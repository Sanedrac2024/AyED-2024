//Form1
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(texto1.Text, texto2.Text, texto3.Text, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked);
            form2.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void texto1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
//Form2
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio4
{
    public partial class Form2 : Form
    {
        public Form2(string recepcionTexto1, string recepcionTexto2, string recepcionTexto3, bool checkeadoBox1, bool checkeadoBox2, bool checkeadoBox3)
        {
            InitializeComponent();
            texto1.Text = recepcionTexto1;
            texto2.Text = recepcionTexto2;
            comboBox1.Text = recepcionTexto3;
            checkBox1.Checked = checkeadoBox1;
            checkBox2.Checked = checkeadoBox2;
            checkBox3.Checked = checkeadoBox3;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

