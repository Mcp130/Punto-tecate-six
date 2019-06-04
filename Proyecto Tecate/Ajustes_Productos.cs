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
    public partial class Ajustes_Productos : Form
    {
        //manda llamar los metodos necesarios para validar 
        validacion va = new validacion();
        // metodo para mandar las consultas mysql
        BaseDeDatos bd = new BaseDeDatos();

        public Ajustes_Productos()
        {
            InitializeComponent();
        }

        private void Ajustes_Load(object sender, EventArgs e)
        { //elimina bordes
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized; //maximiza la pantalla
            dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM six.visinventario;");//selecciona la tabla inventario de la base de datos
            
        }
       
        private void ButGuardar_Click(object sender, EventArgs e)
        {
            
        }//guarda los datos modificados
        //validacion de datos en cajas de texto
        private void TBoxBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.SoloNumeros(e);
        }
        //Para cerrar la ventana 
        private void ButSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //validacion de datos en cajas de texto
        private void TexBCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.SoloNumeros(e);
        }
        //validacion de datos en cajas de texto
        private void TexBInventario_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.SoloNumeros(e);
        }
        //validacion de datos en cajas de texto
        private void TexBCostoPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.SoloNumerosydecimal(e);
        }
        //validacion de datos en cajas de texto
        private void TexBCostoVen_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.SoloNumerosydecimal(e);
        }
        //validacion de datos en cajas de texto
        private void TexBStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.SoloNumeros(e);
        }
        //No sirve para nada este metodo ya que se borro el boton busqueda 
        private void ButBuscar_Click(object sender, EventArgs e)
        {
            //
            if (!TBoxBusqueda.Text.Equals(""))
            {
                string Buscar = "call busqueda_inventario(" + TBoxBusqueda.Text + ");";
                dataGridView1.DataSource = bd.SelectDataTable(Buscar);
            }
            else
            {
                dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM six.visinventario;");
            }
        }
        //boton actualizar
        private void butActualizar_Click(object sender, EventArgs e)
        {
            //contador de errores 
            int i=0;
                //valida que no este vasia la caja de texto
                if (!TexBCodigo.Text.Equals(""))
                {
                    string actualizar = "UPDATE inventario SET Codigo =\"" + TexBCodigo.Text + //sobre escribe el dato en la base de daatos
                        "\" WHERE Codigo = " + TBoxBusqueda.Text + ";";

                    if (bd.executecommand(actualizar))
                    {
                        dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM visinventario;");//selecciona la tabla inventario de la base de datos
                    }
                    else
                    {
                    i++;
                    }
                }
                //validacion de datos de capos y update del mismo campo 
                if (!texBSku.Text.Equals(""))
                {
                    string actualizar = "UPDATE inventario SET SKU = \"" + texBSku.Text +
                        "\" WHERE Codigo = " + TBoxBusqueda.Text + ";";

                    if (bd.executecommand(actualizar))
                    {
                       
                    }
                    else
                    {
                    i++;
                    }
                }
            //validacion de datos de capos y update del mismo campo 
            if (!TexBProducto.Text.Equals(""))
                {
                    string actualizar = "UPDATE inventario SET producto =\"" + TexBProducto.Text +
                        "\" WHERE Codigo = " + TBoxBusqueda.Text + ";";

                    if (bd.executecommand(actualizar))
                    {
                       
                    }
                    else
                    {
                    i++;
                }
                }
            //validacion de datos de capos y update del mismo campo 
            if (!TexBStock.Text.Equals(""))
                {
                    string actualizar = "UPDATE inventario SET stock =" + TexBStock.Text +
                        " WHERE Codigo = " + TBoxBusqueda.Text + ";";

                    if (bd.executecommand(actualizar))
                    {
                        
                    }
                    else
                    {
                    i++;
                }
                }
            //validacion de datos de capos y update del mismo campo 
            if (!TexBInventario.Text.Equals(""))
                {
                    string actualizar = "UPDATE inventario SET unidades_disp =" + TexBInventario.Text +
                        " WHERE Codigo = " + TBoxBusqueda.Text + ";";

                    if (bd.executecommand(actualizar))
                    {
                       
                    }
                    else
                    {
                    i++; 
                    }
                }
            //validacion de datos de capos y update del mismo campo 
            if (!TexBCostoPro.Text.Equals(""))
                {
                    string actualizar = "UPDATE inventario SET cos_Proveedor =" + TexBCostoPro.Text +
                        " WHERE Codigo = " + TBoxBusqueda.Text + ";";

                    if (bd.executecommand(actualizar))
                    {
                        
                    }
                    else
                    {
                    i++;
                }
                }
            //validacion de datos de capos y update del mismo campo 
            if (!TexBCostoVen.Text.Equals(""))
                {
                    string actualizar = "UPDATE inventario SET Cos_venta =" + TexBCostoVen.Text +
                        " WHERE Codigo = " + TBoxBusqueda.Text + ";";

                    if (bd.executecommand(actualizar))
                    {
                        
                    }
                    else
                    {
                    i++;
                }
                }
            //validacion de datos de capos y update del mismo campo 
            if (!TexBProveedor.Text.Equals(""))
                {
                    string actualizar = "UPDATE inventario SET proveedor =\"" + TexBProveedor.Text +
                        "\" WHERE Codigo = " + TBoxBusqueda.Text + ";";

                    if (bd.executecommand(actualizar))
                    {
                        
                    }
                    else
                    {
                    i++;
                }
                }
            //validacion de datos de capos y update del mismo campo 
            if (!TexBCatalogo.Text.Equals(""))
                {
                    string actualizar = "UPDATE inventario SET categoria =\"" + TexBCatalogo.Text +
                        "\" WHERE Codigo = " + TBoxBusqueda.Text + ";";

                    if (bd.executecommand(actualizar))
                    {
                        
                    }
                    else
                    {
                    i++;
                }
                }
                
            if (i==0)
            { 
                MessageBox.Show("Actualizado Corectamente");
                dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM visinventario;");//selecciona la tabla inventario de la base de datos
                //Borra los datos de todos los textxbox
                TexBCodigo.Text = "";
                texBSku.Text = "";
                TexBProducto.Text = "";
                TexBStock.Text = "";
                TexBInventario.Text = "";
                TexBCostoPro.Text = "";
                TexBCostoVen.Text = "";
                TexBProveedor.Text = "";
                TexBCatalogo.Text = "";
                TBoxBusqueda.Text = "";
            }
            else
            {
                MessageBox.Show("Error");
            }
            i = 0;
        }

        //Boton eliminar..
        private void butEliminar_Click(object sender, EventArgs e)
        {
            string eliminar = "call eliminar_producto(" + TBoxBusqueda.Text + ");";

            if (bd.executecommand(eliminar))
            {
                MessageBox.Show("Eliminado correctamente");
                dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM six.visinventario;");
                TBoxBusqueda.Text = "";
            }

            else
            {
                MessageBox.Show("Error");
            }
        }//elimina los productos de la base de datos
        //TextBox de busqueda..
        private void TBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            //valida que no este vacio el textbox
            if (!TBoxBusqueda.Text.Equals(""))
            {
                //Guarda la consulta 
                string Buscar = "call busqueda_inventario(" + TBoxBusqueda.Text + ");";
                //Actualiza con el resultado de la consulta
                dataGridView1.DataSource = bd.SelectDataTable(Buscar);
            }
            else {
                dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM six.visinventario;");
            }
        }

        private void ButGuardar_Click_1(object sender, EventArgs e)
        {
            //Validad que no esten vacios los textBox
            if (!TexBCodigo.Text.Equals("") && !TexBProducto.Text.Equals("")
                && !TexBStock.Text.Equals("") && !TexBInventario.Text.Equals("") && !TexBCostoPro.Text.Equals("")
                && !TexBCostoVen.Text.Equals("") && !TexBProveedor.Text.Equals("") && !TexBCatalogo.Text.Equals("")) {
                //manda los valores de los textbox al procedure creado para agregar nuevos productos 
                string agregar = "call agregar_inventario (\"" + TexBCodigo.Text + "\",\"" + texBSku.Text + "\",\"" +
                    TexBProducto.Text + "\"," + TexBStock.Text + "," + TexBInventario.Text + "," +
                    TexBCostoPro.Text + "," + TexBCostoVen.Text + ",\"" + TexBProveedor.Text + "\",\"" +
                    TexBCatalogo.Text + "\");";

                if (bd.executecommand(agregar))
                {
                    MessageBox.Show("Agregado correctamente");
                    //actualiza el dataGridView con los datos de la tabla inventario
                    dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM visinventario;");
                    //borra los datos de todos los textbox
                    TexBCodigo.Text = "";
                    texBSku.Text = "";
                    TexBProducto.Text = "";
                    TexBStock.Text = "";
                    TexBInventario.Text = "";
                    TexBCostoPro.Text = "";
                    TexBCostoVen.Text = "";
                    TexBProveedor.Text = "";
                    TexBCatalogo.Text = "";
                    TBoxBusqueda.Text = "";
                }
                else
                {
                    MessageBox.Show("Error");
                }
                

            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
