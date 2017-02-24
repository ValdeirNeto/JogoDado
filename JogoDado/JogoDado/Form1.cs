using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDado
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        int J1, J2;
        int soma1, soma2, rodadas;

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            J1 = rnd.Next(1, 7);
            MessageBox.Show(" Numero: " + J1);
            soma1 += J1;
            rodadas++;
            if(rodadas == 6)
            {
                vencedor();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            J2 = rnd.Next(1, 7);
            MessageBox.Show(" Numero: " + J2);
            soma2 += J2;
            rodadas++;
            if (rodadas == 6)
            {
                vencedor();
            }
        }

        public void vencedor()
        {
            if (soma1 > soma2)
            {
                MessageBox.Show("Jogador 1 venceu");
                rodadas = 0;
                
            }
            else if (soma1 < soma2)
            {
                MessageBox.Show("Jogador 2 Venceu");
                rodadas = 0;
            }
            else
            {
                MessageBox.Show("Empate");
                rodadas = 0;
            }
        }




    }
}
