using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Aldila
{
    public partial class WorkForm : Form
    {
        MaHoaMD5 maHoa = new MaHoaMD5();
        fileText text = new fileText();
        public WorkForm()
        {
            InitializeComponent();
            ////lấy kích thước của màn hình
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;
            //cho form hiển thị theo kích thước của màn hình
            this.Width = widthScreen;
            this.Height = heightScreen;
            //lay ty le bang cach lay kich thuoc man hinh chia cho kich thuoc thiet ke
            //1088 là chiều rộng, 602 là chiều cao Form khi thiết kế, xem trong Properties của Form
            float WidthPerscpective = (float)widthScreen / 774;
            float HeightPerscpective = (float)heightScreen /464;//432
            //ResizeAllControls(this, WidthPerscpective, HeightPerscpective);
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
        private void WorkForm_Load(object sender, EventArgs e)
        {
            bienchung.ipcloud= ConfigurationManager.AppSettings["Ipcloud"];
            bienchung.tenMay = ConfigurationManager.AppSettings["Station"];
            bienchung.tenTask = ConfigurationManager.AppSettings["Task"];
            bienchung.sample_number =Convert.ToByte(ConfigurationManager.AppSettings["Qty"]);
            bienchung.initial = Convert.ToByte(ConfigurationManager.AppSettings["Initial"]);
            bienchung.sample_time = Convert.ToInt16(ConfigurationManager.AppSettings["Time"]);
            bienchung.chuoiKetNoiSqlServer = ConfigurationManager.AppSettings["SqlConstring"];
            bienchung.offset = Convert.ToDouble(ConfigurationManager.AppSettings["Offset"]);
            bienchung.resetNewTime = Convert.ToInt16(ConfigurationManager.AppSettings["ResetNewTime"]);


            this.Text = "OD            Test Station: " + bienchung.tenMay+ "           Connect To SQL Server " + bienchung.ipcloud; 
           // label3.Text = "Connect To Cloud Server " + bienchung.ipcloud;
            bienchung.key= text.read_text(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "licensekey.txt")).Trim();
            if (bienchung.key!="NULL")
            {
                try
                {
                    if (maHoa.Decrypt(bienchung.key, "ATPro9999") == bienchung.tenMay.Trim())
                    {
                        bienchung.khoa = true;
                    }
                    else { bienchung.khoa = false; }
                }
                catch { bienchung.khoa = false; }
            }
            else
            {
                bienchung.khoa = false;
            }
            Form fr = new LoadAnh();
            fr.ShowDialog();
        }
        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }


        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (bienchung.khoa == true)
            {
                Form fr = new Form1();
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("No license key!!!");
            }
        }

        private void WorkForm_Resize(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            //this.SendToBack();

        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {
          
                Form fr = new Sample();
                fr.ShowDialog();
          
        }
    }
}
