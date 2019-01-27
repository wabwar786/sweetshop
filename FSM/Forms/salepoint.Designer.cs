namespace FSM.Forms
{
    partial class salepoint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salepoint));
            this.label1 = new System.Windows.Forms.Label();
            this.salesItems_gridview = new System.Windows.Forms.DataGridView();
            this.searchItem_textBox = new System.Windows.Forms.TextBox();
            this.Items_listView = new System.Windows.Forms.ListView();
            this.Discription_list = new System.Windows.Forms.ColumnHeader();
            this.Price_list = new System.Windows.Forms.ColumnHeader();
            this.Qty_list = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.invoice_notextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.percentagetextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.change_txt = new System.Windows.Forms.TextBox();
            this.balance_txt = new System.Windows.Forms.TextBox();
            this.discount_txt = new System.Windows.Forms.TextBox();
            this.receive_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.branchNamelabel = new System.Windows.Forms.Label();
            this.reveiveableAmount_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.customer_name_combobox = new System.Windows.Forms.ComboBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.salesMancheckBox = new System.Windows.Forms.CheckBox();
            this.salesman_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.Barcode_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName_gridview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_gridview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_gridview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billStatus_gridview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete_gridview = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.salesItems_gridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scane Barcode :";
            // 
            // salesItems_gridview
            // 
            this.salesItems_gridview.AllowUserToAddRows = false;
            this.salesItems_gridview.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.salesItems_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode_grid,
            this.ProductName_gridview,
            this.Quantity_gridview,
            this.Price_gridview,
            this.amountGridView,
            this.billStatus_gridview,
            this.Delete_gridview});
            this.salesItems_gridview.Location = new System.Drawing.Point(14, 128);
            this.salesItems_gridview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salesItems_gridview.Name = "salesItems_gridview";
            this.salesItems_gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.salesItems_gridview.RowHeadersVisible = false;
            this.salesItems_gridview.Size = new System.Drawing.Size(894, 472);
            this.salesItems_gridview.TabIndex = 2;
            this.salesItems_gridview.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesItems_gridview_CellEndEdit);
            this.salesItems_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesItems_gridview_CellClick);
            this.salesItems_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesItems_gridview_CellContentClick);
            // 
            // searchItem_textBox
            // 
            this.searchItem_textBox.Location = new System.Drawing.Point(127, 83);
            this.searchItem_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchItem_textBox.Name = "searchItem_textBox";
            this.searchItem_textBox.Size = new System.Drawing.Size(413, 27);
            this.searchItem_textBox.TabIndex = 0;
            this.searchItem_textBox.TextChanged += new System.EventHandler(this.searchItem_textBox_TextChanged);
            this.searchItem_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchItem_textBox_KeyDown);
            // 
            // Items_listView
            // 
            this.Items_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Discription_list,
            this.Price_list,
            this.Qty_list});
            this.Items_listView.FullRowSelect = true;
            this.Items_listView.GridLines = true;
            this.Items_listView.Location = new System.Drawing.Point(128, 117);
            this.Items_listView.Name = "Items_listView";
            this.Items_listView.Size = new System.Drawing.Size(413, 191);
            this.Items_listView.TabIndex = 1;
            this.Items_listView.UseCompatibleStateImageBehavior = false;
            this.Items_listView.View = System.Windows.Forms.View.Details;
            this.Items_listView.Visible = false;
            this.Items_listView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Items_listView_KeyDown);
            // 
            // Discription_list
            // 
            this.Discription_list.Text = "Discription";
            this.Discription_list.Width = 260;
            // 
            // Price_list
            // 
            this.Price_list.Text = "Price";
            this.Price_list.Width = 85;
            // 
            // Qty_list
            // 
            this.Qty_list.Text = "Qty";
            this.Qty_list.Width = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Invoice # :";
            // 
            // invoice_notextBox
            // 
            this.invoice_notextBox.Enabled = false;
            this.invoice_notextBox.Location = new System.Drawing.Point(127, 48);
            this.invoice_notextBox.Name = "invoice_notextBox";
            this.invoice_notextBox.Size = new System.Drawing.Size(195, 27);
            this.invoice_notextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(915, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 248);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hold Bills";
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(7, 197);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(166, 29);
            this.button9.TabIndex = 9;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(179, 197);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(166, 29);
            this.button10.TabIndex = 8;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(179, 155);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(166, 29);
            this.button8.TabIndex = 8;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(179, 113);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 29);
            this.button6.TabIndex = 4;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(7, 155);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(166, 29);
            this.button7.TabIndex = 9;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(179, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 29);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(179, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 29);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(7, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 29);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(7, 113);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 29);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(7, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 29);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.percentagetextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.change_txt);
            this.groupBox2.Controls.Add(this.balance_txt);
            this.groupBox2.Controls.Add(this.discount_txt);
            this.groupBox2.Controls.Add(this.receive_txt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(915, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 204);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Options";
            // 
            // percentagetextBox
            // 
            this.percentagetextBox.Location = new System.Drawing.Point(128, 97);
            this.percentagetextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.percentagetextBox.Name = "percentagetextBox";
            this.percentagetextBox.Size = new System.Drawing.Size(208, 27);
            this.percentagetextBox.TabIndex = 2;
            this.percentagetextBox.Text = "0";
            this.percentagetextBox.TextChanged += new System.EventHandler(this.percentagetextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Discount % :";
            // 
            // change_txt
            // 
            this.change_txt.Location = new System.Drawing.Point(128, 167);
            this.change_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.change_txt.Name = "change_txt";
            this.change_txt.Size = new System.Drawing.Size(208, 27);
            this.change_txt.TabIndex = 4;
            this.change_txt.Text = "0";
            // 
            // balance_txt
            // 
            this.balance_txt.Location = new System.Drawing.Point(128, 27);
            this.balance_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.balance_txt.Name = "balance_txt";
            this.balance_txt.Size = new System.Drawing.Size(208, 27);
            this.balance_txt.TabIndex = 0;
            this.balance_txt.Text = "0";
            // 
            // discount_txt
            // 
            this.discount_txt.Location = new System.Drawing.Point(128, 132);
            this.discount_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.discount_txt.Name = "discount_txt";
            this.discount_txt.Size = new System.Drawing.Size(208, 27);
            this.discount_txt.TabIndex = 3;
            this.discount_txt.Text = "0";
            this.discount_txt.TextChanged += new System.EventHandler(this.discount_txt_TextChanged);
            this.discount_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.discount_txt_KeyDown);
            // 
            // receive_txt
            // 
            this.receive_txt.Location = new System.Drawing.Point(128, 62);
            this.receive_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.receive_txt.Name = "receive_txt";
            this.receive_txt.Size = new System.Drawing.Size(208, 27);
            this.receive_txt.TabIndex = 1;
            this.receive_txt.Text = "0";
            this.receive_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.receive_txt_KeyDown);
            this.receive_txt.Leave += new System.EventHandler(this.receive_txt_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Change :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Balance :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Discount :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Received :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Branch Name :";
            // 
            // branchNamelabel
            // 
            this.branchNamelabel.AutoSize = true;
            this.branchNamelabel.Location = new System.Drawing.Point(124, 19);
            this.branchNamelabel.Name = "branchNamelabel";
            this.branchNamelabel.Size = new System.Drawing.Size(104, 19);
            this.branchNamelabel.TabIndex = 14;
            this.branchNamelabel.Text = "Branch Name :";
            // 
            // reveiveableAmount_txt
            // 
            this.reveiveableAmount_txt.BackColor = System.Drawing.SystemColors.InfoText;
            this.reveiveableAmount_txt.Font = new System.Drawing.Font("Calibri", 62.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reveiveableAmount_txt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reveiveableAmount_txt.Location = new System.Drawing.Point(977, 19);
            this.reveiveableAmount_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reveiveableAmount_txt.Multiline = true;
            this.reveiveableAmount_txt.Name = "reveiveableAmount_txt";
            this.reveiveableAmount_txt.Size = new System.Drawing.Size(291, 109);
            this.reveiveableAmount_txt.TabIndex = 13;
            this.reveiveableAmount_txt.Text = "0";
            this.reveiveableAmount_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.ForeColor = System.Drawing.Color.Orange;
            this.label8.Location = new System.Drawing.Point(979, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Receiveable Amount ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(328, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "Customer Name :";
            // 
            // customer_name_combobox
            // 
            this.customer_name_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.customer_name_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.customer_name_combobox.FormattingEnabled = true;
            this.customer_name_combobox.Location = new System.Drawing.Point(447, 48);
            this.customer_name_combobox.Name = "customer_name_combobox";
            this.customer_name_combobox.Size = new System.Drawing.Size(209, 27);
            this.customer_name_combobox.TabIndex = 2;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.White;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Location = new System.Drawing.Point(812, 92);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(96, 29);
            this.savebtn.TabIndex = 10;
            this.savebtn.Text = "&SAVE";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // salesMancheckBox
            // 
            this.salesMancheckBox.AutoSize = true;
            this.salesMancheckBox.Location = new System.Drawing.Point(671, 95);
            this.salesMancheckBox.Name = "salesMancheckBox";
            this.salesMancheckBox.Size = new System.Drawing.Size(134, 23);
            this.salesMancheckBox.TabIndex = 3;
            this.salesMancheckBox.Text = "View Salesman :";
            this.salesMancheckBox.UseVisualStyleBackColor = true;
            this.salesMancheckBox.CheckedChanged += new System.EventHandler(this.salesMancheckBox_CheckedChanged);
            // 
            // salesman_listView
            // 
            this.salesman_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.salesman_listView.FullRowSelect = true;
            this.salesman_listView.GridLines = true;
            this.salesman_listView.Location = new System.Drawing.Point(609, 124);
            this.salesman_listView.Name = "salesman_listView";
            this.salesman_listView.Size = new System.Drawing.Size(299, 191);
            this.salesman_listView.TabIndex = 19;
            this.salesman_listView.UseCompatibleStateImageBehavior = false;
            this.salesman_listView.View = System.Windows.Forms.View.Details;
            this.salesman_listView.Visible = false;
            this.salesman_listView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.salesman_listView_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 51;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 136;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 106;
            // 
            // Barcode_grid
            // 
            this.Barcode_grid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Barcode_grid.DataPropertyName = "barcode";
            this.Barcode_grid.HeaderText = "Barcode";
            this.Barcode_grid.Name = "Barcode_grid";
            // 
            // ProductName_gridview
            // 
            this.ProductName_gridview.DataPropertyName = "product_name";
            this.ProductName_gridview.HeaderText = "Product Name ";
            this.ProductName_gridview.Name = "ProductName_gridview";
            this.ProductName_gridview.Width = 300;
            // 
            // Quantity_gridview
            // 
            this.Quantity_gridview.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity_gridview.DataPropertyName = "quantity";
            this.Quantity_gridview.HeaderText = "Quantity";
            this.Quantity_gridview.Name = "Quantity_gridview";
            // 
            // Price_gridview
            // 
            this.Price_gridview.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price_gridview.DataPropertyName = "price";
            this.Price_gridview.HeaderText = "Price";
            this.Price_gridview.Name = "Price_gridview";
            // 
            // amountGridView
            // 
            this.amountGridView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amountGridView.HeaderText = "Amount";
            this.amountGridView.Name = "amountGridView";
            // 
            // billStatus_gridview
            // 
            this.billStatus_gridview.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.billStatus_gridview.DataPropertyName = "bill_status";
            this.billStatus_gridview.HeaderText = "Bill Status";
            this.billStatus_gridview.Name = "billStatus_gridview";
            this.billStatus_gridview.Visible = false;
            // 
            // Delete_gridview
            // 
            this.Delete_gridview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_gridview.HeaderText = "Delete";
            this.Delete_gridview.Name = "Delete_gridview";
            this.Delete_gridview.Text = "Delete";
            this.Delete_gridview.UseColumnTextForButtonValue = true;
            this.Delete_gridview.Width = 80;
            // 
            // salepoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1280, 881);
            this.Controls.Add(this.salesman_listView);
            this.Controls.Add(this.salesMancheckBox);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.customer_name_combobox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.reveiveableAmount_txt);
            this.Controls.Add(this.branchNamelabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.invoice_notextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Items_listView);
            this.Controls.Add(this.searchItem_textBox);
            this.Controls.Add(this.salesItems_gridview);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "salepoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POINT OF SALE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.salepoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesItems_gridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView salesItems_gridview;
        private System.Windows.Forms.TextBox searchItem_textBox;
        private System.Windows.Forms.ListView Items_listView;
        private System.Windows.Forms.ColumnHeader Discription_list;
        private System.Windows.Forms.ColumnHeader Price_list;
        private System.Windows.Forms.ColumnHeader Qty_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox invoice_notextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox change_txt;
        private System.Windows.Forms.TextBox balance_txt;
        private System.Windows.Forms.TextBox discount_txt;
        private System.Windows.Forms.TextBox receive_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label branchNamelabel;
        private System.Windows.Forms.TextBox reveiveableAmount_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox percentagetextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox customer_name_combobox;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.CheckBox salesMancheckBox;
        private System.Windows.Forms.ListView salesman_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName_gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn billStatus_gridview;
        private System.Windows.Forms.DataGridViewButtonColumn Delete_gridview;
    }
}