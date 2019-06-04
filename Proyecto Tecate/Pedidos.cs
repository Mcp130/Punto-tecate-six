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
    public partial class Ajustes_Proveedor : Form
    {
        //manda llamar los metodos necesarios para validar 
        validacion va = new validacion();
        // metodo para mandar las consultas mysql
        BaseDeDatos bd = new BaseDeDatos();
        public Ajustes_Proveedor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //para cerrar la ventana 
        private void ButSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Para buscar algun proveedor...
        private void ButBuscar_Click(object sender, EventArgs e)
        {
            //guarda la consulta junto con lo que conga el tBoxBuscar
            string Buscar = "call buscar_proveedor ('" + tboxBuscar.Text + "');";
            //Actualiza el dataGridView con el resultado del procedure busqueda_proveedor
            dataGridView1.DataSource = bd.SelectDataTable(Buscar);
        }
        //Para quitar borde y lo hace a pantalla completa
        private void Pedidos_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM visproveedores;");
        }
        //textbox busqueda
        private void tboxBuscar_TextChanged(object sender, EventArgs e)
        {
            //valida que no este vacio la caja de texto
            if (!tboxBuscar.Text.Equals(""))
            {
                //manda lo de la caja de texto al procedure busqueda_proveedores
                string Buscar = "call busqueda_proveedores('" + tboxBuscar.Text + "');";
                //Actualiza el dataGridView con el resultado de la consulta anterior
                dataGridView1.DataSource = bd.SelectDataTable(Buscar);
            }
            else
            {
                //Actualiza el dataGridView con el resulta de la vista proveedores 
                dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM visProveedores;");
            }
        }
        //Metodo para guardar al proveedor 
        private void ButGuardar_Click(object sender, EventArgs e)
        {
            //Valida que ningun textBox este vacio
            if (!texBProveedor.Text.Equals("") && !texBNumProv.Text.Equals("") && !texBEmpresa.Text.Equals("")
                && !texBNumEmp.Text.Equals("") && !texBFrecuencia.Text.Equals("")) {
                //Guarda la consulta con los valores de los textbox
                string agregar = "call agregar_proveedor (\"" + texBProveedor.Text + "\",\"" + texBNumProv.Text
                    + "\",\"" + texBEmpresa.Text + "\",\"" + texBNumEmp.Text + "\",\"" + texBFrecuencia.Text + "\");,";

                //Manda la consulta
                if (bd.executecommand(agregar))
                {
                    MessageBox.Show("Agregado correctamente");
                    dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM visproveedores;");
                }
                else
                {
                    MessageBox.Show("Agregado correctamente");
                    dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM visproveedores;");
                }
                //Borra todos los textBox
                texBProveedor.Text = "";
                texBNumProv.Text = "";
                texBEmpresa.Text = "";
                texBNumEmp.Text = "";
                texBFrecuencia.Text = "";
                tboxBuscar.Text = "";
            }
            else
            {
                MessageBox.Show("Error");
            }

            
        }
        //metodo para eliminar al proveedor 
        private void butEliminar_Click(object sender, EventArgs e)
        {
            //Guarda la consulta del procedure junto con el valor del texboxbusqueda
            string agregar = "call Eliminar_proveedor (\""+tboxBuscar.Text+"\");";

            //Manda la consulta 
            if (bd.executecommand(agregar))
            {
                MessageBox.Show("Eliminado correctamente");
                dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM visproveedores;");
            }
            else
            {
                MessageBox.Show("Error");
                dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM visproveedores;");
            }
            //Elimina los valores de todos los textbox
            texBProveedor.Text = "";
            texBNumProv.Text = "";
            texBEmpresa.Text = "";
            texBNumEmp.Text = "";
            texBFrecuencia.Text = "";
            tboxBuscar.Text = "";
        }
        //metodo para actualizar al proveedor 
        private void butActualizar_Click(object sender, EventArgs e)
        {
            //Contador para los errorres
            int c = 0;
            //Validacion de texbox, que contengan algo y realiza el update
            if (!texBProveedor.Text.Equals(""))
            {
                string actualizar = "update proveedores set proveedore = \""+ texBProveedor.Text+
                    "\" where proveedore = \""+tboxBuscar.Text+"\" and habilitado = 1;";
                if (bd.executecommand(actualizar))
                {
                    
                }
                else
                {
                    
                    c++;
                }

            }
            //Validacion de texbox, que contengan algo y realiza el update
            if (!texBNumProv.Text.Equals(""))
            {
                string actualizar = "update proveedores set num_tel_prov = \"" + texBNumProv.Text +
                    "\" where proveedore = \"" + tboxBuscar.Text + "\" and habilitado = 1;";
                if (bd.executecommand(actualizar))
                {

                }
                else
                {
                    
                    c++;
                }
            }
            //Validacion de texbox, que contengan algo y realiza el update
            if (!texBEmpresa.Text.Equals(""))
            {
                string actualizar = "update proveedores set empresa = \"" + texBEmpresa.Text +
                    "\" where proveedore = \"" + tboxBuscar.Text + "\" and habilitado = 1;";
                if (bd.executecommand(actualizar))
                {

                }
                else
                {
                    
                    c++;
                }
            }
            //Validacion de texbox, que contengan algo y realiza el update
            if (!texBNumEmp.Text.Equals(""))
            {
                string actualizar = "update proveedores set num_tel_emp = \"" + texBNumEmp.Text +
                    "\" where proveedore = \"" + tboxBuscar.Text + "\" and habilitado = 1;";
                if (bd.executecommand(actualizar))
                {

                }
                else
                {
                    
                    c++;
                }
            }
            //Validacion de texbox, que contengan algo y realiza el update
            if (!texBFrecuencia.Text.Equals(""))
            {
                string actualizar = "update proveedores set frecuencia = \"" + texBFrecuencia.Text +
                    "\" where proveedore = \"" + tboxBuscar.Text + "\" and habilitado = 1;";
                if (bd.executecommand(actualizar))
                {

                }
                else
                {
                    
                    c++;
                }

            }
            //Verifica se hubo algun error 
            if (c == 0)
            {
                MessageBox.Show("Actualizado correctamente");
            }
            else
            {
                MessageBox.Show("Error");
            }
            dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM visproveedores;");
            c = 0;
            //Borra los datos de todos los textbox
            texBProveedor.Text = "";
            texBNumProv.Text = "";
            texBEmpresa.Text = "";
            texBNumEmp.Text = "";
            texBFrecuencia.Text = "";
            tboxBuscar.Text = "";
        }
    }
}
