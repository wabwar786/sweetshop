namespace FSM
{
    partial class Security
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
            this.l = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tex_id = new System.Windows.Forms.TextBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rolebox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tex_user = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.User_Name = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.btn_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // l
            // 
            this.l.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(215, 78);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(440, 33);
            this.l.TabIndex = 59;
            this.l.Text = "                                                                                 " +
                "         ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 59);
            this.label4.TabIndex = 57;
            this.label4.Text = "S E C U R I T Y";
            // 
            // tex_id
            // 
            this.tex_id.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_id.Location = new System.Drawing.Point(175, 33);
            this.tex_id.Name = "tex_id";
            this.tex_id.Size = new System.Drawing.Size(25, 23);
            this.tex_id.TabIndex = 38;
            this.tex_id.Visible = false;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.White;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(394, 210);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(80, 29);
            this.btn_new.TabIndex = 48;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(480, 210);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 29);
            this.btn_save.TabIndex = 46;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 45;
            this.label1.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::FSM.Properties.Resources._1_8ZsXWqdo9OwAfwychr3zEw3;
            this.pictureBox1.Location = new System.Drawing.Point(0, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 634);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // rolebox
            // 
            this.rolebox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rolebox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rolebox.BackColor = System.Drawing.SystemColors.Window;
            this.rolebox.Font = new System.Drawing.Font("Calibri", 10F);
            this.rolebox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rolebox.FormattingEnabled = true;
            this.rolebox.Items.AddRange(new object[] {
            "All-with Signup",
            "All-with Security",
            "Purchasing",
            "Department_Creation",
            "Department_Creation(Delete function)",
            "Issuance_Production",
            "Production_Status",
            "Main_Store",
            "Pricing",
            "Demand_Note",
            "Received_Demands",
            "Transfer",
            "Demand_Status",
            "Edit_Voucher",
            "Reports"});
            this.rolebox.Location = new System.Drawing.Point(340, 181);
            this.rolebox.Name = "rolebox";
            this.rolebox.Size = new System.Drawing.Size(296, 23);
            this.rolebox.TabIndex = 60;
            this.rolebox.SelectedIndexChanged += new System.EventHandler(this.rolebox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 61;
            this.label2.Text = "Tab";
            // 
            // tex_user
            // 
            this.tex_user.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tex_user.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tex_user.BackColor = System.Drawing.SystemColors.Window;
            this.tex_user.Font = new System.Drawing.Font("Calibri", 10F);
            this.tex_user.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tex_user.FormattingEnabled = true;
            this.tex_user.Location = new System.Drawing.Point(340, 146);
            this.tex_user.Name = "tex_user";
            this.tex_user.Size = new System.Drawing.Size(296, 23);
            this.tex_user.TabIndex = 62;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.User_Name,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(221, 245);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(415, 364);
            this.listView1.TabIndex = 63;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click_1);
            // 
            // User_Name
            // 
            this.User_Name.Text = "User_Name";
            this.User_Name.Width = 190;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tab";
            this.columnHeader2.Width = 190;
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.White;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Location = new System.Drawing.Point(561, 210);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 29);
            this.btn_del.TabIndex = 64;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // Security
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 621);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tex_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rolebox);
            this.Controls.Add(this.l);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tex_id);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Security";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security";
            this.Load += new System.EventHandler(this.Security_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tex_id;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox rolebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tex_user;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader User_Name;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}