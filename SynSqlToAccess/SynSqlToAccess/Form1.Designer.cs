namespace SynSqlToAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button3 = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtErro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(683, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Synchronized";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            // 
            // txtLog
            // 
            this.txtLog.AcceptsReturn = true;
            this.txtLog.AcceptsTab = true;
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(0, 144);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(370, 448);
            this.txtLog.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Blue;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Flex_Standard",
            "Freq_Standard",
            "Part",
            "PartZM",
            "ZMmeasType"});
            this.comboBox1.Location = new System.Drawing.Point(509, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 30);
            this.comboBox1.TabIndex = 10;
            // 
            // txtErro
            // 
            this.txtErro.AcceptsReturn = true;
            this.txtErro.AcceptsTab = true;
            this.txtErro.BackColor = System.Drawing.Color.White;
            this.txtErro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtErro.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErro.Location = new System.Drawing.Point(376, 144);
            this.txtErro.Multiline = true;
            this.txtErro.Name = "txtErro";
            this.txtErro.ReadOnly = true;
            this.txtErro.Size = new System.Drawing.Size(443, 448);
            this.txtErro.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SynSqlToAccess.Properties.Resources.AldilaPrimaryFlameLogo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(820, 591);
            this.Controls.Add(this.txtErro);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.button3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SynSqlToAccess";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtErro;
    }
}

