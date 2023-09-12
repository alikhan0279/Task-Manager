using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class DETAILS : Form
    {
        public DETAILS()
        {
            InitializeComponent();
        }


        p_methods PM = new p_methods();
        private void Form4_Load(object sender, EventArgs e)
        {
            PM.Detailss(listView1);
          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
