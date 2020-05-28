using System.ComponentModel;

namespace Parcial2
{
    partial class Administrador
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
            this.tabNegocios = new System.Windows.Forms.TabPage();
            this.tabOrdenes = new System.Windows.Forms.TabPage();
            this.TabAgregar = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVerUsuario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.buttonPedidos = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddBusiness = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonAddBus = new System.Windows.Forms.Button();
            this.textBoxNbus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridViewBus = new System.Windows.Forms.DataGridView();
            this.btnVerNegocios = new System.Windows.Forms.Button();
            this.btnEliminarUser = new System.Windows.Forms.Button();
            this.btnEliminarBus = new System.Windows.Forms.Button();
            this.comboEliminarBus = new System.Windows.Forms.ComboBox();
            this.comboEliminarUser = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxProductos = new System.Windows.Forms.ComboBox();
            this.btnEliminarProductos = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.textBoxAdmin = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxProducto = new System.Windows.Forms.TextBox();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.comboProductoBus = new System.Windows.Forms.ComboBox();
            this.TabController.SuspendLayout();
            this.tabDirecciones.SuspendLayout();
            this.tabNegocios.SuspendLayout();
            this.tabOrdenes.SuspendLayout();
            this.TabAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewOrders)).BeginInit();
            this.AddUser.SuspendLayout();
            this.AddBusiness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewBus)).BeginInit();
            this.tabProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // TabController
            // 
            this.TabController.Controls.Add(this.tabDirecciones);
            this.TabController.Controls.Add(this.tabNegocios);
            this.TabController.Controls.Add(this.tabOrdenes);
            this.TabController.Controls.Add(this.TabAgregar);
            this.TabController.Controls.Add(this.tabProductos);
            this.TabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabController.Location = new System.Drawing.Point(0, 0);
            this.TabController.Name = "TabController";
            this.TabController.SelectedIndex = 0;
            this.TabController.Size = new System.Drawing.Size(571, 432);
            this.TabController.TabIndex = 0;
            // 
            // tabDirecciones
            // 
            this.tabDirecciones.Controls.Add(this.label14);
            this.tabDirecciones.Controls.Add(this.comboEliminarUser);
            this.tabDirecciones.Controls.Add(this.btnEliminarUser);
            this.tabDirecciones.Controls.Add(this.pictureBox1);
            this.tabDirecciones.Controls.Add(this.dataGridView1);
            this.tabDirecciones.Controls.Add(this.btnVerUsuario);
            this.tabDirecciones.Location = new System.Drawing.Point(4, 24);
            this.tabDirecciones.Name = "tabDirecciones";
            this.tabDirecciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabDirecciones.Size = new System.Drawing.Size(563, 404);
            this.tabDirecciones.TabIndex = 0;
            this.tabDirecciones.Text = "Usuarios";
            this.tabDirecciones.UseVisualStyleBackColor = true;
            // 
            // tabNegocios
            // 
            this.tabNegocios.Controls.Add(this.label15);
            this.tabNegocios.Controls.Add(this.comboEliminarBus);
            this.tabNegocios.Controls.Add(this.btnEliminarBus);
            this.tabNegocios.Controls.Add(this.pictureBox3);
            this.tabNegocios.Controls.Add(this.dataGridViewBus);
            this.tabNegocios.Controls.Add(this.btnVerNegocios);
            this.tabNegocios.Location = new System.Drawing.Point(4, 24);
            this.tabNegocios.Name = "tabNegocios";
            this.tabNegocios.Padding = new System.Windows.Forms.Padding(3);
            this.tabNegocios.Size = new System.Drawing.Size(563, 404);
            this.tabNegocios.TabIndex = 1;
            this.tabNegocios.Text = "Negocios";
            this.tabNegocios.UseVisualStyleBackColor = true;
            // 
            // tabOrdenes
            // 
            this.tabOrdenes.Controls.Add(this.pictureBox2);
            this.tabOrdenes.Controls.Add(this.dataGridViewOrders);
            this.tabOrdenes.Controls.Add(this.buttonPedidos);
            this.tabOrdenes.Location = new System.Drawing.Point(4, 24);
            this.tabOrdenes.Name = "tabOrdenes";
            this.tabOrdenes.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrdenes.Size = new System.Drawing.Size(563, 404);
            this.tabOrdenes.TabIndex = 2;
            this.tabOrdenes.Text = "Ordenes";
            this.tabOrdenes.UseVisualStyleBackColor = true;
            // 
            // TabAgregar
            // 
            this.TabAgregar.Controls.Add(this.AddBusiness);
            this.TabAgregar.Controls.Add(this.groupBox2);
            this.TabAgregar.Controls.Add(this.AddUser);
            this.TabAgregar.Location = new System.Drawing.Point(4, 24);
            this.TabAgregar.Name = "TabAgregar";
            this.TabAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.TabAgregar.Size = new System.Drawing.Size(563, 404);
            this.TabAgregar.TabIndex = 3;
            this.TabAgregar.Text = "Agregar";
            this.TabAgregar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(547, 218);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnVerUsuario
            // 
            this.btnVerUsuario.Location = new System.Drawing.Point(426, 110);
            this.btnVerUsuario.Name = "btnVerUsuario";
            this.btnVerUsuario.Size = new System.Drawing.Size(129, 27);
            this.btnVerUsuario.TabIndex = 12;
            this.btnVerUsuario.Text = "Ver usuarios";
            this.btnVerUsuario.UseVisualStyleBackColor = true;
            this.btnVerUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 131);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 117);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(8, 123);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.Size = new System.Drawing.Size(547, 273);
            this.dataGridViewOrders.TabIndex = 16;
            // 
            // buttonPedidos
            // 
            this.buttonPedidos.Location = new System.Drawing.Point(425, 89);
            this.buttonPedidos.Name = "buttonPedidos";
            this.buttonPedidos.Size = new System.Drawing.Size(130, 28);
            this.buttonPedidos.TabIndex = 15;
            this.buttonPedidos.Text = "Lista de pedidos";
            this.buttonPedidos.UseVisualStyleBackColor = true;
            this.buttonPedidos.Click += new System.EventHandler(this.buttonPedidos_Click);
            // 
            // AddUser
            // 
            this.AddUser.Controls.Add(this.textBoxAdmin);
            this.AddUser.Controls.Add(this.label6);
            this.AddUser.Controls.Add(this.buttonAddUser);
            this.AddUser.Controls.Add(this.textBoxPassword);
            this.AddUser.Controls.Add(this.textBoxUser);
            this.AddUser.Controls.Add(this.textBoxName);
            this.AddUser.Controls.Add(this.label4);
            this.AddUser.Controls.Add(this.label3);
            this.AddUser.Controls.Add(this.label2);
            this.AddUser.Location = new System.Drawing.Point(13, 13);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(539, 189);
            this.AddUser.TabIndex = 0;
            this.AddUser.TabStop = false;
            this.AddUser.Text = "Agregar usuario";
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
            // AddBusiness
            // 
            this.AddBusiness.Controls.Add(this.textBoxDesc);
            this.AddBusiness.Controls.Add(this.buttonAddBus);
            this.AddBusiness.Controls.Add(this.textBoxNbus);
            this.AddBusiness.Controls.Add(this.label5);
            this.AddBusiness.Controls.Add(this.label7);
            this.AddBusiness.Location = new System.Drawing.Point(13, 208);
            this.AddBusiness.Name = "AddBusiness";
            this.AddBusiness.Size = new System.Drawing.Size(539, 188);
            this.AddBusiness.TabIndex = 1;
            this.AddBusiness.TabStop = false;
            this.AddBusiness.Text = "Agregar negocio";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Usuario:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contraseña:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(109, 43);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(181, 23);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(109, 83);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(181, 23);
            this.textBoxUser.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(109, 126);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '-';
            this.textBoxPassword.Size = new System.Drawing.Size(181, 23);
            this.textBoxPassword.TabIndex = 5;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(424, 152);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(109, 31);
            this.buttonAddUser.TabIndex = 6;
            this.buttonAddUser.Text = "Agregar";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonAddBus
            // 
            this.buttonAddBus.Location = new System.Drawing.Point(424, 146);
            this.buttonAddBus.Name = "buttonAddBus";
            this.buttonAddBus.Size = new System.Drawing.Size(109, 31);
            this.buttonAddBus.TabIndex = 13;
            this.buttonAddBus.Text = "Agregar";
            this.buttonAddBus.UseVisualStyleBackColor = true;
            this.buttonAddBus.Click += new System.EventHandler(this.buttonAddBus_Click);
            // 
            // textBoxNbus
            // 
            this.textBoxNbus.Location = new System.Drawing.Point(126, 33);
            this.textBoxNbus.Name = "textBoxNbus";
            this.textBoxNbus.Size = new System.Drawing.Size(181, 23);
            this.textBoxNbus.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descripción:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(20, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nombre:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(318, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 37);
            this.label6.TabIndex = 9;
            this.label6.Text = "Administrador true/false:\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(8, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(391, 131);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // dataGridViewBus
            // 
            this.dataGridViewBus.AllowUserToAddRows = false;
            this.dataGridViewBus.AllowUserToDeleteRows = false;
            this.dataGridViewBus.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBus.Location = new System.Drawing.Point(12, 143);
            this.dataGridViewBus.Name = "dataGridViewBus";
            this.dataGridViewBus.ReadOnly = true;
            this.dataGridViewBus.Size = new System.Drawing.Size(543, 217);
            this.dataGridViewBus.TabIndex = 16;
            // 
            // btnVerNegocios
            // 
            this.btnVerNegocios.Location = new System.Drawing.Point(426, 110);
            this.btnVerNegocios.Name = "btnVerNegocios";
            this.btnVerNegocios.Size = new System.Drawing.Size(129, 27);
            this.btnVerNegocios.TabIndex = 15;
            this.btnVerNegocios.Text = "Ver Negocios";
            this.btnVerNegocios.UseVisualStyleBackColor = true;
            this.btnVerNegocios.Click += new System.EventHandler(this.btnVerNegocios_Click);
            // 
            // btnEliminarUser
            // 
            this.btnEliminarUser.Location = new System.Drawing.Point(426, 367);
            this.btnEliminarUser.Name = "btnEliminarUser";
            this.btnEliminarUser.Size = new System.Drawing.Size(129, 27);
            this.btnEliminarUser.TabIndex = 15;
            this.btnEliminarUser.Text = "Eliminar";
            this.btnEliminarUser.UseVisualStyleBackColor = true;
            this.btnEliminarUser.Click += new System.EventHandler(this.btnEliminarUser_Click);
            // 
            // btnEliminarBus
            // 
            this.btnEliminarBus.Location = new System.Drawing.Point(426, 366);
            this.btnEliminarBus.Name = "btnEliminarBus";
            this.btnEliminarBus.Size = new System.Drawing.Size(129, 27);
            this.btnEliminarBus.TabIndex = 18;
            this.btnEliminarBus.Text = "Eliminar";
            this.btnEliminarBus.UseVisualStyleBackColor = true;
            this.btnEliminarBus.Click += new System.EventHandler(this.btnEliminarBus_Click);
            // 
            // comboEliminarBus
            // 
            this.comboEliminarBus.FormattingEnabled = true;
            this.comboEliminarBus.Location = new System.Drawing.Point(177, 369);
            this.comboEliminarBus.Name = "comboEliminarBus";
            this.comboEliminarBus.Size = new System.Drawing.Size(222, 23);
            this.comboEliminarBus.TabIndex = 19;
            // 
            // comboEliminarUser
            // 
            this.comboEliminarUser.FormattingEnabled = true;
            this.comboEliminarUser.Location = new System.Drawing.Point(186, 370);
            this.comboEliminarUser.Name = "comboEliminarUser";
            this.comboEliminarUser.Size = new System.Drawing.Size(222, 23);
            this.comboEliminarUser.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(80, 370);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 24);
            this.label14.TabIndex = 21;
            this.label14.Text = "Usuario:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(71, 369);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 24);
            this.label15.TabIndex = 20;
            this.label15.Text = "Negocio:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.comboProductoBus);
            this.tabProductos.Controls.Add(this.buttonAddProduct);
            this.tabProductos.Controls.Add(this.textBoxProducto);
            this.tabProductos.Controls.Add(this.label9);
            this.tabProductos.Controls.Add(this.label8);
            this.tabProductos.Controls.Add(this.comboBoxProductos);
            this.tabProductos.Controls.Add(this.btnEliminarProductos);
            this.tabProductos.Controls.Add(this.dataGridViewProducts);
            this.tabProductos.Controls.Add(this.btnVerProductos);
            this.tabProductos.Location = new System.Drawing.Point(4, 24);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductos.Size = new System.Drawing.Size(563, 404);
            this.tabProductos.TabIndex = 5;
            this.tabProductos.Text = "Productos";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(80, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "Producto:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxProductos
            // 
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Location = new System.Drawing.Point(186, 372);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(222, 23);
            this.comboBoxProductos.TabIndex = 26;
            // 
            // btnEliminarProductos
            // 
            this.btnEliminarProductos.Location = new System.Drawing.Point(426, 369);
            this.btnEliminarProductos.Name = "btnEliminarProductos";
            this.btnEliminarProductos.Size = new System.Drawing.Size(129, 27);
            this.btnEliminarProductos.TabIndex = 25;
            this.btnEliminarProductos.Text = "Eliminar";
            this.btnEliminarProductos.UseVisualStyleBackColor = true;
            this.btnEliminarProductos.Click += new System.EventHandler(this.btnEliminarProductos_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(8, 101);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.Size = new System.Drawing.Size(547, 262);
            this.dataGridViewProducts.TabIndex = 23;
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.Location = new System.Drawing.Point(426, 68);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(129, 27);
            this.btnVerProductos.TabIndex = 22;
            this.btnVerProductos.Text = "Ver productos";
            this.btnVerProductos.UseVisualStyleBackColor = true;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // textBoxAdmin
            // 
            this.textBoxAdmin.Location = new System.Drawing.Point(424, 44);
            this.textBoxAdmin.Name = "textBoxAdmin";
            this.textBoxAdmin.Size = new System.Drawing.Size(109, 23);
            this.textBoxAdmin.TabIndex = 10;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(126, 89);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(292, 23);
            this.textBoxDesc.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(8, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "Producto:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxProducto
            // 
            this.textBoxProducto.Location = new System.Drawing.Point(290, 21);
            this.textBoxProducto.Name = "textBoxProducto";
            this.textBoxProducto.Size = new System.Drawing.Size(166, 23);
            this.textBoxProducto.TabIndex = 29;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(464, 19);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(93, 27);
            this.buttonAddProduct.TabIndex = 30;
            this.buttonAddProduct.Text = "Agregar";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // comboProductoBus
            // 
            this.comboProductoBus.FormattingEnabled = true;
            this.comboProductoBus.Location = new System.Drawing.Point(114, 21);
            this.comboProductoBus.Name = "comboProductoBus";
            this.comboProductoBus.Size = new System.Drawing.Size(170, 23);
            this.comboProductoBus.TabIndex = 31;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 432);
            this.Controls.Add(this.TabController);
            this.MaximizeBox = false;
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.TabController.ResumeLayout(false);
            this.tabDirecciones.ResumeLayout(false);
            this.tabNegocios.ResumeLayout(false);
            this.tabOrdenes.ResumeLayout(false);
            this.TabAgregar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewOrders)).EndInit();
            this.AddUser.ResumeLayout(false);
            this.AddUser.PerformLayout();
            this.AddBusiness.ResumeLayout(false);
            this.AddBusiness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewBus)).EndInit();
            this.tabProductos.ResumeLayout(false);
            this.tabProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage TabAgregar;
        private System.Windows.Forms.TabPage tabOrdenes;
        private System.Windows.Forms.TabPage tabNegocios;
        private System.Windows.Forms.TabControl TabController;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVerUsuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonPedidos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox AddUser;
        private System.Windows.Forms.GroupBox AddBusiness;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAddBus;
        private System.Windows.Forms.TextBox textBoxNbus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVerNegocios;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnEliminarUser;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboEliminarBus;
        private System.Windows.Forms.ComboBox comboEliminarUser;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridViewBus;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.Button btnVerProductos;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button btnEliminarProductos;
        private System.Windows.Forms.ComboBox comboBoxProductos;
        private System.Windows.Forms.Button btnEliminarBus;
        private System.Windows.Forms.TextBox textBoxAdmin;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxProducto;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.ComboBox comboProductoBus;
        private System.Windows.Forms.TabPage tabDirecciones;
    }
}