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
using FSM.Reports;
using System.Net;

namespace FSM.Forms
{
    public partial class fs_voucher : Form
    {

        public static string connectionstr = ConfigurationSettings.AppSettings["ConnectionString"];
        MySqlConnection conn = new MySqlConnection(connectionstr);


      
        string bag_ctn_c = "";
        string t_a = "";
        string items_names = "";
        string c_name = "";
        string cost_1 = "";
        string cost_2 = "";
        string quanty = "";
        string bags = "";
        string totals = "";
        string ucost = "";
        string tqty = "";
        string hostName = "";
        string myIP = "";
        string aa11 = "";
        string grand = "";
        string totalcost = "";
        string unitcost = "";
        string cocost = "";
        string ctncost = "";
        string t_cost = "";
      
        int new_Id = 0;
       
        string texrate = "";
        string disrate = "";
        string tex_rate = "";
        string tex_amount = "";
        string dis_rate = "";
        string sumqty = null;
     
        string per = null;
        double qty_t = 0;
        

        public fs_voucher()
        {
            InitializeComponent();
        }

        private void connection_check()
        {
            if (conn.State == ConnectionState.Open)
            {
            }
            else
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {


                }
            }



        }
        private void button1_Click(object sender, EventArgs e)
        {

            string _branch_name = branch_name.Text.Substring(0, 1);
            try
            {
                text_in_id.Text = "FS" + _branch_name + "-" + DateTime.Today.ToString("MMyy") + DateTime.Now.ToString("hhmmss");
            }
            catch (Exception es)
            {
            }
            inv_num.Enabled = true;
            company_box.Enabled = true;
            raw_ibox.Enabled = true;
            view_btn.Enabled = true;
            button14.Enabled = true;
            button19.Enabled = true;
            // button9.Enabled = true;
            save_btn.Enabled = true;
            delete_btn.Enabled = true;
            raw_ibox.Text = "";
            company_box.Text = "";
            raw_ibox.Text = "";
            label2.Text = "0";
            label4.Text = "0";
            add_label.Visible = false;
            connection_check();
            Bind_Grid0();
           
            save_btn.Enabled = true;
           
            inv_num.Text = _branch_name + "-" + DateTime.Today.ToString("MMyy") + DateTime.Now.ToString("hhmmss");
        }


        public DataSet SelectAll0()
        {

            DataSet ds = new DataSet();

            try
            {    
                connection_check();
                MySqlCommand cmd1 = new MySqlCommand("select raw_name,supplier,weight,bag,total_kg_p,cost,ctn_cost,Tex,tax_amount,Discount,total_cost,invoice_ID from fsm_null where invoice_no='" + inv_num.Text + "' order by id asc ", conn);
                MySqlDataAdapter daa = new MySqlDataAdapter(cmd1);

                daa.Fill(ds);

                cmd1.Dispose();

            }

            catch (Exception ex)
            {
                connection_check();
               
            }

            return ds;

        }

