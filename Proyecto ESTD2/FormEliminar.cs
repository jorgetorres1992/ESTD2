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
    public partial class FormEliminar : Form
    {
        Computer mycomputer = new Computer(); // Así accederemos al "FileSystem".
        string tipo = "carpeta";
        public FormEliminar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {

                tipo = "carpeta"; // El tipo se cambiará a archivo.
                //groupBox2.Enabled = false;
                string[] carpetas = Directory.GetDirectories("Z:\\");
                for(int i = 0; i< carpetas.Length; i++)
                {
                    listaCarpeta.Items.Add(carpetas[i]);
                    

                }
               

                listaArchivos.Items.Clear();
                
            }
            else
            {
                tipo = "archivo";
                listaCarpeta.ClearSelected();
                //groupBox1.Enabled = false;
                string[] archivos = Directory.GetFiles("Z:\\");
                for (int i = 0; i < archivos.Length; i++)
                {
                    listaArchivos.Items.Add(archivos[i]);
        
                }
                
                listaCarpeta.Items.Clear();                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           

        }
    }
}
