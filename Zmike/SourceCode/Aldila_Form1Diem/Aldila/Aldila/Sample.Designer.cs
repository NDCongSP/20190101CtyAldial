namespace Aldila
{
    partial class Sample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sample));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtResetNewTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInitial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txt_sampletime = new System.Windows.Forms.TextBox();
            this.txt_samplenumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtResetNewTime);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtInitial);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.linkLabel1);
            this.groupBox5.Controls.Add(this.txt_sampletime);
            this.groupBox5.Controls.Add(this.txt_samplenumber);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(28, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(353, 165);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sample Setting";
            // 
            // txtResetNewTime
            // 
            this.txtResetNewTime.Location = new System.Drawing.Point(157, 99);
            this.txtResetNewTime.Name = "txtResetNewTime";
            this.txtResetNewTime.Size = new System.Drawing.Size(121, 22);
            this.txtResetNewTime.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(157, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Reset New Time";
            // 
            // txtInitial
            // 
            this.txtInitial.Location = new System.Drawing.Point(6, 99);
            this.txtInitial.Name = "txtInitial";
            this.txtInitial.Size = new System.Drawing.Size(121, 22);
            this.txtInitial.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Initial Sampling Time";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(308, 137);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 15);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Save";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txt_sampletime
            // 
            this.txt_sampletime.Location = new System.Drawing.Point(6, 49);
            this.txt_sampletime.Name = "txt_sampletime";
            this.txt_sampletime.Size = new System.Drawing.Size(121, 22);
            this.txt_sampletime.TabIndex = 4;
            this.txt_sampletime.TextChanged += new System.EventHandler(this.txt_sampletime_TextChanged);
            // 
            // txt_samplenumber
            // 
            this.txt_samplenumber.Location = new System.Drawing.Point(157, 49);
            this.txt_samplenumber.Name = "txt_samplenumber";
            this.txt_samplenumber.Size = new System.Drawing.Size(121, 22);
            this.txt_samplenumber.TabIndex = 5;
            this.txt_samplenumber.TextChanged += new System.EventHandler(this.txt_samplenumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sample Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(157, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Qty Test";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.txtTaskName);
            this.groupBox1.Controls.Add(this.txtStation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 98);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Station";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(308, 55);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(32, 15);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Save";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(6, 52);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(121, 22);
            this.txtTaskName.TabIndex = 4;
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(157, 52);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(121, 22);
            this.txtStation.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Task Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(157, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Station";
            // 
            // Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 312);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sample";
            this.Load += new System.EventHandler(this.Sample_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txt_sampletime;
        private System.Windows.Forms.TextBox txt_samplenumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInitial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResetNewTime;
        private System.Windows.Forms.Label label7;
    }
}