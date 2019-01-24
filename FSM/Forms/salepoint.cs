using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Net.Sockets;

namespace FSM.Forms
{
    public partial class salepoint : Form
    {
        MySqlConnection conn = null;
        string system_name = System.Environment.MachineName;

        public salepoint()
        {
            InitializeComponent();
            string connectorstr = ConfigurationSettings.AppSettings["ConnectionString"];
            conn = new MySqlConnection(connectorstr);
            connection_check();
        }

        #region Check Conenction Method
        private void connection_check()
        {

            if (conn.State == ConnectionState.Open)
            {
            }
            else
            {
                conn.Open();
            }

        }
        #endregion

        #region Sale point Form load;
        private void salepoint_Load(object sender, EventArgs e)
        {
            load_Products_listview();
            invoice_notextBox.Text = uniqueID();
        }
        #endregion

        #region Loading listview item Names;
        private void load_Products_listview()
        {
            MySqlCommand innzX21122 = new MySqlCommand("select item,qty,retail_price from fsm_mainstore", conn);
            innzX21122.ExecuteNonQuery();
            MySqlDataReader rrr1122 = innzX21122.ExecuteReader();
            while (rrr1122.Read())
            {

                ListViewItem item = new ListViewItem(rrr1122["item"].ToString());
                item.SubItems.Add(rrr1122["retail_price"].ToString());
                item.SubItems.Add(rrr1122["qty"].ToString());
                Items_listView.Items.Add(item);
            }
            innzX21122.Dispose();
            rrr1122.Dispose();

        }
        #endregion

        #region searching list view
        private void searchItem_textBox_TextChanged(object sender, EventArgs e)
        {
            if (searchItem_textBox.Text != "")
            {

                Items_listView.Items.Clear();
                Items_listView.Visible = true;

                MySqlCommand innzX2 = new MySqlCommand("select item,qty,retail_price from fsm_mainstore where item like '" + searchItem_textBox.Text + "%'", conn);
                innzX2.ExecuteNonQuery();
                MySqlDataReader rrr11 = innzX2.ExecuteReader();
                while (rrr11.Read())
                {
                    ListViewItem item = new ListViewItem(rrr11["item"].ToString());
                    item.SubItems.Add(rrr11["retail_price"].ToString());
                    item.SubItems.Add(rrr11["qty"].ToString());
                    Items_listView.Items.Add(item);
                }
                rrr11.Dispose();
                innzX2.Dispose();

                //Items_listView.Focus();

                //foreach(string str in Items_listView.Items)
                //{
                //    if (str.ToUpper().Contains(searchItem_textBox.Text.ToUpper()))
                //    {
                //        Items_listView.Items.Add(str);
                //    }
                //}


                //Items_listView.Items.AddRange(Items.Cast<String>().Where(X => X.StartsWith(searchItem_textBox.Text)).ToArray());
                //for (int i = Items_listView.Items.Count - 1; i >= 0; i--)
                //{
                //    var item = Items_listView.Items[i];
                //    if (item.Text.ToLower().Contains(searchItem_textBox.Text.ToLower()))
                //    {
                //        item.BackColor = SystemColors.Highlight;
                //        item.ForeColor = SystemColors.HighlightText;
                //    }
                //    else
                //    {
                //        Items_listView.Items.Remove(item);
                //    }
                //}
                //if (Items_listView.SelectedItems.Count == 1)
                //{
                //    Items_listView.Focus();
                //}
            }
        }
        #endregion

        #region Search item text change event
        private void Items_listView_KeyDown(object sender, KeyEventArgs e)
        {
            string barcode = "";

            if (e.KeyCode == Keys.Enter)
            {
                ListViewItem item = Items_listView.SelectedItems[0];
                string itemName = item.SubItems[0].Text;

                MySqlCommand innzX21122 = new MySqlCommand("select barcode from fsm_mainstore where item = '" + itemName + "'", conn);
                innzX21122.ExecuteNonQuery();
                MySqlDataReader rrr1122 = innzX21122.ExecuteReader();
                while (rrr1122.Read())
                {
                    barcode = rrr1122["barcode"].ToString();

                }
                rrr1122.Dispose();
                innzX21122.Dispose();


                searchItem_textBox.Text = barcode;
                searchItem_textBox.Focus();
                Items_listView.Visible = false;
            }
        }
        #endregion

