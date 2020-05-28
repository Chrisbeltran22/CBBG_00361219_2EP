using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Parcial2
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PoblarControles();
        }

        private void PoblarControles()
        {
            // Actualizar ComboBox
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "contrasena";
            comboBox1.DisplayMember = "usuario";
            var contra = ConexionBD.ExecuteQuery("SELECT fullname FROM APPUSER WHERE userType = false");
            var contraCombo = new List<string>();

            foreach (DataRow dr in contra.Rows)
            {
                contraCombo.Add(dr[0].ToString());
            }

            comboBox1.DataSource = contraCombo;
            
            var comparar = ConexionBD.ExecuteQuery("SELECT password FROM APPUSER WHERE userType = false");
            var compararCombo = new List<string>();

            foreach (DataRow dr in comparar.Rows)
            {
                compararCombo.Add(dr[0].ToString());
            }

            comboBox2.DataSource = compararCombo;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox2.SelectedValue.Equals(textBox1.Text))
            {
                Usuarios ventana = new Usuarios();
                ventana.Show();
                this.Hide();
            }
            else
                MessageBox.Show("¡Contraseña incorrecta!", "Iniciar sesión",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button2_Click(object sender, EventArgs e)//Cambiar contraseña
        {
            CambiarContra unaVentana = new CambiarContra();
            unaVentana.ShowDialog();
            PoblarControles();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)//Acceder como administrador
        {
            Inicio_Admin unaVentana = new Inicio_Admin();
            unaVentana.Show();
            this.Hide();
            PoblarControles();
        }
    }
    
}