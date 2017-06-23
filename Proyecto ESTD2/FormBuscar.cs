using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using System.IO;

namespace Proyecto_ESTD2
{
    public partial class FormBuscar : Form
    {

        public FormBuscar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var findCarpeta = folderBrowserDialog1.ShowDialog();
            if (findCarpeta == DialogResult.OK)
            {
                txtNombre.Text = folderBrowserDialog1.SelectedPath; 
            }
            listBox1.Items.Clear();

            }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string[] archivos = Directory.GetFiles(txtNombre.Text);
            for (int i = 0; i < archivos.Length; i++)
            {
                listBox1.Items.Add(archivos[i]);

            }
        }
    }
}
