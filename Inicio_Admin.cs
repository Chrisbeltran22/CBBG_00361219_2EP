using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Inicio_Admin : Form
    {
        public Inicio_Admin()
        {
            InitializeComponent();
        }

        private void Inicio_Admin_Load(object sender, EventArgs e)
        {
            PoblarControles();
        }
        
        private void PoblarControles()
        {
            // Actualizar ComboBox
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "contrasena";
            comboBox1.DisplayMember = "usuario";
            var contra = ConexionBD.ExecuteQuery("SELECT fullname FROM APPUSER WHERE userType = true");
            var contraCombo = new List<string>();

            foreach (DataRow dr in contra.Rows)
            {
                contraCombo.Add(dr[0].ToString());
            }

            comboBox1.DataSource = contraCombo;
            
            var comparar = ConexionBD.ExecuteQuery("SELECT password FROM APPUSER WHERE userType = true");
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
                Administrador ventana = new Administrador();
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
    }
}