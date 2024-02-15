using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATSCADA;
using System.Timers;
using System.Threading;
using System.Configuration;
using System.Diagnostics;
using Aldila.Event;

namespace Aldila
{
    public partial class Prodution_Test : Form
    {
        static bool checkerr_min1 = false, checkerr_max1 = false, checkerr_Diam1 = false;
        static byte demCheckbtn = 0;
        static string strdata1 = "";
        DataTable dt_productest = new DataTable();
        DataTable temp = new DataTable();
        string[] rowDataS1 = { "", "", "", "", "", "" };
        public static DataTable logtable = new DataTable();
        static byte saveData = 0;
        SqlServer sql = new SqlServer();
        static string result1 = "";
        static bool s1 = false;
        static float Min1 = 0, Max1 = 0;
        static float demTong1 = 0;
        static byte demSoLanDoc1 = 0;
        static bool choPhepDocS1 = false;

        static float s1_value;
        static float Diameter1 = 0;
        List<ComboBox> lcbb_buildtype = new List<ComboBox>();
        static matketnoi sukien = new matketnoi();
        static Int16 DemSoLanDo = 0, SS1 = 0, SS2 = 0, SS3 = 0, SS4 = 0;

        //moi them
        static double giaTriDo = 0, giaTriDoTam = 0;
        static int demBaoNgungDo = 0;
        static ValueEvent newValueEvent = new ValueEvent();

        private void Diameter_s1_TextChanged(object sender, EventArgs e)
        {
            Diameter_s1.Focus();//đưa con trỏ về lại ô texbox1 sau mỗi lần nhận mã barcode
        }

