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
using  System.Text.RegularExpressions;
namespace FSM
{
    public partial class Signup : Form
    {
        string base64String="";
        string pics = "";
        public static string connectionstr = ConfigurationSettings.AppSettings["ConnectionString"];
        MySqlConnection conn = new MySqlConnection(connectionstr);
        public Signup()
        {
            InitializeComponent();
        }

       

        private void btn_save_Click(object sender, EventArgs e)
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
 //for password 

       
     if (tex_pwd.Text.Length >= 6)
     {

     }
     else
     {
         MessageBox.Show("Password must be atleast 6 characters", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         tex_pwd.Focus();
         return;
     }
     if (System.Text.RegularExpressions.Regex.IsMatch(tex_phone.Text, "^[0-9]"))
     {

     }
     else
     {
         MessageBox.Show("Phone Number must be  Numeric not Charater", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         tex_phone.Focus();
         return;
     }

     if (tex_email.Text == "")
     {
         MessageBox.Show("Email cannot be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         tex_email.Focus();
         return;
     }

            if (btn_save.Text == "Save")
            { 

                Sve(); }
               
            else if (btn_save.Text == "Update")
            {
                upd();
            }

            tex_id.Text = string.Empty;
            tex_user.Text = string.Empty;
            rolebox.Text = string.Empty;
            branch_box1.Text = "";
            tex_pwd.Text = string.Empty;
            tex_phone.Text = string.Empty;
            tex_email.Text = string.Empty;
            pictureBox2.Image = null;
            lview();
            
        }
        private void upd()
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
                MemoryStream ms = new MemoryStream();
                Bitmap btmap = new Bitmap(pictureBox2.Image);
                btmap.Save(ms, ImageFormat.Png);
                byte[] imageBytes = ms.ToArray();
                pics = Convert.ToBase64String(imageBytes);
                ms.Position = 0;
            }
            catch (Exception ex)
            {


            }
          
            try
            {

                if (MessageBox.Show("Are You Sure To Update this record?", "Update Now?",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                  {
            MySqlCommand up = new MySqlCommand("Update fsm_signup  set user_name='" + tex_user.Text + "' ,password='" + tex_pwd.Text + "', role='" + rolebox.Text + "',phone_number='" + tex_phone.Text + "',user_email='" + tex_email.Text + "',user_picture='"+ pics +"',branch_n='"+branch_box1.Text+"' where ID ='"+tex_id.Text+"'", conn);
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
        private void Sve()
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
                MemoryStream ms = new MemoryStream();
                Bitmap btmap = new Bitmap(pictureBox2.Image);
                btmap.Save(ms, ImageFormat.Png);
                byte[] imageBytes = ms.ToArray();
                base64String = Convert.ToBase64String(imageBytes);
                ms.Position = 0;

            }
            catch (Exception)
            {

                base64String = "";
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
                MySqlCommand st = new MySqlCommand("select ID from fsm_signup order by ID desc ", conn);
                st.ExecuteNonQuery();
                MySqlDataReader sd = st.ExecuteReader();
                while (sd.Read())
                {
                    abcz = sd[0].ToString();

                }
                sd.Dispose();
                tex_id.Text = tex_phone.Text + abcz;
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    
                   
                }
                try
                {
                    MySqlCommand itd = new MySqlCommand("insert into fsm_signup(User_ID,user_name,password,role,sign_date,sign_time,createdby,pc_name,phone_number,user_email,user_domain,user_picture,branch_n) Values('" + tex_id.Text + "','" + tex_user.Text + "','" + tex_pwd.Text + "','" + rolebox.Text + "','" + DateTime.Today.ToString("dd-MM-yyyy") + "','" + DateTime.Now.ToString("hh:mm:ss") + "','" + Login.creater + "','" + Environment.MachineName + "','" + tex_phone.Text + "','" + tex_email.Text + "','" + myIP + "','" + base64String + "','" + branch_box1.Text + "')", conn);
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
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are You Sure you want to Delete this record?", "Delete Now?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand dass = new MySqlCommand("Delete from fsm_signup where ID='" + tex_id.Text+"'", conn);
                    dass.ExecuteNonQuery();
                    tex_id.Text = "";
                    rolebox.Text = "";
                    branch_box1.Text = "";
                    tex_user.Text = null;
                    tex_pwd.Text = null;
                    tex_phone.Text = null;
                    tex_email.Text = null;
                    pictureBox2.Image = null;
                    MessageBox.Show("The selected record has been Deleted Successfuly!","Delete Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    dass.Dispose();
                    lview();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The selected record was Not Delete,Please try again", "Delete Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
                    tex_id.Text = string.Empty;
                    tex_user.Text = string.Empty;
                    rolebox.Text = string.Empty;
                    branch_box1.Text = "";
                    tex_pwd.Text = string.Empty;
                    tex_phone.Text = string.Empty;
                    tex_email.Text = string.Empty;
                    pictureBox2.Image = null;
                    btn_save.Text = "Save";            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileidalog = new OpenFileDialog();
                fileidalog.Filter = "jpg files(*.jpg)|*.jpg|JPEG files(*.JPEG)|*.JPEG| All files(*.*)|*.*";
                fileidalog.ShowDialog();
                pictureBox2.Image = Image.FromFile(fileidalog.FileName);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); } 
        }

        private void Signup_Load(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("connected");
            }
            lview();

            MySqlCommand Crole = new MySqlCommand("select r_name from fsm_role order by r_name asc ", conn);
            Crole.ExecuteNonQuery();
            MySqlDataReader rd = Crole.ExecuteReader();
            while (rd.Read())
            {
                rolebox.Items.Add(rd[0].ToString());

            }
            rd.Dispose();
            MySqlCommand Crole23 = new MySqlCommand("select branch_n from fsm_branch order by branch_n asc ", conn);
            Crole23.ExecuteNonQuery();
            MySqlDataReader rd23 = Crole23.ExecuteReader();
            while (rd23.Read())
            {
                branch_box1.Items.Add(rd23[0].ToString());

            }
            rd23.Dispose();

            tex_pwd.UseSystemPasswordChar = true;
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

                MySqlDataAdapter rrx = new MySqlDataAdapter("select ID,user_name,role,phone_number,user_email,branch_n from fsm_signup ", conn);
                DataTable dtx = new DataTable();
                rrx.Fill(dtx);
                for (int i = 0; i < dtx.Rows.Count; i++)
                {

                    DataRow dr = dtx.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["ID"].ToString());
                    listitem.SubItems.Add(dr["user_name"].ToString());
                   
                    listitem.SubItems.Add(dr["role"].ToString());
                    listitem.SubItems.Add(dr["phone_number"].ToString());
                    listitem.SubItems.Add(dr["user_email"].ToString());
                    listitem.SubItems.Add(dr["branch_n"].ToString());
                    listView1.Items.Add(listitem);
                }
                dtx.Dispose();
                rrx.Dispose();     

            }
            catch (Exception ex)
            {
                
                
            }
           
        
        }
        private void btn_plus_Click(object sender, EventArgs e)
        {

            if (rolebox.Text == "" || rolebox.Text == null)
            {
                MessageBox.Show("Please Type a Role!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    MySqlCommand ins = new MySqlCommand("insert into fsm_role(r_name) Values ('" + rolebox.Text + "')", conn);
                    ins.ExecuteNonQuery();
                    ins.Dispose();
                    MessageBox.Show("This Role is now Added to the record!", "record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                rolebox.Items.Clear();
                MySqlCommand Crole = new MySqlCommand("select r_name from fsm_role order by r_name asc ", conn);
                Crole.ExecuteNonQuery();
                MySqlDataReader rd = Crole.ExecuteReader();
                while (rd.Read())
                {
                    rolebox.Items.Add(rd[0].ToString());

                }
                rd.Dispose();

            }
        }

        

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (rolebox.Text == "" || rolebox.Text == null)
            {
                MessageBox.Show("Please Type a Role!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    rolebox.Items.Clear();
                    MySqlCommand ds = new MySqlCommand("delete from fsm_role where r_name=('" + rolebox.Text + "')", conn);
                    ds.ExecuteNonQuery();
                    ds.Dispose();
                    MessageBox.Show("This Role is Delete from the record!", "Record deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                MySqlCommand Crole = new MySqlCommand("select r_name from fsm_role order by r_name asc ", conn);
                Crole.ExecuteNonQuery();
                MySqlDataReader rd = Crole.ExecuteReader();
                while (rd.Read())
                {
                    rolebox.Items.Add(rd[0].ToString());

                }
                rd.Dispose();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            try
            {
               
                tex_id.Text = listView1.SelectedItems[0].SubItems[0].Text;
                tex_user.Text = listView1.SelectedItems[0].SubItems[1].Text;
                rolebox.Text = listView1.SelectedItems[0].SubItems[2].Text;
                tex_phone.Text = listView1.SelectedItems[0].SubItems[3].Text;
                tex_email.Text = listView1.SelectedItems[0].SubItems[4].Text;
                branch_box1.Text = listView1.SelectedItems[0].SubItems[5].Text;
                btn_save.Text = "Update";
                pictureBox2.Image = null;
                string imageC = "";

                MySqlCommand sel = new MySqlCommand("select user_picture from fsm_signup where ID='" + tex_id.Text + "'", conn);
                sel.ExecuteNonQuery();
                MySqlDataReader drdr = sel.ExecuteReader();
                while (drdr.Read())
                {
                    imageC = drdr[0].ToString();

                }
                drdr.Dispose();


                string imgname = imageC;
                byte[] imageBytes = Convert.FromBase64String(imgname);
                MemoryStream ms = new MemoryStream(imageBytes, 0,
                imageBytes.Length);

                ms.Write(imageBytes, 0, imageBytes.Length);
                Image image = Image.FromStream(ms, true);
                pictureBox2.Image = image;

               

            }
            catch (Exception ex)
            {

                // MessageBox.Show(ex.Message);
            }
        }

        
        

        private void tex_email_enter(object sender, EventArgs e)
        {
            if  (tex_email.Text == "someone@example.com")
            {
                tex_email.Text = "";
                tex_email.ForeColor = Color.Black;
            }

        }

        private void tex_email_leave(object sender, EventArgs e)
        {
            if (tex_email.Text == "")
            {
                tex_email.Text = "someone@example.com";
                tex_email.ForeColor = Color.Silver;
            }
        }

       

        private void tex_pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                MessageBox.Show("yes");
            }
        }

       

        private void tex_pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tex_pwd.UseSystemPasswordChar = false;
            }
            else
            {
                tex_pwd.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (branch_box1.Text == "" || branch_box1.Text == null)
            {
                MessageBox.Show("Please Type a Branch Name!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    MySqlCommand ins = new MySqlCommand("insert into fsm_branch(branch_n) Values ('" + branch_box1.Text + "')", conn);
                    ins.ExecuteNonQuery();
                    ins.Dispose();
                    MessageBox.Show("This Branch is now Added to the record!", "Added Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                branch_box1.Items.Clear();
                MySqlCommand Crole = new MySqlCommand("select branch_n from fsm_branch order by branch_n asc ", conn);
                Crole.ExecuteNonQuery();
                MySqlDataReader rd = Crole.ExecuteReader();
                while (rd.Read())
                {
                    branch_box1.Items.Add(rd[0].ToString());

                }
                rd.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (branch_box1.Text == "" || branch_box1.Text == null)
            {
                MessageBox.Show("Please Type a Branch Name!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            try
            {
                rolebox.Items.Clear();
                MySqlCommand ds = new MySqlCommand("delete from fsm_branch where branch_n=('" + branch_box1.Text + "')", conn);
                ds.ExecuteNonQuery();
                ds.Dispose();
                MessageBox.Show("This Branch is Delete from the record!","Deleted record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            MySqlCommand Crole = new MySqlCommand("select branch_n from fsm_branch order by branch_n asc ", conn);
            Crole.ExecuteNonQuery();
            MySqlDataReader rd = Crole.ExecuteReader();
            while (rd.Read())
            {
                branch_box1.Items.Add(rd[0].ToString());

            }
            rd.Dispose();
        }

        private void rolebox_Enter(object sender, EventArgs e)
        {
            if (rolebox.Text == "Select or Type a Role")
            {
                rolebox.Text = "";
                rolebox.ForeColor = Color.Black;
            }
        }

        private void rolebox_Leave(object sender, EventArgs e)
        {
            if (rolebox.Text == "")
            {
                rolebox.Text = "Select or Type a Role";
                rolebox.ForeColor = Color.Silver;
            }
        }

        private void branch_box1_Enter(object sender, EventArgs e)
        {
            if (branch_box1.Text == "Select or Type a Branch")
            {
                branch_box1.Text = "";
                branch_box1.ForeColor = Color.Black;
            }
        }

        private void branch_box1_Leave(object sender, EventArgs e)
        {
            if (branch_box1.Text == "")
            {
                branch_box1.Text = "Select or Type a Branch";
                branch_box1.ForeColor = Color.Silver;
            }
        }
        }

        //private void tex_phone_Enter(object sender, EventArgs e)
        //{
        //    if (tex_phone.Text == "Enter Phone Number")
        //    {
        //        tex_phone.Text = "";
        //        tex_phone.ForeColor = Color.Black;
        //    }
        //}

        //private void tex_phone_Leave(object sender, EventArgs e)
        //{
        //    if (tex_phone.Text == "")
        //    {
        //        tex_phone.Text = "Enter Phone Number";
        //        tex_phone.ForeColor = Color.Silver;
        //    }
        //}

        

        

       

       

        
        
       

        

        
    }

