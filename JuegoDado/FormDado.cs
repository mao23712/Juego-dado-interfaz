using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoDado
{
    public partial class FormDado : Form
    {
        int minimo, maximo;
        

        public FormDado()
        {
            InitializeComponent();

        }
        private void FormDado_Load(object sender, EventArgs e)
        {

        }

        private void brn_volver_Click(object sender, EventArgs e)
        {
            FormJuego volver = new FormJuego();
            volver.Show();
            this.Hide();
        }

        private void check_menor_CheckedChanged(object sender, EventArgs e)
        {
            if (check_menor.Checked)
            {
                check_mayor.Enabled = false;
                minimo = 2;
                maximo = 6;
            }
            else
                check_mayor.Enabled = true;
        }

        private void check_mayor_CheckedChanged(object sender, EventArgs e)
        {
            if (check_mayor.Checked)
            {
                check_menor.Enabled = false;
                minimo = 8;
                maximo = 12;
            }
            else
                check_menor.Enabled = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btn_lanzar_Click(object sender, EventArgs e)
        {
            if (check_menor.Checked==true)
            { 
            
                int dado1 = Dado.Lanzar();
                int dado2 = Dado.Lanzar();
                int suma = dado1 + dado2;
                lbl_suma.Text = suma.ToString();
                switch(dado1)
                {
                    case 1:
                        pct_dado1.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado1.png");
                        break;
                    case 2:
                        pct_dado1.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado2.png");
                        break;
                    case 3:
                        pct_dado1.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado3.png");
                        break;
                    case 4:
                        pct_dado1.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado4.png");
                        break;
                    case 5:
                        pct_dado1.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado5.png");
                        break;
                    case 6:
                        pct_dado1.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado6.png");
                        break;
                }
                switch (dado2)
                {
                    case 1:
                        pct_dado2.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado1.png");
                        break;
                    case 2:
                        pct_dado2.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado2.png");
                        break;
                    case 3:
                        pct_dado2.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado3.png");
                        break;
                    case 4:
                        pct_dado2.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado4.png");
                        break;
                    case 5:
                        pct_dado2.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado5.png");
                        break;
                    case 6:
                        pct_dado2.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado6.png");
                        break;
                }
                if (suma == 7)
                {
                    MessageBox.Show("LA CASA GANA");
                    check_menor.Checked = false;
                    lbl_suma.Text = "0";
                }
                else if (suma >= minimo  && suma <= maximo )
                {
                    MessageBox.Show("¡Ganaste!");
                    check_menor.Checked = false;
                    lbl_suma.Text = "0";
                }
                else
                {
                    MessageBox.Show("LO SIENTO PERDISTE");
                    check_menor.Checked = false;
                    lbl_suma.Text = "0";
                }
            }
            else if(check_mayor.Checked==true)
            {
                int dado1 = Dado.Lanzar();
                int dado2 = Dado.Lanzar();
                int suma = dado1 + dado2;
                lbl_suma.Text = suma.ToString();
                switch (dado1)
                {
                    case 1:
                        pct_dado1.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado1.png");
                        break;
                    case 2:
                        pct_dado1.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado2.png");
                        break;
                    case 3:
                        pct_dado1.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado3.png");
                        break;
                    case 4:
                        pct_dado1.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado4.png");
                        break;
                    case 5:
                        pct_dado1.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado5.png");
                        break;
                    case 6:
                        pct_dado1.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado6.png");
                        break;
                }
                switch (dado2)
                {
                    case 1:
                        pct_dado2.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado1.png");
                        break;
                    case 2:
                        pct_dado2.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado2.png");
                        break;
                    case 3:
                        pct_dado2.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado3.png");
                        break;
                    case 4:
                        pct_dado2.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado4.png");
                        break;
                    case 5:
                        pct_dado2.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado5.png");
                        break;
                    case 6:
                        pct_dado2.BackgroundImage = Image.FromFile("C:/Users/MARIO/source/repos/JuegoDado/JuegoDado/Resources/lado6.png");
                        break;
                }
                if (suma == 7)
                {
                    MessageBox.Show("LA CASA GANA");
                    check_menor.Checked = false;
                    lbl_suma.Text = "0";
                }
                else if (suma >= minimo  && suma <= maximo )
                {
                    MessageBox.Show("¡Ganaste!");
                    check_menor.Checked = false;
                    lbl_suma.Text = "0";
                }
                else
                {
                    MessageBox.Show("LO SIENTO PERDISTE");
                    check_menor.Checked = false;
                    lbl_suma.Text = "0";
                }
            }
        }
    }
}
