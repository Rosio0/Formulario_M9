using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Formulario
{
    public partial class FormularioDois : Form
    {
        public FormularioDois()
        {
            InitializeComponent();
        }
        public void ReceiveData(string Pw, int age, string gen, string prof, string nume, double wei, string data, string cor)
        {
            pass = Pw;
            id = age;
            gene = gen;
            profi = prof;
            numer = nume;
            pes = wei;
            dat = data;
            co = cor;

        }
        string pass, gene, profi, numer, dat, co;
        int id;
        double pes;

        private void button1_Click(object sender, EventArgs e)
        {
            string passw = textBox1.Text;
            if (passw == pass)
            {
                string message = $"Password: {pass}\nIdade: {id}\nGênero: {gene}\nProfissão: {profi}\nMóvel: {numer}\nPeso: {pes}\nData: {dat}\nCor: {co}";
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Password Invalida");
            }


        }
    }
}
