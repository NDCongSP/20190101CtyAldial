namespace Aldila
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_part = new System.Windows.Forms.ComboBox();
            this.grb_meas = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_workorder = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbb_builttype = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rad_unsanded = new System.Windows.Forms.RadioButton();
            this.rad_sanded = new System.Windows.Forms.RadioButton();
            this.btn_ok = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_part);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Part";
            // 
            // cbb_part
            // 
            this.cbb_part.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_part.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbb_part.FormattingEnabled = true;
            this.cbb_part.Location = new System.Drawing.Point(38, 32);
            this.cbb_part.Name = "cbb_part";
            this.cbb_part.Size = new System.Drawing.Size(164, 23);
            this.cbb_part.TabIndex = 1;
            this.cbb_part.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbb_part_KeyDown);
            // 
            // grb_meas
            // 
            this.grb_meas.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.grb_meas.Location = new System.Drawing.Point(276, 23);
            this.grb_meas.Name = "grb_meas";
            this.grb_meas.Size = new System.Drawing.Size(271, 423);
            this.grb_meas.TabIndex = 1;
            this.grb_meas.TabStop = false;
            this.grb_meas.Text = "Measurement type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_workorder);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Work Order";
            // 
            // txt_workorder
            // 
            this.txt_workorder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_workorder.Location = new System.Drawing.Point(39, 31);
            this.txt_workorder.Name = "txt_workorder";
            this.txt_workorder.Size = new System.Drawing.Size(163, 22);
            this.txt_workorder.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbb_builttype);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 82);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Build Type";
            // 
            // cbb_builttype
            // 
            this.cbb_builttype.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_builttype.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbb_builttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_builttype.FormattingEnabled = true;
            this.cbb_builttype.Items.AddRange(new object[] {
            "New",
            "RSND",
            "RPLY"});
            this.cbb_builttype.Location = new System.Drawing.Point(38, 21);
            this.cbb_builttype.Name = "cbb_builttype";
            this.cbb_builttype.Size = new System.Drawing.Size(164, 23);
            this.cbb_builttype.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rad_unsanded);
            this.groupBox4.Controls.Add(this.rad_sanded);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 364);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(236, 82);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Shaft Type";
            // 
            // rad_unsanded
            // 
            this.rad_unsanded.AutoSize = true;
            this.rad_unsanded.Location = new System.Drawing.Point(62, 46);
            this.rad_unsanded.Name = "rad_unsanded";
            this.rad_unsanded.Size = new System.Drawing.Size(77, 19);
            this.rad_unsanded.TabIndex = 1;
            this.rad_unsanded.Text = "Unsanded";
            this.rad_unsanded.UseVisualStyleBackColor = true;
            // 
            // rad_sanded
            // 
            this.rad_sanded.AutoSize = true;
            this.rad_sanded.Checked = true;
            this.rad_sanded.Location = new System.Drawing.Point(62, 21);
            this.rad_sanded.Name = "rad_sanded";
            this.rad_sanded.Size = new System.Drawing.Size(64, 19);
            this.rad_sanded.TabIndex = 0;
            this.rad_sanded.TabStop = true;
            this.rad_sanded.Text = "Sanded";
            this.rad_sanded.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(453, 463);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(94, 28);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(561, 495);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.grb_meas);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Setup Production Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_part;
        private System.Windows.Forms.GroupBox grb_meas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbb_builttype;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rad_unsanded;
        private System.Windows.Forms.RadioButton rad_sanded;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox txt_workorder;
        private System.Windows.Forms.Timer timer1;
    }
}

