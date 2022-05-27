using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace MeuBlocoDeNotas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void SalvarClick(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void SalvarOK(object sender, CancelEventArgs e)
        {
            string Caminho = saveFileDialog1.FileName;
            File.WriteAllText(Caminho, txtJanela.Text);

        }
    }
}
