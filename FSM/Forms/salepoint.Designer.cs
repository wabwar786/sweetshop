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
            ((System.ComponentModel.ISupportInitialize)(this.salesItems_gridview)).BeginInit();
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
            this.salesItems_gridview.AllowUserToDeleteRows = false;
            this.salesItems_gridview.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.salesItems_gridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.salesItems_gridview.ReadOnly = true;
            this.salesItems_gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.salesItems_gridview.RowHeadersVisible = false;
            this.salesItems_gridview.Size = new System.Drawing.Size(898, 497);
            this.salesItems_gridview.TabIndex = 2;
            // 
            // Barcode_grid
            // 
            this.Barcode_grid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Barcode_grid.HeaderText = "Barcode";
            this.Barcode_grid.Name = "Barcode_grid";
            this.Barcode_grid.ReadOnly = true;
            // 
            // ProductName_gridview
            // 
            this.ProductName_gridview.HeaderText = "Product Name ";
            this.ProductName_gridview.Name = "ProductName_gridview";
            this.ProductName_gridview.ReadOnly = true;
            this.ProductName_gridview.Width = 300;
            // 
            // Quantity_gridview
            // 
            this.Quantity_gridview.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity_gridview.HeaderText = "Quantity";
            this.Quantity_gridview.Name = "Quantity_gridview";
            this.Quantity_gridview.ReadOnly = true;
            // 
            // Price_gridview
            // 
            this.Price_gridview.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price_gridview.HeaderText = "Price";
            this.Price_gridview.Name = "Price_gridview";
            this.Price_gridview.ReadOnly = true;
            // 
            // billStatus_gridview
            // 
            this.billStatus_gridview.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.billStatus_gridview.HeaderText = "Bill Status";
            this.billStatus_gridview.Name = "billStatus_gridview";
            this.billStatus_gridview.ReadOnly = true;
            // 
            // Delete_gridview
            // 
            this.Delete_gridview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_gridview.HeaderText = "Delete";
            this.Delete_gridview.Name = "Delete_gridview";
            this.Delete_gridview.ReadOnly = true;
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
            this.invoice_notextBox.Size = new System.Drawing.Size(271, 27);
            this.invoice_notextBox.TabIndex = 6;
            // 
            // salepoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1280, 749);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView salesItems_gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName_gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn billStatus_gridview;
        private System.Windows.Forms.DataGridViewButtonColumn Delete_gridview;
        private System.Windows.Forms.TextBox searchItem_textBox;
        private System.Windows.Forms.ListView Items_listView;
        private System.Windows.Forms.ColumnHeader Discription_list;
        private System.Windows.Forms.ColumnHeader Price_list;
        private System.Windows.Forms.ColumnHeader Qty_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox invoice_notextBox;
    }
}