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

                    MySqlCommand itd = new MySqlCommand("INSERT INTO `fsm_pos_itemsales_temp`( `barcode`, `product_name`, `quantity`, `price`, `bill_status`, `sys_name`, `sys_ip`, `curr_date`, `curr_time`) VALUES ('" + barcode + "','" + productName + "','" + qty + "','" + price + "','" + billStatus + "','" + system_name + "','" + addingDateTimeStamp() + "','"+addingTimeNow()+"')", conn);
                    itd.ExecuteNonQuery();
                    itd.Dispose();

                    //binding data to gridview
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    string query = "SELECT `barcode`, `product_name`, `quantity`, `price`, `bill_status` FROM `fsm_pos_itemsales_temp` WHERE ";
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
    }

}
