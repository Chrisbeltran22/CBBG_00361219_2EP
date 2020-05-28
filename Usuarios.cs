using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Usuarios : Form
    {
        private int ID;
        public Usuarios()
        {
            InitializeComponent();
            //ID = usuario;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            MessageBox.Show("¡Bienvenido!", "Inicio de sesión exitoso", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            //combo direcciones usuario
            var direccion = 
                ConexionBD.ExecuteQuery("SELECT address FROM ADDRESS ad WHERE idUser = 1");
            
            var direccionCombo = new List<string>();
            foreach (DataRow dr in direccion.Rows)
            {
                direccionCombo.Add(dr[0].ToString());
            }
            comboEliminarDireccion.DataSource = direccionCombo;
            
            //combo direccion Id
            var negocio = 
                ConexionBD.ExecuteQuery("SELECT ad.idAddress, ad.address FROM ADDRESS ad WHERE idUser = 1")
                ;
            var negocioCombo = new List<string>();
            foreach (DataRow dr in negocio.Rows)
            {
                negocioCombo.Add(dr[0].ToString());
            }
            comboIdDireccion.DataSource = negocioCombo;

            //combo producto
            var producto = 
                ConexionBD.ExecuteQuery("SELECT p.idProduct, p.name FROM PRODUCT p WHERE idBusiness = 1");
            var productCombo = new List<string>();
            foreach (DataRow dr in producto.Rows)
            {
                productCombo.Add(dr[0].ToString());
            }
            comboIdProducto.DataSource = productCombo;
            
            //combo pedidos
            var pedidos = ConexionBD.ExecuteQuery("SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, " +
                                                  "ad.address FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                                                  "WHERE ao.idProduct = pr.idProduct AND ao.idAddress = ad.idAddress " +
                                                  "AND ad.idUser = au.idUser");
            var pedidosCombo = new List<string>();
            foreach (DataRow dr in pedidos.Rows)
            {
                pedidosCombo.Add(dr[0].ToString());
            }
            comboBoxPedidos.DataSource = pedidosCombo;
            
        }

        private void btnVerDirecciones_Click(object sender, EventArgs e)//Ver direcciones
        {
            var dt = ConexionBD.ExecuteQuery("SELECT ad.idAddress, ad.address FROM ADDRESS ad WHERE idUser = 1");
                             
            dataGridViewDirec.DataSource = dt;
            MessageBox.Show("Direcciones obtenidas exitosamente");
        }

        private void btnEliminarDireccion_Click(object sender, EventArgs e)
        {
            ConexionBD.ExecuteNonQuery($"DELETE FROM ADDRESS WHERE address = '{comboEliminarDireccion.Text}'");
            
            MessageBox.Show("Dirección eliminada");
        }

        private void buttonSeeProduct_Click(object sender, EventArgs e)
        {
            var dt = ConexionBD.ExecuteQuery("SELECT * FROM PRODUCT");
                             
            dataGridViewPedido.DataSource = dt;
            MessageBox.Show("Productos obtenidos exitosamente");
        }

        private void buttonSeeBusiness_Click(object sender, EventArgs e)
        {
            var dt = ConexionBD.ExecuteQuery("SELECT * FROM BUSINESS");
                             
            dataGridViewPedido.DataSource = dt;
            MessageBox.Show("Negocios obtenidos exitosamente");
        }

        private void buttonAddOrden_Click(object sender, EventArgs e)
        {
            if (comboIdProducto.Text.Equals("") ||
                comboIdDireccion.Text.Equals(""))
            {
                MessageBox.Show("Nose pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    ConexionBD.ExecuteNonQuery($"INSERT INTO APPORDER(createDate, idProduct, idAddress) VALUES(" +
                                               $"'{textBox1.Text}', " +
                                               $"{comboIdProducto.Text}, " +
                                               $"{comboIdDireccion.Text})");
                    
                    MessageBox.Show("Se ha registrado la orden");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            var dt = ConexionBD.ExecuteQuery($"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, " +
                                                        $" ad.address FROM APPORDER ao, ADDRESS ad, PRODUCT pr, " +
                                                        $"APPUSER au WHERE ao.idProduct = pr.idProduct " +
                                                        $"AND ao.idAddress = ad.idAddress AND ad.idUser = au.idUser");
                             
            dataGridViewProducts.DataSource = dt;
            MessageBox.Show("Negocios obtenidos exitosamente");
        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            ConexionBD.ExecuteNonQuery($"DELETE FROM APPORDER WHERE idOrder = {comboBoxPedidos.Text}");
            
            MessageBox.Show("Pedido eliminado");
        }

        private void buttonAgregarDirec_Click(object sender, EventArgs e)
        {
            if (textBoxDireccion.Text.Equals("") ||
                textBoxIdDireccion.Text.Equals(""))
            {
                MessageBox.Show("Nos se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    ConexionBD.ExecuteNonQuery($"INSERT INTO ADDRESS(idUser, address) VALUES(" +
                                               $"{textBoxIdDireccion.Text}, " +
                                               $"'{textBoxDireccion.Text}')");
                    
                    MessageBox.Show("Se ha registrado su dirección");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}