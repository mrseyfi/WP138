using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj138
{
    public partial class frmTest2 : Form
    {
        public frmTest2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTest1 f = new frmTest1();
            f.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num4 = 9;
            num4 = num4 + 1;
            num4++; 

            Class1 c = new Class1();
            c.num3 = 8;
        }

        private void btnDell_Click(object sender, EventArgs e)
        {
            //File.Copy()
            //File.Copy()
            //File.Copy()
            //File.Copy()


            File.Delete("c:\\test.txt");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.WriteAllText("c:\\test.txt", "testtest");
        }

        private void frmTest2_Load(object sender, EventArgs e)
        {

        }
    }
}