        private void Bind_Grid0()
        {
            try
            {
                DataSet Ds;

                Ds = this.SelectAll0();

                dataGridView1.DataSource = Ds.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void for_production()
        {
            connection_check();

            if (inv_num.Text == "" || company_box.Text == "")
            {
                if (inv_num.Text == "")
                {
                    string myStringVariable1 = string.Empty;
                    MessageBox.Show("Invoice number is required");
                }
                else if (company_box.Text == "")
                {
                    string myStringVariable2 = string.Empty;
                    MessageBox.Show("Supplier Name is requierd");
                }
            }

            else
            {

                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    connection_check();//MessageBox.Show(ex.Message);

                }
                try
                {
                    connection_check();

                    string Last_Id = "";
                    MySqlCommand sel_id = new MySqlCommand("select ID from fsm_voucher_log ;", conn);
                    sel_id.ExecuteNonQuery();
                    MySqlDataReader drr_id = sel_id.ExecuteReader();
                    while (drr_id.Read())
                    {
                        Last_Id = drr_id[0].ToString();
                    }
                    drr_id.Dispose();
                    if (Last_Id == "")
                    {
                        Last_Id = "1";
                    }
                    else if (Last_Id != "")
                    {
                        new_Id = Convert.ToInt32(Last_Id);
                        invoice_id.Text = 1 + Convert.ToString(new_Id);
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                connection_check();
                try
                {
                    MySqlCommand setupall3 = new MySqlCommand("Delete  from fsm_null where invoice_no ='" + inv_num.Text + "' and branch_n = '" + Login.branch + "' ", conn);
                    setupall3.ExecuteNonQuery();
                    setupall3.Dispose();

                }
                catch (Exception ex)
                {
                }
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    new_Id++;
                    try
                    {
                        items_names = dataGridView1.Rows[i].Cells["raw_m"].Value.ToString();
                        c_name = dataGridView1.Rows[i].Cells["co_name"].Value.ToString();
                        quanty = dataGridView1.Rows[i].Cells["qty"].Value.ToString();
                        bags = dataGridView1.Rows[i].Cells["bag_o"].Value.ToString();
                        totals = dataGridView1.Rows[i].Cells["t_qty"].Value.ToString();
                        ucost = dataGridView1.Rows[i].Cells["cost_i"].Value.ToString();
                        cost_1 = dataGridView1.Rows[i].Cells["co"].Value.ToString();
                        cost_2 = dataGridView1.Rows[i].Cells["total_cost"].Value.ToString();
                        tex_rate = dataGridView1.Rows[i].Cells["tex"].Value.ToString();
                        dis_rate = dataGridView1.Rows[i].Cells["discount"].Value.ToString();
                        t_a = dataGridView1.Rows[i].Cells["tex_A"].Value.ToString();
                        bag_ctn_c = dataGridView1.Rows[i].Cells["ctn_co"].Value.ToString();

                        connection_check();
                        try
                        {
                            MySqlCommand sel_deb = new MySqlCommand("select total_kg_p from fsm_voucher where raw_name='" + items_names + "' and branch_n='" + Login.branch + "'", conn);
                            sel_deb.ExecuteNonQuery();
                            MySqlDataReader deb_dr = sel_deb.ExecuteReader();
                            while (deb_dr.Read())
                            {
                                sumqty = deb_dr[0].ToString();
                            }
                            deb_dr.Dispose();
                        }
                        catch (Exception ex)
                        {

                            connection_check();

                        }


                        if (sumqty == null)
                        {
                            connection_check();
                            try
                            {
                                try
                                {
                                    connection_check();
                                    MySqlCommand setupalll = new MySqlCommand("Insert into fsm_voucher (invoice_ID,invoice_code,invoice_number,branch_n,raw_name,supplier,weight,bag,total_kg_p,rema_qty,cost,Tex,Discount,total_cost,invoice_date,invoice_time,pc_name,domain,tax_amount,ctn_cost,Status,login_user,unit_cost) Values('" + new_Id + "','" + text_in_id.Text + "','" + inv_num.Text + "','" + Login.branch + "','" + items_names + "','" + c_name + "','" + quanty + "' , '" + bags + "','" + totals + "','" + totals + "','" + cost_1 + "','" + tex_rate + "','" + dis_rate + "','" + cost_2 + "' ,'" + DateTime.UtcNow.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss:tt") + "' ,'" + hostName + "','" + myIP + "','" + t_a + "','" + bag_ctn_c + "','for production','" + Login.user_n + "','" + ucost + "') ", conn);
                                    setupalll.ExecuteNonQuery();
                                    setupalll.Dispose();
                                }
                                catch (Exception ex)
                                {

                                    connection_check();
                                }
                                try
                                {
                                    connection_check();
                                    MySqlCommand setupall2 = new MySqlCommand("Insert into fsm_voucher_log (invoice_ID,invoice_code,invoice_number,branch_n,raw_name,supplier,weight,bag,total_kg_p,rema_qty,cost,Tex,Discount,total_cost,invoice_date,invoice_time,pc_name,domain,tax_amount,ctn_cost,Status,login_user,unit_cost) Values('" + new_Id + "','" + text_in_id.Text + "','" + inv_num.Text + "','" + Login.branch + "','" + items_names + "','" + c_name + "','" + quanty + "' , '" + bags + "','" + totals + "','" + totals + "','" + cost_1 + "','" + tex_rate + "','" + dis_rate + "','" + cost_2 + "' ,'" + DateTime.UtcNow.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss:tt") + "' ,'" + hostName + "','" + myIP + "','" + t_a + "','" + bag_ctn_c + "','for production','" + Login.user_n + "','" + ucost + "') ", conn);
                                    setupall2.ExecuteNonQuery();
                                    setupall2.Dispose();

                                }
                                catch (Exception ex)
                                {

                                    connection_check();
                                }

                            }
                            catch (Exception ex)
                            {
                                connection_check();

                                MessageBox.Show(ex.Message);
                            }

                            add_label.Visible = true;

                        }
                        else if (sumqty != null)
                        {
                            connection_check();
                            try
                            {
                                qty_t = Convert.ToDouble(totals) + Convert.ToDouble(sumqty);
                                MySqlCommand in_upd = new MySqlCommand("Update fsm_voucher set total_kg_p='" + Convert.ToString(qty_t) + "', rema_qty='" + Convert.ToString(qty_t) + "' where raw_name='" + items_names + "' and branch_n ='" + Login.branch + "'", conn);
                                in_upd.ExecuteNonQuery();
                                in_upd.Dispose();
                            }
                            catch (Exception ex)
                            {

                            }

                            try
                            {
                                connection_check();
                                MySqlCommand setupall22 = new MySqlCommand("Insert into fsm_voucher_log (invoice_ID,invoice_code,invoice_number,branch_n,raw_name,supplier,weight,bag,total_kg_p,rema_qty,cost,Tex,Discount,total_cost,invoice_date,invoice_time,pc_name,domain,tax_amount,ctn_cost,Status,login_user,unit_cost) Values('" + new_Id + "','" + text_in_id.Text + "','" + inv_num.Text + "','" + Login.branch + "','" + items_names + "','" + c_name + "','" + quanty + "' , '" + bags + "','" + totals + "','" + totals + "','" + cost_1 + "','" + tex_rate + "','" + dis_rate + "','" + cost_2 + "' ,'" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss:tt") + "' ,'" + hostName + "','" + myIP + "','" + t_a + "','" + bag_ctn_c + "','for production','" + Login.user_n + "','" + ucost + "') ", conn);
                                setupall22.ExecuteNonQuery();
                                setupall22.Dispose();
                                add_label.Visible = true;
                            }
                            catch (Exception ex)
                            {

                                connection_check();
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
                report();
                label2.Text = "0";
                label4.Text = "0";
                raw_ibox.Text = "";
                invoice_id.Text = "";
                company_box.Text = "";
                checkBox3.Checked = false;
                //Bind_Grid0();
                //Bind_Grid27();
                //Bind_Grid23();
                //getvoucher_rw();
                //getvoucher_fg();

            }
        }

        public void report()
        {
            connection_check();
            try
            {
                DataSet ddd = new DataSet();
                DataTable dtdd = ddd.Tables.Add("voucher");

                dtdd.Columns.Add("supplier", Type.GetType("System.String"));
                dtdd.Columns.Add("item", Type.GetType("System.String"));
                dtdd.Columns.Add("weight", Type.GetType("System.String"));
                dtdd.Columns.Add("bag", Type.GetType("System.String"));
                dtdd.Columns.Add("total", Type.GetType("System.String"));
                dtdd.Columns.Add("voucher_id", Type.GetType("System.String"));
                //dt.Columns.Add("reicever", Type.GetType("System.String"));
                dtdd.Columns.Add("time", Type.GetType("System.String"));
                dtdd.Columns.Add("invoice", Type.GetType("System.String"));
                dtdd.Columns.Add("date", Type.GetType("System.DateTime"));
                dtdd.Columns.Add("companay_address", Type.GetType("System.String"));
                dtdd.Columns.Add("companay_name", Type.GetType("System.String"));
                dtdd.Columns.Add("user_login", Type.GetType("System.String"));
                dtdd.Columns.Add("branch", Type.GetType("System.String"));

                try
                {
                    DataRow rddd;
                    connection_check();
                    MySqlCommand commander = new MySqlCommand("select supplier,raw_name,weight,bag,total_kg_p,invoice_number ,invoice_date,invoice_time,invoice_code,login_user from fsm_voucher_log where invoice_number = '" + inv_num.Text + "' and branch_n = '" + Login.branch + "' ;", conn);
                    commander.ExecuteNonQuery();
                    MySqlDataReader reader = commander.ExecuteReader();
                    while (reader.Read())
                    {
                        rddd = dtdd.NewRow();
                        string aa = reader[0].ToString();
                        rddd["supplier"] = aa;
                        rddd["item"] = reader[1].ToString();
                        rddd["weight"] = reader[2].ToString();
                        rddd["bag"] = reader[3].ToString();
                        rddd["total"] = reader[4].ToString();
                        rddd["voucher_id"] = reader[5].ToString();
                        rddd["date"] = reader[6].ToString();
                        rddd["time"] = reader[7].ToString(); ;
                        // r["reicever"] = reader[7].ToString();
                        rddd["invoice"] = reader[8].ToString();
                        rddd["user_login"] = reader[9].ToString();
                        rddd["branch"] = Login.branch;

                        dtdd.Rows.Add(rddd);

                    }
                    reader.Dispose();
                    commander.Dispose();

                    report_vaucher ar = new report_vaucher();
                    ar.SetDataSource(dtdd);
                    report_view vv = new report_view();

                    vv.crystalReportViewer1.ReportSource = ar;
                    vv.crystalReportViewer1.Refresh();
                    vv.Show();
                }
                catch (Exception ex)
                {


                }



            }
            catch (Exception ex)
            {

                // MessageBox.Show(ex.Message);
            }


        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            connection_check();
            add_label.Visible = false;
            // update_label.Visible = false;

            try
            {
                report();

            }
            catch (Exception ex)
            {
                connection_check();
                //MessageBox.Show(ex.Message);
            }



        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            connection_check();
            try
            {
                if (textBox5.Text != "")
                {
                    connection_check();
                    MySqlCommand setupall3 = new MySqlCommand("Delete  from fsm_null where raw_name='" + textBox5.Text + "' and branch_n = '" + Login.branch + "' ", conn);
                    setupall3.ExecuteNonQuery();
                    setupall3.Dispose();
                    textBox5.Text = "";
                    Bind_Grid0();
                }
            }
            catch (Exception ex)
            {


            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            connection_check();
            if (company_box.Text == "" || company_box.Text == null)
            {
                MessageBox.Show("Please Type a Supplier Name!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    connection_check();
                    MySqlCommand ins = new MySqlCommand("insert into company(c_name) Values ('" + company_box.Text + "')", conn);
                    ins.ExecuteNonQuery();
                    ins.Dispose();
                    MessageBox.Show("This Role is now Added to the record!", "record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {

                    // MessageBox.Show(ex.Message);
                }
                company_box.Text = "";
                getcom_name();

            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            connection_check();
            if (company_box.Text == "" || company_box.Text == null)
            {
                MessageBox.Show("Please Select a Supplier Name!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    company_box.Items.Clear();
                    MySqlCommand ds = new MySqlCommand("delete from company where c_name=('" + company_box.Text + "')", conn);
                    ds.ExecuteNonQuery();
                    ds.Dispose();
                    MessageBox.Show("This Role is Delete from the record!", "Record deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);

                }
                company_box.Text = "";
                getcom_name();
            }
        }

        private void direct_to_mainstore()
        {
            connection_check();
            string sumqty2 = "";
            string sumqty3 = "";

            if (inv_num.Text == "" || company_box.Text == "")
            {
                if (inv_num.Text == "")
                {
                    string myStringVariable1 = string.Empty;
                    MessageBox.Show("Invoice number is required");
                }
                else if (company_box.Text == "")
                {
                    string myStringVariable2 = string.Empty;
                    MessageBox.Show("Supplier Name is requierd");
                }
            }

            else
            {



                connection_check();//MessageBox.Show(ex.Message);


                try
                {
                    connection_check();
                    string Last_Id = "";
                    MySqlCommand sel_id = new MySqlCommand("select ID from fsm_voucher_log ;", conn);
                    sel_id.ExecuteNonQuery();
                    MySqlDataReader drr_id = sel_id.ExecuteReader();
                    while (drr_id.Read())
                    {
                        Last_Id = drr_id[0].ToString();
                    }
                    drr_id.Dispose();
                    if (Last_Id == "")
                    {
                        Last_Id = "1";
                    }
                    else if (Last_Id != "")
                    {
                        new_Id = Convert.ToInt32(Last_Id);
                        invoice_id.Text = 1 + Convert.ToString(new_Id);
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                try
                {
                    connection_check();
                    MySqlCommand setupall3 = new MySqlCommand("Delete  from fsm_null where invoice_no ='" + inv_num.Text + "' and branch_n = '" + Login.branch + "' ", conn);
                    setupall3.ExecuteNonQuery();
                    setupall3.Dispose();

                }
                catch (Exception ex)
                {
                }

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    new_Id++;

                    try
                    {

                        items_names = dataGridView1.Rows[i].Cells["raw_m"].Value.ToString();
                        c_name = dataGridView1.Rows[i].Cells["co_name"].Value.ToString();
                        quanty = dataGridView1.Rows[i].Cells["qty"].Value.ToString();
                        bags = dataGridView1.Rows[i].Cells["bag_o"].Value.ToString();
                        totals = dataGridView1.Rows[i].Cells["t_qty"].Value.ToString();
                        ucost = dataGridView1.Rows[i].Cells["cost_i"].Value.ToString();
                        cost_1 = dataGridView1.Rows[i].Cells["co"].Value.ToString();
                        cost_2 = dataGridView1.Rows[i].Cells["total_cost"].Value.ToString();
                        tex_rate = dataGridView1.Rows[i].Cells["tex"].Value.ToString();
                        dis_rate = dataGridView1.Rows[i].Cells["discount"].Value.ToString();
                        t_a = dataGridView1.Rows[i].Cells["tex_A"].Value.ToString();
                        bag_ctn_c = dataGridView1.Rows[i].Cells["ctn_co"].Value.ToString();

                        //connection_check();
                        //try
                        //{
                        //    MySqlCommand sel_deb = new MySqlCommand("select qty from fsm_mainstore where item='" + items_names + "' and branch_n='" + Login.branch + "'", conn);
                        //    sel_deb.ExecuteNonQuery();
                        //    MySqlDataReader deb_dr = sel_deb.ExecuteReader();
                        //    while (deb_dr.Read())
                        //    {
                        //        sumqty = deb_dr[0].ToString();
                        //    }
                        //    deb_dr.Dispose();
                        //}
                        //catch (Exception ex)
                        //{
                        //    MessageBox.Show(ex.Message);
                        //    connection_check();

                        //}
                        connection_check();
                        try
                        {
                            MySqlCommand sel_deb2 = new MySqlCommand("select barcode from fsm_pro_pricing where cat_name='" + items_names + "' ", conn);
                            sel_deb2.ExecuteNonQuery();
                            MySqlDataReader deb_dr2 = sel_deb2.ExecuteReader();
                            while (deb_dr2.Read())
                            {
                                sumqty2 = deb_dr2[0].ToString();
                            }
                            deb_dr2.Dispose();
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show(ex.Message);
                            connection_check();

                        }
                        try
                        {
                            MySqlCommand sel_deb3 = new MySqlCommand("select cat_name from fsm_pro_pricing where cat_name='" + items_names + "' ", conn);
                            sel_deb3.ExecuteNonQuery();
                            MySqlDataReader deb_dr3 = sel_deb3.ExecuteReader();
                            while (deb_dr3.Read())
                            {
                                sumqty3 = deb_dr3[0].ToString();
                            }
                            deb_dr3.Dispose();
                        }
                        catch (Exception ex)
                        {
                            // MessageBox.Show(ex.Message);
                            connection_check();

                        }
                        if (sumqty3 == null)
                        {
                            try
                            {
                                connection_check();
                                MySqlCommand setupall211 = new MySqlCommand("Insert into fsm_pro_pricing (cat_name) Values('" + items_names + "') ", conn);
                                setupall211.ExecuteNonQuery();
                                setupall211.Dispose();
                            }
                            catch (Exception ex)
                            {

                                connection_check();
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else if (sumqty3 != null)
                        {

                        }
                        //if (sumqty == null)
                        //{
                        connection_check();
                        try
                        {
                            try
                            {
                                connection_check();
                                MySqlCommand setupall2 = new MySqlCommand("Insert into fsm_mainstore (barcode,branch_n,item,qty,ms_data,ms_time,pc_name,domain,Status,login_user) Values('" + sumqty2 + "','" + Login.branch + "','" + items_names + "','" + totals + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss:tt") + "','" + hostName + "','" + myIP + "','Finished Goods','" + Login.user_n + "') ", conn);
                                setupall2.ExecuteNonQuery();
                                setupall2.Dispose();
                            }
                            catch (Exception ex)
                            {

                                connection_check();
                                MessageBox.Show(ex.Message);
                            }
                            try
                            {
                                connection_check();
                                MySqlCommand setupall21 = new MySqlCommand("Insert into fsm_voucher_log (unit_cost,barcode,invoice_ID,invoice_code,invoice_number,branch_n,raw_name,supplier,weight,bag,total_kg_p,rema_qty,cost,Tex,Discount,total_cost,invoice_date,invoice_time,pc_name,domain,tax_amount,ctn_cost,Status,login_user) Values('" + ucost + "','" + sumqty2 + "','" + new_Id + "','" + text_in_id.Text + "','" + inv_num.Text + "','" + Login.branch + "','" + items_names + "','" + c_name + "','" + quanty + "' , '" + bags + "','" + totals + "','" + totals + "','" + cost_1 + "','" + tex_rate + "','" + dis_rate + "','" + cost_2 + "' ,'" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss:tt") + "' ,'" + hostName + "','" + myIP + "','" + t_a + "','" + bag_ctn_c + "','Finished Goods','" + Login.user_n + "') ", conn);
                                setupall21.ExecuteNonQuery();
                                setupall21.Dispose();

                            }
                            catch (Exception ex)
                            {

                                connection_check();
                                // MessageBox.Show(ex.Message);
                            }

                        }
                        catch (Exception ex)
                        {
                            connection_check();

                            MessageBox.Show(ex.Message);
                        }

                        add_label.Visible = true;

                        //    }
                        //    else if (sumqty != null)
                        //    {
                        //        try
                        //        {
                        //            connection_check();
                        //            qty_t = Convert.ToDouble(totals) + Convert.ToDouble(sumqty);
                        //            MySqlCommand in_upd = new MySqlCommand("Update fsm_mainstore set barcode='" + sumqty2 + "' , qty='" + Convert.ToString(qty_t) + "' where item='" + items_names + "' and branch_n ='" + Login.branch + "'", conn);
                        //            in_upd.ExecuteNonQuery();
                        //            in_upd.Dispose();

                        //        }
                        //        catch (Exception ex)
                        //        {
                        //        }
                        //        try
                        //        {
                        //            connection_check();
                        //            qty_t = Convert.ToDouble(totals) + Convert.ToDouble(sumqty);
                        //            MySqlCommand in_upd = new MySqlCommand("Update fsm_voucher set barcode='" + sumqty2 + "',total_kg_p='" + Convert.ToString(qty_t) + "', rema_qty='" + Convert.ToString(qty_t) + "' where raw_name='" + items_names + "' and branch_n ='" + Login.branch + "'", conn);
                        //            in_upd.ExecuteNonQuery();
                        //            in_upd.Dispose();

                        //        }
                        //        catch (Exception ex)
                        //        { }

                        //        try
                        //        {
                        //            connection_check();
                        //            MySqlCommand setupall22 = new MySqlCommand("Insert into fsm_voucher_log (unit_cost,barcode,invoice_ID,invoice_code,invoice_number,branch_n,raw_name,supplier,weight,bag,total_kg_p,cost,Tex,Discount,total_cost,invoice_date,invoice_time,pc_name,domain,tax_amount,ctn_cost,Status,login_user) Values('"+ucost+"','" + sumqty2 + "','" + new_Id + "','" + text_in_id.Text + "','" + inv_num.Text + "','" + Login.branch + "','" + items_names + "','" + c_name + "','" + quanty + "' , '" + bags + "','" + totals + "','" + cost_1 + "','" + tex_rate + "','" + dis_rate + "','" + cost_2 + "' ,'" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss:tt") + "' ,'" + hostName + "','" + myIP + "','" + t_a + "','" + bag_ctn_c + "','Finshed','" + Login.user_n + "') ", conn);
                        //            setupall22.ExecuteNonQuery();
                        //            setupall22.Dispose();
                        //            add_label.Visible = true;
                        //        }
                        //        catch (Exception ex)
                        //        {

                        //            connection_check();
                        //            MessageBox.Show(ex.Message);
                        //        }

                        //    }
                        //}
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }


                }



                report();
                label2.Text = "0";
                label4.Text = "0";
                raw_ibox.Text = "";
                invoice_id.Text = "";
                company_box.Text = "";
                checkBox3.Checked = false;
                //Bind_Grid0();
                //Bind_Grid27();
                //Bind_Grid23();
                //Bind_Grid39();
                //Bind_Grid19();
                //getvoucher_rw();
                //getvoucher_fg();


            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            connection_check();
            // MessageBox.Show("","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (checkBox3.Checked == true)
            {

                DialogResult dlg = MessageBox.Show("Are you sure you want to Send these Products Diretly to Main Store? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    direct_to_mainstore();
                    inv_num.Text = "Nill";
                    Bind_Grid0();
                    save_btn.Enabled = false;
                }

            }
            else if (checkBox3.Checked == false)
            {
                DialogResult dlg1 = MessageBox.Show("Are you sure you want to Send these Item For Production?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg1 == DialogResult.Yes)
                {
                    for_production();
                    inv_num.Text = "Nill";
                    Bind_Grid0();
                    save_btn.Enabled = false;
                }

            }
          
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                progressBar3.Value = e.ProgressPercentage;
                label111.Text = e.ProgressPercentage + "%";
                progressBar3.Update();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                for (int i = 0; i < 100; i++)
                {

                    System.Threading.Thread.Sleep(100);

                    backgroundWorker1.ReportProgress(i);

                }
                conn.Open();
            }
            catch (Exception ex)
            {

                //  throw;
            }


            return;

        }

        private void fs_voucher_Load(object sender, EventArgs e)
        {
            hostName = Dns.GetHostName();
            myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();

            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }

            /////////////////---------Data Grid View 1 Design---------\\\\\\\\\\\\\\\\\\\

            dataGridView1.BorderStyle = BorderStyle.FixedSingle;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            connection_check();

            string i_raw = "";
            int rowindex = e.RowIndex;
            int col = e.ColumnIndex;
            double t_q = 0;
            double t_p = 0;


            if (dataGridView1.Rows[rowindex].Cells["raw_m"].Value == null)
            {
                dataGridView1.Rows[rowindex].Cells["raw_m"].Value = raw_ibox.Text;
            }
            if (dataGridView1.Rows[rowindex].Cells["co_name"].Value == "")
            {
                dataGridView1.Rows[rowindex].Cells["co_name"].Value = company_box.Text;
            }

            if (col == 4)
            {
                try
                {
                    quanty = dataGridView1.Rows[rowindex].Cells["qty"].Value.ToString();
                }
                catch (Exception ex)
                {

                    quanty = "0";
                }

                try
                {
                    bags = dataGridView1.Rows[rowindex].Cells["bag_o"].Value.ToString();
                    if (bags == "")
                    {
                        bags = "1";
                        dataGridView1.Rows[rowindex].Cells["bag_o"].Value = "1";
                    }
                }
                catch (Exception ex)
                {

                    bags = "1";
                    dataGridView1.Rows[rowindex].Cells["bag_o"].Value = "1";
                }
                try
                {
                    dataGridView1.Rows[rowindex].Cells["t_qty"].Value = Convert.ToString(Convert.ToDouble(quanty) * Convert.ToDouble(bags));
                }
                catch (Exception ex)
                {


                }


                try
                {
                    unitcost = dataGridView1.Rows[rowindex].Cells["cost_i"].Value.ToString();
                    if (unitcost == "")
                    {
                        unitcost = "1";
                        dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";
                    }

                }
                catch (Exception ex)
                {
                    unitcost = "1";
                    dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";

                }
                try
                {
                    cocost = dataGridView1.Rows[rowindex].Cells["co"].Value.ToString();
                    if (cocost == "")
                    {
                        cocost = "1";
                        dataGridView1.Rows[rowindex].Cells["co"].Value = "1";
                    }
                }
                catch (Exception ex)
                {
                    cocost = "1";
                    dataGridView1.Rows[rowindex].Cells["co"].Value = "1";

                }
                try
                {
                    quanty = dataGridView1.Rows[rowindex].Cells["qty"].Value.ToString();
                }
                catch (Exception ex)
                {

                    quanty = "0";
                }
                try
                {
                    dataGridView1.Rows[rowindex].Cells["ctn_co"].Value = Convert.ToString(Convert.ToDouble(quanty) * Convert.ToDouble(cocost));
                    ctncost = dataGridView1.Rows[rowindex].Cells["ctn_co"].Value.ToString();
                    if (ctncost == "")
                    {
                        ctncost = "1";
                        dataGridView1.Rows[rowindex].Cells["ctn_co"].Value = "1";
                    }
                }
                catch (Exception ex)
                {
                    ctncost = "1";
                    dataGridView1.Rows[rowindex].Cells["ctn_co"].Value = "1";

                }

                try
                {
                    texrate = dataGridView1.Rows[rowindex].Cells["tex"].Value.ToString();
                    if (texrate == "")
                    {
                        texrate = "0";
                        dataGridView1.Rows[rowindex].Cells["tex"].Value = "0";
                    }
                }
                catch (Exception ex)
                {
                    texrate = "0";
                    dataGridView1.Rows[rowindex].Cells["tex"].Value = "0";

                }
                try
                {
                    tex_amount = dataGridView1.Rows[rowindex].Cells["tex_A"].Value.ToString();
                    if (tex_amount == "")
                    {
                        tex_amount = "0";
                        dataGridView1.Rows[rowindex].Cells["tex_A"].Value = "0";
                    }
                }
                catch (Exception ex)
                {
                    texrate = "0";
                    dataGridView1.Rows[rowindex].Cells["tex"].Value = "0";

                }
                try
                {
                    tqty = dataGridView1.Rows[rowindex].Cells["t_qty"].Value.ToString();
                }
                catch (Exception ex)
                {


                }

                try
                {
                    disrate = dataGridView1.Rows[rowindex].Cells["discount"].Value.ToString();
                    if (disrate == "")
                    {
                        disrate = "0";
                        dataGridView1.Rows[rowindex].Cells["discount"].Value = "0";
                    }
                }
                catch (Exception ex)
                {
                    disrate = "0";
                    dataGridView1.Rows[rowindex].Cells["discount"].Value = "0";

                }
                try
                {

                    dataGridView1.Rows[rowindex].Cells["total_cost"].Value = Convert.ToString(Convert.ToDouble(unitcost) * Convert.ToDouble(tqty));

                }
                catch (Exception ex)
                {


                }
            }
            if (col == 5)
            {
                try
                {
                    quanty = dataGridView1.Rows[rowindex].Cells["qty"].Value.ToString();
                }
                catch (Exception ex)
                {

                    quanty = "0";
                }
                try
                {

                    bags = dataGridView1.Rows[rowindex].Cells["bag_o"].Value.ToString();
                    if (bags == "")
                    {
                        bags = "1";
                        dataGridView1.Rows[rowindex].Cells["bag_o"].Value = "1";
                    }
                }
                catch (Exception ex)
                {

                    bags = "1";
                    dataGridView1.Rows[rowindex].Cells["bag_o"].Value = "1";
                }
                try
                {
                    unitcost = dataGridView1.Rows[rowindex].Cells["cost_i"].Value.ToString();
                    if (unitcost == "")
                    {
                        unitcost = "1";
                        dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";
                    }

                }
                catch (Exception ex)
                {
                    unitcost = "1";
                    dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";

                }
                try
                {
                    cocost = dataGridView1.Rows[rowindex].Cells["co"].Value.ToString();
                    if (cocost == "")
                    {
                        cocost = "1";
                        dataGridView1.Rows[rowindex].Cells["co"].Value = "1";
                    }
                }
                catch (Exception ex)
                {
                    cocost = "1";
                    dataGridView1.Rows[rowindex].Cells["co"].Value = "1";

                }
                try
                {
                    dataGridView1.Rows[rowindex].Cells["t_qty"].Value = Convert.ToString(Convert.ToDouble(quanty) * Convert.ToDouble(bags));
                }
                catch (Exception ex)
                {


                }

                try
                {
                    tqty = dataGridView1.Rows[rowindex].Cells["t_qty"].Value.ToString();
                }
                catch (Exception ex)
                {


                }
                try
                {
                    dataGridView1.Rows[rowindex].Cells["total_cost"].Value = Convert.ToString(Convert.ToDouble(cocost) * Convert.ToDouble(tqty));
                }
                catch (Exception ex)
                {

                }
                try
                {
                    unitcost = dataGridView1.Rows[rowindex].Cells["cost_i"].Value.ToString();
                    if (unitcost == "")
                    {
                        unitcost = "1";
                        dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";
                    }

                }
                catch (Exception exc)
                {
                    unitcost = "1";
                    dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";

                }
                try
                {
                    cocost = dataGridView1.Rows[rowindex].Cells["co"].Value.ToString();
                    if (cocost == "")
                    {
                        cocost = "1";
                        dataGridView1.Rows[rowindex].Cells["co"].Value = "1";
                    }
                }
                catch (Exception exc)
                {
                    cocost = "1";
                    dataGridView1.Rows[rowindex].Cells["co"].Value = "1";

                }
                try
                {
                    quanty = dataGridView1.Rows[rowindex].Cells["qty"].Value.ToString();
                }
                catch (Exception exc)
                {

                    quanty = "0";
                }
                try
                {
                    dataGridView1.Rows[rowindex].Cells["ctn_co"].Value = Convert.ToString(Convert.ToDouble(quanty) * Convert.ToDouble(cocost));
                    ctncost = dataGridView1.Rows[rowindex].Cells["ctn_co"].Value.ToString();
                    if (ctncost == "")
                    {
                        ctncost = "1";
                        dataGridView1.Rows[rowindex].Cells["ctn_co"].Value = "1";
                    }
                }
                catch (Exception exc)
                {
                    ctncost = "1";
                    dataGridView1.Rows[rowindex].Cells["ctn_co"].Value = "1";

                }
                try
                {
                    totalcost = dataGridView1.Rows[rowindex].Cells["total_cost"].Value.ToString();
                }
                catch (Exception exc)
                { }
                try
                {
                    texrate = dataGridView1.Rows[rowindex].Cells["tex"].Value.ToString();
                    if (texrate == "")
                    {
                        texrate = "0";
                        dataGridView1.Rows[rowindex].Cells["tex"].Value = "0";
                    }
                }
                catch (Exception exc)
                {
                    texrate = "0";
                    dataGridView1.Rows[rowindex].Cells["tex"].Value = "0";
                }
                try
                {
                    dataGridView1.Rows[rowindex].Cells["tex_A"].Value = Convert.ToString(Convert.ToDouble(totalcost) * (Convert.ToDouble(texrate) / 100));

                }
                catch (Exception exc)
                {


                }
            }
            if (col == 0)
            {
                try
                {
                    unitcost = dataGridView1.Rows[rowindex].Cells["cost_i"].Value.ToString();
                    if (unitcost == "")
                    {
                        unitcost = "1";
                        dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";
                    }
                }
                catch (Exception ex)
                {
                    unitcost = "1";
                    dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";

                }
                try
                {
                    cocost = dataGridView1.Rows[rowindex].Cells["co"].Value.ToString();
                    if (cocost == "")
                    {
                        cocost = "1";
                        dataGridView1.Rows[rowindex].Cells["co"].Value = "1";
                    }
                }
                catch (Exception ex)
                {
                    cocost = "1";
                    dataGridView1.Rows[rowindex].Cells["co"].Value = "1";

                }
                try
                {
                    texrate = dataGridView1.Rows[rowindex].Cells["tex"].Value.ToString();
                    if (texrate == "")
                    {
                        texrate = "0";
                        dataGridView1.Rows[rowindex].Cells["co"].Value = "0";
                    }
                }
                catch (Exception ex)
                {
                    texrate = "0";
                    dataGridView1.Rows[rowindex].Cells["tex"].Value = "0";

                }
                try
                {
                    per = (Convert.ToDouble(unitcost) * Convert.ToDouble(texrate) / 100).ToString();
                }
                catch (Exception ex)
                {


                }

                try
                {
                    tqty = dataGridView1.Rows[rowindex].Cells["t_qty"].Value.ToString();
                }
                catch (Exception ex)
                {


                }
                dataGridView1.Rows[rowindex].Cells["co"].Value = (Convert.ToDouble(per) + Convert.ToDouble(unitcost)).ToString();


                try
                {
                    cocost = dataGridView1.Rows[rowindex].Cells["co"].Value.ToString();
                    if (cocost == "")
                    {
                        cocost = "1";
                        dataGridView1.Rows[rowindex].Cells["co"].Value = "1";
                    }
                }
                catch (Exception ex)
                {


                }
                try
                {
                    dataGridView1.Rows[rowindex].Cells["total_cost"].Value = Convert.ToString(Convert.ToDouble(cocost) * Convert.ToDouble(tqty));
                }
                catch (Exception ex)
                {


                }
                try
                {
                    unitcost = dataGridView1.Rows[rowindex].Cells["cost_i"].Value.ToString();
                    if (unitcost == "")
                    {
                        unitcost = "1";
                        dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";
                    }

                }
                catch (Exception exc)
                {
                    unitcost = "1";
                    dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";

                }
                try
                {
                    cocost = dataGridView1.Rows[rowindex].Cells["co"].Value.ToString();
                    if (cocost == "")
                    {
                        cocost = "1";
                        dataGridView1.Rows[rowindex].Cells["co"].Value = "1";
                    }
                }
                catch (Exception exc)
                {
                    cocost = "1";
                    dataGridView1.Rows[rowindex].Cells["co"].Value = "1";

                }
                try
                {
                    quanty = dataGridView1.Rows[rowindex].Cells["qty"].Value.ToString();
                }
                catch (Exception exc)
                {

                    quanty = "0";
                }
                try
                {
                    dataGridView1.Rows[rowindex].Cells["ctn_co"].Value = Convert.ToString(Convert.ToDouble(quanty) * Convert.ToDouble(cocost));
                    ctncost = dataGridView1.Rows[rowindex].Cells["ctn_co"].Value.ToString();
                    if (ctncost == "")
                    {
                        ctncost = "1";
                        dataGridView1.Rows[rowindex].Cells["ctn_co"].Value = "1";
                    }
                }
                catch (Exception exc)
                {
                    ctncost = "1";
                    dataGridView1.Rows[rowindex].Cells["ctn_co"].Value = "1";

                }




                try
                {
                    totalcost = dataGridView1.Rows[rowindex].Cells["total_cost"].Value.ToString();
                }
                catch (Exception ex)
                { }
                try
                {
                    texrate = dataGridView1.Rows[rowindex].Cells["tex"].Value.ToString();
                    if (texrate == "")
                    {
                        texrate = "0";
                        dataGridView1.Rows[rowindex].Cells["tex"].Value = "0";
                    }
                }
                catch (Exception ex)
                {
                    texrate = "0";
                    dataGridView1.Rows[rowindex].Cells["tex"].Value = "0";
                }
                try
                {
                    dataGridView1.Rows[rowindex].Cells["tex_A"].Value = Convert.ToString(Convert.ToDouble(totalcost) * (Convert.ToDouble(texrate) / 100));

                }
                catch (Exception ex)
                {


                }
                dataGridView1.Rows[rowindex].Cells["discount"].Value = "0";

            }
            {
                if (col == 8)
                {
                    try
                    {
                        unitcost = dataGridView1.Rows[rowindex].Cells["cost_i"].Value.ToString();
                        if (unitcost == "")
                        {
                            unitcost = "1";
                            dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";
                        }

                    }
                    catch (Exception exc)
                    {
                        unitcost = "1";
                        dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";

                    }
                    try
                    {
                        cocost = dataGridView1.Rows[rowindex].Cells["co"].Value.ToString();
                        if (cocost == "")
                        {
                            cocost = "1";
                            dataGridView1.Rows[rowindex].Cells["co"].Value = "1";
                        }
                    }
                    catch (Exception exc)
                    {
                        cocost = "1";
                        dataGridView1.Rows[rowindex].Cells["co"].Value = "1";

                    }
                    try
                    {
                        quanty = dataGridView1.Rows[rowindex].Cells["qty"].Value.ToString();
                    }
                    catch (Exception exc)
                    {

                        quanty = "0";
                    }
                    try
                    {
                        ctncost = dataGridView1.Rows[rowindex].Cells["ctn_co"].Value.ToString();
                        if (ctncost == "")
                        {
                            ctncost = "1";
                            dataGridView1.Rows[rowindex].Cells["ctn_co"].Value = "1";
                        }
                    }
                    catch (Exception exc)
                    {

                        quanty = "0";
                    }
                    try
                    {
                        dataGridView1.Rows[rowindex].Cells["cost_i"].Value = Convert.ToString(Convert.ToDouble(ctncost) / Convert.ToDouble(quanty));
                        unitcost = dataGridView1.Rows[rowindex].Cells["cost_i"].Value.ToString();
                        if (ctncost == "")
                        {
                            ctncost = "1";
                            dataGridView1.Rows[rowindex].Cells["ctn_co"].Value = "1";
                        }
                    }
                    catch (Exception exc)
                    {
                        ctncost = "1";
                        dataGridView1.Rows[rowindex].Cells["ctn_co"].Value = "1";

                    }



                    try
                    {
                        unitcost = dataGridView1.Rows[rowindex].Cells["cost_i"].Value.ToString();
                        if (unitcost == "")
                        {
                            unitcost = "1";
                            dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";
                        }
                    }
                    catch (Exception ex)
                    {
                        unitcost = "1";
                        dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";

                    }
                    try
                    {
                        cocost = dataGridView1.Rows[rowindex].Cells["co"].Value.ToString();
                        if (cocost == "")
                        {
                            cocost = "1";
                            dataGridView1.Rows[rowindex].Cells["co"].Value = "1";
                        }
                    }
                    catch (Exception ex)
                    {
                        cocost = "1";
                        dataGridView1.Rows[rowindex].Cells["co"].Value = "1";

                    }
                    try
                    {
                        texrate = dataGridView1.Rows[rowindex].Cells["tex"].Value.ToString();
                        if (texrate == "")
                        {
                            texrate = "0";
                            dataGridView1.Rows[rowindex].Cells["co"].Value = "0";
                        }
                    }
                    catch (Exception ex)
                    {
                        texrate = "0";
                        dataGridView1.Rows[rowindex].Cells["tex"].Value = "0";

                    }
                    try
                    {
                        per = (Convert.ToDouble(unitcost) * Convert.ToDouble(texrate) / 100).ToString();
                    }
                    catch (Exception ex)
                    {


                    }

                    try
                    {
                        tqty = dataGridView1.Rows[rowindex].Cells["t_qty"].Value.ToString();
                    }
                    catch (Exception ex)
                    {


                    }
                    dataGridView1.Rows[rowindex].Cells["co"].Value = (Convert.ToDouble(per) + Convert.ToDouble(unitcost)).ToString();


                    try
                    {
                        cocost = dataGridView1.Rows[rowindex].Cells["co"].Value.ToString();
                        if (cocost == "")
                        {
                            cocost = "1";
                            dataGridView1.Rows[rowindex].Cells["co"].Value = "1";
                        }
                    }
                    catch (Exception ex)
                    {


                    }
                    try
                    {
                        dataGridView1.Rows[rowindex].Cells["total_cost"].Value = Convert.ToString(Convert.ToDouble(cocost) * Convert.ToDouble(tqty));
                    }
                    catch (Exception ex)
                    {


                    }


                    try
                    {
                        totalcost = dataGridView1.Rows[rowindex].Cells["total_cost"].Value.ToString();
                    }
                    catch (Exception ex)
                    { }
                    try
                    {
                        texrate = dataGridView1.Rows[rowindex].Cells["tex"].Value.ToString();
                        if (texrate == "")
                        {
                            texrate = "0";
                            dataGridView1.Rows[rowindex].Cells["tex"].Value = "0";
                        }
                    }
                    catch (Exception ex)
                    {
                        texrate = "0";
                        dataGridView1.Rows[rowindex].Cells["tex"].Value = "0";
                    }
                    try
                    {
                        dataGridView1.Rows[rowindex].Cells["tex_A"].Value = Convert.ToString(Convert.ToDouble(totalcost) * (Convert.ToDouble(texrate) / 100));

                    }
                    catch (Exception ex)
                    {


                    }
                    dataGridView1.Rows[rowindex].Cells["discount"].Value = "0";

                }
            }
            if (col == 9)
            {
                try
                {
                    unitcost = dataGridView1.Rows[rowindex].Cells["cost_i"].Value.ToString();
                    if (unitcost == "")
                    {
                        unitcost = "1";
                        dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";
                    }
                }
                catch (Exception ex)
                {
                    unitcost = "1";
                    dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";

                }
                try
                {
                    texrate = dataGridView1.Rows[rowindex].Cells["tex"].Value.ToString();
                    if (texrate == "")
                    {
                        texrate = "0";
                        dataGridView1.Rows[rowindex].Cells["tex"].Value = "0";
                    }
                }
                catch (Exception ex)
                {
                    texrate = "0";
                    dataGridView1.Rows[rowindex].Cells["tex"].Value = "0";

                }
                if (Convert.ToDouble(dataGridView1.Rows[rowindex].Cells["tex"].Value) > 100)
                {
                    dataGridView1.Rows[rowindex].Cells["tex"].Value = "0";
                }
                try
                {
                    unitcost = dataGridView1.Rows[rowindex].Cells["cost_i"].Value.ToString();
                    if (unitcost == "")
                    {
                        unitcost = "1";
                        dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";
                    }
                }
                catch (Exception ex)
                {
                    unitcost = "1";
                    dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";

                }
                try
                {
                    texrate = dataGridView1.Rows[rowindex].Cells["tex"].Value.ToString();
                    if (texrate == "")
                    {
                        texrate = "0";
                        dataGridView1.Rows[rowindex].Cells["tex"].Value = "0";
                    }
                }
                catch (Exception ex)
                {
                    texrate = "0";
                    dataGridView1.Rows[rowindex].Cells["tex"].Value = "0";

                }

                string per = (Convert.ToDouble(unitcost) * Convert.ToDouble(texrate) / 100).ToString();
                try
                {
                    tqty = dataGridView1.Rows[rowindex].Cells["t_qty"].Value.ToString();
                }
                catch (Exception ex)
                {


                }
                dataGridView1.Rows[rowindex].Cells["co"].Value = (Convert.ToDouble(per) + Convert.ToDouble(unitcost)).ToString();
                try
                {
                    cocost = dataGridView1.Rows[rowindex].Cells["co"].Value.ToString();
                }
                catch (Exception ex)
                {


                }
                try
                {
                    dataGridView1.Rows[rowindex].Cells["total_cost"].Value = Convert.ToString(Convert.ToDouble(cocost) * Convert.ToDouble(tqty));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                try
                {
                    unitcost = dataGridView1.Rows[rowindex].Cells["cost_i"].Value.ToString();
                    if (unitcost == "")
                    {
                        unitcost = "1";
                        dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";
                    }

                }
                catch (Exception exc)
                {
                    unitcost = "1";
                    dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";

                }
                try
                {
                    cocost = dataGridView1.Rows[rowindex].Cells["co"].Value.ToString();
                    if (cocost == "")
                    {
                        cocost = "1";
                        dataGridView1.Rows[rowindex].Cells["co"].Value = "1";
                    }
                }
                catch (Exception exc)
                {
                    cocost = "1";
                    dataGridView1.Rows[rowindex].Cells["co"].Value = "1";

                }
                try
                {
                    quanty = dataGridView1.Rows[rowindex].Cells["qty"].Value.ToString();
                }
                catch (Exception exc)
                {

                    quanty = "0";
                }
                try
                {
                    dataGridView1.Rows[rowindex].Cells["ctn_co"].Value = Convert.ToString(Convert.ToDouble(quanty) * Convert.ToDouble(cocost));
                    ctncost = dataGridView1.Rows[rowindex].Cells["ctn_co"].Value.ToString();
                    if (ctncost == "")
                    {
                        ctncost = "1";
                        dataGridView1.Rows[rowindex].Cells["ctn_co"].Value = "1";
                    }
                }
                catch (Exception exc)
                {
                    ctncost = "1";
                    dataGridView1.Rows[rowindex].Cells["ctn_co"].Value = "1";

                }

                try
                {
                    totalcost = dataGridView1.Rows[rowindex].Cells["total_cost"].Value.ToString();
                }
                catch (Exception ex)
                { }
                try
                {
                    texrate = dataGridView1.Rows[rowindex].Cells["tex"].Value.ToString();
                    if (texrate == "")
                    {
                        texrate = "0";
                        dataGridView1.Rows[rowindex].Cells["tex"].Value = "0";
                    }
                }
                catch (Exception ex)
                {
                    texrate = "0";
                    dataGridView1.Rows[rowindex].Cells["tex"].Value = "0";
                }
                try
                {
                    dataGridView1.Rows[rowindex].Cells["tex_A"].Value = Convert.ToString(Convert.ToDouble(totalcost) * (Convert.ToDouble(texrate) / 100));

                }
                catch (Exception ex)
                {


                }

            }

            if (col == 11)
            {
                try
                {
                    unitcost = dataGridView1.Rows[rowindex].Cells["cost_i"].Value.ToString();
                    if (unitcost == "")
                    {
                        unitcost = "1";
                        dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";
                    }
                }
                catch (Exception ex)
                {
                    unitcost = "1";
                    dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";

                }
                try
                {
                    disrate = dataGridView1.Rows[rowindex].Cells["discount"].Value.ToString();
                    if (disrate == "")
                    {
                        disrate = "0";
                        dataGridView1.Rows[rowindex].Cells["discount"].Value = "0";
                    }
                }
                catch (Exception ex)
                {
                    disrate = "0";
                    dataGridView1.Rows[rowindex].Cells["discount"].Value = "0";

                }
                if (Convert.ToDouble(dataGridView1.Rows[rowindex].Cells["discount"].Value) > Convert.ToDouble(dataGridView1.Rows[rowindex].Cells["cost_i"].Value))
                {
                    dataGridView1.Rows[rowindex].Cells["discount"].Value = "0";
                }
                //string per1 = (Convert.ToDouble(unitcost) * Convert.ToDouble(disrate) / 100).ToString();
                try
                {
                    tqty = dataGridView1.Rows[rowindex].Cells["t_qty"].Value.ToString();
                }
                catch (Exception ex)
                {


                }

                try
                {
                    cocost = dataGridView1.Rows[rowindex].Cells["co"].Value.ToString();
                }
                catch (Exception ex)
                {


                }
                try
                {
                    disrate = dataGridView1.Rows[rowindex].Cells["discount"].Value.ToString();
                    if (disrate == "")
                    {
                        disrate = "0";
                        dataGridView1.Rows[rowindex].Cells["discount"].Value = "0";
                    }
                }
                catch (Exception ex)
                {
                    disrate = "0";
                    dataGridView1.Rows[rowindex].Cells["discount"].Value = "0";

                }
                try
                {
                    dataGridView1.Rows[rowindex].Cells["co"].Value = (Convert.ToDouble(cocost) - Convert.ToDouble(disrate)).ToString();
                }
                catch (Exception ex)
                {


                }
                try
                {
                    cocost = dataGridView1.Rows[rowindex].Cells["co"].Value.ToString();
                }
                catch (Exception ex)
                {


                }
                try
                {
                    tqty = dataGridView1.Rows[rowindex].Cells["t_qty"].Value.ToString();
                }
                catch (Exception ex)
                {


                }
                try
                {
                    dataGridView1.Rows[rowindex].Cells["total_cost"].Value = Convert.ToString(Convert.ToDouble(cocost) * Convert.ToDouble(tqty));
                }
                catch (Exception ex)
                {


                }
                try
                {
                    totalcost = dataGridView1.Rows[rowindex].Cells["total_cost"].Value.ToString();
                }
                catch (Exception exc)
                { }
                try
                {
                    texrate = dataGridView1.Rows[rowindex].Cells["tex"].Value.ToString();
                    if (texrate == "")
                    {
                        texrate = "0";
                        dataGridView1.Rows[rowindex].Cells["tex"].Value = "0";
                    }
                }
                catch (Exception exc)
                {
                    texrate = "0";
                    dataGridView1.Rows[rowindex].Cells["tex"].Value = "0";
                }
                try
                {
                    dataGridView1.Rows[rowindex].Cells["tex_A"].Value = Convert.ToString(Convert.ToDouble(totalcost) * (Convert.ToDouble(texrate) / 100));

                }
                catch (Exception exc)
                {


                }
                try
                {
                    unitcost = dataGridView1.Rows[rowindex].Cells["cost_i"].Value.ToString();
                    if (unitcost == "")
                    {
                        unitcost = "1";
                        dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";
                    }

                }
                catch (Exception exc)
                {
                    unitcost = "1";
                    dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";

                }
                try
                {
                    cocost = dataGridView1.Rows[rowindex].Cells["co"].Value.ToString();
                    if (cocost == "")
                    {
                        cocost = "1";
                        dataGridView1.Rows[rowindex].Cells["co"].Value = "1";
                    }
                }
                catch (Exception exc)
                {
                    cocost = "1";
                    dataGridView1.Rows[rowindex].Cells["co"].Value = "1";

                }
                try
                {
                    quanty = dataGridView1.Rows[rowindex].Cells["qty"].Value.ToString();
                }
                catch (Exception exc)
                {

                    quanty = "0";
                }
                try
                {
                    dataGridView1.Rows[rowindex].Cells["ctn_co"].Value = Convert.ToString(Convert.ToDouble(quanty) * Convert.ToDouble(cocost));
                    ctncost = dataGridView1.Rows[rowindex].Cells["ctn_co"].Value.ToString();
                    if (ctncost == "")
                    {
                        ctncost = "1";
                        dataGridView1.Rows[rowindex].Cells["ctn_co"].Value = "1";
                    }
                }
                catch (Exception exc)
                {
                    ctncost = "1";
                    dataGridView1.Rows[rowindex].Cells["ctn_co"].Value = "1";

                }

            }

            for (int k = 0; k < dataGridView1.RowCount; k++)
            {
                try
                {

                    grand = dataGridView1.Rows[k].Cells["t_qty"].Value.ToString();

                    t_q = Convert.ToDouble(grand) + t_q;


                    t_cost = dataGridView1.Rows[k].Cells["total_cost"].Value.ToString();
                    t_p = Convert.ToDouble(t_cost) + t_p;

                }
                catch (Exception ex)
                {

                    //  MessageBox.Show(ex.Message);
                }
                label4.Text = Convert.ToString(t_q);
                label2.Text = Convert.ToString(t_p);
            }
            t_q = 0;
            t_q = 0;




        }


        private void getcom_name()
        {

            try
            {
                connection_check();

                company_box.Items.Clear();

                MySqlCommand com_name = new MySqlCommand("select DISTINCT(c_name) from company order by c_name asc ", conn);

                com_name.ExecuteNonQuery();

                MySqlDataReader rd = com_name.ExecuteReader();

                while (rd.Read())
                {

                    company_box.Items.Add(rd[0].ToString());

                
                }

                rd.Dispose();

            }
            catch (Exception ex)
            {
                connection_check();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           branch_name.Text = Login.branch;

            getcom_name();
            getitem_name();
            
            
            user.Text = Login.user_n;
            panel2.Visible = false;
            progressBar3.Visible = false;
            label112.Visible = false;
            label111.Visible = false;
           
        }
        private void getitem_name()
        {
            connection_check();
            try
            {
                connection_check();
               
                raw_ibox.Items.Clear();
                MySqlCommand item_name = new MySqlCommand("select DISTINCT(raw_name) from rawtb order by raw_name asc ", conn);
                item_name.ExecuteNonQuery();
                MySqlDataReader rd = item_name.ExecuteReader();
                while (rd.Read())
                {
                    raw_ibox.Items.Add(rd[0].ToString());
                }
                rd.Dispose();
            }
            catch (Exception ex)
            {
                connection_check();
                

            }

        }

        private void raw_ibox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    connection_check();
                }
                catch (Exception ex)
                {


                }

                if (raw_ibox.Text != "")
                {
                    try
                    {

                        MySqlCommand total_qantity = new MySqlCommand("select raw_name,invoice_no from fsm_null where ((raw_name ='" + raw_ibox.Text + "') and (invoice_no='" + inv_num.Text + "') and (branch_n = '" + Login.branch + "')) ", conn);
                        total_qantity.ExecuteNonQuery();
                        MySqlDataReader rd = total_qantity.ExecuteReader();
                        while (rd.Read())
                        {
                            aa11 = rd[0].ToString();
                        }
                        rd.Dispose();


                        if (aa11 != raw_ibox.Text)
                        {


                            connection_check();
                            MySqlCommand setupalll = new MySqlCommand("Insert into fsm_null (raw_name,invoice_no,branch_n) Values('" + raw_ibox.Text + "','" + inv_num.Text + "','" + Login.branch + "') ", conn);
                            setupalll.ExecuteNonQuery();
                            setupalll.Dispose();
                            raw_ibox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Invalid Entry!This Item is already entered", "Double Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            raw_ibox.Text = "";
                            raw_ibox.Focus();
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }

                }
                else
                {
                    raw_ibox.Focus();
                    return;
                }
            }

            Bind_Grid0();
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{up}");
                SendKeys.Send("{right}");
            }
        }
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            string i_raw = "";
            int rowindex = e.RowIndex;
            int col = e.ColumnIndex;

            if (col == 11)
            {
                try
                {
                    unitcost = dataGridView1.Rows[rowindex].Cells["cost_i"].Value.ToString();
                    if (unitcost == "")
                    {
                        unitcost = "1";
                        dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";
                    }
                }
                catch (Exception ex)
                {
                    unitcost = "1";
                    dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";

                }
                try
                {
                    disrate = dataGridView1.Rows[rowindex].Cells["discount"].Value.ToString();
                    if (disrate == "")
                    {
                        disrate = "0";
                        dataGridView1.Rows[rowindex].Cells["discount"].Value = "0";
                    }
                }
                catch (Exception ex)
                {
                    disrate = "0";
                    dataGridView1.Rows[rowindex].Cells["discount"].Value = "0";

                }
                if (Convert.ToDouble(dataGridView1.Rows[rowindex].Cells["discount"].Value) > Convert.ToDouble(dataGridView1.Rows[rowindex].Cells["cost_i"].Value))
                {
                    dataGridView1.Rows[rowindex].Cells["discount"].Value = "0";
                }
                //string per1 = (Convert.ToDouble(unitcost) * Convert.ToDouble(disrate) / 100).ToString();
                try
                {
                    tqty = dataGridView1.Rows[rowindex].Cells["t_qty"].Value.ToString();
                }
                catch (Exception ex)
                {


                }

                try
                {
                    cocost = dataGridView1.Rows[rowindex].Cells["co"].Value.ToString();
                }
                catch (Exception ex)
                {


                }
                try
                {
                    disrate = dataGridView1.Rows[rowindex].Cells["discount"].Value.ToString();
                    if (disrate == "")
                    {
                        disrate = "0";
                        dataGridView1.Rows[rowindex].Cells["discount"].Value = "0";
                    }
                }
                catch (Exception ex)
                {
                    disrate = "0";
                    dataGridView1.Rows[rowindex].Cells["discount"].Value = "0";

                }
                try
                {
                    dataGridView1.Rows[rowindex].Cells["co"].Value = (Convert.ToDouble(cocost) + Convert.ToDouble(disrate)).ToString();
                }
                catch (Exception ex)
                {


                }
                try
                {
                    cocost = dataGridView1.Rows[rowindex].Cells["co"].Value.ToString();
                }
                catch (Exception ex)
                {


                }
                try
                {
                    tqty = dataGridView1.Rows[rowindex].Cells["t_qty"].Value.ToString();
                }
                catch (Exception ex)
                {


                }
                try
                {
                    dataGridView1.Rows[rowindex].Cells["total_cost"].Value = Convert.ToString(Convert.ToDouble(cocost) * Convert.ToDouble(tqty));
                }
                catch (Exception ex)
                {


                }
                try
                {
                    totalcost = dataGridView1.Rows[rowindex].Cells["total_cost"].Value.ToString();
                }
                catch (Exception exc)
                { }
                try
                {
                    texrate = dataGridView1.Rows[rowindex].Cells["tex"].Value.ToString();
                    if (texrate == "")
                    {
                        texrate = "0";
                        dataGridView1.Rows[rowindex].Cells["tex"].Value = "0";
                    }
                }
                catch (Exception exc)
                {
                    texrate = "0";
                    dataGridView1.Rows[rowindex].Cells["tex"].Value = "0";
                }
                try
                {
                    dataGridView1.Rows[rowindex].Cells["tex_A"].Value = Convert.ToString(Convert.ToDouble(totalcost) * (Convert.ToDouble(texrate) / 100));

                }
                catch (Exception exc)
                {


                }
                try
                {
                    unitcost = dataGridView1.Rows[rowindex].Cells["cost_i"].Value.ToString();
                    if (unitcost == "")
                    {
                        unitcost = "1";
                        dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";
                    }

                }
                catch (Exception exc)
                {
                    unitcost = "1";
                    dataGridView1.Rows[rowindex].Cells["cost_i"].Value = "1";

                }
                try
                {
                    cocost = dataGridView1.Rows[rowindex].Cells["co"].Value.ToString();
                    if (cocost == "")
                    {
                        cocost = "1";
                        dataGridView1.Rows[rowindex].Cells["co"].Value = "1";
                    }
                }
                catch (Exception exc)
                {
                    cocost = "1";
                    dataGridView1.Rows[rowindex].Cells["co"].Value = "1";

                }
                try
                {
                    quanty = dataGridView1.Rows[rowindex].Cells["qty"].Value.ToString();
                }
                catch (Exception exc)
                {

                    quanty = "0";
                }
                try
                {
                    dataGridView1.Rows[rowindex].Cells["ctn_co"].Value = Convert.ToString(Convert.ToDouble(quanty) * Convert.ToDouble(cocost));
                    ctncost = dataGridView1.Rows[rowindex].Cells["ctn_co"].Value.ToString();
                    if (ctncost == "")
                    {
                        ctncost = "1";
                        dataGridView1.Rows[rowindex].Cells["ctn_co"].Value = "1";
                    }
                }
                catch (Exception exc)
                {
                    ctncost = "1";
                    dataGridView1.Rows[rowindex].Cells["ctn_co"].Value = "1";

                }

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["raw_m"].Value.ToString();

            }
            catch (Exception ex)
            {


            }
        }
    }
}
