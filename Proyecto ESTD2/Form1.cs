using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Proyecto_ESTD2
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool DefineDosDevice(int flags, string NombreDisco, string Path);
        public Form1()
        {
            InitializeComponent();
        }

        // funcion recursivo para que cree el arbol y lo lea treeView
        private TreeNode CrearArbol(DirectoryInfo directoryInfo)
        {
            TreeNode treeNode = new TreeNode(directoryInfo.Name);

            foreach (var item in directoryInfo.GetDirectories()) 
            {
                // recorriendo nodos de folders
                treeNode.Nodes.Add(CrearArbol(item));
            }

            foreach (var item in directoryInfo.GetFiles())
            {
                // a diferencia de los nodos de los folder
                // se lee los archivos individuales de cada nodo de los folder
                // y se agregan al treeview con item.name
                treeNode.Nodes.Add(new TreeNode(item.Name));
            }

            // retorna
            return treeNode;
        }

        private void Form1_Load(object sender, EventArgs e) // funcion que carga todo el formulario al darle start
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e) // Boton Buscar
        {
            FolderBrowserDialog carpeta = new FolderBrowserDialog();
            if (carpeta.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                textBox1.Text = carpeta.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e) // boton Montar
        {
            if (!DefineDosDevice(0, textBox2.Text, textBox1.Text))
            {
                throw new Win32Exception();    
            }

            string rutaBase = "C:\\Users\\JLT\\Desktop\\Proyecto ESTD2 V3\\HDD";
            tvFile.Nodes.Clear(); // limpia el treeview cada que carga

            DirectoryInfo directoryInfo = new DirectoryInfo(rutaBase);
            // se manda como parametro al constructo la ruta del HDD 

            // llama la funcio recursiva treeNode
            tvFile.Nodes.Add(CrearArbol(directoryInfo));

            MessageBox.Show("Disco ha sido Montado Exitosamente");

        }

        private void button3_Click(object sender, EventArgs e) // boton desmontar
        {
            if(!DefineDosDevice(2, textBox2.Text, textBox1.Text))
            {
                throw new Win32Exception();
            }

            tvFile.Nodes.Clear();
            MessageBox.Show("Disco ha sido Desmontado Exitosamente");
        }

        private void button4_Click(object sender, EventArgs e)// btn agregar archivos
        {
            FormBurcarArchivos frm = new FormBurcarArchivos();
            frm.Show();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormAgregarCarpeta frm = new FormAgregarCarpeta();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormExtraer extraer = new FormExtraer();
            extraer.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormEliminar eliminar = new FormEliminar();
            eliminar.Show();
        }
    }
}
