using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace WindowsFormsApplication1
{
    public partial class Performance : Form
    {

      

        public Performance()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //ram or cpu ke previsous value load krta hy is se
            float fram = RAM.NextValue();
            float fcpu = CPU.NextValue();

            //Set value to cpu and ram
            progressBarcpu.Value = (int)fcpu;
            progressBarram.Value = (int)fram;

            //Update value to cpu and ram label

            _cpu.Text = string.Format("{0:0.00}%", fcpu);
            _ram.Text = string.Format("{0:0.00}%", fram);

            //Draw cpu and ram chart

            chart1.Series["CPU"].Points.AddY(fcpu);
            chart1.Series["RAM"].Points.AddY(fram);

            

  

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            


        }
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Performance_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
