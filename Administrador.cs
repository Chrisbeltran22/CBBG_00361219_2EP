using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Parcial2
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            MessageBox.Show("¡Bienvenido!", "Inicio de sesión exitoso", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            //combo usuario
            var comparar = ConexionBD.ExecuteQuery("SELECT fullname FROM APPUSER");
            var compararCombo = new List<string>();
            foreach (DataRow dr in comparar.Rows)
            {
                compararCombo.Add(dr[0].ToString());
            }
            comboEliminarUser.DataSource = compararCombo;
            
            //combo ordenes 
            var orden = ConexionBD.ExecuteQuery("SELECT * FROM APPORDER");
            var ordenCombo = new List<string>();
            foreach (DataRow dr in orden.Rows)
            {
                ordenCombo.Add(dr[0].ToString());
            }
            //comboUsuarios.DataSource = ordenCombo;
            
            //combo negocios
            var negocio = ConexionBD.ExecuteQuery("SELECT name FROM BUSINESS");
            var negocioCombo = new List<string>();
            foreach (DataRow dr in negocio.Rows)
            {
                negocioCombo.Add(dr[0].ToString());
            }
            comboEliminarBus.DataSource = negocioCombo;

            //combo producto
            var producto = ConexionBD.ExecuteQuery("SELECT name FROM PRODUCT");
            var productoCombo = new List<string>();
            foreach (DataRow dr in producto.Rows)
            {
                productoCombo.Add(dr[0].ToString());
            }
            comboBoxProductos.DataSource = productoCombo;
            
            //combo id business
            var product = ConexionBD.ExecuteQuery("SELECT idBusiness FROM BUSINESS");
            var productCombo = new List<string>();
            foreach (DataRow dr in product.Rows)
            {
                productCombo.Add(dr[0].ToString());
            }
            comboProductoBus.DataSource = productCombo;
        }
         
        private void btnCrearUsuario_Click(object sender, EventArgs e)//ver usuarios, error de nombres
        {
            var dt = ConexionBD.ExecuteQuery("SELECT * FROM APPUSER");
                             
            dataGridView1.DataSource = dt;
            MessageBox.Show("Ususarios obtenidos exitosamente");
        }


        private void buttonPedidos_Click(object sender, EventArgs e)//Ver pedidos
        {
            var dt = ConexionBD.ExecuteQuery("SELECT * FROM APPORDER");
                             
            dataGridViewOrders.DataSource = dt;
            MessageBox.Show("Lista de pedidos obtenidos exitosamente");
        }

        private void buttonAddUser_Click(object sender, EventArgs e)//Agregar usuarios
        {
            if (textBoxName.Text.Equals("") ||
                textBoxUser.Text.Equals("") ||
                textBoxPassword.Text.Equals(""))
            {
                MessageBox.Show("Nos se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    ConexionBD.ExecuteNonQuery($"INSERT INTO APPUSER(fullname, username, password, userType)" +
                                               $" VALUES(" +
                                                 $"'{textBoxName.Text}', " +
                                                 $"'{textBoxUser.Text}', " +
                                                 $"'{textBoxPassword.Text}', " +
                                                 $"'{textBoxAdmin.Text}')");
                    
                    MessageBox.Show("Se ha registrado el usuario");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private void buttonAddBus_Click(object sender, EventArgs e)//Agregar negocios
        {
            if (textBoxNbus.Text.Equals("") ||
                textBoxDesc.Text.Equals(""))
            {
                MessageBox.Show("Nos se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    ConexionBD.ExecuteNonQuery($"INSERT INTO BUSINESS(name, description) VALUES(" +
                                                 $"'{textBoxNbus.Text}', " +
                                                 $"'{textBoxDesc.Text}')");
                    
                    MessageBox.Show("Se ha registrado el negocio");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private void btnEliminarUser_Click(object sender, EventArgs e)//Eliminar Usuarios
        {
            ConexionBD.ExecuteNonQuery("DELETE FROM APPUSER WHERE fullname = '{comboEliminarUser.Text}'");
            MessageBox.Show("Usuario eliminado");
        }

        private void btnVerNegocios_Click(object sender, EventArgs e)//Ver negocios
        {
            var dt = ConexionBD.ExecuteQuery("SELECT * FROM BUSINESS");
                             
            dataGridViewBus.DataSource = dt;
            MessageBox.Show("Lista de negocios obtenidos exitosamente");
        }

        private void btnVerProductos_Click(object sender, EventArgs e)//Ver productos
        {
            var dt = ConexionBD.ExecuteQuery("SELECT * FROM PRODUCT");
                             
            dataGridViewProducts.DataSource = dt;
            MessageBox.Show("Lista de productos obtenidos exitosamente");
        }

        private void btnEliminarBus_Click(object sender, EventArgs e)//Eliminar negocios
        {
           ConexionBD.ExecuteNonQuery("DELETE FROM BUSINESS WHERE name  = '{comboEliminarBus.Text}'");
            MessageBox.Show("Negocio eliminado");
        }


        private void btnEliminarProductos_Click(object sender, EventArgs e)//Eliminar productos
        {
            ConexionBD.ExecuteNonQuery("DELETE FROM PRODUCT WHERE name = '{comboBoxProducto.Text}'");
            MessageBox.Show("Producto eliminado");
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)//agregar producto
        {
            if (comboBoxProductos.Text.Equals("") ||
                textBoxProducto.Text.Equals(""))
            {
                MessageBox.Show("Nos se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    ConexionBD.ExecuteNonQuery($"INSERT INTO PRODUCT(idBusiness, name) VALUES(" +
                                               $"{comboProductoBus.Text}, " +
                                               $"'{textBoxProducto.Text}')");
                    
                    MessageBox.Show("Se ha registrado el producto");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}