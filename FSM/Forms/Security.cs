using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Configuration;
using System.Drawing.Imaging;
using System.Net;
using System.Text.RegularExpressions;
namespace FSM
{
    public partial class Security : Form
    {
        string base64String = "";
        string pics = "";
        public static string connectionstr = ConfigurationSettings.AppSettings["ConnectionString"];
        MySqlConnection conn = new MySqlConnection(connectionstr);
        public Security()
        {
            InitializeComponent();
        }

        private void Security_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("connected");
            }
            MySqlCommand Crole23 = new MySqlCommand("select user_name from fsm_signup order by user_name asc ", conn);
            Crole23.ExecuteNonQuery();
            MySqlDataReader rd23 = Crole23.ExecuteReader();
            while (rd23.Read())
            {
                tex_user.Items.Add(rd23[0].ToString());

            }
            rd23.Dispose();
            lview();

        }
        private void lview()
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {


            }
            try
            {
                listView1.View = View.Details;
                listView1.Items.Clear();

                MySqlDataAdapter rrx = new MySqlDataAdapter("select user_name,tabs from fsm_security ", conn);
                DataTable dtx = new DataTable();
                rrx.Fill(dtx);
                for (int i = 0; i < dtx.Rows.Count; i++)
                {

                    DataRow dr = dtx.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["user_name"].ToString());
                    listitem.SubItems.Add(dr["tabs"].ToString());
                    listView1.Items.Add(listitem);
                }
                dtx.Dispose();
                rrx.Dispose();

            }
            catch (Exception ex)
            {


            }


        }

        private void listView1_Click(object sender, EventArgs e)
        {
            try
            {

                tex_id.Text = listView1.SelectedItems[0].SubItems[0].Text;
                tex_user.Text = listView1.SelectedItems[0].SubItems[1].Text;

            }
            catch (Exception ex)
            {

                // MessageBox.Show(ex.Message);
            }
        }

        private void rolebox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            tex_id.Text = string.Empty;
            tex_user.Text = string.Empty;
            rolebox.Text = string.Empty;
            
            btn_save.Text = "Save";            
        }
        private void Sve()
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
            }
           
            string hostName = Dns.GetHostName();
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            string abcz = "";
            //try
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {


                }
                
                try
                {
                    MySqlCommand itd = new MySqlCommand("insert into fsm_security(user_name,tabs,sign_date,sign_time,pc_name,user_domain) Values('" + tex_user.Text + "','" + rolebox.Text + "','" + DateTime.Today.ToString("dd-MM-yyyy") + "','" + DateTime.Now.ToString("hh:mm:ss") + "','" + Environment.MachineName + "','" + myIP + "')", conn);
                    itd.ExecuteNonQuery();
                    itd.Dispose();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Record is successfully Added!", "Record Added Successful!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            //catch (Exception ex) {
            //    
            //}



        }
        private void update()
        {
            try
            {

                if (MessageBox.Show("Are You Sure To Update this record?", "Update Now?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand up = new MySqlCommand("Update fsm_security  set tabs='" + rolebox.Text + "' where  user_name='" + tex_user.Text + "'", conn);
                    up.ExecuteNonQuery();
                    up.Dispose();
                    MessageBox.Show("The selected record has been Updated Successfuly!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The selected record is Not Update,Please try again", "Üpdate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string ch_dep = "";
            if (rolebox.Text != "" || tex_user.Text != "")
            {


                if (rolebox.Text == "")
                {
                    MessageBox.Show("Role cannot be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    rolebox.Focus();
                    return;
                }
                //for username 
                if (tex_user.Text == "")
                {
                    MessageBox.Show("Username cannot be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tex_user.Focus();
                    return;
                }
                else
                {
                    try
                    {
                        
                        MySqlCommand sel_deb = new MySqlCommand("select user_name,tabs from fsm_security where user_name='" + tex_user.Text + "' and tabs='"+rolebox.Text+"' ", conn);
                        sel_deb.ExecuteNonQuery();
                        MySqlDataReader deb_dr = sel_deb.ExecuteReader();
                        while (deb_dr.Read())
                        {
                            ch_dep = deb_dr[0].ToString();
                        }
                        deb_dr.Dispose();
                    }
                    catch (Exception ex)
                    {


                    }

                }

                if (ch_dep == null || ch_dep == "")
                {
                    
                        if (btn_save.Text == "Save")
                    {

                        Sve();
                    }
                        if (btn_save.Text == "Update")
                        {

                            update();
                        }
                        
                   
                }
                else if (ch_dep != null || ch_dep != "")
                {
                    MessageBox.Show("This User Have Already Access of this Tab!", "Invaild Tab", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rolebox.Focus();
                    return;
                }
                   
                }
               
                tex_user.Text = string.Empty;
                rolebox.Text = string.Empty;
                lview();
            }

        private void listView1_Click_1(object sender, EventArgs e)
        {
              
                tex_user.Text = listView1.SelectedItems[0].SubItems[0].Text;
                rolebox.Text = listView1.SelectedItems[0].SubItems[1].Text;
                btn_save.Text = "Update";
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are You Sure you want to Delete this record?", "Delete Now?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand dass = new MySqlCommand("Delete from fsm_security where user_name='" + tex_user.Text + "' and tabs='"+rolebox.Text+"' ", conn);
                    dass.ExecuteNonQuery();
                    rolebox.Text = "";
                    tex_user.Text = null;
                    MessageBox.Show("The selected record has been Deleted Successfuly!", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dass.Dispose();
                    lview();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("The selected record was Not Delete,Please try again", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        }

        
    }

