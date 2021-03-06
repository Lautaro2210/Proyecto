using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            song.CreateControl();
        }
        AxWMPLib.AxWindowsMediaPlayer song = new AxWMPLib.AxWindowsMediaPlayer();
        string ruta = string.Empty;
        string archivo = string.Empty;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                archivo = ofd.SafeFileName;
                ruta = ofd.FileName;
                song.URL = ruta;
                song.settings.setMode("loop", true);
                song.Ctlcontrols.stop();
                lbCancion.Text = archivo;
                lbCancion.Location = new Point(this.ClientSize.Width / 2 - lbCancion.Width / 2, lbCancion.Location.Y);

            }
        }

        private void cbSL_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    if (cbSL.Checked)
                        ((CheckBox)c).Checked = true;
                    else
                        ((CheckBox)c).Checked = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dia = Application.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek).ToString();
            string hora = DateTime.Now.Hour.ToString("00");
            string minutos = DateTime.Now.Minute.ToString("00");

            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    if (dia == c.Text.ToLower().ToString() && minutos == tbtmin.Text.ToString() && hora == tbthora.Text.ToString())
                    {
                        try
                        {
                            song.Ctlcontrols.play();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }



                }
            }
        }

        private void btActivar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
