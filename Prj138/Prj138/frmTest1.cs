using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj138
{
    public partial class frmTest1 : Form
    {
        public frmTest1()
        {
            InitializeComponent();
        }



        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = 156;
                int num2 = 5;
                int num3;
                num3 = num2;

                //textBox1.Text = num3.ToString();

                num3 = int.Parse(textBox1.Text);

                num3 = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("خطا");
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmTest2 f = new frmTest2();
            f.Show();
        }

        private void frmTest1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "\\1\r\n2\r\n3\r\n4\r\n\t5";

            textBox1.Text =
                            @"
                            1
                            2
                            3
                            4
                            5";

        }
    }
}
