using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aldila
{
    public partial class Sample : Form
    {
        public Sample()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (txt_sampletime.Text.Trim() != "" && txt_samplenumber.Text.Trim() != "" && !string.IsNullOrWhiteSpace(txtResetNewTime.Text))
                {
                    if(Convert.ToInt16(txtResetNewTime.Text) >= 10)
                    {
                        bienchung.sample_time = Convert.ToInt16(txt_sampletime.Text.Trim());
                        bienchung.sample_number = Convert.ToByte(txt_samplenumber.Text.Trim());
                        bienchung.initial = Convert.ToByte(txtInitial.Text.Trim());
                        //bienchung.offset = Convert.ToDouble(txtOffset.Text.Trim());
                        bienchung.resetNewTime = Convert.ToInt16(txtResetNewTime.Text.Trim());

                        System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        config.AppSettings.Settings["Time"].Value = txt_sampletime.Text.Trim();
                        config.AppSettings.Settings["Qty"].Value = txt_samplenumber.Text.Trim();
                        config.AppSettings.Settings["Initial"].Value = txtInitial.Text.Trim();
                        //config.AppSettings.Settings["Offset"].Value = txtOffset.Text.Trim();
                        config.AppSettings.Settings["ResetNewTime"].Value = txtResetNewTime.Text.Trim();

                        config.Save(ConfigurationSaveMode.Modified);
                        ConfigurationManager.RefreshSection("appSettings");
                        MessageBox.Show("Update successful");
                    }
                    else
                    {
                        MessageBox.Show("'Reset New Time' >=10. Please try again!");
                    }
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }
            }
            catch
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (txtTaskName.Text.Trim() != "" && txtStation.Text.Trim() != "")
                {
                    bienchung.tenTask = txtTaskName.Text.Trim();
                    bienchung.tenMay = txtStation.Text.Trim();
                    System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["Station"].Value = txtStation.Text.Trim();
                    config.AppSettings.Settings["Task"].Value = txtTaskName.Text.Trim();
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                    MessageBox.Show("Update successful");
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }
            }
            catch
            {
                MessageBox.Show("Update Failed");
            }

        }

        private void Sample_Load(object sender, EventArgs e)
        {
            txt_samplenumber.Text = bienchung.sample_number.ToString();
            txt_sampletime.Text = bienchung.sample_time.ToString();
            txtStation.Text = bienchung.tenMay;
            txtTaskName.Text = bienchung.tenTask;
            txtInitial.Text = bienchung.initial.ToString();
            //txtOffset.Text = bienchung.offset.ToString();
            txtResetNewTime.Text = bienchung.resetNewTime.ToString();
        }

        private void txt_sampletime_TextChanged(object sender, EventArgs e)
        {
            decimal temp = new decimal();
            if (!decimal.TryParse(txt_sampletime.Text, out temp))
            {
                if (txt_sampletime.Text != "")
                {
                    MessageBox.Show("Please enter the number");
                }

            }

        }
        private void txt_samplenumber_TextChanged(object sender, EventArgs e)
        {
            decimal temp = new decimal();
            if (!decimal.TryParse(txt_samplenumber.Text, out temp))
            {
                if (txt_sampletime.Text != "")
                {
                    MessageBox.Show("Please enter the number");
                }
            }
        }
    }
}
