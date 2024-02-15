using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aldila
{
    public partial class Form1 : Form
    {
        public  DataTable dt1 = new DataTable();
        public  DataTable dt = new DataTable();
        static matketnoi sukien = new matketnoi();
        public Form1()
        {
            InitializeComponent();

        }
        private void Sukien_thongbao(object sender, EventArgs e)
        {
            MessageBox.Show("No connection to the server!");
        }
        class matketnoi
        {
            public event EventHandler thongbao;
            public void Onthongbao()
            {
                if (thongbao != null)
                {
                    thongbao(this, EventArgs.Empty);
                }
            }
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDOWN = 161;
            const int WM_SYSCOMMAND = 274;
            const int HTCAPTION = 2;
            const int SC_MOVE = 61456;
            if ((m.Msg == WM_SYSCOMMAND) && (m.WParam.ToInt32() == SC_MOVE))
            {
                return;
            }
            if ((m.Msg == WM_NCLBUTTONDOWN) && (m.WParam.ToInt32() == HTCAPTION))
            {
                return;
            }

            base.WndProc(ref m);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dt1 = bienchung.sql.selectdatatheocot("Part", "Number,ID", "");
            if (dt1 != null)
            {
                if (dt1.Rows.Count != 0)
                {
                    cbb_part.DataSource = dt1;
                    cbb_part.DisplayMember = "Number";
                    cbb_part.ValueMember = "ID";
                }
            }
            else
            {
                MessageBox.Show("No connection to the server!");
            }
            //txtPart.Text= cbb_part.Text = "";
            cbb_part.Text = "";
            timer1.Enabled = true;
            cbb_part.SelectedIndexChanged += Cbb_part_SelectedIndexChanged;
            sukien.thongbao += Sukien_thongbao;
        }

        private void Cbb_part_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dt != null)
            {
                dt.Clear();
            }
            bienchung.lstrdata.Clear();
            grb_meas.Controls.Clear();
            //Lay ra ID cua nhung part gia tri nam trong cbb_part
            dt = bienchung.sql.SelectDataWhere("PartZM", "where PartID='" + cbb_part.SelectedValue + "'");

            List<Label> llbl = new List<Label>();
            if (dt != null)
            {
                if (dt.Rows.Count != 0)
                {
                    //comboBox1.Items.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Label lbli = new Label();
                        //Lay tung diem trong bang Measure
                        string strdata = bienchung.sql.selectdatatheoid("ZMmeasType", "Name", "ID", dt.Rows[i][1].ToString());
                        bienchung.lstrdata.Add(strdata);
                        //Add cbb to group 
                        llbl.Add(lbli);
                        llbl[i].Location = new Point(80, 36 + 40 * i);
                        llbl[i].Height = 23;
                        llbl[i].Width = 160;
                        llbl[i].Text = strdata;
                        llbl[i].Name = "pos" + i;
                        grb_meas.Controls.Add(llbl[i]);
                    }
                    //Lay so luong diem can do
                    bienchung.number_of_pos = llbl.Count;
                    //txtPart.Text = "";
                    txt_workorder.Focus();
                }
            }
            else
            {
                sukien.Onthongbao();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (!string.IsNullOrEmpty(txt_workorder.Text) && !string.IsNullOrEmpty(cbb_builttype.Text) && !string.IsNullOrEmpty(cbb_part.Text) && (rad_sanded.Checked == true || rad_unsanded.Checked == true))
            {
                btn_ok.Enabled = true;
            }
            else
                btn_ok.Enabled = false;
            timer1.Enabled = true;

        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            //this.Hide();
            try
            {
                bienchung.workorder = txt_workorder.Text;
                bienchung.part = cbb_part.Text;
                bienchung.partvalue = (int)cbb_part.SelectedValue;
                bienchung.buildtype = cbb_builttype.Text;
                if (rad_sanded.Checked)
                {
                    bienchung.shaftType = rad_sanded.Text;
                }
                else if (rad_unsanded.Checked)
                {
                    bienchung.shaftType = rad_unsanded.Text;
                }
                this.Close();
                Form frm = new Prodution_Test();
                frm.ShowDialog();
            }
            catch { MessageBox.Show("Check part code!"); }
        }

        //private void txtPart_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        if (txtPart.Text.Trim() != null && txtPart.Text.Trim() != "")
        //        {
        //            for (int i = 0; i < dt1.Rows.Count; i++)
        //            {
        //                if (txtPart.Text.Trim() == dt1.Rows[i][0].ToString())
        //                {
        //                    cbb_part.Text = txtPart.Text;
        //                    break;
        //                }
        //                else
        //                {
                            
        //                }
        //                if (i == dt1.Rows.Count-1)
        //                {
        //                    txtPart.Text = "";
        //                    MessageBox.Show("Part does not exist!");
        //                }
                       
        //            }
        //        }
                
        //    }
        //}

        private void cbb_part_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //MessageBox.Show("covo");
                if (cbb_part.Text.Trim() != null && cbb_part.Text.Trim() != "")
                {
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        if (cbb_part.Text.Trim() == dt1.Rows[i][0].ToString())
                        {
                            cbb_part.Text = cbb_part.Text;
                            break;
                        }
                        else
                        {

                        }
                        if (i == dt1.Rows.Count - 1)
                        {
                            cbb_part.Text = "";
                            MessageBox.Show("Part does not exist!");
                        }

                    }
                }

            }
        }
    }
}
