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
    public partial class quick_sale_creation : Form
    {
        MySqlConnection conn = null;
        string system_name = System.Environment.MachineName;

        public quick_sale_creation()
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

        #region adding item names to combobox
        private void itemNames()
        {
            itemNameCombobox.Items.Clear();
            MySqlCommand sel = new MySqlCommand("select distinct(item) from fsm_mainstore where branch_n='" + Login.branch + "' ", conn);
            sel.ExecuteNonQuery();
            MySqlDataReader drr = sel.ExecuteReader();
            while (drr.Read())
            {
                itemNameCombobox.Items.Add(drr["item"].ToString());

            }
            drr.Dispose();
            sel.Dispose();

        }
        #endregion

        #region adding item barcode to combobox
        private void itemsBarcode()
        {
            barcodeCombobox.Items.Clear();
            MySqlCommand sel = new MySqlCommand("select distinct(barcode) from fsm_mainstore where branch_n='" + Login.branch + "' ", conn);
            sel.ExecuteNonQuery();
            MySqlDataReader drr = sel.ExecuteReader();
            while (drr.Read())
            {
                barcodeCombobox.Items.Add(drr["barcode"].ToString());

            }
            drr.Dispose();
            sel.Dispose();

        }
        #endregion

        #region form load
        private void quick_sale_creation_Load(object sender, EventArgs e)
        {
            itemNames();
            itemsBarcode();
            laodingGridView();
        }
        #endregion

        #region DataGridView Binding
        private void laodingGridView()
        {
            MySqlDataAdapter sda = new MySqlDataAdapter();
            string query = "SELECT `barcode`, `item_name` FROM `fsm_quick_Sale` WHERE branch='" + Login.branch + "'";
            MySqlCommand command = new MySqlCommand(query, conn);
            sda.SelectCommand = command;
            DataTable table = new DataTable();
            sda.Fill(table);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = table;
            quickSaleGridview.DataSource = bsource;
        }
        #endregion

        private void savebtn_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO `fsm_quick_sale`( `barcode`, `item_name`,  `branch`) VALUES ('"+barcodeCombobox.Text+"','"+itemNameCombobox.Text+"','"+Login.branch+"')";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.ExecuteNonQuery();
            command.Dispose();

            laodingGridView();
            MessageBox.Show(this, "Quick Sale item is Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            itemNameCombobox.Text = "";
            barcodeCombobox.Text = "";

            itemNameCombobox.Focus();
        }

        private void barcodeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand sel=null;
             MySqlDataReader drr=null;
            try
            {
                 sel = new MySqlCommand("select item  from fsm_mainstore where branch_n='" + Login.branch + "' and barcode ='" + barcodeCombobox.Text + "' ", conn);
                sel.ExecuteNonQuery();
                drr = sel.ExecuteReader();
                while (drr.Read())
                {
                    itemNameCombobox.Text = drr["item"].ToString();

                }
                drr.Dispose();
                sel.Dispose();
            }
            catch (Exception es)
            {
                //MessageBox.Show(es.Message);
            }
            finally
            {
                //drr.Dispose();
                //sel.Dispose();
            }
           
           
        }

        private void itemNameCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand sel = null;
            MySqlDataReader drr = null;

            try
            {
                 sel = new MySqlCommand("select barcode  from fsm_mainstore where branch_n='" + Login.branch + "' and item ='" + itemNameCombobox.Text + "' ", conn);
                sel.ExecuteNonQuery();
                 drr = sel.ExecuteReader();
                while (drr.Read())
                {
                    barcodeCombobox.Text = drr["barcode"].ToString();

                }

                drr.Dispose();
                sel.Dispose();
            }
            catch (Exception es)
            {
                //MessageBox.Show(es.Message);
            }
            finally
            {
                //drr.Dispose();
                //sel.Dispose();
            }
             
           
        }

        private void quickSaleGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            barcodeCombobox.Text = quickSaleGridview.Rows[e.RowIndex].Cells["barcodeGridveiw"].Value.ToString();
            itemNameCombobox.Text = quickSaleGridview.Rows[e.RowIndex].Cells["itemNamegridview"].Value.ToString();

        }

        private void quickSaleGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            barcodeCombobox.Text = quickSaleGridview.Rows[e.RowIndex].Cells["barcodeGridveiw"].Value.ToString();
            itemNameCombobox.Text = quickSaleGridview.Rows[e.RowIndex].Cells["itemNamegridview"].Value.ToString();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM fsm_quick_sale where branch='" + Login.branch + "' and barcode='" + barcodeCombobox.Text + "' and item_name='" + itemNameCombobox.Text + "'";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.ExecuteNonQuery();
            command.Dispose();
            MessageBox.Show(this, "Quick Sale item is Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            itemNameCombobox.Text = "";
            barcodeCombobox.Text = "";
            itemNameCombobox.Focus();
            laodingGridView();
        }
    }
}
