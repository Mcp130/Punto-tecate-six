using MySql.Data.MySqlClient;
using Proyecto_Tecate.Conexion;
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
    public partial class Ventas : Form
    {
        //manda llamar los metodos necesarios para validar 
        validacion va = new validacion(); 
        // metodo para mandar las consultas mysql
        BaseDeDatos bd = new BaseDeDatos();
        //SIrve para guardar la conexion
        string stconec;
        //para poder abrir la conexion con la libreria MySqlConnection
        MySqlConnection cnn = new MySqlConnection();


      
        public Ventas()
        {
            InitializeComponent();// elimina los botones de minimizar, maximizar y cerrar
            new Conex();
        }

        private void codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            va.SoloNumeros(e); //validacion de numero
        }

        private void ButSalir_Click(object sender, EventArgs e)
        {
            this.Close();// sale de la pantalla principal
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;// elimina los bordes de la pantalla 
            WindowState = FormWindowState.Maximized;//hace que la pantalla principal la hace completa
            dataGridView1.DataSource = bd.SelectDataTable("select * from visventas;");//hace una consulta a la tabla visventas que se encuentra en la base de datos
            stconec = "server=localhost;database=six;user id=root;password=Yui48627931.";// coneccion a la base de datos
            cnn.ConnectionString = stconec;//guarda los valores de la conexion en cnn
            cnn.Open();//Abre la conexion 
            //variable donde se guardara el resultado de la columna total de la tabla ventas
            double t = 0;

            string suma = "select sum(total) from ventas;";//consulta para sumar los valores de los  precio

            MySqlCommand myCmd = new MySqlCommand(suma, cnn);//manda la cadena de la consulta anterior
            try
            {
                //Guarda el valor que devuelve la consulta suma
                t = Convert.ToDouble(myCmd.ExecuteScalar());
            }
            catch
            {
                t = 0;
            }


            TexBTotal.Text = "" + t.ToString();//muestra el resultado de la consulta anterior
        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ButAgregar_Click(object sender, EventArgs e)
        {
            
                
                //Obtiene la fecha actual y la guarda en la variable hoy
                DateTime hoy = DateTime.Today;
                //da formato a la fecha obtenida del sistema (año/mes/dia)
                string fecha_actual = hoy.ToString("yyyy/MM/dd");
                //Manda el codigo de barra y la fecha actual al precedure de ventas
                string agregar = "call agregar_venta(" + texBcodigo.Text + ",\"" + fecha_actual + "\");";
                //Borrar la caja de texto texBcodigo
                texBcodigo.Text = "";
                //variable donde se guardara el resultado de la columna total de la tabla ventas
                double t = 0;

                string suma = "select sum(total) from ventas;";//hace una consulta de la  suma de los productos

                


                if (bd.executecommand(agregar))//manda parametros a la base de datos para que te lo devuelva si es verdadero o falso
                {
                    //actializa el dataGridview para tener los valores mas recientes de la tabla ventas
                    dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM visventas;");
                }
                else
                {
                    MessageBox.Show("Error");
                    //actializa el dataGridview para tener los valores mas recientes de la tabla ventas
                    dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM visventas;");
                }
            //Manda la consulta guardada en suma junto su conexion guardada en cnn para su ejecucion
            MySqlCommand myCmd = new MySqlCommand(suma, cnn);
            try
            {
                t = Convert.ToDouble(myCmd.ExecuteScalar());//guarda resultado de la consuulta
            }
            catch
            {
                t = 0;
            }
            //le asigna el valor de de t a la caja de texto texBTotal
            TexBTotal.Text = "" + t.ToString();

        }
        //manda lo que se tiene en ventas a una tabla de nombre historico
        private void ButCobrar_Click(object sender, EventArgs e)  
        {
            //Consulta utilizada para mover los datos de la tabla ventas a historial
            string Vender = "insert into historial_ventas select * from ventas;";
            if (bd.executecommand(Vender))
            { 
                //actializa el dataGridview para tener los valores mas recientes de la tabla ventas
                dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM visventas;");
            }
            else
            {
                MessageBox.Show("Error");
                //actializa el dataGridview para tener los valores mas recientes de la tabla ventas
                dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM visventas;");
            }
            //consulta para borrar los datos de la tabla venta
            string borrar = "delete from ventas where idventas>0;";
            if (bd.executecommand(borrar))
            {
                //actializa el dataGridview para tener los valores mas recientes de la tabla ventas
                dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM visventas;");
            }
            else
            {
                MessageBox.Show("Error");
                dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM visventas;");
            }
            //Coloca en 0 la caja de texto texBTotal
            TexBTotal.Text = "" + 0;
        }

        private void butCancelar_Click(object sender, EventArgs e)// elimina los datos de la tabla ventas
        {
            //consulta utilizada para borrar los datos de la tabla ventas
            string borrar = "delete from ventas where idventas>0;";
            if (bd.executecommand(borrar))
            {
                //actializa el dataGridview para tener los valores mas recientes de la tabla ventas
                dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM visventas;");
            }
            else
            {
                MessageBox.Show("Error");
                //actializa el dataGridview para tener los valores mas recientes de la tabla ventas
                dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM visventas;");
            }
            //coloca en 0 la caja de texto texBtotal
            TexBTotal.Text = "" + 0;
        }
    }
}
