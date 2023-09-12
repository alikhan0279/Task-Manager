using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        p_methods pm = new p_methods();
        private void Form1_Load(object sender, EventArgs e)
        { //Total Process Show
           
            pm.GetProcess(listBox1);
            int total = pm.tot; 
            label1.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pm.kill(listBox1);
                pm.tot = 0;
                pm.GetProcess(listBox1);

                int total = pm.tot;
                label1.Text = total.ToString();
            }
            catch (Exception ex)
            {
                string a = "Please Select the Process to Kill";
                MessageBox.Show(a, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void runNewTskToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DETAILS FR = new DETAILS();
            FR.Show();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NewProcess form = new NewProcess())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    pm.GetProcess(listBox1);
                }

            }
        }

        private void dETAILSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // this.Hide();
            DETAILS FR = new DETAILS();
            FR.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pERFORMANCESToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pERFORMANCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Performance p2 = new Performance();
            p2.Show();
        }
    }
}
