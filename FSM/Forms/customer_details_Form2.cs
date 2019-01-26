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
using System.IO;
using System.Drawing.Imaging;
using System.Net.Sockets;

namespace FSM
{
    public partial class customer_details_Form2 : Form
    {
        MySqlConnection conn = null;
        string base64String = "";

        public customer_details_Form2()
        {
            InitializeComponent();
            string connectorstr = ConfigurationSettings.AppSettings["ConnectionString"];
            conn = new MySqlConnection(connectorstr);
            _checkConnection();
        }

        private void _checkConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                { }
                else
                {
                    conn.Open();
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);

            }

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

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_fname.Text = "";
            txt_lname.Text = "";
            txt_comp_name.Text = "";
            tex_email.Text = "";
            txt_ph_no.Text = "";
            tex_mob.Text = "";
            cb_contry.Text = "";
            cb_city.Text = "";
            txt_street_no.Text = "";
            txt_house_no.Text = "";
            pictureBox2.Image = null;
            btn_save.Text = "Save";


            _checkConnection();
            //cb_contry.Items.Clear();
            //MySqlCommand _getCountrycit = new MySqlCommand("select DISTINCT(Country) from link_table", conn);
            //_getCountrycit.ExecuteNonQuery();
            //MySqlDataReader _get = _getCountrycit.ExecuteReader();
            //while (_get.Read())
            //{
            //    cb_contry.Items.Add(_get[0].ToString());


            //}
            //_get.Dispose();

            //cb_city.Items.Clear();
            //MySqlCommand _getCountrycit1 = new MySqlCommand("select DISTINCT(City) from link_table", conn);
            //_getCountrycit1.ExecuteNonQuery();
            //MySqlDataReader _get1 = _getCountrycit1.ExecuteReader();
            //while (_get1.Read())
            //{

            //    cb_city.Items.Add(_get1[0].ToString());