        private void Diameter_s1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    newValueEvent.ValueChange = Convert.ToDouble(Diameter_s1.Text.Split(',')[2]);
                    Diameter_s1.Text = null;
                }
                catch
                {

                }
            }
        }

        public Prodution_Test()
        {
            InitializeComponent();
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
        private void Prodution_Test_Load(object sender, EventArgs e)
        {

            try
            {
                #region aaaaa
                labCountShaft.Text = "";
                temp.Clear();
                dt_productest.Clear();
                dgrid_ref.Rows.Clear();
                dgrid_ref.Columns.Clear();

                grbs1.Enabled = false;

                cbb_pos1.Enabled = false;
                //timer1.Enabled = true;
                // TODO: This line of code loads data into the 'aldilaDataSet.PartZM' table. You can move, or remove it, as needed.          

                foreach (Control ctr in grb_setup.Controls)
                {

                    if (ctr.GetType() == typeof(ComboBox) && (ctr.Name == "cbb_pos1" || ctr.Name == "cbb_pos2" || ctr.Name == "cbb_pos3" || ctr.Name == "cbb_pos4"))
                    {
                        string name = ctr.Name;
                        char end = ctr.Name[ctr.Name.Length - 1];
                        ((ComboBox)ctr).Items.Clear();
                        for (int j = 0; j < bienchung.lstrdata.Count; j++)
                        {
                            ((ComboBox)ctr).Items.Add(bienchung.lstrdata[j]);
                        }
                        if (bienchung.lstrdata.Count >= 3)
                        {
                            if (bienchung.number_of_pos <= 3)
                            {
                                if (ctr.Name == "cbb_pos1")
                                {
                                    ((ComboBox)ctr).Text = bienchung.lstrdata[0];
                                }
                                else if (ctr.Name == "cbb_pos2")
                                {
                                    ((ComboBox)ctr).Text = bienchung.lstrdata[1];
                                }
                                else if (ctr.Name == "cbb_pos3")
                                {
                                    ((ComboBox)ctr).Text = bienchung.lstrdata[2];
                                }

                                else if (ctr.Name == "cbb_pos4")
                                {
                                    ((ComboBox)ctr).Text = "";
                                }
                            }
                            else
                            {
                                if (ctr.Name == "cbb_pos1")
                                {
                                    ((ComboBox)ctr).Text = bienchung.lstrdata[0];
                                }
                                else if (ctr.Name == "cbb_pos2")
                                {
                                    ((ComboBox)ctr).Text = bienchung.lstrdata[1];
                                }
                                else if (ctr.Name == "cbb_pos3")
                                {
                                    ((ComboBox)ctr).Text = bienchung.lstrdata[2];
                                }

                                else if (ctr.Name == "cbb_pos4")
                                {
                                    ((ComboBox)ctr).Text = bienchung.lstrdata[3];
                                }
                            }
                        }
                    }
                    if (ctr.GetType() == typeof(ComboBox) && (ctr.Name == "cbb_buildtype1" || ctr.Name == "cbb_buildtype2" || ctr.Name == "cbb_buildtype3" || ctr.Name == "cbb_buildtype4"))
                    {
                        ((ComboBox)ctr).Text = "New";
                    }
                }
                lbl_part.Text = bienchung.part;
                lbl_workorder.Text = bienchung.workorder;
                lblbuildtype.Text = bienchung.buildtype;
                lblShaftType.Text = bienchung.shaftType;
                lblqt1.Text = bienchung.sample_number.ToString();

                dgrid_ref.Columns.Add("MeasurementType", "Measurement Type");
                dgrid_ref.Columns.Add("DiameterLowerLimit", "Diameter Lower Limit");
                dgrid_ref.Columns.Add("DiameterUpperLimit", "Diameter Upper Limit");
                dgrid_ref.Columns.Add("MinUnder", "Min Under");
                dgrid_ref.Columns.Add("MaxOver", "Max Over");
                dgrid_ref.Columns.Add("BuildType", "Build Type");
                //Add column to dgrid_real
                dgrid_ref.Columns["BuildType"].Width = 150;
                dgrid_ref.Columns["DiameterUpperLimit"].Width = 200;
                dgrid_ref.Columns["DiameterLowerLimit"].Width = 200;
                dgrid_ref.Columns["MaxOver"].Width = 100;
                dgrid_ref.Columns["MinUnder"].Width = 100;
                dgrid_ref.Columns["MeasurementType"].Width = 180;
                DataGridViewRow dr1 = new DataGridViewRow();
                dgrid_ref.Rows.Add(dr1);
                DataGridViewRow dr2 = new DataGridViewRow();
                dgrid_ref.Rows.Add(dr2);
                DataGridViewRow dr3 = new DataGridViewRow();
                dgrid_ref.Rows.Add(dr3);
                DataGridViewRow dr4 = new DataGridViewRow();
                dgrid_ref.Rows.Add(dr4);
                DataGridViewRow drreal1 = new DataGridViewRow();

                dt_productest = sql.SelectDataWhere_ds("PartZM", "ZMID,Diam_LL,Diam_UL,Min_Under,Max_Over ", "where PartID='" + bienchung.partvalue.ToString() + "'");
                if (dt_productest == null)
                {
                    sukien.Onthongbao();
                }
                temp = dt_productest.Copy();
                //change_ref();
                //Add content to data gridview
                //dgrid_ref.DataSource = temp;
                //strdata = sql.selectdatatheoid("PartZM", "Diam_LL,Diam_UL,Min_Under,Max_Over", "ZMID", Form1.dt.Rows[0][1].ToString());
                cbb_pos1.SelectedIndexChanged += Cbb_pos1_SelectedIndexChanged;

                chk_pos1.CheckStateChanged += chk_pos1_CheckStateChanged;

                DemSoLanDo = SS1 = SS2 = SS3 = SS4 = 0;
                var thread_s1 = System.Threading.Tasks.Task.Factory.StartNew(() => doc_s1());

                sukien.thongbao += Sukien_thongbao;
                #endregion

                //đăng ký sự kiện giá trị đo thay đổi
                newValueEvent.ValueChanged += (s, o) =>
                {
                    giaTriDo = o.valueChange + bienchung.offset;

                    //demBaoNgungDo = 0;

                    if (giaTriDo > bienchung.offset)
                    {
                        choPhepDocS1 = true;
                    }
                    else
                    {
                        choPhepDocS1 = false;
                        demSoLanDoc1 = 0;
                        labResult.Text = "0";
                    }
                };

                //đăng ký sự kiện Diameter
                //newDiameterValueEvent.ValueChanged += (s, o) =>
                //{

                //};

                txtTest.Visible = false;
                timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            try
            {
                if (giaTriDo != giaTriDoTam)
                {
                    giaTriDoTam = giaTriDo;
                    demBaoNgungDo = 0;
                }
                else
                {
                    demBaoNgungDo++;
                    if (demBaoNgungDo == bienchung.resetNewTime)
                    {
                        newValueEvent.ValueChange = 0;
                        //giaTriDo = giaTriDoTam = 0;
                    }
                    else if (demBaoNgungDo > bienchung.resetNewTime)
                    {
                        demBaoNgungDo = 100;
                    }
                }
                txtTest.Text = $"Dem ngung={demBaoNgungDo} |Gia tri do tam = { giaTriDoTam} | Gia tri do = { giaTriDo}";
            }
            catch
            {

            }

            timer1.Enabled = true;
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

        #region threa doc sensor
        void doc_s1()
        {
            while (true)
            {
                try
                {
                    if (InvokeRequired)
                    {
                        MethodInvoker fill = new MethodInvoker(delegate
                        {
                            #region Đếm số lần luu thanh cong
                            if (SS1 != 0)
                            {
                                DemSoLanDo = SS1;
                            }
                            else if (SS2 != 0)
                            {
                                DemSoLanDo = SS2;
                            }
                            else if (SS3 != 0)
                            {
                                DemSoLanDo = SS3;
                            }
                            else
                                DemSoLanDo = SS4;
                            //Debug.WriteLine(DemSoLanDo);
                            if (saveData == 1)
                            {
                                labCountShaft.Text = $"Total Production Shaft: {DemSoLanDo}";
                            }
                            else if (saveData == 2)
                            {
                                labCountShaft.Text = $"Total Pilot Shaft: {DemSoLanDo}";
                            }
                            #endregion
                            if (choPhepDocS1 == true && s1 == true)
                            {
                                //MessageBox.Show(bienchung.sample_number.ToString()+"||"+ bienchung.sample_time.ToString());
                                demSoLanDoc1++;
                                if (demSoLanDoc1 == 1)
                                {
                                    checkerr_min1 = checkerr_max1 = checkerr_Diam1 = false;
                                    Diameter1 = demTong1 = Min1 = Max1 = 0;
                                    grs1.Rows.Clear();
                                    panel_diameters1.BackColor = panel_max1.BackColor = panel_min1.BackColor = grs1.BackgroundColor = grbs1.BackColor;
                                    lbl_Max_Over1.Text = ""; lbl_Min_Under1.Text = ""; grs1.Rows.Clear();
                                }
                                //đọc các giá trị để lấy mẫu
                                if (demSoLanDoc1 < (bienchung.sample_number + bienchung.initial) && demSoLanDoc1 > bienchung.initial)
                                {
                                    s1_value = (float)giaTriDo;

                                    demTong1 += s1_value;
                                    if (Min1 == 0 && Max1 == 0)
                                    {
                                        Min1 = Max1 = demTong1;
                                    }
                                    if (s1_value >= Max1)
                                    {
                                        Max1 = s1_value;
                                    }
                                    if (s1_value <= Min1)
                                    {
                                        Min1 = s1_value;
                                    }

                                    #region fill data to grid view
                                    DataGridViewRow dr = new DataGridViewRow();
                                    grs1.Rows.Add(dr);
                                    grs1.Rows[demSoLanDoc1 - 1 - bienchung.initial].Cells[0].Value = demSoLanDoc1.ToString();
                                    grs1.Rows[demSoLanDoc1 - 1 - bienchung.initial].Cells[1].Value = Math.Round(s1_value, 2);

                                    if ((s1_value <= float.Parse(rowDataS1[2].ToString()) + float.Parse(rowDataS1[4].ToString())) && (s1_value >= float.Parse(rowDataS1[1].ToString()) - float.Parse(rowDataS1[3].ToString())))
                                    {
                                        grs1.Rows[demSoLanDoc1 - 1 - bienchung.initial].Cells[2].Value = "Passed";
                                        grs1.Rows[demSoLanDoc1 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Green;
                                    }
                                    else if (s1_value > float.Parse(rowDataS1[2].ToString()) + float.Parse(rowDataS1[4].ToString()))
                                    {
                                        checkerr_max1 = true;
                                        grs1.Rows[demSoLanDoc1 - 1 - bienchung.initial].Cells[2].Value = "Failed";
                                        grs1.Rows[demSoLanDoc1 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Red;
                                    }
                                    else if (s1_value < float.Parse(rowDataS1[1].ToString()) - float.Parse(rowDataS1[3].ToString()))
                                    {
                                        checkerr_min1 = true;
                                        grs1.Rows[demSoLanDoc1 - 1 - bienchung.initial].Cells[2].Value = "Failed";
                                        grs1.Rows[demSoLanDoc1 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Red;
                                    }
                                    #endregion
                                }
                                else if (demSoLanDoc1 == (bienchung.sample_number + bienchung.initial))
                                {
                                    s1_value = (float)giaTriDo;

                                    demTong1 += s1_value;
                                    if (s1_value >= Max1)
                                    {
                                        Max1 = s1_value;
                                    }
                                    if (s1_value <= Min1)
                                    {
                                        Min1 = s1_value;
                                    }

                                    Diameter1 = (float)(Math.Round(demTong1 / bienchung.sample_number, 2));
                                    labResult.Text = Diameter1.ToString();

                                    //Fill data to gridview 
                                    #region fill data to grid view end of time
                                    DataGridViewRow dr = new DataGridViewRow();
                                    grs1.Rows.Add(dr);
                                    grs1.Rows[demSoLanDoc1 - 1 - bienchung.initial].Cells[0].Value = demSoLanDoc1.ToString();
                                    grs1.Rows[demSoLanDoc1 - 1 - bienchung.initial].Cells[1].Value = Math.Round(s1_value, 2);

                                    if ((s1_value <= float.Parse(rowDataS1[2].ToString()) + float.Parse(rowDataS1[4].ToString())) && (s1_value >= float.Parse(rowDataS1[1].ToString()) - float.Parse(rowDataS1[3].ToString())))
                                    {
                                        grs1.Rows[demSoLanDoc1 - 1 - bienchung.initial].Cells[2].Value = "Passed";
                                        grs1.Rows[demSoLanDoc1 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Green;
                                    }
                                    else if (s1_value > float.Parse(rowDataS1[2].ToString()) + float.Parse(rowDataS1[4].ToString()))
                                    {
                                        checkerr_max1 = true;
                                        grs1.Rows[demSoLanDoc1 - 1 - bienchung.initial].Cells[2].Value = "Failed";
                                        grs1.Rows[demSoLanDoc1 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Red;
                                    }
                                    else if (s1_value < float.Parse(rowDataS1[1].ToString()) - float.Parse(rowDataS1[3].ToString()))
                                    {
                                        checkerr_min1 = true;
                                        grs1.Rows[demSoLanDoc1 - 1 - bienchung.initial].Cells[2].Value = "Failed";
                                        grs1.Rows[demSoLanDoc1 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Red;
                                    }

                                    if ((Diameter1 <= float.Parse(rowDataS1[2].ToString())) && (Diameter1 >= float.Parse(rowDataS1[1].ToString())))
                                    {
                                        panel_diameters1.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        panel_diameters1.BackColor = Color.Red;
                                        checkerr_Diam1 = true;
                                    }
                                    if (checkerr_max1 == true)
                                    {
                                        lbl_Max_Over1.Text = "NG";
                                        panel_max1.BackColor = Color.Red;
                                    }
                                    else
                                    {
                                        lbl_Max_Over1.Text = "OK";
                                        panel_max1.BackColor = Color.Green;
                                    }
                                    if (checkerr_min1 == true)
                                    {
                                        lbl_Min_Under1.Text = "NG";
                                        panel_min1.BackColor = Color.Red;
                                    }
                                    else
                                    {
                                        lbl_Min_Under1.Text = "OK";
                                        panel_min1.BackColor = Color.Green;
                                    }
                                    if (checkerr_Diam1 == true || checkerr_max1 == true || checkerr_min1 == true)
                                    {
                                        result1 = "Failed";
                                    }
                                    else
                                    {
                                        result1 = "Passed";
                                    }
                                    // Log data to database
                                    switch (saveData)
                                    {
                                        case 1:
                                            DataTable dt = sql.selectdatatheocot("DatalogZMike", "ShaftNum", "where MeasType='" + cbb_pos1.Text.Trim() + "' and Part = '" + bienchung.part + "' and WorkOrder='" + bienchung.workorder + "' and ShaftType='5' and DateTime >='" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00.0") + "' and DateTime <='" + DateTime.Now.ToString("yyyy-MM-dd 23:59:59.999") + "'");
                                            if (dt != null)
                                            {
                                                if (dt.Rows.Count < 5)
                                                {
                                                    if (sql.themData("DatalogZMike", "values('" + bienchung.tenMay + "','" + (dt.Rows.Count + 1).ToString() + "',getdate(),'" + bienchung.part + "','" + cbb_pos1.Text.Trim() + "','" + bienchung.workorder + "','" + Diameter1.ToString() + "','" + ((Max1 - Min1) / 2).ToString("0.000") + "','" + Max1.ToString("0.000") + "','" + Min1.ToString("0.000") + "','" + rowDataS1[2] + "','" + rowDataS1[1] + "','" + rowDataS1[4] + "','" + rowDataS1[3] + "','" + result1 + "','" + bienchung.buildtype + "','5')") != "GOOD")
                                                    {
                                                        sukien.Onthongbao();
                                                    }
                                                    else
                                                    {
                                                        SS1++;
                                                        //luu du lieu vao bang hien thi de web doc hien thi
                                                        //sql.UpdateCmd("ZMikeDisplay", $"Part='{bienchung.part}',WorkOrder='{bienchung.workorder}',MeasType='{cbb_pos1.Text.Trim()}',DiaReading={Diameter1.ToString()},Result='{result1}'", $"Station='OD Machine No.05' and SensorName='S1'");
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                sukien.Onthongbao();
                                            }
                                            break;
                                        case 2:
                                            DataTable dt1 = sql.selectdatatheocot("DatalogZMike", "ShaftNum", "where MeasType='" + cbb_pos1.Text.Trim() + "' and Part = '" + bienchung.part + "' and WorkOrder='" + bienchung.workorder + "' and ShaftType='all' and DateTime >='" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00.0") + "' and DateTime <='" + DateTime.Now.ToString("yyyy-MM-dd 23:59:59.999") + "'");
                                            if (dt1 != null)
                                            {
                                                if (sql.themData("DatalogZMike", "values('" + bienchung.tenMay + "','" + (dt1.Rows.Count + 1).ToString() + "',getdate(),'" + bienchung.part + "','" + cbb_pos1.Text.Trim() + "','" + bienchung.workorder + "','" + Diameter1.ToString() + "','" + ((Max1 - Min1) / 2).ToString("0.000") + "','" + Max1.ToString("0.000") + "','" + Min1.ToString("0.000") + "','" + rowDataS1[2] + "','" + rowDataS1[1] + "','" + rowDataS1[4] + "','" + rowDataS1[3] + "','" + result1 + "','" + bienchung.buildtype + "','all')") != "GOOD")
                                                {
                                                    sukien.Onthongbao();
                                                }
                                                else
                                                {
                                                    SS1++;
                                                    //luu du lieu vao bang hien thi de web doc hien thi
                                                    //sql.UpdateCmd("ZMikeDisplay", $"Part='{bienchung.part}',WorkOrder='{bienchung.workorder}',MeasType='{cbb_pos1.Text.Trim()}',DiaReading={Diameter1.ToString()},Result='{result1}'", $"Station='OD Machine No.05' and SensorName='S1'");
                                                }
                                            }
                                            else
                                            {
                                                sukien.Onthongbao();
                                            }
                                            break;
                                        default:
                                            break;
                                    }
                                    #endregion

                                }
                                else if (demSoLanDoc1 > (bienchung.sample_number + bienchung.initial))
                                {
                                    demSoLanDoc1 = Convert.ToByte(bienchung.sample_number + bienchung.initial);
                                }
                            }
                        });

                        Invoke(fill);
                    }
                }
                catch { }
                Thread.Sleep(bienchung.sample_time);
            }
        }
        #endregion
        #region cac radio button
        private void rbtnSave5_CheckedChanged(object sender, EventArgs e)
        {
            rbtnSave5.BackColor = Color.LightGreen;
            rbtnSaveAll.BackColor = SystemColors.Control;
            rbtnSaveNo.BackColor = SystemColors.Control;

        }

        private void rbtnSaveAll_CheckedChanged(object sender, EventArgs e)
        {
            rbtnSave5.BackColor = SystemColors.Control;
            rbtnSaveAll.BackColor = Color.LightGreen;
            rbtnSaveNo.BackColor = SystemColors.Control;
        }

        private void rbtnSaveNo_CheckedChanged(object sender, EventArgs e)
        {
            rbtnSave5.BackColor = SystemColors.Control;
            rbtnSaveAll.BackColor = SystemColors.Control;
            rbtnSaveNo.BackColor = Color.LightGreen;
        }
        #endregion

        #region cac ham va su kien
        bool KiemTraLap()
        {
            string[] mang = new string[4];
            if (chk_pos1.Checked == true)
            {
                mang[0] = cbb_pos1.Text;
            }
            else
            {
                mang[0] = null;
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    if (mang[i] != null)
                    {
                        if (mang[i] == mang[j])
                        {

                            return false;
                        }
                    }
                }
            }
            return true;
        }
        #endregion

        #region checkbox
        private void chk_pos1_CheckStateChanged(object sender, EventArgs e)
        {
            if (chk_pos1.Checked)
            {
                change_ref();
                grbs1.Enabled = true;
                cbb_pos1.Enabled = true;
                lblmt1.Text = cbb_pos1.Text;
            }
            else
            {
                for (int j = 0; j < 6; j++)
                {
                    dgrid_ref.Rows[0].Cells[j].Value = "";
                }
                panel_diameters1.BackColor = panel_max1.BackColor = panel_min1.BackColor = grs1.BackgroundColor = grbs1.BackColor;
                Diameter_s1.Text = "0"; lbl_Max_Over1.Text = ""; lbl_Min_Under1.Text = ""; grs1.Rows.Clear();
                labResult.Text = "0";
                grbs1.Enabled = false;
                cbb_pos1.Enabled = false;
            }

        }
        #endregion

        #region combobox
        private void Cbb_pos1_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_ref();
            lblmt1.Text = cbb_pos1.Text;
        }
        #endregion

        #region cac ham doc du lieu
        private void change_ref()
        {
            strdata1 = sql.selectdatatheoid("ZMmeasType", "ID", "Name", cbb_pos1.Text);
            for (int i = 0; i < temp.Rows.Count; i++)
            {

                if (temp.Rows[i][0].ToString() == strdata1 && chk_pos1.Checked == true)
                {

                    dgrid_ref.Rows[0].Cells[0].Value = rowDataS1[0] = cbb_pos1.Text;
                    dgrid_ref.Rows[0].Cells[1].Value = rowDataS1[1] = temp.Rows[i][1].ToString();
                    dgrid_ref.Rows[0].Cells[2].Value = rowDataS1[2] = temp.Rows[i][2].ToString();
                    dgrid_ref.Rows[0].Cells[3].Value = rowDataS1[3] = temp.Rows[i][3].ToString();
                    dgrid_ref.Rows[0].Cells[4].Value = rowDataS1[4] = temp.Rows[i][4].ToString();
                    dgrid_ref.Rows[0].Cells[5].Value = rowDataS1[5] = lblbuildtype.Text;
                }
                else if (!chk_pos1.Checked)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        dgrid_ref.Rows[0].Cells[j].Value = rowDataS1[j] = "";
                    }

                }
            }
        }
        #endregion
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnStartStop.Text.Trim() == "Stop")
                {
                    demCheckbtn = 0;
                    if (chk_pos1.Checked == false || (chk_pos1.Checked == true && cbb_pos1.Text.Trim() == "") || (rbtnSave5.Checked == false && rbtnSaveAll.Checked == false && rbtnSaveNo.Checked == false))
                    {
                        demCheckbtn++;
                    }

                    if (demCheckbtn == 0)
                    {
                        if (KiemTraLap())
                        {
                            if (chk_pos1.Checked == true)
                            {
                                s1 = true;
                            }
                            else
                            {
                                s1 = false;
                            }

                            if (rbtnSave5.Checked == true)
                            {
                                saveData = 1;
                            }
                            else if (rbtnSaveAll.Checked == true)
                            {
                                saveData = 2;
                            }
                            else if (rbtnSaveNo.Checked == true)
                            {
                                saveData = 0;
                            }
                            else
                            {
                                saveData = 0;
                            }
                            cbb_pos1.Enabled = false;

                            chk_pos1.Enabled = false;

                            rbtnSaveNo.Enabled = false;
                            rbtnSaveAll.Enabled = false;
                            rbtnSave5.Enabled = false;
                            btnStartStop.Text = "Start";
                            btnStartStop.BackColor = Color.Green;

                            Diameter_s1.Focus();
                            Diameter_s1.Text = "0";
                        }
                        else
                        {
                            MessageBox.Show("Meas Type cannot overlap!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please enter all the parameters!");
                    }

                }
                else if (btnStartStop.Text.Trim() == "Start")
                {
                    s1 = false;
                    demSoLanDoc1 = 0;
                    rbtnSaveNo.Enabled = true;
                    rbtnSaveAll.Enabled = true;
                    rbtnSave5.Enabled = true;
                    chk_pos1.Enabled = true;
                    if (chk_pos1.Checked == true)
                    {
                        cbb_pos1.Enabled = true;
                    }
                    btnStartStop.Text = "Stop";
                    btnStartStop.BackColor = Color.Red;

                    SS1 = SS2 = SS3 = SS4 = DemSoLanDo = 0;
                    labCountShaft.Text = "";
                }
            }
            catch
            {

            }
        }
        private void Prodution_Test_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}