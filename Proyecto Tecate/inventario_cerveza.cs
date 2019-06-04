using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Tecate
{
    public partial class inventario_cerveza : Form
    {
        //manda llamar los metodos necesarios para validar 
        validacion va = new validacion();
        // metodo para mandar las consultas mysql
        BaseDeDatos bd = new BaseDeDatos();
        public inventario_cerveza()
        {
            InitializeComponent();
        }
        //Valida que solo sean numeros
        private void TexBCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.SoloNumeros(e);
            
        }
        //No sirve para nada este metodo
        private void ButBuscar_Click(object sender, EventArgs e)
        {
            string Buscar = "select * from inventario where Codigo_Barras =" + TexBCB.Text+";";
            dataGridView1.DataSource = bd.SelectDataTable(Buscar);
            
        }
        //Cierra la ventana 
        private void ButSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void inventario_cerveza_Load(object sender, EventArgs e)
        {
            //Quita los borde y lo hace a pantalla completa 
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM visinventario;");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        //Merodo para buscar un producto 
        private void TexBCB_TextChanged(object sender, EventArgs e)
        {
            //Valida que no este vacio el textbox
            if (!TexBCB.Text.Equals(""))
            {
                //Guarda la consulta
                string Buscar = "call busqueda_inventario(" + TexBCB.Text + ");";
                //Actualiza el datagriedview con el resultado de la consulta
                dataGridView1.DataSource = bd.SelectDataTable(Buscar);
            }
            else
            {
                //Actualiza el datagriedview con el resultado de la vista inventario 
                dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM six.visinventario;");
            }
        }
    }
}
