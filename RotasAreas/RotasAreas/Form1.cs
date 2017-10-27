using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RotasAreas
{
    public partial class frmRotas : Form
    {
        public frmRotas()
        {
            InitializeComponent();
        }

        private void dlgNomesCidades_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void Leitura()
        {
            StreamReader arq = new StreamReader("C:\\Users\\u15259\\Desktop\\RotasAreas\\CaminhosEntreCidadesMarte.txt");
            while (!arq.EndOfStream)
            {
                String linha;
                linha = arq.ReadLine();
            }
        }s

        private void frmRotas_Load(object sender, EventArgs e)
        {
            Leitura();
            this.BackgroundImage = imgRotasAereas.Images[0];
        }
    }
}