            //}
            //_get1.Dispose();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            { _checkConnection(); }
            catch (Exception ee) { }
            try
            {

                if (MessageBox.Show("Are You Sure you want to Delete this record?", "Delete Now?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand dass = new MySqlCommand("Delete from customer_details where ID='" + txt_id.Text + "'", conn);
                    dass.ExecuteNonQuery();
                    txt_fname.Text = "";
                    txt_lname.Text = "";
                    txt_comp_name.Text = "";
                    tex_email.Text = "";
                    txt_ph_no.Text = "";
                    tex_mob.Text = "";
                    cb_contry.Text = "";
                    cb_city.Text = "";
                    txt_street_no.Text = "";
                    txt_house_no.Text = "";
                    pictureBox2.Image = null;
                    btn_save.Text = "Save";
                    MessageBox.Show("The selected record has been Deleted Successfuly!", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dass.Dispose();
                    lview();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " The selected record was Not Delete,Please try again", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //for username 
            //      if (tex_user.Text == "")
            //      {
            //         MessageBox.Show("Username cannot be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //         tex_user.Focus();
            //         return;
            //}
            //for password 



            if (!(System.Text.RegularExpressions.Regex.IsMatch(txt_ph_no.Text, "^[a-zA-Z]")))
            {

            }
            else
            {
                MessageBox.Show("Phone Number must be Numeric not Charater", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_ph_no.Focus();
                return;
            }
            if (!(System.Text.RegularExpressions.Regex.IsMatch(tex_mob.Text, "^[a-zA-Z]")))
            {

            }
            else
            {
                MessageBox.Show("Phone Number must be Numeric not Charater", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tex_mob.Focus();
                return;
            }

            if (tex_email.Text == "")
            {
                MessageBox.Show("Email cannot be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tex_email.Focus();
                return;
            }
            if (txt_fname.Text == "")
            {
                MessageBox.Show("First Name cannot be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_fname.Focus();
                return;
            }

            if (txt_lname.Text == "")
            {
                MessageBox.Show("Last Name cannot be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_lname.Focus();
                return;
            }


            if (btn_save.Text == "Save")
            {

                Sve();

            }

            else if (btn_save.Text == "Update")
            {
                upd();
            }


        }

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

        private void Sve()
        {
            try
            { _checkConnection(); }
            catch (Exception ee) { }
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

            //try
            {
                _checkConnection();
                // txt_id.Text = tex_phone.Text + abcz;
                string system_name = System.Environment.MachineName;
                MySqlCommand itd = new MySqlCommand("INSERT INTO `fsm_customers`( `fname`, `lname`, `comp_name`, `email`, `phno`, `mobno`, `contry`, `city`, `street`, `house`, `image`, `branch`,pc_name,ip,date,time) VALUES ('" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_comp_name.Text + "','" + tex_email.Text + "','" + txt_ph_no.Text + "','" + tex_mob.Text + "','" + cb_contry.Text + "','" + cb_city.Text + "','" + txt_street_no.Text + "','" + txt_house_no.Text + "','" + base64String + "','" + branchescombobox.Text + "','" + system_name + "','" + GetIPAddress() + "','" + addingDateTimeStamp() + "','"+addingTimeNow()+"')", conn);
                itd.ExecuteNonQuery();
                itd.Dispose();
                MessageBox.Show("Record is successfully Added!", "Record Added Successful!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            //catch (Exception ex) {
            //    MessageBox.Show(ex.Message);
            //}
            conn.Close();
            txt_fname.Text = "";
            txt_lname.Text = "";
            txt_comp_name.Text = "";
            tex_email.Text = "";
            txt_ph_no.Text = "";
            tex_mob.Text = "";
            cb_contry.Text = "";
            cb_city.Text = "";
            txt_street_no.Text = "";
            txt_house_no.Text = "";
            pictureBox2.Image = null;


            lview();

        }
        private void upd()
        {


            try
            {
                MemoryStream ms = new MemoryStream();
                Bitmap btmap = new Bitmap(pictureBox2.Image);
                btmap.Save(ms, ImageFormat.Png);
                byte[] imageBytes = ms.ToArray();
                base64String = Convert.ToBase64String(imageBytes);
                ms.Position = 0;
            }
            catch (Exception ex)
            {
                base64String = "";
                // MessageBox.Show(ex.Message);
            }


            try
            {
                _checkConnection();
                // string passupdate = CreateMD5(tex_pwd.Text);
                if (MessageBox.Show("Are You Sure To Update this record?", "Update Now?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    MySqlCommand up = new MySqlCommand("Update fsm_customers  set fname	='" + txt_fname.Text + "',lname='" + txt_lname.Text + "',comp_name='" + txt_comp_name.Text + "' ,email='" + tex_email.Text + "', phno='" + txt_ph_no.Text + "',mobno='" + tex_mob.Text + "',contry='" + cb_contry.Text + "',city='" + cb_city.Text + "',street='" + txt_street_no.Text + "',house='" + txt_house_no.Text + "',image='" + base64String + "' where ID =" + txt_id.Text + "", conn);
                    up.ExecuteNonQuery();
                    up.Dispose();
                    MessageBox.Show("The selected record has been Updated Successfuly!");

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The selected record is Not Update,Please try again" + ex.Message, "Üpdate Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            txt_fname.Text = "";
            txt_lname.Text = "";
            txt_comp_name.Text = "";
            tex_email.Text = "";
            txt_ph_no.Text = "";
            tex_mob.Text = "";
            cb_contry.Text = "";
            cb_city.Text = "";
            txt_street_no.Text = "";
            txt_house_no.Text = "";
            pictureBox2.Image = null;
            btn_save.Text = "Save";
            lview();

        }
        private void lview()
        {
            try
            {
                _checkConnection();     
          
            listView1.View = View.Details;
            listView1.Items.Clear();

            MySqlDataAdapter rrx = new MySqlDataAdapter("select ID,fname,email,phno,comp_name,contry from fsm_customers where(branch='" + Login.branch + "')", conn);
            DataTable dtx = new DataTable();
            rrx.Fill(dtx);
            for (int i = 0; i < dtx.Rows.Count; i++)
            {

                DataRow dr = dtx.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["ID"].ToString());
                listitem.SubItems.Add(dr["fname"].ToString());
                listitem.SubItems.Add(dr["email"].ToString());
                listitem.SubItems.Add(dr["phno"].ToString());
                listitem.SubItems.Add(dr["comp_name"].ToString());
                listitem.SubItems.Add(dr["contry"].ToString());
                listView1.Items.Add(listitem);
            }
            dtx.Dispose();
            rrx.Dispose();
                conn.Close();
            }
            catch (Exception eex)
            {
                MessageBox.Show(eex.Message);

            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string imageC = "";
            try
            {
                _checkConnection();

                txt_id.Text = listView1.SelectedItems[0].SubItems[0].Text;
                btn_save.Text = "Update";
                pictureBox2.Image = null;
                MySqlCommand sel = new MySqlCommand("select fname,lname,email,phno,comp_name,mobno,contry,city,street,house,image,branch from fsm_customers where ID='" + txt_id.Text + "'", conn);
                sel.ExecuteNonQuery();
                MySqlDataReader drdr = sel.ExecuteReader();
                while (drdr.Read())
                {
                    txt_fname.Text = drdr[0].ToString();
                    txt_lname.Text = drdr[1].ToString();
                    tex_email.Text = drdr[2].ToString();
                    txt_ph_no.Text = drdr[3].ToString();
                    txt_comp_name.Text = drdr[4].ToString();
                    tex_mob.Text = drdr[5].ToString();
                    cb_contry.Text = drdr[6].ToString();
                    cb_city.Text = drdr[7].ToString();
                    txt_street_no.Text = drdr[8].ToString();
                    txt_house_no.Text = drdr[9].ToString();
                    imageC = drdr["image"].ToString();
                    branchescombobox.Text = drdr["branch"].ToString();

                }
                drdr.Dispose();



                conn.Close();


            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
            }
            try
            {
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

        private void customer_details_Form2_Load(object sender, EventArgs e)
        {
            try
            {
                _checkConnection();
            }
            catch (Exception)
            {
            }
            
            lview();
        }
    }
}
