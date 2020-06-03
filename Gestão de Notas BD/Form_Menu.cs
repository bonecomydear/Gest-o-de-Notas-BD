using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_de_Notas_BD
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {

        }

        private void gestãoNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chamaNotas();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            chamaNotas();

        }
        void chamaNotas()
        {

            Form_Notas form_Notas = new Form_Notas();
            form_Notas.MdiParent = this;
            form_Notas.Show();

        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Sobre form_Sobre = new Form_Sobre();
           // form_Sobre.MdiParent = this;
            form_Sobre.ShowDialog();

        }
    }
}

