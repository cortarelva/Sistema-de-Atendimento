using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Atendimento
{
    public partial class Form1 : Form
    {
        Queue<string> numGeral = new Queue<string>();
        Queue<string> numPrio = new Queue<string>();
        int contadorGeral = 1;
        int contadorPrio = 1;
        int indexGeral = 0;
        int indexPrio = 0;
        int counterPrioritarias = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //botoes
        private void btnGeral_Click(object sender, EventArgs e)
        {
            char[] letraGeral = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            
            
            lblLetraGeral.Text = letraGeral[indexGeral].ToString();
            
            if(contadorGeral == 100)
            {
               indexGeral = indexGeral + 1;
               contadorGeral = 0; 
            }

            if (indexGeral > 25) { indexGeral = 0; }

            numGeral.Enqueue(lblGcaract.Text+" "+letraGeral[indexGeral] + " " + contadorGeral);

            lblLetraGeral.Text = letraGeral[indexGeral].ToString();
            lblNumGeral.Text = contadorGeral.ToString();
            lblSenhasEspera.Text = " ";

            contadorGeral++;
        }

        private void btnPrioritarios_Click(object sender, EventArgs e)
        {
            char[] letraPrio = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };


            lblLetraPrio.Text = letraPrio[indexPrio].ToString();

            if (contadorPrio == 100)
            {
                indexPrio = indexPrio + 1;
                contadorPrio = 0;
            }

            if (indexPrio > 25) { indexPrio = 0; }

            numPrio.Enqueue(lblPcaract.Text +" "+ letraPrio[indexPrio] + " " + contadorPrio);

            lblLetraPrio.Text = letraPrio[indexPrio].ToString();
            lblNumPrio.Text = contadorPrio.ToString();
            lblSenhasEspera.Text = " ";
            contadorPrio++;
            


        }

        
        //label das senhas geral
        private void lblLetraGeral_Click(object sender, EventArgs e)
        {
            
        }

        private void lblNumGeral_Click(object sender, EventArgs e)
        {
                     
        }
        //label senhas prio
        private void lblLetraPrio_Click(object sender, EventArgs e)
        {

        }

        private void lblNumPrio_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplayNum_Click(object sender, EventArgs e)
        {

        }

        private void lblPcaract_Click(object sender, EventArgs e)
        {

        }

        //Botoes dos guichets
        private void btnGuichet1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (numPrio.Count() > 0 || numGeral.Count() > 0)
            {
                if (counterPrioritarias < 3 && numPrio.Count() > 0)
                {
                    lblDisplayNum.Text = numPrio.Dequeue().ToString();
                    lblGiche.Text = btn.Text;
                    counterPrioritarias++;
                }
                else
                {
                    if(numGeral.Count() > 0)
                    {
                        lblDisplayNum.Text = numGeral.Dequeue().ToString();
                        lblGiche.Text = btn.Text;
                        counterPrioritarias = 0;
                    }
                    else { lblSenhasEspera.Text = "Não há senhas em espera"; }
                }
            }
            else { lblSenhasEspera.Text = "Não há senhas em espera"; }
        }

        private void btnGuichet2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (numPrio.Count() > 0 || numGeral.Count() > 0)
            {
                if (counterPrioritarias < 3 && numPrio.Count() > 0)
                {
                    lblDisplayNum.Text = numPrio.Dequeue().ToString();
                    lblGiche.Text = btn.Text;
                    counterPrioritarias++;
                }
                else
                {
                    if (numGeral.Count() > 0)
                    {
                        lblDisplayNum.Text = numGeral.Dequeue().ToString();
                        lblGiche.Text = btn.Text;
                        counterPrioritarias = 0;
                    }
                    else { lblSenhasEspera.Text = "Não há senhas em espera"; }
                }
            }
            else { lblSenhasEspera.Text = "Não há senhas em espera"; }
        }

        private void btnGuichet3_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            if (numPrio.Count() > 0 || numGeral.Count() > 0)
            {
                if (counterPrioritarias < 3 && numPrio.Count() > 0)
                {
                    lblDisplayNum.Text = numPrio.Dequeue().ToString();
                    lblGiche.Text = btn.Text;
                    counterPrioritarias++;
                }
                else
                {
                    if (numGeral.Count() > 0)
                    {
                        lblDisplayNum.Text = numGeral.Dequeue().ToString();
                        lblGiche.Text = btn.Text;
                        counterPrioritarias = 0;
                    }
                    else { lblSenhasEspera.Text = "Não há senhas em espera"; }
                }
            }
            else { lblSenhasEspera.Text = "Não há senhas em espera"; }
        }
        private void lblSenhasEspera_Click(object sender, EventArgs e)
        {
            
        }

    }//form
}//namespace
