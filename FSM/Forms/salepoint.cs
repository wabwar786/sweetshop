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
            loadingHoldBills();
        }
        #endregion

        #region loading hold bills
        private void loadingHoldBills()
        {

            try
            {
                string[] hold_bills = new string[500];
                int i = 0;

                MySqlCommand innzX21122 = new MySqlCommand("select invoice_no from fsm_pos_itemsales_temp where bill_status='Progress' group by invoice_no ", conn);
                innzX21122.ExecuteNonQuery();
                MySqlDataReader rrr1122 = innzX21122.ExecuteReader();
                while (rrr1122.Read())
                {
                    hold_bills[i] = rrr1122["invoice_no"].ToString();
                    i++;
                }
                innzX21122.Dispose();
                rrr1122.Dispose();

                //setting values to buttons

                button1.Text = hold_bills[0];
                button2.Text = hold_bills[1];
                button3.Text = hold_bills[2];
                button4.Text = hold_bills[3];
                button5.Text = hold_bills[4];
                button6.Text = hold_bills[5];
                button7.Text = hold_bills[6];
                button8.Text = hold_bills[7];
                button9.Text = hold_bills[8];

            }
            catch (Exception es)
            {
                
                
            }
            

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

                MySqlCommand innzX2 = new MySqlCommand("select item,qty,retail_price from fsm_mainstore where item like '" + searchItem_textBox.Text+ "%'", conn);
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
                   barcode  = rrr1122["barcode"].ToString();
                  
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
                        MessageBox.Show(this,"Item Quantity is not avaliable Kindly Purchase some Qty!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }

                    MySqlCommand itd = new MySqlCommand("INSERT INTO `fsm_pos_itemsales_temp`( invoice_no,`barcode`, `product_name`, `quantity`, `price`, `bill_status`, `sys_name`, `sys_ip`, `curr_date`, `curr_time`) VALUES ('" + invoice_notextBox.Text+ "','" + barcode + "','" + productName + "','1','" + price + "','" + billStatus + "','" + system_name + "','"+GetIPAddress()+"','" + addingDateTimeStamp() + "','" + addingTimeNow() + "')", conn);
                    itd.ExecuteNonQuery();
                    itd.Dispose();

                    //binding data to gridview
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    string query = "SELECT `barcode`, `product_name`, `quantity`, `price`, `bill_status` FROM `fsm_pos_itemsales_temp` WHERE invoice_no='" + invoice_notextBox.Text+ "'";
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

        #region grid cell end edit events
        private void salesItems_gridview_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (salesItems_gridview.CurrentCell.ColumnIndex == 3)
            {
                string _getBarcode = salesItems_gridview.Rows[e.RowIndex].Cells["Barcode_grid"].Value.ToString();
                string _getItemName = salesItems_gridview.Rows[e.RowIndex].Cells["ProductName_gridview"].Value.ToString();
                string _getQty = salesItems_gridview.Rows[e.RowIndex].Cells["Quantity_gridview"].Value.ToString();
                string _dbQuantity = "";

                MySqlCommand sel = new MySqlCommand("select qty from fsm_mainstore where (barcode='" + _getBarcode + "' and item='" + _getItemName + "')", conn);
                sel.ExecuteNonQuery();
                MySqlDataReader drr = sel.ExecuteReader();
                while (drr.Read())
                {
                    _dbQuantity = drr["qty"].ToString();
                }
                drr.Dispose();
                sel.Dispose();

                double _acturalQuantity = (((Convert.ToDouble(_dbQuantity)) + 1) - (Convert.ToDouble(_getQty)));

                //updating new quantity in main store
                MySqlCommand itd123 = new MySqlCommand("UPDATE fsm_mainstore set qty='" + _acturalQuantity + "' where (item = '" + _getItemName + "' and barcode='" + _getBarcode + "')", conn);
                itd123.ExecuteNonQuery();
                itd123.Dispose();

                //updating new quantity in sale table
                MySqlCommand itd1234 = new MySqlCommand("UPDATE `fsm_pos_itemsales_temp` set quantity='" + _getQty + "' where (product_name = '" + _getItemName + "' and barcode='" + _getBarcode + "' and invoice_no ='"+invoice_notextBox.Text+"')", conn);
                itd1234.ExecuteNonQuery();
                itd1234.Dispose();

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
            }


        }
        #endregion

        #region grid cell click event
        private void salesItems_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int value = e.ColumnIndex;
        }
        #endregion

        #region grid cell content click event
        private void salesItems_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if for deletion

            if (salesItems_gridview.CurrentCell.ColumnIndex == 0)
            {
                string _getBarcode = salesItems_gridview.Rows[e.RowIndex].Cells["Barcode_grid"].Value.ToString();
                string _getItemName = salesItems_gridview.Rows[e.RowIndex].Cells["ProductName_gridview"].Value.ToString();
                string _getQty = salesItems_gridview.Rows[e.RowIndex].Cells["Quantity_gridview"].Value.ToString();

                //Deleting item
                MySqlCommand itd1234 = new MySqlCommand("Delete from `fsm_pos_itemsales_temp` where (product_name = '" + _getItemName + "' and barcode='" + _getBarcode + "' and invoice_no ='" + invoice_notextBox.Text + "')", conn);
                itd1234.ExecuteNonQuery();
                itd1234.Dispose();

                //adding quantity back to main store
                string _dbQuantity = "";

                MySqlCommand sel = new MySqlCommand("select qty from fsm_mainstore where (barcode='" + _getBarcode + "' and item='" + _getItemName + "')", conn);
                sel.ExecuteNonQuery();
                MySqlDataReader drr = sel.ExecuteReader();
                while (drr.Read())
                {
                    _dbQuantity = drr["qty"].ToString();
                }
                drr.Dispose();
                sel.Dispose();

                double _acturalQuantity = (((Convert.ToDouble(_dbQuantity)) + Convert.ToDouble(_getQty)));

                //updating new quantity in main store
                MySqlCommand itd123 = new MySqlCommand("UPDATE fsm_mainstore set qty='" + _acturalQuantity + "' where (item = '" + _getItemName + "' and barcode='" + _getBarcode + "')", conn);
                itd123.ExecuteNonQuery();
                itd123.Dispose();

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
            }
        }
        #endregion

        #region hold bills click action

        string get_invoice_btn = "";
        private void loading_bills( string invoice_number)
        {
            //binding data to gridview
            MySqlDataAdapter sda = new MySqlDataAdapter();
            string query = "SELECT `barcode`, `product_name`, `quantity`, `price`, `bill_status` FROM `fsm_pos_itemsales_temp` WHERE invoice_no='" + invoice_number + "'";
            MySqlCommand command = new MySqlCommand(query, conn);
            sda.SelectCommand = command;
            DataTable table = new DataTable();
            sda.Fill(table);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = table;
            salesItems_gridview.DataSource = bsource;

            invoice_notextBox.Text = invoice_number;
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            get_invoice_btn = button1.Text;

            loading_bills(get_invoice_btn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            get_invoice_btn = button2.Text;

            loading_bills(get_invoice_btn);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            get_invoice_btn = button3.Text;

            loading_bills(get_invoice_btn);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            get_invoice_btn = button4.Text;

            loading_bills(get_invoice_btn);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            get_invoice_btn = button5.Text;

            loading_bills(get_invoice_btn);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            get_invoice_btn = button6.Text;

            loading_bills(get_invoice_btn);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            get_invoice_btn = button7.Text;

            loading_bills(get_invoice_btn);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            get_invoice_btn = button8.Text;

            loading_bills(get_invoice_btn);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            get_invoice_btn = button9.Text;

            loading_bills(get_invoice_btn);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            get_invoice_btn = button10.Text;

            loading_bills(get_invoice_btn);
        }
        #endregion
    }

}
