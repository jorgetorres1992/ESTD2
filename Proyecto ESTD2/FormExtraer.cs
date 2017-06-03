using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.Devices;

namespace Proyecto_ESTD2
{
    public partial class FormExtraer : Form
    {
        Computer mycomputer = new Computer(); // Así accederemos al "FileSystem".
        string tipo = "carpeta";
        public FormExtraer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void radioCarpeta_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCarpeta.Checked == true)
            {
                tipo = "carpeta"; // El tipo se cambiará a archivo.
                btnCarpeta.Enabled = true;
                btnArchivo.Enabled = false;
            }
            else
            {
                tipo = "archivo";
                btnCarpeta.Enabled = false;
                btnArchivo.Enabled = true;
            }
        }

        private void btnCarpeta_Click(object sender, EventArgs e)
        {
            var resultado = folderBrowserDialog1.ShowDialog();
            if (resultado == DialogResult.OK) { txtOrigen.Text = folderBrowserDialog1.SelectedPath; }
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            var resultado1 = openFileDialog1.ShowDialog();
            if (resultado1 == DialogResult.OK) { txtOrigen.Text = openFileDialog1.FileName; }
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            var resultado2 = folderBrowserDialog1.ShowDialog();
            if (resultado2 == DialogResult.OK)
            {
                txtDestino.Text = folderBrowserDialog1.SelectedPath + txtOrigen.Text.Substring(txtOrigen.Text.LastIndexOf(@"\"));
            }
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            if (tipo == "carpeta")
            {
                mycomputer.FileSystem.MoveDirectory(txtOrigen.Text, txtDestino.Text);
                MessageBox.Show("Se extrajo la carpeta correctamente");
                txtOrigen.Clear();
                txtDestino.Clear();
            } 
            if (tipo == "archivo")
            {
                mycomputer.FileSystem.MoveFile(txtOrigen.Text, txtDestino.Text);
                MessageBox.Show("Se extrajo el archivo correctamente");
                txtOrigen.Clear();
                txtDestino.Clear();
            }
        }
    }
}
