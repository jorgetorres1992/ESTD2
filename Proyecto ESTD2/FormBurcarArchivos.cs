using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices; // agregando referencia visual basic para el file open dialog 

namespace Proyecto_ESTD2
{
    public partial class FormBurcarArchivos : Form
    {
        Computer mycomputer = new Computer(); // accediendo al fileSystem del OS
        
        public FormBurcarArchivos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Form1 frm1 = new Form1();
            //frm1.Show();
            this.Hide();
        }

        private void btnBuscarArchivo_Click(object sender, EventArgs e)
        {
            var resultado = openFileDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                txtOrigen.Text = openFileDialog1.FileName;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            var resultado = folderBrowserDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                txtDestino.Text = folderBrowserDialog1.SelectedPath + txtOrigen.Text.Substring(txtOrigen.Text.LastIndexOf(@"\"));
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            mycomputer.FileSystem.CopyFile(txtOrigen.Text, txtDestino.Text);
            MessageBox.Show("Archivo ha sido Agregado Correctamente!!");
            txtOrigen.Clear();
            txtDestino.Clear();

        }
    }
}
