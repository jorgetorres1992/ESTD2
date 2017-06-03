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

namespace Proyecto_ESTD2
{
    public partial class FormAgregarCarpeta : Form
    {
        public FormAgregarCarpeta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) //etiqueta
        {

        }

        private void button1_Click(object sender, EventArgs e) //boton buscar
        {
            var findCarpeta = folderBrowserDialog1.ShowDialog();
            if(findCarpeta==DialogResult.OK)
            {
                txtUbicacion.Text = folderBrowserDialog1.SelectedPath; //+ txtnombre.Text.Substring(txtnombre.Text.LastIndexOf(@"\"));
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCrearCarpeta_Click(object sender, EventArgs e)
        {
            string nombreUbicacion = txtUbicacion.Text;
            string nombreCarpeta = txtnombre.Text;
            if (Directory.Exists(nombreUbicacion + "\\" + nombreCarpeta))
            {
                MessageBox.Show("CARPETA EXISTE CAMBIE EL NOMBRE");
            }
            else
            {

                
                Directory.CreateDirectory(nombreUbicacion + "\\" + nombreCarpeta);
                MessageBox.Show("Carpeta se ha creado exitosamente!!");
                txtUbicacion.Clear();
                txtnombre.Clear();
            }
        }
    }
}
