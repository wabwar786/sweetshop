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
            this.Barcode_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName_gridview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_gridview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_gridview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billStatus_gridview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete_gridview = new System.Windows.Forms.DataGridViewButtonColumn();
            this.searchItem_textBox = new System.Windows.Forms.TextBox();
            this.Items_listView = new System.Windows.Forms.ListView();
            this.Discription_list = new System.Windows.Forms.ColumnHeader();
            this.Price_list = new System.Windows.Forms.ColumnHeader();
            this.Qty_list = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.invoice_notextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.salesItems_gridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 76);
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
            this.billStatus_gridview,
            this.Delete_gridview});
            this.salesItems_gridview.Location = new System.Drawing.Point(14, 128);
            this.salesItems_gridview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salesItems_gridview.Name = "salesItems_gridview";
            this.salesItems_gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.salesItems_gridview.RowHeadersVisible = false;
            this.salesItems_gridview.Size = new System.Drawing.Size(894, 497);
            this.salesItems_gridview.TabIndex = 2;
            this.salesItems_gridview.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesItems_gridview_CellEndEdit);
            this.salesItems_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesItems_gridview_CellClick);
            this.salesItems_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesItems_gridview_CellContentClick);
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
            // billStatus_gridview
            // 
            this.billStatus_gridview.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.billStatus_gridview.DataPropertyName = "bill_status";
            this.billStatus_gridview.HeaderText = "Bill Status";
            this.billStatus_gridview.Name = "billStatus_gridview";
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
            // searchItem_textBox
            // 
            this.searchItem_textBox.Location = new System.Drawing.Point(127, 73);
            this.searchItem_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchItem_textBox.Name = "searchItem_textBox";
            this.searchItem_textBox.Size = new System.Drawing.Size(413, 27);
            this.searchItem_textBox.TabIndex = 3;
            this.searchItem_textBox.TextChanged += new System.EventHandler(this.searchItem_textBox_TextChanged);
            this.searchItem_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchItem_textBox_KeyDown);
            // 
            // Items_listView
            // 
            this.Items_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Discription_list,
            this.Price_list,
            this.Qty_list});
            this.Items_listView.GridLines = true;
            this.Items_listView.Location = new System.Drawing.Point(127, 107);
            this.Items_listView.Name = "Items_listView";
            this.Items_listView.Size = new System.Drawing.Size(413, 191);
            this.Items_listView.TabIndex = 4;
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
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Invoice # :";
            // 
            // invoice_notextBox
            // 
            this.invoice_notextBox.Enabled = false;
            this.invoice_notextBox.Location = new System.Drawing.Point(127, 38);
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
            this.groupBox1.Location = new System.Drawing.Point(915, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 248);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hold Bills";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(7, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 26);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(179, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 26);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(7, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 26);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(179, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 26);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(7, 113);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 26);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(179, 113);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 26);
            this.button6.TabIndex = 4;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(7, 155);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(166, 26);
            this.button7.TabIndex = 9;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(179, 155);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(166, 26);
            this.button8.TabIndex = 8;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(7, 197);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(166, 26);
            this.button9.TabIndex = 9;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(179, 197);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(166, 26);
            this.button10.TabIndex = 8;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(915, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 204);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Received :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Discount :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Balance :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Change :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 27);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 73);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 27);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(122, 117);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(223, 27);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(122, 158);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(223, 27);
            this.textBox4.TabIndex = 12;
            // 
            // salepoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1280, 891);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName_gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn billStatus_gridview;
        private System.Windows.Forms.DataGridViewButtonColumn Delete_gridview;
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}