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
    public partial class deals_creation : Form
    {
        MySqlConnection conn = null;
        string system_name = System.Environment.MachineName;

        #region cunstructor
        public deals_creation()
        {
            InitializeComponent();

            string connectorstr = ConfigurationSettings.AppSettings["ConnectionString"];
            conn = new MySqlConnection(connectorstr);
            connection_check();
        }
        #endregion

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

        #region new button code
        private void newbtn_Click(object sender, EventArgs e)
        {
            dealNumbertextBox.Enabled = true;
            dealNametxt.Enabled = true;
            itemNametxt.Enabled = true;
            quantitytxt.Enabled = true;

            dealNumbertextBox.Text = "";
            dealNametxt.Text = "";
            itemNametxt.Text = "";
            quantitytxt.Text = "";
            savebtn.Text = "SAVE";
            savebtn.ForeColor = Color.White;
            //savebtn.BackColor = Color.White;
            dealNumbertextBox.Focus();
        }
        #endregion

        #region DataGridView Binding
        private void laodingGridView()
        {
            MySqlDataAdapter sda = new MySqlDataAdapter();
            string query = "SELECT `deal_number`, `deal_name`, `item_name`, `quantity` FROM `fsm_deals` WHERE branch='"+Login.branch+"'";
            MySqlCommand command = new MySqlCommand(query, conn);
            sda.SelectCommand = command;
            DataTable table = new DataTable();
            sda.Fill(table);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = table;
            dealsGridview.DataSource = bsource;
        }
        #endregion

        #region Form load Event
        private void deals_creation_Load(object sender, EventArgs e)
        {
            laodingGridView();
            save_deals();
            itemNames();
        }
        #endregion

        #region save button code
        private void savebtn_Click(object sender, EventArgs e)
        {
            if (savebtn.Text == "SAVE")
            {
                string query = "INSERT INTO `fsm_deals`(`deal_number`, `deal_name`, `item_name`, `quantity`, `branch`, `sys_name`, `sys_ip`, `curr_time`, `curr_date`) VALUES ('" + dealNumbertextBox.Text + "','" + dealNametxt.Text + "','" + itemNametxt.Text + "','" + quantitytxt.Text + "','" + Login.branch + "','" + system_name + "','" + GetIPAddress() + "','" + addingDateTimeStamp() + "','" + addingTimeNow() + "')";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                MessageBox.Show(this, "Deal is Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string query = "UPDATE `fsm_deals` SET `item_name`='" + itemNametxt.Text + "',`quantity`='" + quantitytxt.Text + "' WHERE branch='" + Login.branch + "'and deal_number = '"+dealNumbertextBox.Text+"'and deal_name='"+dealNametxt.Text+"'";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                MessageBox.Show(this, "Deal is Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            dealNumbertextBox.Text= "";
            dealNametxt.Text = "";
            itemNametxt.Text = "";
            quantitytxt.Text = "";

            dealNumbertextBox.Enabled = false;
            dealNametxt.Enabled = false;
            itemNametxt.Enabled = false;
            quantitytxt.Enabled = false;

            newbtn.Focus();
            laodingGridView();

            savebtn.Text = "SAVE";
            savebtn.ForeColor = Color.White;
            //savebtn.BackColor = Color.White;
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

        #region adding existing deals to combobox
        private void save_deals()
        {
            saveDealstxt.Items.Clear();
            MySqlCommand sel = new MySqlCommand("select distinct(deal_name) from fsm_deals where branch='" + Login.branch + "' ", conn);
            sel.ExecuteNonQuery();
            MySqlDataReader drr = sel.ExecuteReader();
            while (drr.Read())
            {
                saveDealstxt.Items.Add(drr["deal_name"].ToString());

            }
            drr.Dispose();
            sel.Dispose();

        }
        #endregion

        #region adding item names from main store
        private void itemNames()
        {
            itemNametxt.Items.Clear();
            MySqlCommand sel = new MySqlCommand("SELECT ITEM FROM fsm_mainstore WHERE BRANCH_N='"+Login.branch+"'", conn);
            sel.ExecuteNonQuery();
            MySqlDataReader drr = sel.ExecuteReader();
            while (drr.Read())
            {
                itemNametxt.Items.Add(drr["ITEM"].ToString());

            }
            drr.Dispose();
            sel.Dispose();

        }
        #endregion

        #region delete button code
        private void deletebtn_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM fsm_deals where branch='" + Login.branch + "' and deal_name='" + dealNametxt.Text + "' and item_name='" + itemNametxt.Text + "' and quantity='" + quantitytxt.Text + "'";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.ExecuteNonQuery();
            command.Dispose();
            MessageBox.Show(this, "Deal item is Successfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dealNumbertextBox.Enabled = false;
            dealNametxt.Enabled = false;
            itemNametxt.Enabled = false;
            quantitytxt.Enabled = false;
            laodingGridView();
        }
        #endregion

        #region data gridveiw click event
        private void dealsGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dealNumbertextBox.Enabled = true;
            //dealNametxt.Enabled = true;
            itemNametxt.Enabled = true;
            quantitytxt.Enabled = true;

            deletebtn.Focus();

            dealNumbertextBox.Text = dealsGridview.Rows[e.RowIndex].Cells["dealnumberGrid"].Value.ToString();
            dealNametxt.Text = dealsGridview.Rows[e.RowIndex].Cells["dealNameGrid"].Value.ToString();
            itemNametxt.Text = dealsGridview.Rows[e.RowIndex].Cells["itemNameGird"].Value.ToString();
            quantitytxt.Text = dealsGridview.Rows[e.RowIndex].Cells["quantityGird"].Value.ToString();

            savebtn.Text = "UPDATE";
            savebtn.ForeColor = Color.Yellow;
            savebtn.BackColor = Color.Black;
        }
        #endregion

        #region search existing deals
        private void saveDealstxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter();
            string query = "SELECT `deal_number`, `deal_name`, `item_name`, `quantity` FROM `fsm_deals` WHERE branch='" + Login.branch + "' and deal_name like '"+saveDealstxt.Text+"%'";
            MySqlCommand command = new MySqlCommand(query, conn);
            sda.SelectCommand = command;
            DataTable table = new DataTable();
            sda.Fill(table);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = table;
            dealsGridview.DataSource = bsource;
        }
        #endregion

    }
}