        #region getting system ip and current date and time
        private string uniqueID()
        {
            DateTime date = DateTime.Now;

            string uniqueID = String.Format(
              "{0:0000}{1:00}{2:00}{3:00}{4:00}POS",
              date.Year, date.Month, date.Day,
              date.Hour, date.Minute
              );

            return uniqueID;

        }

        private string addingDateTimeStamp()
        {

            DateTime now = DateTime.Now;
            string date = now.GetDateTimeFormats('d')[0];
            string time = now.GetDateTimeFormats('t')[0];

            // MessageBox.Show(date.ToString());
            return date.ToString();

        }

        public static System.Net.IPAddress GetIPAddress()      //get the ip adress of system
        {
            System.Net.IPAddress ip = System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName()).Where(address =>
            address.AddressFamily == AddressFamily.InterNetwork).First();
            return ip;
            //getip

        }

        private string addingTimeNow()
        {

            DateTime now = DateTime.Now;
            string date = now.GetDateTimeFormats('d')[0];
            string time = now.GetDateTimeFormats('t')[0];

            // MessageBox.Show(time.ToString());
            return time.ToString();

        }
        #endregion

        #region adding items to gridview List
        private void searchItem_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barcode = "";
                string productName = "";
                string qty = "";
                string price = "";
                string billStatus = "";

                //int rowIndex = salesItems_gridview.Rows.Add();
                //var row = salesItems_gridview.Rows[rowIndex];
                //row.Cells[2].Value = searchItem_textBox.Text;

                //adding data to others cells

                //string cellValue = salesItems_gridview.Rows[rowIndex].Cells[2].Value.ToString();
                MySqlCommand sel = new MySqlCommand("select item,qty,retail_price,barcode from fsm_mainstore where barcode='" + searchItem_textBox.Text + "'", conn);
                sel.ExecuteNonQuery();
                MySqlDataReader drr = sel.ExecuteReader();
                while (drr.Read())
                {
                    barcode = drr["barcode"].ToString();
                    productName = drr["item"].ToString();
                    qty = drr["qty"].ToString();
                    price = drr["retail_price"].ToString();
                    billStatus = "Progress";
                }
                drr.Dispose();
                sel.Dispose();

                if (qty == "0")
                {
                    MessageBox.Show(this, "Item Quantity is not avaliable Kindly Purchase some Qty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MySqlCommand itd = new MySqlCommand("INSERT INTO `fsm_pos_itemsales_temp`( invoice_no,`barcode`, `product_name`, `quantity`, `price`, `bill_status`, `sys_name`, `sys_ip`, `curr_date`, `curr_time`) VALUES ('" + invoice_notextBox.Text + "','" + barcode + "','" + productName + "','1','" + price + "','" + billStatus + "','" + system_name + "','" + GetIPAddress() + "','" + addingDateTimeStamp() + "','" + addingTimeNow() + "')", conn);
                itd.ExecuteNonQuery();
                itd.Dispose();

                //binding data to gridview
                MySqlDataAdapter sda = new MySqlDataAdapter();
                string query = "SELECT `barcode`, `product_name`, `quantity`, `price`, `bill_status` FROM `fsm_pos_itemsales_temp` WHERE invoice_no='" + invoice_notextBox.Text + "'";
                MySqlCommand command = new MySqlCommand(query, conn);
                sda.SelectCommand = command;
                DataTable table = new DataTable();
                sda.Fill(table);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = table;
                salesItems_gridview.DataSource = bsource;

                //deducting quantity from Main-store

                qty = (Convert.ToDouble(qty) - 1).ToString();

                //updating new quantity
                MySqlCommand itd123 = new MySqlCommand("UPDATE fsm_mainstore set qty='" + qty + "' where (item = '" + productName + "' and barcode='" + barcode + "')", conn);
                itd123.ExecuteNonQuery();
                itd123.Dispose();

            }
        }
        #endregion

