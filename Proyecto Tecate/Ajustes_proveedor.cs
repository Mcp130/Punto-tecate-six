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
    public partial class Ajustes : Form
    {
        validacion va = new validacion();
        BaseDeDatos bd = new BaseDeDatos();

        public Ajustes()
        {
            InitializeComponent();
        }

        private void Ajustes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bd.SelectDataTable("select * from productos;");
        }

        private void ButGuardar_Click(object sender, EventArgs e)
        {
            string agregar = "insert into productos (`Codigo_Barras`, `Nombre_Producto`, `stock`, `Inventario`, `costo_proveedor`, `Costo_venta`, `Catalogo`, `idProveedor`)" +
                " values ('" + TexBCodigo.Text + "','" + TexBProducto.Text + "','" +
                TexBStock.Text + "','" + TexBInventario.Text + "','" + TexBCostoPro.Text + "','" + TexBCostoVen.Text + "','" +
                TexBCatalogo.Text + "','" + TexBProveedor.Text + "');";

            if (bd.executecommand(agregar))
            {
                MessageBox.Show("Agregado correctamente");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void TBoxBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.SoloNumeros(e);
        }

        private void ButSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TexBCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.SoloNumeros(e);
        }

        private void TexBInventario_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.SoloNumeros(e);
        }

        private void TexBCostoPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.SoloNumerosydecimal(e);
        }

        private void TexBCostoVen_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.SoloNumerosydecimal(e);
        }

        private void TexBStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.SoloNumeros(e);
        }

        private void ButBuscar_Click(object sender, EventArgs e)
        {
            string Buscar = "select * from productos where Codigo_Barras=" + TBoxBusqueda.Text + ";";
            dataGridView1.DataSource = bd.SelectDataTable(Buscar);
        }

        private void butActualizar_Click(object sender, EventArgs e)
        {
            if (!TexBCodigo.Equals(""))
            {
                string actualizar = "UPDATE productos SET Codigo_Barras =" + TexBCodigo.Text + " WHERE Codigo_Barras = " + TBoxBusqueda.Text + ";";

                if (bd.executecommand(actualizar))
                {
                    MessageBox.Show("Actualizado Corectamente");
                    dataGridView1.DataSource = bd.SelectDataTable("select * from productos;");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            string eliminar = "delete from productos where Codigo_Barras = " + TBoxBusqueda.Text + ";";

            if (bd.executecommand(eliminar))
            {
                MessageBox.Show("Eliminado correctamente");
                dataGridView1.DataSource = bd.SelectDataTable("select * from productos;");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void TBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            string Busca = "select * from productos where Codigo_Barras =" + TBoxBusqueda.Text + ";";
            dataGridView1.DataSource = bd.SelectDataTable(Busca);
        }
    }
}
