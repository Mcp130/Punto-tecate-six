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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        //Botodo de ventas  
        private void ButVentas_Click(object sender, EventArgs e)
        {
            abrir_from(new Ventas ());//abre la ventana de ventas
        }
        //boton de salir 
        private void ButSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); //cierra el programa
        }
        //boton de Proveedores
        private void ButPedidos_Click(object sender, EventArgs e)
        {
            abrir_from(new Ajustes_Proveedor()); //abre la ventana de ajustes provedor
        }
        //Boton de Inventario
        private void ButInventario_Click(object sender, EventArgs e)
        {
            abrir_from(new inventario_cerveza()); //abre la ventana de inventario
        }
        //Boton de ajustes de inventario 
        private void ButAjuInv_Click(object sender, EventArgs e)
        {
            abrir_from(new Ajustes_Productos()); //abre la ventana de ajustes de producto
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ButReporte_Click(object sender, EventArgs e)
        {
            abrir_from(new Reporte()); //abre la ventana del reporte
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            //Funciona para habrir el formulario inicial en pantalla completa
            WindowState = FormWindowState.Maximized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void abrir_from(object pan_contenedor) //metodo utilizado para abrir las ventanas en la
                                                       // pantalla principal.
        {
            if (this.pan_contenedor.Controls.Count > 0)
                this.pan_contenedor.Controls.RemoveAt(0);
            Form abrir = pan_contenedor as Form;
            abrir.TopLevel = false;
            abrir.Dock = DockStyle.Fill;
            this.pan_contenedor.Controls.Add(abrir);
            this.pan_contenedor.Tag = abrir;
            abrir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
