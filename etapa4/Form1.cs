namespace ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = "Admin";
            string contraseņa = "Admin12345";
            textBox2.PasswordChar = '#';
            if (textBox1.Text == usuario || textBox1.Text == contraseņa)
            {
                MessageBox.Show("Autorizado a ingresar", "Ingresaste");
            }
            else
            {
                MessageBox.Show("Usuario o contraseņa incorrecta", "Error");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
