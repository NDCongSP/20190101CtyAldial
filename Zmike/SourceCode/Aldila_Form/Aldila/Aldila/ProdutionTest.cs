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

namespace Aldila
{
    public partial class Prodution_Test : Form
    {
        static bool checkerr_min1 = false, checkerr_max1 = false, checkerr_Diam1 = false, checkerr_Diam2 = false, checkerr_Diam3 = false, checkerr_Diam4 = false, checkerr_min2 = false, checkerr_max2 = false, checkerr_min3 = false, checkerr_max3 = false, checkerr_min4 = false, checkerr_max4 = false;
        static byte demCheckbtn = 0;
        static string strdata1 = "", strdata2 = "", strdata3 = "", strdata4 = "";
        DataTable dt_productest = new DataTable();
        DataTable temp = new DataTable();
        string[] rowDataS1 = { "", "", "", "", "", "" };
        string[] rowDataS2 = { "", "", "", "", "", "" };
        string[] rowDataS3 = { "", "", "", "", "", "" };
        string[] rowDataS4 = { "", "", "", "", "", "" };
        public static DataTable logtable = new DataTable();
        static byte saveData = 0;
        SqlServer sql = new SqlServer();
        static string result1 = "", result2 = "", result3 = "", result4 = "";
        static bool s1 = false, s2 = false, s3 = false, s4 = false;
        static float Min1 = 0, Max1 = 0, Min2 = 0, Max2 = 0, Min3 = 0, Max3 = 0, Min4 = 0, Max4 = 0;
        static float demTong1 = 0, demTong2 = 0, demTong3 = 0, demTong4 = 0;
        static byte demSoLanDoc1 = 0, demSoLanDoc2 = 0, demSoLanDoc3 = 0, demSoLanDoc4 = 0;
        static bool choPhepDocS1 = false, choPhepDocS2 = false, choPhepDocS3 = false, choPhepDocS4 = false;
        static float s1_value, s2_value, s3_value, s4_value;
        static float Diameter1 = 0, Diameter2 = 0, Diameter3 = 0, Diameter4 = 0;
        List<ComboBox> lcbb_buildtype = new List<ComboBox>();
        static matketnoi sukien = new matketnoi();
        static Int16 DemSoLanDo = 0, SS1 = 0, SS2 = 0, SS3 = 0, SS4 = 0;
        public Prodution_Test()
        {
            InitializeComponent();
            iCloudTie1.CloudIP = bienchung.ipcloud.Trim();
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
                iDriver1.ConstructionCompleted += IDriver1_ConstructionCompleted;
                labCountShaft.Text = "";
                temp.Clear();
                dt_productest.Clear();
                dgrid_ref.Rows.Clear();
                dgrid_ref.Columns.Clear();
                grbs1.Enabled = false;
                grbs2.Enabled = false;
                grbs3.Enabled = false;
                grbs4.Enabled = false;
                cbb_pos1.Enabled = false;
                cbb_pos2.Enabled = false;
                cbb_pos3.Enabled = false;
                cbb_pos4.Enabled = false;
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
                lblqt1.Text = lblqt2.Text = lblqt3.Text = lblqt4.Text = bienchung.sample_number.ToString();

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
                cbb_pos2.SelectedIndexChanged += Cbb_pos2_SelectedIndexChanged;
                cbb_pos3.SelectedIndexChanged += Cbb_pos3_SelectedIndexChanged;
                cbb_pos4.SelectedIndexChanged += Cbb_pos4_SelectedIndexChanged;
                chk_pos1.CheckStateChanged += chk_pos1_CheckStateChanged;
                chk_pos2.CheckStateChanged += chk_pos2_CheckStateChanged;
                chk_pos3.CheckStateChanged += chk_pos3_CheckStateChanged;
                chk_pos4.CheckStateChanged += chk_pos4_CheckStateChanged;

                DemSoLanDo = SS1 = SS2 = SS3 = SS4 = 0;
                var thread_s1 = System.Threading.Tasks.Task.Factory.StartNew(() => doc_s1());
                var thread_s2 = System.Threading.Tasks.Task.Factory.StartNew(() => doc_s2());
                var thread_s3 = System.Threading.Tasks.Task.Factory.StartNew(() => doc_s3());
                var thread_s4 = System.Threading.Tasks.Task.Factory.StartNew(() => doc_s4());

                sukien.thongbao += Sukien_thongbao;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
        private void IDriver1_ConstructionCompleted()
        {
            //Doc gia tri dau cua cac cam bien
            try
            {
                if (InvokeRequired)
                {
                    MethodInvoker load = new MethodInvoker(delegate
                    {
                        iDriver1.Task(bienchung.tenTask).Tag("S4").TagValueChanged += S4TagValueChanged;
                        iDriver1.Task(bienchung.tenTask).Tag("S3").TagValueChanged += S3TagValueChanged;
                        iDriver1.Task(bienchung.tenTask).Tag("S2").TagValueChanged += S2TagValueChanged;
                        iDriver1.Task(bienchung.tenTask).Tag("S1").TagValueChanged += S1TagValueChanged;
                        iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Station").Value = bienchung.tenMay;
                        iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Part").Value = bienchung.part;
                        iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("WorkOrder").Value = bienchung.workorder;
                        iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("S4").Value = "";
                        iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("MeasType4").Value = "";
                        iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Result4").Value = "";
                        iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("S3").Value = "";
                        iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("MeasType3").Value = "";
                        iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Result3").Value = "";
                        iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("S2").Value = "";
                        iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("MeasType2").Value = "";
                        iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Result2").Value = "";
                        iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("S1").Value = "";
                        iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("MeasType1").Value = "";
                        iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Result1").Value = "";

                    });

                    Invoke(load);
                }
            }
            catch (Exception)
            {

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
                            Debug.WriteLine(DemSoLanDo);
                            if (saveData==1)
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
                                    Diameter_s1.Text = "0"; lbl_Max_Over1.Text = ""; lbl_Min_Under1.Text = ""; grs1.Rows.Clear();
                                }
                                if (demSoLanDoc1 < (bienchung.sample_number + bienchung.initial) && demSoLanDoc1 > bienchung.initial)
                                {

                                    s1_value = (float)(Math.Round(float.Parse(iDriver1.Task(bienchung.tenTask).Tag("S1").Value), 2));
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
                                    grs1.Rows[demSoLanDoc1 - 1 - bienchung.initial].Cells[1].Value = s1_value;

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

                                    //s1_value = float.Parse(iDriver1.Task(bienchung.tenTask).Tag("S1").Value);
                                    s1_value = (float)(Math.Round(float.Parse(iDriver1.Task(bienchung.tenTask).Tag("S1").Value), 2));
                                    demTong1 += s1_value;
                                    if (s1_value >= Max1)
                                    {
                                        Max1 = s1_value;
                                    }
                                    if (s1_value <= Min1)
                                    {
                                        Min1 = s1_value;
                                    }
                                    //Diameter1 = demTong1 / bienchung.sample_number;
                                    Diameter1 = (float)(Math.Round(demTong1 / bienchung.sample_number, 2));
                                    //Fill data to gridview 
                                    #region fill data to grid view end of time

                                    DataGridViewRow dr = new DataGridViewRow();
                                    grs1.Rows.Add(dr);
                                    grs1.Rows[demSoLanDoc1 - 1 - bienchung.initial].Cells[0].Value = demSoLanDoc1.ToString();
                                    grs1.Rows[demSoLanDoc1 - 1 - bienchung.initial].Cells[1].Value = s1_value;

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
                                    //Diameter_s1.Text = Diameter1.ToString("0.000");
                                    Diameter_s1.Text = Diameter1.ToString();

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
                                    iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("S1").Value = Diameter1.ToString();
                                    iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("MeasType1").Value = cbb_pos1.Text.Trim();
                                    iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Result1").Value = result1;
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
                                                    SS1++;
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
                                if (demSoLanDoc1 >= (bienchung.sample_number + bienchung.initial))
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
        void doc_s2()
        {

            while (true)
            {
                try
                {
                    if (InvokeRequired)
                    {
                        MethodInvoker fill = new MethodInvoker(delegate
                        {
                            if (choPhepDocS2 == true && s2 == true)
                            {
                                demSoLanDoc2++;
                                if (demSoLanDoc2 == 1)
                                {
                                    checkerr_min2 = checkerr_max2 = checkerr_Diam2 = false;
                                    Diameter2 = demTong2 = Min2 = Max2 = 0;
                                    grs2.Rows.Clear();
                                    panel_diameters2.BackColor = panel_max2.BackColor = panel_min2.BackColor = grs2.BackgroundColor = grbs2.BackColor;
                                    Diameter_s2.Text = "0"; lbl_Max_Over2.Text = ""; lbl_Min_Under2.Text = ""; grs2.Rows.Clear();
                                }
                                if (demSoLanDoc2 < (bienchung.sample_number + bienchung.initial) && demSoLanDoc2 > bienchung.initial)
                                {
                                    s2_value = (float)(Math.Round(float.Parse(iDriver1.Task(bienchung.tenTask).Tag("S2").Value), 2));
                                    demTong2 += s2_value;
                                    if (Min2 == 0 && Max2 == 0)
                                    {
                                        Min2 = Max2 = demTong2;
                                    }
                                    if (s2_value >= Max2)
                                    {
                                        Max2 = s2_value;
                                    }
                                    if (s2_value <= Min2)
                                    {
                                        Min2 = s2_value;
                                    }
                                    #region fill data to grid view

                                    DataGridViewRow dr = new DataGridViewRow();
                                    grs2.Rows.Add(dr);
                                    grs2.Rows[demSoLanDoc2 - 1 - bienchung.initial].Cells[0].Value = demSoLanDoc2.ToString();
                                    grs2.Rows[demSoLanDoc2 - 1 - bienchung.initial].Cells[1].Value = s2_value;
                                    if ((s2_value <= float.Parse(rowDataS2[2].ToString()) + float.Parse(rowDataS2[4].ToString())) && (s2_value >= float.Parse(rowDataS2[1].ToString()) - float.Parse(rowDataS2[3].ToString())))
                                    {
                                        grs2.Rows[demSoLanDoc2 - 1 - bienchung.initial].Cells[2].Value = "Passed";
                                        grs2.Rows[demSoLanDoc2 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Green;
                                    }
                                    else if (s2_value > float.Parse(rowDataS2[2].ToString()) + float.Parse(rowDataS2[4].ToString()))
                                    {
                                        checkerr_max2 = true;
                                        grs2.Rows[demSoLanDoc2 - 1 - bienchung.initial].Cells[2].Value = "Failed";
                                        grs2.Rows[demSoLanDoc2 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Red;
                                    }
                                    else if (s2_value < float.Parse(rowDataS2[1].ToString()) - float.Parse(rowDataS2[3].ToString()))
                                    {
                                        checkerr_min2 = true;
                                        grs2.Rows[demSoLanDoc2 - 1 - bienchung.initial].Cells[2].Value = "Failed";
                                        grs2.Rows[demSoLanDoc2 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Red;
                                    }
                                    #endregion
                                }
                                else if (demSoLanDoc2 == (bienchung.sample_number + bienchung.initial))
                                {
                                    //s2_value = float.Parse(iDriver1.Task(bienchung.tenTask).Tag("S2").Value);
                                    s2_value = (float)(Math.Round(float.Parse(iDriver1.Task(bienchung.tenTask).Tag("S2").Value), 2));
                                    demTong2 += s2_value;
                                    if (s2_value >= Max2)
                                    {
                                        Max2 = s2_value;
                                    }
                                    if (s2_value <= Min2)
                                    {
                                        Min2 = s2_value;
                                    }
                                    //Diameter2 = demTong2 / bienchung.sample_number;
                                    Diameter2 = (float)(Math.Round(demTong2 / bienchung.sample_number, 2));
                                    #region fill data to grid view end of time

                                    DataGridViewRow dr = new DataGridViewRow();
                                    grs2.Rows.Add(dr);
                                    grs2.Rows[demSoLanDoc2 - 1 - bienchung.initial].Cells[0].Value = demSoLanDoc2.ToString();
                                    grs2.Rows[demSoLanDoc2 - 1 - bienchung.initial].Cells[1].Value = s2_value;

                                    if ((s2_value <= float.Parse(rowDataS2[2].ToString()) + float.Parse(rowDataS2[4].ToString())) && (s2_value >= float.Parse(rowDataS2[1].ToString()) - float.Parse(rowDataS2[3].ToString())))
                                    {
                                        grs2.Rows[demSoLanDoc2 - 1 - bienchung.initial].Cells[2].Value = "Passed";
                                        grs2.Rows[demSoLanDoc2 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Green;
                                    }
                                    else if (s2_value > float.Parse(rowDataS2[2].ToString()) + float.Parse(rowDataS2[4].ToString()))
                                    {
                                        checkerr_max2 = true;
                                        grs2.Rows[demSoLanDoc2 - 1 - bienchung.initial].Cells[2].Value = "Failed";
                                        grs2.Rows[demSoLanDoc2 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Red;
                                    }
                                    else if (s2_value < float.Parse(rowDataS2[1].ToString()) - float.Parse(rowDataS2[3].ToString()))
                                    {
                                        checkerr_min2 = true;
                                        grs2.Rows[demSoLanDoc2 - 1 - bienchung.initial].Cells[2].Value = "Failed";
                                        grs2.Rows[demSoLanDoc2 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Red;
                                    }
                                    Diameter_s2.Text = Diameter2.ToString();
                                    if ((Diameter2 <= float.Parse(rowDataS2[2].ToString())) && (Diameter2 >= float.Parse(rowDataS2[1].ToString())))
                                    {
                                        panel_diameters2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        panel_diameters2.BackColor = Color.Red;
                                        checkerr_Diam2 = true;
                                    }
                                    if (checkerr_max2 == true)
                                    {
                                        lbl_Max_Over2.Text = "NG";
                                        panel_max2.BackColor = Color.Red;
                                    }
                                    else
                                    {
                                        lbl_Max_Over2.Text = "OK";
                                        panel_max2.BackColor = Color.Green;
                                    }
                                    if (checkerr_min2 == true)
                                    {
                                        lbl_Min_Under2.Text = "NG";
                                        panel_min2.BackColor = Color.Red;
                                    }
                                    else
                                    {
                                        lbl_Min_Under2.Text = "OK";
                                        panel_min2.BackColor = Color.Green;
                                    }
                                    if (checkerr_Diam2 == true || checkerr_max2 == true || checkerr_min2 == true)
                                    {
                                        result2 = "Failed";
                                    }
                                    else
                                    {
                                        result2 = "Passed";
                                    }
                                    iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("S2").Value = Diameter2.ToString();
                                    //iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Part").Value = bienchung.part;
                                    //iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("WorkOrder").Value = bienchung.workorder;
                                    iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("MeasType2").Value = cbb_pos2.Text.Trim();
                                    iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Result2").Value = result2;
                                    switch (saveData)
                                    {
                                        case 1:
                                            DataTable dt = sql.selectdatatheocot("DatalogZMike", "ShaftNum", "where MeasType='" + cbb_pos2.Text.Trim() + "' and Part = '" + bienchung.part + "' and WorkOrder='" + bienchung.workorder + "' and ShaftType='5' and DateTime >='" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00.0") + "' and DateTime <='" + DateTime.Now.ToString("yyyy-MM-dd 23:59:59.999") + "'");
                                            if (dt != null)
                                            {
                                                if (dt.Rows.Count < 5)
                                                {
                                                    if (sql.themData("DatalogZMike", "values('" + bienchung.tenMay + "','" + (dt.Rows.Count + 1).ToString() + "',getdate(),'" + bienchung.part + "','" + cbb_pos2.Text.Trim() + "','" + bienchung.workorder + "','" + Diameter2.ToString() + "','" + ((Max2 - Min2) / 2).ToString("0.000") + "','" + Max2.ToString("0.000") + "','" + Min2.ToString("0.000") + "','" + rowDataS2[2] + "','" + rowDataS2[1] + "','" + rowDataS2[4] + "','" + rowDataS2[3] + "','" + result2 + "','" + bienchung.buildtype + "','5')") != "GOOD")
                                                    {
                                                        sukien.Onthongbao();
                                                    }
                                                    else
                                                    {
                                                        SS2++;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                sukien.Onthongbao();
                                            }
                                            break;
                                        case 2:
                                            DataTable dt1 = sql.selectdatatheocot("DatalogZMike", "ShaftNum", "where MeasType='" + cbb_pos2.Text.Trim() + "' and Part = '" + bienchung.part + "' and WorkOrder='" + bienchung.workorder + "' and ShaftType='all' and DateTime >='" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00.0") + "' and DateTime <='" + DateTime.Now.ToString("yyyy-MM-dd 23:59:59.999") + "'");
                                            if (dt1 != null)
                                            {
                                                if (sql.themData("DatalogZMike", "values('" + bienchung.tenMay + "','" + (dt1.Rows.Count + 1).ToString() + "',getdate(),'" + bienchung.part + "','" + cbb_pos2.Text.Trim() + "','" + bienchung.workorder + "','" + Diameter2.ToString() + "','" + ((Max2 - Min2) / 2).ToString("0.000") + "','" + Max2.ToString("0.000") + "','" + Min2.ToString("0.000") + "','" + rowDataS2[2] + "','" + rowDataS2[1] + "','" + rowDataS2[4] + "','" + rowDataS2[3] + "','" + result2 + "','" + bienchung.buildtype + "','all')") != "GOOD")
                                                {
                                                    sukien.Onthongbao();
                                                }
                                                else
                                                {
                                                    SS2++;
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
                                if (demSoLanDoc2 >= (bienchung.sample_number + bienchung.initial))
                                {
                                    demSoLanDoc2 = Convert.ToByte(bienchung.sample_number + bienchung.initial);
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
        void doc_s3()
        {
            while (true)
            {
                try
                {
                    if (InvokeRequired)
                    {
                        MethodInvoker fill = new MethodInvoker(delegate
                        {
                            if (choPhepDocS3 == true && s3 == true)
                            {
                                demSoLanDoc3++;
                                if (demSoLanDoc3 == 1)
                                {
                                    checkerr_min3 = checkerr_max3 = checkerr_Diam2 = false;
                                    Diameter3 = demTong3 = Min3 = Max3 = 0;
                                    grs3.Rows.Clear();
                                    panel_diameters3.BackColor = panel_max3.BackColor = panel_min3.BackColor = grs3.BackgroundColor = grbs3.BackColor;
                                    Diameter_s3.Text = "0"; lbl_Max_Over3.Text = ""; lbl_Min_Under3.Text = ""; grs3.Rows.Clear();
                                }
                                if (demSoLanDoc3 < (bienchung.sample_number + bienchung.initial) && demSoLanDoc3 > bienchung.initial)
                                {
                                    //s3_value = float.Parse(iDriver1.Task(bienchung.tenTask).Tag("S3").Value);
                                    s3_value = (float)(Math.Round(float.Parse(iDriver1.Task(bienchung.tenTask).Tag("S3").Value), 2));
                                    demTong3 += s3_value;
                                    if (Min3 == 0 && Max3 == 0)
                                    {
                                        Min3 = Max3 = demTong3;
                                    }
                                    if (s3_value >= Max3)
                                    {
                                        Max3 = s3_value;
                                    }
                                    if (s3_value <= Min3)
                                    {
                                        Min3 = s3_value;
                                    }
                                    #region fill data to grid view

                                    DataGridViewRow dr = new DataGridViewRow();
                                    grs3.Rows.Add(dr);
                                    grs3.Rows[demSoLanDoc3 - 1 - bienchung.initial].Cells[0].Value = demSoLanDoc3.ToString();
                                    grs3.Rows[demSoLanDoc3 - 1 - bienchung.initial].Cells[1].Value = s3_value;
                                    if ((s3_value <= float.Parse(rowDataS3[2].ToString()) + float.Parse(rowDataS3[4].ToString())) && (s3_value >= float.Parse(rowDataS3[1].ToString()) - float.Parse(rowDataS3[3].ToString())))
                                    {
                                        grs3.Rows[demSoLanDoc3 - 1 - bienchung.initial].Cells[2].Value = "Passed";
                                        grs3.Rows[demSoLanDoc3 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Green;
                                    }
                                    else if (s3_value > float.Parse(rowDataS3[2].ToString()) + float.Parse(rowDataS3[4].ToString()))
                                    {
                                        checkerr_max3 = true;
                                        grs3.Rows[demSoLanDoc3 - 1 - bienchung.initial].Cells[2].Value = "Failed";
                                        grs3.Rows[demSoLanDoc3 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Red;
                                    }
                                    else if (s3_value < float.Parse(rowDataS3[1].ToString()) - float.Parse(rowDataS3[3].ToString()))
                                    {
                                        checkerr_min3 = true;
                                        grs3.Rows[demSoLanDoc3 - 1 - bienchung.initial].Cells[2].Value = "Failed";
                                        grs3.Rows[demSoLanDoc3 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Red;
                                    }




                                    #endregion
                                }
                                else if (demSoLanDoc3 == (bienchung.sample_number + bienchung.initial))
                                {
                                    //MessageBox.Show("ok2");
                                    //s3_value = float.Parse(iDriver1.Task(bienchung.tenTask).Tag("S3").Value);
                                    s3_value = (float)(Math.Round(float.Parse(iDriver1.Task(bienchung.tenTask).Tag("S3").Value), 2));
                                    demTong3 += s3_value;
                                    if (s3_value >= Max3)
                                    {
                                        Max3 = s3_value;
                                    }
                                    if (s3_value <= Min3)
                                    {
                                        Min3 = s3_value;
                                    }

                                    //Diameter3 = demTong3 / bienchung.sample_number;
                                    Diameter3 = (float)(Math.Round(demTong3 / bienchung.sample_number, 2));
                                    #region fill data to grid view end of time

                                    DataGridViewRow dr = new DataGridViewRow();
                                    grs3.Rows.Add(dr);
                                    grs3.Rows[demSoLanDoc3 - 1 - bienchung.initial].Cells[0].Value = demSoLanDoc3.ToString();
                                    grs3.Rows[demSoLanDoc3 - 1 - bienchung.initial].Cells[1].Value = s3_value;
                                    if ((s3_value <= float.Parse(rowDataS3[2].ToString()) + float.Parse(rowDataS3[4].ToString())) && (s3_value >= float.Parse(rowDataS3[1].ToString()) - float.Parse(rowDataS3[3].ToString())))
                                    {
                                        grs3.Rows[demSoLanDoc3 - 1 - bienchung.initial].Cells[2].Value = "Passed";
                                        grs3.Rows[demSoLanDoc3 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Green;
                                    }
                                    else if (s3_value > float.Parse(rowDataS3[2].ToString()) + float.Parse(rowDataS3[4].ToString()))
                                    {
                                        checkerr_max3 = true;
                                        grs3.Rows[demSoLanDoc3 - 1 - bienchung.initial].Cells[2].Value = "Failed";
                                        grs3.Rows[demSoLanDoc3 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Red;
                                    }
                                    else if (s3_value < float.Parse(rowDataS3[1].ToString()) - float.Parse(rowDataS3[3].ToString()))
                                    {
                                        checkerr_min3 = true;
                                        grs3.Rows[demSoLanDoc3 - 1 - bienchung.initial].Cells[2].Value = "Failed";
                                        grs3.Rows[demSoLanDoc3 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Red;
                                    }
                                    Diameter_s3.Text = Diameter3.ToString();
                                    if ((Diameter3 <= float.Parse(rowDataS3[2].ToString())) && (Diameter3 >= float.Parse(rowDataS3[1].ToString())))
                                    {
                                        panel_diameters3.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        panel_diameters3.BackColor = Color.Red;
                                        checkerr_Diam2 = true;
                                    }
                                    if (checkerr_max3 == true)
                                    {
                                        lbl_Max_Over3.Text = "NG";
                                        panel_max3.BackColor = Color.Red;
                                    }
                                    else
                                    {
                                        lbl_Max_Over3.Text = "OK";
                                        panel_max3.BackColor = Color.Green;
                                    }
                                    if (checkerr_min3 == true)
                                    {
                                        lbl_Min_Under3.Text = "NG";
                                        panel_min3.BackColor = Color.Red;
                                    }
                                    else
                                    {
                                        lbl_Min_Under3.Text = "OK";
                                        panel_min3.BackColor = Color.Green;
                                    }
                                    if (checkerr_Diam3 == true || checkerr_max3 == true || checkerr_min3 == true)
                                    {
                                        result3 = "Failed";
                                    }
                                    else
                                    {
                                        result3 = "Passed";
                                    }
                                    iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("S3").Value = Diameter3.ToString();
                                    //iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Part").Value = bienchung.part;
                                    //iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("WorkOrder").Value = bienchung.workorder;
                                    iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("MeasType3").Value = cbb_pos3.Text.Trim();
                                    iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Result3").Value = result3;
                                    switch (saveData)
                                    {
                                        case 1:
                                            DataTable dt = sql.selectdatatheocot("DatalogZMike", "ShaftNum", "where MeasType='" + cbb_pos3.Text.Trim() + "' and Part = '" + bienchung.part + "' and WorkOrder='" + bienchung.workorder + "' and ShaftType='5' and DateTime >='" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00.0") + "' and DateTime <='" + DateTime.Now.ToString("yyyy-MM-dd 23:59:59.999") + "'");
                                            if (dt != null)
                                            {
                                                if (dt.Rows.Count < 5)
                                                {
                                                    if (sql.themData("DatalogZMike", "values('" + bienchung.tenMay + "','" + (dt.Rows.Count + 1).ToString() + "',getdate(),'" + bienchung.part + "','" + cbb_pos3.Text.Trim() + "','" + bienchung.workorder + "','" + Diameter3.ToString() + "','" + ((Max3 - Min3) / 2).ToString("0.000") + "','" + Max3.ToString("0.000") + "','" + Min3.ToString("0.000") + "','" + rowDataS3[2] + "','" + rowDataS3[1] + "','" + rowDataS3[4] + "','" + rowDataS3[3] + "','" + result3 + "','" + bienchung.buildtype + "','5')") != "GOOD")
                                                    {
                                                        sukien.Onthongbao();
                                                    }
                                                    else
                                                    {
                                                        SS3++;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                sukien.Onthongbao();
                                            }
                                            break;
                                        case 2:
                                            DataTable dt1 = sql.selectdatatheocot("DatalogZMike", "ShaftNum", "where MeasType='" + cbb_pos3.Text.Trim() + "' and Part = '" + bienchung.part + "' and WorkOrder='" + bienchung.workorder + "' and ShaftType='all' and DateTime >='" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00.0") + "' and DateTime <='" + DateTime.Now.ToString("yyyy-MM-dd 23:59:59.999") + "'");
                                            if (dt1 != null)
                                            {

                                                if (sql.themData("DatalogZMike", "values('" + bienchung.tenMay + "','" + (dt1.Rows.Count + 1).ToString() + "',getdate(),'" + bienchung.part + "','" + cbb_pos3.Text.Trim() + "','" + bienchung.workorder + "','" + Diameter3.ToString() + "','" + ((Max3 - Min3) / 2).ToString("0.000") + "','" + Max3.ToString("0.000") + "','" + Min3.ToString("0.000") + "','" + rowDataS3[2] + "','" + rowDataS3[1] + "','" + rowDataS3[4] + "','" + rowDataS3[3] + "','" + result3 + "','" + bienchung.buildtype + "','all')") != "GOOD")
                                                {
                                                    sukien.Onthongbao();
                                                }
                                                else
                                                {
                                                    SS3++;
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
                                if (demSoLanDoc3 >= (bienchung.sample_number + bienchung.initial))
                                {
                                    demSoLanDoc3 = Convert.ToByte(bienchung.sample_number + bienchung.initial);
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
        void doc_s4()
        {
            while (true)
            {
                try
                {
                    if (InvokeRequired)
                    {
                        MethodInvoker fill = new MethodInvoker(delegate
                        {
                            if (choPhepDocS4 == true && s4 == true)
                            {
                                demSoLanDoc4++;
                                if (demSoLanDoc4 == 1)
                                {
                                    checkerr_min4 = checkerr_max4 = checkerr_Diam4 = false;
                                    Diameter4 = demTong4 = Min4 = Max4 = 0;
                                    grs4.Rows.Clear();
                                    panel_diameters4.BackColor = panel_max4.BackColor = panel_min4.BackColor = grs4.BackgroundColor = grbs4.BackColor;
                                    Diameter_s4.Text = "0"; lbl_Max_Over4.Text = ""; lbl_Min_Under4.Text = ""; grs4.Rows.Clear();
                                }
                                if (demSoLanDoc4 < (bienchung.sample_number + bienchung.initial) && demSoLanDoc4 > bienchung.initial)
                                {
                                    //s4_value = float.Parse(iDriver1.Task(bienchung.tenTask).Tag("S4").Value);
                                    s4_value = (float)(Math.Round(float.Parse(iDriver1.Task(bienchung.tenTask).Tag("S4").Value), 2));
                                    demTong4 += s4_value;
                                    if (Min4 == 0 && Max4 == 0)
                                    {
                                        Min4 = Max4 = demTong4;
                                    }
                                    if (s4_value >= Max4)
                                    {
                                        Max4 = s4_value;
                                    }
                                    if (s4_value <= Min4)
                                    {
                                        Min4 = s4_value;
                                    }
                                    #region fill data to grid view

                                    DataGridViewRow dr = new DataGridViewRow();
                                    grs4.Rows.Add(dr);
                                    grs4.Rows[demSoLanDoc4 - 1 - bienchung.initial].Cells[0].Value = demSoLanDoc4.ToString();
                                    grs4.Rows[demSoLanDoc4 - 1 - bienchung.initial].Cells[1].Value = s4_value;
                                    if ((s4_value <= float.Parse(rowDataS4[2].ToString()) + float.Parse(rowDataS4[4].ToString())) && (s4_value >= float.Parse(rowDataS4[1].ToString()) - float.Parse(rowDataS4[3].ToString())))
                                    {
                                        grs4.Rows[demSoLanDoc4 - 1 - bienchung.initial].Cells[2].Value = "Passed";
                                        grs4.Rows[demSoLanDoc4 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Green;
                                    }
                                    else if (s4_value > float.Parse(rowDataS4[2].ToString()) + float.Parse(rowDataS4[4].ToString()))
                                    {
                                        checkerr_max4 = true;
                                        grs4.Rows[demSoLanDoc4 - 1 - bienchung.initial].Cells[2].Value = "Failed";
                                        grs4.Rows[demSoLanDoc4 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Red;
                                    }
                                    else if (s4_value < float.Parse(rowDataS4[1].ToString()) - float.Parse(rowDataS4[3].ToString()))
                                    {
                                        checkerr_min4 = true;
                                        grs4.Rows[demSoLanDoc4 - 1 - bienchung.initial].Cells[2].Value = "Failed";
                                        grs4.Rows[demSoLanDoc4 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Red;
                                    }



                                    #endregion
                                }
                                else if (demSoLanDoc4 == (bienchung.sample_number + bienchung.initial))
                                {
                                    //MessageBox.Show("ok2");
                                    //s4_value = float.Parse(iDriver1.Task(bienchung.tenTask).Tag("S4").Value);
                                    s4_value = (float)(Math.Round(float.Parse(iDriver1.Task(bienchung.tenTask).Tag("S4").Value), 2));
                                    demTong4 += s4_value;
                                    if (s4_value >= Max4)
                                    {
                                        Max4 = s4_value;
                                    }
                                    if (s4_value <= Min4)
                                    {
                                        Min4 = s4_value;
                                    }
                                    //Diameter4 = demTong4 / bienchung.sample_number;
                                    Diameter4 = (float)(Math.Round(demTong4 / bienchung.sample_number, 2));

                                    #region fill data to grid view end of time

                                    DataGridViewRow dr = new DataGridViewRow();
                                    grs4.Rows.Add(dr);
                                    grs4.Rows[demSoLanDoc4 - 1 - bienchung.initial].Cells[0].Value = demSoLanDoc4.ToString();
                                    grs4.Rows[demSoLanDoc4 - 1 - bienchung.initial].Cells[1].Value = s4_value;
                                    if ((s4_value <= float.Parse(rowDataS4[2].ToString()) + float.Parse(rowDataS4[4].ToString())) && (s4_value >= float.Parse(rowDataS4[1].ToString()) - float.Parse(rowDataS4[3].ToString())))
                                    {
                                        grs4.Rows[demSoLanDoc4 - 1 - bienchung.initial].Cells[2].Value = "Passed";
                                        grs4.Rows[demSoLanDoc4 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Green;
                                    }
                                    else if (s4_value > float.Parse(rowDataS4[2].ToString()) + float.Parse(rowDataS4[4].ToString()))
                                    {
                                        checkerr_max3 = true;
                                        grs4.Rows[demSoLanDoc4 - 1 - bienchung.initial].Cells[2].Value = "Failed";
                                        grs4.Rows[demSoLanDoc4 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Red;
                                    }
                                    else if (s4_value < float.Parse(rowDataS4[1].ToString()) - float.Parse(rowDataS4[3].ToString()))
                                    {
                                        checkerr_min3 = true;
                                        grs4.Rows[demSoLanDoc4 - 1 - bienchung.initial].Cells[2].Value = "Failed";
                                        grs4.Rows[demSoLanDoc4 - 1 - bienchung.initial].DefaultCellStyle.BackColor = Color.Red;
                                    }
                                    Diameter_s4.Text = Diameter4.ToString();
                                    if ((Diameter4 <= float.Parse(rowDataS4[2].ToString())) && (Diameter4 >= float.Parse(rowDataS4[1].ToString())))
                                    {
                                        panel_diameters4.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        panel_diameters4.BackColor = Color.Red;
                                        checkerr_Diam4 = true;
                                    }
                                    if (checkerr_max4 == true)
                                    {
                                        lbl_Max_Over4.Text = "NG";
                                        panel_max4.BackColor = Color.Red;
                                    }
                                    else
                                    {
                                        lbl_Max_Over4.Text = "OK";
                                        panel_max4.BackColor = Color.Green;
                                    }
                                    if (checkerr_min4 == true)
                                    {
                                        lbl_Min_Under4.Text = "NG";
                                        panel_min4.BackColor = Color.Red;
                                    }
                                    else
                                    {
                                        lbl_Min_Under4.Text = "OK";
                                        panel_min4.BackColor = Color.Green;
                                    }
                                    if (checkerr_Diam4 == true || checkerr_max4 == true || checkerr_min4 == true)
                                    {
                                        result4 = "Failed";
                                    }
                                    else
                                    {
                                        result4 = "Passed";
                                    }
                                    iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("S4").Value = Diameter4.ToString();
                                    //iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Part").Value = bienchung.part;
                                    //iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("WorkOrder").Value = bienchung.workorder;
                                    iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("MeasType4").Value = cbb_pos4.Text.Trim();
                                    iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Result4").Value = result4;
                                    switch (saveData)
                                    {
                                        case 1:
                                            DataTable dt = sql.selectdatatheocot("DatalogZMike", "ShaftNum", "where MeasType='" + cbb_pos4.Text.Trim() + "' and Part = '" + bienchung.part + "' and WorkOrder='" + bienchung.workorder + "' and ShaftType='5' and DateTime >='" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00.0") + "' and DateTime <='" + DateTime.Now.ToString("yyyy-MM-dd 23:59:59.999") + "'");
                                            if (dt != null)
                                            {
                                                if (dt.Rows.Count < 5)
                                                {
                                                    if (sql.themData("DatalogZMike", "values('" + bienchung.tenMay + "','" + (dt.Rows.Count + 1).ToString() + "',getdate(),'" + bienchung.part + "','" + cbb_pos4.Text.Trim() + "','" + bienchung.workorder + "','" + Diameter4.ToString() + "','" + ((Max4 - Min4) / 2).ToString("0.000") + "','" + Max4.ToString("0.000") + "','" + Min4.ToString("0.000") + "','" + rowDataS4[2] + "','" + rowDataS4[1] + "','" + rowDataS4[4] + "','" + rowDataS4[3] + "','" + result4 + "','" + bienchung.buildtype + "','5')") != "GOOD")
                                                    {
                                                        sukien.Onthongbao();
                                                    }
                                                    else
                                                    {
                                                        SS4++;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                sukien.Onthongbao();
                                            }
                                            break;
                                        case 2:
                                            DataTable dt1 = sql.selectdatatheocot("DatalogZMike", "ShaftNum", "where MeasType='" + cbb_pos4.Text.Trim() + "' and Part = '" + bienchung.part + "' and WorkOrder='" + bienchung.workorder + "' and ShaftType='all' and DateTime >='" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00.0") + "' and DateTime <='" + DateTime.Now.ToString("yyyy-MM-dd 23:59:59.999") + "'");
                                            if (dt1 != null)
                                            {

                                                if (sql.themData("DatalogZMike", "values('" + bienchung.tenMay + "','" + (dt1.Rows.Count + 1).ToString() + "',getdate(),'" + bienchung.part + "','" + cbb_pos4.Text.Trim() + "','" + bienchung.workorder + "','" + Diameter4.ToString() + "','" + ((Max4 - Min4) / 2).ToString("0.000") + "','" + Max4.ToString("0.000") + "','" + Min4.ToString("0.000") + "','" + rowDataS4[2] + "','" + rowDataS4[1] + "','" + rowDataS4[4] + "','" + rowDataS4[3] + "','" + result4 + "','" + bienchung.buildtype + "','all')") != "GOOD")
                                                {
                                                    sukien.Onthongbao();
                                                }
                                                else
                                                {
                                                    SS4++;
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
                                if (demSoLanDoc4 >= (bienchung.sample_number + bienchung.initial))
                                {
                                    demSoLanDoc4 = Convert.ToByte(bienchung.sample_number + bienchung.initial);
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
        #region  tagvaluchenge
        private void S1TagValueChanged(object o, TagValueEventArgs e)
        {

            if (iDriver1.Task(bienchung.tenTask).Tag("S1").Value != "0")
            {
                choPhepDocS1 = true;
            }
            else
            {
                choPhepDocS1 = false;
                demSoLanDoc1 = 0;
            }


        }
        private void S2TagValueChanged(object o, TagValueEventArgs e)
        {
            if (iDriver1.Task(bienchung.tenTask).Tag("S2").Value != "0")
            {
                choPhepDocS2 = true;
            }
            else
            {
                choPhepDocS2 = false;
                demSoLanDoc2 = 0;
            }
        }

        private void S3TagValueChanged(object o, TagValueEventArgs e)
        {
            if (iDriver1.Task(bienchung.tenTask).Tag("S3").Value != "0")
            {
                choPhepDocS3 = true;
            }
            else
            {
                choPhepDocS3 = false;
                demSoLanDoc3 = 0;
            }

        }

        private void S4TagValueChanged(object o, TagValueEventArgs e)
        {
            if (iDriver1.Task(bienchung.tenTask).Tag("S4").Value != "0")
            {
                choPhepDocS4 = true;
            }
            else
            {
                choPhepDocS4 = false;
                demSoLanDoc4 = 0;
            }
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
            if (chk_pos2.Checked == true)
            {
                mang[1] = cbb_pos2.Text;
            }
            else
            {
                mang[1] = null;
            }
            if (chk_pos3.Checked == true)
            {
                mang[2] = cbb_pos3.Text;
            }
            else
            {
                mang[2] = null;
            }
            if (chk_pos4.Checked == true)
            {
                mang[3] = cbb_pos4.Text;
            }
            else
            {
                mang[3] = null;
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
        private void chk_pos4_CheckStateChanged(object sender, EventArgs e)
        {
            if (chk_pos4.Checked == true)
            {
                change_ref();
                grbs4.Enabled = true;
                cbb_pos4.Enabled = true;
                lblmt4.Text = cbb_pos4.Text;
            }
            else
            {
                for (int j = 0; j < 6; j++)
                {
                    dgrid_ref.Rows[3].Cells[j].Value = "";
                }
                panel_diameters4.BackColor = panel_max4.BackColor = panel_min4.BackColor = grs4.BackgroundColor = grbs4.BackColor;
                Diameter_s4.Text = "0"; lbl_Max_Over4.Text = ""; lbl_Min_Under4.Text = ""; grs4.Rows.Clear();
                grbs4.Enabled = false;
                cbb_pos4.Enabled = false;
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("S4").Value = "";
                //iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Part").Value ="";
                //iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("WorkOrder").Value = "";
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("MeasType4").Value = "";
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Result4").Value = "";
            }

        }

        private void chk_pos3_CheckStateChanged(object sender, EventArgs e)
        {
            if (chk_pos3.Checked)
            {
                change_ref();
                grbs3.Enabled = true;
                cbb_pos3.Enabled = true;
                lblmt3.Text = cbb_pos3.Text;
            }
            else
            {

                for (int j = 0; j < 6; j++)
                {
                    dgrid_ref.Rows[2].Cells[j].Value = "";
                }
                panel_diameters3.BackColor = panel_max3.BackColor = panel_min3.BackColor = grs3.BackgroundColor = grbs3.BackColor;
                Diameter_s3.Text = "0"; lbl_Max_Over3.Text = ""; lbl_Min_Under3.Text = ""; grs3.Rows.Clear();
                grbs3.Enabled = false;
                cbb_pos3.Enabled = false;
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("S3").Value = "";
                //iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Part").Value = "";
                //iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("WorkOrder").Value = "";
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("MeasType3").Value = "";
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Result3").Value = "";
            }

        }

        private void chk_pos2_CheckStateChanged(object sender, EventArgs e)
        {
            if (chk_pos2.Checked)
            {
                change_ref();
                grbs2.Enabled = true;
                cbb_pos2.Enabled = true;
                lblmt2.Text = cbb_pos2.Text;
            }
            else
            {
                for (int j = 0; j < 6; j++)
                {
                    dgrid_ref.Rows[1].Cells[j].Value = "";
                }
                panel_diameters2.BackColor = panel_max2.BackColor = panel_min2.BackColor = grs2.BackgroundColor = grbs2.BackColor;
                Diameter_s2.Text = "0"; lbl_Max_Over2.Text = ""; lbl_Min_Under2.Text = ""; grs2.Rows.Clear();
                grbs2.Enabled = false;
                cbb_pos2.Enabled = false;
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("S2").Value = "";
                //iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Part").Value = "";
                //iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("WorkOrder").Value = "";
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("MeasType2").Value = "";
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Result2").Value = "";
            }

        }

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
                grbs1.Enabled = false;
                cbb_pos1.Enabled = false;
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("S1").Value = "";
                //iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Part").Value = "";
                //iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("WorkOrder").Value = "";
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("MeasType1").Value = "";
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Result1").Value = "";
            }

        }
        #endregion
        #region combobox

        private void Cbb_pos1_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_ref();
            lblmt1.Text = cbb_pos1.Text;
        }
        private void Cbb_pos2_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_ref();
            lblmt2.Text = cbb_pos2.Text;
        }
        private void Cbb_pos3_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_ref();
            lblmt3.Text = cbb_pos3.Text;
        }
        private void Cbb_pos4_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_ref();
            lblmt4.Text = cbb_pos4.Text;
        }
        #endregion
        #region cac ham doc du lieu
        private void change_ref()
        {
            strdata1 = sql.selectdatatheoid("ZMmeasType", "ID", "Name", cbb_pos1.Text);
            strdata2 = sql.selectdatatheoid("ZMmeasType", "ID", "Name", cbb_pos2.Text);
            strdata3 = sql.selectdatatheoid("ZMmeasType", "ID", "Name", cbb_pos3.Text);
            strdata4 = sql.selectdatatheoid("ZMmeasType", "ID", "Name", cbb_pos4.Text);
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
                if (temp.Rows[i][0].ToString() == strdata2 && chk_pos2.Checked == true)
                {

                    dgrid_ref.Rows[1].Cells[0].Value = rowDataS2[0] = cbb_pos2.Text;
                    dgrid_ref.Rows[1].Cells[1].Value = rowDataS2[1] = temp.Rows[i][1].ToString();
                    dgrid_ref.Rows[1].Cells[2].Value = rowDataS2[2] = temp.Rows[i][2].ToString();
                    dgrid_ref.Rows[1].Cells[3].Value = rowDataS2[3] = temp.Rows[i][3].ToString();
                    dgrid_ref.Rows[1].Cells[4].Value = rowDataS2[4] = temp.Rows[i][4].ToString();
                    dgrid_ref.Rows[1].Cells[5].Value = rowDataS2[5] = lblbuildtype.Text;

                    //dgrid_ref.Rows.Add(dr);

                }
                else if (!chk_pos2.Checked)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        dgrid_ref.Rows[1].Cells[j].Value = rowDataS2[j] = "";
                    }
                }

                if (temp.Rows[i][0].ToString() == strdata3 && chk_pos3.Checked == true)
                {

                    dgrid_ref.Rows[2].Cells[0].Value = rowDataS3[0] = cbb_pos3.Text;
                    dgrid_ref.Rows[2].Cells[1].Value = rowDataS3[1] = temp.Rows[i][1].ToString();
                    dgrid_ref.Rows[2].Cells[2].Value = rowDataS3[2] = temp.Rows[i][2].ToString();
                    dgrid_ref.Rows[2].Cells[3].Value = rowDataS3[3] = temp.Rows[i][3].ToString();
                    dgrid_ref.Rows[2].Cells[4].Value = rowDataS3[4] = temp.Rows[i][4].ToString();
                    dgrid_ref.Rows[2].Cells[5].Value = rowDataS3[5] = lblbuildtype.Text;
                }
                else if (!chk_pos3.Checked)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        dgrid_ref.Rows[2].Cells[j].Value = rowDataS3[j] = "";
                    }
                }

                if (temp.Rows[i][0].ToString() == strdata4 && chk_pos4.Checked == true)
                {

                    dgrid_ref.Rows[3].Cells[0].Value = rowDataS4[0] = cbb_pos4.Text;
                    dgrid_ref.Rows[3].Cells[1].Value = rowDataS4[1] = temp.Rows[i][1].ToString();
                    dgrid_ref.Rows[3].Cells[2].Value = rowDataS4[2] = temp.Rows[i][2].ToString();
                    dgrid_ref.Rows[3].Cells[3].Value = rowDataS4[3] = temp.Rows[i][3].ToString();
                    dgrid_ref.Rows[3].Cells[4].Value = rowDataS4[4] = temp.Rows[i][4].ToString();
                    dgrid_ref.Rows[3].Cells[5].Value = rowDataS4[5] = lblbuildtype.Text;
                    //dgrid_ref.Rows.Add(dr);

                }
                else if (!chk_pos4.Checked)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        dgrid_ref.Rows[3].Cells[j].Value = rowDataS4[j] = "";
                    }
                }

            }
        }
        #endregion
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text.Trim() == "Stop")
            {
                demCheckbtn = 0;
                if ((chk_pos1.Checked == false && chk_pos2.Checked == false && chk_pos3.Checked == false && chk_pos4.Checked == false) || (chk_pos1.Checked == true && cbb_pos1.Text.Trim() == "") || (rbtnSave5.Checked == false && rbtnSaveAll.Checked == false && rbtnSaveNo.Checked == false))
                {
                    demCheckbtn++;
                }
                if ((chk_pos1.Checked == false && chk_pos2.Checked == false && chk_pos3.Checked == false && chk_pos4.Checked == false) || (chk_pos2.Checked == true && cbb_pos2.Text.Trim() == "") || (rbtnSave5.Checked == false && rbtnSaveAll.Checked == false && rbtnSaveNo.Checked == false))
                {
                    demCheckbtn++;
                }
                if ((chk_pos1.Checked == false && chk_pos2.Checked == false && chk_pos3.Checked == false && chk_pos4.Checked == false) || (chk_pos3.Checked == true && cbb_pos3.Text.Trim() == "") || (rbtnSave5.Checked == false && rbtnSaveAll.Checked == false && rbtnSaveNo.Checked == false))
                {
                    demCheckbtn++;
                }
                if ((chk_pos1.Checked == false && chk_pos2.Checked == false && chk_pos3.Checked == false && chk_pos4.Checked == false) || (chk_pos4.Checked == true && cbb_pos4.Text.Trim() == "") || (rbtnSave5.Checked == false && rbtnSaveAll.Checked == false && rbtnSaveNo.Checked == false))
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
                        if (chk_pos2.Checked == true)
                        {
                            s2 = true;
                        }
                        else
                        {
                            s2 = false;
                        }
                        if (chk_pos3.Checked == true)
                        {
                            s3 = true;
                        }
                        else
                        {
                            s3 = false;
                        }
                        if (chk_pos4.Checked == true)
                        {
                            s4 = true;
                        }
                        else
                        {
                            s4 = false;
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
                        cbb_pos2.Enabled = false;
                        cbb_pos3.Enabled = false;
                        cbb_pos4.Enabled = false;
                        chk_pos1.Enabled = false;
                        chk_pos2.Enabled = false;
                        chk_pos3.Enabled = false;
                        chk_pos4.Enabled = false;
                        rbtnSaveNo.Enabled = false;
                        rbtnSaveAll.Enabled = false;
                        rbtnSave5.Enabled = false;
                        btnStartStop.Text = "Start";
                        btnStartStop.BackColor = Color.Green;
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
                s2 = false;
                s3 = false;
                s4 = false;
                demSoLanDoc1 = 0;
                demSoLanDoc2 = 0;
                demSoLanDoc3 = 0;
                demSoLanDoc4 = 0;
                rbtnSaveNo.Enabled = true;
                rbtnSaveAll.Enabled = true;
                rbtnSave5.Enabled = true;
                chk_pos1.Enabled = true;
                chk_pos2.Enabled = true;
                chk_pos3.Enabled = true;
                chk_pos4.Enabled = true;
                if (chk_pos1.Checked == true)
                {
                    cbb_pos1.Enabled = true;
                }
                if (chk_pos2.Checked == true)
                {
                    cbb_pos2.Enabled = true;
                }
                if (chk_pos3.Checked == true)
                {
                    cbb_pos3.Enabled = true;
                }
                if (chk_pos4.Checked == true)
                {
                    cbb_pos4.Enabled = true;
                }
                btnStartStop.Text = "Stop";
                btnStartStop.BackColor = Color.Red;

                SS1 = SS2 = SS3 = SS4 = DemSoLanDo = 0;
                labCountShaft.Text = "";
            }
        }
        private void Prodution_Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Station").Value = "";
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Part").Value = "";
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("WorkOrder").Value = "";
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("S4").Value = "";
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("MeasType4").Value = "";
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Result4").Value = "";
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("S3").Value = "";
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("MeasType3").Value = "";
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Result3").Value = "";
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("S2").Value = "";
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("MeasType2").Value = "";
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Result2").Value = "";
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("S1").Value = "";
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("MeasType1").Value = "";
                iDriver1.Task("InternalTask_" + bienchung.tenTask).Tag("Result1").Value = "";
            }
            catch { }
        }

    }
}