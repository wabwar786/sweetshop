using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;
using System.Configuration;
using System.Net;
using System.Diagnostics;
using FSM.Forms;

namespace FSM
{
    public partial class mainfrm : Form
    {
        
        private int childFormNumber = 0;

        public static string connectionstr = ConfigurationSettings.AppSettings["ConnectionString"];

        MySqlConnection conn = new MySqlConnection(connectionstr);

        public mainfrm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }

        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void inventryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fsm_inventory fs = new fsm_inventory();
            fs.ShowDialog();
        }
        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Signup fs = new Signup();
            fs.ShowDialog();
        }
        private void button63_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void securityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Security fs = new Security();
            fs.ShowDialog();
        }
        private void mainfrm_Load(object sender, EventArgs e)
        {
            conn.Open();
            if (Login.user_n == "Main Admin" )
            {
                signUpToolStripMenuItem.Visible = true;
                securityToolStripMenuItem.Visible = true;
            }
            
            string tbs = "";
            MySqlCommand com_name = new MySqlCommand("select tabs from fsm_security where(user_name='" + Login.user_n + "')", conn);
            com_name.ExecuteNonQuery();
            MySqlDataReader rd = com_name.ExecuteReader();
            while (rd.Read())
            {
                tbs = rd[0].ToString();
                if (tbs == "All-with Signup")
                {
                    signUpToolStripMenuItem.Visible = true;
                }
                if (tbs == "All-with Security")
                {
                    securityToolStripMenuItem.Visible = true;
                }
            }
            rd.Dispose();

        }

        
        private void barcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarcodeMaker fs = new BarcodeMaker();
            fs.ShowDialog();
        }
        private void checkUpdateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            update_check uc = new update_check();
            uc.ShowDialog();
        }

        private void goodsReceivingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fs_voucher fsv = new fs_voucher();
            fsv.Show();
        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salepoint sp = new salepoint();
            sp.ShowDialog();
        }

        private void customersRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer_details_Form2 sdf = new customer_details_Form2();
            sdf.ShowDialog();
        }

        private void salesManRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sales_man_reg smr = new sales_man_reg();
            smr.ShowDialog();
        }

        private void accountCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //account ac = new account();
            //ac.ShowDialog();
        }

        private void dealsCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deals_creation dc = new deals_creation();
            dc.ShowDialog();
        }

        private void quickSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quick_sale_creation qsc = new quick_sale_creation();
            qsc.ShowDialog();
        }
    }
}