        private void salesItems_gridview_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (salesItems_gridview.CurrentCell.ColumnIndex == 3)
            {
                string _getQty = salesItems_gridview.Rows[e.RowIndex].Cells["Quantity_gridview"].Value.ToString();

            }
        }

        private void salesItems_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int value = e.ColumnIndex;
        }

        private void trial_for_balancesheet()
        {
            try
            {
                _checkConnection();

                #region Calculating Balance Sheet

                bool apOpeningExist = false, inventoryOpeningExist = false, apExist = false, inventoryExist = false;
                DataSet _mainSubTypeHeads = MySqlHelpers.ExecuteDataSet(connection, CommandType.Text, "select DISTINCT account_type,account_subtype from account_signup");
                DataSet _trialBalance = MySqlHelpers.ExecuteDataSet(connection, CommandType.Text, "select * from albert_trial_balance where client_code=0");
                Double _vatPayableObCR = 0, _vatPayableObDR = 0, _vatPayableActCR = 0, _vatPayableActDR = 0, _vatPayableCbCR = 0, _vatPayableCbDR = 0;
                for (int i = 0; i < _mainSubTypeHeads.Tables[0].Rows.Count; i++)
                {

                    #region Closings
                    List<AccountHead> openingAccounts = new List<AccountHead>();
                    string accountSubType = _mainSubTypeHeads.Tables[0].Rows[i]["account_subtype"].ToString();
                    if (accountSubType != "Sales" && accountSubType != "Expense")//no openings
                    {
                        //all accounts again accountSubtype
                        openingAccounts = AccountsHelper.getAllHeadsSumCRDRAgainstAccountSubTypeTillDate(connection, accountSubType, dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                        foreach (var item in openingAccounts)
                        {
                            _trialBalance.Tables[0].Rows.Add();
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["account_type"] = accountSubType;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["account_name"] = item.account;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["act_dr"] = 0;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["act_cr"] = 0;
                            if (accountSubType.ToLower() == "current assets" || accountSubType.ToLower() == "non current assets" || accountSubType.ToLower() == "fixed assets" || accountSubType.ToLower() == "expense")
                            {//Debit Heads
                                if (item.account == "A/R" || item.account == "A/P" || item.account == "Cash" || item.account == "Bank")
                                {
                                    if (item.sumDebitGross - item.sumCreditGross >= 0)
                                    {
                                        _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_dr"] = item.sumDebitGross - item.sumCreditGross;
                                        _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_cr"] = 0;
                                        _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_dr"] = item.sumDebitGross - item.sumCreditGross;
                                        _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_cr"] = 0;
                                    }
                                    else
                                    {
                                        _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_cr"] = -1 * (item.sumDebitGross - item.sumCreditGross);
                                        _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_dr"] = 0;
                                        _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_cr"] = -1 * (item.sumDebitGross - item.sumCreditGross);
                                        _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_dr"] = 0;
                                    }

                                }
                                else
                                {
                                    double _inventoryInvDeb = 0, _inventoryInvVatPayable = 0;
                                    if (item.account == "Inventories")
                                    {
                                        inventoryOpeningExist = true;
                                        List<AccountHead> _apList = AccountsHelper.getAPHeadFromInventoryTillDate(connection, dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                                        _inventoryInvDeb = _inventoryInvDeb + _apList.FirstOrDefault().sumCredit;
                                        _inventoryInvVatPayable = _inventoryInvVatPayable + _apList.FirstOrDefault().sumCreditGross - _apList.FirstOrDefault().sumCredit;
                                        if (item.sumDebit + _inventoryInvDeb - item.sumCredit >= 0)
                                        {
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_dr"] = item.sumDebit + _inventoryInvDeb - item.sumCredit;
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_cr"] = 0;
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_dr"] = item.sumDebit + _inventoryInvDeb - item.sumCredit;
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_cr"] = 0;
                                        }
                                        else
                                        {
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_cr"] = -1 * (item.sumDebit + _inventoryInvDeb - item.sumCredit);
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_dr"] = 0;
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_cr"] = -1 * (item.sumDebit + _inventoryInvDeb - item.sumCredit);
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_dr"] = 0;
                                        }
                                        _vatPayableObDR = Math.Round(_vatPayableObDR + _inventoryInvVatPayable + item.sumDebitGross - item.sumDebit, 2);
                                        _vatPayableObCR = Math.Round(_vatPayableObCR + item.sumCreditGross - item.sumCredit, 2);
                                    }
                                    else
                                    {
                                        if (item.sumDebit - item.sumCredit >= 0)
                                        {
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_dr"] = item.sumDebit - item.sumCredit;
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_cr"] = 0;
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_dr"] = item.sumDebit - item.sumCredit;
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_cr"] = 0;
                                        }
                                        else
                                        {
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_cr"] = -1 * (item.sumDebit - item.sumCredit);
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_dr"] = 0;
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_cr"] = -1 * (item.sumDebit - item.sumCredit);
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_dr"] = 0;
                                        }
                                    }
                                    _vatPayableObDR = Math.Round(_vatPayableObDR + item.sumDebitGross - item.sumDebit, 2);
                                    _vatPayableObCR = Math.Round(_vatPayableObCR + item.sumCreditGross - item.sumCredit, 2);
                                }

                            }
                            else
                            {//Credit Heads
                                if (item.account == "A/R" || item.account == "A/P" || item.account == "Cash" || item.account == "Bank")
                                {
                                    double _inventoryAP = 0;
                                    if (item.account == "A/P")
                                    {
                                        apOpeningExist = true;
                                        List<AccountHead> _apList = AccountsHelper.getAPHeadFromInventoryTillDate(connection, dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                                        _inventoryAP = _inventoryAP + _apList.FirstOrDefault().sumCreditGross;
                                        if (item.sumCreditGross + _inventoryAP - item.sumDebit >= 0)
                                        {
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_cr"] = item.sumCreditGross + _inventoryAP - item.sumDebitGross;
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_dr"] = 0;
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_cr"] = item.sumCreditGross + _inventoryAP - item.sumDebitGross;
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_dr"] = 0;
                                        }
                                        else
                                        {
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_dr"] = -1 * (item.sumCreditGross + _inventoryAP - item.sumDebitGross);
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_cr"] = 0;
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_dr"] = -1 * (item.sumCreditGross + _inventoryAP - item.sumDebitGross);
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_cr"] = 0;
                                        }
                                    }
                                    else
                                    {
                                        if (item.sumCreditGross - item.sumDebit >= 0)
                                        {
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_cr"] = item.sumCreditGross - item.sumDebitGross;
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_dr"] = 0;
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_cr"] = item.sumCreditGross - item.sumDebitGross;
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_dr"] = 0;
                                        }
                                        else
                                        {
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_dr"] = -1 * (item.sumCreditGross - item.sumDebitGross);
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_cr"] = 0;
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_dr"] = -1 * (item.sumCreditGross - item.sumDebitGross);
                                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_cr"] = 0;
                                        }
                                    }



                                }
                                else
                                {

                                    if (item.sumCredit - item.sumDebit >= 0)
                                    {
                                        _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_cr"] = item.sumCredit - item.sumDebit;
                                        _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_dr"] = 0;
                                        _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_cr"] = item.sumCredit - item.sumDebit;
                                        _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_dr"] = 0;
                                    }
                                    else
                                    {
                                        _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_dr"] = -1 * (item.sumCredit - item.sumDebit);
                                        _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_cr"] = 0;
                                        _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_dr"] = -1 * (item.sumCredit - item.sumDebit);
                                        _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_cr"] = 0;
                                    }
                                    _vatPayableObDR = Math.Round(_vatPayableObDR + item.sumDebitGross - item.sumDebit, 2);
                                    _vatPayableObCR = Math.Round(_vatPayableObCR + item.sumCreditGross - item.sumCredit, 2);
                                }
                            }
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["month"] = DateTime.Today.ToString("MM");
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["year"] = DateTime.Today.ToString("yyyy");
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["client_code"] = mainfrm.client_code;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["date"] = DateTime.UtcNow.ToString("yyyy-MM-dd");
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["time"] = string.Format("{0:hh:mm:ss tt}", DateTime.UtcNow);
                        }
                    }
                    else
                    {
                        openingAccounts = AccountsHelper.getAllHeadsSumCRDRAgainstAccountSubTypeTillDate(connection, accountSubType, dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                        foreach (var item in openingAccounts)
                        {
                            _trialBalance.Tables[0].Rows.Add();
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["account_type"] = accountSubType;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["account_name"] = item.account;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_dr"] = 0;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_cr"] = 0;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["act_dr"] = 0;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["act_cr"] = 0;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_dr"] = 0;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_cr"] = 0;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["month"] = DateTime.Today.ToString("MM");
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["year"] = DateTime.Today.ToString("yyyy");
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["client_code"] = mainfrm.client_code;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["date"] = DateTime.UtcNow.ToString("yyyy-MM-dd");
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["time"] = string.Format("{0:hh:mm:ss tt}", DateTime.UtcNow);
                            _vatPayableObDR = Math.Round(_vatPayableObDR + item.sumDebitGross - item.sumDebit, 2);
                            _vatPayableObCR = Math.Round(_vatPayableObCR + item.sumCreditGross - item.sumCredit, 2);
                        }

                    }

                    #region Check if Opening in Inventory but not in Accounts for A/P and Inventories

                    List<AccountHead> _apListNewOp = AccountsHelper.getAPHeadFromInventoryTillDate(connection, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    if (_apListNewOp.Count > 0)
                    {
                        if (!inventoryOpeningExist && accountSubType == "Current Assets")
                        {
                            #region Inventory Entry
                            inventoryOpeningExist = true;
                            double _inventoryInvDeb = _apListNewOp.FirstOrDefault().sumCredit;
                            double _inventoryInvVatPayable = _apListNewOp.FirstOrDefault().sumCreditGross - _apListNewOp.FirstOrDefault().sumCredit;
                            _trialBalance.Tables[0].Rows.Add();
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["account_type"] = "Current Assets";
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["account_name"] = "Inventories";
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["act_dr"] = 0;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["act_cr"] = 0;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_dr"] = _inventoryInvDeb;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_cr"] = 0;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_dr"] = _inventoryInvDeb;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_cr"] = 0;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["month"] = DateTime.Today.ToString("MM");
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["year"] = DateTime.Today.ToString("yyyy");
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["client_code"] = mainfrm.client_code;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["date"] = DateTime.UtcNow.ToString("yyyy-MM-dd");
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["time"] = string.Format("{0:hh:mm:ss tt}", DateTime.UtcNow);
                            _vatPayableObDR = Math.Round(_vatPayableObDR + _inventoryInvVatPayable, 2);

                            #endregion
                        }
                        if (!apOpeningExist && accountSubType == "Current Liability")
                        {
                            #region AP Entry
                            apOpeningExist = true;
                            double _inventoryAP = _apListNewOp.FirstOrDefault().sumCreditGross;
                            _trialBalance.Tables[0].Rows.Add();
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["account_type"] = "Current Liability";
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["account_name"] = "A/P";
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["act_dr"] = 0;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["act_cr"] = 0;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_cr"] = _inventoryAP;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["ob_dr"] = 0;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_cr"] = _inventoryAP;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["cb_dr"] = 0;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["month"] = DateTime.Today.ToString("MM");
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["year"] = DateTime.Today.ToString("yyyy");
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["client_code"] = mainfrm.client_code;
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["date"] = DateTime.UtcNow.ToString("yyyy-MM-dd");
                            _trialBalance.Tables[0].Rows[_trialBalance.Tables[0].Rows.Count - 1]["time"] = string.Format("{0:hh:mm:ss tt}", DateTime.UtcNow);

                            #endregion
                        }
                    }

                    #endregion

                    #endregion
                }

                #endregion


                #region Building queries and Db Entries

                string query = "", account_type = "0", account_name = "0", ob_dr = "0", ob_cr = "0", act_dr = "0", act_cr = "0", cb_dr = "0", cb_cr = "0";
                for (int i = 0; i < _trialBalance.Tables[0].Rows.Count; i++)
                {


                    account_type = _trialBalance.Tables[0].Rows[i]["account_type"].ToString();
                    account_name = _trialBalance.Tables[0].Rows[i]["account_name"].ToString();
                    ob_dr = _trialBalance.Tables[0].Rows[i]["ob_dr"].ToString();
                    ob_cr = _trialBalance.Tables[0].Rows[i]["ob_cr"].ToString();
                    act_dr = _trialBalance.Tables[0].Rows[i]["act_dr"].ToString();
                    act_cr = _trialBalance.Tables[0].Rows[i]["act_cr"].ToString();
                    cb_dr = _trialBalance.Tables[0].Rows[i]["cb_dr"].ToString();
                    cb_cr = _trialBalance.Tables[0].Rows[i]["cb_cr"].ToString();

                    query = query + "insert into albert_trial_balance(account_type,account_name,ob_dr,ob_cr,act_dr,act_cr,cb_dr,cb_cr,month,year,client_code,date,time,pcname) values('" + account_type + "','" + account_name + "','" + ob_dr + "','" + ob_cr + "','" + act_dr + "','" + act_cr + "','" + cb_dr + "','" + cb_cr + "','" + DateTime.Today.ToString("MM") + "','" + DateTime.Today.ToString("yyyy") + "','" + mainfrm.client_code + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss") + "','" + pcName + "');";

                }

                //Calculating Commulative Profit
                account_type = "Retained Earnings";
                account_name = "Accomulated Profit";
                ob_cr = "0"; ob_dr = "0"; act_dr = "0"; act_cr = "0"; cb_dr = "0"; cb_cr = "0";
                double acc_profit = AccountsHelper.calculateAccomolativeProfitTillDate(connection, dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                if (acc_profit >= 0)
                {
                    ob_cr = Convert.ToString(acc_profit);
                }
                else
                {
                    ob_dr = Convert.ToString(-1 * acc_profit);
                }
                if (double.Parse(ob_cr) - double.Parse(ob_dr) >= 0)
                    cb_cr = Convert.ToString(double.Parse(ob_cr) - double.Parse(ob_dr));
                else
                    cb_dr = Convert.ToString(-1 * (double.Parse(ob_cr) - double.Parse(ob_dr)));

                query = query + "insert into albert_trial_balance(account_type,account_name,ob_dr,ob_cr,act_dr,act_cr,cb_dr,cb_cr,month,year,client_code,date,time,pcname) values('" + account_type + "','" + account_name + "','" + ob_dr + "','" + ob_cr + "','" + act_dr + "','" + act_cr + "','" + cb_dr + "','" + cb_cr + "','" + DateTime.Today.ToString("MM") + "','" + DateTime.Today.ToString("yyyy") + "','" + mainfrm.client_code + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss") + "','" + pcName + "');";

                //Calculating/ Entry Vat Payable
                account_type = "Current Liability";
                account_name = "Vat Payable";
                //vat is CR account head

                if (_vatPayableObCR + _vatPayableActCR - _vatPayableObDR - _vatPayableActDR >= 0)
                {
                    _vatPayableCbCR = _vatPayableObCR + _vatPayableActCR - _vatPayableObDR - _vatPayableActDR;
                    _vatPayableCbDR = 0;
                }
                else
                {
                    _vatPayableCbDR = (-1 * (_vatPayableObCR + _vatPayableActCR - _vatPayableObDR - _vatPayableActDR));
                    _vatPayableCbCR = 0;
                }
                if (_vatPayableObCR - _vatPayableObDR >= 0)
                {
                    _vatPayableObCR = _vatPayableObCR - _vatPayableObDR;
                    _vatPayableObDR = 0;
                }
                else
                {
                    _vatPayableObDR = (-1 * (_vatPayableObCR - _vatPayableObDR));
                    _vatPayableObCR = 0;
                }
                query = query + "insert into albert_trial_balance(account_type,account_name,ob_dr,ob_cr,act_dr,act_cr,cb_dr,cb_cr,month,year,client_code,date,time,pcname) values('" + account_type + "','" + account_name + "','" + _vatPayableObDR.ToString("0.##") + "','" + _vatPayableObCR.ToString("0.##") + "','" + _vatPayableActDR.ToString("0.##") + "','" + _vatPayableActCR.ToString("0.##") + "','" + _vatPayableCbDR.ToString("0.##") + "','" + _vatPayableCbCR.ToString("0.##") + "','" + DateTime.Today.ToString("MM") + "','" + DateTime.Today.ToString("yyyy") + "','" + mainfrm.client_code + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss") + "','" + pcName + "');";


                //Db Entries
                MySqlHelpers.ExecuteNonQuery(connection, CommandType.Text, "delete from albert_trial_balance where ((client_code='" + mainfrm.client_code + "')and(pcname='" + pcName + "'))");
                MySqlHelpers.ExecuteNonQuery(connection, CommandType.Text, query);



                #endregion


              
            }
            catch (Exception oo)
            {
                MessageBox.Show(oo.Message);
            }
        }
    }

}
