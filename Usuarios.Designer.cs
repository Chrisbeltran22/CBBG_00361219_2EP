using System;
using System.ComponentModel;

namespace Parcial2
{
    partial class Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabController = new System.Windows.Forms.TabControl();
            this.tabDirecciones = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.comboEliminarDireccion = new System.Windows.Forms.ComboBox();
            this.btnEliminarDireccion = new System.Windows.Forms.Button();
            this.dataGridViewDirec = new System.Windows.Forms.DataGridView();
            this.btnVerDirecciones = new System.Windows.Forms.Button();
            this.TabAgregar = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddOrder = new System.Windows.Forms.GroupBox();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.tabVerPedidos = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxPedidos = new System.Windows.Forms.ComboBox();
            this.btnEliminarPedido = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.btnVerPedidos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboIdProducto = new System.Windows.Forms.ComboBox();
            this.comboIdDireccion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewPedido = new System.Windows.Forms.DataGridView();
            this.buttonSeeBusiness = new System.Windows.Forms.Button();
            this.buttonSeeProduct = new System.Windows.Forms.Button();
            this.groupBoxDireccion = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxIdDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAgregarDirec = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TabController.SuspendLayout();
            this.tabDirecciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewDirec)).BeginInit();
            this.TabAgregar.SuspendLayout();
            this.AddOrder.SuspendLayout();
            this.tabVerPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewPedido)).BeginInit();
            this.groupBoxDireccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabController
            // 
            this.TabController.Controls.Add(this.tabDirecciones);
            this.TabController.Controls.Add(this.TabAgregar);
            this.TabController.Controls.Add(this.tabVerPedidos);
            this.TabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabController.Location = new System.Drawing.Point(0, 0);
            this.TabController.Name = "TabController";
            this.TabController.SelectedIndex = 0;
            this.TabController.Size = new System.Drawing.Size(579, 433);
            this.TabController.TabIndex = 1;
            // 
            // tabDirecciones
            // 
            this.tabDirecciones.Controls.Add(this.groupBoxDireccion);
            this.tabDirecciones.Controls.Add(this.label14);
            this.tabDirecciones.Controls.Add(this.comboEliminarDireccion);
            this.tabDirecciones.Controls.Add(this.btnEliminarDireccion);
            this.tabDirecciones.Controls.Add(this.dataGridViewDirec);
            this.tabDirecciones.Controls.Add(this.btnVerDirecciones);
            this.tabDirecciones.Location = new System.Drawing.Point(4, 24);
            this.tabDirecciones.Name = "tabDirecciones";
            this.tabDirecciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabDirecciones.Size = new System.Drawing.Size(571, 405);
            this.tabDirecciones.TabIndex = 0;
            this.tabDirecciones.Text = "Direcciones";
            this.tabDirecciones.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(22, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 24);
            this.label14.TabIndex = 21;
            this.label14.Text = "Dirección:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboEliminarDireccion
            // 
            this.comboEliminarDireccion.FormattingEnabled = true;
            this.comboEliminarDireccion.Location = new System.Drawing.Point(156, 243);
            this.comboEliminarDireccion.Name = "comboEliminarDireccion";
            this.comboEliminarDireccion.Size = new System.Drawing.Size(222, 23);
            this.comboEliminarDireccion.TabIndex = 20;
            // 
            // btnEliminarDireccion
            // 
            this.btnEliminarDireccion.Location = new System.Drawing.Point(421, 243);
            this.btnEliminarDireccion.Name = "btnEliminarDireccion";
            this.btnEliminarDireccion.Size = new System.Drawing.Size(129, 27);
            this.btnEliminarDireccion.TabIndex = 15;
            this.btnEliminarDireccion.Text = "Eliminar";
            this.btnEliminarDireccion.UseVisualStyleBackColor = true;
            this.btnEliminarDireccion.Click += new System.EventHandler(this.btnEliminarDireccion_Click);
            // 
            // dataGridViewDirec
            // 
            this.dataGridViewDirec.AllowUserToAddRows = false;
            this.dataGridViewDirec.AllowUserToDeleteRows = false;
            this.dataGridViewDirec.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDirec.Location = new System.Drawing.Point(8, 39);
            this.dataGridViewDirec.Name = "dataGridViewDirec";
            this.dataGridViewDirec.ReadOnly = true;
            this.dataGridViewDirec.Size = new System.Drawing.Size(555, 198);
            this.dataGridViewDirec.TabIndex = 13;
            // 
            // btnVerDirecciones
            // 
            this.btnVerDirecciones.Location = new System.Drawing.Point(436, 6);
            this.btnVerDirecciones.Name = "btnVerDirecciones";
            this.btnVerDirecciones.Size = new System.Drawing.Size(129, 27);
            this.btnVerDirecciones.TabIndex = 12;
            this.btnVerDirecciones.Text = "Ver tus direcciones";
            this.btnVerDirecciones.UseVisualStyleBackColor = true;
            this.btnVerDirecciones.Click += new System.EventHandler(this.btnVerDirecciones_Click);
            // 
            // TabAgregar
            // 
            this.TabAgregar.Controls.Add(this.groupBox2);
            this.TabAgregar.Controls.Add(this.AddOrder);
            this.TabAgregar.Location = new System.Drawing.Point(4, 24);
            this.TabAgregar.Name = "TabAgregar";
            this.TabAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.TabAgregar.Size = new System.Drawing.Size(571, 405);
            this.TabAgregar.TabIndex = 3;
            this.TabAgregar.Text = "Hacer pedido";
            this.TabAgregar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(431, -182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // AddOrder
            // 
            this.AddOrder.Controls.Add(this.textBox1);
            this.AddOrder.Controls.Add(this.buttonSeeProduct);
            this.AddOrder.Controls.Add(this.buttonSeeBusiness);
            this.AddOrder.Controls.Add(this.dataGridViewPedido);
            this.AddOrder.Controls.Add(this.label3);
            this.AddOrder.Controls.Add(this.label2);
            this.AddOrder.Controls.Add(this.comboIdDireccion);
            this.AddOrder.Controls.Add(this.comboIdProducto);
            this.AddOrder.Controls.Add(this.label1);
            this.AddOrder.Controls.Add(this.buttonAddOrder);
            this.AddOrder.Location = new System.Drawing.Point(13, 13);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(539, 374);
            this.AddOrder.TabIndex = 0;
            this.AddOrder.TabStop = false;
            this.AddOrder.Text = "Hacer un pedido";
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Location = new System.Drawing.Point(424, 22);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(109, 31);
            this.buttonAddOrder.TabIndex = 6;
            this.buttonAddOrder.Text = "Agregar";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrden_Click);
            // 
            // tabVerPedidos
            // 
            this.tabVerPedidos.Controls.Add(this.label8);
            this.tabVerPedidos.Controls.Add(this.comboBoxPedidos);
            this.tabVerPedidos.Controls.Add(this.btnEliminarPedido);
            this.tabVerPedidos.Controls.Add(this.dataGridViewProducts);
            this.tabVerPedidos.Controls.Add(this.btnVerPedidos);
            this.tabVerPedidos.Location = new System.Drawing.Point(4, 24);
            this.tabVerPedidos.Name = "tabVerPedidos";
            this.tabVerPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabVerPedidos.Size = new System.Drawing.Size(571, 405);
            this.tabVerPedidos.TabIndex = 5;
            this.tabVerPedidos.Text = "Mis pedidos";
            this.tabVerPedidos.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "Pedido:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxPedidos
            // 
            this.comboBoxPedidos.FormattingEnabled = true;
            this.comboBoxPedidos.Location = new System.Drawing.Point(114, 339);
            this.comboBoxPedidos.Name = "comboBoxPedidos";
            this.comboBoxPedidos.Size = new System.Drawing.Size(314, 23);
            this.comboBoxPedidos.TabIndex = 26;
            // 
            // btnEliminarPedido
            // 
            this.btnEliminarPedido.Location = new System.Drawing.Point(434, 336);
            this.btnEliminarPedido.Name = "btnEliminarPedido";
            this.btnEliminarPedido.Size = new System.Drawing.Size(129, 27);
            this.btnEliminarPedido.TabIndex = 25;
            this.btnEliminarPedido.Text = "Eliminar";
            this.btnEliminarPedido.UseVisualStyleBackColor = true;
            this.btnEliminarPedido.Click += new System.EventHandler(this.btnEliminarPedido_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(8, 82);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.Size = new System.Drawing.Size(555, 248);
            this.dataGridViewProducts.TabIndex = 23;
            // 
            // btnVerPedidos
            // 
            this.btnVerPedidos.Location = new System.Drawing.Point(436, 49);
            this.btnVerPedidos.Name = "btnVerPedidos";
            this.btnVerPedidos.Size = new System.Drawing.Size(129, 27);
            this.btnVerPedidos.TabIndex = 22;
            this.btnVerPedidos.Text = "Ver pedidos";
            this.btnVerPedidos.UseVisualStyleBackColor = true;
            this.btnVerPedidos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fecha:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboIdProducto
            // 
            this.comboIdProducto.FormattingEnabled = true;
            this.comboIdProducto.Location = new System.Drawing.Point(109, 61);
            this.comboIdProducto.Name = "comboIdProducto";
            this.comboIdProducto.Size = new System.Drawing.Size(221, 23);
            this.comboIdProducto.TabIndex = 32;
            // 
            // comboIdDireccion
            // 
            this.comboIdDireccion.FormattingEnabled = true;
            this.comboIdDireccion.Location = new System.Drawing.Point(109, 103);
            this.comboIdDireccion.Name = "comboIdDireccion";
            this.comboIdDireccion.Size = new System.Drawing.Size(221, 23);
            this.comboIdDireccion.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Id de producto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Id de direccion";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewPedido
            // 
            this.dataGridViewPedido.AllowUserToAddRows = false;
            this.dataGridViewPedido.AllowUserToDeleteRows = false;
            this.dataGridViewPedido.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedido.Location = new System.Drawing.Point(3, 183);
            this.dataGridViewPedido.Name = "dataGridViewPedido";
            this.dataGridViewPedido.ReadOnly = true;
            this.dataGridViewPedido.Size = new System.Drawing.Size(530, 185);
            this.dataGridViewPedido.TabIndex = 36;
            // 
            // buttonSeeBusiness
            // 
            this.buttonSeeBusiness.Location = new System.Drawing.Point(404, 150);
            this.buttonSeeBusiness.Name = "buttonSeeBusiness";
            this.buttonSeeBusiness.Size = new System.Drawing.Size(129, 27);
            this.buttonSeeBusiness.TabIndex = 37;
            this.buttonSeeBusiness.Text = "Ver negocios";
            this.buttonSeeBusiness.UseVisualStyleBackColor = true;
            this.buttonSeeBusiness.Click += new System.EventHandler(this.buttonSeeBusiness_Click);
            // 
            // buttonSeeProduct
            // 
            this.buttonSeeProduct.Location = new System.Drawing.Point(6, 150);
            this.buttonSeeProduct.Name = "buttonSeeProduct";
            this.buttonSeeProduct.Size = new System.Drawing.Size(129, 27);
            this.buttonSeeProduct.TabIndex = 38;
            this.buttonSeeProduct.Text = "Ver productos";
            this.buttonSeeProduct.UseVisualStyleBackColor = true;
            this.buttonSeeProduct.Click += new System.EventHandler(this.buttonSeeProduct_Click);
            // 
            // groupBoxDireccion
            // 
            this.groupBoxDireccion.Controls.Add(this.buttonAgregarDirec);
            this.groupBoxDireccion.Controls.Add(this.textBoxIdDireccion);
            this.groupBoxDireccion.Controls.Add(this.label5);
            this.groupBoxDireccion.Controls.Add(this.textBoxDireccion);
            this.groupBoxDireccion.Controls.Add(this.label4);
            this.groupBoxDireccion.Location = new System.Drawing.Point(15, 296);
            this.groupBoxDireccion.Name = "groupBoxDireccion";
            this.groupBoxDireccion.Size = new System.Drawing.Size(533, 103);
            this.groupBoxDireccion.TabIndex = 22;
            this.groupBoxDireccion.TabStop = false;
            this.groupBoxDireccion.Text = "Agregar Dirección";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Dirección:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(125, 29);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(280, 23);
            this.textBoxDireccion.TabIndex = 23;
            // 
            // textBoxIdDireccion
            // 
            this.textBoxIdDireccion.Location = new System.Drawing.Point(126, 69);
            this.textBoxIdDireccion.Name = "textBoxIdDireccion";
            this.textBoxIdDireccion.Size = new System.Drawing.Size(130, 23);
            this.textBoxIdDireccion.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Id personal:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAgregarDirec
            // 
            this.buttonAgregarDirec.Location = new System.Drawing.Point(418, 66);
            this.buttonAgregarDirec.Name = "buttonAgregarDirec";
            this.buttonAgregarDirec.Size = new System.Drawing.Size(109, 31);
            this.buttonAgregarDirec.TabIndex = 26;
            this.buttonAgregarDirec.Text = "Agregar";
            this.buttonAgregarDirec.UseVisualStyleBackColor = true;
            this.buttonAgregarDirec.Click += new System.EventHandler(this.buttonAgregarDirec_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 23);
            this.textBox1.TabIndex = 39;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 433);
            this.Controls.Add(this.TabController);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.TabController.ResumeLayout(false);
            this.tabDirecciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewDirec)).EndInit();
            this.TabAgregar.ResumeLayout(false);
            this.AddOrder.ResumeLayout(false);
            this.AddOrder.PerformLayout();
            this.tabVerPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewPedido)).EndInit();
            this.groupBoxDireccion.ResumeLayout(false);
            this.groupBoxDireccion.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage TabAgregar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabControl TabController;
        private System.Windows.Forms.Button btnVerDirecciones;
        private System.Windows.Forms.DataGridView dataGridViewDirec;
        private System.Windows.Forms.Button btnEliminarDireccion;
        private System.Windows.Forms.ComboBox comboEliminarDireccion;
        private System.Windows.Forms.TabPage tabDirecciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboIdProducto;
        private System.Windows.Forms.ComboBox comboIdDireccion;
        private System.Windows.Forms.Button buttonSeeBusiness;
        private System.Windows.Forms.Button buttonSeeProduct;
        private System.Windows.Forms.GroupBox AddOrder;
        private System.Windows.Forms.DataGridView dataGridViewPedido;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.TabPage tabVerPedidos;
        private System.Windows.Forms.Button btnVerPedidos;
        private System.Windows.Forms.ComboBox comboBoxPedidos;
        private System.Windows.Forms.Button btnEliminarPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxDireccion;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxIdDireccion;
        private System.Windows.Forms.Button buttonAgregarDirec;
        private System.Windows.Forms.TextBox textBox1;
    }
}