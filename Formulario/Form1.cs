namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

       
        private void button1_Click(object sender, EventArgs e)
        {


            string pass = textBox1.Text;
            int idade = (int)numericUpDown1.Value;
            string genero;
            if (radioButton1.Checked ) 
            { 
                genero = radioButton1.Text;
            }
            else if (radioButton2.Checked ) 
            {
                 genero = radioButton2.Text;
            }
            else { genero = "Indefinido"; }
            string profissao = "";

            
            switch (comboBox1.SelectedIndex)
            {
                case 0:  profissao = "Desempregado"; break;
                case 1:
                case 2:
                case 3:
                case 4: profissao = comboBox1.Text; break;
            }
            string movel = maskedTextBox1.Text;
            double peso = Convert.ToDouble(numericUpDown2.Value);

            string data = dateTimePicker1.Text;
            string cor = listBox2.Text;



            FormularioDois form2 = new FormularioDois();

            form2.ReceiveData(pass, idade, genero, profissao, movel, peso, data, cor);

            
            form2.Show();

        }
    }
}
