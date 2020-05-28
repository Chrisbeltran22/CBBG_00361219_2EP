using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class CambiarContra : Form
    {
        public CambiarContra()
        {
            InitializeComponent();
        }
        
        private void CambiarContra_Load(object sender, EventArgs e)
        {
            PoblarControles();
        }

        private void PoblarControles()
        {
            // Actualizar ComboBox
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "contrasena";
            comboBox1.DisplayMember = "usuario";
            //combo contraseñas
            var contra = ConexionBD.ExecuteQuery("SELECT fullname FROM APPUSER");
            var contraCombo = new List<string>();

            foreach (DataRow dr in contra.Rows)
            {
                contraCombo.Add(dr[0].ToString());
            }

            comboBoxLista.DataSource = contraCombo;

            var comparar =
                ConexionBD.ExecuteQuery("SELECT password FROM APPUSER WHERE fullname = '{comboBoxlista}'");
            var compararCombo = new List<string>();

            foreach (DataRow dr in comparar.Rows)
            {
                compararCombo.Add(dr[0].ToString());
            }

            comboBox1.DataSource = compararCombo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedValue.Equals(textBoxActual.Text))
                {
                    ConexionBD.ExecuteNonQuery(
                        "UPDATE APPUSER SET password = '{textBoxNueva.Text}' WHERE fullname = '{comboBoxLista.Text}'");
                    MessageBox.Show("Se ha actualizado su contraseña");
                }
                else
                    MessageBox.Show("¡Contraseña inválida!", "Cambio contraseña",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}