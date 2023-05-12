using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/////////////////////////////////////////////////////////////////////////// CRUD
namespace test_crud3
{
    public partial class Form1 : Form
    {
        //variable global q conecta la bd
        SqlConnection conexion = new SqlConnection("server=DESKTOP-QD5KMLH\\SQLEXPRESS; database=bd_crud_test; integrated security=true");
        public Form1()
        {
            InitializeComponent();
        }
        /////////////////////////////////////////////////////////////////////////// CRUD

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conexión exitosa");
                conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("NO se pudo conectar");
                
            }
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            //comando ejecuta la orden SQL
            SqlCommand comando = new SqlCommand("Select * from equipos", conexion);
            //adaptador adapta la orden sql a la BD creando una instancia de la clase SQLAdapter
            SqlDataAdapter adaptador = new SqlDataAdapter();
            //con esa instancia creada selecciono el comando creado q ya tiene la orden en SQL
            adaptador.SelectCommand = comando;
            //de la clase DataTable creo una instancia llamada tabla
            DataTable tabla = new DataTable();
            //con el adaptador uso el metodo Fill/rellenar para llenar la 'tabla'
            adaptador.Fill(tabla);
            //visualizo lo rellenado en un Ddatagridview indicando q sea igual a mi tabla creada
            dgvProd.DataSource=tabla;
            conexion.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string escribir = "INSERT INTO equipos(Id_equipo,Nombres,PartJug,PartGan) VALUES (@id_equipo,@nombres,@partjug,@partGan)";

            conexion.Open();
            SqlCommand comando = new SqlCommand(escribir, conexion);
            comando.Parameters.AddWithValue("@id_equipo", textBoxIdEq.Text);
            comando.Parameters.AddWithValue("@nombres", textBoxPais.Text);
            comando.Parameters.AddWithValue("@partjug", textBoxPartJug.Text);
            comando.Parameters.AddWithValue("@partgan", textBoxPartGan.Text);
            comando.ExecuteNonQuery();
            conexion.Close();

            MessageBox.Show("Equipo agregado");
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            //variable q contendrá el comando UPDATE de SQL. Solo indico actualizar ID y NOmbre con set + id=idNuevo y nombre=nombreNuevo DONDE coincida el ID. Si no coincide el ID no se modifica
            string actualizar = "UPDATE equipos SET Id_equipo = @id_equipo, Nombres = @nombres, PartGan = @partgan WHERE Id_equipo=@id_equipo";
            conexion.Open();
            SqlCommand comando = new SqlCommand(actualizar, conexion);
            //para agregar los parámetros al comando
            comando.Parameters.AddWithValue("@id_equipo", textBoxIdEq.Text);
            comando.Parameters.AddWithValue("@nombres", textBoxPais.Text);
            comando.Parameters.AddWithValue("@partjug", textBoxPartJug.Text);
            comando.Parameters.AddWithValue("@partgan", textBoxPartGan.Text);
            comando.ExecuteNonQuery();//permite ejecutar el comando
            conexion.Close();
            MessageBox.Show("Equipo actualizado");
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            //variable query q contiene el comando DELETE y aplica DONDE el ID ingresado sea igual al ID existente
            string query = "DELETE FROM equipos WHERE ID_equipo = @id_equipo";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id_equipo", textBoxIdEq.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Equipo eliminado");
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //Creo la instancia desde SqlCommand con el comando SQL DONDE coincida el ID
            SqlCommand comando = new SqlCommand("SELECT * FROM equipos WHERE Id_equipo = @id_equipo", conexion);
            comando.Parameters.AddWithValue("@id_equipo", textBoxIdEq.Text);//Traigo los parametros por medio del id y sus valores
            conexion.Open();//abro la bd
            //creo un Objeto DataReader para leer/recuperar los datos
            SqlDataReader registro = comando.ExecuteReader();
            
            if (registro.Read())//si el registro es leído
            {
                textBoxPais.Text = registro["Nombres"].ToString(); // a la textboxPais pasarle el registro leído en la columna Nombres
                textBoxPartJug.Text = registro["PartJug"].ToString();// a la textoxPartJug pasarle el registro leído en la columna PartJug
                textBoxPartGan.Text = registro["PartGan"].ToString();// a la textoxPartGan pasarle el registro leído en la columna PartGan
            }
            conexion.Close();
        }
    }
}
