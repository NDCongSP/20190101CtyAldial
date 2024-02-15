namespace CloudServer
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
            this.iDriver1 = new ATSCADA.iDriver();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.iWebPort1 = new ATSCADA.iWinTools.iWebPort();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDriver1
            // 
            this.iDriver1.Designmode = false;
            this.iDriver1.GetTaskTimeOut = ((ulong)(5000ul));
            this.iDriver1.MaxTagWriteTimes = 10;
            this.iDriver1.ProjectFile = null;
            this.iDriver1.WaitingTime = 500;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(334, -15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "-";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem,
            this.vIEWToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 48);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // vIEWToolStripMenuItem
            // 
            this.vIEWToolStripMenuItem.Name = "vIEWToolStripMenuItem";
            this.vIEWToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.vIEWToolStripMenuItem.Text = "VIEW";
            this.vIEWToolStripMenuItem.Click += new System.EventHandler(this.vIEWToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "MFG Cloud";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // iWebPort1
            // 
            this.iWebPort1.Driver = this.iDriver1;
            this.iWebPort1.OnCloud = true;
            this.iWebPort1.RestartIISAfter = 0D;
            this.iWebPort1.ServerIP = "192.168.1.100";
            this.iWebPort1.WebPort = "8010";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(1, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "ip";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CloudServer.Properties.Resources.hinhadila;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(361, 169);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ATSCADA.iDriver iDriver1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private ATSCADA.iWinTools.iWebPort iWebPort1;
        private System.Windows.Forms.Label label2;
    }
}

