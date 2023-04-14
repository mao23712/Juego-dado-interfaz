using System;
using System.Drawing;
using System.Windows.Forms;

namespace JuegoDado
{
    public partial class FormJuego : Form
    {
        public FormJuego()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_jugar_Click(object sender, EventArgs e)
        {
            FormDado form2 = new FormDado();
            form2.Show();
            this.Hide();
        }

        private void btn_jugar_MouseHover(object sender, EventArgs e)
        {
            btn_jugar.Size = new Size(btn_jugar.Size.Width + 10, btn_jugar.Size.Height + 10);
        }

        private void btn_jugar_MouseLeave(object sender, EventArgs e)
        {
            btn_jugar.Size = new Size(btn_jugar.Size.Width - 10, btn_jugar.Size.Height - 10);

        }
    }
}
