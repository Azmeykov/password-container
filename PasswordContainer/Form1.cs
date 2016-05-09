using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordContainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //event registration
            textBox1.KeyUp += TextBoxKeyUp;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Do something
                e.Handled = true;
                if (textBox1.Text == "")
                {
                    //form closing
                    this.Hide();
                    //new form creation
                    Form2 form2 = new Form2();
                    form2.Show();
                }
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
