using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using System.IO;
using System.Data.OleDb;
using iTextSharp.text.pdf;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace FSM
{
    public partial class BarcodeMaker : Form
    {
        //string conngsm = ConfigurationSettings.AppSettings["ConnectionString"];
        //MySqlConnection conngsm1;

        public static string conngsm = ConfigurationSettings.AppSettings["ConnectionString"];
        MySqlConnection conngsm1 = new MySqlConnection(conngsm);

        public BarcodeMaker()
        {
            InitializeComponent();
        }

        private void BarcodeMaker_Load(object sender, EventArgs e)
        {

            conngsm1.Open();
          
            getitem_name();
            getproduct();
            getbatch();
        }
        private void connection_check()
        {
            if (conngsm1.State == ConnectionState.Open)
            {
            }
            else if (conngsm1.State == ConnectionState.Closed)
            {
                try
                {
                    conngsm1.Open();
                }
                catch (Exception ex)
                {


                }
            }
        }
        private void getitem_name()
        {
            connection_check();
            try
            {
                textBox4.Items.Clear();
                MySqlCommand item_name = new MySqlCommand("select DISTINCT(raw_name) from rawtb order by raw_name asc ", conngsm1);
                item_name.ExecuteNonQuery();
                MySqlDataReader rd = item_name.ExecuteReader();
                while (rd.Read())
                {
                    textBox4.Items.Add(rd[0].ToString());
                }
                rd.Dispose();
            }
            catch (Exception ex)
            { }
        }

        private void getproduct()
        {
            connection_check();
            comboBox1.Items.Clear();
            try
            {
                MySqlCommand com_name = new MySqlCommand("select DISTINCT(cat_name) from fsm_pro_pricing order by cat_name desc ", conngsm1);
                com_name.ExecuteNonQuery();
                MySqlDataReader rd = com_name.ExecuteReader();
                while (rd.Read())
                {
                    comboBox1.Items.Add(rd[0].ToString());
                }
                rd.Dispose();
            }
            catch (Exception ex)
            {


            }

        }

        private void getbatch()
        {
            connection_check();
            comboBox2.Items.Clear();
            try
            {
                MySqlCommand com_name = new MySqlCommand("select DISTINCT(Batch_no) from fsm_production_status order by Batch_no asc ", conngsm1);
                com_name.ExecuteNonQuery();
                MySqlDataReader rd = com_name.ExecuteReader();
                while (rd.Read())
                {
                    comboBox2.Items.Add(rd[0].ToString());
                }
                rd.Dispose();
            }
            catch (Exception ex)
            {


            }

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Text = "";
                textBox4.Text = "";
              
                if (textBox2.Text == "")
                {
                    textBox2.Text = "0";

                }

                if (textBox4.Text == "")
                {
                    textBox4.Text = "0";

                }
                textBox2.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection_check();
            try
            {
                conngsm1 = new MySqlConnection(conngsm);
                conngsm1.Open();
                MySqlCommand delcm = new MySqlCommand("delete from barcod", conngsm1);
                delcm.ExecuteNonQuery();
                MessageBox.Show("Cleared...! Now you can create more Barcode.");
            }
            catch (Exception ex)
            { }
            conngsm1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection_check();
            if (textBox1.Text == "" && textBox4.Text == "")
            {


                int hax = Convert.ToInt32(textBox3.Text);
                
                for (int i = 0; i < hax; i++)
                {

                   // MySqlCommand setupalll = new MySqlCommand("Insert into fsm_barcode (bar_name,bar_code,pro_code,descrip,bar_date,bar_time,login_user,branch_n,pc_name,domain,no_of_prints,com_name,pro_price) Values('" + pro_box.Text + "','" + bar_no.Text + "','" + bar_no.Text + "','" + se_date.Text + "','" + DateTime.UtcNow.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss:tt") + "','" + Login.user_n + "','" + Login.branch + "','" + hostName + "','" + myIp + "','" + p_no.Text + "','FRESCO SWEETS','" + pro_price.Text + "') ", conn);
                   // setupalll.ExecuteNonQuery();
                   // setupalll.Dispose();

                    MySqlCommand barinc = new MySqlCommand("insert into barcod(invoice_no,expdate,bar_price) values('" + comboBox1.Text + "','" + textBox5.Text + "','" + comboBox2.Text + "')", conngsm1);
                    barinc.ExecuteNonQuery();
                }

                MessageBox.Show("Added Successfully");

            }
            else
            {

                if (textBox3.Text == "") { textBox3.Text = "0"; }
                int ha = Convert.ToInt32(textBox3.Text);
                for (int i = 0; i <= ha; i++)
                {
                    MySqlCommand barinc = new MySqlCommand("insert into barcod(bar_name,bar_price,invoice_no,expdate) values('" + textBox1.Text + "','" + comboBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", conngsm1);
                    barinc.ExecuteNonQuery();
                }

                MessageBox.Show("Added Successfully");


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection_check();
            try
            {
                Document doc = new Document(new iTextSharp.text.Rectangle(110, 80));
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/codes.pdf", FileMode.Create));

                doc.Open();

                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Price");
                dt.Columns.Add("INV");
                dt.Columns.Add("Expire");
                string so1 = "", so2 = "", so3 = "", so4 = "", so5 = "";
                MySqlCommand cmsel = new MySqlCommand("select bar_name,bar_price,invoice_no,expdate from barcod", conngsm1);
                cmsel.ExecuteNonQuery();
                MySqlDataReader cmread = cmsel.ExecuteReader();
                while (cmread.Read())
                {
                    so1 = cmread[0].ToString();
                    so2 = cmread[1].ToString();
                    so3 = cmread[2].ToString();
                    so4 = cmread[3].ToString();
                    so5 = so4;
                  
                        DataRow row = dt.NewRow();
                        row["ID"] = so1;///Barcode
                        row["Price"] = so2;
                        row["INV"] = so3;
                        row["Expire"] = so5;
                        dt.Rows.Add(row);
                
                }
                cmread.Dispose();
                System.Drawing.Image img1 = null;


                for (int i = 0; i < dt.Rows.Count; i++)
                {


                        if (i != 0)
                        {
                            doc.NewPage();

                        }


                        

                        PdfContentByte cb1 = writer.DirectContent;
                        BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_BOLDITALIC, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    
                        cb1.SetFontAndSize(bf, 9.0f);
                        cb1.BeginText();
                        cb1.SetTextMatrix(10.0f, 70.5f);
                        cb1.ShowText("F r e s c o s w e e t s");
                    
                        //   cb1.TextAlignment = Element.ALIGN_MIDDLE;
                        cb1.EndText();


                        PdfContentByte cb21 = writer.DirectContent;
                        BaseFont bf111 = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                        
                      
                        cb21.SetFontAndSize(bf111, 6.0f);
                        cb21.BeginText();
                        cb21.SetTextMatrix(3.0f, 60.0f);
                        cb21.ShowText(dt.Rows[i]["INV"].ToString());
                        cb21.EndText();


                      
                        PdfContentByte cb21c = writer.DirectContent;
                        BaseFont bf111c = BaseFont.CreateFont(BaseFont.COURIER_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                        cb21c.SetFontAndSize(bf111c, 6.0f);
                        cb21c.BeginText();
                        cb21c.SetTextMatrix(3.0f, 50.0f);
                        cb21c.ShowText(dt.Rows[i]["Expire"].ToString());
                        cb21c.EndText();

                       
                        
                        iTextSharp.text.pdf.PdfContentByte cb = writer.DirectContent;
                        iTextSharp.text.pdf.Barcode128 bc = new Barcode128();
                        bc.TextAlignment = Element.ALIGN_LEFT;
                        bc.Size = 3;
                        
                        bc.Code = dt.Rows[i]["ID"].ToString();
                        bc.StartStopText = true;
                        bc.CodeType = iTextSharp.text.pdf.Barcode128.EAN13;
                        bc.Extended = false;




                        iTextSharp.text.Image img = bc.CreateImageWithBarcode(cb, iTextSharp.text.Color.BLACK, iTextSharp.text.Color.BLACK);
                        BaseFont bf11 = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

                        cb.SetTextMatrix(3.0f, 4.0f);
                        img.ScaleToFit(100, 30);
                        img.SetAbsolutePosition(10.0f, 10);
                        img.Alignment = Element.ALIGN_RIGHT;
                        cb.AddImage(img);

                    
                }

                ////////////////////***********************************//////////////////////
                doc.Open();
                doc.Close();
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/codes.pdf");

                checkBox1.CheckState = CheckState.Unchecked;
                checkBox2.CheckState = CheckState.Unchecked;
                checkBox3.CheckState = CheckState.Unchecked;
                checkBox4.CheckState = CheckState.Unchecked;
                textBox5.Text = "";


              
            }
            catch (OleDbException ex)
            { }
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            connection_check();
            try
            {
                Document doc = new Document(new iTextSharp.text.Rectangle(110, 80));

                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/codes.pdf", FileMode.Create));

                doc.Open();

                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Price");
                dt.Columns.Add("INV");
                dt.Columns.Add("Expire");
                string so1 = "", so2 = "", so3 = "", so4 = "", so5 = "";
                MySqlCommand cmsel = new MySqlCommand("select bar_name,bar_price,invoice_no,expdate from barcod", conngsm1);
                // SqlCommand cmsel = new SqlCommand("select bar_name,bar_price,invoice_no from barcod", cnn);
                cmsel.ExecuteNonQuery();
                MySqlDataReader cmread = cmsel.ExecuteReader();
                //cmsel.ExecuteNonQuery();
                // SqlDataReader cmread = cmsel.ExecuteReader();
                while (cmread.Read())
                {
                    so1 = cmread[0].ToString();
                    so2 = cmread[1].ToString();
                    so3 = cmread[2].ToString();
                    so4 = cmread[3].ToString();
                    //DateTime dts = Convert.ToDateTime(so4);
                    so5 = so4;
                    //int conts = Convert.ToInt32(textBox3.Text);

                    // for (int i = 0; i < conts; i++)
                    {
                        DataRow row = dt.NewRow();
                        row["ID"] = so1;
                        row["Price"] = so2;
                        row["INV"] = so3;
                        row["Expire"] = so5;
                        dt.Rows.Add(row);
                    }
                }
                cmread.Dispose();
                System.Drawing.Image img1 = null;


                for (int i = 0; i < dt.Rows.Count; i++)
                {


                    {
                        if (i != 0)
                        {
                            doc.NewPage();

                        }



                        PdfContentByte cb21 = writer.DirectContent;
                        BaseFont bf111 = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                        cb21.SetFontAndSize(bf111, 7.0f);
                        cb21.BeginText();
                        cb21.SetTextMatrix(3.0f, 50.0f);
                        cb21.ShowText(dt.Rows[i]["INV"].ToString());
                        cb21.EndText();



                        PdfContentByte cb21c = writer.DirectContent;
                        BaseFont bf111c = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                        cb21c.SetFontAndSize(bf111c, 6.3f);
                        cb21c.BeginText();
                        cb21c.SetTextMatrix(3.0f, 25.0f);
                        cb21c.ShowText(dt.Rows[i]["Expire"].ToString());
                        cb21c.EndText();



                    }
                }

                ////////////////////***********************************//////////////////////
                doc.Open();
                doc.Close();
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/codes.pdf");

                checkBox1.CheckState = CheckState.Unchecked;
                checkBox2.CheckState = CheckState.Unchecked;
                checkBox3.CheckState = CheckState.Unchecked;
                checkBox4.CheckState = CheckState.Unchecked;
                textBox5.Text = "";

                try
                {
                    conngsm1.Dispose();
                    conngsm1.Close();

                }
                catch (Exception ex)
                { }
            }
            catch (OleDbException ex)
            { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            



              
        }

        private void textBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection_check();
            textBox1.Text = "";
            try
            {

                MySqlCommand com_name = new MySqlCommand("select barcode,retial_price from fsm_pro_pricing where cat_name ='" + textBox4.Text + "' ", conngsm1);
                com_name.ExecuteNonQuery();
                MySqlDataReader rd = com_name.ExecuteReader();
                while (rd.Read())
                {
                    textBox1.Text = rd[0].ToString();
                }
                rd.Dispose();

            }
            catch (Exception ex)
            { }
            //try
            //{

            //    MySqlCommand cmmcatex = new MySqlCommand("select bar_code from categorytb where cat_name = '" + textBox4.Text + "' ", conngsm1);
            //    cmmcatex.ExecuteNonQuery();

            //    MySqlDataReader catereadx = cmmcatex.ExecuteReader();
            //    while (catereadx.Read())
            //    {
            //        textBox1.Text = (catereadx[0].ToString());
            //    }
            //    catereadx.Dispose();
            //    comboBox1.Text = "";
            //}
          
           
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox5.Focus();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3.Focus();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox4.Text = "";


        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Text = checkBox1.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string aa , bb;
            aa = textBox5.Text;
            textBox5.Text = dateTimePicker1.Value.ToShortDateString();
            bb = aa + textBox5.Text;
            textBox5.Text = bb;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox5.Text = checkBox2.Text;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                string cc, dd;
                cc = textBox5.Text;
                dd = cc + checkBox3.Text;
                textBox5.Text = dd;
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                string ee, ff;
                ee = textBox5.Text;
                ff = ee + checkBox4.Text;
                textBox5.Text = ff;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string gg, hh;
            gg = textBox5.Text;
            hh = gg + dateTimePicker2.Value.ToShortDateString();
            textBox5.Text = hh;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection_check();
            textBox1.Text = "";
            textBox1.Text = comboBox2.Text;
            try
            {

                MySqlCommand com_name = new MySqlCommand("select Product from fsm_production_status where Batch_no= '" + comboBox2.Text + "' ", conngsm1);
                com_name.ExecuteNonQuery();
                MySqlDataReader rd = com_name.ExecuteReader();
                while (rd.Read())
                {
                    textBox4.Text = rd[0].ToString();
                }
                rd.Dispose();
               
            }
            catch (Exception ex)
            {


            }


           
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pr_pro_Click(object sender, EventArgs e)
        {
            connection_check();
            try
            {
                Document doc = new Document(new iTextSharp.text.Rectangle(110, 80));

                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/codes.pdf", FileMode.Create));

                doc.Open();

                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Price");
                dt.Columns.Add("INV");
                dt.Columns.Add("Expire");
                string so1 = "", so2 = "", so3 = "", so4 = "", so5 = "";
                MySqlCommand cmsel = new MySqlCommand("select bar_name,bar_price,invoice_no,expdate from barcod", conngsm1);
                // SqlCommand cmsel = new SqlCommand("select bar_name,bar_price,invoice_no from barcod", cnn);
                cmsel.ExecuteNonQuery();
                MySqlDataReader cmread = cmsel.ExecuteReader();
                //cmsel.ExecuteNonQuery();
                // SqlDataReader cmread = cmsel.ExecuteReader();
                while (cmread.Read())
                {
                    so1 = cmread[0].ToString();
                    so2 = cmread[1].ToString();
                    so3 = cmread[2].ToString();
                    so4 = cmread[3].ToString();
                    //DateTime dts = Convert.ToDateTime(so4);
                    so5 = so4;
                    //int conts = Convert.ToInt32(textBox3.Text);

                    // for (int i = 0; i < conts; i++)
                    {
                        DataRow row = dt.NewRow();
                        row["ID"] = so1;
                        row["Price"] = so2;
                        row["INV"] = so3;
                        row["Expire"] = so5;
                        dt.Rows.Add(row);
                    }
                }
                cmread.Dispose();
                System.Drawing.Image img1 = null;


                for (int i = 0; i < dt.Rows.Count; i++)
                {


                    {
                        if (i != 0)
                        {
                            doc.NewPage();

                        }



                        PdfContentByte cb1 = writer.DirectContent;
                        BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_BOLDITALIC, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

                        cb1.SetFontAndSize(bf, 9.0f);
                        cb1.BeginText();
                        cb1.SetTextMatrix(10.0f, 68.5f);
                        cb1.ShowText("F r e s c o s w e e t s");

                        cb1.EndText();



                        PdfContentByte cb21 = writer.DirectContent;
                        BaseFont bf111 = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                        cb21.SetFontAndSize(bf111, 8.0f);
                        cb21.BeginText();
                        cb21.SetTextMatrix(5.0f, 60.0f);
                        cb21.ShowText(dt.Rows[i]["INV"].ToString());
                        cb21.EndText();





                        PdfContentByte cb21c = writer.DirectContent;
                        BaseFont bf111c = BaseFont.CreateFont(BaseFont.COURIER_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                        cb21c.SetFontAndSize(bf111c, 5.3f);
                        cb21c.BeginText();
                        cb21c.SetTextMatrix(5.0f, 50.0f);
                        cb21c.ShowText(dt.Rows[i]["Expire"].ToString());
                        cb21c.EndText();



                        iTextSharp.text.pdf.PdfContentByte cb = writer.DirectContent;
                        iTextSharp.text.pdf.Barcode128 bc = new Barcode128();
                        bc.TextAlignment = Element.ALIGN_LEFT;
                        bc.Size = 5;

                        //BaseFont bf1m = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                        //bc.SetFontAndSize(bf1m, 24.3f);
                        bc.Code = dt.Rows[i]["ID"].ToString();
                        bc.StartStopText = true;
                        bc.CodeType = iTextSharp.text.pdf.Barcode128.EAN13;
                        bc.Extended = false;


                        iTextSharp.text.Image img = bc.CreateImageWithBarcode(cb, iTextSharp.text.Color.BLACK, iTextSharp.text.Color.BLACK);
                        BaseFont bf11 = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);


                        cb.SetTextMatrix(3.5f, 6.0f);
                        img.ScaleToFit(100, 30);
                        img.SetAbsolutePosition(5.0f, 5);
                        img.Alignment = Element.ALIGN_LEFT;
                        cb.AddImage(img);
                    }
                }

                ////////////////////***********************************//////////////////////
                doc.Open();
                doc.Close();
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/codes.pdf");

                checkBox1.CheckState = CheckState.Unchecked;
                checkBox2.CheckState = CheckState.Unchecked;
                checkBox3.CheckState = CheckState.Unchecked;
                checkBox4.CheckState = CheckState.Unchecked;
                textBox5.Text = "";


            }
            catch (OleDbException ex)
            { }
        }

       

       
    }
}
