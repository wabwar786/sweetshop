namespace FSM.Forms
{
    partial class deals_creation
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dealNumbertextBox = new System.Windows.Forms.TextBox();
            this.dealNametxt = new System.Windows.Forms.TextBox();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.itemNametxt = new System.Windows.Forms.ComboBox();
            this.saveDealstxt = new System.Windows.Forms.ComboBox();
            this.newbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.dealsGridview = new System.Windows.Forms.DataGridView();
            this.dealnumberGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealNameGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameGird = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGird = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealsGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 67);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(240, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "DEALS CREATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deal # :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Deal Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Item Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Saved Deals :";
            // 
            // dealNumbertextBox
            // 
            this.dealNumbertextBox.Enabled = false;
            this.dealNumbertextBox.Location = new System.Drawing.Point(128, 91);
            this.dealNumbertextBox.Name = "dealNumbertextBox";
            this.dealNumbertextBox.Size = new System.Drawing.Size(263, 27);
            this.dealNumbertextBox.TabIndex = 1;
            // 
            // dealNametxt
            // 
            this.dealNametxt.Enabled = false;
            this.dealNametxt.Location = new System.Drawing.Point(521, 91);
            this.dealNametxt.Name = "dealNametxt";
            this.dealNametxt.Size = new System.Drawing.Size(263, 27);
            this.dealNametxt.TabIndex = 2;
            // 
            // quantitytxt
            // 
            this.quantitytxt.Enabled = false;
            this.quantitytxt.Location = new System.Drawing.Point(521, 128);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(263, 27);
            this.quantitytxt.TabIndex = 4;
            // 
            // itemNametxt
            // 
            this.itemNametxt.Enabled = false;
            this.itemNametxt.FormattingEnabled = true;
            this.itemNametxt.Location = new System.Drawing.Point(128, 128);
            this.itemNametxt.Name = "itemNametxt";
            this.itemNametxt.Size = new System.Drawing.Size(263, 27);
            this.itemNametxt.TabIndex = 3;
            // 
            // saveDealstxt
            // 
            this.saveDealstxt.FormattingEnabled = true;
            this.saveDealstxt.Location = new System.Drawing.Point(128, 165);
            this.saveDealstxt.Name = "saveDealstxt";
            this.saveDealstxt.Size = new System.Drawing.Size(263, 27);
            this.saveDealstxt.TabIndex = 10;
            this.saveDealstxt.SelectedIndexChanged += new System.EventHandler(this.saveDealstxt_SelectedIndexChanged);
            // 
            // newbtn
            // 
            this.newbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.newbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newbtn.Location = new System.Drawing.Point(527, 166);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(81, 30);
            this.newbtn.TabIndex = 0;
            this.newbtn.Text = "&NEW";
            this.newbtn.UseVisualStyleBackColor = false;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.savebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.savebtn.Location = new System.Drawing.Point(614, 166);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(81, 30);
            this.savebtn.TabIndex = 5;
            this.savebtn.Text = "&SAVE";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deletebtn.Location = new System.Drawing.Point(701, 166);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(81, 30);
            this.deletebtn.TabIndex = 13;
            this.deletebtn.Text = "&DELETE";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // dealsGridview
            // 
            this.dealsGridview.AllowUserToAddRows = false;
            this.dealsGridview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dealsGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dealsGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dealnumberGrid,
            this.dealNameGrid,
            this.itemNameGird,
            this.quantityGird});
            this.dealsGridview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dealsGridview.Location = new System.Drawing.Point(0, 216);
            this.dealsGridview.Name = "dealsGridview";
            this.dealsGridview.RowHeadersVisible = false;
            this.dealsGridview.Size = new System.Drawing.Size(827, 372);
            this.dealsGridview.TabIndex = 14;
            this.dealsGridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dealsGridview_CellClick);
            // 
            // dealnumberGrid
            // 
            this.dealnumberGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dealnumberGrid.DataPropertyName = "deal_number";
            this.dealnumberGrid.HeaderText = "Deal #";
            this.dealnumberGrid.Name = "dealnumberGrid";
            // 
            // dealNameGrid
            // 
            this.dealNameGrid.DataPropertyName = "deal_name";
            this.dealNameGrid.HeaderText = "Deal Name";
            this.dealNameGrid.Name = "dealNameGrid";
            this.dealNameGrid.Width = 300;
            // 
            // itemNameGird
            // 
            this.itemNameGird.DataPropertyName = "item_name";
            this.itemNameGird.HeaderText = "Item Name";
            this.itemNameGird.Name = "itemNameGird";
            this.itemNameGird.Width = 300;
            // 
            // quantityGird
            // 
            this.quantityGird.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityGird.DataPropertyName = "quantity";
            this.quantityGird.HeaderText = "Quantity";
            this.quantityGird.Name = "quantityGird";
            // 
            // deals_creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(827, 588);
            this.Controls.Add(this.dealsGridview);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.newbtn);
            this.Controls.Add(this.saveDealstxt);
            this.Controls.Add(this.itemNametxt);
            this.Controls.Add(this.quantitytxt);
            this.Controls.Add(this.dealNametxt);
            this.Controls.Add(this.dealNumbertextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "deals_creation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deals Creation";
            this.Load += new System.EventHandler(this.deals_creation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealsGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dealNumbertextBox;
        private System.Windows.Forms.TextBox dealNametxt;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.ComboBox itemNametxt;
        private System.Windows.Forms.ComboBox saveDealstxt;
        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.DataGridView dealsGridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealnumberGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealNameGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameGird;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGird;
    }
}