using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LacoRepeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            int fim = int.Parse(txtFim.Text);
            if(numero > fim)
            {
                MessageBox.Show("O 1º valor precisa ser menor que o 2º");
                return;
            }

            lbResult.Items.Clear();

            for (int fator = numero; fator <= fim; fator++)
            {
                lbResult.Items.Add("Tabuada do " + fator);
                for (int i = 0; i < 11; i++)
                {
                    lbResult.Items.Add($" {fator} X {i} = {fator*i}");
                }
                lbResult.Items.Add("");
            }

        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            string[] animais = {"gato", "cachorro", "cobra", "cavalo", "coelho", "dinossauro"};
          
            for (int i = 0; i< animais.Length; i++)
            {
                lbResult.Items.Add(animais[i]);
            }
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            string[,] usuarios = {
                    {"Isadora", "usuario0", "123"},
                    {"Carlos",  "usuario1", "123"},
                    {"William", "usuario2", "123"},
                    {"João",    "usuario3", "123"},
                    {"Eder",    "usuario4", "123"},
                    {"Julio",   "usuario5", "123"}
            };

            lbResult.Items.Add("QTD DE ITENS NO ARRAY");
            lbResult.Items.Add(usuarios.GetLength(0));

            lbResult.Items.Add("QTD DE COLUNAS NO ARRAY");
            lbResult.Items.Add(usuarios.GetLength(1));

            lbResult.Items.Add("NOME DO 1º USUARIO NO ARRAY");
            lbResult.Items.Add(usuarios[0,0]);

            lbResult.Items.Add("NOME DO ULTIMO USUARIO NO ARRAY");
            lbResult.Items.Add(usuarios[usuarios.GetLength(0)-1, 0]);

            lbResult.Items.Add("TODOS OS USUARIOS CADASTRADOS");
            for(int i = 0; i< usuarios.GetLength(0); i++ )
            {
                lbResult.Items.Add(i + " - " + usuarios[i,0] + " / " + usuarios[i, 1]);
            }

            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            for(int i = 0; i < usuarios.GetLength(0); i++)
            {
                if(usuario == usuarios[i,1] && senha == usuarios[i,2])
                {
                    //MessageBox.Show("Usuario Encontrado Uhul, Boa Noite " + usuarios[i, 0].ToUpper());
                    lblNome.Text = "Usuario Encontrado Uhul, Boa Noite " + usuarios[i, 0].ToUpper();
                    return;
                }
            }

            MessageBox.Show("Usuario ou senha incorretos");
        }
    }
}
