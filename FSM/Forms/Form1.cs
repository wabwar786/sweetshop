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
using FSM.Reports;

namespace FSM
{
    public partial class fsm_inventory : Form
    {
        int panel_status = 0;
        string aa11 = "";
        string ctoo = "";
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
        string invo_id = "";
        string grand = "";
        string totalcost = "";
        string unitcost = "";
        string cocost = "";
        string ctncost = "";
        string t_cost = "";
        string tempbatch = "";
        int new_Id = 0;
        string pin = "";
        string pin2 = "";
        string Iname = "";
        string oqty = "";
        string iprice = "";
        string pprice = "";
        string iicost = "";
        string Cqty = "";
        string trqty = "";
        string p_cost = "";
        string p_tcost = "";
        string status = "1";
        string texrate = "";
        string disrate = "";
        string tex_rate = "";
        string tex_amount = "";
        string dis_rate = "";
        string sumqty = null;
        string sumqty1 = null;
        string per = null;
        double qty_t = 0;
        string dnido = "";

        public static string connectionstr = ConfigurationSettings.AppSettings["ConnectionString"];
        MySqlConnection conn = new MySqlConnection(connectionstr);


        public fsm_inventory()
        {
            InitializeComponent();

        }


        //////////////////////////-----------------------fsm-purchasing code-------------------------///////////////////////////////
        public DataSet SelectAll0()
        {
            connection_check();

            DataSet ds = new DataSet();

            try
            {     ///and branch_n = '" + Login.branch + "'
                ///
                connection_check();
                MySqlCommand cmd1 = new MySqlCommand("select raw_name,supplier,weight,bag,total_kg_p,cost,ctn_cost,Tex,tax_amount,Discount,total_cost,invoice_ID from fsm_null where invoice_no='" + inv_num.Text + "' order by id asc ", conn);
                MySqlDataAdapter daa = new MySqlDataAdapter(cmd1);

                daa.Fill(ds);

                cmd1.Dispose();

            }

            catch (Exception ex)
            {
                connection_check();
                // MessageBox.Show(ex.Message);
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
        public DataSet SelectAll1()
        {

            DataSet ds = new DataSet();

            try
            {
                connection_check();
                MySqlCommand cmd1 = new MySqlCommand("select raw_name,supplier,weight,bag,total_kg_p,cost,ctn_cost,Tex,tax_amount,Discount,total_cost,invoice_ID from fsm_null where branch_n = '" + Login.branch + "' ", conn);
                MySqlDataAdapter daa = new MySqlDataAdapter(cmd1);

                daa.Fill(ds);

                cmd1.Dispose();

            }

            catch (Exception ex)
            {
                connection_check();
                //MessageBox.Show(ex.Message);
            }

            return ds;


        }

        private void Bind_Grid1()
        {
            try
            {
                DataSet Ds;

                Ds = this.SelectAll1();

                dataGridView1.DataSource = Ds.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public DataSet SelectAll2()
        {

            DataSet ds1 = new DataSet();

            try
            {
                connection_check();
                MySqlCommand cmd11 = new MySqlCommand("select raw_name,supplier,weight,bag,total_kg_p,unit_cost,cost,ctn_cost,Tex,tax_amount,Discount,total_cost,invoice_ID from fsm_voucher_log where ((invoice_code ='" + vouch_tex.Text + "') and (branch_n = '" + Login.branch + "')and(Status='for production'))", conn);
                MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                daa1.Fill(ds1);

                cmd11.Dispose();

            }

            catch (Exception ex)
            {
                connection_check();
                //MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid2()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll2();

                dataGridView11.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public DataSet SelectAll2_1()
        {

            DataSet ds1 = new DataSet();

            try
            {
                connection_check();
                MySqlCommand cmd11 = new MySqlCommand("select raw_name,supplier,weight,bag,total_kg_p,unit_cost,cost,ctn_cost,Tex,tax_amount,Discount,total_cost,invoice_ID from fsm_voucher_log where ((invoice_number ='" + id_code_text.Text + "') and (branch_n = '" + Login.branch + "')and(Status='for production'))", conn);
                MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                daa1.Fill(ds1);

                cmd11.Dispose();

            }

            catch (Exception ex)
            {
                connection_check();
                //MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid2_1()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll2_1();

                dataGridView11.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public DataSet SelectAll2_2()
        {

            DataSet ds1 = new DataSet();

            try
            {
                connection_check();
                MySqlCommand cmd11 = new MySqlCommand("select raw_name,supplier,weight,bag,total_kg_p,unit_cost,cost,ctn_cost,Tex,tax_amount,Discount,total_cost,invoice_ID from fsm_voucher_log where ((invoice_code ='" + vouch_tex.Text + "') and (branch_n = '" + Login.branch + "')and(Status='Finished Goods'))", conn);
                MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                daa1.Fill(ds1);

                cmd11.Dispose();

            }

            catch (Exception ex)
            {
                connection_check();
                //MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid2_2()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll2_2();

                dataGridView11.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public DataSet SelectAll2_2_2()
        {

            DataSet ds1 = new DataSet();

            try
            {
                connection_check();
                MySqlCommand cmd11 = new MySqlCommand("select raw_name,supplier,weight,bag,total_kg_p,unit_cost,cost,ctn_cost,Tex,tax_amount,Discount,total_cost,invoice_ID from fsm_voucher_log where ((invoice_number ='" + id_code_text.Text + "') and (branch_n = '" + Login.branch + "')and(Status='Finished Goods'))", conn);
                MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                daa1.Fill(ds1);

                cmd11.Dispose();

            }

            catch (Exception ex)
            {
                connection_check();
                //MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid2_2_2()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll2_2_2();

                dataGridView11.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public DataSet SelectAll19()
        {

            DataSet ds = new DataSet();

            try
            {     ///and branch_n = '" + Login.branch + "'
                MySqlCommand cmd1 = new MySqlCommand("select barcode,item,qty,Status,ms_data,ms_time from fsm_mainstore where (branch_n='" + Login.branch + "') and(Status='Finished Goods') ", conn);
                MySqlDataAdapter daa = new MySqlDataAdapter(cmd1);

                daa.Fill(ds);

                cmd1.Dispose();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ds;


        }

        private void Bind_Grid19()
        {
            try
            {
                DataSet Ds;

                Ds = this.SelectAll19();

                dataGridView10.DataSource = Ds.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public void report_0()
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
                    MySqlCommand commander = new MySqlCommand("select supplier,raw_name,weight,bag,total_kg_p,invoice_number ,invoice_date,invoice_time,invoice_code,login_user from fsm_voucher_log where invoice_code = '" + vouch_tex.Text + "' and branch_n = '" + Login.branch + "' ;", conn);
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
        public void report_2()
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
                    MySqlCommand commander = new MySqlCommand("select supplier,raw_name,weight,bag,total_kg_p,invoice_number ,invoice_date,invoice_time,invoice_code,login_user from fsm_voucher_log where (((invoice_number = '" + voucher_box.Text + "') or (invoice_code = '" + voucher_box.Text + "')) and (branch_n = '" + Login.branch + "')and(Status='for production') );", conn);
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
                    MessageBox.Show(ex.Message);

                }



            }
            catch (Exception ex)
            {

                // MessageBox.Show(ex.Message);
            }


        }
        public void report_3()
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
                    MySqlCommand commander = new MySqlCommand("select supplier,raw_name,weight,bag,total_kg_p,invoice_number ,invoice_date,invoice_time,invoice_code,login_user from fsm_voucher_log where (((invoice_number ='" + voucher_boxfg.Text + "') or (invoice_code ='" + voucher_boxfg.Text + "'))and(branch_n = '" + Login.branch + "')and(Status='Finished Goods')) ;", conn);
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
        public void transfer_report_1()
        {
            connection_check();
            try
            {
                DataSet ddd = new DataSet();
                DataTable dtdd = ddd.Tables.Add("transfer_to");

                dtdd.Columns.Add("tr_date", Type.GetType("System.String"));
                dtdd.Columns.Add("tr_time", Type.GetType("System.String"));
                dtdd.Columns.Add("dn_date", Type.GetType("System.String"));
                dtdd.Columns.Add("dn_time", Type.GetType("System.String"));
                dtdd.Columns.Add("item", Type.GetType("System.String"));
                dtdd.Columns.Add("from_b", Type.GetType("System.String"));
                //dt.Columns.Add("reicever", Type.GetType("System.String"));
                dtdd.Columns.Add("to_b", Type.GetType("System.String"));
                // dtdd.Columns.Add("invoice", Type.GetType("System.String"));
                dtdd.Columns.Add("demand", Type.GetType("System.String"));
                dtdd.Columns.Add("transfer", Type.GetType("System.String"));
                dtdd.Columns.Add("discribtion", Type.GetType("System.String"));
                dtdd.Columns.Add("discribtion2", Type.GetType("System.String"));
                dtdd.Columns.Add("demandid", Type.GetType("System.String"));


                try
                {
                    DataRow rddd;
                    connection_check();
                    MySqlCommand commander = new MySqlCommand("select itemname,dn_date,dn_time,demand_qty,transfer_qty from fsm_demand_note where demand_id = '" + dn_tex.Text + "'  ;", conn);
                    commander.ExecuteNonQuery();
                    MySqlDataReader reader = commander.ExecuteReader();
                    while (reader.Read())
                    {
                        rddd = dtdd.NewRow();
                        string aa = reader[0].ToString();
                        rddd["item"] = aa;
                        rddd["dn_date"] = reader[1].ToString();
                        rddd["dn_time"] = reader[2].ToString();
                        rddd["demand"] = reader[3].ToString();
                        rddd["transfer"] = reader[4].ToString();
                        rddd["demandid"] = dn_tex.Text;
                        rddd["discribtion"] = textBox10.Text;
                        rddd["tr_date"] = DateTime.Today.ToString("yyyy-MM-dd");
                        rddd["tr_time"] = DateTime.Now.ToString("hh:mm:ss:tt");
                        rddd["from_b"] = Login.branch;
                        rddd["to_b"] = bdn.Text;

                        dtdd.Rows.Add(rddd);

                    }
                    reader.Dispose();
                    commander.Dispose();

                    transfer ar = new transfer();
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
        public void transfer_report_2()
        {
            connection_check();
            try
            {
                DataSet ddd = new DataSet();
                DataTable dtdd = ddd.Tables.Add("transfer_to");

                dtdd.Columns.Add("tr_date", Type.GetType("System.String"));
                dtdd.Columns.Add("tr_time", Type.GetType("System.String"));
                dtdd.Columns.Add("dn_date", Type.GetType("System.String"));
                dtdd.Columns.Add("dn_time", Type.GetType("System.String"));
                dtdd.Columns.Add("item", Type.GetType("System.String"));
                dtdd.Columns.Add("from_b", Type.GetType("System.String"));
                //dt.Columns.Add("reicever", Type.GetType("System.String"));
                dtdd.Columns.Add("to_b", Type.GetType("System.String"));
                // dtdd.Columns.Add("invoice", Type.GetType("System.String"));
                dtdd.Columns.Add("demand", Type.GetType("System.String"));
                dtdd.Columns.Add("transfer", Type.GetType("System.String"));
                dtdd.Columns.Add("discribtion", Type.GetType("System.String"));
                dtdd.Columns.Add("discribtion2", Type.GetType("System.String"));
                dtdd.Columns.Add("demandid", Type.GetType("System.String"));


                try
                {
                    DataRow rddd;
                    connection_check();
                    MySqlCommand commander = new MySqlCommand("select itemname,dn_date,dn_time,demand_qty,transfer_qty from fsm_demand_note where demand_id = '" + dn_tex.Text + "' ", conn);
                    commander.ExecuteNonQuery();
                    MySqlDataReader reader = commander.ExecuteReader();
                    while (reader.Read())
                    {
                        rddd = dtdd.NewRow();
                        string aa = reader[0].ToString();
                        rddd["item"] = aa;
                        rddd["dn_date"] = reader[1].ToString();
                        rddd["dn_time"] = reader[2].ToString();
                        rddd["demand"] = reader[3].ToString();
                        rddd["transfer"] = reader[4].ToString();
                        rddd["demandid"] = dn_tex.Text;
                        rddd["discribtion"] = textBox11.Text;
                        rddd["tr_date"] = DateTime.Today.ToString("yyyy-MM-dd");
                        rddd["tr_time"] = DateTime.Now.ToString("hh:mm:ss:tt");
                        rddd["from_b"] = Login.branch;
                        rddd["to_b"] = bdn.Text;

                        dtdd.Rows.Add(rddd);

                    }
                    reader.Dispose();
                    commander.Dispose();

                    transfer ar = new transfer();
                    ar.SetDataSource(dtdd);
                    report_view vv = new report_view();

                    vv.crystalReportViewer1.ReportSource = ar;
                    vv.crystalReportViewer1.Refresh();
                    vv.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        public void received_report_fg()
        {
            connection_check();
            try
            {
                DataSet ddd = new DataSet();
                DataTable dtdd = ddd.Tables.Add("transfer_to");

                dtdd.Columns.Add("tr_date", Type.GetType("System.String"));
                dtdd.Columns.Add("tr_time", Type.GetType("System.String"));
                dtdd.Columns.Add("re_date", Type.GetType("System.String"));
                dtdd.Columns.Add("re_time", Type.GetType("System.String"));
                dtdd.Columns.Add("dn_date", Type.GetType("System.String"));
                dtdd.Columns.Add("dn_time", Type.GetType("System.String"));
                dtdd.Columns.Add("item", Type.GetType("System.String"));
                dtdd.Columns.Add("from_b", Type.GetType("System.String"));
                dtdd.Columns.Add("to_b", Type.GetType("System.String"));
                dtdd.Columns.Add("demand", Type.GetType("System.String"));
                dtdd.Columns.Add("transfer", Type.GetType("System.String"));
                dtdd.Columns.Add("re", Type.GetType("System.String"));
                dtdd.Columns.Add("discribtion", Type.GetType("System.String"));
                //dtdd.Columns.Add("discribtion2", Type.GetType("System.String"));
                dtdd.Columns.Add("demandid", Type.GetType("System.String"));


                try
                {
                    DataRow rddd;
                    connection_check();
                    MySqlCommand commander = new MySqlCommand("select itemname,dn_date,dn_time,demand_qty,transfer_qty,tr_date,tr_time,re_qty from fsm_demand_note where demand_id = '" + dn_tex2.Text + "'  ;", conn);
                    commander.ExecuteNonQuery();
                    MySqlDataReader reader = commander.ExecuteReader();
                    while (reader.Read())
                    {
                        rddd = dtdd.NewRow();
                        string aa = reader[0].ToString();
                        rddd["item"] = aa;
                        rddd["dn_date"] = reader[1].ToString();
                        rddd["dn_time"] = reader[2].ToString();
                        rddd["demand"] = reader[3].ToString();
                        rddd["transfer"] = reader[4].ToString();
                        rddd["demandid"] = dn_tex2.Text;
                        rddd["discribtion"] = textBox7.Text;
                        rddd["tr_date"] = reader[5].ToString();
                        rddd["tr_time"] = reader[6].ToString();
                        rddd["re"] = reader[7].ToString();
                        rddd["re_date"] = DateTime.Today.ToString("yyyy-MM-dd");
                        rddd["re_time"] = DateTime.Now.ToString("hh:mm:ss:tt");
                        rddd["from_b"] = Login.branch;
                        rddd["to_b"] = bdn3.Text;

                        dtdd.Rows.Add(rddd);

                    }
                    reader.Dispose();
                    commander.Dispose();

                    received ar = new received();
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
        public void received_report_rw()
        {
            connection_check();
            try
            {
                DataSet ddd = new DataSet();
                DataTable dtdd = ddd.Tables.Add("transfer_to");

                dtdd.Columns.Add("tr_date", Type.GetType("System.String"));
                dtdd.Columns.Add("tr_time", Type.GetType("System.String"));
                dtdd.Columns.Add("re_date", Type.GetType("System.String"));
                dtdd.Columns.Add("re_time", Type.GetType("System.String"));
                dtdd.Columns.Add("dn_date", Type.GetType("System.String"));
                dtdd.Columns.Add("dn_time", Type.GetType("System.String"));
                dtdd.Columns.Add("item", Type.GetType("System.String"));
                dtdd.Columns.Add("from_b", Type.GetType("System.String"));
                dtdd.Columns.Add("to_b", Type.GetType("System.String"));
                dtdd.Columns.Add("demand", Type.GetType("System.String"));
                dtdd.Columns.Add("transfer", Type.GetType("System.String"));
                dtdd.Columns.Add("re", Type.GetType("System.String"));
                dtdd.Columns.Add("discribtion", Type.GetType("System.String"));
                //dtdd.Columns.Add("discribtion2", Type.GetType("System.String"));
                dtdd.Columns.Add("demandid", Type.GetType("System.String"));


                try
                {
                    DataRow rddd;
                    connection_check();
                    MySqlCommand commander = new MySqlCommand("select itemname,dn_date,dn_time,demand_qty,transfer_qty,tr_date,tr_time,re_qty from fsm_demand_note where demand_id = '" + dn_tex2.Text + "'  ;", conn);
                    commander.ExecuteNonQuery();
                    MySqlDataReader reader = commander.ExecuteReader();
                    while (reader.Read())
                    {
                        rddd = dtdd.NewRow();
                        string aa = reader[0].ToString();
                        rddd["item"] = aa;
                        rddd["dn_date"] = reader[1].ToString();
                        rddd["dn_time"] = reader[2].ToString();
                        rddd["demand"] = reader[3].ToString();
                        rddd["transfer"] = reader[4].ToString();
                        rddd["demandid"] = dn_tex2.Text;
                        rddd["discribtion"] = textBox6.Text;
                        rddd["tr_date"] = reader[5].ToString();
                        rddd["tr_time"] = reader[6].ToString();
                        rddd["re"] = reader[7].ToString();
                        rddd["re_date"] = DateTime.Today.ToString("yyyy-MM-dd");
                        rddd["re_time"] = DateTime.Now.ToString("hh:mm:ss:tt");
                        rddd["from_b"] = Login.branch;
                        rddd["to_b"] = bdn3.Text;

                        dtdd.Rows.Add(rddd);

                    }
                    reader.Dispose();
                    commander.Dispose();

                    received ar = new received();
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
        public void received_report_view()
        {
            connection_check();
            try
            {
                DataSet ddd = new DataSet();
                DataTable dtdd = ddd.Tables.Add("transfer_to");

                dtdd.Columns.Add("tr_date", Type.GetType("System.String"));
                dtdd.Columns.Add("tr_time", Type.GetType("System.String"));
                dtdd.Columns.Add("re_date", Type.GetType("System.String"));
                dtdd.Columns.Add("re_time", Type.GetType("System.String"));
                dtdd.Columns.Add("dn_date", Type.GetType("System.String"));
                dtdd.Columns.Add("dn_time", Type.GetType("System.String"));
                dtdd.Columns.Add("item", Type.GetType("System.String"));
                dtdd.Columns.Add("from_b", Type.GetType("System.String"));
                dtdd.Columns.Add("to_b", Type.GetType("System.String"));
                dtdd.Columns.Add("demand", Type.GetType("System.String"));
                dtdd.Columns.Add("transfer", Type.GetType("System.String"));
                dtdd.Columns.Add("re", Type.GetType("System.String"));
                dtdd.Columns.Add("discribtion", Type.GetType("System.String"));
                //dtdd.Columns.Add("discribtion2", Type.GetType("System.String"));
                dtdd.Columns.Add("demandid", Type.GetType("System.String"));


                try
                {
                    DataRow rddd;
                    connection_check();
                    MySqlCommand commander = new MySqlCommand("select itemname,dn_date,dn_time,demand_qty,transfer_qty,tr_date,tr_time,re_date,re_time,re_qty,comment from fsm_demand_note where demand_id = '" + dn_tex3.Text + "'  ;", conn);
                    commander.ExecuteNonQuery();
                    MySqlDataReader reader = commander.ExecuteReader();
                    while (reader.Read())
                    {
                        rddd = dtdd.NewRow();
                        string aa = reader[0].ToString();
                        rddd["item"] = aa;
                        rddd["dn_date"] = reader[1].ToString();
                        rddd["dn_time"] = reader[2].ToString();
                        rddd["demand"] = reader[3].ToString();
                        rddd["transfer"] = reader[4].ToString();
                        rddd["demandid"] = dn_tex3.Text;
                        rddd["tr_date"] = reader[5].ToString();
                        rddd["tr_time"] = reader[6].ToString();
                        rddd["re_date"] = reader[7].ToString();
                        rddd["re_time"] = reader[8].ToString();
                        rddd["re"] = reader[9].ToString();
                        rddd["discribtion"] = reader[10].ToString();
                        rddd["from_b"] = Login.branch;
                        rddd["to_b"] = bdn3.Text;

                        dtdd.Rows.Add(rddd);

                    }
                    reader.Dispose();
                    commander.Dispose();

                    received ar = new received();
                    ar.SetDataSource(dtdd);
                    report_view vv = new report_view();

                    vv.crystalReportViewer1.ReportSource = ar;
                    vv.crystalReportViewer1.Refresh();
                    vv.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);


                }



            }
            catch (Exception ex)
            {

                // MessageBox.Show(ex.Message);
            }


        }
        public void demand_report_view()
        {
            connection_check();
            try
            {
                DataSet ddd = new DataSet();
                DataTable dtdd = ddd.Tables.Add("transfer_to");


                dtdd.Columns.Add("dn_date", Type.GetType("System.String"));
                dtdd.Columns.Add("dn_time", Type.GetType("System.String"));
                dtdd.Columns.Add("item", Type.GetType("System.String"));
                dtdd.Columns.Add("from_b", Type.GetType("System.String"));
                dtdd.Columns.Add("to_b", Type.GetType("System.String"));
                dtdd.Columns.Add("demand", Type.GetType("System.String"));
                dtdd.Columns.Add("demandid", Type.GetType("System.String"));


                try
                {
                    DataRow rddd;
                    connection_check();
                    MySqlCommand commander = new MySqlCommand("select itemname,dn_date,dn_time,demand_qty from fsm_demand_note where (demand_id = '" + tex_dnid.Text + "') and (branch_n ='" + Login.branch + "')  ;", conn);
                    commander.ExecuteNonQuery();
                    MySqlDataReader reader = commander.ExecuteReader();
                    while (reader.Read())
                    {
                        rddd = dtdd.NewRow();
                        string aa = reader[0].ToString();
                        rddd["item"] = aa;
                        rddd["dn_date"] = reader[1].ToString();
                        rddd["dn_time"] = reader[2].ToString();
                        rddd["demand"] = reader[3].ToString();
                        rddd["from_b"] = Login.branch;
                        rddd["to_b"] = bename.Text;
                        rddd["demandid"] = tex_dnid.Text;


                        dtdd.Rows.Add(rddd);

                    }
                    reader.Dispose();
                    commander.Dispose();

                    demanding ar = new demanding();
                    ar.SetDataSource(dtdd);
                    report_view vv = new report_view();

                    vv.crystalReportViewer1.ReportSource = ar;
                    vv.crystalReportViewer1.Refresh();
                    vv.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);


                }



            }
            catch (Exception ex)
            {

                // MessageBox.Show(ex.Message);
            }


        }

        private void FSM_Load(object sender, EventArgs e)
        {
         

                connection_check();
          
            if (Login.user_n != "Main Admin")
            {
                Inventry.TabPages.Remove(Purchasing);
                Inventry.TabPages.Remove(Department_Creation);
                Inventry.TabPages.Remove(Issuance_Production);
                Inventry.TabPages.Remove(Production_Status);
                Inventry.TabPages.Remove(Main_Store);
                Inventry.TabPages.Remove(Pricing);
                Inventry.TabPages.Remove(Demand_Note);
                Inventry.TabPages.Remove(Received_Demands);
                Inventry.TabPages.Remove(Transfer);
                Inventry.TabPages.Remove(Demand_Status);
                Inventry.TabPages.Remove(Edit_Voucher);
                Inventry.TabPages.Remove(Reports);
                btn_minus_pd.Visible = true;
                btn_minus_dep.Visible = true;
                s.Visible = true;
            }
            if (Login.user_n == "faizan")
            {
                Inventry.TabPages.Add(Purchasing);
                Inventry.TabPages.Add(Department_Creation);
                Inventry.TabPages.Add(Issuance_Production);
                Inventry.TabPages.Add(Production_Status);
                Inventry.TabPages.Add(Main_Store);
                Inventry.TabPages.Add(Pricing);
                Inventry.TabPages.Add(Demand_Note);
                Inventry.TabPages.Add(Received_Demands);
                Inventry.TabPages.Add(Transfer);
                Inventry.TabPages.Add(Demand_Status);
                Inventry.TabPages.Add(Edit_Voucher);
                Inventry.TabPages.Add(Reports);
                btn_minus_pd.Visible = true;
                btn_minus_dep.Visible = true;
                s.Visible = true;
            }
            string[] aqty = new string[13];
            aqty[0] = "Purchasing";
            aqty[1] = "Department_Creation";
            aqty[2] = "Department_Creation(Delete function)";
            aqty[3] = "Issuance_Production";
            aqty[4] = "Production_Status";
            aqty[5] = "Main_Store";
            aqty[6] = "Pricing";
            aqty[7] = "Demand_Note";
            aqty[8] = "Received_Demands";
            aqty[9] = "Transfer";
            aqty[10] = "Demand_Status";
            aqty[11] = "Edit_Voucher";
            aqty[12] = "Reports";

            string tbs = "";
            for (int i = 0; i < 12; i++)
            {
                MySqlCommand com_name = new MySqlCommand("select tabs from fsm_security where(user_name='" + Login.user_n + "') and (tabs='" + aqty[i] + "')", conn);
                com_name.ExecuteNonQuery();
                MySqlDataReader rd = com_name.ExecuteReader();
                while (rd.Read())
                {
                    tbs = rd[0].ToString();
                    if (tbs == "Purchasing")
                    {
                        Inventry.TabPages.Add(Purchasing);
                    }
                    if (tbs == "Department_Creation")
                    {
                        Inventry.TabPages.Add(Department_Creation);
                    }
                    if (tbs == "Department_Creation(Delete function)")
                    {
                        btn_minus_pd.Visible = true;
                        btn_minus_dep.Visible = true;
                        s.Visible = true;
                    }
                    if (tbs == "Issuance_Production")
                    {
                        Inventry.TabPages.Add(Issuance_Production);
                    }
                    if (tbs == "Production_Status")
                    {
                        Inventry.TabPages.Add(Production_Status);
                    }
                    if (tbs == "Main_Store")
                    {
                        Inventry.TabPages.Add(Main_Store);
                    }
                    if (tbs == "Pricing")
                    {
                        Inventry.TabPages.Add(Pricing);
                    }
                    if (tbs == "Demand_Note")
                    {
                        Inventry.TabPages.Add(Demand_Note);
                    }
                    if (tbs == "Received_Demands")
                    {
                        Inventry.TabPages.Add(Received_Demands);
                    }
                    if (tbs == "Transfer")
                    {
                        Inventry.TabPages.Add(Transfer);
                    }
                    if (tbs == "Demand_Status")
                    {
                        Inventry.TabPages.Add(Demand_Status);
                    }
                    if (tbs == "Edit_Voucher")
                    {
                        Inventry.TabPages.Add(Edit_Voucher);
                    }
                    if (tbs == "Reports")
                    {
                        Inventry.TabPages.Add(Reports);
                    }

                }
                rd.Dispose();
            }
            Inventry.Visible = true;

            panel2.Visible = true;
            progressBar3.Visible = true;
            label112.Visible = true;
            label111.Visible = true;

            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }


            hostName = Dns.GetHostName();
            myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();

            ///////////////---------Data Grid View 1 Design---------\\\\\\\\\\\\\\\\\\\

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

            ///////////////-------------------End-------------------\\\\\\\\\\\\\\\\\\\

            ///////////////---------Data Grid View 2 Design---------\\\\\\\\\\\\\\\\\\\

            dataGridView2.BorderStyle = BorderStyle.FixedSingle;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.SlateGray;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView2.BackgroundColor = Color.White;

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateGray;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ///////////////-------------------End-------------------\\\\\\\\\\\\\\\\\\\


            ///////////////---------Data Grid View 3 Design---------\\\\\\\\\\\\\\\\\\\

            dataGridView3.BorderStyle = BorderStyle.FixedSingle;
            dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView3.DefaultCellStyle.SelectionBackColor = Color.SlateGray;
            dataGridView3.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView3.BackgroundColor = Color.White;

            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateGray;
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ///////////////-------------------End-------------------\\\\\\\\\\\\\\\\\\\



            ///////////////---------Data Grid View 11 Design---------\\\\\\\\\\\\\\\\\\\

            dataGridView11.BorderStyle = BorderStyle.FixedSingle;
            dataGridView11.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataGridView11.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView11.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dataGridView11.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView11.BackgroundColor = Color.White;

            dataGridView11.EnableHeadersVisualStyles = false;
            dataGridView11.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView11.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dataGridView11.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ///////////////-------------------End-------------------\\\\\\\\\\\\\\\\\\\

            ///////////////---------Data Grid View 10 Design---------\\\\\\\\\\\\\\\\\\\

            dataGridView14.BorderStyle = BorderStyle.FixedSingle;
            dataGridView14.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataGridView14.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView14.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView14.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 152, 0);
            dataGridView14.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView14.BackgroundColor = Color.White;

            dataGridView14.EnableHeadersVisualStyles = false;
            dataGridView14.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView14.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 152, 0);
            dataGridView14.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ///////////////-------------------End-------------------\\\\\\\\\\\\\\\\\\\


            ///////////////---------Data Grid View 8 Design---------\\\\\\\\\\\\\\\\\\\

            dataGridView8.BorderStyle = BorderStyle.FixedSingle;
            dataGridView8.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataGridView8.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView8.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView8.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 152, 0);
            dataGridView8.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView8.BackgroundColor = Color.White;

            dataGridView8.EnableHeadersVisualStyles = false;
            dataGridView8.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView8.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 152, 0);
            dataGridView8.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ///////////////-------------------End-------------------\\\\\\\\\\\\\\\\\\\


            ///////////////---------Data Grid View 10 Design---------\\\\\\\\\\\\\\\\\\\

            dataGridView10.BorderStyle = BorderStyle.FixedSingle;
            dataGridView10.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataGridView10.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView10.DefaultCellStyle.ForeColor = Color.FromArgb(62, 39, 35);
            dataGridView10.DefaultCellStyle.SelectionBackColor = Color.FromArgb(93, 64, 55);
            dataGridView10.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView10.BackgroundColor = Color.White;

            dataGridView10.EnableHeadersVisualStyles = false;
            dataGridView10.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView10.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(93, 64, 55);
            dataGridView10.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ///////////////-------------------End-------------------\\\\\\\\\\\\\\\\\\\


            ///////////////---------Data Grid View 15 Design---------\\\\\\\\\\\\\\\\\\\

            dataGridView15.BorderStyle = BorderStyle.FixedSingle;
            dataGridView15.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataGridView15.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView15.DefaultCellStyle.ForeColor = Color.FromArgb(38, 50, 56);
            dataGridView15.DefaultCellStyle.SelectionBackColor = Color.FromArgb(38, 50, 56);
            dataGridView15.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView15.BackgroundColor = Color.White;

            dataGridView15.EnableHeadersVisualStyles = false;
            dataGridView15.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView15.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(38, 50, 56);
            dataGridView15.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ///////////////-------------------End-------------------\\\\\\\\\\\\\\\\\\\


            ///////////////---------Data Grid View 16 Design---------\\\\\\\\\\\\\\\\\\\

            dataGridView16.BorderStyle = BorderStyle.FixedSingle;
            dataGridView16.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataGridView16.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView16.DefaultCellStyle.ForeColor = Color.FromArgb(38, 50, 56);
            dataGridView16.DefaultCellStyle.SelectionBackColor = Color.FromArgb(38, 50, 56);
            dataGridView16.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView16.BackgroundColor = Color.White;

            dataGridView16.EnableHeadersVisualStyles = false;
            dataGridView16.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView16.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(38, 50, 56);
            dataGridView16.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ///////////////-------------------End-------------------\\\\\\\\\\\\\\\\\\\


            ///////////////---------Data Grid View 17 Design---------\\\\\\\\\\\\\\\\\\\

            dataGridView17.BorderStyle = BorderStyle.FixedSingle;
            dataGridView17.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataGridView17.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView17.DefaultCellStyle.ForeColor = Color.FromArgb(38, 50, 56);
            dataGridView17.DefaultCellStyle.SelectionBackColor = Color.FromArgb(38, 50, 56);
            dataGridView17.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView17.BackgroundColor = Color.White;

            dataGridView17.EnableHeadersVisualStyles = false;
            dataGridView17.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView17.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(38, 50, 56);
            dataGridView17.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ///////////////-------------------End-------------------\\\\\\\\\\\\\\\\\\\

            ///////////////---------Data Grid View 18 Design---------\\\\\\\\\\\\\\\\\\\

            dataGridView18.BorderStyle = BorderStyle.FixedSingle;
            dataGridView18.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataGridView18.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView18.DefaultCellStyle.ForeColor = Color.FromArgb(211, 47, 47);
            dataGridView18.DefaultCellStyle.SelectionBackColor = Color.FromArgb(211, 47, 47);
            dataGridView18.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView18.BackgroundColor = Color.White;

            dataGridView18.EnableHeadersVisualStyles = false;
            dataGridView18.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView18.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(211, 47, 47);
            dataGridView18.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ///////////////-------------------End-------------------\\\\\\\\\\\\\\\\\\\

            ///////////////---------Data Grid View 19 Design---------\\\\\\\\\\\\\\\\\\\

            dataGridView19.BorderStyle = BorderStyle.FixedSingle;
            dataGridView19.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataGridView19.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView19.DefaultCellStyle.ForeColor = Color.FromArgb(211, 47, 47);
            dataGridView19.DefaultCellStyle.SelectionBackColor = Color.FromArgb(211, 47, 47);
            dataGridView19.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView19.BackgroundColor = Color.White;

            dataGridView19.EnableHeadersVisualStyles = false;
            dataGridView19.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView19.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(211, 47, 47);
            dataGridView19.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ///////////////-------------------End-------------------\\\\\\\\\\\\\\\\\\\

            ///////////////---------Data Grid View 21 Design---------\\\\\\\\\\\\\\\\\\\

            dataGridView21.BorderStyle = BorderStyle.FixedSingle;
            dataGridView21.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataGridView21.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView21.DefaultCellStyle.ForeColor = Color.FromArgb(211, 47, 47);
            dataGridView21.DefaultCellStyle.SelectionBackColor = Color.FromArgb(211, 47, 47);
            dataGridView21.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView21.BackgroundColor = Color.White;

            dataGridView21.EnableHeadersVisualStyles = false;
            dataGridView21.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView21.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(211, 47, 47);
            dataGridView21.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ///////////////-------------------End-------------------\\\\\\\\\\\\\\\\\\\

            ///////////////---------Data Grid View 22 Design---------\\\\\\\\\\\\\\\\\\\

            dataGridView22.BorderStyle = BorderStyle.FixedSingle;
            dataGridView22.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataGridView22.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView22.DefaultCellStyle.ForeColor = Color.FromArgb(211, 47, 47);
            dataGridView22.DefaultCellStyle.SelectionBackColor = Color.FromArgb(211, 47, 47);
            dataGridView22.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView22.BackgroundColor = Color.White;

            dataGridView22.EnableHeadersVisualStyles = false;
            dataGridView22.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView22.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(211, 47, 47);
            dataGridView22.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ///////////////-------------------End-------------------\\\\\\\\\\\\\\\\\\\

            ///////////////---------Data Grid View 12 Design---------\\\\\\\\\\\\\\\\\\\

            dataGridView12.BorderStyle = BorderStyle.FixedSingle;
            dataGridView12.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataGridView12.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView12.DefaultCellStyle.ForeColor = Color.FromArgb(136, 14, 79);
            dataGridView12.DefaultCellStyle.SelectionBackColor = Color.FromArgb(136, 14, 79);
            dataGridView12.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView12.BackgroundColor = Color.White;

            dataGridView12.EnableHeadersVisualStyles = false;
            dataGridView12.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView12.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(136, 14, 79);
            dataGridView12.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ///////////////-------------------End-------------------\\\\\\\\\\\\\\\\\\\

            ///////////////---------Data Grid View 13 Design---------\\\\\\\\\\\\\\\\\\\

            dataGridView13.BorderStyle = BorderStyle.FixedSingle;
            dataGridView13.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataGridView13.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView13.DefaultCellStyle.ForeColor = Color.FromArgb(136, 14, 79);
            dataGridView13.DefaultCellStyle.SelectionBackColor = Color.FromArgb(136, 14, 79);
            dataGridView13.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView13.BackgroundColor = Color.White;

            dataGridView13.EnableHeadersVisualStyles = false;
            dataGridView13.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView13.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(136, 14, 79);
            dataGridView13.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ///////////////-------------------End-------------------\\\\\\\\\\\\\\\\\\\

            ///////////////---------Data Grid View 20 Design---------\\\\\\\\\\\\\\\\\\\

            dataGridView20.BorderStyle = BorderStyle.FixedSingle;
            dataGridView20.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataGridView20.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView20.DefaultCellStyle.ForeColor = Color.FromArgb(136, 14, 79);
            dataGridView20.DefaultCellStyle.SelectionBackColor = Color.FromArgb(136, 14, 79);
            dataGridView20.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView20.BackgroundColor = Color.White;

            dataGridView20.EnableHeadersVisualStyles = false;
            dataGridView20.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView20.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(136, 14, 79);
            dataGridView20.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ///////////////-------------------End-------------------\\\\\\\\\\\\\\\\\\\

            ///////////////---------Data Grid View 23 Design---------\\\\\\\\\\\\\\\\\\\

            dataGridView23.BorderStyle = BorderStyle.FixedSingle;
            dataGridView23.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataGridView23.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView23.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33);
            dataGridView23.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 33, 33);
            dataGridView23.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView23.BackgroundColor = Color.White;

            dataGridView23.EnableHeadersVisualStyles = false;
            dataGridView23.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView23.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 33, 33);
            dataGridView20.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ///////////////-------------------End-------------------\\\\\\\\\\\\\\\\\\\


            ///////////////---------Data Grid View 24 Design---------\\\\\\\\\\\\\\\\\\\

            dataGridView24.BorderStyle = BorderStyle.FixedSingle;
            dataGridView24.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataGridView24.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView24.DefaultCellStyle.ForeColor = Color.FromArgb(62, 39, 35);
            dataGridView24.DefaultCellStyle.SelectionBackColor = Color.FromArgb(93, 64, 55);
            dataGridView24.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView24.BackgroundColor = Color.White;

            dataGridView24.EnableHeadersVisualStyles = false;
            dataGridView24.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView24.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(93, 64, 55);
            dataGridView24.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ///////////////-------------------End-------------------\\\\\\\\\\\\\\\\\\\

            //try
            //{
            //    text_in_id.Text = "FS-" + DateTime.Today.ToString("MMyy") + DateTime.Now.ToString("hhss");
            //}
            //catch (Exception es)
            //{
            //}
            try
            {
                dn_id.Text = "DN-" + DateTime.Today.ToString("MMyy") + DateTime.Now.ToString("hhss");
            }
            catch (Exception es)
            {
            }

        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
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
        
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Bind_Grid7();
            Bind_Grid18();
            Bind_Grid19();
            Bind_Grid21();
            Bind_Grid32();
            Bind_Grid29();
            Bind_Grid39();
            getvoucher_rw_fg();
            getvoucher_rw();
            getvoucher_fg();
            getcom_name();
            getitem_name();
            getdepp();
            getproduct();
            getbranch_n();
            depget();
            pdget();
            pdgetall();
            fsm_pro_listviewer();
            fsm_mainlist();
            demandlist();
            branch_name.Text = Login.branch;
            bran_name.Text = Login.branch;
            user.Text = Login.user_n;
            panel2.Visible = false;
            progressBar3.Visible = false;
            label112.Visible = false;
            label111.Visible = false;
            backgroundWorker2.RunWorkerAsync();
        }

        private void getcom_name()
        {
           
            try
            { 
                connection_check();
                
                company_box.Items.Clear();
                
                sup_box.Items.Clear();
                
                sup_box2.Items.Clear();
                
                com_boxs.Items.Clear();

                MySqlCommand com_name = new MySqlCommand("select DISTINCT(c_name) from company order by c_name asc ", conn);
                
                com_name.ExecuteNonQuery();
                
                MySqlDataReader rd = com_name.ExecuteReader();
                
                while (rd.Read())
                {

                    company_box.Items.Add(rd[0].ToString());
                   
                    sup_box.Items.Add(rd[0].ToString());
                    
                    com_boxs.Items.Add(rd[0].ToString());
                    
                    sup_box2.Items.Add(rd[0].ToString());

                }

                rd.Dispose();
            
            }
            catch (Exception ex)
            {
                connection_check();
            }
        }
        private void getvoucher_rw_fg()
        {
            connection_check();
            try
            {
                connection_check();
                vouch_tex.Items.Clear();
                MySqlCommand com_name = new MySqlCommand("select DISTINCT(invoice_code) from fsm_voucher_log where (invoice_code like'FS%') and (branch_n='" + Login.branch + "')", conn);
                com_name.ExecuteNonQuery();
                MySqlDataReader rd = com_name.ExecuteReader();
                while (rd.Read())
                {
                    vouch_tex.Items.Add(rd[0].ToString());
                }
                rd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection_check();

            }


        }
        private void getvoucher_rw()
        {
            connection_check();
            try
            {
                connection_check();
                voucher_box.Items.Clear();
                MySqlCommand com_name = new MySqlCommand("select DISTINCT(invoice_code) from fsm_voucher_log where (invoice_code like'FS%') and (branch_n='" + Login.branch + "') and (Status='for production')", conn);
                com_name.ExecuteNonQuery();
                MySqlDataReader rd = com_name.ExecuteReader();
                while (rd.Read())
                {
                    voucher_box.Items.Add(rd[0].ToString());
                }
                rd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection_check();

            }


        }

        private void getvoucher_fg()
        {
            connection_check();
            try
            {
                connection_check();

                voucher_boxfg.Items.Clear();

                MySqlCommand com_name = new MySqlCommand("select DISTINCT(invoice_code) from fsm_voucher_log where (invoice_code like'FS%')and(branch_n='" + Login.branch + "') and (Status='Finished Goods') ", conn);
                com_name.ExecuteNonQuery();
                MySqlDataReader rd = com_name.ExecuteReader();
                while (rd.Read())
                {

                    voucher_boxfg.Items.Add(rd[0].ToString());

                }
                rd.Dispose();
            }
            catch (Exception ex)
            {
                connection_check();

            }


        }

        private void getitem_name()
        {
            connection_check();
            try
            {
                connection_check();
                // item_box.Items.Clear();
                i_n_box.Items.Clear();
                i_n_box2.Items.Clear();
                item_add.Items.Clear();
                search_boxs.Items.Clear();
                raw_ibox.Items.Clear();
                MySqlCommand item_name = new MySqlCommand("select DISTINCT(raw_name) from rawtb order by raw_name asc ", conn);
                item_name.ExecuteNonQuery();
                MySqlDataReader rd = item_name.ExecuteReader();
                while (rd.Read())
                {
                    //   item_box.Items.Add(rd[0].ToString());
                    i_n_box.Items.Add(rd[0].ToString());
                    i_n_box2.Items.Add(rd[0].ToString());
                    item_add.Items.Add(rd[0].ToString());
                    search_boxs.Items.Add(rd[0].ToString());
                    raw_ibox.Items.Add(rd[0].ToString());
                }
                rd.Dispose();
            }
            catch (Exception ex)
            {
                connection_check();
                //MessageBox.Show(ex.Message);

            }

        }
        private void getitem_price()
        {
            connection_check();
            try
            {
                connection_check();

                MySqlCommand item_name = new MySqlCommand("select DISTINCT(raw_name) from rawtb order by raw_name asc ", conn);
                item_name.ExecuteNonQuery();
                MySqlDataReader rd = item_name.ExecuteReader();
                while (rd.Read())
                {

                    search_boxs.Items.Add(rd[0].ToString());
                }
                rd.Dispose();
            }
            catch (Exception ex)
            {
                connection_check();
                //MessageBox.Show(ex.Message);

            }

        }

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

        private void save_btn_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (checkBox3.Checked == true)
            {

                DialogResult dlg = MessageBox.Show("Are you sure you want to Send these Products Diretly to Main Store? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    direct_to_mainstore();
                }

            }
            else if (checkBox3.Checked == false)
            {
                DialogResult dlg1 = MessageBox.Show("Are you sure you want to Send these Item For Production?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg1 == DialogResult.Yes)
                {
                    for_production();
                }

            }
            inv_num.Text = "NILL";
            Bind_Grid0();
        }


        private void update_table()
        {
           
            connection_check();
           

            for (int b = 0; b < dataGridView11.RowCount; b++)
            {
                


                try
                {

                    items_names = dataGridView11.Rows[b].Cells["raw_n2"].Value.ToString();
                    c_name = dataGridView11.Rows[b].Cells["Supplier"].Value.ToString();
                    quanty = dataGridView11.Rows[b].Cells["weight"].Value.ToString();
                    bags = dataGridView11.Rows[b].Cells["bag2"].Value.ToString();
                    totals = dataGridView11.Rows[b].Cells["Total_kg2"].Value.ToString();
                    ucost = dataGridView11.Rows[b].Cells["uni_1"].Value.ToString();
                    cost_1 = dataGridView11.Rows[b].Cells["uct"].Value.ToString();
                    cost_2 = dataGridView11.Rows[b].Cells["Total_coo"].Value.ToString();
                    invo_id = dataGridView11.Rows[b].Cells["invoo_id"].Value.ToString();
                    tex_rate = dataGridView11.Rows[b].Cells["tex1"].Value.ToString();
                    dis_rate = dataGridView11.Rows[b].Cells["Disco"].Value.ToString();
                    t_a = dataGridView11.Rows[b].Cells["tex_a1"].Value.ToString();
                    bag_ctn_c = dataGridView11.Rows[b].Cells["ctn_co1"].Value.ToString();

                    //connection_check();
                    //MySqlCommand sel_deb = new MySqlCommand("select total_kg_p from fsm_voucher where raw_name='" + items_names + "' and branch_n='" + Login.branch + "' and Status !='Finished Goods'", conn);
                    //sel_deb.ExecuteNonQuery();
                    //MySqlDataReader deb_dr = sel_deb.ExecuteReader();
                    //while (deb_dr.Read())
                    //{
                    //    sumqty1 = deb_dr[0].ToString();
                    //}
                    //deb_dr.Dispose();

                    //if (sumqty1 == null)
                    //{

                    //}
                    //else if (sumqty1 != null)
                    //{
                    //qty_t = Convert.ToInt32(totals) + Convert.ToInt32(sumqty1);
                    connection_check();
                    MySqlCommand in_upd = new MySqlCommand("Update fsm_voucher_log set unit_cost='" + ucost + "', weight ='" + quanty + "', bag='" + bags + "' , total_kg_p='" + totals + "',rema_qty='" + totals + "', cost ='" + cost_1 + "',ctn_cost='" + bag_ctn_c + "',Tex='" + tex_rate + "',tax_amount='" + t_a + "',Discount='" + dis_rate + "',total_cost = '" + cost_2 + "',pc_name='" + hostName + "',domain='" + myIP + "' ,invoice_date='" + DateTime.Today.ToString("yyyy-MM-dd") + "' , invoice_time='" + DateTime.Now.ToString("hh:mm:ss:tt") + "' where  ((raw_name='" + items_names + "') and (invoice_ID='" + invo_id + "') and (branch_n ='" + Login.branch + "')and (Status='for production'))", conn);
                    in_upd.ExecuteNonQuery();
                    in_upd.Dispose();
                    connection_check();
                    try
                    {
                        connection_check();
                        MySqlCommand setupall2 = new MySqlCommand("Insert into fsm_edit_voucher_log (unit_cost,invoice_ID,invoice_code,invoice_number,branch_n,raw_name,supplier,weight,bag,total_kg_p,rema_qty,cost,Tex,Discount,total_cost,invoice_date,invoice_time,pc_name,domain,Status,ctn_cost,tax_amount,login_user) Values('" + ucost + "','" + invo_id + "','" + vouch_tex.Text + "','" + id_code_text.Text + "','" + Login.branch + "','" + items_names + "','" + c_name + "','" + quanty + "' , '" + bags + "','" + totals + "','" + totals + "','" + cost_1 + "','" + tex_rate + "','" + dis_rate + "','" + cost_2 + "' ,'" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss:tt") + "' ,'" + hostName + "','" + myIP + "','Edited Raw Material','" + bag_ctn_c + "','" + t_a + "','" + Login.user_n + "') ", conn);
                        setupall2.ExecuteNonQuery();
                        setupall2.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }



                //}
                catch (Exception ex)
                {
                    connection_check();
                    MessageBox.Show(ex.Message);
                }

            }



        }

        private void update_table_2()
        {
            string sumqty2 = "";
            string sumqty3 = "";
           
            for (int b = 0; b < dataGridView11.RowCount; b++)
            {
              

                try
                {

                    items_names = dataGridView11.Rows[b].Cells["raw_n2"].Value.ToString();
                    c_name = dataGridView11.Rows[b].Cells["Supplier"].Value.ToString();
                    quanty = dataGridView11.Rows[b].Cells["weight"].Value.ToString();
                    bags = dataGridView11.Rows[b].Cells["bag2"].Value.ToString();
                    totals = dataGridView11.Rows[b].Cells["Total_kg2"].Value.ToString();
                    cost_1 = dataGridView11.Rows[b].Cells["uct"].Value.ToString();
                    cost_2 = dataGridView11.Rows[b].Cells["Total_coo"].Value.ToString();
                    invo_id = dataGridView11.Rows[b].Cells["invoo_id"].Value.ToString();
                    tex_rate = dataGridView11.Rows[b].Cells["tex1"].Value.ToString();
                    dis_rate = dataGridView11.Rows[b].Cells["Disco"].Value.ToString();
                    t_a = dataGridView11.Rows[b].Cells["tex_a1"].Value.ToString();
                    bag_ctn_c = dataGridView11.Rows[b].Cells["ctn_co1"].Value.ToString();

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
                        MessageBox.Show(ex.Message);
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
                        MessageBox.Show(ex.Message);
                        connection_check();

                    }
                    if (sumqty3 == null || sumqty3 == "")
                    {
                        try
                        {
                            connection_check();
                            MySqlCommand setupall2 = new MySqlCommand("Insert into fsm_pro_pricing (cat_name) Values('" + items_names + "') ", conn);
                            setupall2.ExecuteNonQuery();
                            setupall2.Dispose();
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
                    //if (sumqty == null || sumqty == "")
                    //{


                    //}
                    //else if (sumqty != null || sumqty != "")
                    //{
                    //try
                    //{
                    //    connection_check();
                    //    qty_t = Convert.ToDouble(totals) + Convert.ToDouble(sumqty);
                    //    MySqlCommand in_upd = new MySqlCommand("Update fsm_mainstore set barcode='" + sumqty2 + "' , qty='" + Convert.ToString(qty_t) + "' where item='" + items_names + "' and branch_n ='" + Login.branch + "'", conn);
                    //    in_upd.ExecuteNonQuery();
                    //    in_upd.Dispose();

                    //}
                    //catch (Exception ex)
                    //{
                    //}
                    try
                    {

                        connection_check();
                        MySqlCommand in_upd = new MySqlCommand("Update fsm_voucher_log set barcode='" + sumqty2 + "', unit_cost='" + ucost + "', weight ='" + quanty + "', bag='" + bags + "' , total_kg_p=" + totals + " ,rema_qty='" + totals + "', cost ='" + cost_1 + "',ctn_cost='" + bag_ctn_c + "',Tex='" + tex_rate + "',tax_amount='" + t_a + "',Discount='" + dis_rate + "',total_cost = '" + cost_2 + "',pc_name='" + hostName + "',domain='" + myIP + "' ,invoice_date='" + Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-dd")) + "' , invoice_time='" + DateTime.Now.ToString("hh:mm:ss:tt") + "' where  ((raw_name='" + items_names + "') and (invoice_ID='" + invo_id + "') and (branch_n ='" + Login.branch + "')and(Status='Finished Goods'))", conn);
                        in_upd.ExecuteNonQuery();
                        in_upd.Dispose();
                        connection_check(); ;

                    }
                    catch (Exception ex)
                    { }

                    try
                    {
                        connection_check();
                        MySqlCommand setupall22 = new MySqlCommand("Insert into fsm_edit_voucher_log (unit_cost,barcode,invoice_ID,invoice_code,invoice_number,branch_n,raw_name,supplier,weight,bag,total_kg_p,rema_qty,cost,Tex,Discount,total_cost,invoice_date,invoice_time,pc_name,domain,tax_amount,ctn_cost,Status,login_user) Values('" + ucost + "','" + sumqty2 + "','" + invo_id + "','" + vouch_tex.Text + "','" + text_in_id.Text + "','" + Login.branch + "','" + items_names + "','" + c_name + "','" + quanty + "' , '" + bags + "','" + totals + "','" + totals + "','" + cost_1 + "','" + tex_rate + "','" + dis_rate + "','" + cost_2 + "' ,'" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss:tt") + "' ,'" + hostName + "','" + myIP + "','" + t_a + "','" + bag_ctn_c + "',' Edit Finshed Goods ','" + Login.user_n + "') ", conn);
                        setupall22.ExecuteNonQuery();
                        setupall22.Dispose();
                        add_label.Visible = true;
                    }
                    catch (Exception ex)
                    {

                        connection_check();
                        MessageBox.Show(ex.Message);
                    }

                    //}
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
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
            connection_check();

            //string _getInvoiceNo = "0";
            //MySqlCommand _SEK = new MySqlCommand("select MAX(invoice_no) from fsm_null", conn);
            //_SEK.ExecuteNonQuery();
            //MySqlDataReader _DRX = _SEK.ExecuteReader();
            //while (_DRX.Read())
            //{
            //    _getInvoiceNo = _DRX[0].ToString(); //43217261130799
            //}
            //_DRX.Dispose();

            //if (_getInvoiceNo == "") { _getInvoiceNo = "0"; }
            //double n = Convert.ToDouble(_getInvoiceNo) + 1;

            inv_num.Text = _branch_name + "-" + DateTime.Today.ToString("MMyy") + DateTime.Now.ToString("hhmmss");

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



        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{up}");
                SendKeys.Send("{right}");
            }
        }




        private void button3_Click(object sender, EventArgs e)
        {
            //connection_check();
            //DataSet ddd = new DataSet();
            //DataTable dtdd = ddd.Tables.Add("voucher");

            //dtdd.Columns.Add("supplier", Type.GetType("System.String"));
            //dtdd.Columns.Add("item", Type.GetType("System.String"));
            //dtdd.Columns.Add("weight", Type.GetType("System.String"));
            //dtdd.Columns.Add("bag", Type.GetType("System.String"));
            //dtdd.Columns.Add("total", Type.GetType("System.String"));
            //dtdd.Columns.Add("voucher_id", Type.GetType("System.String"));
            ////dt.Columns.Add("reicever", Type.GetType("System.String"));
            //dtdd.Columns.Add("date", Type.GetType("System.String"));
            //dtdd.Columns.Add("time", Type.GetType("System.String"));
            //dtdd.Columns.Add("invoice", Type.GetType("System.String"));
            //dtdd.Columns.Add("Login.branch", Type.GetType("System.String"));


            //DataRow rddd;
            //connection_check();
            //try
            //{
            //    MySqlCommand commander = new MySqlCommand("select supplier , raw_name , weight, bag , total_kg_p,invoice_number ,invoice_date,invoice_time  from fsm_voucher where invoice_number = '" + inv_num.Text + "' and branch_n ='" + Login.branch + "';", conn);
            //    commander.ExecuteNonQuery();
            //    for (int l = 0; l < dataGridView11.RowCount; l++)
            //    {
            //        rddd = dtdd.NewRow();
            //        rddd["supplier"] = dataGridView11.Rows[l].Cells["co_name"].Value.ToString();
            //        rddd["item"] = dataGridView11.Rows[l].Cells["raw_m"].Value.ToString();
            //        rddd["weight"] = dataGridView11.Rows[l].Cells["qty"].Value.ToString();
            //        rddd["bag"] = dataGridView11.Rows[l].Cells["bag_o"].Value.ToString();
            //        rddd["total"] = dataGridView11.Rows[l].Cells["t_qty"].Value.ToString();
            //        rddd["date"] = DateTime.Today.ToString("dd-MM-yyyy");
            //        rddd["time"] = DateTime.Now.ToString("hh:mm:ss");
            //        rddd["voucher_id"] = inv_num.Text;
            //        rddd["invoice"] = text_in_id.Text;
            //        rddd["Login.branch"] = Login.branch;

            //        dtdd.Rows.Add(rddd);
            //    }

            //    commander.Dispose();

            //}
            //catch (Exception ex)
            //{
            //    connection_check();
            //    MessageBox.Show(ex.Message);
            //}

            //report_vaucher ar = new report_vaucher();
            //ar.SetDataSource(dtdd);
            //report_view vv = new report_view();

            //vv.crystalReportViewer1.ReportSource = ar;
            //vv.crystalReportViewer1.Refresh();
            //vv.Show();


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

        private void company_box_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        ///////////---------------------get department---------------///////////////////


        private void getdepp()
        {

            upup_label.Visible = false;
            up_label.Visible = false;
            cb_dep.Items.Clear();
            dep2_box.Items.Clear();
            try
            {
                connection_check();
                MySqlCommand com_name = new MySqlCommand("select DISTINCT(dep_name) from depitem order by dep_name asc ", conn);
                com_name.ExecuteNonQuery();
                MySqlDataReader rd = com_name.ExecuteReader();
                while (rd.Read())
                {
                    cb_dep.Items.Add(rd[0].ToString());
                    dep2_box.Items.Add(rd[0].ToString());
                }
                rd.Dispose();
            }
            catch (Exception ex)
            {
                connection_check();

            }

        }
        private void cb_dep_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection_check();
            upup_label.Visible = false;
            up_label.Visible = false;
            cb_pd.Text = "";
            cb_pd.Items.Clear();

            try
            {
                connection_check();
                MySqlCommand com_name = new MySqlCommand("select DISTINCT(cat_name) from depitem  where dep_name = '" + cb_dep.Text + "' order by dep_name asc ", conn);
                com_name.ExecuteNonQuery();
                MySqlDataReader rd = com_name.ExecuteReader();
                while (rd.Read())
                {
                    cb_pd.Items.Add(rd[0].ToString());
                }
                rd.Dispose();

            }
            catch (Exception ex)
            {

                connection_check();
            }

        }
        public DataSet SelectAll3_3()
        {
            DataSet ds1 = new DataSet();

            try
            {
                connection_check();
                MySqlCommand cmd11 = new MySqlCommand("select itemname from depitem where cat_name='" + grid_refresh.Text + "' ;", conn);
                MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                daa1.Fill(ds1);

                cmd11.Dispose();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid3_3()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll3_3();

                dataGridView2.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public DataSet SelectAll3()
        {
            DataSet ds1 = new DataSet();

            try
            {
                connection_check();
                MySqlCommand cmd11 = new MySqlCommand("select distinct(itemname) from depitem where cat_name='" + cb_pd.Text + "' ;", conn);
                MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                daa1.Fill(ds1);

                cmd11.Dispose();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid3()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll3();

                dataGridView2.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        //public DataSet SelectAll20()
        //{

        //    DataSet ds1 = new DataSet();

        //    try
        //    {
        //        connection_check();
        //        try
        //        {
        //            MySqlCommand cmd11 = new MySqlCommand("select raw_name,total_kg_p,rema_qty from fsm_voucher where branch_n ='" + f_branch_stock.Text + "' ", conn);
        //            MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

        //            daa1.Fill(ds1);

        //            cmd11.Dispose();

        //        }
        //        catch (Exception ex)
        //        {


        //        }


        //    }

        //    catch (Exception ex)
        //    {
        //       // MessageBox.Show(ex.Message);
        //    }

        //    return ds1;


        //}

        //private void Bind_Grid20()
        //{
        //    try
        //    {
        //        DataSet Ds1;

        //        Ds1 = this.SelectAll20();

        //        dataGridView12.DataSource = Ds1.Tables[0];
        //    }
        //    catch (Exception ex)
        //    {
        //        //MessageBox.Show(ex.Message);
        //    }
        //}
        public DataSet SelectAll21()
        {

            DataSet ds1 = new DataSet();

            try
            {
                connection_check();
                try
                {
                    MySqlCommand cmd11 = new MySqlCommand("select branch_n from fsm_branch where branch_n !='" + Login.branch + "'", conn);
                    MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                    daa1.Fill(ds1);

                    cmd11.Dispose();


                }
                catch (Exception ex)
                {


                }

            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid21()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll21();

                dataGridView12.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public DataSet SelectAll22()
        {

            DataSet ds1 = new DataSet();

            try
            {
                connection_check();
                try
                {
                    MySqlCommand cmd11 = new MySqlCommand("select itemname,demand_qty from fsm_demand_note where ((demand_id='" + dn_tex.Text + "') and (demand_type='Raw Material')and(branch_n='" + bdn.Text + "'))", conn);
                    MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                    daa1.Fill(ds1);

                    cmd11.Dispose();
                }
                catch (Exception ex)
                {


                }


            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid22()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll22();

                dataGridView13.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public DataSet SelectAll31()
        {

            DataSet ds1 = new DataSet();

            try
            {
                connection_check();
                try
                {
                    MySqlCommand cmd11 = new MySqlCommand("select itemname,demand_qty,transfer_qty from fsm_demand_note where (demand_id='" + dn_tex2.Text + "') and (demand_type!='Finished goods')  ;", conn);
                    MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                    daa1.Fill(ds1);

                    cmd11.Dispose();
                }
                catch (Exception ex)
                {


                }


            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid31()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll31();

                dataGridView18.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public DataSet SelectAll28()
        {

            DataSet ds1 = new DataSet();

            try
            {
                connection_check();
                try
                {
                    MySqlCommand cmd11 = new MySqlCommand("select itemname,demand_qty from fsm_demand_note where (demand_id='" + dn_tex.Text + "') and (demand_type='Finished Goods')and (branch_n ='" + bdn.Text + "')  ;", conn);
                    MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                    daa1.Fill(ds1);

                    cmd11.Dispose();
                }
                catch (Exception ex)
                {


                }


            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid28()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll28();

                dataGridView20.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public DataSet SelectAll30()
        {

            DataSet ds1 = new DataSet();

            try
            {
                connection_check();
                try
                {
                    MySqlCommand cmd11 = new MySqlCommand("select itemname,demand_qty,transfer_qty from fsm_demand_note where (demand_id='" + dn_tex2.Text + "') and (demand_type!='Raw Material')  ;", conn);
                    MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                    daa1.Fill(ds1);

                    cmd11.Dispose();
                }
                catch (Exception ex)
                {


                }


            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid30()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll30();

                dataGridView22.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public DataSet SelectAll27()
        {

            DataSet ds1 = new DataSet();

            try
            {
                connection_check();
                try
                {
                    MySqlCommand cmd11 = new MySqlCommand("select DISTINCT(raw_name) from rawtb order by raw_name asc ;", conn);
                    MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                    daa1.Fill(ds1);

                    cmd11.Dispose();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);

                }


            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid27()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll27();

                dataGridView15.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public DataSet SelectAll26()
        {

            DataSet ds1 = new DataSet();

            try
            {
                connection_check();
                try
                {
                    MySqlCommand cmd11 = new MySqlCommand("select itemname,demand_qty,transfer_qty from fsm_demand_note where demand_id='" + dn_tex2.Text + "' ;", conn);
                    MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                    daa1.Fill(ds1);

                    cmd11.Dispose();
                }
                catch (Exception ex)
                {


                }


            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid26()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll26();

                dataGridView18.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public DataSet SelectAll23()
        {

            DataSet ds1 = new DataSet();

            try
            {
                connection_check();
                MySqlCommand cmd11 = new MySqlCommand("select DISTINCT(cat_name) from fsm_pro_pricing order by cat_name asc ;", conn);
                MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                daa1.Fill(ds1);

                cmd11.Dispose();

            }

            catch (Exception ex)
            {
                connection_check();
                //MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid23()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll23();

                dataGridView16.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                connection_check();
                MessageBox.Show(ex.Message);
            }
        }
        public DataSet SelectAll25()
        {

            DataSet ds1 = new DataSet();

            try
            {
                connection_check();
                MySqlCommand cmd11 = new MySqlCommand("select item,sd,is,f1,mr,demand from fsm_null_2", conn);
                MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                daa1.Fill(ds1);

                cmd11.Dispose();

            }

            catch (Exception ex)
            {
                connection_check();
                //MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid25()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll25();

                dataGridView17.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                connection_check();
                // MessageBox.Show(ex.Message);
            }
        }
        private void cb_pd_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection_check();
            string dp = cb_dep.Text;
            string pd = cb_pd.Text;
            upup_label.Visible = false;
            up_label.Visible = false;


            Bind_Grid3();


            for (int b = 0; b < dataGridView2.RowCount; b++)
            {
                pin = dataGridView2.Rows[b].Cells["itemname"].Value.ToString();

                string count = "";
                string total_cost = "";
                string grand_total = "";

                //calculating price for issuance
                MySqlCommand total_price = new MySqlCommand("select COUNT(total_cost)as total_count ,SUM(total_cost) as total_cost from fsm_voucher_log where (raw_name ='" + pin + "' )and( branch_n = '" + Login.branch + "') ", conn);
                total_price.ExecuteNonQuery();
                MySqlDataReader price = total_price.ExecuteReader();
                while (price.Read())
                {
                    if (price["total_count"].ToString() == "")
                    {
                        count = "0";
                    }
                    else
                    {
                        count = price["total_count"].ToString();
                    }
                    if (price["total_cost"].ToString() == "")
                    {
                        total_cost = "0";
                    }
                    else
                    {
                        total_cost = price["total_cost"].ToString();
                    }
                    grand_total = (Convert.ToDouble(total_cost) / Convert.ToDouble(count)).ToString();
                    if (grand_total == "NaN")
                    {
                        grand_total = "";
                    }
                    dataGridView2.Rows[b].Cells["Price"].Value = grand_total;

                }
                price.Dispose();
                total_price.Dispose();
                //end pricing

                if (dataGridView2.Rows[b].Cells["open_cost"].Value == null || dataGridView2.Rows[b].Cells["open_cost"].Value == "")
                {
                    dataGridView2.Rows[b].Cells["open_cost"].Value = "0";
                    dataGridView2.Rows[b].Cells["c_quantity"].Value = "0";
                }
                try
                {
                    connection_check();
                    try
                    {
                        MySqlCommand total_qantity = new MySqlCommand("select total_kg_p,rema_qty from fsm_voucher where (raw_name ='" + pin + "' )and( branch_n = '" + Login.branch + "') ", conn);
                        total_qantity.ExecuteNonQuery();
                        MySqlDataReader rd = total_qantity.ExecuteReader();
                        while (rd.Read())
                        {

                            dataGridView2.Rows[b].Cells["open_cost"].Value = rd[0].ToString();
                            dataGridView2.Rows[b].Cells["c_quantity"].Value = rd[1].ToString();

                        }
                        rd.Dispose();
                    }
                    catch (Exception ex)
                    {

                        connection_check();
                        MessageBox.Show(ex.Message);
                    }


                }
                catch
                { }
                try
                {
                    txt_bat.Text = (Convert.ToChar(dp[0])).ToString() + (Convert.ToChar(pd[0])).ToString() + DateTime.Today.ToString("yyyyMMdd") + DateTime.Now.ToString("hhmmss");
                }
                catch (Exception es)
                {
                }

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection_check();
            string emp_val = "1";

            try
            {
                hostName = Dns.GetHostName();
                myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
                //for (int j = 0; j < dataGridView2.RowCount; j++)
                //{
                //    try
                //    {

                //        Iname = dataGridView2.Rows[j].Cells["itemname"].Value.ToString();

                //    }
                //    catch (Exception ec)
                //    {
                //    }

                //    try
                //    {
                //        trqty = "0";
                //        trqty = dataGridView2.Rows[j].Cells["tr_qty"].Value.ToString();
                //        if (trqty == "0" || trqty == "" || trqty == null)
                //        {
                //            emp_val = "0";
                //        }

                //    }
                //    catch (Exception ec)
                //    {
                //        trqty = "0";
                //        emp_val = "0";
                //    }


                //}
                //if (emp_val == "1")
                {


                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {


                        try
                        {

                            Iname = dataGridView2.Rows[i].Cells["itemname"].Value.ToString();

                        }
                        catch (Exception ec)
                        {
                        }

                        try
                        {

                            trqty = dataGridView2.Rows[i].Cells["tr_qty"].Value.ToString();
                        }
                        catch (Exception ec)
                        {
                            trqty="0";
                            //MessageBox.Show(ec.Message);
                        }
                        try
                        {


                            Cqty = dataGridView2.Rows[i].Cells["c_quantity"].Value.ToString();

                            //if (Cqty == "" || Cqty == "0")
                            //{
                            //    MessageBox.Show(this,"Quantity is not enough to Issue Item name [ "+Iname+"","Information",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            //}

                        }
                        catch (Exception ec)
                        {
                            Cqty="0";
                        }
                        try
                        {


                            oqty = dataGridView2.Rows[i].Cells["open_cost"].Value.ToString();

                        }
                        catch (Exception ec)
                        {
                            oqty="0";
                        }
                        try
                        {


                            iprice = dataGridView2.Rows[i].Cells["Price"].Value.ToString();

                        }
                        catch (Exception ec)
                        {
                            iprice="0";
                        }
                        try
                        {


                            pprice = dataGridView2.Rows[i].Cells["pcost"].Value.ToString();

                        }
                        catch (Exception ec)
                        {
                            pprice="0";
                        }

                        try
                        {
                            connection_check();
                            MySqlCommand itd = new MySqlCommand("insert into fsm_production(Batch_no ,branch_n,Department ,Product,Itemname,item_price,item_qty,rem_qty,Pc_name ,Domain ,Date,Time ,Status,login_user,product_cost) Values('" + txt_bat.Text + "','" + Login.branch + "','" + cb_dep.Text + "','" + cb_pd.Text + "','" + Iname + "','" + iprice + "','" + trqty + "','" + Cqty + "','" + hostName + "','" + myIP + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss:tt") + "','" + state_tex.Text + "','" + Login.user_n + "','" + pprice + "')", conn);
                            itd.ExecuteNonQuery();
                            itd.Dispose();

                        }
                        catch (Exception ex)
                        {
                            
                            //MessageBox.Show(ex.Message);

                        }
                       
                        try
                        {
                            connection_check();//and(cost='" + iprice + "')
                            MySqlCommand axx = new MySqlCommand("select cost from fsm_voucher where ((raw_name='" + Iname + "' )and(branch_n = '" + Login.branch + "'))", conn);
                            axx.ExecuteNonQuery();
                            MySqlDataReader dtr = axx.ExecuteReader();
                            while (dtr.Read())
                            {
                                p_cost = dtr[0].ToString();
                            }
                            axx.Dispose();
                            dtr.Dispose();

                        }
                        catch (Exception ex)
                        {
                            

                        }

                       
                        //try
                        {
                            connection_check();//and(cost='" + iprice + "')
                            MySqlCommand in_upd = new MySqlCommand("Update fsm_voucher set total_cost ='" + Convert.ToString(Convert.ToDouble(Cqty) * Convert.ToDouble(p_cost)) + "',  total_kg_p ='" + Cqty + "', rema_qty ='" + Cqty + "'   where  ((raw_name='" + Iname + "') and ( branch_n = '" + Login.branch + "'))", conn);
                            in_upd.ExecuteNonQuery();
                            in_upd.Dispose();
                        }
                       // catch (Exception ex)
                        {
                           

                        }



                        //MessageBox.Show("Record is successfully Added!", "Record Added Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                //else { MessageBox.Show("Minimum Transfer Quantity is 1!", "Invaild transfer quantity", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                up_label.Visible = true;
                fsm_pro_listviewer();
                fsm_mainlist();
                label128.Text = "0";
                label130.Text = "0";
                Bind_Grid3();
                Bind_Grid3_3();
                cb_dep.Text = "";
                cb_pd.Text = "";
                txt_bat.Text = "";


                //conn.Open();
            }
            catch (Exception ex)
            {
            }




        }

        private void fsm_pro_listviewer()
        {
            connection_check();
            upup_label.Visible = false;
            up_label.Visible = false;
            string[] batch = new string[1000];
            listView1.View = View.Details;
            listView1.Items.Clear();
            int k = 0;

            try
            {
                connection_check();
                MySqlCommand axx = new MySqlCommand("select DISTINCT(Batch_no) from fsm_production", conn);
                axx.ExecuteNonQuery();
                MySqlDataReader dtr = axx.ExecuteReader();
                while (dtr.Read())
                {
                    batch[k] = dtr[0].ToString();
                    k++;
                }
                axx.Dispose();
                dtr.Dispose();
            }
            catch (Exception ex)
            {

                connection_check();
            }



            k = 0;
            listView1.View = View.Details;
            listView1.Items.Clear();
            while (batch[k] != null)
            {
                //ac_listView1.View = View.Details;
                //ac_listView1.Items.Clear();
                connection_check();
                try
                {
                    MySqlDataAdapter axx2 = new MySqlDataAdapter("select Department,Product,Status from fsm_production where Batch_no='" + batch[k] + "' and branch_n ='" + Login.branch + "' and Status='" + state_tex.Text + "' ", conn);
                    DataTable dtv2 = new DataTable();
                    axx2.Fill(dtv2);
                    //for (int i = 0; i < dtv2.Rows.Count; i++)
                    //{
                    try
                    {
                        DataRow dr = dtv2.Rows[0];
                        ListViewItem listitem = new ListViewItem(batch[k]);
                        listitem.SubItems.Add(dr["Department"].ToString());
                        listitem.SubItems.Add(dr["Product"].ToString());
                        listitem.SubItems.Add(dr["Status"].ToString());
                        //listitem.SubItems.Add(dr["Date"].ToString());
                        //listitem.SubItems.Add(dr["Time"].ToString());
                        listView1.Items.Add(listitem);
                    }
                    catch (Exception ex)
                    {


                    }

                    //}
                    dtv2.Dispose();
                    axx2.Dispose();
                }
                catch (Exception ex)
                {

                    connection_check();
                }

                k++;
            }




        }

        private void fsm_mainlist()
        {
            connection_check();
            string[] batch = new string[1000];
            listView4.View = View.Details;
            listView4.Items.Clear();
            int k = 0;

            try
            {
                connection_check();
                MySqlCommand axx = new MySqlCommand("select DISTINCT(Batch_no) from fsm_production where Status='Production' and branch_n = '" + Login.branch + "'", conn);
                axx.ExecuteNonQuery();
                MySqlDataReader dtr = axx.ExecuteReader();
                while (dtr.Read())
                {
                    batch[k] = dtr[0].ToString();
                    k++;
                }
                axx.Dispose();
                dtr.Dispose();

            }
            catch (Exception ex)
            {


            }


            k = 0;
            listView4.View = View.Details;
            listView4.Items.Clear();
            while (batch[k] != null)
            {
                try
                {
                    connection_check();
                    MySqlDataAdapter axx2 = new MySqlDataAdapter("select Department,Product,Status,Date,Time from fsm_production where Batch_no='" + batch[k] + "' and branch_n = '" + Login.branch + "' ", conn);
                    DataTable dtv2 = new DataTable();
                    axx2.Fill(dtv2);

                    DataRow dr = dtv2.Rows[0];
                    ListViewItem listitem = new ListViewItem(batch[k]);
                    listitem.SubItems.Add(dr["Department"].ToString());
                    listitem.SubItems.Add(dr["Product"].ToString());
                    listitem.SubItems.Add(dr["Status"].ToString());
                    listitem.SubItems.Add(dr["Date"].ToString());
                    listitem.SubItems.Add(dr["Time"].ToString());
                    listView4.Items.Add(listitem);

                    dtv2.Dispose();
                    axx2.Dispose();
                }
                catch (Exception ex)
                {


                }

                k++;
            }

        }
        private void demandlist()
        {
            listView5.View = View.Details;
            listView5.Items.Clear();

            MySqlDataAdapter axx = new MySqlDataAdapter("select DISTINCT(demand_id),branch from fsm_demand_note where (status ='Demand') and (branch_n = '" + Login.branch + "') ", conn);
            DataTable dtv = new DataTable();
            axx.Fill(dtv);
            for (int i = 0; i < dtv.Rows.Count; i++)
            {
                DataRow dr = dtv.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["demand_id"].ToString());
                listitem.SubItems.Add(dr["branch"].ToString());
                listView5.Items.Add(listitem);
            }
            dtv.Dispose();
            axx.Dispose();

        }
        private void demandlist_2()
        {
            listView6.View = View.Details;
            listView6.Items.Clear();
            try
            {
                MySqlDataAdapter axx = new MySqlDataAdapter("select DISTINCT(demand_id) from fsm_demand_note where (branch_n ='" + bdn.Text + "') and (branch ='" + Login.branch + "')  and (status='Demand') and (branch_n !='" + Login.branch + "')", conn);
                DataTable dtv = new DataTable();
                axx.Fill(dtv);
                for (int i = 0; i < dtv.Rows.Count; i++)
                {
                    DataRow dr = dtv.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["demand_id"].ToString());

                    listView6.Items.Add(listitem);
                }
                dtv.Dispose();
                axx.Dispose();

            }
            catch (Exception ex)
            {


            }


        }
        private void demandlist_3()
        {
            listView6.View = View.Details;
            listView6.Items.Clear();

            MySqlDataAdapter axx = new MySqlDataAdapter("select DISTINCT(demand_id) from fsm_demand_note where status!='Finished' ", conn);
            DataTable dtv = new DataTable();
            axx.Fill(dtv);
            for (int i = 0; i < dtv.Rows.Count; i++)
            {
                DataRow dr = dtv.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["demand_id"].ToString());

                listView6.Items.Add(listitem);
            }
            dtv.Dispose();
            axx.Dispose();

        }
        public DataSet SelectAll7()
        {

            DataSet ds1 = new DataSet();

            try
            {
                try
                {
                    connection_check();
                    MySqlCommand cmd11 = new MySqlCommand("select Batch_no,Department,barcode,Product,product_cost,quantity,total_cost,Date,Time from fsm_production_status where branch_n='" + Login.branch + "' ;", conn);
                    MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                    daa1.Fill(ds1);

                    cmd11.Dispose();

                }
                catch (Exception ex)
                {
                    connection_check();
                }

            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid7()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll7();

                dataGridView9.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public DataSet SelectAll29()
        {

            DataSet ds1 = new DataSet();

            try
            {
                try
                {
                    connection_check();
                    MySqlCommand cmd11 = new MySqlCommand("select DISTINCT(demand_id),status,branch from fsm_demand_note where (status != 'Finished') and (branch_n = '" + Login.branch + "') ", conn);
                    MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                    daa1.Fill(ds1);

                    cmd11.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection_check();
                }

            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid29()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll29();

                dataGridView21.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public DataSet SelectAll39()
        {

            DataSet ds1 = new DataSet();

            try
            {
                try
                {
                    connection_check();
                    MySqlCommand cmd11 = new MySqlCommand("select cat_name,barcode,retial_price from fsm_pro_pricing order by cat_name asc ", conn);//why branch not in this query?
                    MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                    daa1.Fill(ds1);

                    cmd11.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection_check();
                }

            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid39()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll39();

                dataGridView24.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public DataSet SelectAll32()
        {

            DataSet ds1 = new DataSet();

            try
            {
                try
                {
                    connection_check();
                    MySqlCommand cmd11 = new MySqlCommand("select DISTINCT(demand_id),status,branch from fsm_demand_note where (status = 'Finished') and (branch_n = '" + Login.branch + "') ", conn);
                    MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                    daa1.Fill(ds1);

                    cmd11.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection_check();
                }

            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid32()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll32();

                dataGridView19.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        private void listView1_Click_1(object sender, EventArgs e)
        {
            cb_pd.Text = "";
            Bind_Grid3();
            txt_bat.Text = listView1.SelectedItems[0].SubItems[0].Text;
            batch_tex.Text = listView1.SelectedItems[0].SubItems[0].Text;
            //tempbatch = listView1.SelectedItems[0].SubItems[0].Text;


            Bind_Grid5();
            upup_label.Visible = false;
            up_label.Visible = false;
            for (int b = 0; b < dataGridView3.RowCount; b++)
            {
                pin = dataGridView3.Rows[b].Cells["Item_n"].Value.ToString();
                if (dataGridView3.Rows[b].Cells["rem_qty"].Value == null || dataGridView3.Rows[b].Cells["rem_qty"].Value == "")
                {

                    dataGridView3.Rows[b].Cells["rem_qty"].Value = "0";
                }
                pin2 = dataGridView3.Rows[b].Cells["icost"].Value.ToString();
                try
                {
                    connection_check();
                    try
                    {
                        connection_check();
                        MySqlCommand total_qantity = new MySqlCommand("select rema_qty from fsm_voucher_log where ((raw_name ='" + pin + "')and(cost='" + pin2 + "') and  (branch_n= '" + Login.branch + "')) ", conn);
                        total_qantity.ExecuteNonQuery();
                        MySqlDataReader rd = total_qantity.ExecuteReader();
                        while (rd.Read())
                        {
                            dataGridView3.Rows[b].Cells["rem_qty"].Value = rd[0].ToString();
                        }
                        rd.Dispose();

                    }
                    catch (Exception ex)
                    {
                        connection_check();

                    }
                }
                catch (Exception ex)
                {


                }

            }

        }
        public DataSet SelectAll4()
        {

            DataSet ds1 = new DataSet();

            try
            {
                try
                {
                    connection_check();
                    MySqlCommand cmd11 = new MySqlCommand("select Product,Itemname,item_qty,rem_qty from fsm_production where Batch_no ='" + tempbatch + "'branch_n = '" + Login.branch + "';", conn);
                    MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                    daa1.Fill(ds1);

                    cmd11.Dispose();
                }
                catch (Exception ex)
                {


                }


            }

            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid4()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll4();

                dataGridView3.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public DataSet SelectAll5()
        {

            DataSet ds1 = new DataSet();

            try
            {
                // tempbatch = listView1.SelectedItems[0].SubItems[0].Text;
                try
                {
                    connection_check();
                    MySqlCommand cmd11 = new MySqlCommand("select Product,Itemname,item_price,item_qty,product_cost from fsm_production where  Batch_no ='" + txt_bat.Text + "' and branch_n = '" + Login.branch + "' ;", conn);
                    MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                    daa1.Fill(ds1);

                    cmd11.Dispose();

                }
                catch (Exception ex)
                {


                }

            }

            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid5()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll5();

                dataGridView3.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public DataSet SelectAll5_5()
        {

            DataSet ds1 = new DataSet();

            try
            {
                // tempbatch = listView1.SelectedItems[0].SubItems[0].Text;
                try
                {
                    connection_check();
                    MySqlCommand cmd11 = new MySqlCommand("select Product,Itemname,item_qty,item_price from fsm_production where  Batch_no ='" + texbatch.Text + "' and branch_n = '" + Login.branch + "' ;", conn);
                    MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                    daa1.Fill(ds1);

                    cmd11.Dispose();

                }
                catch (Exception ex)
                {


                }

            }

            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid5_5()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll5_5();

                dataGridView3.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public DataSet SelectAll17()
        {

            DataSet ds1 = new DataSet();

            try
            {
                // tempbatch = listView1.SelectedItems[0].SubItems[0].Text;
                try
                {
                    connection_check();
                }
                catch (Exception ex)
                {


                }
                MySqlCommand cmd11 = new MySqlCommand("select cat_name,itemname from depitem where cat_name='" + Pd_create.Text + "'", conn);
                MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                daa1.Fill(ds1);

                cmd11.Dispose();

            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid17()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll17();

                dataGridView8.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public DataSet SelectAll177()
        {

            DataSet ds1 = new DataSet();

            try
            {
                // tempbatch = listView1.SelectedItems[0].SubItems[0].Text;
                try
                {
                    connection_check();
                }
                catch (Exception ex)
                {


                }
                MySqlCommand cmd11 = new MySqlCommand("select cat_name,Itemname from fsm_null3 ", conn);
                MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                daa1.Fill(ds1);

                cmd11.Dispose();

            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid177()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll177();

                dataGridView8.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public DataSet SelectAll18()
        {

            DataSet ds1 = new DataSet();

            try
            {
                // tempbatch = listView1.SelectedItems[0].SubItems[0].Text;
                try
                {
                    connection_check();
                    MySqlCommand cmd11 = new MySqlCommand("select dep_name from departmenttb ", conn);
                    MySqlDataAdapter daa1 = new MySqlDataAdapter(cmd11);

                    daa1.Fill(ds1);

                    cmd11.Dispose();

                }
                catch (Exception ex)
                {


                }

            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            return ds1;


        }

        private void Bind_Grid18()
        {
            try
            {
                DataSet Ds1;

                Ds1 = this.SelectAll18();

                dataGridView14.DataSource = Ds1.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void item_box_KeyDown(object sender, KeyEventArgs e)
        {
            //Bind_Grid0();
        }






        private void inv_num_TextChanged(object sender, EventArgs e)
        {
            Bind_Grid0();
            //try
            //{
            //    text_in_id.Text = "FS-" + DateTime.Today.ToString("MMyy") + DateTime.Now.ToString("hhmm");
            //}
            //catch (Exception es)
            //{
            //}
            //add_label.Visible = false;
            //update_label.Visible = false;
            //if (checkBox1.Checked == true)
            //{
            //    Bind_Grid2();
            //}
            //else if(checkBox1.Checked == false)
            //{



            //}
            //try
            //{
            //    text_in_id.Text = "FS-"+inv_num.Text;
            //}
            //catch (Exception es)
            //{
            //}
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            int col = e.ColumnIndex;
            double cvv = 0;
            double cvv1 = 0;
            string ppcost = "0";
            double t_q = 0;

           // if (col == 2)
            //{


            //    try
            //    {
            //        iprice = dataGridView2.Rows[rowindex].Cells["Price"].Value.ToString();
            //    }
            //    catch (Exception ex)
            //    {
            //        iprice = "0";

            //    }

            //    for (int b = 0; b < dataGridView2.RowCount; b++)
            //    {
            //        pin = dataGridView2.Rows[b].Cells["itemname"].Value.ToString();
            //        if (dataGridView2.Rows[b].Cells["open_cost"].Value == null || dataGridView2.Rows[b].Cells["open_cost"].Value == "")
            //        {
            //            dataGridView2.Rows[b].Cells["open_cost"].Value = "0";
            //            dataGridView2.Rows[b].Cells["c_quantity"].Value = "0";
            //        }

            //        connection_check();
            //        try
            //        {
            //            MySqlCommand total_qantity = new MySqlCommand("select total_kg_p,rema_qty from fsm_voucher_log where ((raw_name ='" + pin + "') and (cost='" + iprice + "') and (branch_n = '" + Login.branch + "')) ", conn);
            //            total_qantity.ExecuteNonQuery();
            //            MySqlDataReader rd = total_qantity.ExecuteReader();
            //            while (rd.Read())
            //            {
            //                dataGridView2.Rows[b].Cells["open_cost"].Value = rd[0].ToString();
            //                dataGridView2.Rows[b].Cells["c_quantity"].Value = rd[1].ToString();

            //            }
            //            rd.Dispose();
            //        }
            //        catch (Exception ex)
            //        {

            //            connection_check();
            //            MessageBox.Show(ex.Message);
            //        }
            //    }

            //}

            if (col == 3)
            {
                try
                {

                    trqty = dataGridView2.Rows[rowindex].Cells["tr_qty"].Value.ToString();
                }
                catch (Exception ec)
                {
                    trqty = "0";
                }
                try
                {
                    Cqty = dataGridView2.Rows[rowindex].Cells["c_quantity"].Value.ToString();

                }
                catch (Exception ec)
                {
                    Cqty = "0";
                }
                if (dataGridView2.Rows[rowindex].Cells["c_quantity"].Value == "0")
                {
                    dataGridView2.Rows[rowindex].Cells["tr_qty"].Value = "0";
                }
                if (Convert.ToDouble(trqty) < 0)
                {
                    dataGridView2.Rows[rowindex].Cells["tr_qty"].Value = "0";
                }
                try
                {

                    trqty = dataGridView2.Rows[rowindex].Cells["tr_qty"].Value.ToString();
                }
                catch (Exception ec)
                {
                    trqty = "0";
                }
                try
                {


                    Cqty = dataGridView2.Rows[rowindex].Cells["c_quantity"].Value.ToString();

                }
                catch (Exception ec)
                {
                    Cqty = "0";
                }
                if (Convert.ToDouble(trqty) <= Convert.ToDouble(Cqty))
                {
                    dataGridView2.Rows[rowindex].Cells["c_quantity"].Value = Convert.ToDouble(Cqty) - Convert.ToDouble(trqty);
                    try
                    {
                        iprice = dataGridView2.Rows[rowindex].Cells["Price"].Value.ToString();
                    }
                    catch (Exception ex)
                    {
                        iprice = "0";

                    }

                    dataGridView2.Rows[rowindex].Cells["pcost"].Value = Convert.ToDouble(iprice) * Convert.ToDouble(trqty);
                }
                else if (Convert.ToDouble(trqty) > Convert.ToDouble(Cqty))
                {
                    dataGridView2.Rows[rowindex].Cells["tr_qty"].Value = "0";
                    dataGridView2.Rows[rowindex].Cells["pcost"].Value = "0";
                }

            }

            for (int k = 0; k < dataGridView2.RowCount; k++)
            {
                try
                {

                    ppcost = dataGridView2.Rows[k].Cells["pcost"].Value.ToString();

                    t_q = Convert.ToDouble(ppcost) + t_q;




                }
                catch (Exception ex)
                {
                    ppcost = "0";
                    t_q = Convert.ToDouble(ppcost) + t_q;
                    //  MessageBox.Show(ex.Message);
                }
                label128.Text = Convert.ToString(t_q);

            }
            t_q = 0;


        }

        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int rowindex = e.RowIndex;
            int col = e.ColumnIndex;
            string tttr = "";
            string cccr = "";
            if (col == 3)
            {
                try
                {

                    tttr = dataGridView2.Rows[rowindex].Cells["tr_qty"].Value.ToString();
                }
                catch (Exception ec)
                {
                    tttr = "0";
                    dataGridView2.Rows[rowindex].Cells["tr_qty"].Value = "0";
                    //MessageBox.Show(ec.Message);
                }
                try
                {


                    cccr = dataGridView2.Rows[rowindex].Cells["c_quantity"].Value.ToString();
                    if (cccr == "")
                    {
                        cccr = "0";
                        dataGridView2.Rows[rowindex].Cells["c_quantity"].Value = "0";
                    }

                }
                catch (Exception ec)
                {

                }
                if (Convert.ToDouble(tttr) < 0)
                {
                    dataGridView2.Rows[rowindex].Cells["tr_qty"].Value = "0";
                }
                try
                {

                    tttr = dataGridView2.Rows[rowindex].Cells["tr_qty"].Value.ToString();
                }
                catch (Exception ec)
                {
                    tttr = "0";
                    dataGridView2.Rows[rowindex].Cells["tr_qty"].Value = "0";
                    //MessageBox.Show(ec.Message);
                }
                try
                {


                    cccr = dataGridView2.Rows[rowindex].Cells["c_quantity"].Value.ToString();
                    if (cccr == "")
                    {
                        cccr = "0";
                        dataGridView2.Rows[rowindex].Cells["c_quantity"].Value = "0";
                    }
                }
                catch (Exception ec)
                {
                }

                //if (dataGridView3.Rows[rowindex].Cells["rem_qty"].Value != "0" && Convert.ToInt32(tttr) < Convert.ToInt32(cccr))
                {
                    dataGridView2.Rows[rowindex].Cells["c_quantity"].Value = Convert.ToDouble(cccr) + Convert.ToDouble(tttr);
                    dataGridView2.Rows[rowindex].Cells["pcost"].Value = "0";
                }
                if (Convert.ToDouble(tttr) > Convert.ToDouble(cccr))
                {
                    dataGridView2.Rows[rowindex].Cells["tr_qty"].Value = "0";
                    dataGridView2.Rows[rowindex].Cells["pcost"].Value = "0";
                }
                if (dataGridView2.Rows[rowindex].Cells["c_quantity"].Value == "0")
                {
                    dataGridView2.Rows[rowindex].Cells["tr_qty"].Value = "0";
                    // MessageBox.Show("The current Quantity Is Empty","Error Inviad Quantity",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }



            }

        }

        private void dataGridView3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            int col = e.ColumnIndex;
            string trqty1 = "";
            string Cqty1 = "";
            double t_q = 0;
            string top = "";
            if (col == 5)
            {
                try
                {
                    trqty1 = dataGridView3.Rows[rowindex].Cells["item_qty"].Value.ToString();
                    if (trqty1 == null || trqty1 == "")
                    {
                        trqty1 = "0";
                    }
                }
                catch (Exception ec)
                {
                    // MessageBox.Show(ec.Message);
                }
                try
                {


                    Cqty1 = dataGridView3.Rows[rowindex].Cells["rem_qty"].Value.ToString();

                }
                catch (Exception ec)
                {
                }
                if (dataGridView3.Rows[rowindex].Cells["rem_qty"].Value == "0")
                {
                    dataGridView3.Rows[rowindex].Cells["item_qty"].Value = "0";
                    // MessageBox.Show("The current Quantity Is Empty","Error Inviad Quantity",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                if (Convert.ToDouble(trqty1) < 0)
                {
                    dataGridView3.Rows[rowindex].Cells["item_qty"].Value = "0";
                }
                try
                {

                    trqty1 = dataGridView3.Rows[rowindex].Cells["item_qty"].Value.ToString();
                    if (trqty1 == null || trqty1 == "")
                    {
                        trqty1 = "0";
                    }
                }
                catch (Exception ec)
                {
                    // MessageBox.Show(ec.Message);
                }
                try
                {


                    Cqty1 = dataGridView3.Rows[rowindex].Cells["rem_qty"].Value.ToString();

                }
                catch (Exception ec)
                {
                }
                if (Convert.ToDouble(trqty1) <= Convert.ToDouble(Cqty1))
                {
                    dataGridView3.Rows[rowindex].Cells["rem_qty"].Value = Convert.ToDouble(Cqty1) - Convert.ToDouble(trqty1);
                    try
                    { iprice = dataGridView3.Rows[rowindex].Cells["icost"].Value.ToString(); }
                    catch (Exception ec)
                    { }
                    dataGridView3.Rows[rowindex].Cells["pipcost"].Value = Convert.ToDouble(iprice) * Convert.ToDouble(trqty1);
                }
                else if (Convert.ToDouble(trqty1) > Convert.ToDouble(Cqty1))
                {
                    dataGridView3.Rows[rowindex].Cells["item_qty"].Value = "0";
                    dataGridView3.Rows[rowindex].Cells["pipcost"].Value = "0";
                }

            }
            for (int k = 0; k < dataGridView3.RowCount; k++)
            {
                try
                {

                    top = dataGridView3.Rows[k].Cells["pipcost"].Value.ToString();

                    t_q = Convert.ToDouble(top) + t_q;




                }
                catch (Exception ex)
                {

                    //  MessageBox.Show(ex.Message);
                }
                label130.Text = Convert.ToString(t_q);

            }
            t_q = 0;

        }

        private void dataGridView3_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int rowindex = e.RowIndex;
            int col = e.ColumnIndex;
            string tttr = "";
            string cccr = "";
            if (col == 5)
            {
                try
                {

                    tttr = dataGridView3.Rows[rowindex].Cells["item_qty"].Value.ToString();
                }
                catch (Exception ec)
                {
                    tttr = "0";
                    //dataGridView2.Rows[rowindex].Cells["tr_qty"].Value = "0";
                    //MessageBox.Show(ec.Message);
                }
                try
                {


                    cccr = dataGridView3.Rows[rowindex].Cells["rem_qty"].Value.ToString();

                }
                catch (Exception ec)
                {
                }
                if (Convert.ToDouble(tttr) < 0)
                {
                    dataGridView3.Rows[rowindex].Cells["item_qty"].Value = "0";
                }
                try
                {

                    tttr = dataGridView3.Rows[rowindex].Cells["item_qty"].Value.ToString();
                }
                catch (Exception ec)
                {
                    tttr = "0";
                    //dataGridView2.Rows[rowindex].Cells["tr_qty"].Value = "0";
                    //MessageBox.Show(ec.Message);
                }
                try
                {


                    cccr = dataGridView3.Rows[rowindex].Cells["rem_qty"].Value.ToString();

                }
                catch (Exception ec)
                {
                }

                //if (dataGridView3.Rows[rowindex].Cells["rem_qty"].Value != "0" && Convert.ToInt32(tttr) < Convert.ToInt32(cccr))
                {
                    dataGridView3.Rows[rowindex].Cells["rem_qty"].Value = Convert.ToDouble(cccr) + Convert.ToDouble(tttr);
                    dataGridView3.Rows[rowindex].Cells["pipcost"].Value = "0";
                }
                if (Convert.ToDouble(tttr) > Convert.ToDouble(cccr))
                {
                    dataGridView3.Rows[rowindex].Cells["item_qty"].Value = "0";
                    dataGridView3.Rows[rowindex].Cells["pipcost"].Value = "0";
                }
                if (dataGridView3.Rows[rowindex].Cells["rem_qty"].Value == "0")
                {
                    dataGridView3.Rows[rowindex].Cells["item_qty"].Value = "0";
                    // MessageBox.Show("The current Quantity Is Empty","Error Inviad Quantity",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            hostName = Dns.GetHostName();
            myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            string iiname = "";
            string ttrqty = "";
            string ccqty = "";
            string pp_cost = "";
            string ntqty = "";
            try
            {
                connection_check();
            }
            catch (Exception ex)
            {
            }
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {


                try
                {

                    iiname = dataGridView3.Rows[i].Cells["Item_n"].Value.ToString();

                }
                catch (Exception ec)
                {
                }

                try
                {

                    ttrqty = dataGridView3.Rows[i].Cells["item_qty"].Value.ToString();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
                try
                {


                    ccqty = dataGridView3.Rows[i].Cells["rem_qty"].Value.ToString();

                }
                catch (Exception ec)
                {
                }
                try
                {


                    iprice = dataGridView3.Rows[i].Cells["icost"].Value.ToString();

                }
                catch (Exception ec)
                {
                }
                try
                {


                    pprice = dataGridView3.Rows[i].Cells["pipcost"].Value.ToString();

                }
                catch (Exception ec)
                {
                }
                //try
                //{

                //    if (iprice == null || iprice == "")
                //    {
                //        iicost = dataGridView3.Rows[i].Cells["icost"].Value.ToString();
                //    }
                //    else if (iprice == null || iprice == "")
                //    {
                //        iicost = "0";
                //    }


                //}
                //catch (Exception ec)
                //{

                //}
                try
                {
                    connection_check();
                    MySqlCommand itd = new MySqlCommand("Update fsm_production set product_cost='" + pprice + "', item_qty='" + ttrqty + "' , rem_qty = '" + ccqty + "', item_price='" + iprice + "' where ( Batch_no ='" + batch_tex.Text + "') and (branch_n = '" + Login.branch + "') and (Itemname='" + iiname + "') ", conn);
                    itd.ExecuteNonQuery();
                    itd.Dispose();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    connection_check();

                }
                try
                {
                    MySqlCommand axx = new MySqlCommand("select cost from fsm_voucher_log where ((raw_name='" + Iname + "' )and(cost='" + iprice + "')and(branch_n = '" + Login.branch + "'))", conn);
                    axx.ExecuteNonQuery();
                    MySqlDataReader dtr = axx.ExecuteReader();
                    while (dtr.Read())
                    {
                        p_cost = dtr[0].ToString();
                    }
                    axx.Dispose();
                    dtr.Dispose();

                }
                catch (Exception ex)
                {
                    connection_check();

                }

                connection_check();
                try
                {
                    //ntqty = Convert.ToString(Convert.ToDouble(p_cost) - Convert.ToDouble(trqty));
                    MySqlCommand in_upd = new MySqlCommand("Update fsm_voucher_log set total_cost ='" + Convert.ToString(Convert.ToDouble(oqty) * Convert.ToDouble(p_cost)) + "',  total_kg_p ='" + ccqty + "', rema_qty ='" + ccqty + "'   where  ((raw_name='" + Iname + "')and(cost='" + iprice + "') and ( branch_n = '" + Login.branch + "'))", conn);
                    in_upd.ExecuteNonQuery();
                    in_upd.Dispose();
                }
                catch (Exception ex)
                {
                    connection_check();

                }


                //MessageBox.Show("Record is successfully Added!", "Record Added Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            cb_dep.Text = "";
            cb_pd.Text = "";
            batch_tex.Text = "";
            txt_bat.Text = "";
            Bind_Grid5();
            label128.Text = "0";
            label130.Text = "0";
            fsm_pro_listviewer();
            upup_label.Visible = true;


        }

        ///////////////////////////////----------------------Purchasing Details Reports-------------------\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\



        private void pur_report()
        {
            DataSet ddd = new DataSet();
            DataTable dtdd = ddd.Tables.Add("Purchasing");

            dtdd.Columns.Add("supplier", Type.GetType("System.String"));
            dtdd.Columns.Add("item", Type.GetType("System.String"));
            dtdd.Columns.Add("weight", Type.GetType("System.String"));
            dtdd.Columns.Add("bag", Type.GetType("System.String"));
            dtdd.Columns.Add("total", Type.GetType("System.String"));
            dtdd.Columns.Add("date", Type.GetType("System.DateTime"));
            dtdd.Columns.Add("cost", Type.GetType("System.String"));
            dtdd.Columns.Add("total_cost", Type.GetType("System.String"));
            dtdd.Columns.Add("to_date", Type.GetType("System.String"));
            dtdd.Columns.Add("from_date", Type.GetType("System.String"));
            dtdd.Columns.Add("branch", Type.GetType("System.String"));
            dtdd.Columns.Add("tax", Type.GetType("System.String"));
            dtdd.Columns.Add("discount", Type.GetType("System.String"));
            dtdd.Columns.Add("invoice_number", Type.GetType("System.String"));
            dtdd.Columns.Add("bag_cost", Type.GetType("System.String"));
            dtdd.Columns.Add("tax_a", Type.GetType("System.String"));


            try
            {
                connection_check();
            }
            catch (Exception ex)
            {
            }



            DataRow rddd;
            string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            connection_check();
            try
            {
                MySqlCommand commander = new MySqlCommand("select supplier,raw_name,weight,bag,total_kg_p,cost,total_cost,invoice_date,Tex,Discount,invoice_code,ctn_cost,tax_amount from fsm_voucher_log where ((invoice_date >='" + date1 + "' and invoice_date <='" + date2 + "' )and (branch_n = '" + Login.branch + "') and (Status='for production'))", conn);
                commander.ExecuteNonQuery();
                MySqlDataReader reader = commander.ExecuteReader();
                while (reader.Read())
                {
                    rddd = dtdd.NewRow();
                    rddd["supplier"] = reader[0].ToString();
                    rddd["item"] = reader[1].ToString();
                    rddd["weight"] = reader[2].ToString();
                    rddd["bag"] = reader[3].ToString();
                    rddd["total"] = reader[4].ToString();
                    rddd["cost"] = reader[5].ToString();
                    rddd["total_cost"] = reader[6].ToString();
                    rddd["date"] = reader[7].ToString();
                    rddd["tax"] = reader[8].ToString();
                    rddd["discount"] = reader[9].ToString();
                    rddd["invoice_number"] = reader[10].ToString();
                    rddd["bag_cost"] = reader[11].ToString();
                    rddd["tax_a"] = reader[12].ToString();
                    rddd["to_date"] = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                    rddd["from_date"] = dateTimePicker2.Value.ToString("dd-MM-yyyy");
                    rddd["branch"] = Login.branch;
                    dtdd.Rows.Add(rddd);

                }
                reader.Dispose();
                commander.Dispose();

            }
            catch (Exception ex)
            {
                connection_check();
            }

            purchasing_report ar = new purchasing_report();
            ar.SetDataSource(dtdd);
            report_view vv = new report_view();

            vv.crystalReportViewer1.ReportSource = ar;
            vv.crystalReportViewer1.Refresh();
            vv.Show();



        }
        private void pur_report_2()
        {
            DataSet ddd = new DataSet();
            DataTable dtdd = ddd.Tables.Add("Purchasing");

            dtdd.Columns.Add("supplier", Type.GetType("System.String"));
            dtdd.Columns.Add("item", Type.GetType("System.String"));
            dtdd.Columns.Add("weight", Type.GetType("System.String"));
            dtdd.Columns.Add("bag", Type.GetType("System.String"));
            dtdd.Columns.Add("total", Type.GetType("System.String"));
            dtdd.Columns.Add("date", Type.GetType("System.DateTime"));
            dtdd.Columns.Add("cost", Type.GetType("System.String"));
            dtdd.Columns.Add("total_cost", Type.GetType("System.String"));
            dtdd.Columns.Add("to_date", Type.GetType("System.String"));
            dtdd.Columns.Add("from_date", Type.GetType("System.String"));
            dtdd.Columns.Add("branch", Type.GetType("System.String"));
            dtdd.Columns.Add("tax", Type.GetType("System.String"));
            dtdd.Columns.Add("discount", Type.GetType("System.String"));
            dtdd.Columns.Add("invoice_number", Type.GetType("System.String"));
            dtdd.Columns.Add("bag_cost", Type.GetType("System.String"));
            dtdd.Columns.Add("tax_a", Type.GetType("System.String"));
            dtdd.Columns.Add("barcode", Type.GetType("System.String"));


            try
            {
                connection_check();
            }
            catch (Exception ex)
            {
            }



            DataRow rddd;
            string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            connection_check();
            try
            {
                MySqlCommand commander = new MySqlCommand("select supplier,raw_name,weight,bag,total_kg_p,cost,total_cost,invoice_date,Tex,Discount,invoice_code,ctn_cost,tax_amount,barcode from fsm_voucher_log where ((invoice_date >='" + date1 + "' and invoice_date <='" + date2 + "') and (branch_n = '" + Login.branch + "') and (Status='Finished Goods'))", conn);
                commander.ExecuteNonQuery();
                MySqlDataReader reader = commander.ExecuteReader();
                while (reader.Read())
                {
                    rddd = dtdd.NewRow();
                    rddd["supplier"] = reader[0].ToString();
                    rddd["item"] = reader[1].ToString();
                    rddd["weight"] = reader[2].ToString();
                    rddd["bag"] = reader[3].ToString();
                    rddd["total"] = reader[4].ToString();
                    rddd["cost"] = reader[5].ToString();
                    rddd["total_cost"] = reader[6].ToString();
                    rddd["date"] = reader[7].ToString();
                    rddd["tax"] = reader[8].ToString();
                    rddd["discount"] = reader[9].ToString();
                    rddd["invoice_number"] = reader[10].ToString();
                    rddd["bag_cost"] = reader[11].ToString();
                    rddd["tax_a"] = reader[12].ToString();
                    rddd["barcode"] = reader[13].ToString();
                    rddd["to_date"] = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                    rddd["from_date"] = dateTimePicker2.Value.ToString("dd-MM-yyyy");
                    rddd["branch"] = Login.branch;
                    dtdd.Rows.Add(rddd);

                }
                reader.Dispose();
                commander.Dispose();

            }
            catch (Exception ex)
            {
                connection_check();
            }

            purchasing_report_2 ar = new purchasing_report_2();
            ar.SetDataSource(dtdd);
            report_view vv = new report_view();

            vv.crystalReportViewer1.ReportSource = ar;
            vv.crystalReportViewer1.Refresh();
            vv.Show();



        }
        private void current_report()
        {
            DataSet ddd = new DataSet();
            DataTable dtdd = ddd.Tables.Add("Purchasing");

            dtdd.Columns.Add("supplier", Type.GetType("System.String"));
            dtdd.Columns.Add("item", Type.GetType("System.String"));
            //dtdd.Columns.Add("weight", Type.GetType("System.String"));
            //dtdd.Columns.Add("bag", Type.GetType("System.String"));
            dtdd.Columns.Add("total", Type.GetType("System.String"));
            dtdd.Columns.Add("date", Type.GetType("System.DateTime"));
            dtdd.Columns.Add("to_date", Type.GetType("System.String"));
            dtdd.Columns.Add("from_date", Type.GetType("System.String"));
            dtdd.Columns.Add("branch", Type.GetType("System.String"));

            DataRow rddd;
            string[] bn = new string[5000];
            string[] itemn = new string[5000];
            int k = 0;
            int no = 0;

            try
            {
                connection_check();
                MySqlCommand axx = new MySqlCommand("select DISTINCT(raw_name) from fsm_voucher_log where (Status='for production') and (branch_n='" + Login.branch + "') ", conn);
                axx.ExecuteNonQuery();
                MySqlDataReader dtr = axx.ExecuteReader();
                while (dtr.Read())
                {
                    bn[k] = dtr[0].ToString();
                    k++;
                }
                axx.Dispose();
                dtr.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                for (int i = 0; i < k; i++)
                {


                    connection_check();
                    MySqlCommand commander = new MySqlCommand("select sum(total_kg_p) from fsm_voucher_log where ((raw_name='" + bn[i] + "')and(branch_n = '" + Login.branch + "') and (Status='for production') ) order by raw_name asc ", conn);
                    commander.ExecuteNonQuery();
                    MySqlDataReader reader = commander.ExecuteReader();
                    while (reader.Read())
                    {
                        rddd = dtdd.NewRow();
                        rddd["item"] = bn[i];
                        rddd["total"] = reader[0].ToString();
                        rddd["branch"] = Login.branch;
                        dtdd.Rows.Add(rddd);

                    }
                    reader.Dispose();
                    commander.Dispose();
                }
                current_stock_report ar = new current_stock_report();
                ar.SetDataSource(dtdd);
                report_view vv = new report_view();

                vv.crystalReportViewer1.ReportSource = ar;
                vv.crystalReportViewer1.Refresh();
                vv.Show();
            }
            catch (Exception ex)
            { }




        }
        private void current_report_2()
        {
            DataSet ddd = new DataSet();
            DataTable dtdd = ddd.Tables.Add("Purchasing");

            dtdd.Columns.Add("supplier", Type.GetType("System.String"));
            dtdd.Columns.Add("item", Type.GetType("System.String"));
            //dtdd.Columns.Add("weight", Type.GetType("System.String"));
            //dtdd.Columns.Add("bag", Type.GetType("System.String"));
            dtdd.Columns.Add("total", Type.GetType("System.String"));
            dtdd.Columns.Add("date", Type.GetType("System.DateTime"));
            dtdd.Columns.Add("to_date", Type.GetType("System.String"));
            dtdd.Columns.Add("from_date", Type.GetType("System.String"));
            dtdd.Columns.Add("branch", Type.GetType("System.String"));
            dtdd.Columns.Add("barcode", Type.GetType("System.String"));

            DataRow rddd;
            string[] bn = new string[5000];
            int k = 0;
            try
            {
                connection_check();
                MySqlCommand axx = new MySqlCommand("select DISTINCT(raw_name) from fsm_voucher_log where (Status='Finished Goods') and (branch_n='" + Login.branch + "') ", conn);
                axx.ExecuteNonQuery();
                MySqlDataReader dtr = axx.ExecuteReader();
                while (dtr.Read())
                {
                    bn[k] = dtr[0].ToString();
                    k++;
                }
                axx.Dispose();
                dtr.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                for (int i = 0; i < k; i++)
                {

                    connection_check();
                    MySqlCommand commander = new MySqlCommand("select sum(total_kg_p),barcode from fsm_voucher_log where ((raw_name='" + bn[i] + "')and(branch_n = '" + Login.branch + "') and (Status='Finished Goods')) ", conn);
                    commander.ExecuteNonQuery();
                    MySqlDataReader reader = commander.ExecuteReader();
                    while (reader.Read())
                    {
                        rddd = dtdd.NewRow();
                        rddd["item"] = bn[i];
                        rddd["total"] = reader[0].ToString();
                        rddd["barcode"] = reader[1].ToString();
                        rddd["branch"] = Login.branch;
                        dtdd.Rows.Add(rddd);

                    }
                    reader.Dispose();
                    commander.Dispose();
                }
                current_stock_report_2 ar = new current_stock_report_2();
                ar.SetDataSource(dtdd);
                report_view vv = new report_view();

                vv.crystalReportViewer1.ReportSource = ar;
                vv.crystalReportViewer1.Refresh();
                vv.Show();
            }
            catch (Exception ex)
            { }




        }
        private void suppliers_details()
        {
            try
            {
                connection_check();
            }
            catch (Exception ex)
            {


            }
            DataSet ddd = new DataSet();
            DataTable dtdd = ddd.Tables.Add("Purchasing");

            dtdd.Columns.Add("supplier", Type.GetType("System.String"));
            dtdd.Columns.Add("item", Type.GetType("System.String"));
            dtdd.Columns.Add("weight", Type.GetType("System.String"));
            dtdd.Columns.Add("bag", Type.GetType("System.String"));
            dtdd.Columns.Add("total", Type.GetType("System.String"));
            dtdd.Columns.Add("date", Type.GetType("System.DateTime"));
            dtdd.Columns.Add("cost", Type.GetType("System.String"));
            dtdd.Columns.Add("total_cost", Type.GetType("System.String"));
            dtdd.Columns.Add("to_date", Type.GetType("System.String"));
            dtdd.Columns.Add("from_date", Type.GetType("System.String"));
            dtdd.Columns.Add("branch", Type.GetType("System.String"));
            dtdd.Columns.Add("invoice_number", Type.GetType("System.String"));

            DataRow rddd;
            try
            {
                MySqlCommand commander = new MySqlCommand("select  raw_name , weight, bag , total_kg_p,cost ,total_cost,invoice_date,invoice_code from fsm_voucher_log where ((supplier = '" + sup_box.Text + "') and  (invoice_date BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "') and (branch_n = '" + Login.branch + "')and(Status='for production')) ", conn);
                commander.ExecuteNonQuery();
                MySqlDataReader reader = commander.ExecuteReader();
                while (reader.Read())
                {
                    rddd = dtdd.NewRow();
                    rddd["supplier"] = sup_box.Text;
                    rddd["item"] = reader[0].ToString();
                    rddd["weight"] = reader[1].ToString();
                    rddd["bag"] = reader[2].ToString();
                    rddd["total"] = reader[3].ToString();
                    rddd["cost"] = reader[4].ToString();
                    rddd["total_cost"] = reader[5].ToString();
                    rddd["date"] = reader[6].ToString();
                    rddd["invoice_number"] = reader[7].ToString();
                    rddd["to_date"] = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                    rddd["from_date"] = dateTimePicker2.Value.ToString("dd-MM-yyyy");
                    rddd["branch"] = Login.branch;

                    dtdd.Rows.Add(rddd);

                }
                reader.Dispose();
                commander.Dispose();

                supplier_report ar = new supplier_report();
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
        private void suppliers_details_2()
        {
            try
            {
                connection_check();
            }
            catch (Exception ex)
            {


            }
            DataSet ddd = new DataSet();
            DataTable dtdd = ddd.Tables.Add("Purchasing");

            dtdd.Columns.Add("supplier", Type.GetType("System.String"));
            dtdd.Columns.Add("item", Type.GetType("System.String"));
            dtdd.Columns.Add("weight", Type.GetType("System.String"));
            dtdd.Columns.Add("bag", Type.GetType("System.String"));
            dtdd.Columns.Add("total", Type.GetType("System.String"));
            dtdd.Columns.Add("date", Type.GetType("System.DateTime"));
            dtdd.Columns.Add("cost", Type.GetType("System.String"));
            dtdd.Columns.Add("total_cost", Type.GetType("System.String"));
            dtdd.Columns.Add("to_date", Type.GetType("System.String"));
            dtdd.Columns.Add("from_date", Type.GetType("System.String"));
            dtdd.Columns.Add("branch", Type.GetType("System.String"));
            dtdd.Columns.Add("invoice_number", Type.GetType("System.String"));
            dtdd.Columns.Add("barcode", Type.GetType("System.String"));

            DataRow rddd;
            try
            {
                MySqlCommand commander = new MySqlCommand("select  raw_name , weight, bag , total_kg_p,cost ,total_cost,invoice_date,invoice_code,barcode from fsm_voucher_log where ((supplier = '" + sup_box2.Text + "') and  (invoice_date BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "') and (branch_n = '" + Login.branch + "')and(Status='Finished Goods')) ", conn);
                commander.ExecuteNonQuery();
                MySqlDataReader reader = commander.ExecuteReader();
                while (reader.Read())
                {
                    rddd = dtdd.NewRow();
                    rddd["supplier"] = sup_box2.Text;
                    rddd["item"] = reader[0].ToString();
                    rddd["weight"] = reader[1].ToString();
                    rddd["bag"] = reader[2].ToString();
                    rddd["total"] = reader[3].ToString();
                    rddd["cost"] = reader[4].ToString();
                    rddd["total_cost"] = reader[5].ToString();
                    rddd["date"] = reader[6].ToString();
                    rddd["invoice_number"] = reader[7].ToString();
                    rddd["barcode"] = reader[8].ToString();
                    rddd["to_date"] = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                    rddd["from_date"] = dateTimePicker2.Value.ToString("dd-MM-yyyy");
                    rddd["branch"] = Login.branch;

                    dtdd.Rows.Add(rddd);

                }
                reader.Dispose();
                commander.Dispose();

                supplier_report_2 ar = new supplier_report_2();
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
        private void item_details()
        {
            try
            {
                connection_check();
            }
            catch (Exception ex)
            {


            }
            DataSet ddd = new DataSet();
            DataTable dtdd = ddd.Tables.Add("Purchasing");

            dtdd.Columns.Add("supplier", Type.GetType("System.String"));
            dtdd.Columns.Add("item", Type.GetType("System.String"));
            dtdd.Columns.Add("weight", Type.GetType("System.String"));
            dtdd.Columns.Add("bag", Type.GetType("System.String"));
            dtdd.Columns.Add("total", Type.GetType("System.String"));
            dtdd.Columns.Add("date", Type.GetType("System.DateTime"));
            dtdd.Columns.Add("cost", Type.GetType("System.String"));
            dtdd.Columns.Add("total_cost", Type.GetType("System.String"));
            dtdd.Columns.Add("to_date", Type.GetType("System.String"));
            dtdd.Columns.Add("from_date", Type.GetType("System.String"));
            dtdd.Columns.Add("branch", Type.GetType("System.String"));
            dtdd.Columns.Add("invoice_number", Type.GetType("System.String"));



            try
            {
                DataRow rddd;
                MySqlCommand commander = new MySqlCommand("select  supplier, weight, bag , total_kg_p,cost ,total_cost,invoice_date,invoice_code from fsm_voucher_log where ((raw_name = '" + i_n_box.Text + "' ) and (invoice_date between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "') and (branch_n = '" + Login.branch + "')and(Status='for production'))", conn);
                commander.ExecuteNonQuery();
                MySqlDataReader reader = commander.ExecuteReader();
                while (reader.Read())
                {
                    rddd = dtdd.NewRow();
                    rddd["supplier"] = reader[0].ToString();
                    rddd["item"] = i_n_box.Text;
                    rddd["weight"] = reader[1].ToString();
                    rddd["bag"] = reader[2].ToString();
                    rddd["total"] = reader[3].ToString();
                    rddd["cost"] = reader[4].ToString();
                    rddd["total_cost"] = reader[5].ToString();
                    rddd["date"] = reader[6].ToString();
                    rddd["invoice_number"] = reader[7].ToString();
                    rddd["to_date"] = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                    rddd["from_date"] = dateTimePicker2.Value.ToString("dd-MM-yyyy");
                    rddd["branch"] = Login.branch;

                    dtdd.Rows.Add(rddd);

                }
                reader.Dispose();
                commander.Dispose();

                Item_report ar = new Item_report();
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
        private void item_details_2()
        {
            try
            {
                connection_check();
            }
            catch (Exception ex)
            {


            }
            DataSet ddd = new DataSet();
            DataTable dtdd = ddd.Tables.Add("Purchasing");

            dtdd.Columns.Add("supplier", Type.GetType("System.String"));
            dtdd.Columns.Add("item", Type.GetType("System.String"));
            dtdd.Columns.Add("weight", Type.GetType("System.String"));
            dtdd.Columns.Add("bag", Type.GetType("System.String"));
            dtdd.Columns.Add("total", Type.GetType("System.String"));
            dtdd.Columns.Add("date", Type.GetType("System.DateTime"));
            dtdd.Columns.Add("cost", Type.GetType("System.String"));
            dtdd.Columns.Add("total_cost", Type.GetType("System.String"));
            dtdd.Columns.Add("to_date", Type.GetType("System.String"));
            dtdd.Columns.Add("from_date", Type.GetType("System.String"));
            dtdd.Columns.Add("branch", Type.GetType("System.String"));
            dtdd.Columns.Add("invoice_number", Type.GetType("System.String"));
            dtdd.Columns.Add("barcode", Type.GetType("System.String"));


            try
            {
                DataRow rddd;
                MySqlCommand commander = new MySqlCommand("select  supplier, weight, bag , total_kg_p,cost ,total_cost,invoice_date,invoice_code,barcode from fsm_voucher_log where ((raw_name = '" + i_n_box2.Text + "' ) and (invoice_date between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "') and (branch_n = '" + Login.branch + "')and(Status='Finished Goods'))", conn);
                commander.ExecuteNonQuery();
                MySqlDataReader reader = commander.ExecuteReader();
                while (reader.Read())
                {
                    rddd = dtdd.NewRow();
                    rddd["supplier"] = reader[0].ToString();
                    rddd["item"] = i_n_box2.Text;
                    rddd["weight"] = reader[1].ToString();
                    rddd["bag"] = reader[2].ToString();
                    rddd["total"] = reader[3].ToString();
                    rddd["cost"] = reader[4].ToString();
                    rddd["total_cost"] = reader[5].ToString();
                    rddd["date"] = reader[6].ToString();
                    rddd["invoice_number"] = reader[7].ToString();
                    rddd["barcode"] = reader[8].ToString();
                    rddd["to_date"] = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                    rddd["from_date"] = dateTimePicker2.Value.ToString("dd-MM-yyyy");
                    rddd["branch"] = Login.branch;

                    dtdd.Rows.Add(rddd);

                }
                reader.Dispose();
                commander.Dispose();

                Item_report_2 ar = new Item_report_2();
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
        private void pur_report_btn_Click(object sender, EventArgs e)
        {
            pur_report();

        }

        private void c_s_report_btn_Click(object sender, EventArgs e)
        {
            current_report();
        }

        private void van_report_btn_Click(object sender, EventArgs e)
        {
            suppliers_details();
        }

        private void item_report_btn_Click(object sender, EventArgs e)
        {
            item_details();
        }


        ///////////////////////////////----------------------Purchasing Details Reports End -------------------\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\





        ///////////////////////////////----------------------Production Details Reports-------------------\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        private void dep_pro_report()
        {
            DataSet ddd = new DataSet();
            DataTable dtdd = ddd.Tables.Add("Production");

            dtdd.Columns.Add("product_dep", Type.GetType("System.String"));
            dtdd.Columns.Add("product", Type.GetType("System.String"));
            // dtdd.Columns.Add("item", Type.GetType("System.String"));
            dtdd.Columns.Add("batch_no", Type.GetType("System.String"));
            //dtdd.Columns.Add("qty", Type.GetType("System.String"));
            dtdd.Columns.Add("date", Type.GetType("System.String"));
            dtdd.Columns.Add("time", Type.GetType("System.String"));
            dtdd.Columns.Add("status", Type.GetType("System.String"));
            dtdd.Columns.Add("to_date", Type.GetType("System.String"));
            dtdd.Columns.Add("from_date", Type.GetType("System.String"));
            dtdd.Columns.Add("branch", Type.GetType("System.String"));



            try
            {
                connection_check();
                DataRow rddd;
                MySqlCommand commander = new MySqlCommand("select  Department,Product,Batch_no ,Date,Time,Status,branch_n from fsm_production where Department = '" + dep2_box.Text + "' and  (date between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "') and  branch_n='" + Login.branch + "'  ", conn);
                commander.ExecuteNonQuery();
                MySqlDataReader reader = commander.ExecuteReader();
                while (reader.Read())
                {
                    rddd = dtdd.NewRow();
                    rddd["product_dep"] = dep2_box.Text;
                    rddd["product"] = reader[1].ToString();
                    rddd["batch_no"] = reader[2].ToString();
                    rddd["date"] = reader[3].ToString();
                    rddd["time"] = reader[4].ToString();
                    rddd["status"] = reader[5].ToString();
                    rddd["branch"] = reader[6].ToString();
                    rddd["to_date"] = dateTimePicker2.Value.ToString("dd-MM-yyyy");
                    rddd["from_date"] = dateTimePicker1.Value.ToString("dd-MM-yyyy");


                    dtdd.Rows.Add(rddd);

                }
                reader.Dispose();
                commander.Dispose();
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
            }


            product_dep_report ar = new product_dep_report();
            ar.SetDataSource(dtdd);
            report_view vv = new report_view();

            vv.crystalReportViewer1.ReportSource = ar;
            vv.crystalReportViewer1.Refresh();
            vv.Show();


        }

        private void pro_report()
        {
            DataSet ddd = new DataSet();
            DataTable dtdd = ddd.Tables.Add("Production");

            //dtdd.Columns.Add("product_dep", Type.GetType("System.String"));
            dtdd.Columns.Add("product", Type.GetType("System.String"));
            dtdd.Columns.Add("item", Type.GetType("System.String"));
            dtdd.Columns.Add("batch_no", Type.GetType("System.String"));
            dtdd.Columns.Add("qty", Type.GetType("System.String"));
            dtdd.Columns.Add("date", Type.GetType("System.String"));
            dtdd.Columns.Add("time", Type.GetType("System.String"));
            //dtdd.Columns.Add("status", Type.GetType("System.String"));
            dtdd.Columns.Add("to_date", Type.GetType("System.String"));
            dtdd.Columns.Add("from_date", Type.GetType("System.String"));
            dtdd.Columns.Add("branch", Type.GetType("System.String"));

            DataRow rddd;
            try
            {
                connection_check();
                MySqlCommand commander = new MySqlCommand("select  Product, Batch_no , Date,Time ,Itemname,item_qty,branch_n from fsm_production where Product = '" + pro_box.Text + "' and  (date between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "') and branch_n = '" + Login.branch + "' ", conn);
                commander.ExecuteNonQuery();
                MySqlDataReader reader = commander.ExecuteReader();
                while (reader.Read())
                {
                    rddd = dtdd.NewRow();
                    // rddd["product_dep"] = dep2_box.Text;
                    rddd["product"] = pro_box.Text;
                    rddd["batch_no"] = reader[1].ToString();
                    rddd["date"] = reader[2].ToString();
                    rddd["time"] = reader[3].ToString();
                    //rddd["status"] = reader[4].ToString();
                    rddd["item"] = reader[4].ToString();
                    rddd["qty"] = reader[5].ToString();
                    rddd["branch"] = reader[6].ToString();
                    rddd["to_date"] = dateTimePicker2.Value.ToString("dd-MM-yyyy");
                    rddd["from_date"] = dateTimePicker1.Value.ToString("dd-MM-yyyy");


                    dtdd.Rows.Add(rddd);

                }
                reader.Dispose();
                commander.Dispose();

                product_report ar = new product_report();
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


        private void pro_2_report()
        {
            DataSet ddd = new DataSet();
            DataTable dtdd = ddd.Tables.Add("Production");

            //dtdd.Columns.Add("product_dep", Type.GetType("System.String"));
            dtdd.Columns.Add("item", Type.GetType("System.String"));
            dtdd.Columns.Add("qty1", Type.GetType("System.String"));
            dtdd.Columns.Add("qty2", Type.GetType("System.String"));
            dtdd.Columns.Add("qty3", Type.GetType("System.String"));
            dtdd.Columns.Add("qty4", Type.GetType("System.String"));
            dtdd.Columns.Add("qty5", Type.GetType("System.String"));
            dtdd.Columns.Add("qty6", Type.GetType("System.String"));
            dtdd.Columns.Add("qty7", Type.GetType("System.String"));
            dtdd.Columns.Add("qty8", Type.GetType("System.String"));
            dtdd.Columns.Add("qty9", Type.GetType("System.String"));
            dtdd.Columns.Add("qty10", Type.GetType("System.String"));
            dtdd.Columns.Add("qty11", Type.GetType("System.String"));
            dtdd.Columns.Add("qty12", Type.GetType("System.String"));
            dtdd.Columns.Add("qty13", Type.GetType("System.String"));
            dtdd.Columns.Add("qty14", Type.GetType("System.String"));
            dtdd.Columns.Add("qty15", Type.GetType("System.String"));
            dtdd.Columns.Add("qty16", Type.GetType("System.String"));
            dtdd.Columns.Add("qty17", Type.GetType("System.String"));
            dtdd.Columns.Add("qty18", Type.GetType("System.String"));
            dtdd.Columns.Add("qty19", Type.GetType("System.String"));
            dtdd.Columns.Add("qty20", Type.GetType("System.String"));
            dtdd.Columns.Add("qty21", Type.GetType("System.String"));
            dtdd.Columns.Add("qty22", Type.GetType("System.String"));
            dtdd.Columns.Add("to_date", Type.GetType("System.String"));
            dtdd.Columns.Add("from_date", Type.GetType("System.String"));
            DataRow rddd;
            try
            {
                connection_check();
            }
            catch (Exception ex)
            {


            }
            MySqlCommand commander = new MySqlCommand("select  (item_n),(Barfi),(Bengali),(Cold_Store),(Dariy_Farm_Salam),(Desi_Gee_Packets),(Gajar_Halwa),(Gulaab_Jaman),(Halwa),(Ice_Cream),(Kachori),(Kitchen),(Ladoo),(Nimko),(Nimko_Retal),(Paneer),(Patisa),(Personal_Use),(Pizza),(Samosa),(Talai),(Universal_Department),(vegetables) from fsm_pd", conn);
            commander.ExecuteNonQuery();
            MySqlDataReader reader = commander.ExecuteReader();
            while (reader.Read())
            {
                rddd = dtdd.NewRow();
                // rddd["product_dep"] = dep2_box.Text;
                //rddd["product"] = pro_box.Text;
                string aa = "";
                rddd["item"] = reader[0].ToString();
                aa = "";
                aa = reader[1].ToString();
                if (aa == "")
                {
                    aa = "-";
                }
                rddd["qty1"] = aa;
                aa = "";
                aa = reader[2].ToString();
                if (aa == "")
                {
                    aa = "-";
                }
                rddd["qty2"] = aa;
                aa = "";
                aa = reader[3].ToString();
                if (aa == "")
                {
                    aa = "-";
                }
                rddd["qty3"] = aa;
                aa = "";
                aa = reader[4].ToString();
                if (aa == "")
                {
                    aa = "-";
                }
                rddd["qty4"] = aa;
                aa = "";
                aa = reader[5].ToString();
                if (aa == "")
                {
                    aa = "-";
                }
                rddd["qty5"] = aa;
                aa = "";
                aa = reader[6].ToString();
                if (aa == "")
                {
                    aa = "-";
                }
                rddd["qty6"] = aa;
                aa = "";
                aa = reader[7].ToString();
                if (aa == "")
                {
                    aa = "-";
                }
                rddd["qty7"] = aa;
                aa = "";
                aa = reader[8].ToString();
                if (aa == "")
                {
                    aa = "-";
                }
                rddd["qty8"] = aa;
                aa = "";
                aa = reader[9].ToString();
                if (aa == "")
                {
                    aa = "-";
                }
                rddd["qty9"] = aa;
                aa = "";
                aa = reader[10].ToString();
                if (aa == "")
                {
                    aa = "-";
                }
                rddd["qty10"] = aa;
                aa = "";
                aa = reader[11].ToString();
                if (aa == "")
                {
                    aa = "-";
                }
                rddd["qty11"] = aa;
                aa = "";
                aa = reader[12].ToString();
                if (aa == "")
                {
                    aa = "-";
                }
                rddd["qty12"] = aa;
                aa = "";
                aa = reader[13].ToString();
                if (aa == "")
                {
                    aa = "-";
                }
                rddd["qty13"] = aa;
                aa = "";
                aa = reader[14].ToString();
                if (aa == "")
                {
                    aa = "-";
                }
                rddd["qty14"] = aa;
                aa = "";
                aa = reader[15].ToString();
                if (aa == "")
                {
                    aa = "-";
                }
                rddd["qty15"] = aa;
                aa = "";
                aa = reader[16].ToString();
                if (aa == "")
                {
                    aa = "-";
                }
                rddd["qty16"] = aa;
                aa = "";
                aa = reader[17].ToString();
                if (aa == "")
                {
                    aa = "-";
                }
                rddd["qty17"] = aa;
                aa = "";
                aa = reader[18].ToString();
                if (aa == "")
                {
                    aa = "-";
                }
                rddd["qty18"] = aa;
                aa = "";
                aa = reader[19].ToString();
                if (aa == "")
                {
                    aa = "-";
                }
                rddd["qty19"] = aa;
                aa = "";
                aa = reader[20].ToString();
                if (aa == "")
                {
                    aa = "-";
                }
                rddd["qty20"] = aa;
                aa = "";
                aa = reader[21].ToString();
                if (aa == "")
                {
                    aa = "-";
                }
                rddd["qty21"] = aa;
                aa = "";
                aa = reader[22].ToString();
                if (aa == "")
                {
                    aa = "-";
                }
                rddd["qty22"] = aa;
                //aa = rea6der[1].ToString();
                //if (aa == "")
                //{
                //    aa = 0;
                //}
                //rddd["status"] = reader[4].ToString();
                // rddd["item"] = reader[4].ToString();
                //rddd["qty"] = reader[5].ToString();
                rddd["to_date"] = dateTimePicker2.Value.ToString("dd-MM-yyyy");
                rddd["from_date"] = dateTimePicker1.Value.ToString("dd-MM-yyyy");


                dtdd.Rows.Add(rddd);

            }
            reader.Dispose();
            commander.Dispose();

            pro_report ar = new pro_report();
            ar.SetDataSource(dtdd);
            report_view vv = new report_view();

            vv.crystalReportViewer1.ReportSource = ar;
            vv.crystalReportViewer1.Refresh();
            vv.Show();


        }

        private void getproduct()
        {
            pro_box.Items.Clear();
            ser_pro.Items.Clear();
            try
            {
                connection_check();
                MySqlCommand com_name = new MySqlCommand("select DISTINCT(cat_name) from fsm_pro_pricing order by cat_name desc ", conn);
                com_name.ExecuteNonQuery();
                MySqlDataReader rd = com_name.ExecuteReader();
                while (rd.Read())
                {
                    pro_box.Items.Add(rd[0].ToString());
                    ser_pro.Items.Add(rd[0].ToString());
                }
                rd.Dispose();
            }
            catch (Exception ex)
            {


            }

        }

        private void dep_pro_btn_Click(object sender, EventArgs e)
        {
            dep_pro_report();
        }

        private void pro_btn_Click(object sender, EventArgs e)
        {
            pro_report();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection_check();

                MySqlCommand itd12 = new MySqlCommand("delete from fsm_pd ;", conn);
                itd12.ExecuteNonQuery();
                itd12.Dispose();
                string[] dep_n = new string[100];
                string[] item = new string[100];
                string[] aqty = new string[100];
                int k = 0;
                connection_check();
                MySqlCommand axx = new MySqlCommand("select DISTINCT(Itemname) from fsm_production ", conn);
                axx.ExecuteNonQuery();
                MySqlDataReader dtr = axx.ExecuteReader();
                while (dtr.Read())
                {
                    item[k] = dtr[0].ToString();
                    k++;
                }
                axx.Dispose();
                dtr.Dispose();

                k = 0;
                connection_check();
                MySqlCommand axx12 = new MySqlCommand("select DISTINCT(Department) from fsm_production ", conn);
                axx12.ExecuteNonQuery();
                MySqlDataReader dtr12 = axx12.ExecuteReader();
                while (dtr12.Read())
                {
                    dep_n[k] = dtr12[0].ToString();
                    k++;
                }
                axx12.Dispose();
                dtr12.Dispose();

                k = 0;
                while (item[k] != null)
                {
                    connection_check();
                    MySqlCommand itd = new MySqlCommand("insert into fsm_pd (item_n,branch_n) Values('" + item[k] + "','" + Login.branch + "')", conn);
                    itd.ExecuteNonQuery();
                    itd.Dispose();
                    k++;
                }

                k = 0;
                while (dep_n[k] != null)
                {
                    int j = 0;
                    while (item[j] != null)
                    {
                        connection_check();
                        MySqlCommand axx121 = new MySqlCommand("select sum(item_qty) from fsm_production where((Department='" + dep_n[k] + "') and (Itemname='" + item[j] + "')and(date between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'))", conn);
                        axx121.ExecuteNonQuery();
                        MySqlDataReader dtr121 = axx121.ExecuteReader();
                        while (dtr121.Read())
                        {
                            aqty[j] = dtr121[0].ToString();
                            j++;
                        }
                        axx121.Dispose();
                        dtr121.Dispose();
                    }
                    j = 0;
                    while (item[j] != null)
                    {
                        connection_check();
                        MySqlCommand itd1 = new MySqlCommand("update fsm_pd set " + dep_n[k] + "='" + aqty[j] + "' where item_n='" + item[j] + "'", conn);
                        itd1.ExecuteNonQuery();
                        itd1.Dispose();
                        j++;

                    }
                    k++;


                }
                k = 0;
            }
            catch (Exception ex)
            {


            }


            //while (dep_n[k] !=null)
            //{
            //    int y = 0;
            //    MySqlCommand axxx = new MySqlCommand("select Itemname,item_qty  from fsm_production ", conn);
            //    axxx.ExecuteNonQuery();
            //    MySqlDataReader dtrx = axxx.ExecuteReader();
            //    while (dtrx.Read())
            //    {
            //        item[y] = dtrx[0].ToString();
            //        aqty[y] = dtrx[1].ToString();
            //        y++;
            //    }
            //    axxx.Dispose();
            //    dtrx.Dispose();
            //    k++;

            //}


            pro_2_report();
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

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            { connection_check(); }
        }


        //private void PlusButtonClick()
        //{

        //    int newIndex = 0;
        //    for (int x = 0; x < listView4.Items.Count; x++)
        //    {
        //        ListViewItem listitem = new ListViewItem();
        //        if (listitem.Selected)
        //        {
        //            listitem.Selected = false;
        //            newIndex = x++;
        //            break;
        //        }
        //    }

        //    this.listView1.Items[newIndex].Selected = true;
        //}


        private void listView4_Click(object sender, EventArgs e)
        {
            connection_check();

            try
            {
                //PlusButtonClick();
                qty_made.Enabled = true;
                qty_made.Focus();
                bat_text.Text = listView4.SelectedItems[0].SubItems[0].Text;
                depart_tex.Text = listView4.SelectedItems[0].SubItems[1].Text;
                prod_tex.Text = listView4.SelectedItems[0].SubItems[2].Text;
                date_tex.Text = listView4.SelectedItems[0].SubItems[4].Text;
                time_tex.Text = listView4.SelectedItems[0].SubItems[5].Text;

            }
            catch (Exception ex)
            {


            }

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            string sumqty2 = "";
            string sumqty = "";
            Double qty_t = 0;
            try
            {
                connection_check();
                MySqlCommand itd = new MySqlCommand("Update fsm_production set Status='" + status_tex.Text + "'  where  Batch_no ='" + bat_text.Text + "' and branch_n = '" + Login.branch + "' ", conn);
                itd.ExecuteNonQuery();
                itd.Dispose();
            }
            catch (Exception ex)
            {


            }

            connection_check();
            try
            {
                MySqlCommand sel_deb2 = new MySqlCommand("select barcode from fsm_pro_pricing where cat_name='" + prod_tex.Text + "' ", conn);
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
                MessageBox.Show(ex.Message);
                connection_check();

            }
            connection_check();
            try
            {
                MySqlCommand sel_deb = new MySqlCommand("select sum(product_cost) from fsm_production where Batch_no ='" + bat_text.Text + "' and branch_n='" + Login.branch + "'", conn);
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
                MessageBox.Show(ex.Message);
                connection_check();

            }
            try
            {
                MySqlCommand itd_1 = new MySqlCommand("insert into fsm_production_status (barcode,Batch_no ,branch_n,Department ,Product,quantity,Pc_name,Domain ,Date,Time ,Status,login_user,product_cost,total_cost) Values('" + sumqty2 + "','" + bat_text.Text + "','" + Login.branch + "','" + depart_tex.Text + "','" + prod_tex.Text + "','" + qty_made.Text + "','" + hostName + "','" + myIP + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss:tt") + "','" + status_tex.Text + "','" + Login.user_n + "','" + sumqty + "','" + Convert.ToString(Convert.ToDouble(sumqty) * Convert.ToDouble(qty_made.Text)) + "')", conn);
                itd_1.ExecuteNonQuery();
                itd_1.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            if (sumqty == null || sumqty == "")
            {
            try
            {
                MySqlCommand itd_2 = new MySqlCommand("insert into fsm_voucher_log (barcode,branch_n,Department,raw_name,total_kg_p,rema_qty,pc_name,domain,invoice_date,invoice_time,Status,login_user,cost,total_cost) Values('" + sumqty2 + "','" + Login.branch + "','" + depart_tex.Text + "','" + prod_tex.Text + "','" + qty_made.Text + "','" + qty_made.Text + "','" + hostName + "','" + myIP + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss:tt") + "','Finished Goods','" + Login.user_n + "','" + sumqty + "','" + Convert.ToString(Convert.ToDouble(sumqty) * Convert.ToDouble(qty_made.Text)) + "')", conn);
                itd_2.ExecuteNonQuery();
                itd_2.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            }
            else if (sumqty != "" || sumqty != null)
            {
                try
                {
                    connection_check();
                    qty_t = Convert.ToDouble(qty_made.Text) + Convert.ToDouble(sumqty);
                    MySqlCommand in_upd = new MySqlCommand("Update fsm_mainstore set  qty='" + Convert.ToString(qty_t) + "' where item='" + prod_tex.Text + "' and branch_n ='" + Login.branch + "'", conn);
                    in_upd.ExecuteNonQuery();
                    in_upd.Dispose();

                }
                catch (Exception ex)
                {
                }
            }

            Bind_Grid7();
            Bind_Grid19();
            qty_made.Text = "";
            qty_made.Enabled = false;
            bat_text.Text = "";
            depart_tex.Text = "";
            prod_tex.Text = "";
            date_tex.Text = "";
            time_tex.Text = "";
            fsm_mainlist();
            fsm_pro_listviewer();
        }


        private void main_store_report()
        {
            DataSet ddd = new DataSet();
            DataTable dtdd = ddd.Tables.Add("Production");

            dtdd.Columns.Add("product_dep", Type.GetType("System.String"));
            dtdd.Columns.Add("product", Type.GetType("System.String"));
            //dtdd.Columns.Add("item", Type.GetType("System.String"));
            dtdd.Columns.Add("batch_no", Type.GetType("System.String"));
            dtdd.Columns.Add("qty", Type.GetType("System.String"));
            dtdd.Columns.Add("date", Type.GetType("System.String"));
            dtdd.Columns.Add("time", Type.GetType("System.String"));
            dtdd.Columns.Add("status", Type.GetType("System.String"));
            dtdd.Columns.Add("branch", Type.GetType("System.String"));


            DataRow rddd;
            try
            {
                connection_check();
                MySqlCommand commander = new MySqlCommand("select Product,Batch_no,Date,Time ,Department,quantity,Status from fsm_production_status where branch_n = '" + Login.branch + "' ", conn);
                commander.ExecuteNonQuery();
                MySqlDataReader reader = commander.ExecuteReader();
                while (reader.Read())
                {
                    rddd = dtdd.NewRow();

                    rddd["product"] = reader[0].ToString();
                    rddd["batch_no"] = reader[1].ToString();
                    rddd["date"] = reader[2].ToString();
                    string aa = reader[3].ToString();
                    rddd["time"] = aa;
                    rddd["product_dep"] = reader[4].ToString();
                    rddd["qty"] = reader[5].ToString();
                    rddd["status"] = reader[6].ToString();
                    rddd["branch"] = Login.branch;

                    //rddd["to_date"] = dateTimePicker4.Value.ToString("dd-MM-yyyy");
                    //rddd["from_date"] = dateTimePicker3.Value.ToString("dd-MM-yyyy");


                    dtdd.Rows.Add(rddd);

                }
                reader.Dispose();
                commander.Dispose();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);

            }


            main_store_report ar = new main_store_report();
            ar.SetDataSource(dtdd);
            report_view vv = new report_view();

            vv.crystalReportViewer1.ReportSource = ar;
            vv.crystalReportViewer1.Refresh();
            vv.Show();


        }
        private void button8_Click(object sender, EventArgs e)
        {
            main_store_report();
        }





        private void button11_Click(object sender, EventArgs e)
        {
            report_0();
            //DataSet ddd = new DataSet();
            //DataTable dtdd = ddd.Tables.Add("voucher");

            //dtdd.Columns.Add("supplier", Type.GetType("System.String"));
            //dtdd.Columns.Add("item", Type.GetType("System.String"));
            //dtdd.Columns.Add("weight", Type.GetType("System.String"));
            //dtdd.Columns.Add("bag", Type.GetType("System.String"));
            //dtdd.Columns.Add("total", Type.GetType("System.String"));
            //dtdd.Columns.Add("voucher_id", Type.GetType("System.String"));
            ////dt.Columns.Add("reicever", Type.GetType("System.String"));
            //dtdd.Columns.Add("date", Type.GetType("System.String"));
            //dtdd.Columns.Add("time", Type.GetType("System.String"));
            //dtdd.Columns.Add("invoice", Type.GetType("System.String"));
            ////dtdd.Columns.Add("companay_address", Type.GetType("System.String"));
            ////dtdd.Columns.Add("companay_name", Type.GetType("System.String"));
            ////dtdd.Columns.Add("com_number", Type.GetType("System.String"));
            //dtdd.Columns.Add("branch", Type.GetType("System.String"));


            //DataRow rddd;
            //try
            //{
            //    connection_check();
            //    MySqlCommand commander = new MySqlCommand("select supplier , raw_name , weight, bag , total_kg_p,invoice_number ,invoice_date,invoice_time  from fsm_edit_voucher_log where invoice_number = '" + id_code_text.Text + "';", conn);
            //    commander.ExecuteNonQuery();
            //    for (int l = 0; l < dataGridView11.RowCount; l++)
            //    {
            //        rddd = dtdd.NewRow();
            //        rddd["supplier"] = dataGridView11.Rows[l].Cells["Supplier"].Value.ToString();
            //        rddd["item"] = dataGridView11.Rows[l].Cells["raw_n2"].Value.ToString();
            //        rddd["weight"] = dataGridView11.Rows[l].Cells["weight"].Value.ToString();
            //        rddd["bag"] = dataGridView11.Rows[l].Cells["bag2"].Value.ToString();
            //        rddd["total"] = dataGridView11.Rows[l].Cells["Total_kg2"].Value.ToString();
            //        rddd["date"] = DateTime.Today.ToString("dd-MM-yyyy");
            //        rddd["time"] = DateTime.Now.ToString("hh:mm:ss");
            //        rddd["voucher_id"] = id_code_text.Text;
            //        rddd["invoice"] = id_code_text.Text;
            //        //rddd["companay_address"] = comapany_ad.Text;
            //        //rddd["companay_name"] = company_n.Text;
            //        //rddd["com_number"] = company_num.Text;
            //        rddd["branch"] = Login.branch;
            //        dtdd.Rows.Add(rddd);
            //    }

            //    commander.Dispose();

            //    report_vaucher ar = new report_vaucher();
            //    ar.SetDataSource(dtdd);
            //    report_view vv = new report_view();

            //    vv.crystalReportViewer1.ReportSource = ar;
            //    vv.crystalReportViewer1.Refresh();
            //    vv.Show();

            //}
            //catch (Exception ex)
            //{


            //}


        }

        private void button10_Click(object sender, EventArgs e)
        {
            uppoo.Visible = true;
            try
            {
                connection_check();
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
            }


            if (id_code_text.Text == "")
            {
                if (id_code_text.Text == "")
                {
                    string myStringVariable1 = string.Empty;
                    MessageBox.Show("Invoice number is required");
                    id_code_text.Focus();
                    return;
                }

            }
            else
            {
                if (checkBox4.Checked == true)
                {

                    DialogResult dlg = MessageBox.Show("Are you sure you want to Update these Products OF Main Store? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlg == DialogResult.Yes)
                    {
                        update_table_2();
                    }

                }
                else if (checkBox4.Checked == false)
                {
                    DialogResult dlg1 = MessageBox.Show("Are you sure you want to Update these Item OF Production?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlg1 == DialogResult.Yes)
                    {
                        update_table();
                    }

                }

            }
            label2.Text = "0";
            label4.Text = "0";
            raw_ibox.Text = "";
            invoice_id.Text = "";
            company_box.Text = "";
            inv_num.Text = "";
            Bind_Grid2();
            Bind_Grid2_2();
            report_0();
            Bind_Grid27();
            Bind_Grid23();
            uppoo.Visible = false;
        }



        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView11_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double t_q = 0;
            double t_p = 0;
            string i_raw = "";
            int rowindex = e.RowIndex;
            int col = e.ColumnIndex;



            if (dataGridView11.Rows[rowindex].Cells["raw_n2"].Value == null)
            {
                dataGridView11.Rows[rowindex].Cells["raw_n2"].Value = raw_ibox.Text;
            }
            if (dataGridView11.Rows[rowindex].Cells["Supplier"].Value == null)
            {
                dataGridView11.Rows[rowindex].Cells["Supplier"].Value = company_box.Text;
            }

            if (col == 3)
            {
                try
                {
                    quanty = dataGridView11.Rows[rowindex].Cells["weight"].Value.ToString();
                }
                catch (Exception ex)
                {

                    quanty = "0";
                }
                try
                {

                    bags = dataGridView11.Rows[rowindex].Cells["bag2"].Value.ToString();
                }
                catch (Exception ex)
                {

                    bags = "1";
                    dataGridView11.Rows[rowindex].Cells["bag2"].Value = "1";
                }
                try
                {
                    dataGridView11.Rows[rowindex].Cells["Total_kg2"].Value = Convert.ToString(Convert.ToDouble(quanty) * Convert.ToDouble(bags));
                }
                catch (Exception ex)
                {


                }

                {

                    try
                    {
                        cocost = dataGridView11.Rows[rowindex].Cells["uct"].Value.ToString();
                        if (cocost == "")
                        {
                            cocost = "1";
                            dataGridView11.Rows[rowindex].Cells["uct"].Value = "1";
                        }
                    }
                    catch (Exception ex)
                    {
                        cocost = "1";
                        dataGridView11.Rows[rowindex].Cells["uct"].Value = "1";

                    }
                    try
                    {
                        quanty = dataGridView11.Rows[rowindex].Cells["weight"].Value.ToString();
                    }
                    catch (Exception ex)
                    {

                        quanty = "0";
                    }
                    try
                    {
                        dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value = Convert.ToString(Convert.ToDouble(quanty) * Convert.ToDouble(cocost));
                        ctncost = dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value.ToString();
                        if (ctncost == "")
                        {
                            ctncost = "1";
                            dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value = "1";
                        }
                    }
                    catch (Exception ex)
                    {
                        ctncost = "1";
                        dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value = "1";

                    }
                }
                try
                {
                    texrate = dataGridView11.Rows[rowindex].Cells["tex1"].Value.ToString();
                }
                catch (Exception ex)
                {
                    texrate = "0";
                    dataGridView11.Rows[rowindex].Cells["tex1"].Value = "0";

                }
                try
                {
                    tex_amount = dataGridView11.Rows[rowindex].Cells["tex_a1"].Value.ToString();
                    if (tex_amount == "")
                    {
                        tex_amount = "0";
                        dataGridView11.Rows[rowindex].Cells["tex_a1"].Value = "0";
                    }
                }
                catch (Exception ex)
                {
                    tex_amount = "0";
                    dataGridView1.Rows[rowindex].Cells["tex_a1"].Value = "0";

                }
                try
                {
                    tqty = dataGridView11.Rows[rowindex].Cells["Total_kg2"].Value.ToString();
                }
                catch (Exception ex)
                {


                }
                try
                {
                    disrate = dataGridView11.Rows[rowindex].Cells["Disco"].Value.ToString();
                }
                catch (Exception ex)
                {
                    disrate = "0";
                    dataGridView11.Rows[rowindex].Cells["Disco"].Value = "0";

                }
                try
                {
                    dataGridView11.Rows[rowindex].Cells["Total_coo"].Value = Convert.ToString(Convert.ToDouble(cocost) * Convert.ToDouble(tqty));
                }
                catch (Exception ex)
                {


                }


            }
            if (col == 4)
            {
                try
                {
                    quanty = dataGridView11.Rows[rowindex].Cells["weight"].Value.ToString();
                }
                catch (Exception ex)
                {

                    quanty = "0";
                }
                try
                {

                    bags = dataGridView11.Rows[rowindex].Cells["bag2"].Value.ToString();
                }
                catch (Exception ex)
                {

                    bags = "1";
                    dataGridView11.Rows[rowindex].Cells["bag2"].Value = "1";
                }
                try
                {
                    unitcost = dataGridView11.Rows[rowindex].Cells["uni_1"].Value.ToString();

                }
                catch (Exception ex)
                {
                    unitcost = "1";
                    dataGridView11.Rows[rowindex].Cells["uni_1"].Value = "1";

                }
                try
                {
                    cocost = dataGridView11.Rows[rowindex].Cells["uct"].Value.ToString();

                }
                catch (Exception ex)
                {
                    cocost = "1";
                    dataGridView11.Rows[rowindex].Cells["uct"].Value = "1";

                }
                try
                {
                    dataGridView11.Rows[rowindex].Cells["Total_kg2"].Value = Convert.ToString(Convert.ToDouble(quanty) * Convert.ToDouble(bags));
                }
                catch (Exception ex)
                {


                }

                try
                {
                    tqty = dataGridView11.Rows[rowindex].Cells["Total_kg2"].Value.ToString();
                }
                catch (Exception ex)
                {


                }
                try
                {
                    dataGridView11.Rows[rowindex].Cells["Total_coo"].Value = Convert.ToString(Convert.ToDouble(cocost) * Convert.ToDouble(tqty));
                }
                catch (Exception ex)
                {


                }
                try
                {
                    unitcost = dataGridView11.Rows[rowindex].Cells["uni_1"].Value.ToString();
                    if (unitcost == "")
                    {
                        unitcost = "1";
                        dataGridView11.Rows[rowindex].Cells["uni_1"].Value = "1";
                    }

                }
                catch (Exception exc)
                {
                    unitcost = "1";
                    dataGridView11.Rows[rowindex].Cells["uni_1"].Value = "1";

                }
                try
                {
                    cocost = dataGridView11.Rows[rowindex].Cells["uct"].Value.ToString();
                    if (cocost == "")
                    {
                        cocost = "1";
                        dataGridView11.Rows[rowindex].Cells["uct"].Value = "1";
                    }
                }
                catch (Exception exc)
                {
                    cocost = "1";
                    dataGridView11.Rows[rowindex].Cells["uct"].Value = "1";

                }
                try
                {
                    quanty = dataGridView11.Rows[rowindex].Cells["weight"].Value.ToString();
                }
                catch (Exception exc)
                {

                    quanty = "0";
                }
                try
                {
                    dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value = Convert.ToString(Convert.ToDouble(quanty) * Convert.ToDouble(cocost));
                    ctncost = dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value.ToString();
                    if (ctncost == "")
                    {
                        ctncost = "1";
                        dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value = "1";
                    }
                }
                catch (Exception exc)
                {
                    ctncost = "1";
                    dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value = "1";

                }
                try
                {
                    totalcost = dataGridView11.Rows[rowindex].Cells["Total_coo"].Value.ToString();
                }
                catch (Exception exc)
                { }
                try
                {
                    texrate = dataGridView11.Rows[rowindex].Cells["tex1"].Value.ToString();
                    if (texrate == "")
                    {
                        texrate = "0";
                        dataGridView11.Rows[rowindex].Cells["tex1"].Value = "0";
                    }
                }
                catch (Exception exc)
                {
                    texrate = "0";
                    dataGridView11.Rows[rowindex].Cells["tex1"].Value = "0";
                }
                try
                {
                    dataGridView11.Rows[rowindex].Cells["tex_a1"].Value = Convert.ToString(Convert.ToDouble(totalcost) * (Convert.ToDouble(texrate) / 100));

                }
                catch (Exception exc)
                {


                }
            }
            if (col == 6)
            {
                try
                {
                    unitcost = dataGridView11.Rows[rowindex].Cells["uni_1"].Value.ToString();

                }
                catch (Exception ex)
                {
                    unitcost = "1";
                    dataGridView11.Rows[rowindex].Cells["uni_1"].Value = "1";

                }
                try
                {
                    cocost = dataGridView11.Rows[rowindex].Cells["uct"].Value.ToString();

                }
                catch (Exception ex)
                {
                    cocost = "1";
                    dataGridView11.Rows[rowindex].Cells["uct"].Value = "1";

                }
                try
                {
                    texrate = dataGridView11.Rows[rowindex].Cells["tex1"].Value.ToString();
                }
                catch (Exception ex)
                {
                    texrate = "0";
                    dataGridView11.Rows[rowindex].Cells["tex1"].Value = "0";

                }
                string per = (Convert.ToDouble(unitcost) * Convert.ToDouble(texrate) / 100).ToString();
                try
                {
                    tqty = dataGridView11.Rows[rowindex].Cells["Total_kg2"].Value.ToString();
                }
                catch (Exception ex)
                {


                }
                dataGridView11.Rows[rowindex].Cells["uct"].Value = (Convert.ToDouble(per) + Convert.ToDouble(unitcost)).ToString();


                try
                {
                    cocost = dataGridView11.Rows[rowindex].Cells["uct"].Value.ToString();
                }
                catch (Exception ex)
                {


                }
                try
                {
                    dataGridView11.Rows[rowindex].Cells["Total_coo"].Value = Convert.ToString(Convert.ToDouble(cocost) * Convert.ToDouble(tqty));
                }
                catch (Exception ex)
                {


                }
                {
                    try
                    {
                        unitcost = dataGridView11.Rows[rowindex].Cells["uni_1"].Value.ToString();
                        if (unitcost == "")
                        {
                            unitcost = "1";
                            dataGridView11.Rows[rowindex].Cells["uni_1"].Value = "1";
                        }

                    }
                    catch (Exception exc)
                    {
                        unitcost = "1";
                        dataGridView11.Rows[rowindex].Cells["uni_1"].Value = "1";

                    }
                    try
                    {
                        cocost = dataGridView11.Rows[rowindex].Cells["uct"].Value.ToString();
                        if (cocost == "")
                        {
                            cocost = "1";
                            dataGridView11.Rows[rowindex].Cells["uct"].Value = "1";
                        }
                    }
                    catch (Exception exc)
                    {
                        cocost = "1";
                        dataGridView11.Rows[rowindex].Cells["uct"].Value = "1";

                    }
                    try
                    {
                        quanty = dataGridView11.Rows[rowindex].Cells["weight"].Value.ToString();
                    }
                    catch (Exception exc)
                    {

                        quanty = "0";
                    }
                    try
                    {
                        dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value = Convert.ToString(Convert.ToDouble(quanty) * Convert.ToDouble(cocost));
                        ctncost = dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value.ToString();
                        if (ctncost == "")
                        {
                            ctncost = "1";
                            dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value = "1";
                        }
                    }
                    catch (Exception exc)
                    {
                        ctncost = "1";
                        dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value = "1";

                    }




                    try
                    {
                        totalcost = dataGridView11.Rows[rowindex].Cells["Total_coo"].Value.ToString();
                    }
                    catch (Exception ex)
                    { }
                    try
                    {
                        texrate = dataGridView11.Rows[rowindex].Cells["tex1"].Value.ToString();
                        if (texrate == "")
                        {
                            texrate = "0";
                            dataGridView11.Rows[rowindex].Cells["tex1"].Value = "0";
                        }
                    }
                    catch (Exception ex)
                    {
                        texrate = "0";
                        dataGridView11.Rows[rowindex].Cells["tex1"].Value = "0";
                    }
                    try
                    {
                        dataGridView11.Rows[rowindex].Cells["tex_a1"].Value = Convert.ToString(Convert.ToDouble(totalcost) * (Convert.ToDouble(texrate) / 100));

                    }
                    catch (Exception ex)
                    {


                    }

                }
                dataGridView11.Rows[rowindex].Cells["Disco"].Value = "0";

            }
            if (col == 8)
            {
                try
                {
                    unitcost = dataGridView11.Rows[rowindex].Cells["uni_1"].Value.ToString();
                    if (unitcost == "")
                    {
                        unitcost = "1";
                        dataGridView11.Rows[rowindex].Cells["uni_1"].Value = "1";
                    }

                }
                catch (Exception exc)
                {
                    unitcost = "1";
                    dataGridView11.Rows[rowindex].Cells["uni_1"].Value = "1";

                }
                try
                {
                    cocost = dataGridView11.Rows[rowindex].Cells["uct"].Value.ToString();
                    if (cocost == "")
                    {
                        cocost = "1";
                        dataGridView11.Rows[rowindex].Cells["uct"].Value = "1";
                    }
                }
                catch (Exception exc)
                {
                    cocost = "1";
                    dataGridView11.Rows[rowindex].Cells["uct"].Value = "1";

                }
                try
                {
                    quanty = dataGridView11.Rows[rowindex].Cells["weight"].Value.ToString();
                }
                catch (Exception exc)
                {

                    quanty = "0";
                }
                try
                {
                    ctncost = dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value.ToString();
                    if (ctncost == "")
                    {
                        ctncost = "1";
                        dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value = "1";
                    }
                }
                catch (Exception exc)
                {

                    quanty = "0";
                }
                try
                {
                    dataGridView11.Rows[rowindex].Cells["uni_1"].Value = Convert.ToString(Convert.ToDouble(ctncost) / Convert.ToDouble(quanty));
                    unitcost = dataGridView11.Rows[rowindex].Cells["uni_1"].Value.ToString();
                    if (ctncost == "")
                    {
                        ctncost = "1";
                        dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value = "1";
                    }
                }
                catch (Exception exc)
                {
                    ctncost = "1";
                    dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value = "1";

                }



                try
                {
                    unitcost = dataGridView11.Rows[rowindex].Cells["uni_1"].Value.ToString();
                    if (unitcost == "")
                    {
                        unitcost = "1";
                        dataGridView11.Rows[rowindex].Cells["uni_1"].Value = "1";
                    }
                }
                catch (Exception ex)
                {
                    unitcost = "1";
                    dataGridView11.Rows[rowindex].Cells["uni_1"].Value = "1";

                }
                try
                {
                    cocost = dataGridView11.Rows[rowindex].Cells["uct"].Value.ToString();
                    if (cocost == "")
                    {
                        cocost = "1";
                        dataGridView11.Rows[rowindex].Cells["uct"].Value = "1";
                    }
                }
                catch (Exception ex)
                {
                    cocost = "1";
                    dataGridView11.Rows[rowindex].Cells["uct"].Value = "1";

                }
                try
                {
                    texrate = dataGridView11.Rows[rowindex].Cells["tex1"].Value.ToString();
                    if (texrate == "")
                    {
                        texrate = "0";
                        dataGridView11.Rows[rowindex].Cells["tex1"].Value = "0";
                    }
                }
                catch (Exception ex)
                {
                    texrate = "0";
                    dataGridView11.Rows[rowindex].Cells["tex1"].Value = "0";

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
                    tqty = dataGridView11.Rows[rowindex].Cells["Total_kg2"].Value.ToString();
                }
                catch (Exception ex)
                {


                }
                dataGridView11.Rows[rowindex].Cells["uct"].Value = (Convert.ToDouble(per) + Convert.ToDouble(unitcost)).ToString();


                try
                {
                    cocost = dataGridView11.Rows[rowindex].Cells["uct"].Value.ToString();
                    if (cocost == "")
                    {
                        cocost = "1";
                        dataGridView11.Rows[rowindex].Cells["uct"].Value = "1";
                    }
                }
                catch (Exception ex)
                {


                }
                try
                {
                    dataGridView11.Rows[rowindex].Cells["Total_coo"].Value = Convert.ToString(Convert.ToDouble(cocost) * Convert.ToDouble(tqty));
                }
                catch (Exception ex)
                {


                }


                try
                {
                    totalcost = dataGridView11.Rows[rowindex].Cells["Total_coo"].Value.ToString();
                }
                catch (Exception ex)
                { }
                try
                {
                    texrate = dataGridView11.Rows[rowindex].Cells["tex1"].Value.ToString();
                    if (texrate == "")
                    {
                        texrate = "0";
                        dataGridView11.Rows[rowindex].Cells["tex1"].Value = "0";
                    }
                }
                catch (Exception ex)
                {
                    texrate = "0";
                    dataGridView11.Rows[rowindex].Cells["tex1"].Value = "0";
                }
                try
                {
                    dataGridView11.Rows[rowindex].Cells["tex_a1"].Value = Convert.ToString(Convert.ToDouble(totalcost) * (Convert.ToDouble(texrate) / 100));

                }
                catch (Exception ex)
                {


                }
                dataGridView11.Rows[rowindex].Cells["Disco"].Value = "0";

            }

            if (col == 9)
            {
                try
                {
                    unitcost = dataGridView11.Rows[rowindex].Cells["uni_1"].Value.ToString();

                }
                catch (Exception ex)
                {
                    unitcost = "1";
                    dataGridView11.Rows[rowindex].Cells["uni_1"].Value = "1";

                }
                try
                {
                    texrate = dataGridView11.Rows[rowindex].Cells["tex1"].Value.ToString();
                }
                catch (Exception ex)
                {
                    texrate = "0";
                    dataGridView11.Rows[rowindex].Cells["tex1"].Value = "0";

                }
                if (Convert.ToDouble(dataGridView11.Rows[rowindex].Cells["tex1"].Value) > 100)
                {

                    dataGridView11.Rows[rowindex].Cells["tex1"].Value = "0";
                }
                try
                {
                    unitcost = dataGridView11.Rows[rowindex].Cells["uni_1"].Value.ToString();

                }
                catch (Exception ex)
                {
                    unitcost = "1";
                    dataGridView11.Rows[rowindex].Cells["uni_1"].Value = "1";

                }
                try
                {
                    texrate = dataGridView11.Rows[rowindex].Cells["tex1"].Value.ToString();
                }
                catch (Exception ex)
                {
                    texrate = "0";
                    dataGridView11.Rows[rowindex].Cells["tex1"].Value = "0";

                }
                string per = (Convert.ToDouble(unitcost) * Convert.ToDouble(texrate) / 100).ToString();
                try
                {
                    tqty = dataGridView11.Rows[rowindex].Cells["Total_kg2"].Value.ToString();
                }
                catch (Exception ex)
                {


                }
                dataGridView11.Rows[rowindex].Cells["uct"].Value = (Convert.ToDouble(per) + Convert.ToDouble(unitcost)).ToString();
                try
                {
                    cocost = dataGridView11.Rows[rowindex].Cells["uct"].Value.ToString();
                }
                catch (Exception ex)
                {


                }
                try
                {
                    dataGridView11.Rows[rowindex].Cells["Total_coo"].Value = Convert.ToString(Convert.ToDouble(cocost) * Convert.ToDouble(tqty));
                }
                catch (Exception ex)
                {


                }
                {
                    try
                    {
                        unitcost = dataGridView11.Rows[rowindex].Cells["uni_1"].Value.ToString();
                        if (unitcost == "")
                        {
                            unitcost = "1";
                            dataGridView11.Rows[rowindex].Cells["uni_1"].Value = "1";
                        }

                    }
                    catch (Exception exc)
                    {
                        unitcost = "1";
                        dataGridView11.Rows[rowindex].Cells["uni_1"].Value = "1";

                    }
                    try
                    {
                        cocost = dataGridView11.Rows[rowindex].Cells["uct"].Value.ToString();
                        if (cocost == "")
                        {
                            cocost = "1";
                            dataGridView11.Rows[rowindex].Cells["uct"].Value = "1";
                        }
                    }
                    catch (Exception exc)
                    {
                        cocost = "1";
                        dataGridView11.Rows[rowindex].Cells["uct"].Value = "1";

                    }
                    try
                    {
                        quanty = dataGridView11.Rows[rowindex].Cells["weight"].Value.ToString();
                    }
                    catch (Exception exc)
                    {

                        quanty = "0";
                    }
                    try
                    {
                        dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value = Convert.ToString(Convert.ToDouble(quanty) * Convert.ToDouble(cocost));
                        ctncost = dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value.ToString();
                        if (ctncost == "")
                        {
                            ctncost = "1";
                            dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value = "1";
                        }
                    }
                    catch (Exception exc)
                    {
                        ctncost = "1";
                        dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value = "1";

                    }

                    try
                    {
                        totalcost = dataGridView11.Rows[rowindex].Cells["Total_coo"].Value.ToString();
                    }
                    catch (Exception ex)
                    { }
                    try
                    {
                        texrate = dataGridView11.Rows[rowindex].Cells["tex1"].Value.ToString();
                        if (texrate == "")
                        {
                            texrate = "0";
                            dataGridView11.Rows[rowindex].Cells["tex1"].Value = "0";
                        }
                    }
                    catch (Exception ex)
                    {
                        texrate = "0";
                        dataGridView11.Rows[rowindex].Cells["tex1"].Value = "0";
                    }
                    try
                    {
                        dataGridView11.Rows[rowindex].Cells["tex_a1"].Value = Convert.ToString(Convert.ToDouble(totalcost) * (Convert.ToDouble(texrate) / 100));

                    }
                    catch (Exception ex)
                    {


                    }

                }

            }

            if (col == 11)
            {
                try
                {
                    unitcost = dataGridView11.Rows[rowindex].Cells["uni_1"].Value.ToString();

                }
                catch (Exception ex)
                {
                    unitcost = "1";
                    dataGridView11.Rows[rowindex].Cells["uni_1"].Value = "1";

                }
                try
                {
                    disrate = dataGridView11.Rows[rowindex].Cells["Disco"].Value.ToString();
                }
                catch (Exception ex)
                {
                    disrate = "0";
                    dataGridView11.Rows[rowindex].Cells["Disco"].Value = "0";

                }
                if (Convert.ToDouble(dataGridView11.Rows[rowindex].Cells["Disco"].Value) > Convert.ToDouble(dataGridView11.Rows[rowindex].Cells["uni_1"].Value))
                {
                    dataGridView11.Rows[rowindex].Cells["discount"].Value = "0";
                }

                //string per1 = (Convert.ToDouble(unitcost) * Convert.ToDouble(disrate) / 100).ToString();
                try
                {
                    tqty = dataGridView11.Rows[rowindex].Cells["Total_kg2"].Value.ToString();
                }
                catch (Exception ex)
                {


                }

                try
                {
                    cocost = dataGridView11.Rows[rowindex].Cells["uct"].Value.ToString();
                }
                catch (Exception ex)
                {


                }
                try
                {
                    dataGridView11.Rows[rowindex].Cells["uct"].Value = (Convert.ToDouble(cocost) - Convert.ToDouble(disrate)).ToString();
                }
                catch (Exception ex)
                {


                }
                try
                {
                    cocost = dataGridView11.Rows[rowindex].Cells["uct"].Value.ToString();
                }
                catch (Exception ex)
                {


                }
                try
                {
                    tqty = dataGridView11.Rows[rowindex].Cells["Total_kg2"].Value.ToString();
                }
                catch (Exception ex)
                {


                }
                try
                {
                    dataGridView11.Rows[rowindex].Cells["Total_coo"].Value = Convert.ToString(Convert.ToDouble(cocost) * Convert.ToDouble(tqty));
                }
                catch (Exception ex)
                {


                }
                try
                {
                    totalcost = dataGridView11.Rows[rowindex].Cells["Total_coo"].Value.ToString();
                }
                catch (Exception exc)
                { }
                try
                {
                    texrate = dataGridView11.Rows[rowindex].Cells["tex1"].Value.ToString();
                    if (texrate == "")
                    {
                        texrate = "0";
                        dataGridView11.Rows[rowindex].Cells["tex1"].Value = "0";
                    }
                }
                catch (Exception exc)
                {
                    texrate = "0";
                    dataGridView11.Rows[rowindex].Cells["tex1"].Value = "0";
                }
                try
                {
                    dataGridView11.Rows[rowindex].Cells["tex_a1"].Value = Convert.ToString(Convert.ToDouble(totalcost) * (Convert.ToDouble(texrate) / 100));

                }
                catch (Exception exc)
                {


                }
                try
                {
                    unitcost = dataGridView11.Rows[rowindex].Cells["uni_1"].Value.ToString();
                    if (unitcost == "")
                    {
                        unitcost = "1";
                        dataGridView11.Rows[rowindex].Cells["uni_1"].Value = "1";
                    }

                }
                catch (Exception exc)
                {
                    unitcost = "1";
                    dataGridView11.Rows[rowindex].Cells["uni_1"].Value = "1";

                }
                try
                {
                    cocost = dataGridView11.Rows[rowindex].Cells["uct"].Value.ToString();
                    if (cocost == "")
                    {
                        cocost = "1";
                        dataGridView11.Rows[rowindex].Cells["uct"].Value = "1";
                    }
                }
                catch (Exception exc)
                {
                    cocost = "1";
                    dataGridView11.Rows[rowindex].Cells["uct"].Value = "1";

                }
                try
                {
                    quanty = dataGridView11.Rows[rowindex].Cells["weight"].Value.ToString();
                }
                catch (Exception exc)
                {

                    quanty = "0";
                }
                try
                {
                    dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value = Convert.ToString(Convert.ToDouble(quanty) * Convert.ToDouble(cocost));
                    ctncost = dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value.ToString();
                    if (ctncost == "")
                    {
                        ctncost = "1";
                        dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value = "1";
                    }
                }
                catch (Exception exc)
                {
                    ctncost = "1";
                    dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value = "1";

                }

            }
            for (int k = 0; k < dataGridView11.RowCount; k++)
            {
                try
                {

                    grand = dataGridView11.Rows[k].Cells["Total_kg2"].Value.ToString();

                    t_q = Convert.ToDouble(grand) + t_q;


                    t_cost = dataGridView11.Rows[k].Cells["Total_coo"].Value.ToString();
                    t_p = Convert.ToDouble(t_cost) + t_p;

                }
                catch (Exception ex)
                {

                    //  MessageBox.Show(ex.Message);
                }
                label53.Text = Convert.ToString(t_q);
                label52.Text = Convert.ToString(t_p);
            }
            t_q = 0;
            t_q = 0;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void dataGridView1_Click(object sender, EventArgs e)
        {




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

        private void depget()
        {
            try
            {
                connection_check();
                Dep_create.Items.Clear();
                MySqlCommand Crole = new MySqlCommand("select dep_name from departmenttb order by dep_name asc ", conn);
                Crole.ExecuteNonQuery();
                MySqlDataReader rd = Crole.ExecuteReader();
                while (rd.Read())
                {
                    Dep_create.Items.Add(rd[0].ToString());

                }
                rd.Dispose();
            }
            catch (Exception ex)
            {


            }

        }
        private void pdgetall()
        {
            try
            {
                connection_check();
                search_box_pro.Items.Clear();
                connection_check();
                MySqlCommand Crole = new MySqlCommand("select cat_name from fsm_pro_pricing order by cat_name asc  ", conn);
                Crole.ExecuteNonQuery();
                MySqlDataReader rd = Crole.ExecuteReader();
                while (rd.Read())
                {
                    search_box_pro.Items.Add(rd[0].ToString());

                }
                rd.Dispose();
            }
            catch (Exception ex)
            {


            }

        }
        private void pdget()
        {
            try
            {
                connection_check();
                Pd_create.Items.Clear();
                connection_check();
                MySqlCommand Crole = new MySqlCommand("select cat_name from fsm_product order by cat_name asc  ", conn);
                Crole.ExecuteNonQuery();
                MySqlDataReader rd = Crole.ExecuteReader();
                while (rd.Read())
                {
                    Pd_create.Items.Add(rd[0].ToString());

                }
                rd.Dispose();
            }
            catch (Exception ex)
            {


            }

        }
        //private void itget()
        //{
        //    try
        //    {
        //        connection_check();

        //        search_boxs.Items.Clear();
        //        connection_check();
        //        MySqlCommand Crole = new MySqlCommand("select DISTINCT(itemname) from depitem order by itemname asc  ", conn);
        //        Crole.ExecuteNonQuery();
        //        MySqlDataReader rd = Crole.ExecuteReader();
        //        while (rd.Read())
        //        {

        //            search_boxs.Items.Add(rd[0].ToString());

        //        }
        //        rd.Dispose();
        //    }
        //    catch (Exception ex)
        //    {


        //    }

        //}
        private void btn_plus_dep_Click(object sender, EventArgs e)
        {
            string ch_dep = null;
            if (Dep_create.Text == "" || Dep_create.Text == null)
            {
                MessageBox.Show("Please Type a Department!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {

                    try
                    {
                        connection_check();
                        MySqlCommand sel_deb = new MySqlCommand("select dep_name from departmenttb where dep_name='" + Dep_create.Text + "' ", conn);
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
                catch (Exception ex)
                {

                    connection_check();

                }
                if (ch_dep == null)
                {
                    try
                    {
                        connection_check();
                        MySqlCommand ins = new MySqlCommand("insert into departmenttb (dep_name) Values ('" + Dep_create.Text + "')", conn);
                        ins.ExecuteNonQuery();
                        ins.Dispose();
                        MessageBox.Show("This Department is now Added to the record!", "record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                else if (ch_dep != null)
                {
                    MessageBox.Show("This Department Already Exist!", "Invaild Department", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Dep_create.Focus();
                    return;
                }
                depget();
                getdepp();
                getitem_name();
                //Dep_create.Text = "";
                //Pd_create.Text = "";
                //item_add.Text = "";

            }
            Bind_Grid18();
        }

        private void btn_minus_dep_Click(object sender, EventArgs e)
        {
            connection_check();
            if (Dep_create.Text == "" || Dep_create.Text == null)
            {
                MessageBox.Show("Please Select a Department!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    connection_check();
                    Dep_create.Items.Clear();
                    MySqlCommand ds = new MySqlCommand("delete from departmenttb where dep_name=('" + Dep_create.Text + "')", conn);
                    ds.ExecuteNonQuery();
                    ds.Dispose();
                    MessageBox.Show("This Department is Delete from the record!", "Record deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    connection_check();
                    MessageBox.Show(ex.Message);

                }
                connection_check();
                depget();
                getdepp();
                getitem_name();
                Dep_create.Text = "";
                //Pd_create.Text = "";
                //item_add.Text = "";
            }
            Bind_Grid18();
        }

        private void btn_plus_pd_Click(object sender, EventArgs e)
        {
            string ch_pd = null;
            connection_check();
            if (Pd_create.Text == "" || Pd_create.Text == null)
            {
                MessageBox.Show("Please Type a Product!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    connection_check();
                    try
                    {
                        connection_check();
                        MySqlCommand sel_deb = new MySqlCommand("select cat_name from fsm_product where  cat_name='" + Pd_create.Text + "' ", conn);
                        sel_deb.ExecuteNonQuery();
                        MySqlDataReader deb_dr = sel_deb.ExecuteReader();
                        while (deb_dr.Read())
                        {
                            ch_pd = deb_dr[0].ToString();
                        }
                        deb_dr.Dispose();
                    }
                    catch (Exception ex)
                    {

                        connection_check();
                    }

                }
                catch (Exception ex)
                {

                    connection_check();

                }


                if (ch_pd == null)
                {

                    try
                    {
                        try
                        {
                            connection_check();
                            MySqlCommand ins = new MySqlCommand("insert into fsm_product(cat_name) Values ('" + Pd_create.Text + "') ", conn);
                            ins.ExecuteNonQuery();
                            ins.Dispose();
                            MessageBox.Show("This Product is now Added to the record!", "record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        try
                        {
                            connection_check();
                            MySqlCommand setupall2 = new MySqlCommand("Insert into fsm_pro_pricing (cat_name) Values('" + Pd_create.Text + "') ", conn);
                            setupall2.ExecuteNonQuery();
                            setupall2.Dispose();
                        }
                        catch (Exception ex)
                        {

                            connection_check();
                            MessageBox.Show(ex.Message);
                        }
                    }
                    catch (Exception ex)
                    {
                        connection_check();
                        // MessageBox.Show(ex.Message);
                    }
                }

                else if (ch_pd != null)
                {
                    connection_check();
                    MessageBox.Show("This Product Already Exist!", "Invaild Department", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Dep_create.Focus();
                    return;
                }


                connection_check();
                getdepp();
                getproduct();
                getitem_name();
                //Dep_create.Text = "";
                //Pd_create.Text = "";
                //item_add.Text = "";
                Bind_Grid17();
                Bind_Grid39();

            }

        }

        private void btn_minus_pd_Click(object sender, EventArgs e)
        {
            try
            {
                connection_check();
                if (Pd_create.Text == "" || Pd_create.Text == null)
                {
                    MessageBox.Show("Please Select a Product!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    try
                    {
                        connection_check();
                        Pd_create.Items.Clear();
                        MySqlCommand ds = new MySqlCommand("delete from fsm_product where cat_name='" + Pd_create.Text + "'", conn);
                        ds.ExecuteNonQuery();
                        ds.Dispose();

                        try
                        {
                            connection_check();
                            MySqlCommand ds1 = new MySqlCommand("delete from fsm_pro_pricing where cat_name='" + Pd_create.Text + "'", conn);
                            ds1.ExecuteNonQuery();
                            ds1.Dispose();
                        }
                        catch (Exception ex)
                        {


                        }


                        MessageBox.Show("This Product is Delete from the record!", "Record deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    catch (Exception ex)
                    {
                        connection_check();
                        MessageBox.Show(ex.Message);

                    }
                    connection_check();
                    getproduct();
                    getdepp();
                    getitem_name();
                    //Dep_create.Text = "";
                    Pd_create.Text = "";
                    //item_add.Text = "";
                    Bind_Grid17();
                }
            }
            catch (Exception ex)
            {


            }

        }

        private void btn_plus_item_Click(object sender, EventArgs e)
        {
            string ch_it = null;
            string ch_it1 = null;
            connection_check();
            if (add_item_only.Checked == true)
            {
                if (item_add.Text != "" || item_add.Text != null)
                {
                    try
                    {

                        MySqlCommand sel_deb1 = new MySqlCommand("select raw_name from rawtb where (raw_name='" + item_add.Text + "') ", conn);
                        sel_deb1.ExecuteNonQuery();
                        MySqlDataReader deb_dr1 = sel_deb1.ExecuteReader();
                        while (deb_dr1.Read())
                        {
                            ch_it1 = deb_dr1[0].ToString();
                        }
                        deb_dr1.Dispose();
                    }
                    catch (Exception ex)
                    {

                        connection_check();

                    }
                    if (ch_it1 == null)
                    {

                        try
                        {
                            try
                            {
                                connection_check();
                                MySqlCommand ins1 = new MySqlCommand("insert into rawtb (raw_name) Values ('" + item_add.Text + "') ", conn);
                                ins1.ExecuteNonQuery();
                                ins1.Dispose();
                                MessageBox.Show("This Item is now Added to the record!", "record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            catch (Exception ex)
                            {
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }
                    else if (ch_it1 != null)
                    {
                        connection_check();
                        MessageBox.Show("This Item is Already Exist!", "Invaild Department", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Dep_create.Focus();
                        return;

                    }
                    getitem_name();
                    getdepp();
                    //Dep_create.Text = "";
                    //Pd_create.Text = "";
                    //item_add.Text = "";

                    Bind_Grid17();
                    Bind_Grid39();
                }
                else
                {
                    MessageBox.Show("Please Type or Select an Item!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {


                if (item_add.Text == "" || item_add.Text == null || Pd_create.Text == "" || Pd_create.Text == null || Dep_create.Text == "" || Dep_create.Text == null)
                {
                    MessageBox.Show("Please Type or Select an Item!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    try
                    {
                        connection_check();
                        MySqlCommand sel_deb = new MySqlCommand("select itemname from depitem where (dep_name='" + Dep_create.Text + "') and  (cat_name='" + Pd_create.Text + "') and (itemname='" + item_add.Text + "') ", conn);
                        sel_deb.ExecuteNonQuery();
                        MySqlDataReader deb_dr = sel_deb.ExecuteReader();
                        while (deb_dr.Read())
                        {
                            ch_it = deb_dr[0].ToString();
                        }
                        deb_dr.Dispose();
                    }
                    catch (Exception ex)
                    {

                        connection_check();

                    }

                    if (ch_it == null)
                    {

                        try
                        {
                            try
                            {
                                connection_check();
                                MySqlCommand ins = new MySqlCommand("insert into depitem (dep_name,cat_name,itemname) Values ('" + Dep_create.Text + "','" + Pd_create.Text + "','" + item_add.Text + "') ", conn);
                                ins.ExecuteNonQuery();
                                ins.Dispose();
                                MessageBox.Show("This Item is now Added to the record!", "record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }
                    else if (ch_it != null)
                    {
                        connection_check();
                        MessageBox.Show("This Item is Already Exist!", "Invaild Department", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        item_add.Focus();
                        return;
                    }


                    connection_check();
                    getitem_name();
                    getdepp();
                    //Dep_create.Text = "";
                    //Pd_create.Text = "";
                    //item_add.Text = "";

                    Bind_Grid17();
                    Bind_Grid39();
                }
            }

        }

        private void s_Click(object sender, EventArgs e)
        {
            connection_check();
            if (add_item_only.Checked == true)
            {
                if (item_add.Text == "" || item_add.Text == null)
                {
                    MessageBox.Show("Please Type a Item!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        connection_check();
                        item_add.Items.Clear();
                        connection_check();
                        MySqlCommand ds1 = new MySqlCommand("delete from rawtb where  (raw_name='" + item_add.Text + "')", conn);
                        ds1.ExecuteNonQuery();
                        ds1.Dispose();
                        MessageBox.Show("This item is Delete from the record!", "Record deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        connection_check();
                        // MessageBox.Show(ex.Message);
                    }
                    connection_check();
                    getitem_name();
                    item_add.Text = "";
                }
            }
            else
            {
                if (item_add.Text == "" || item_add.Text == null)
                {
                    MessageBox.Show("Please Type a Item!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        connection_check();
                        item_add.Items.Clear();
                        MySqlCommand ds = new MySqlCommand("delete from depitem where (dep_name='" + Dep_create.Text + "') and  (cat_name='" + Pd_create.Text + "') and (itemname='" + item_add.Text + "')", conn);
                        ds.ExecuteNonQuery();
                        ds.Dispose();
                        connection_check();
                        MessageBox.Show("This item is Delete from the record!", "Record deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        connection_check();
                    }

                    getitem_name();
                    getdepp();
                    Bind_Grid17();
                    Bind_Grid39();
                    item_add.Text = "";
                }
            }
        }

        private void Dep_create_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection_check();
            Pd_create.Text = "";
            Pd_create.Items.Clear();

            try
            {
                connection_check();
                MySqlCommand com_name = new MySqlCommand("select DISTINCT(cat_name) from depitem  where dep_name = '" + Dep_create.Text + "' order by dep_name asc ", conn);
                com_name.ExecuteNonQuery();
                MySqlDataReader rd = com_name.ExecuteReader();
                while (rd.Read())
                {
                    Pd_create.Items.Add(rd[0].ToString());
                }
                rd.Dispose();

            }
            catch (Exception ex)
            {

                connection_check();
            }
            texdep.Text = Dep_create.Text;

        }

        private void Pd_create_SelectedIndexChanged(object sender, EventArgs e)
        {
            texpd.Text = Pd_create.Text;
            //connection_check();
            //item_add.Text = "";
            //item_add.Items.Clear();

            //try
            //{
            //    connection_check();
            //    MySqlCommand com_name = new MySqlCommand("select DISTINCT(itemname) from depitem  where cat_name = '" + Pd_create.Text + "' order by dep_name asc ", conn);
            //    com_name.ExecuteNonQuery();
            //    MySqlDataReader rd = com_name.ExecuteReader();
            //    while (rd.Read())
            //    {
            //        item_add.Items.Add(rd[0].ToString());
            //    }
            //    rd.Dispose();

            //}
            //catch (Exception ex)
            //{

            //    connection_check();
            //}
            Bind_Grid17();
        }

        private void getbranch_n()
        {
            try
            {
                connection_check();
                // f_branch_stock.Items.Clear();
                // t_branch_stock.Items.Clear();
                bcom.Items.Clear();
                b_name.Items.Clear();
                comboBox5.Items.Clear();
                bran_box.Items.Clear();
                MySqlCommand Crole = new MySqlCommand("select branch_n from fsm_branch where branch_n !='" + Login.branch + "' order by branch_n asc  ", conn);
                Crole.ExecuteNonQuery();
                MySqlDataReader rd = Crole.ExecuteReader();
                while (rd.Read())
                {
                    // f_branch_stock.Items.Add(rd[0].ToString());
                    // t_branch_stock.Items.Add(rd[0].ToString());
                    bcom.Items.Add(rd[0].ToString());
                    b_name.Items.Add(rd[0].ToString());
                    comboBox5.Items.Add(rd[0].ToString());
                    bran_box.Items.Add(rd[0].ToString());
                }
                rd.Dispose();
            }
            catch (Exception ex)
            {


            }
        }
        private void getbranch_n_2()
        {
            try
            {
                connection_check();

                bran_box.Items.Clear();

                MySqlCommand Crole = new MySqlCommand("select branch_n from fsm_branch  order by branch_n asc  ", conn);
                Crole.ExecuteNonQuery();
                MySqlDataReader rd = Crole.ExecuteReader();
                while (rd.Read())
                {

                    bran_box.Items.Add(rd[0].ToString());

                }
                rd.Dispose();
            }
            catch (Exception ex)
            {


            }
        }
        private void for_production()
        {
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
                //connection_check();
                //try
                //{
                //    connection_check();
                    
                //    string Last_Id = "";
                   
                //    MySqlCommand sel_id = new MySqlCommand("Select LAST(ID) from fsm_voucher_log", conn);
                    
                //    sel_id.ExecuteNonQuery();
                    
                //    MySqlDataReader drr_id = sel_id.ExecuteReader();
                    
                //    while (drr_id.Read())
                //    {
                //        Last_Id = drr_id[0].ToString();
                //    }
                //    drr_id.Dispose();
                    
                //    if (Last_Id == "")
                //    {
                //        Last_Id = "1";
                //    }
                //    else if (Last_Id != "")
                //    {
                //        new_Id = Convert.ToInt32(Last_Id);
                //        invoice_id.Text = 1 + Convert.ToString(new_Id);
                //    }
                //}
                //catch (Exception ex)
                //{

                //    MessageBox.Show(ex.Message);
                //}

                connection_check();
                try
                {
                    MySqlCommand setupall3 = new MySqlCommand("Delete from fsm_null where invoice_no ='" + inv_num.Text + "' and branch_n = '" + Login.branch + "' ", conn);
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
                Bind_Grid0();
                Bind_Grid27();
                Bind_Grid23();
                getvoucher_rw();
                getvoucher_fg();

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
                    sumqty = "";
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
                            MySqlCommand sel_deb = new MySqlCommand("select qty from fsm_mainstore where item='" + items_names + "' and branch_n='" + Login.branch + "'", conn);
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
                            MessageBox.Show(ex.Message);

                        }
                        if (sumqty == "")
                        {

                        //connection_check();
                        try
                        {
                            MySqlCommand sel_deb2 = new MySqlCommand("select barcode,cat_name from fsm_pro_pricing where cat_name='" + items_names + "' ", conn);
                            sel_deb2.ExecuteNonQuery();
                            MySqlDataReader deb_dr2 = sel_deb2.ExecuteReader();
                            while (deb_dr2.Read())
                            {
                                sumqty2 = deb_dr2[0].ToString();
                                sumqty3 = deb_dr2[1].ToString();
                            }
                            deb_dr2.Dispose();
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show(ex.Message);

                        }
                        //try
                        //{
                        //    MySqlCommand sel_deb3 = new MySqlCommand("select cat_name from fsm_pro_pricing where cat_name='" + items_names + "' ", conn);
                        //    sel_deb3.ExecuteNonQuery();
                        //    MySqlDataReader deb_dr3 = sel_deb3.ExecuteReader();
                        //    while (deb_dr3.Read())
                        //    {
                        //        sumqty3 = deb_dr3[0].ToString();
                        //    }
                        //    deb_dr3.Dispose();
                        //}
                        //catch (Exception ex)
                        //{
                        //    // MessageBox.Show(ex.Message);
                        //    connection_check();

                        //}
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
                                MySqlCommand setupall2 = new MySqlCommand("Insert into fsm_mainstore (barcode,branch_n,item,qty,ms_data,ms_time,pc_name,domain,Status,login_user,retail_price) Values('" + sumqty2 + "','" + Login.branch + "','" + items_names + "','" + totals + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss:tt") + "','" + hostName + "','" + myIP + "','Finished Goods','" + Login.user_n + "','" + cost_1 + "') ", conn);
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
                                MySqlCommand setup = new MySqlCommand("Insert into fsm_voucher (unit_cost,barcode,invoice_ID,invoice_code,invoice_number,branch_n,raw_name,supplier,weight,bag,total_kg_p,rema_qty,cost,Tex,Discount,total_cost,invoice_date,invoice_time,pc_name,domain,tax_amount,ctn_cost,Status,login_user) Values('" + ucost + "','" + sumqty2 + "','" + new_Id + "','" + text_in_id.Text + "','" + inv_num.Text + "','" + Login.branch + "','" + items_names + "','" + c_name + "','" + quanty + "' , '" + bags + "','" + totals + "','" + totals + "','" + cost_1 + "','" + tex_rate + "','" + dis_rate + "','" + cost_2 + "' ,'" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss:tt") + "' ,'" + hostName + "','" + myIP + "','" + t_a + "','" + bag_ctn_c + "','Finished Goods','" + Login.user_n + "') ", conn);
                                setup.ExecuteNonQuery();
                                setup.Dispose();


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

                            }
                            else if (sumqty != "")
                            {
                                try
                                {
                                    connection_check();
                                    qty_t = Convert.ToDouble(totals) + Convert.ToDouble(sumqty);
                                    MySqlCommand in_upd = new MySqlCommand("Update fsm_mainstore set  qty='" + Convert.ToString(qty_t) + "' where item='" + items_names + "' and branch_n ='" + Login.branch + "'", conn);
                                    in_upd.ExecuteNonQuery();
                                    in_upd.Dispose();

                                }
                                catch (Exception ex)
                                {
                                }
                                try
                                {
                                    connection_check();
                                    qty_t = Convert.ToDouble(totals) + Convert.ToDouble(sumqty);
                                    MySqlCommand in_upd = new MySqlCommand("Update fsm_voucher set total_kg_p='" + Convert.ToString(qty_t) + "', rema_qty='" + Convert.ToString(qty_t) + "' where raw_name='" + items_names + "' and branch_n ='" + Login.branch + "'", conn);
                                    in_upd.ExecuteNonQuery();
                                    in_upd.Dispose();

                                }
                                catch (Exception ex)
                                { }

                                try
                                {
                                    connection_check();
                                    MySqlCommand setupall22 = new MySqlCommand("Insert into fsm_voucher_log (unit_cost,barcode,invoice_ID,invoice_code,invoice_number,branch_n,raw_name,supplier,weight,bag,total_kg_p,cost,Tex,Discount,total_cost,invoice_date,invoice_time,pc_name,domain,tax_amount,ctn_cost,Status,login_user) Values('"+ucost+"','" + sumqty2 + "','" + new_Id + "','" + text_in_id.Text + "','" + inv_num.Text + "','" + Login.branch + "','" + items_names + "','" + c_name + "','" + quanty + "' , '" + bags + "','" + totals + "','" + cost_1 + "','" + tex_rate + "','" + dis_rate + "','" + cost_2 + "' ,'" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss:tt") + "' ,'" + hostName + "','" + myIP + "','" + t_a + "','" + bag_ctn_c + "','Finshed','" + Login.user_n + "') ", conn);
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
                Bind_Grid0();
                Bind_Grid27();
                Bind_Grid23();
                Bind_Grid39();
                Bind_Grid19();
                getvoucher_rw();
                getvoucher_fg();


            }
        }
        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void f_branch_stock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Bind_Grid20();
        }

        private void t_branch_stock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Bind_Grid21();
        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {


            if (checkBox1.Checked == true)
            {
                Bind_Grid23();
                search_box_pro.Visible = true;
                search_boxs.Visible = false;
            
               // dataGridView17.Visible = false;

                //dataGridView15.Visible = false;
                checkBox2.Checked = false;
               // dataGridView16.Visible = true;
            }
            if (!backgroundWorker3.IsBusy)
            {
                backgroundWorker3.RunWorkerAsync();
            }
            else if (checkBox1.Checked == false)
            {
                //dataGridView16.Visible = false;

               
                Bind_Grid25();
               // dataGridView17.Visible = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {


            if (checkBox2.Checked == true)
            {
                Bind_Grid27();
                search_box_pro.Visible = false;
                search_boxs.Visible = true;
                //panel1.Visible = true;
                //progressBar1.Visible = true;
                //label107.Visible = true;
                //label108.Visible = true;
               // dataGridView17.Visible = false;
               // dataGridView16.Visible = false;
                checkBox1.Checked = false;
               // dataGridView15.Visible = true;
            }
            //if (!backgroundWorker4.IsBusy)
            //{
            //    backgroundWorker4.RunWorkerAsync();
            //}
            else if (checkBox2.Checked == false)
            {
               // dataGridView15.Visible = false;

                //panel1.Visible = false;
                //progressBar1.Visible = false;
                //label107.Visible = false;
                //label108.Visible = false;
                Bind_Grid25();
               // dataGridView17.Visible = true;
            }




        }

        private void dataGridView15_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            int col = e.ColumnIndex;

            double t_q = 0;
            for (int k = 0; k < dataGridView15.RowCount; k++)
            {
                try
                {

                    grand = dataGridView15.Rows[k].Cells["dn"].Value.ToString();

                    t_q = Convert.ToDouble(grand) + t_q;



                }
                catch (Exception ex)
                {

                }
                label106.Text = Convert.ToString(t_q);

            }
            t_q = 0;


        }

        private void button13_Click(object sender, EventArgs e)
        {
            string ti = System.DateTime.Now.ToString("hh:mm:ss:tt");
            connection_check();

            if (dn_id.Text == "")
            {
               
                    string myStringVariable1 = string.Empty;
                    MessageBox.Show("Demand ID is required");
                    return;
               
               
            }

            else
            {
                if (active_branch.Checked == true)
                {
                    connection_check();
                    if (checkBox2.Checked == true)
                    {

                        for (int i = 0; i < dataGridView15.RowCount; i++)
                        {
                            items_names = dataGridView15.Rows[i].Cells["r_m"].Value.ToString();

                            try
                            {
                                quanty = dataGridView15.Rows[i].Cells["dn"].Value.ToString();
                            }
                            catch (Exception ex)
                            {
                                quanty = "0";
                                dataGridView15.Rows[i].Cells["dn"].Value = "0";
                            }
                            if (quanty != "0")
                            {


                                connection_check();
                                try
                                {
                                    connection_check();
                                    MySqlCommand setupalll = new MySqlCommand("Insert into fsm_demand_note (itemname,demand_qty,demand_id,branch,dn_date,dn_time,pc_name,domain,demand_type,status,login_user,branch_n) Values('" + items_names + "','" + quanty + "' ,'" + dn_id.Text + "','" + Login.branch + "' ,'" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + ti + "' ,'" + hostName + "','" + myIP + "','Raw Material','Demand','" + Login.user_n + "','" + bran_name.Text + "')", conn);
                                    setupalll.ExecuteNonQuery();
                                    setupalll.Dispose();
                                }
                                catch (Exception ex)
                                {

                                    connection_check();
                                }
                            }
                        }
                    }

                    else if (checkBox1.Checked == true)
                    {
                        for (int j = 0; j < dataGridView16.RowCount; j++)
                        {
                            items_names = dataGridView16.Rows[j].Cells["rr_m"].Value.ToString();
                            try
                            {
                                quanty = dataGridView16.Rows[j].Cells["dno"].Value.ToString();
                            }
                            catch (Exception ex)
                            {
                                quanty = "0";
                                dataGridView16.Rows[j].Cells["dno"].Value = "0";
                            }
                            if (quanty != "0")
                            {
                                connection_check();
                                try
                                {
                                    connection_check();
                                    MySqlCommand setupalll1 = new MySqlCommand("Insert into fsm_demand_note (itemname,demand_qty,demand_id,branch,dn_date,dn_time,pc_name,domain,demand_type,status,login_user,branch_n) Values('" + items_names + "','" + quanty + "' ,'" + dn_id.Text + "','" + Login.branch + "' ,'" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + ti + "' ,'" + hostName + "','" + myIP + "','Finished Goods','Demand','" + Login.user_n + "','" + bran_name.Text + "')", conn);
                                    setupalll1.ExecuteNonQuery();
                                    setupalll1.Dispose();
                                }
                                catch (Exception ex)
                                {

                                    connection_check();
                                }
                            }
                        }
                    }

                }
                else if (active_branch.Checked == false || bcom.Text == "")
                {
                    if (bcom.Text == "")
                    {
                        string myStringVariable2 = string.Empty;
                        MessageBox.Show("Branch Name is requierd");
                        bcom.Focus();
                        return;
                    }
                    connection_check();
                    if (checkBox2.Checked == true)
                    {

                        for (int i = 0; i < dataGridView15.RowCount; i++)
                        {
                            items_names = dataGridView15.Rows[i].Cells["r_m"].Value.ToString();

                            try
                            {
                                quanty = dataGridView15.Rows[i].Cells["dn"].Value.ToString();
                            }
                            catch (Exception ex)
                            {
                                quanty = "0";
                                dataGridView15.Rows[i].Cells["dn"].Value = "0";
                            }
                            if (quanty != "0")
                            {


                                connection_check();
                                try
                                {
                                    connection_check();
                                    MySqlCommand setupalll = new MySqlCommand("Insert into fsm_demand_note (itemname,demand_qty,demand_id,branch,dn_date,dn_time,pc_name,domain,demand_type,status,login_user,branch_n) Values('" + items_names + "','" + quanty + "' ,'" + dn_id.Text + "','" + bcom.Text + "' ,'" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + ti + "' ,'" + hostName + "','" + myIP + "','Raw Material','Demand','" + Login.user_n + "','" + Login.branch + "')", conn);
                                    setupalll.ExecuteNonQuery();
                                    setupalll.Dispose();
                                }
                                catch (Exception ex)
                                {

                                    connection_check();
                                }
                            }
                        }
                    }

                    else if (checkBox1.Checked == true)
                    {
                        for (int j = 0; j < dataGridView16.RowCount; j++)
                        {
                            items_names = dataGridView16.Rows[j].Cells["rr_m"].Value.ToString();
                            try
                            {
                                quanty = dataGridView16.Rows[j].Cells["dno"].Value.ToString();
                            }
                            catch (Exception ex)
                            {
                                quanty = "0";
                                dataGridView16.Rows[j].Cells["dno"].Value = "0";
                            }
                            if (quanty != "0")
                            {
                                connection_check();
                                try
                                {
                                    connection_check();
                                    MySqlCommand setupalll1 = new MySqlCommand("Insert into fsm_demand_note (itemname,demand_qty,demand_id,branch,dn_date,dn_time,pc_name,domain,demand_type,status,login_user,branch_n) Values('" + items_names + "','" + quanty + "' ,'" + dn_id.Text + "','" + bcom.Text + "' ,'" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + ti + "' ,'" + hostName + "','" + myIP + "','Finished goods','Demand','" + Login.user_n + "','" + Login.branch + "')", conn);
                                    setupalll1.ExecuteNonQuery();
                                    setupalll1.Dispose();
                                }
                                catch (Exception ex)
                                {

                                    connection_check();
                                }
                            }
                        }
                    }

                }

            }
            dn_id.Text = "";
            bcom.Text = "";
            //checkBox1.Checked = false;
            //checkBox2.Checked = false;
            bcom.Enabled = false;
            active_branch.Checked = false;
            textBox8.Text = "";
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            button13.Enabled = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            // label106.Text = "0";
            label107.Visible = false;
            label108.Visible = false;
            label108.Text = "0";
            panel1.Visible = false;
            search_boxs.Text = "";
            search_boxs.Enabled = false;
            bran_name.Text = Login.branch;
            bran_box.Enabled = true;
            progressBar1.Visible = false;
           // dataGridView15.Visible = false;
            //dataGridView16.Visible = false;
            Bind_Grid25();
            //dataGridView17.Visible = true;
            demandlist();
            demandlist_2();
            Bind_Grid32();
            Bind_Grid29();
            Bind_Grid27();
            Bind_Grid23();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            connection_check();

            try
            {
                dn_id.Text = "DN-" + DateTime.Today.ToString("MMyy") + DateTime.Now.ToString("hhmmss");
            }
            catch (Exception es)
            {
            }
            search_box_pro.Visible = false;
            search_boxs.Visible = true;
            active_branch.Enabled = true;
            bcom.Enabled = true;
            bcom.Text = "";
            textBox8.Text = "";
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            button13.Enabled = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            //dataGridView15.Visible = false;
            //dataGridView16.Visible = false;
           // dataGridView17.Visible = true;
            // label106.Text = "0";
            label107.Visible = false;
            label108.Visible = false;
            label108.Text = "0";
            panel1.Visible = false;
            search_boxs.Text = "";
            search_boxs.Enabled = true;
            progressBar1.Visible = false;
        }

        private void dataGridView16_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //    int rowindex = e.RowIndex;
            //    int col = e.ColumnIndex;
            //    double t_q = 0;

            //    for (int k = 0; k < dataGridView16.RowCount; k++)
            //    {
            //        try
            //        {

            //            grand = dataGridView16.Rows[k].Cells["dno"].Value.ToString();

            //            t_q = Convert.ToDouble(grand) + t_q;



            //        }
            //        catch (Exception ex)
            //        {

            //            //  MessageBox.Show(ex.Message);
            //        }
            //        label106.Text = Convert.ToString(t_q);

            //    }
            //    t_q = 0;

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

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {


            //connection_check();
            //try
            //{

            //    //if (checkBox1.Checked == true)
            //    //{

            //    //    //dataGridView17.Visible = false;

            //    //dataGridView15.Visible = false;
            //    //checkBox2.Checked = false;
            //    //dataGridView16.Visible = true;


            //    string[] bn = new string[5000];
            //    string[] itemn = new string[5000];
            //    int k = 1;
            //    int no = 0;

            //try
            //{
            //    connection_check();
            //    MySqlCommand axx = new MySqlCommand("select branch_n from fsm_branch  ", conn);
            //    axx.ExecuteNonQuery();
            //    MySqlDataReader dtr = axx.ExecuteReader();
            //    while (dtr.Read())
            //    {
            //        bn[k] = dtr[0].ToString();
            //        k++;
            //    }
            //    axx.Dispose();
            //    dtr.Dispose();
            //}
            //catch (Exception ex)
            //{
            //}
            //        double pr_perc = 0;
            //        int count = dataGridView16.Rows.Count;
            //        int pp = count * k;
            //        double get_val = 100 / Convert.ToDouble(pp);
            //        k = 0;
            //        while (k != null)
            //        {



            //            k++;

            //        }


            //    }


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);

            //}

        }

        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label107.Visible = false;
            label108.Visible = false;
            panel1.Visible = false;
            progressBar1.Visible = false;




        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {

            //if (checkBox2.Checked == true)
            //{


            //    string[] bn = new string[5000];
            //    string[] itemn = new string[5000];
            //    int m = 1;
            //    int no = 0;

            //    //try
            //    //{
            //    //    connection_check();
            //    //    MySqlCommand axx = new MySqlCommand("select branch_n from fsm_branch  ", conn);
            //    //    axx.ExecuteNonQuery();
            //    //    MySqlDataReader dtr = axx.ExecuteReader();
            //    //    while (dtr.Read())
            //    //    {
            //    //        bn[m] = dtr[0].ToString();

            //    //        m++;
            //    //    }
            //    //    axx.Dispose();
            //    //    dtr.Dispose();
            //    //}
            //    //catch (Exception ex)
            //    //{
            //    //}

            //    int i = 0;

            //    double pr_perc = 0;
            //    int count = dataGridView15.Rows.Count;
            //    int pp = count * m;
            //    double get_val = 100 / Convert.ToDouble(pp);
            //    m = 0;

            //    while (m != null)
            //    {



            //        m++;

            //    }


            //}
        }

        private void backgroundWorker3_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            {

                progressBar1.Value = e.ProgressPercentage;
                label108.Text = e.ProgressPercentage + "%";
                progressBar1.Update();

            }
        }

        private void backgroundWorker4_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            {
                try
                {
                    progressBar1.Value = e.ProgressPercentage;
                    label108.Text = e.ProgressPercentage + "%";
                    progressBar1.Update();


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void backgroundWorker4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label107.Visible = false;
            label108.Visible = false;
            panel1.Visible = false;
            progressBar1.Visible = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView12_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                bdn.Text = dataGridView12.Rows[e.RowIndex].Cells["bdno"].Value.ToString();

            }
            catch (Exception ex)
            {


            }
        }

        private void bdn_TextChanged(object sender, EventArgs e)
        {
            demandlist_2();
        }

        private void dn_tex_TextChanged(object sender, EventArgs e)
        {
            Bind_Grid22();
            for (int b = 0; b < dataGridView13.RowCount; b++)
            {
                pin = dataGridView13.Rows[b].Cells["ino"].Value.ToString();
                if (dataGridView13.Rows[b].Cells["c_qty"].Value == null || dataGridView13.Rows[b].Cells["rem_qty"].Value == "")
                {

                    dataGridView13.Rows[b].Cells["c_qty"].Value = "0";
                }
               

                    try
                    {
                        //wants average price
                        connection_check();
                        MySqlCommand total_qantity = new MySqlCommand("select rema_qty from fsm_voucher where ((raw_name ='" + pin + "') and (Status='for production') and (branch_n='" + Login.branch + "')) ", conn);
                        total_qantity.ExecuteNonQuery();
                        MySqlDataReader rd = total_qantity.ExecuteReader();
                        while (rd.Read())
                        {
                            dataGridView13.Rows[b].Cells["c_qty"].Value = rd[0].ToString();
                        }
                        rd.Dispose();

                    }
                    catch (Exception ex)
                    {
                       

                    }

               
            }

            Bind_Grid28();
            //for (int jb = 0; jb < dataGridView20.RowCount; jb++)
            //{
            //    pin2 = dataGridView20.Rows[jb].Cells["ino3"].Value.ToString();

            //    try
            //    {
            //        connection_check();
            //        try
            //        {
            //            connection_check();
            //            MySqlCommand total_qantity12 = new MySqlCommand("select rema_qty from fsm_voucher  where ((raw_name ='" + pin2 + "') and (Status='Finished Goods') and (branch_n='" + Login.branch + "') ) ", conn);
            //            total_qantity12.ExecuteNonQuery();
            //            MySqlDataReader rd111 = total_qantity12.ExecuteReader();
            //            while (rd111.Read())
            //            {
            //                dataGridView20.Rows[jb].Cells["c_qty3"].Value = rd111[0].ToString();
            //            }
            //            rd111.Dispose();

            //        }
            //        catch (Exception ex)
            //        {
            //            connection_check();

            //        }


            //    }
            //    catch (Exception ex)
            //    {


            //    }
            //}

        }

        private void listView6_Click(object sender, EventArgs e)
        {
            dn_tex.Text = listView6.SelectedItems[0].SubItems[0].Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string ti = System.DateTime.Now.ToString("hh:mm:ss:tt");
            hostName = Dns.GetHostName();
            myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            
            try
            {
                connection_check();
            }
            catch (Exception ex)
            {
            }
            for (int i = 0; i < dataGridView13.RowCount; i++)
            {
                string iiname = "";
                string ttrqty = "";
                string ccqty = "";
                string crqty = "";
                string pp_cost = "";


                try
                {

                    iiname = dataGridView13.Rows[i].Cells["ino"].Value.ToString();

                }
                catch (Exception ec)
                {
                }
                try
                {


                    crqty = dataGridView13.Rows[i].Cells["c_qty"].Value.ToString();

                }
                catch (Exception ec)
                {
                }
                try
                {

                    ttrqty = dataGridView13.Rows[i].Cells["ddno"].Value.ToString();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
                try
                {


                    ccqty = dataGridView13.Rows[i].Cells["ttdno"].Value.ToString();
                    if (ccqty == "") { ccqty = "0"; }
                }
                catch (Exception ec)
                {
                    if (ccqty == "") { ccqty = "0"; }
                }
                try
                {


                    iprice = dataGridView13.Rows[i].Cells["i_price"].Value.ToString();
                    if (iprice == "") { iprice = "0"; }
                }
                catch (Exception ec)
                {
                    if (iprice == "") { iprice = "0"; }
                }
                try
                {
                    connection_check();
                    MySqlCommand itd = new MySqlCommand("Update fsm_demand_note set transfer_qty='" + ccqty + "',cur_qty='" + crqty + "', tr_dec='" + textBox11.Text + "' ,item_price='" + iprice + "' , status='transfer',tr_date='" + DateTime.Today.ToString("yyyy-MM-dd") + "',tr_time='" + ti + "' where (itemname='" + iiname + "') and  (demand_id ='" + dn_tex.Text + "' )and (branch= '" + Login.branch + "' )", conn);
                    itd.ExecuteNonQuery();
                    itd.Dispose();

                }
                catch (Exception ex)
                {

                    connection_check();

                }

                try
                {
                    connection_check();
                    MySqlCommand setupalll = new MySqlCommand("Insert into fsm_transfer (item_price,itemname,qty,demand_id,branch,branch_n,tr_date,tr_time,pc_name,domain,status,tr_qty,cur_qty,login_user,descrip) Values('" + iprice + "','" + iiname + "','" + ttrqty + "' ,'" + dn_tex.Text + "','" + bdn.Text + "','" + Login.branch + "' ,'" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss:tt") + "' ,'" + hostName + "','" + myIP + "','transfer','" + ccqty + "','" + crqty + "','" + Login.user_n + "','" + textBox11.Text + "')", conn);
                    setupalll.ExecuteNonQuery();
                    setupalll.Dispose();
                }
                catch (Exception ex)
                {

                    connection_check();
                }

                //try
                //{
                //    connection_check();
                //    MySqlCommand axx = new MySqlCommand("select total_cost from fsm_voucher where ((raw_name='" + iiname + "') and (branch_n = '" + Login.branch + "') and (cost='" + iprice + "')) ", conn);
                //    axx.ExecuteNonQuery();
                //    MySqlDataReader dtr = axx.ExecuteReader();
                //    while (dtr.Read())
                //    {
                //        pp_cost = dtr[0].ToString();
                //    }
                //    axx.Dispose();
                //    dtr.Dispose();
                //}
                //catch (Exception ex)
                //{


                //}
                //try
                {
                    connection_check();
                    MySqlCommand in_upd = new MySqlCommand("Update fsm_voucher set total_cost ='" + Convert.ToString(Convert.ToDouble(crqty) * Convert.ToDouble(iprice)) + "',total_kg_p = '" + crqty + "', rema_qty= '" + crqty + "'   where (( raw_name='" + iiname + "') and ( branch_n = '" + Login.branch + "') and (Status='for production'))  ", conn);
                    in_upd.ExecuteNonQuery();
                    in_upd.Dispose();

                }
                //catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    //connection_check();
                }


                //MessageBox.Show("Record is successfully Added!", "Record Added Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            transfer_report_2();
            dn_tex.Text = "";
            bdn.Text = "";
            textBox11.Text = "";
            demandlist();
            demandlist_2();
            //  demandlist_3();
            Bind_Grid28();
            Bind_Grid22();
            Bind_Grid32();
            Bind_Grid27();
            Bind_Grid23();
            Bind_Grid29();
        }



        private void dataGridView21_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView21.RowCount; i++)
            {
                dnido = dataGridView21.Rows[i].Cells["cst"].Value.ToString();
                if (dnido == "transfer")
                {
                    dataGridView21.Rows[i].DefaultCellStyle.ForeColor = Color.DodgerBlue;
                }
            }
            try
            {

                dn_tex2.Text = dataGridView21.Rows[e.RowIndex].Cells["dnto"].Value.ToString();

            }
            catch (Exception ex)
            {


            }
            try
            {

                bdn3.Text = dataGridView21.Rows[e.RowIndex].Cells["bno"].Value.ToString();

            }
            catch (Exception ex)
            {


            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string ti = System.DateTime.Now.ToString("hh:mm:ss:tt");
            hostName = Dns.GetHostName();
            myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            string iiname = "";
            string ttrqty = "";
            string ccqty = "";
            string crqty = "";
            string pp_cost = "";
            try
            {
                connection_check();
            }
            catch (Exception ex)
            {
            }
            try
            {
                connection_check();
                for (int i = 0; i < dataGridView20.RowCount; i++)
                {


                    try
                    {

                        iiname = dataGridView20.Rows[i].Cells["ino3"].Value.ToString();

                    }
                    catch (Exception ec)
                    {
                    }
                    try
                    {


                        crqty = dataGridView20.Rows[i].Cells["c_qty3"].Value.ToString();

                    }
                    catch (Exception ec)
                    {
                    }
                    try
                    {

                        ttrqty = dataGridView20.Rows[i].Cells["dno3"].Value.ToString();
                    }
                    catch (Exception ec)
                    {
                        MessageBox.Show(ec.Message);
                    }
                    try
                    {


                        ccqty = dataGridView20.Rows[i].Cells["ttdno3"].Value.ToString();

                    }
                    catch (Exception ec)
                    {
                    }
                    try
                    {


                        iprice = dataGridView20.Rows[i].Cells["i_price3"].Value.ToString();

                    }
                    catch (Exception ec)
                    {
                    }
                    try
                    {
                        connection_check();
                        MySqlCommand itd = new MySqlCommand("Update fsm_demand_note set transfer_qty='" + ccqty + "',cur_qty='" + crqty + "', tr_dec='" + textBox11.Text + "' ,item_price='" + iprice + "' , status='transfer',tr_date='" + DateTime.Today.ToString("yyyy-MM-dd") + "',tr_time='" + ti + "' where (itemname='" + iiname + "' ) and (demand_id='" + dn_tex.Text + "') and (branch='" + Login.branch + "') ", conn);
                        itd.ExecuteNonQuery();
                        itd.Dispose();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        connection_check();

                    }

                    try
                    {
                        connection_check();
                        MySqlCommand setupalll = new MySqlCommand("Insert into fsm_transfer (item_price,itemname,qty,demand_id,branch,branch_n,tr_date,tr_time,pc_name,domain,status,tr_qty,cur_qty,login_user,descrip) Values('" + iprice + "','" + iiname + "','" + ttrqty + "' ,'" + dn_tex.Text + "','" + bdn.Text + "','" + Login.branch + "' ,'" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss:tt") + "' ,'" + hostName + "','" + myIP + "','transfer','" + ccqty + "','" + crqty + "','" + Login.user_n + "','" + textBox10.Text + "')", conn);
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
                        MySqlCommand in_upd = new MySqlCommand("Update fsm_mainstore set qty = '" + crqty + "'  where  item='" + iiname + "' and branch_n = '" + Login.branch + "' ", conn);
                        in_upd.ExecuteNonQuery();
                        in_upd.Dispose();

                    }
                    catch (Exception ex)
                    {

                        connection_check();
                    }
                    //try
                    //{
                    //    connection_check();
                    //    MySqlCommand axx = new MySqlCommand("select cost from fsm_voucher where raw_name='" + iiname + "' and branch_n = '" + Login.branch + "' ", conn);
                    //    axx.ExecuteNonQuery();
                    //    MySqlDataReader dtr = axx.ExecuteReader();
                    //    while (dtr.Read())
                    //    {
                    //        pp_cost = dtr[0].ToString();
                    //    }
                    //    axx.Dispose();
                    //    dtr.Dispose();
                    //}
                    //catch (Exception ex)
                    //{


                    //}
                    try
                    {
                        connection_check();
                        MySqlCommand in_upd = new MySqlCommand("Update fsm_voucher_log set total_cost ='" + Convert.ToString(Convert.ToDouble(crqty) * Convert.ToDouble(iprice)) + "',total_kg_p = '" + crqty + "', rema_qty= '" + crqty + "'   where (( raw_name='" + iiname + "') and ( branch_n = '" + Login.branch + "') and (Status='Finished Goods')and (cost='" + iprice + "'))", conn);
                        in_upd.ExecuteNonQuery();
                        in_upd.Dispose();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        connection_check();
                    }
                    //MessageBox.Show("Record is successfully Added!", "Record Added Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {


            }

            transfer_report_1();
            textBox10.Text = "";
            dn_tex.Text = "";
            bdn.Text = "";
            Bind_Grid28();
            Bind_Grid22();
            demandlist();
            demandlist_2();
            //demandlist_3();
            Bind_Grid32();
            Bind_Grid27();
            Bind_Grid23();
            Bind_Grid29();


        }

        private void dataGridView20_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            int col = e.ColumnIndex;
            string trqty1 = "";
            string Cqty1 = "";
            string dqty1 = "";
            if (col == 1)
            {


                try
                {
                    iprice = dataGridView20.Rows[rowindex].Cells["i_price3"].Value.ToString();
                }
                catch (Exception ex)
                {
                    iprice = "0";

                }

                for (int b = 0; b < dataGridView20.RowCount; b++)
                {
                    pin = dataGridView20.Rows[b].Cells["ino3"].Value.ToString();
                    if (dataGridView20.Rows[b].Cells["c_qty3"].Value == null || dataGridView20.Rows[b].Cells["c_qty3"].Value == "")
                    {
                        dataGridView20.Rows[b].Cells["c_qty3"].Value = "0";

                    }

                    connection_check();
                    try
                    {
                        MySqlCommand total_qantity = new MySqlCommand("select rema_qty from fsm_voucher_log where ((raw_name ='" + pin + "') and (Status='Finished Goods') and (cost='" + iprice + "') and (branch_n = '" + Login.branch + "')) ", conn);
                        total_qantity.ExecuteNonQuery();
                        MySqlDataReader rd = total_qantity.ExecuteReader();
                        while (rd.Read())
                        {
                            dataGridView20.Rows[b].Cells["c_qty3"].Value = rd[0].ToString();


                        }
                        rd.Dispose();
                    }
                    catch (Exception ex)
                    {

                        connection_check();
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            if (col == 2)
            {
                try
                {

                    trqty1 = dataGridView20.Rows[rowindex].Cells["ttdno3"].Value.ToString();
                }
                catch (Exception ec)
                {
                    // MessageBox.Show(ec.Message);
                }
                try
                {


                    Cqty1 = dataGridView20.Rows[rowindex].Cells["c_qty3"].Value.ToString();

                }
                catch (Exception ec)
                {
                }
                try
                {


                    dqty1 = dataGridView20.Rows[rowindex].Cells["dno3"].Value.ToString();

                }
                catch (Exception ec)
                {
                }
                if (dataGridView20.Rows[rowindex].Cells["c_qty3"].Value == "0")
                {
                    dataGridView20.Rows[rowindex].Cells["ttdno3"].Value = "0";
                    // MessageBox.Show("The current Quantity Is Empty","Error Inviad Quantity",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                if (Convert.ToDouble(trqty1) < 0)
                {
                    dataGridView20.Rows[rowindex].Cells["ttdno3"].Value = "0";
                }
                try
                {

                    trqty1 = dataGridView20.Rows[rowindex].Cells["ttdno3"].Value.ToString();
                }
                catch (Exception ec)
                {
                    // MessageBox.Show(ec.Message);
                }
                try
                {


                    Cqty1 = dataGridView20.Rows[rowindex].Cells["c_qty3"].Value.ToString();

                }
                catch (Exception ec)
                {
                }
                if (Convert.ToDouble(trqty1) <= Convert.ToDouble(Cqty1))
                {
                    dataGridView20.Rows[rowindex].Cells["c_qty3"].Value = Convert.ToDouble(Cqty1) - Convert.ToDouble(trqty1);
                }
                else if (Convert.ToDouble(trqty1) >= Convert.ToDouble(Cqty1))
                {
                    dataGridView20.Rows[rowindex].Cells["ttdno3"].Value = "0";
                }


            }
        }

        private void dataGridView13_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            int col = e.ColumnIndex;
            string trqty1 = "";
            string Cqty1 = "";
            string dqty1 = "";

            //if (col == 2)
            //{


            //    try
            //    {
            //        iprice = dataGridView13.Rows[rowindex].Cells["i_price"].Value.ToString();
            //    }
            //    catch (Exception ex)
            //    {
            //        iprice = "0";

            //    }

            //    for (int b = 0; b < dataGridView13.RowCount; b++)
            //    {
            //        pin = dataGridView13.Rows[b].Cells["ino"].Value.ToString();
            //        if (dataGridView13.Rows[b].Cells["c_qty"].Value == null || dataGridView13.Rows[b].Cells["c_qty"].Value == "")
            //        {
            //            dataGridView13.Rows[b].Cells["c_qty"].Value = "0";

            //        }

            //        connection_check();
            //        try
            //        {
            //            MySqlCommand total_qantity = new MySqlCommand("select rema_qty from fsm_voucher_log where ((raw_name ='" + pin + "') and (cost='" + iprice + "') and (Status='for production') and (branch_n = '" + Login.branch + "')) ", conn);
            //            total_qantity.ExecuteNonQuery();
            //            MySqlDataReader rd = total_qantity.ExecuteReader();
            //            while (rd.Read())
            //            {
            //                dataGridView13.Rows[b].Cells["c_qty"].Value = rd[0].ToString();


            //            }
            //            rd.Dispose();
            //        }
            //        catch (Exception ex)
            //        {

            //            connection_check();
            //            MessageBox.Show(ex.Message);
            //        }

            //    }
            //}
            if (col == 2)
            {
                try
                {

                    trqty1 = dataGridView13.Rows[rowindex].Cells["ttdno"].Value.ToString();
                    if (trqty1 == "") { trqty1 = "0"; }
                }
                catch (Exception ec)
                {
                    trqty1 = "0";
                    // MessageBox.Show(ec.Message);
                }
                try
                {


                    Cqty1 = dataGridView13.Rows[rowindex].Cells["c_qty"].Value.ToString();

                }
                catch (Exception ec)
                {
                }
                try
                {


                    dqty1 = dataGridView13.Rows[rowindex].Cells["dno"].Value.ToString();

                }
                catch (Exception ec)
                {
                }
                if (dataGridView13.Rows[rowindex].Cells["c_qty"].Value == "0")
                {
                    dataGridView13.Rows[rowindex].Cells["ttdno"].Value = "0";
                 }
                try
                {
                    if (trqty1 == "") { trqty1 = "0"; }
                    if (Convert.ToDouble(trqty1) < 0)
                    {
                        dataGridView13.Rows[rowindex].Cells["ttdno"].Value = "0";
                    }
                }
                catch (Exception ee) { }
                try
                {

                    trqty1 = dataGridView13.Rows[rowindex].Cells["ttdno"].Value.ToString();
                }
                catch (Exception ec)
                {
                    //MessageBox.Show(ec.Message);
                }
                try
                {


                    Cqty1 = dataGridView13.Rows[rowindex].Cells["c_qty"].Value.ToString();

                }
                catch (Exception ec)
                {
                }
                if (Convert.ToDouble(trqty1) <= Convert.ToDouble(Cqty1))
                {
                    dataGridView13.Rows[rowindex].Cells["c_qty"].Value = Convert.ToDouble(Cqty1) - Convert.ToDouble(trqty1);
                }
                else if (Convert.ToDouble(trqty1) >= Convert.ToDouble(Cqty1))
                {
                    dataGridView13.Rows[rowindex].Cells["ttdno"].Value = "0";
                }


            }
        }

        private void dataGridView20_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int rowindex = e.RowIndex;
            int col = e.ColumnIndex;
            string tttr = "";
            string cccr = "";
            if (col == 2)
            {
                try
                {

                    tttr = dataGridView20.Rows[rowindex].Cells["ttdno3"].Value.ToString();
                }
                catch (Exception ec)
                {
                    tttr = "0";
                    //dataGridView2.Rows[rowindex].Cells["tr_qty"].Value = "0";
                    //MessageBox.Show(ec.Message);
                }
                try
                {


                    cccr = dataGridView20.Rows[rowindex].Cells["c_qty3"].Value.ToString();

                }
                catch (Exception ec)
                {
                }
                if (dataGridView20.Rows[rowindex].Cells["c_qty3"].Value == "0")
                {
                    dataGridView20.Rows[rowindex].Cells["ttdno3"].Value = "0";
                    // MessageBox.Show("The current Quantity Is Empty","Error Inviad Quantity",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                if (Convert.ToDouble(tttr) < 0)
                {
                    dataGridView20.Rows[rowindex].Cells["ttdno3"].Value = "0";
                }
                try
                {

                    tttr = dataGridView20.Rows[rowindex].Cells["ttdno3"].Value.ToString();
                }
                catch (Exception ec)
                {
                    tttr = "0";
                    //dataGridView2.Rows[rowindex].Cells["tr_qty"].Value = "0";
                    //MessageBox.Show(ec.Message);
                }
                try
                {


                    cccr = dataGridView20.Rows[rowindex].Cells["c_qty3"].Value.ToString();
                   
                }
                catch (Exception ec)
                {
                }
                if (cccr == "") { cccr = "0"; }
                // if (dataGridView20.Rows[rowindex].Cells["c_qty3"].Value != "0" && Convert.ToInt32(tttr) <= Convert.ToInt32(cccr))
                {
                    dataGridView20.Rows[rowindex].Cells["c_qty3"].Value = Convert.ToDouble(cccr) + Convert.ToDouble(tttr);
                }
                if (Convert.ToDouble(tttr) >= Convert.ToDouble(cccr))
                {
                    dataGridView20.Rows[rowindex].Cells["ttdno3"].Value = "0";
                }
                if (dataGridView20.Rows[rowindex].Cells["c_qty3"].Value == "0")
                {
                    dataGridView20.Rows[rowindex].Cells["ttdno3"].Value = "0";
                    // MessageBox.Show("The current Quantity Is Empty","Error Inviad Quantity",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }


            }
        }

        private void dataGridView13_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int rowindex = e.RowIndex;
            int col = e.ColumnIndex;
            string tttr = "";
            string cccr = "";
            if (col == 2)
            {
                try
                {

                    tttr = dataGridView13.Rows[rowindex].Cells["ttdno"].Value.ToString();
                }
                catch (Exception ec)
                {
                    tttr = "0";

                }
                try
                {


                    cccr = dataGridView13.Rows[rowindex].Cells["c_qty"].Value.ToString();

                }
                catch (Exception ec)
                {
                }
                if (Convert.ToDouble(tttr) < 0)
                {
                    dataGridView13.Rows[rowindex].Cells["ttdno"].Value = "0";
                }
                try
                {

                    tttr = dataGridView13.Rows[rowindex].Cells["ttdno"].Value.ToString();
                }
                catch (Exception ec)
                {
                    tttr = "0";
                    //dataGridView2.Rows[rowindex].Cells["tr_qty"].Value = "0";
                    //MessageBox.Show(ec.Message);
                }
                try
                {


                    cccr = dataGridView13.Rows[rowindex].Cells["c_qty"].Value.ToString();

                }
                catch { }

                //if (dataGridView13.Rows[rowindex].Cells["c_qty"].Value != "0" && Convert.ToInt32(tttr) <= Convert.ToInt32(cccr))
                {
                    dataGridView13.Rows[rowindex].Cells["c_qty"].Value = Convert.ToDouble(cccr) + Convert.ToDouble(tttr);
                }
                if (Convert.ToDouble(tttr) >= Convert.ToDouble(cccr))
                {
                    dataGridView13.Rows[rowindex].Cells["ttdno"].Value = "0";
                }
                if (dataGridView13.Rows[rowindex].Cells["c_qty"].Value == "0")
                {
                    dataGridView13.Rows[rowindex].Cells["ttdno"].Value = "0";
                    // MessageBox.Show("The current Quantity Is Empty","Error Inviad Quantity",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }



            }
        }

        private void dn_tex2_TextChanged(object sender, EventArgs e)
        {
            Bind_Grid31();


            Bind_Grid30();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            string ti = System.DateTime.Now.ToString("hh:mm:ss:tt");
            hostName = Dns.GetHostName();
            myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            string iiname = "";
            string ttrqty = "";
            string ccqty = "";
            string crqty = "";
            string pp_cost = "";
            try
            {
                connection_check();
            }
            catch (Exception ex)
            {
            }
            for (int i = 0; i < dataGridView22.RowCount; i++)
            {


                try
                {

                    iiname = dataGridView22.Rows[i].Cells["ino4"].Value.ToString();

                }
                catch (Exception ec)
                {
                }
                try
                {


                    crqty = dataGridView22.Rows[i].Cells["re_qty2"].Value.ToString();

                }
                catch (Exception ec)
                {
                }
                try
                {

                    ttrqty = dataGridView22.Rows[i].Cells["dno4"].Value.ToString();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }

                try
                {
                    connection_check();
                    MySqlCommand itd1 = new MySqlCommand("Update fsm_demand_note set comment='" + textBox7.Text + "', re_qty='" + crqty + "', status='Finished' ,re_date='" + DateTime.Today.ToString("yyyy-MM-dd") + "',re_time='" + ti + "' where itemname='" + iiname + "' and  demand_id ='" + dn_tex2.Text + "'", conn);
                    itd1.ExecuteNonQuery();
                    itd1.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection_check();

                }
                try
                {
                    connection_check();
                    MySqlCommand itd = new MySqlCommand("Update fsm_transfer set status='Finished' where  demand_id ='" + dn_tex2.Text + "' ", conn);
                    itd.ExecuteNonQuery();
                    itd.Dispose();

                }
                catch (Exception ex)
                {

                    connection_check();

                }


                //try
                // {
                //     MySqlCommand sel_deb = new MySqlCommand("select total_kg_p from fsm_voucher where raw_name='" + iiname + "' and branch_n='" + Login.branch + "'", conn);
                //     sel_deb.ExecuteNonQuery();
                //     MySqlDataReader deb_dr = sel_deb.ExecuteReader();
                //     while (deb_dr.Read())
                //     {
                //         sumqty = deb_dr[0].ToString();
                //     }
                //     deb_dr.Dispose();
                // }
                // catch (Exception ex)
                // {

                //     connection_check();

                // } 


                // if (sumqty == null)
                // {
                //connection_check();
                //try
                //{
                try
                {
                    connection_check();
                    MySqlCommand setupalll = new MySqlCommand("Insert into fsm_voucher_log (branch_n,raw_name,total_kg_p,rema_qty,invoice_date,invoice_time,pc_name,domain,Status,login_user) Values('" + Login.branch + "','" + iiname + "','" + crqty + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss:tt") + "' ,'" + hostName + "','" + myIP + "','Received stock Finished','" + Login.user_n + "') ", conn);
                    setupalll.ExecuteNonQuery();
                    setupalll.Dispose();
                }
                catch (Exception ex)
                {

                    connection_check();
                }


                //    }
                //    catch (Exception ex)
                //    {
                //        connection_check();

                //        MessageBox.Show(ex.Message);
                //    }

                //}
                //else if (sumqty != null)
                //{
                //    try
                //    {
                //        connection_check();
                //        qty_t = Convert.ToInt32(crqty) + Convert.ToInt32(sumqty);
                //        MySqlCommand in_upd = new MySqlCommand("Update fsm_voucher set total_kg_p='" + Convert.ToString(qty_t) + "', rema_qty='" + Convert.ToString(qty_t) + "' where (raw_name='" + iiname + "') and (branch_n ='" + Login.branch + "') and (Status='Finished Goods')", conn);
                //        in_upd.ExecuteNonQuery();
                //        in_upd.Dispose();

                //    }
                //    catch (Exception ex)
                //    {
                //    }


                //}
                //try
                //{
                //    MySqlCommand sel_deb = new MySqlCommand("select qty from fsm_mainstore where item='" + iiname + "' and branch_n='" + Login.branch + "'", conn);
                //    sel_deb.ExecuteNonQuery();
                //    MySqlDataReader deb_dr = sel_deb.ExecuteReader();
                //    while (deb_dr.Read())
                //    {
                //        ccqty = deb_dr[0].ToString();
                //    }
                //    deb_dr.Dispose();
                //}
                //catch (Exception ex)
                //{

                //    connection_check();

                //}

                //if (ccqty == null || ccqty == "")
                //{
                //    connection_check();

                //try
                //{
                //    connection_check();
                //    MySqlCommand setupalll4 = new MySqlCommand("Insert into fsm_voucher (branch_n,raw_name,total_kg_p,invoice_date,invoice_time,pc_name,domain,Status,login_user) Values('" + Login.branch + "','" + iiname + "','" + crqty + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss:tt") + "' ,'" + hostName + "','" + myIP + "','Received finish stock','" + Login.user_n + "') ", conn);
                //    setupalll4.ExecuteNonQuery();
                //    setupalll4.Dispose();
                //}
                //catch (Exception ex)
                //{

                //    connection_check();
                //}
                //    connection_check();

                //    try
                //    {
                //        connection_check();
                //        MySqlCommand setupalll5 = new MySqlCommand("Insert into fsm_mainstore (branch_n,item,qty,ms_data,ms_time,pc_name,domain,Status,login_user) Values('" + Login.branch + "','" + iiname + "','" + crqty + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss:tt") + "' ,'" + hostName + "','" + myIP + "','Received finish stock','" + Login.user_n + "') ", conn);
                //        setupalll5.ExecuteNonQuery();
                //        setupalll5.Dispose();
                //    }
                //    catch (Exception ex)
                //    {

                //        connection_check();
                //    }
                //}
                //else if (ccqty != null || ccqty != "")
                //{
                //    try
                //    {
                //        connection_check();
                //        qty_t = Convert.ToInt32(crqty) + Convert.ToInt32(ccqty);
                //        MySqlCommand in_upd = new MySqlCommand("Update fsm_voucher set total_kg_p='" + Convert.ToString(qty_t) + "', rema_qty='" + Convert.ToString(qty_t) + "' where (raw_name='" + iiname + "') and (branch_n ='" + Login.branch + "') and Status='Finished Goods'", conn);
                //        in_upd.ExecuteNonQuery();
                //        in_upd.Dispose();
                //    }
                //    catch (Exception ex)
                //    {


                //    }
                //    try
                //    {
                //        connection_check();
                //        qty_t = Convert.ToInt32(crqty) + Convert.ToInt32(ccqty);
                //        MySqlCommand in_upd = new MySqlCommand("Update fsm_mainstore set qty='" + Convert.ToString(qty_t) + "' where (item='" + iiname + "') and (branch_n ='" + Login.branch + "') ", conn);
                //        in_upd.ExecuteNonQuery();
                //        in_upd.Dispose();
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show(ex.Message);

                //    }

                //}



                //MessageBox.Show("Record is successfully Added!", "Record Added Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            received_report_fg();
            dn_tex2.Text = "";
            Bind_Grid31();
            Bind_Grid30();
            Bind_Grid29();
            Bind_Grid32();
            textBox6.Text = "Type Description Here ...";
            textBox6.ForeColor = Color.DimGray;
            textBox7.Text = "Type Description Here ...";
            textBox7.ForeColor = Color.DimGray;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string ti = System.DateTime.Now.ToString("hh:mm:ss:tt");
            hostName = Dns.GetHostName();
            myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            string iiname = "";
            string ttrqty = "";
            string ccqty = "";
            string crqty = "";
            string pp_cost = "";
            try
            {
                connection_check();
            }
            catch (Exception ex)
            {
            }
            for (int i = 0; i < dataGridView18.RowCount; i++)
            {


                try
                {

                    iiname = dataGridView18.Rows[i].Cells["ino2"].Value.ToString();

                }
                catch (Exception ec)
                {
                }
                try
                {


                    crqty = dataGridView18.Rows[i].Cells["re_qty"].Value.ToString();

                }
                catch (Exception ec)
                {
                }
                try
                {

                    ttrqty = dataGridView18.Rows[i].Cells["dno2"].Value.ToString();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }

                try
                {
                    connection_check();
                    MySqlCommand itd = new MySqlCommand("Update fsm_demand_note set comment='" + textBox6.Text + "', re_qty='" + crqty + "', status='Finished',re_date='" + DateTime.Today.ToString("yyyy-MM-dd") + "',re_time='" + ti + "' where itemname='" + iiname + "' and demand_id ='" + dn_tex2.Text + "'  ", conn);
                    itd.ExecuteNonQuery();
                    itd.Dispose();

                }
                catch (Exception ex)
                {

                    connection_check();

                }
                try
                {
                    connection_check();
                    MySqlCommand itd = new MySqlCommand("Update fsm_transfer set status='Finished' where  demand_id ='" + dn_tex2.Text + "' ", conn);
                    itd.ExecuteNonQuery();
                    itd.Dispose();

                }
                catch (Exception ex)
                {

                    connection_check();

                }

                //try
                //{
                //    MySqlCommand sel_deb = new MySqlCommand("select total_kg_p from fsm_voucher where raw_name='" + iiname + "' and branch_n='" + Login.branch + "'", conn);
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

                //    connection_check();

                //}


                //if (sumqty == null)
                //{
                //    connection_check();
                //    try
                //    {
                try
                {
                    connection_check();
                    MySqlCommand setupalll = new MySqlCommand("Insert into fsm_voucher_log (branch_n,raw_name,total_kg_p,rema_qty,invoice_date,invoice_time,pc_name,domain,Status,login_user,) Values('" + Login.branch + "','" + iiname + "','" + crqty + "','" + crqty + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("hh:mm:ss:tt") + "' ,'" + hostName + "','" + myIP + "','Received stock raw','" + Login.user_n + "') ", conn);
                    setupalll.ExecuteNonQuery();
                    setupalll.Dispose();
                }
                catch (Exception ex)
                {

                    connection_check();
                }


                //}
                //    catch (Exception ex)
                //    {
                //        connection_check();

                //        MessageBox.Show(ex.Message);
                //    }

                //}
                //else if (sumqty != null)
                //{
                //    connection_check();
                //    qty_t = Convert.ToInt32(crqty) + Convert.ToInt32(sumqty);
                //    MySqlCommand in_upd = new MySqlCommand("Update fsm_voucher_log set total_kg_p='" + Convert.ToString(qty_t) + "', rema_qty='" + Convert.ToString(qty_t) + "' where (raw_name='" + iiname + "') and (branch_n ='" + Login.branch + "') and (Status!='Finished Goods') ", conn);
                //    in_upd.ExecuteNonQuery();
                //    in_upd.Dispose();

                //}



                //MessageBox.Show("Record is successfully Added!", "Record Added Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            received_report_rw();
            dn_tex2.Text = "";
            Bind_Grid31();
            Bind_Grid30();
            Bind_Grid29();
            Bind_Grid32();
            textBox6.Text = "Type Description Here ...";
            textBox6.ForeColor = Color.DimGray;
            textBox7.Text = "Type Description Here ...";
            textBox7.ForeColor = Color.DimGray;

        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Type Description Here ...")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Type Description Here ...";
                textBox6.ForeColor = Color.DimGray;
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "Type Description Here ...")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.Black;
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "Type Description Here ...";
                textBox7.ForeColor = Color.DimGray;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void bcom_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox8.Text = bcom.Text;

        }

        private void search_boxs_Leave(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView15.RowCount; i++)
            {
                dnido = dataGridView15.Rows[i].Cells["r_m"].Value.ToString();
                if (dataGridView15.Rows[i].DefaultCellStyle.BackColor == Color.FromArgb(255, 249, 196))
                {
                    dataGridView15.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    dataGridView15.Focus();
                }
            }
            //for (int j = 0; j < dataGridView16.RowCount; j++)
            //{
            //    dnido = dataGridView16.Rows[j].Cells["rr_m"].Value.ToString();
            //    if (dataGridView16.Rows[j].DefaultCellStyle.BackColor == Color.FromArgb(255, 249, 196))
            //    {
            //        dataGridView16.Rows[j].DefaultCellStyle.BackColor = Color.White;
            //        dataGridView16.Focus();
            //    }
            //}

        }

        private void search_boxs_TextChanged(object sender, EventArgs e)
        {
            if (search_boxs.Text != "")
            {
                for (int i = 0; i < dataGridView15.RowCount; i++)
                {
                    dnido = dataGridView15.Rows[i].Cells["r_m"].Value.ToString();
                    if (dnido == search_boxs.Text)
                    {
                        dataGridView15.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 249, 196);
                        dataGridView15.Focus();
                        dataGridView15.CurrentCell = dataGridView15[1, i];
                        //dataGridView15.CurrentRow.Cells["dn"].Selected = true;
                        //
                    }
                }
                //for (int j = 0; j < dataGridView16.RowCount; j++)
                //{
                //    dnido = dataGridView16.Rows[j].Cells["rr_m"].Value.ToString();
                //    if (dnido == search_boxs.Text)
                //    {
                //        dataGridView16.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(255, 249, 196);
                //        dataGridView16.Focus();
                //        dataGridView16.CurrentCell = dataGridView16[1, j];
                //        //dataGridView15.CurrentRow.Cells["dn"].Selected = true;
                //    }
                //}
            }

        }
        public DataSet SelectAll33()
        {
            string date1 = dateTimePicker5.Value.ToString("yyyy-MM-dd");
            string date2 = dateTimePicker6.Value.ToString("yyyy-MM-dd");
            DataSet ds_2 = new DataSet();

            try
            {
                MySqlCommand cmd_2 = new MySqlCommand("select DISTINCT(demand_id),demand_type,status,branch_n,branch,dn_date,re_date,tr_date  from fsm_demand_note where (dn_date >='" + date1 + "') and (dn_date <='" + date2 + "') and (branch_n = '" + Login.branch + "')", conn);
                MySqlDataAdapter daa_2 = new MySqlDataAdapter(cmd_2);

                daa_2.Fill(ds_2);

                cmd_2.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ds_2;


        }

        private void Bind_Grid33()
        {
            try
            {
                DataSet Ds_2;

                Ds_2 = this.SelectAll33();

                dataGridView23.DataSource = Ds_2.Tables[0];
            }
            catch (Exception ex)
            {
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            Bind_Grid33();

        }

        private void textBox10_Enter(object sender, EventArgs e)
        {
            if (textBox10.Text == "Type Description Here ...")
            {
                textBox10.Text = "";
                textBox10.ForeColor = Color.Black;
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                textBox10.Text = "Type Description Here ...";
                textBox10.ForeColor = Color.DimGray;
            }
        }

        private void textBox11_Enter(object sender, EventArgs e)
        {
            if (textBox11.Text == "Type Description Here ...")
            {
                textBox11.Text = "";
                textBox11.ForeColor = Color.Black;
            }
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                textBox11.Text = "Type Description Here ...";
                textBox11.ForeColor = Color.DimGray;
            }
        }

        private void dataGridView19_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView19_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                dn_tex3.Text = dataGridView19.Rows[e.RowIndex].Cells["dbp"].Value.ToString();

            }
            catch (Exception ex)
            {


            }
            try
            {

                bdn3.Text = dataGridView19.Rows[e.RowIndex].Cells["bno2"].Value.ToString();

            }
            catch (Exception ex)
            {


            }


        }

        private void groupBox14_Enter(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

            Pd_create.Enabled = true;
            Dep_create.Enabled = true;
            item_add.Enabled = true;
            btn_plus_dep.Enabled = true;
            btn_minus_dep.Enabled = true;
            btn_plus_pd.Enabled = true;
            btn_minus_pd.Enabled = true;
            btn_plus_item.Enabled = true;
            edit_dep.Enabled = true;
            edit_pd.Enabled = true;
            edit_it.Enabled = true;
            s.Enabled = true;
            texdep.Text = "";
            texpd.Text = "";
            texit.Text = "";
            Pd_create.Text = "";
            Dep_create.Text = "";
            item_add.Text = "";
            Bind_Grid177();


        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            Bind_Grid39();
            //int count = dataGridView24.Rows.Count;

            //    for (int jj = 0; jj < count; jj++)
            //    {
            //        try
            //        {

            //            string tempitem = dataGridView16.Rows[jj].Cells["rr_m"].Value.ToString();
            //            connection_check();
            //            MySqlCommand axx = new MySqlCommand("select sum(qty) from fsm_mainstore where (branch_n ='" + bn[k] + "')and (item='" + tempitem + "')", conn);
            //            axx.ExecuteNonQuery();
            //            MySqlDataReader dtr = axx.ExecuteReader();
            //            while (dtr.Read())
            //            {
            //                dataGridView16.Rows[jj].Cells[k].Value = dtr[0].ToString();
            //            }
            //            axx.Dispose();
            //            dtr.Dispose();
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //        }


            //    }

            //    k++;

        }

        private void button22_Click(object sender, EventArgs e)
        {
            //    string[] bn = new string[5000];
            //    int m = 0;
            //    int no = 0;

            //    try
            //    {
            //        connection_check();
            //        MySqlCommand axx = new MySqlCommand("select DISTINCT(cat_name) from depitem ", conn);
            //        axx.ExecuteNonQuery();
            //        MySqlDataReader dtr = axx.ExecuteReader();
            //        while (dtr.Read())
            //        {
            //            bn[m] = dtr[0].ToString();

            //            m++;
            //        }
            //        axx.Dispose();
            //        dtr.Dispose();
            //    }
            //    catch (Exception ex)
            //    {
            //    }
            //     for (int i = 0; i < m ; i++)
            //{

            //     MySqlCommand itd_1 = new MySqlCommand("insert into fsm_pro_pricing (cat_name) Values('" +  bn[i] + "')", conn);
            //    itd_1.ExecuteNonQuery();
            //    itd_1.Dispose();
            //}

        }

        private void dataGridView24_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            int col = e.ColumnIndex;
            string bco = "";
            string pit = "";
            string rit = "";
            string sumqty2 = "";

            if (col == 0)
            {
                try
                {

                    bco = dataGridView24.Rows[rowindex].Cells["bcode"].Value.ToString();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
                try
                {


                    pit = dataGridView24.Rows[rowindex].Cells["pi"].Value.ToString();

                }
                catch (Exception ec)
                {
                }

                try
                {
                    MySqlCommand sel_deb2 = new MySqlCommand("select barcode from fsm_pro_pricing where cat_name='" + pit + "' ", conn);
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
                    MessageBox.Show(ex.Message);
                    connection_check();

                }
                if (sumqty2 == bco)
                {
                    MessageBox.Show("Barcode Already exist!", "Inviald Barcode", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (sumqty2 != bco)
                {
                    try
                    {
                        connection_check();
                        MySqlCommand itd_1 = new MySqlCommand("update fsm_pro_pricing set barcode='" + bco + "',retial_price='" + rit + "' where cat_name='" + pit + "'", conn);
                        itd_1.ExecuteNonQuery();
                        itd_1.Dispose();
                        Bind_Grid39();

                    }
                    catch (Exception ex)
                    {


                    }
                    try
                    {
                        connection_check();
                        MySqlCommand itd_11 = new MySqlCommand("update fsm_mainstore set barcode='" + bco + "' where item='" + pit + "'", conn);
                        itd_11.ExecuteNonQuery();
                        itd_11.Dispose();
                        Bind_Grid19();
                    }
                    catch (Exception ex)
                    {
                        // MessageBox.Show(ex.Message);

                    }
                }

            }
            if (col == 2)
            {
                try
                {

                    bco = dataGridView24.Rows[rowindex].Cells["bcode"].Value.ToString();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
                try
                {


                    pit = dataGridView24.Rows[rowindex].Cells["pi"].Value.ToString();

                }
                catch (Exception ec)
                {
                }
                try
                {


                    rit = dataGridView24.Rows[rowindex].Cells["ri"].Value.ToString();

                }
                catch (Exception ec)
                {
                }
                try
                {
                    MySqlCommand sel_deb2 = new MySqlCommand("select barcode from fsm_pro_pricing where cat_name='" + pit + "' ", conn);
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
                    MessageBox.Show(ex.Message);
                    connection_check();

                }
                if (sumqty2 == bco)
                {

                }
                else if (sumqty2 != bco)
                {
                    try
                    {
                        connection_check();
                        MySqlCommand itd_1 = new MySqlCommand("update fsm_pro_pricing set barcode='" + bco + "',retial_price='" + rit + "' where cat_name='" + pit + "'", conn);
                        itd_1.ExecuteNonQuery();
                        itd_1.Dispose();
                        Bind_Grid39();

                    }
                    catch (Exception ex)
                    {


                    }
                    try
                    {
                        connection_check();
                        MySqlCommand itd_11 = new MySqlCommand("update fsm_mainstore set barcode='" + bco + "' where item='" + pit + "'", conn);
                        itd_11.ExecuteNonQuery();
                        itd_11.Dispose();
                        Bind_Grid19();
                    }
                    catch (Exception ex)
                    {
                        // MessageBox.Show(ex.Message);

                    }
                }


            }
        }

        private void ser_pro_TextChanged(object sender, EventArgs e)
        {
            if (ser_pro.Text != "")
            {
                for (int i = 0; i < dataGridView24.RowCount; i++)
                {
                    dnido = dataGridView24.Rows[i].Cells["pi"].Value.ToString();
                    if (dnido == ser_pro.Text)
                    {

                        dataGridView24.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 249, 196);
                        // dataGridView15.Focus(i,);
                        dataGridView24.Focus();
                        dataGridView24.CurrentCell = dataGridView24[1, i];
                        //dataGridView24.CurrentRow.Cells["bcode"].Selected = true;
                        //
                    }
                }
            }





        }



        private void ser_pro_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView24.RowCount; i++)
            {
                dnido = dataGridView24.Rows[i].Cells["pi"].Value.ToString();
                if (dataGridView24.Rows[i].DefaultCellStyle.BackColor == Color.FromArgb(255, 249, 196))
                {
                    dataGridView24.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    dataGridView24.Focus();
                }
            }
        }

        private void listView5_Click(object sender, EventArgs e)
        {
            tex_dnid.Text = listView5.SelectedItems[0].SubItems[0].Text;
            bename.Text = listView5.SelectedItems[0].SubItems[1].Text;
            demand_report_view();
            btn_cancel.Enabled = true;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            report_2();
        }

        private void dataGridView14_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                Dep_create.Text = dataGridView14.Rows[e.RowIndex].Cells["dbno"].Value.ToString();

            }
            catch (Exception ex)
            {


            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            int bco = 10000;
            int count = dataGridView24.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                bco++;
                dataGridView24.Rows[i].Cells["bcode"].Value = Convert.ToString(bco);
            }
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            string b_co = "";
            string r_co = "";
            string p_co = "";
            string sumqty2 = "";
            int count = dataGridView24.Rows.Count;
            for (int i = 0; i < count; i++)
            {

                b_co = dataGridView24.Rows[i].Cells["bcode"].Value.ToString();
                r_co = dataGridView24.Rows[i].Cells["ri"].Value.ToString();
                p_co = dataGridView24.Rows[i].Cells["pi"].Value.ToString();


                try
                {
                    MySqlCommand sel_deb2 = new MySqlCommand("select barcode from fsm_pro_pricing where cat_name='" + p_co + "' ", conn);
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
                    MessageBox.Show(ex.Message);
                    connection_check();

                }
                if (sumqty2 == b_co)
                {
                    MessageBox.Show("Barcode Already exist!", "Inviald Barcode", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (sumqty2 != b_co)
                {

                    connection_check();
                    try
                    {
                        //connection_check();

                        MySqlCommand itd_1 = new MySqlCommand("update fsm_pro_pricing set barcode='" + b_co + "',retial_price='" + r_co + "' where cat_name='" + p_co + "'", conn);
                        itd_1.ExecuteNonQuery();
                        itd_1.Dispose();
                        // connection_check();

                    }
                    catch (Exception ex)
                    {


                    }
                    connection_check();
                    try
                    {
                        // connection_check();
                        MySqlCommand itd_11 = new MySqlCommand("update fsm_mainstore set barcode='" + b_co + "' where item='" + p_co + "'", conn);
                        itd_11.ExecuteNonQuery();
                        itd_11.Dispose();
                        //connection_check();
                        Bind_Grid19();

                    }
                    catch (Exception ex)
                    {


                    }
                }

            }
            Bind_Grid39();
            Bind_Grid19();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            pur_report_2();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            current_report_2();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            suppliers_details_2();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            item_details_2();
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            report_3();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            Bind_Grid29();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            connection_check();
            try
            {
                if (tex_dnid.Text != "")
                {
                    connection_check();
                    MySqlCommand setupall3 = new MySqlCommand("Delete  from fsm_demand_note where demand_id='" + tex_dnid.Text + "' and branch_n = '" + Login.branch + "' ", conn);
                    setupall3.ExecuteNonQuery();
                    setupall3.Dispose();
                    tex_dnid.Text = "";
                    btn_cancel.Enabled = false;
                    demandlist();

                }
            }
            catch (Exception ex)
            {


            }
        }

        public void demand_report_view_2()
        {
            connection_check();
            try
            {
                DataSet ddd = new DataSet();
                DataTable dtdd = ddd.Tables.Add("transfer_to");


                dtdd.Columns.Add("dn_date", Type.GetType("System.String"));
                dtdd.Columns.Add("dn_time", Type.GetType("System.String"));
                dtdd.Columns.Add("item", Type.GetType("System.String"));
                dtdd.Columns.Add("from_b", Type.GetType("System.String"));
                dtdd.Columns.Add("to_b", Type.GetType("System.String"));
                dtdd.Columns.Add("demand", Type.GetType("System.String"));
                dtdd.Columns.Add("demandid", Type.GetType("System.String"));


                try
                {
                    DataRow rddd;
                    connection_check();
                    MySqlCommand commander = new MySqlCommand("select itemname,dn_date,dn_time,demand_qty,branch,demand_id from fsm_demand_note where ((dn_date between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "')  and (branch_n ='" + Login.branch + "'));", conn);
                    commander.ExecuteNonQuery();
                    MySqlDataReader reader = commander.ExecuteReader();
                    while (reader.Read())
                    {
                        rddd = dtdd.NewRow();
                        string aa = reader[0].ToString();
                        rddd["item"] = aa;
                        rddd["dn_date"] = reader[1].ToString();
                        rddd["dn_time"] = reader[2].ToString();
                        rddd["demand"] = reader[3].ToString();
                        rddd["to_b"] = "All";//reader[4].ToString();
                        rddd["demandid"] = reader[5].ToString();
                        rddd["from_b"] = Login.branch;

                        dtdd.Rows.Add(rddd);

                    }
                    reader.Dispose();
                    commander.Dispose();

                    demanding ar = new demanding();
                    ar.SetDataSource(dtdd);
                    report_view vv = new report_view();

                    vv.crystalReportViewer1.ReportSource = ar;
                    vv.crystalReportViewer1.Refresh();
                    vv.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);


                }



            }
            catch (Exception ex)
            {

                // MessageBox.Show(ex.Message);
            }


        }
        public void demand_report_view_3()
        {
            connection_check();
            try
            {
                DataSet ddd = new DataSet();
                DataTable dtdd = ddd.Tables.Add("transfer_to");


                dtdd.Columns.Add("dn_date", Type.GetType("System.String"));
                dtdd.Columns.Add("dn_time", Type.GetType("System.String"));
                dtdd.Columns.Add("item", Type.GetType("System.String"));
                dtdd.Columns.Add("from_b", Type.GetType("System.String"));
                dtdd.Columns.Add("to_b", Type.GetType("System.String"));
                dtdd.Columns.Add("demand", Type.GetType("System.String"));
                dtdd.Columns.Add("demandid", Type.GetType("System.String"));


                try
                {
                    DataRow rddd;
                    connection_check();
                    MySqlCommand commander = new MySqlCommand("select itemname,dn_date,dn_time,demand_qty,branch,demand_id from fsm_demand_note where ((dn_date between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "')  and (branch_n ='" + Login.branch + "')and (branch='" + b_name.Text + "'));", conn);
                    commander.ExecuteNonQuery();
                    MySqlDataReader reader = commander.ExecuteReader();
                    while (reader.Read())
                    {
                        rddd = dtdd.NewRow();
                        string aa = reader[0].ToString();
                        rddd["item"] = aa;
                        rddd["dn_date"] = reader[1].ToString();
                        rddd["dn_time"] = reader[2].ToString();
                        rddd["demand"] = reader[3].ToString();
                        rddd["to_b"] = b_name.Text;
                        rddd["demandid"] = reader[5].ToString();
                        rddd["from_b"] = Login.branch;

                        dtdd.Rows.Add(rddd);

                    }
                    reader.Dispose();
                    commander.Dispose();

                    demanding ar = new demanding();
                    ar.SetDataSource(dtdd);
                    report_view vv = new report_view();

                    vv.crystalReportViewer1.ReportSource = ar;
                    vv.crystalReportViewer1.Refresh();
                    vv.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);


                }



            }
            catch (Exception ex)
            {

                // MessageBox.Show(ex.Message);
            }


        }
        public void demand_status_report_view()
        {
            connection_check();
            try
            {
                DataSet ddd = new DataSet();
                DataTable dtdd = ddd.Tables.Add("transfer_to");

                dtdd.Columns.Add("tr_date", Type.GetType("System.String"));
                dtdd.Columns.Add("tr_time", Type.GetType("System.String"));
                dtdd.Columns.Add("re_date", Type.GetType("System.String"));
                dtdd.Columns.Add("re_time", Type.GetType("System.String"));
                dtdd.Columns.Add("dn_date", Type.GetType("System.String"));
                dtdd.Columns.Add("dn_time", Type.GetType("System.String"));
                dtdd.Columns.Add("item", Type.GetType("System.String"));
                dtdd.Columns.Add("from_b", Type.GetType("System.String"));
                dtdd.Columns.Add("to_b", Type.GetType("System.String"));
                dtdd.Columns.Add("demand", Type.GetType("System.String"));
                dtdd.Columns.Add("transfer", Type.GetType("System.String"));
                dtdd.Columns.Add("re", Type.GetType("System.String"));
                dtdd.Columns.Add("discribtion", Type.GetType("System.String"));
                //dtdd.Columns.Add("discribtion2", Type.GetType("System.String"));
                dtdd.Columns.Add("demandid", Type.GetType("System.String"));
                dtdd.Columns.Add("status", Type.GetType("System.String"));
                dtdd.Columns.Add("dalayed_d", Type.GetType("System.String"));
                dtdd.Columns.Add("dalayed_t", Type.GetType("System.String"));


                try
                {
                    DataRow rddd;
                    connection_check();
                    MySqlCommand commander = new MySqlCommand("select DISTINCT(demand_id),dn_date,dn_time,demand_type,tr_date,tr_time,re_date,re_time,status from fsm_demand_note where branch_n='" + Login.branch + "';", conn);
                    commander.ExecuteNonQuery();
                    MySqlDataReader reader = commander.ExecuteReader();
                    while (reader.Read())
                    {
                        rddd = dtdd.NewRow();
                        rddd["demandid"] = reader[0].ToString();
                        string dd = reader[1].ToString();
                        rddd["dn_date"] = dd;
                        string dt = reader[2].ToString();
                        rddd["dn_time"] = dt;
                        rddd["demand"] = reader[3].ToString();
                        rddd["tr_date"] = reader[4].ToString();
                        rddd["tr_time"] = reader[5].ToString();
                        string rd = reader[6].ToString();
                        rddd["re_date"] = rd;
                        string rt = reader[7].ToString();
                        rddd["re_time"] = rt;
                        rddd["status"] = reader[8].ToString();
                        rddd["from_b"] = Login.branch;
                        rddd["to_b"] = "All";
                        dtdd.Rows.Add(rddd);

                    }
                    reader.Dispose();
                    commander.Dispose();

                    demand_s ar = new demand_s();
                    ar.SetDataSource(dtdd);
                    report_view vv = new report_view();

                    vv.crystalReportViewer1.ReportSource = ar;
                    vv.crystalReportViewer1.Refresh();
                    vv.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);


                }



            }
            catch (Exception ex)
            {

                // MessageBox.Show(ex.Message);
            }


        }
        public void demand_status_report_view_2()
        {
            connection_check();
            try
            {
                DataSet ddd = new DataSet();
                DataTable dtdd = ddd.Tables.Add("transfer_to");

                dtdd.Columns.Add("tr_date", Type.GetType("System.String"));
                dtdd.Columns.Add("tr_time", Type.GetType("System.String"));
                dtdd.Columns.Add("re_date", Type.GetType("System.String"));
                dtdd.Columns.Add("re_time", Type.GetType("System.String"));
                dtdd.Columns.Add("dn_date", Type.GetType("System.String"));
                dtdd.Columns.Add("dn_time", Type.GetType("System.String"));
                dtdd.Columns.Add("item", Type.GetType("System.String"));
                dtdd.Columns.Add("from_b", Type.GetType("System.String"));
                dtdd.Columns.Add("to_b", Type.GetType("System.String"));
                dtdd.Columns.Add("demand", Type.GetType("System.String"));
                dtdd.Columns.Add("transfer", Type.GetType("System.String"));
                dtdd.Columns.Add("re", Type.GetType("System.String"));
                dtdd.Columns.Add("discribtion", Type.GetType("System.String"));
                //dtdd.Columns.Add("discribtion2", Type.GetType("System.String"));
                dtdd.Columns.Add("demandid", Type.GetType("System.String"));
                dtdd.Columns.Add("status", Type.GetType("System.String"));



                try
                {
                    DataRow rddd;
                    connection_check();
                    MySqlCommand commander = new MySqlCommand("select DISTINCT(demand_id),dn_date,dn_time,demand_type,tr_date,tr_time,re_date,re_time,status,branch from fsm_demand_note where ((dn_date between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "')and(branch_n='" + Login.branch + "')and (branch='" + comboBox5.Text + "')) ;", conn);
                    commander.ExecuteNonQuery();
                    MySqlDataReader reader = commander.ExecuteReader();
                    while (reader.Read())
                    {
                        rddd = dtdd.NewRow();
                        rddd["demandid"] = reader[0].ToString();
                        rddd["dn_date"] = reader[1].ToString();
                        rddd["dn_time"] = reader[2].ToString();
                        rddd["demand"] = reader[3].ToString();
                        rddd["tr_date"] = reader[4].ToString();
                        rddd["tr_time"] = reader[5].ToString();
                        rddd["re_date"] = reader[6].ToString();
                        rddd["re_time"] = reader[7].ToString();
                        rddd["status"] = reader[8].ToString();
                        rddd["from_b"] = Login.branch;
                        rddd["to_b"] = comboBox5.Text;

                        dtdd.Rows.Add(rddd);

                    }
                    reader.Dispose();
                    commander.Dispose();

                    demand_s ar = new demand_s();
                    ar.SetDataSource(dtdd);
                    report_view vv = new report_view();

                    vv.crystalReportViewer1.ReportSource = ar;
                    vv.crystalReportViewer1.Refresh();
                    vv.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);


                }



            }
            catch (Exception ex)
            {

                // MessageBox.Show(ex.Message);
            }


        }
        private void button57_Click(object sender, EventArgs e)
        {
            demand_report_view_2();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            demand_report_view_3();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            demand_status_report_view();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            demand_status_report_view_2();
        }

        private void bran_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            bran_name.Text = bran_box.Text;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (active_branch.Checked == true)
            {
                bran_box.Enabled = true;
            }
            else if (active_branch.Checked == false)
            {
                bran_name.Text = Login.branch;
            }
        }


        private void innum_tex_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void new_btn_2_Click(object sender, EventArgs e)
        {
            label2.Text = "0";
            label4.Text = "0";
            raw_ibox.Text = "";
            invoice_id.Text = "";
            company_box.Text = "";
            inv_num.Text = "";
            id_code_text.Text = "";
            Bind_Grid2();
            Bind_Grid2_2();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            label128.Text = "0";
            label130.Text = "0";
            cb_dep.Text = "";
            cb_pd.Text = "";
            txt_bat.Text = "";
            Bind_Grid3();
            Bind_Grid5_5();
            up_label.Visible = false;
            fsm_pro_listviewer();
            fsm_mainlist();
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid. ")
            {

                object value = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dataGridView2.Columns[e.ColumnIndex]).Items.Contains(value))
                {

                    ((DataGridViewComboBoxColumn)dataGridView2.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = true;
                }

            }
        }

        private void raw_ibox_Enter(object sender, EventArgs e)
        {

        }

        private void raw_ibox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                if (raw_ibox.Text != "")
                {
                    try
                    {
                        connection_check();
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



        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                connection_check();
                int row = e.RowIndex;
                int col = e.ColumnIndex;
                string ab = "";
                string bbc = "";
                string tc = "";
                string trqty1 = "";
                string Cqty1 = "";

                if (col == 1)
                {
                    if (dataGridView3.Columns[col].Name == "cahangeit")
                    {
                        // string cellValue = dataGridView3.Rows[row].Cells["cahangeit"].Value.ToString();
                        try
                        {

                            trqty1 = dataGridView3.Rows[row].Cells["Item_n"].Value.ToString();
                            if (trqty1 == null || trqty1 == "")
                            {
                                trqty1 = "0";
                            }
                            dg_it.Text = trqty1;

                        }
                        catch (Exception ec)
                        {
                            // MessageBox.Show(ec.Message);
                        }
                        try
                        {


                            Cqty1 = dataGridView3.Rows[row].Cells["rem_qty"].Value.ToString();
                            if (Cqty1 == null || Cqty1 == "")
                            {
                                Cqty1 = "0";
                            }
                            dg_cq.Text = Cqty1;
                            dg_ocq.Text = Cqty1;

                        }
                        catch (Exception ec)
                        {
                        }
                        try
                        {


                            ab = dataGridView3.Rows[row].Cells["icost"].Value.ToString();
                            if (ab == null || ab == "")
                            {
                                ab = "0";
                            }
                            dg_ip.Text = ab;
                            dg_oit.Text = ab;
                        }
                        catch (Exception ec)
                        {
                        }
                        try
                        {


                            bbc = dataGridView3.Rows[row].Cells["item_qty"].Value.ToString();
                            if (bbc == null || bbc == "")
                            {
                                bbc = "0";
                            }
                            dg_tq.Text = bbc;
                            dg_ntq.Text = bbc;
                        }
                        catch (Exception ec)
                        {
                        }

                        try
                        {
                            connection_check();
                            dg_gp.Items.Clear();

                            MySqlCommand com_name = new MySqlCommand("select cost from fsm_voucher_log where (raw_name ='" + trqty1 + "') and (branch_n ='" + Login.branch + "') ", conn);
                            com_name.ExecuteNonQuery();
                            MySqlDataReader rd = com_name.ExecuteReader();
                            while (rd.Read())
                            {
                                dg_gp.Items.Add(rd[0].ToString());
                            }
                            rd.Dispose();
                        }
                        catch (Exception ex)
                        {
                            connection_check();

                        }
                        panel_status = e.RowIndex;
                        Changer_price.Visible = true;


                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);

            }

        }



        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{

            //    connection_check();
            //    int row = e.RowIndex;
            //    int col = e.ColumnIndex;
            //    if (col == 2)
            //    {


            //        pin2 = dataGridView2.Rows[row].Cells["itemname"].Value.ToString();
            //        if (dataGridView2.Rows[row].Cells["open_cost"].Value == null || dataGridView2.Rows[row].Cells["open_cost"].Value == "")
            //        {
            //            dataGridView2.Rows[row].Cells["open_cost"].Value = "0";
            //            dataGridView2.Rows[row].Cells["c_quantity"].Value = "0";
            //        }

            //        try
            //        {
            //            connection_check();
            //            MySqlCommand item_price = new MySqlCommand("select cost from fsm_voucher_log where (raw_name ='" + pin2 + "') and (branch_n ='" + Login.branch + "') ", conn);
            //            item_price.ExecuteNonQuery();
            //            MySqlDataReader rd1;
            //            try
            //            {
            //                DataGridViewComboBoxCell dgvCmbCell;
            //                dgvCmbCell = (DataGridViewComboBoxCell)dataGridView2.Rows[row].Cells[col];
            //                dgvCmbCell.Items.Clear();
            //                dgvCmbCell.Value = null;
            //                And make your loop 
            //                Price.Items.Clear();
            //                rd1 = item_price.ExecuteReader();
            //                while (rd1.Read())
            //                {
            //                    dgvCmbCell.Items.Add(rd1[0].ToString());
            //                    dgvCmbCell.Value = rd1[0].ToString();
            //                }
            //                rd1.Dispose();

            //            }
            //            catch (Exception ex)
            //            {

            //                connection_check();
            //                MessageBox.Show(ex.Message);
            //            }

            //        }
            //        catch (Exception ex)
            //        {


            //        }
            //    }
            //}
            //catch (Exception ex)
            //{


            //}
        }

        private void dataGridView13_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                int col = e.ColumnIndex;
                if (col == 1)
                {
                    pin = dataGridView13.Rows[row].Cells["ino"].Value.ToString();
                    if (dataGridView13.Rows[row].Cells["c_qty"].Value == null || dataGridView13.Rows[row].Cells["c_qty"].Value == "")
                    {

                        dataGridView13.Rows[row].Cells["c_qty"].Value = "0";
                    }
                    MySqlCommand item_price = new MySqlCommand("select cost from fsm_voucher_log where (raw_name ='" + pin + "') and (branch_n ='" + Login.branch + "') ", conn);
                    //item_price.ExecuteNonQuery();
                    MySqlDataReader rd1;
                    try
                    {
                        DataGridViewComboBoxCell dgvCmbCell;
                        dgvCmbCell = (DataGridViewComboBoxCell)dataGridView13.Rows[row].Cells[col];
                        dgvCmbCell.Items.Clear();
                        dgvCmbCell.Value = null;
                        rd1 = item_price.ExecuteReader();
                        while (rd1.Read())
                        {

                            dgvCmbCell.Items.Add(rd1[0].ToString());
                            dgvCmbCell.Value = rd1[0].ToString();
                        }
                        rd1.Dispose();

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
            }

        }

        private void dataGridView20_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            connection_check();
            try
            {
                int row = e.RowIndex;
                int col = e.ColumnIndex;
                if (col == 1)
                {
                    pin2 = dataGridView20.Rows[row].Cells["ino3"].Value.ToString();
                    if (dataGridView20.Rows[row].Cells["c_qty3"].Value == null || dataGridView20.Rows[row].Cells["c_qty3"].Value == "")
                    {

                        dataGridView20.Rows[row].Cells["c_qty3"].Value = "0";
                    }
                    MySqlCommand item_price = new MySqlCommand("select cost from fsm_voucher_log where (raw_name ='" + pin2 + "') and (branch_n ='" + Login.branch + "') ", conn);
                    //item_price.ExecuteNonQuery();
                    MySqlDataReader rd1;
                    try
                    {
                        DataGridViewComboBoxCell dgvCmbCell;
                        dgvCmbCell = (DataGridViewComboBoxCell)dataGridView20.Rows[row].Cells[col];
                        dgvCmbCell.Items.Clear();
                        dgvCmbCell.Value = null;
                        //And make your loop 
                        //Price.Items.Clear();
                        rd1 = item_price.ExecuteReader();
                        while (rd1.Read())
                        {
                            dgvCmbCell.Items.Add(rd1[0].ToString());
                            dgvCmbCell.Value = rd1[0].ToString();
                        }
                        rd1.Dispose();
                    }
                    catch (Exception ex)
                    {
                        connection_check();
                        MessageBox.Show(ex.Message);
                    }
                    dataGridView20.Rows[row].Cells["ttdno3"].Value = "0";
                }
            }
            catch (Exception ex)
            {
            }

        }



        private void dg_gp_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                connection_check();
                MySqlCommand total_qantity = new MySqlCommand("select rema_qty from fsm_voucher_log where (raw_name ='" + dg_it.Text + "') and(cost='" + dg_gp.Text + "') and  (branch_n= '" + Login.branch + "') ", conn);
                total_qantity.ExecuteNonQuery();
                MySqlDataReader rd = total_qantity.ExecuteReader();
                while (rd.Read())
                {
                    dg_cq.Text = rd[0].ToString();
                }
                rd.Dispose();

            }
            catch (Exception ex)
            {
                connection_check();

            }
            dg_ip.Text = dg_gp.Text;
        }
        private void changep()
        {
            string ntqty = "";
            connection_check();


            try
            {
                MySqlCommand axx = new MySqlCommand("select total_kg_p from fsm_voucher_log where ((raw_name='" + dg_it.Text + "' )and(cost='" + dg_oit.Text + "')and(branch_n = '" + Login.branch + "'))", conn);
                axx.ExecuteNonQuery();
                MySqlDataReader dtr = axx.ExecuteReader();
                while (dtr.Read())
                {
                    p_cost = dtr[0].ToString();
                }
                axx.Dispose();
                dtr.Dispose();

            }
            catch (Exception ex)
            {
                connection_check();

            }

            connection_check();
            try
            {
                ntqty = Convert.ToString(Convert.ToDouble(p_cost) + Convert.ToDouble(dg_tq.Text));
                MySqlCommand in_upd = new MySqlCommand("Update fsm_voucher_log set total_cost ='" + Convert.ToString(Convert.ToDouble(oqty) * Convert.ToDouble(p_cost)) + "',  total_kg_p ='" + ntqty + "', rema_qty ='" + ntqty + "'   where  ((raw_name='" + dg_it.Text + "')and(cost='" + dg_oit.Text + "') and ( branch_n = '" + Login.branch + "'))", conn);
                in_upd.ExecuteNonQuery();
                in_upd.Dispose();
            }
            catch (Exception ex)
            {
                connection_check();

            }
            DataGridViewRow row = dataGridView3.Rows[panel_status];
            row.Cells["rem_qty"].Value = this.dg_cq.Text;
            row.Cells["item_qty"].Value = "0";
            row.Cells["pipcost"].Value = "0";
            row.Cells["icost"].Value = this.dg_ip.Text;

            dg_ip.Text = "";
            dg_it.Text = "";
            dg_ntq.Text = "";
            dg_oit.Text = "";
            dg_tq.Text = "";
            dg_cq.Text = "";
            dg_gp.Text = "";
            Changer_price.Visible = false;
        }
        private void button62_Click(object sender, EventArgs e)
        {
            changep();




        }

        private void button63_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView3.Rows[panel_status];
            row.Cells["rem_qty"].Value = this.dg_ocq.Text;
            row.Cells["item_qty"].Value = this.dg_tq.Text;
            row.Cells["icost"].Value = this.dg_oit.Text;

            dg_ip.Text = "";
            dg_it.Text = "";
            dg_ntq.Text = "";
            dg_oit.Text = "";
            dg_tq.Text = "";
            dg_cq.Text = "";
            dg_gp.Text = "";
            Changer_price.Visible = false;


        }

        private void dg_ntq_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (dg_ntq.Text > dg_cq.Text)
            //    {
            //        dg_ntq.Text = "0";
            //        dg_ntq.Focus();
            //        return;
            //    }
            //}
        }

        private void button64_Click(object sender, EventArgs e)
        {
            string iiname = "";
            string ttrqty = "";
            string ccqty = "";
            string pp_cost = "";
            string ntqty = ""; connection_check();
            try
            {
                if (txt_bat.Text != "")
                {
                    connection_check();
                    for (int i = 0; i < dataGridView3.RowCount; i++)
                    {


                        try
                        {

                            iiname = dataGridView3.Rows[i].Cells["Item_n"].Value.ToString();

                        }
                        catch (Exception ec)
                        {
                        }

                        try
                        {

                            ttrqty = dataGridView3.Rows[i].Cells["item_qty"].Value.ToString();
                        }
                        catch (Exception ec)
                        {
                            MessageBox.Show(ec.Message);
                        }
                        try
                        {


                            ccqty = dataGridView3.Rows[i].Cells["rem_qty"].Value.ToString();

                        }
                        catch (Exception ec)
                        {
                        }
                        try
                        {


                            iprice = dataGridView3.Rows[i].Cells["icost"].Value.ToString();

                        }
                        catch (Exception ec)
                        {
                        }
                        try
                        {
                            MySqlCommand axx = new MySqlCommand("select cost from fsm_voucher_log where ((raw_name='" + iiname + "' )and(cost='" + iprice + "')and(branch_n = '" + Login.branch + "'))", conn);
                            axx.ExecuteNonQuery();
                            MySqlDataReader dtr = axx.ExecuteReader();
                            while (dtr.Read())
                            {
                                pp_cost = dtr[0].ToString();
                            }
                            axx.Dispose();
                            dtr.Dispose();

                        }
                        catch (Exception ex)
                        {
                            connection_check();

                        }

                        connection_check();
                        try
                        {
                            MySqlCommand in_upd = new MySqlCommand("Update fsm_voucher_log set total_cost ='" + Convert.ToString(Convert.ToDouble(ccqty) * Convert.ToDouble(pp_cost)) + "',  total_kg_p ='" + Convert.ToString(Convert.ToDouble(ccqty) + Convert.ToDouble(ttrqty)) + "', rema_qty ='" + Convert.ToString(Convert.ToDouble(ccqty) + Convert.ToDouble(ttrqty)) + "'   where  ((raw_name='" + iiname + "')and(cost='" + iprice + "') and ( branch_n = '" + Login.branch + "'))", conn);
                            in_upd.ExecuteNonQuery();
                            in_upd.Dispose();
                        }
                        catch (Exception ex)
                        {
                            connection_check();

                        }
                    }
                    MySqlCommand setupall3 = new MySqlCommand("Delete  from fsm_production where Batch_no='" + txt_bat.Text + "' and branch_n = '" + Login.branch + "' ", conn);
                    setupall3.ExecuteNonQuery();
                    setupall3.Dispose();
                    cb_dep.Text = "";
                    cb_pd.Text = "";
                    txt_bat.Text = "";
                    Bind_Grid3();
                    Bind_Grid5_5();
                    label128.Text = "0";
                    label130.Text = "0";
                    up_label.Visible = false;
                    fsm_pro_listviewer();
                    fsm_mainlist();

                }
            }
            catch (Exception ex)
            {


            }

        }

        private void button65_Click(object sender, EventArgs e)
        {
            dn_tex.Text = "";
            bdn.Text = "";
            Bind_Grid22();
            Bind_Grid28();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView11_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int rowindex = e.RowIndex;
            int col = e.ColumnIndex;
            string tttr = "";
            string cccr = "";

            if (col == 11)
            {
                try
                {
                    unitcost = dataGridView11.Rows[rowindex].Cells["uni_1"].Value.ToString();

                }
                catch (Exception ex)
                {
                    unitcost = "1";
                    dataGridView11.Rows[rowindex].Cells["uni_1"].Value = "1";

                }
                try
                {
                    disrate = dataGridView11.Rows[rowindex].Cells["Disco"].Value.ToString();
                }
                catch (Exception ex)
                {
                    disrate = "0";
                    dataGridView11.Rows[rowindex].Cells["Disco"].Value = "0";

                }
                if (Convert.ToDouble(dataGridView11.Rows[rowindex].Cells["Disco"].Value) > Convert.ToDouble(dataGridView11.Rows[rowindex].Cells["uni_1"].Value))
                {
                    dataGridView11.Rows[rowindex].Cells["discount"].Value = "0";
                }

                //string per1 = (Convert.ToDouble(unitcost) * Convert.ToDouble(disrate) / 100).ToString();
                try
                {
                    tqty = dataGridView11.Rows[rowindex].Cells["Total_kg2"].Value.ToString();
                }
                catch (Exception ex)
                {


                }

                try
                {
                    cocost = dataGridView11.Rows[rowindex].Cells["uct"].Value.ToString();
                }
                catch (Exception ex)
                {


                }
                try
                {
                    dataGridView11.Rows[rowindex].Cells["uct"].Value = (Convert.ToDouble(cocost) + Convert.ToDouble(disrate)).ToString();
                }
                catch (Exception ex)
                {


                }
                try
                {
                    cocost = dataGridView11.Rows[rowindex].Cells["uct"].Value.ToString();
                }
                catch (Exception ex)
                {


                }
                try
                {
                    tqty = dataGridView11.Rows[rowindex].Cells["Total_kg2"].Value.ToString();
                }
                catch (Exception ex)
                {


                }
                try
                {
                    dataGridView11.Rows[rowindex].Cells["Total_coo"].Value = Convert.ToString(Convert.ToDouble(cocost) * Convert.ToDouble(tqty));
                }
                catch (Exception ex)
                {


                }
                try
                {
                    totalcost = dataGridView11.Rows[rowindex].Cells["Total_coo"].Value.ToString();
                }
                catch (Exception exc)
                { }
                try
                {
                    texrate = dataGridView11.Rows[rowindex].Cells["tex1"].Value.ToString();
                    if (texrate == "")
                    {
                        texrate = "0";
                        dataGridView11.Rows[rowindex].Cells["tex1"].Value = "0";
                    }
                }
                catch (Exception exc)
                {
                    texrate = "0";
                    dataGridView11.Rows[rowindex].Cells["tex1"].Value = "0";
                }
                try
                {
                    dataGridView11.Rows[rowindex].Cells["tex_a1"].Value = Convert.ToString(Convert.ToDouble(totalcost) * (Convert.ToDouble(texrate) / 100));

                }
                catch (Exception exc)
                {


                }
                try
                {
                    unitcost = dataGridView11.Rows[rowindex].Cells["uni_1"].Value.ToString();
                    if (unitcost == "")
                    {
                        unitcost = "1";
                        dataGridView11.Rows[rowindex].Cells["uni_1"].Value = "1";
                    }

                }
                catch (Exception exc)
                {
                    unitcost = "1";
                    dataGridView11.Rows[rowindex].Cells["uni_1"].Value = "1";

                }
                try
                {
                    cocost = dataGridView11.Rows[rowindex].Cells["uct"].Value.ToString();
                    if (cocost == "")
                    {
                        cocost = "1";
                        dataGridView11.Rows[rowindex].Cells["uct"].Value = "1";
                    }
                }
                catch (Exception exc)
                {
                    cocost = "1";
                    dataGridView11.Rows[rowindex].Cells["uct"].Value = "1";

                }
                try
                {
                    quanty = dataGridView11.Rows[rowindex].Cells["weight"].Value.ToString();
                }
                catch (Exception exc)
                {

                    quanty = "0";
                }
                try
                {
                    dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value = Convert.ToString(Convert.ToDouble(quanty) * Convert.ToDouble(cocost));
                    ctncost = dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value.ToString();
                    if (ctncost == "")
                    {
                        ctncost = "1";
                        dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value = "1";
                    }
                }
                catch (Exception exc)
                {
                    ctncost = "1";
                    dataGridView11.Rows[rowindex].Cells["ctn_co1"].Value = "1";

                }

            }
        }

        private void vouch_tex_KeyDown(object sender, KeyEventArgs e)
        {
          

        }

        private void id_code_text_KeyDown(object sender, KeyEventArgs e)
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
                if (checkBox4.Checked == true)
                {
                    double t_q = 0;
                    double t_p = 0;
                    connection_check();
                    try
                    {
                        MySqlCommand sel_deb = new MySqlCommand("select invoice_code from fsm_voucher_log where ((invoice_number='" + id_code_text.Text + "') and (branch_n='" + Login.branch + "') and (Status='Finished Goods'))", conn);
                        sel_deb.ExecuteNonQuery();
                        MySqlDataReader deb_dr = sel_deb.ExecuteReader();
                        while (deb_dr.Read())
                        {
                            id_code_text.Text = deb_dr[0].ToString();
                        }
                        deb_dr.Dispose();
                    }
                    catch (Exception ex)
                    {


                    }

                    Bind_Grid2_2_2();
                    for (int k = 0; k < dataGridView11.RowCount; k++)
                    {
                        try
                        {

                            grand = dataGridView11.Rows[k].Cells["Total_kg2"].Value.ToString();

                            t_q = Convert.ToDouble(grand) + t_q;


                            t_cost = dataGridView11.Rows[k].Cells["Total_coo"].Value.ToString();
                            t_p = Convert.ToDouble(t_cost) + t_p;

                        }
                        catch (Exception ex)
                        {

                            //  MessageBox.Show(ex.Message);
                        }
                        label53.Text = Convert.ToString(t_q);
                        label52.Text = Convert.ToString(t_p);
                    }
                    t_q = 0;
                    t_q = 0;


                }
                else
                {
                    double t_q = 0;
                    double t_p = 0;
                    connection_check();
                    try
                    {
                        MySqlCommand sel_deb = new MySqlCommand("select invoice_code from fsm_voucher_log where ((invoice_number='" + id_code_text.Text + "') and (branch_n='" + Login.branch + "') and (Status='for production'))", conn);
                        sel_deb.ExecuteNonQuery();
                        MySqlDataReader deb_dr = sel_deb.ExecuteReader();
                        while (deb_dr.Read())
                        {
                            id_code_text.Text = deb_dr[0].ToString();
                        }
                        deb_dr.Dispose();
                    }
                    catch (Exception ex)
                    {


                    }

                    Bind_Grid2_1();
                    for (int k = 0; k < dataGridView11.RowCount; k++)
                    {
                        try
                        {

                            grand = dataGridView11.Rows[k].Cells["Total_kg2"].Value.ToString();

                            t_q = Convert.ToDouble(grand) + t_q;


                            t_cost = dataGridView11.Rows[k].Cells["Total_coo"].Value.ToString();
                            t_p = Convert.ToDouble(t_cost) + t_p;

                        }
                        catch (Exception ex)
                        {

                            //  MessageBox.Show(ex.Message);
                        }
                        label53.Text = Convert.ToString(t_q);
                        label52.Text = Convert.ToString(t_p);
                    }
                    t_q = 0;
                    t_q = 0;
                }

            }
        }

        private void item_add_SelectedIndexChanged(object sender, EventArgs e)
        {
            texit.Text = item_add.Text;

        }

        private void edit_dep_Click(object sender, EventArgs e)
        {
            try
            {
                connection_check();
                MySqlCommand in_upd = new MySqlCommand("Update departmenttb set dep_name='" + Dep_create.Text + "'  where dep_name='" + texdep.Text + "' ", conn);
                in_upd.ExecuteNonQuery();
                in_upd.Dispose();

            }
            catch (Exception ex)
            {
            }
            try
            {
                connection_check();
                MySqlCommand in_upd = new MySqlCommand("Update depitem set dep_name='" + Dep_create.Text + "'  where dep_name='" + texdep.Text + "' ", conn);
                in_upd.ExecuteNonQuery();
                in_upd.Dispose();

            }
            catch (Exception ex)
            {
            }
            Dep_create.Text = "";
            texdep.Text = "";
            depget();
            getdepp();
            pdget();
            getitem_name();
            Bind_Grid18();
        }

        private void edit_pd_Click(object sender, EventArgs e)
        {
            connection_check();
            try
            {
                try
                {
                    connection_check();
                    MySqlCommand in_upd = new MySqlCommand("Update fsm_product set cat_name='" + Pd_create.Text + "'  where cat_name='" + texpd.Text + "' ", conn);
                    in_upd.ExecuteNonQuery();
                    in_upd.Dispose();

                }
                catch (Exception ex)
                {
                }
                try
                {
                    connection_check();
                    MySqlCommand in_upd1 = new MySqlCommand("Update fsm_pro_pricing set cat_name='" + Pd_create.Text + "'  where cat_name='" + texpd.Text + "' ", conn);
                    in_upd1.ExecuteNonQuery();
                    in_upd1.Dispose();

                }
                catch (Exception ex)
                {
                }
                try
                {
                    connection_check();
                    MySqlCommand in_upd2 = new MySqlCommand("Update depitem set cat_name='" + Pd_create.Text + "'  where cat_name='" + texpd.Text + "' ", conn);
                    in_upd2.ExecuteNonQuery();
                    in_upd2.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ex)
            {


            }

            Pd_create.Text = "";
            texpd.Text = "";
            getdepp();
            pdget();
            getproduct();
            getitem_name();
            Bind_Grid17();
            Bind_Grid39();
        }

        private void edit_it_Click(object sender, EventArgs e)
        {
            connection_check();
            if (add_item_only.Checked == true)
            {
                if (texit.Text != "" || texit.Text != null)
                {


                    try
                    {
                        connection_check();
                        MySqlCommand in_upd1 = new MySqlCommand("Update rawtb set raw_name='" + item_add.Text + "'  where raw_name='" + texit.Text + "' ", conn);
                        in_upd1.ExecuteNonQuery();
                        in_upd1.Dispose();
                        MessageBox.Show("This Item is now Updated to the record!", "record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                    }
                    item_add.Text = "";
                    texit.Text = "";
                    getitem_name();
                }
                else
                {
                    MessageBox.Show("Please Select or type the Item", "Invalid Item Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (texit.Text != "" || texit.Text != null || Pd_create.Text != "" || Pd_create.Text != null || Dep_create.Text != "" || Dep_create.Text != null)
                {
                    try
                    {
                        try
                        {
                            connection_check();
                            MySqlCommand in_upd = new MySqlCommand("Update depitem set itemname='" + item_add.Text + "'  where (dep_name='" + Dep_create.Text + "' ) and (cat_name='" + Pd_create.Text + "') and (itemname='" + texit.Text + "') ", conn);
                            in_upd.ExecuteNonQuery();
                            in_upd.Dispose();
                            MessageBox.Show("This Item is now Updated to the record!", "record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                else
                {
                    MessageBox.Show("Please Select or type the Item", "Invalid Item Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                item_add.Text = "";
                texit.Text = "";
                getitem_name();
                getdepp();
                pdget();
                Bind_Grid17();
                Bind_Grid39();
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

        private void dataGridView8_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            connection_check();
            try
            {

                item_add.Text = dataGridView8.Rows[e.RowIndex].Cells["c_pd"].Value.ToString();
                texit.Text = dataGridView8.Rows[e.RowIndex].Cells["c_pd"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dn_tex3_TextChanged(object sender, EventArgs e)
        {
            received_report_view();
        }

        private void dataGridView13_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView15_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int rowindex = e.RowIndex;
            int col = e.ColumnIndex;
            if (col == 1)
            {
                //for (int jj = 0; jj < dataGridView15.Rows.Count; jj++)
                //{
                try
                {
                    string tempitem = dataGridView15.Rows[rowindex].Cells["r_m"].Value.ToString();
                    connection_check();
                    MySqlCommand axx = new MySqlCommand("select total_kg_p from fsm_voucher where ((branch_n ='" + bran_name.Text + "')and (raw_name='" + tempitem + "')and(Status !='Finished Goods')) ", conn);
                    axx.ExecuteNonQuery();
                    MySqlDataReader dtr = axx.ExecuteReader();
                    while (dtr.Read())
                    {
                        string aa;
                        aa = dtr[0].ToString();
                        if (aa == "" || aa == null)
                        {
                            dataGridView15.Rows[rowindex].Cells["m_r"].Value = 0;
                        }
                        else
                        {
                            dataGridView15.Rows[rowindex].Cells["m_r"].Value = aa;
                        }
                    }
                    axx.Dispose();
                    dtr.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                //}

            }
        }

        private void dataGridView16_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int rowindex = e.RowIndex;
            int col = e.ColumnIndex;
            if (col == 1)
            {


                //for (int jj = 0; jj <dataGridView16.Rows.Count; jj++)
                //{
                try
                {

                    string tempitem = dataGridView16.Rows[rowindex].Cells["rr_m"].Value.ToString();
                    connection_check();
                    MySqlCommand axx = new MySqlCommand("select sum(total_kg_p) from fsm_voucher_log where ((branch_n ='" + Login.branch + "')and (raw_name='" + tempitem + "') and (Status!='for production'))", conn);
                    axx.ExecuteNonQuery();
                    MySqlDataReader dtr = axx.ExecuteReader();
                    while (dtr.Read())
                    {
                        string aa = "";
                        aa = dtr[0].ToString();
                        if (aa == "" || aa == null)
                        {
                            dataGridView16.Rows[rowindex].Cells["mr"].Value = "0";
                        }
                        else
                        {
                            dataGridView16.Rows[rowindex].Cells["mr"].Value = aa;
                        }

                    }
                    axx.Dispose();
                    dtr.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                // }
            }
        }

        private void search_box_pro_TextChanged(object sender, EventArgs e)
        {
            if (search_box_pro.Text != "")
            {

                for (int j = 0; j < dataGridView16.RowCount; j++)
                {
                    dnido = dataGridView16.Rows[j].Cells["rr_m"].Value.ToString();
                    if (dnido == search_box_pro.Text)
                    {
                        dataGridView16.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(255, 249, 196);
                        dataGridView16.Focus();
                        dataGridView16.CurrentCell = dataGridView16[1, j];
                        //dataGridView15.CurrentRow.Cells["dn"].Selected = true;
                    }
                }
            }
        }

        private void search_box_pro_Leave(object sender, EventArgs e)
        {
            for (int j = 0; j < dataGridView16.RowCount; j++)
            {
                dnido = dataGridView16.Rows[j].Cells["rr_m"].Value.ToString();
                if (dataGridView16.Rows[j].DefaultCellStyle.BackColor == Color.FromArgb(255, 249, 196))
                {
                    dataGridView16.Rows[j].DefaultCellStyle.BackColor = Color.White;
                    dataGridView16.Focus();
                }
            }
        }


        private void voucher_boxfg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vouch_tex_SelectedIndexChanged(object sender, EventArgs e)
        {
               

                if (checkBox4.Checked == true)
                {
                    double t_q = 0;
                    double t_p = 0;
                    connection_check();
                    try
                    {
                        MySqlCommand sel_deb = new MySqlCommand("select invoice_number from fsm_voucher_log where ((invoice_code='" + vouch_tex.Text + "') and (branch_n='" + Login.branch + "') and (Status='Finished Goods'))", conn);
                        sel_deb.ExecuteNonQuery();
                        MySqlDataReader deb_dr = sel_deb.ExecuteReader();
                        while (deb_dr.Read())
                        {
                            id_code_text.Text = deb_dr[0].ToString();
                        }
                        deb_dr.Dispose();
                    }
                    catch (Exception ex)
                    {


                    }

                    Bind_Grid2_2();
                    for (int k = 0; k < dataGridView11.RowCount; k++)
                    {
                        try
                        {

                            grand = dataGridView11.Rows[k].Cells["Total_kg2"].Value.ToString();

                            t_q = Convert.ToDouble(grand) + t_q;


                            t_cost = dataGridView11.Rows[k].Cells["Total_coo"].Value.ToString();
                            t_p = Convert.ToDouble(t_cost) + t_p;

                        }
                        catch (Exception ex)
                        {

                            //  MessageBox.Show(ex.Message);
                        }
                        label53.Text = Convert.ToString(t_q);
                        label52.Text = Convert.ToString(t_p);
                    }
                    t_q = 0;
                    t_q = 0;


                }
                else
                {
                    double t_q = 0;
                    double t_p = 0;
                    connection_check();
                    try
                    {
                        MySqlCommand sel_deb = new MySqlCommand("select invoice_number from fsm_voucher_log where ((invoice_code='" + vouch_tex.Text + "') and (branch_n='" + Login.branch + "') and (Status='for production'))", conn);
                        sel_deb.ExecuteNonQuery();
                        MySqlDataReader deb_dr = sel_deb.ExecuteReader();
                        while (deb_dr.Read())
                        {
                            id_code_text.Text = deb_dr[0].ToString();
                        }
                        deb_dr.Dispose();
                    }
                    catch (Exception ex)
                    {


                    }

                    Bind_Grid2();
                    for (int k = 0; k < dataGridView11.RowCount; k++)
                    {
                        try
                        {

                            grand = dataGridView11.Rows[k].Cells["Total_kg2"].Value.ToString();

                            t_q = Convert.ToDouble(grand) + t_q;


                            t_cost = dataGridView11.Rows[k].Cells["Total_coo"].Value.ToString();
                            t_p = Convert.ToDouble(t_cost) + t_p;

                        }
                        catch (Exception ex)
                        {

                            //  MessageBox.Show(ex.Message);
                        }
                        label53.Text = Convert.ToString(t_q);
                        label52.Text = Convert.ToString(t_p);
                    }
                    t_q = 0;
                    t_q = 0;
                }

            
           
        }

        private void dataGridView15_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





    }
}



