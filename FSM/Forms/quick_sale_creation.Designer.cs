namespace FSM.Forms
{
    partial class quick_sale_creation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.itemNameCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.barcodeCombobox = new System.Windows.Forms.ComboBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.quickSaleGridview = new System.Windows.Forms.DataGridView();
            this.deletebtn = new System.Windows.Forms.Button();
            this.barcodeGridveiw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNamegridview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quickSaleGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 67);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUICK SALE CREATION";
            // 
            // itemNameCombobox
            // 
            this.itemNameCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemNameCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemNameCombobox.FormattingEnabled = true;
            this.itemNameCombobox.Location = new System.Drawing.Point(137, 118);
            this.itemNameCombobox.Name = "itemNameCombobox";
            this.itemNameCombobox.Size = new System.Drawing.Size(291, 27);
            this.itemNameCombobox.TabIndex = 1;
            this.itemNameCombobox.SelectedIndexChanged += new System.EventHandler(this.itemNameCombobox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Barcode :";
            // 
            // barcodeCombobox
            // 
            this.barcodeCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.barcodeCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.barcodeCombobox.FormattingEnabled = true;
            this.barcodeCombobox.Location = new System.Drawing.Point(137, 85);
            this.barcodeCombobox.Name = "barcodeCombobox";
            this.barcodeCombobox.Size = new System.Drawing.Size(291, 27);
            this.barcodeCombobox.TabIndex = 0;
            this.barcodeCombobox.SelectedIndexChanged += new System.EventHandler(this.barcodeCombobox_SelectedIndexChanged);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.savebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.savebtn.Location = new System.Drawing.Point(264, 157);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(79, 29);
            this.savebtn.TabIndex = 2;
            this.savebtn.Text = "&SAVE";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // quickSaleGridview
            // 
            this.quickSaleGridview.AllowUserToAddRows = false;
            this.quickSaleGridview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quickSaleGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quickSaleGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeGridveiw,
            this.itemNamegridview});
            this.quickSaleGridview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.quickSaleGridview.Location = new System.Drawing.Point(0, 197);
            this.quickSaleGridview.Name = "quickSaleGridview";
            this.quickSaleGridview.RowHeadersVisible = false;
            this.quickSaleGridview.Size = new System.Drawing.Size(481, 311);
            this.quickSaleGridview.TabIndex = 6;
            this.quickSaleGridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.quickSaleGridview_CellClick);
            this.quickSaleGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.quickSaleGridview_CellContentClick);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deletebtn.Location = new System.Drawing.Point(349, 157);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(79, 29);
            this.deletebtn.TabIndex = 7;
            this.deletebtn.Text = "&DELETE";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // barcodeGridveiw
            // 
            this.barcodeGridveiw.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.barcodeGridveiw.DataPropertyName = "barcode";
            this.barcodeGridveiw.HeaderText = "Item Code";
            this.barcodeGridveiw.Name = "barcodeGridveiw";
            // 
            // itemNamegridview
            // 
            this.itemNamegridview.DataPropertyName = "item_name";
            this.itemNamegridview.HeaderText = "Item Name";
            this.itemNamegridview.Name = "itemNamegridview";
            this.itemNamegridview.Width = 300;
            // 
            // quick_sale_creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(481, 508);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.quickSaleGridview);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.barcodeCombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemNameCombobox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "quick_sale_creation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick Sale";
            this.Load += new System.EventHandler(this.quick_sale_creation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quickSaleGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox itemNameCombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox barcodeCombobox;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.DataGridView quickSaleGridview;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeGridveiw;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNamegridview;
    }
}