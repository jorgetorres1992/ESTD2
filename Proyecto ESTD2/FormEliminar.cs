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

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //agregando a la lista las carpetas y archivos del HDD
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
                //textBox2.Text = "Ruta";

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
                //textBox1.Text = "Ruta";              
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                string ruta1 = textBox1.Text;
                Directory.Delete(ruta1);
                MessageBox.Show("Carpeta Eliminada Correctamente!!");
            }
            else
            {
                string ruta2 = textBox2.Text;
                File.Delete(ruta2);
                MessageBox.Show("Archivo Eliminado Correctamente!!");

            }
        }

        private void listaCarpeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox1.Text = listaCarpeta.SelectedItem.ToString();
            }
            else
            {
                textBox1.Text = "RUTA";
            }
        }

        private void listaArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox2.Text = listaArchivos.SelectedItem.ToString();
            }
            else
            {
                textBox2.Text = "RUTA";
            }
        }
    }
}
