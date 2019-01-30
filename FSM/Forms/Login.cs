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
using System.Net;

namespace FSM
{
    public partial class Login : Form
    {
        public static string branch;
        public static string user_n;
        string myIP = "";
        string hostName = "";
       
        public static string connectionstr = ConfigurationSettings.AppSettings["ConnectionString"];
        MySqlConnection conn = new MySqlConnection(connectionstr);
        public static string creater = null;

        public Login()
        {
            InitializeComponent();
        }
        private void connection_check1()
        {
            if (conn.State == ConnectionState.Open)
            {
            }
            else if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btn_login(object sender, EventArgs e)
        {
            //connection_check1();
           try
           {
              // connection_check1();
                string uPass = "";
                string dPass = "";
                try
                {
                    connection_check1();
                    MySqlCommand fins = new MySqlCommand("select password ,branch_n,user_name from fsm_signup where user_name ='" + tex_user.Text + "'", conn);
                    fins.ExecuteNonQuery();
                    MySqlDataReader bcc = fins.ExecuteReader();
                    if (bcc.Read())
                    {
                        dPass = bcc[0].ToString();
                        branch_nnn.Text = bcc[1].ToString();
                        role_text.Text = bcc[2].ToString();
                    }

                    bcc.Dispose();
                    branch = branch_nnn.Text;
                    user_n = role_text.Text;
                    uPass = texpwd.Text;
                }
                catch (Exception ex)
                {
                    
                   
                }
                
                if (dPass == "")
                {

                    MessageBox.Show("Invalid User-Name, Please verify again", "Invalid UserName", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                }
                else if (uPass == dPass)
                {
                    
                    //MessageBox.Show("You are Successfully Login", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        connection_check1();
                        MySqlCommand itd = new MySqlCommand("insert into fsm_login(user_name,domain,pc_name,date,time,branch_n,role) Values('" + tex_user.Text + "','" + myIP + "','" + hostName + "','" + DateTime.Today.ToString("dd-MM-yyyy") + "','" + DateTime.Now.ToString("hh:mm:ss") + "' ,'" + branch_nnn.Text + "' ,'" + role_text.Text + "')", conn);
                        itd.ExecuteNonQuery();
                        itd.Dispose();


                        tex_user.Text = "";
                        texpwd.Text = "";
                        mainfrm fs = new mainfrm();
                        Hide();
                        fs.Show();
                       // Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                    
                
                }
                else if (uPass != dPass)
                {

                    MessageBox.Show("Invaild Password,Please try again", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    texpwd.Focus();
                    return;
                }
                
                
                

            }
            catch (Exception ex)
            {
              MessageBox.Show("Invaild Username and Password,Please try again","Login error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }

           loadingCurrentAccount();
        }
       

        

        

        

        private void Login_Load(object sender, EventArgs e)
        {
            connection_check1();
            try
            {
                hostName = Dns.GetHostName();
                myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
               // conn.Open();
              
            }
            catch (Exception ex)
            {
                
                
            }
           
        }

        private void loadingCurrentAccount()
        {
            //MySqlCommand innzX21122 = new MySqlCommand("select ID from fsm_account_no where branch='" + Login.branch + "'", conn);
            //innzX21122.ExecuteNonQuery();
            //MySqlDataReader rrr1122 = innzX21122.ExecuteReader();
            //while (rrr1122.Read())
            //{
            //    account.account_no = rrr1122["ID"].ToString(); /*add acc  */ 
            //}
            //rrr1122.Dispose();
            //innzX21122.Dispose();
        }

        private void texpwd_KeyDown(object sender, KeyEventArgs e)
        {
           // try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    connection_check1();
                    string uPass = "";
                    string dPass = "";
                    try
                    {
                        MySqlCommand fins = new MySqlCommand("select password ,branch_n,user_name from fsm_signup where user_name ='" + tex_user.Text + "'", conn);
                        fins.ExecuteNonQuery();
                        MySqlDataReader bcc = fins.ExecuteReader();
                        if (bcc.Read())
                        {
                            dPass = bcc[0].ToString();
                            branch_nnn.Text = bcc[1].ToString();
                            role_text.Text = bcc[2].ToString();
                        }

                        bcc.Dispose();
                        branch = branch_nnn.Text;
                        uPass = texpwd.Text;
                        user_n = role_text.Text;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        
                    }
                    
                    if (dPass == "")
                    {

                        MessageBox.Show("Invalid User-Name, Please verify again", "Invalid UserName", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (uPass == dPass)
                    {
                        try
                        {
                            connection_check1();
                            MySqlCommand itd = new MySqlCommand("insert into fsm_login(user_name,domain,pc_name,date,time,branch_n,role) Values('" + tex_user.Text + "','" + myIP + "','" + hostName + "','" + DateTime.Today.ToString("dd-MM-yyyy") + "','" + DateTime.Now.ToString("hh:mm:ss") + "' ,'" + branch_nnn.Text + "' ,'" + role_text.Text + "')", conn);
                            itd.ExecuteNonQuery();
                            itd.Dispose();
                                
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                        mainfrm fs = new mainfrm();
                        //this.Close();
                        fs.ShowDialog();
                       // this.Show();
                        //welcome fs1 = new welcome();
                        //fs1.Close();
                    }
                    else if (uPass != dPass)
                    {

                        MessageBox.Show("Invaild Password,Please try again", "Login error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                }
            }
           // catch (Exception ex)
            {

              //  MessageBox.Show(ex.Message); 
            }
           
        }

       //FSM fs = new FSM();
       //                 this.Close();
       //                 fs.ShowDialog();
       //                 this.Show();
       //                 welcome fs1 = new welcome();
       //                 fs1.Close();

          
    }
}
