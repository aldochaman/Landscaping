﻿namespace COMPLETE_FLAT_UI
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
               this.components = new System.ComponentModel.Container();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
               this.panelContenedorPrincipal = new System.Windows.Forms.Panel();
               this.panelContenedorForm = new System.Windows.Forms.Panel();
               this.panel1 = new System.Windows.Forms.Panel();
               this.lbFecha = new System.Windows.Forms.Label();
               this.lblHora = new System.Windows.Forms.Label();
               this.panelMenu = new System.Windows.Forms.Panel();
               this.button2 = new System.Windows.Forms.Button();
               this.btnSalir = new System.Windows.Forms.PictureBox();
               this.btnMenu = new System.Windows.Forms.PictureBox();
               this.pictureBox5 = new System.Windows.Forms.PictureBox();
               this.pictureBox6 = new System.Windows.Forms.PictureBox();
               this.pictureBox3 = new System.Windows.Forms.PictureBox();
               this.btnListaServicios = new System.Windows.Forms.Button();
               this.pictureBox4 = new System.Windows.Forms.PictureBox();
               this.btnMembresia = new System.Windows.Forms.Button();
               this.pictureBox2 = new System.Windows.Forms.PictureBox();
               this.btnListaClientes = new System.Windows.Forms.Button();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.button1 = new System.Windows.Forms.Button();
               this.PanelBarraTitulo = new System.Windows.Forms.Panel();
               this.label1 = new System.Windows.Forms.Label();
               this.btnNormal = new System.Windows.Forms.Button();
               this.btnMinimizar = new System.Windows.Forms.Button();
               this.btnMaximizar = new System.Windows.Forms.Button();
               this.btnCerrar = new System.Windows.Forms.Button();
               this.tmExpandirMenu = new System.Windows.Forms.Timer(this.components);
               this.tmContraerMenu = new System.Windows.Forms.Timer(this.components);
               this.tmFechaHora = new System.Windows.Forms.Timer(this.components);
               this.panelContenedorPrincipal.SuspendLayout();
               this.panel1.SuspendLayout();
               this.panelMenu.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.PanelBarraTitulo.SuspendLayout();
               this.SuspendLayout();
               // 
               // panelContenedorPrincipal
               // 
               this.panelContenedorPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
               this.panelContenedorPrincipal.Controls.Add(this.panelContenedorForm);
               this.panelContenedorPrincipal.Controls.Add(this.panel1);
               this.panelContenedorPrincipal.Controls.Add(this.panelMenu);
               this.panelContenedorPrincipal.Controls.Add(this.PanelBarraTitulo);
               this.panelContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
               this.panelContenedorPrincipal.Location = new System.Drawing.Point(0, 0);
               this.panelContenedorPrincipal.Name = "panelContenedorPrincipal";
               this.panelContenedorPrincipal.Size = new System.Drawing.Size(1100, 600);
               this.panelContenedorPrincipal.TabIndex = 0;
               // 
               // panelContenedorForm
               // 
               this.panelContenedorForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
               this.panelContenedorForm.Dock = System.Windows.Forms.DockStyle.Fill;
               this.panelContenedorForm.Location = new System.Drawing.Point(230, 43);
               this.panelContenedorForm.Name = "panelContenedorForm";
               this.panelContenedorForm.Size = new System.Drawing.Size(870, 457);
               this.panelContenedorForm.TabIndex = 6;
               this.panelContenedorForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedorForm_Paint);
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
               this.panel1.Controls.Add(this.lbFecha);
               this.panel1.Controls.Add(this.lblHora);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
               this.panel1.Location = new System.Drawing.Point(230, 500);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(870, 100);
               this.panel1.TabIndex = 5;
               // 
               // lbFecha
               // 
               this.lbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.lbFecha.AutoSize = true;
               this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
               this.lbFecha.ForeColor = System.Drawing.Color.White;
               this.lbFecha.Location = new System.Drawing.Point(608, 71);
               this.lbFecha.Name = "lbFecha";
               this.lbFecha.Size = new System.Drawing.Size(224, 20);
               this.lbFecha.TabIndex = 4;
               this.lbFecha.Text = "Lunes, 26 de septiembre 2018";
               // 
               // lblHora
               // 
               this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.lblHora.AutoSize = true;
               this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblHora.ForeColor = System.Drawing.Color.LightGray;
               this.lblHora.Location = new System.Drawing.Point(612, 11);
               this.lblHora.Name = "lblHora";
               this.lblHora.Size = new System.Drawing.Size(205, 54);
               this.lblHora.TabIndex = 1;
               this.lblHora.Text = "21:49:45";
               // 
               // panelMenu
               // 
               this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
               this.panelMenu.Controls.Add(this.button2);
               this.panelMenu.Controls.Add(this.btnSalir);
               this.panelMenu.Controls.Add(this.btnMenu);
               this.panelMenu.Controls.Add(this.pictureBox5);
               this.panelMenu.Controls.Add(this.pictureBox6);
               this.panelMenu.Controls.Add(this.pictureBox3);
               this.panelMenu.Controls.Add(this.btnListaServicios);
               this.panelMenu.Controls.Add(this.pictureBox4);
               this.panelMenu.Controls.Add(this.btnMembresia);
               this.panelMenu.Controls.Add(this.pictureBox2);
               this.panelMenu.Controls.Add(this.btnListaClientes);
               this.panelMenu.Controls.Add(this.pictureBox1);
               this.panelMenu.Controls.Add(this.button1);
               this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
               this.panelMenu.Location = new System.Drawing.Point(0, 43);
               this.panelMenu.Name = "panelMenu";
               this.panelMenu.Size = new System.Drawing.Size(230, 557);
               this.panelMenu.TabIndex = 2;
               // 
               // button2
               // 
               this.button2.Cursor = System.Windows.Forms.Cursors.Default;
               this.button2.FlatAppearance.BorderSize = 0;
               this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
               this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
               this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button2.ForeColor = System.Drawing.Color.Silver;
               this.button2.Image = global::COMPLETE_FLAT_UI.Properties.Resources.Planes;
               this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.button2.Location = new System.Drawing.Point(3, 174);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(230, 40);
               this.button2.TabIndex = 14;
               this.button2.Text = "Factura";
               this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
               this.button2.UseVisualStyleBackColor = true;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // btnSalir
               // 
               this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
               this.btnSalir.Location = new System.Drawing.Point(9, 517);
               this.btnSalir.Name = "btnSalir";
               this.btnSalir.Size = new System.Drawing.Size(33, 31);
               this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.btnSalir.TabIndex = 13;
               this.btnSalir.TabStop = false;
               this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
               // 
               // btnMenu
               // 
               this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnMenu.Image = global::COMPLETE_FLAT_UI.Properties.Resources.menu2;
               this.btnMenu.Location = new System.Drawing.Point(181, 2);
               this.btnMenu.Name = "btnMenu";
               this.btnMenu.Size = new System.Drawing.Size(43, 37);
               this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
               this.btnMenu.TabIndex = 12;
               this.btnMenu.TabStop = false;
               this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
               // 
               // pictureBox5
               // 
               this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
               this.pictureBox5.Location = new System.Drawing.Point(0, 310);
               this.pictureBox5.Name = "pictureBox5";
               this.pictureBox5.Size = new System.Drawing.Size(2, 40);
               this.pictureBox5.TabIndex = 11;
               this.pictureBox5.TabStop = false;
               // 
               // pictureBox6
               // 
               this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
               this.pictureBox6.Location = new System.Drawing.Point(0, 264);
               this.pictureBox6.Name = "pictureBox6";
               this.pictureBox6.Size = new System.Drawing.Size(2, 40);
               this.pictureBox6.TabIndex = 9;
               this.pictureBox6.TabStop = false;
               // 
               // pictureBox3
               // 
               this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
               this.pictureBox3.Location = new System.Drawing.Point(0, 218);
               this.pictureBox3.Name = "pictureBox3";
               this.pictureBox3.Size = new System.Drawing.Size(2, 40);
               this.pictureBox3.TabIndex = 7;
               this.pictureBox3.TabStop = false;
               // 
               // btnListaServicios
               // 
               this.btnListaServicios.Cursor = System.Windows.Forms.Cursors.Default;
               this.btnListaServicios.FlatAppearance.BorderSize = 0;
               this.btnListaServicios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
               this.btnListaServicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
               this.btnListaServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnListaServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnListaServicios.ForeColor = System.Drawing.Color.Silver;
               this.btnListaServicios.Image = global::COMPLETE_FLAT_UI.Properties.Resources.Planes;
               this.btnListaServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnListaServicios.Location = new System.Drawing.Point(3, 125);
               this.btnListaServicios.Name = "btnListaServicios";
               this.btnListaServicios.Size = new System.Drawing.Size(230, 40);
               this.btnListaServicios.TabIndex = 6;
               this.btnListaServicios.Text = "Servicios";
               this.btnListaServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
               this.btnListaServicios.UseVisualStyleBackColor = true;
               this.btnListaServicios.Click += new System.EventHandler(this.btnListaServicios_Click);
               // 
               // pictureBox4
               // 
               this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
               this.pictureBox4.Location = new System.Drawing.Point(0, 172);
               this.pictureBox4.Name = "pictureBox4";
               this.pictureBox4.Size = new System.Drawing.Size(2, 40);
               this.pictureBox4.TabIndex = 5;
               this.pictureBox4.TabStop = false;
               // 
               // btnMembresia
               // 
               this.btnMembresia.Cursor = System.Windows.Forms.Cursors.Default;
               this.btnMembresia.FlatAppearance.BorderSize = 0;
               this.btnMembresia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
               this.btnMembresia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
               this.btnMembresia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnMembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnMembresia.ForeColor = System.Drawing.Color.Silver;
               this.btnMembresia.Image = global::COMPLETE_FLAT_UI.Properties.Resources.Membresia;
               this.btnMembresia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnMembresia.Location = new System.Drawing.Point(0, 217);
               this.btnMembresia.Name = "btnMembresia";
               this.btnMembresia.Size = new System.Drawing.Size(230, 40);
               this.btnMembresia.TabIndex = 4;
               this.btnMembresia.Text = "Historial de Pagos";
               this.btnMembresia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
               this.btnMembresia.UseVisualStyleBackColor = true;
               this.btnMembresia.Click += new System.EventHandler(this.btnMembresia_Click);
               // 
               // pictureBox2
               // 
               this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
               this.pictureBox2.Location = new System.Drawing.Point(0, 126);
               this.pictureBox2.Name = "pictureBox2";
               this.pictureBox2.Size = new System.Drawing.Size(2, 40);
               this.pictureBox2.TabIndex = 3;
               this.pictureBox2.TabStop = false;
               // 
               // btnListaClientes
               // 
               this.btnListaClientes.Cursor = System.Windows.Forms.Cursors.Default;
               this.btnListaClientes.FlatAppearance.BorderSize = 0;
               this.btnListaClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
               this.btnListaClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
               this.btnListaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnListaClientes.ForeColor = System.Drawing.Color.Silver;
               this.btnListaClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnListaClientes.Image")));
               this.btnListaClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnListaClientes.Location = new System.Drawing.Point(3, 80);
               this.btnListaClientes.Name = "btnListaClientes";
               this.btnListaClientes.Size = new System.Drawing.Size(230, 40);
               this.btnListaClientes.TabIndex = 2;
               this.btnListaClientes.Text = "Clientes";
               this.btnListaClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
               this.btnListaClientes.UseVisualStyleBackColor = true;
               this.btnListaClientes.Click += new System.EventHandler(this.btnListaClientes_Click);
               // 
               // pictureBox1
               // 
               this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
               this.pictureBox1.Location = new System.Drawing.Point(0, 80);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(2, 40);
               this.pictureBox1.TabIndex = 1;
               this.pictureBox1.TabStop = false;
               // 
               // button1
               // 
               this.button1.Cursor = System.Windows.Forms.Cursors.Default;
               this.button1.FlatAppearance.BorderSize = 0;
               this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
               this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
               this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.ForeColor = System.Drawing.Color.Silver;
               this.button1.Image = global::COMPLETE_FLAT_UI.Properties.Resources.Dashboard;
               this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.button1.Location = new System.Drawing.Point(0, 266);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(230, 40);
               this.button1.TabIndex = 0;
               this.button1.Text = "Balance";
               this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
               this.button1.UseVisualStyleBackColor = true;
               // 
               // PanelBarraTitulo
               // 
               this.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
               this.PanelBarraTitulo.Controls.Add(this.label1);
               this.PanelBarraTitulo.Controls.Add(this.btnNormal);
               this.PanelBarraTitulo.Controls.Add(this.btnMinimizar);
               this.PanelBarraTitulo.Controls.Add(this.btnMaximizar);
               this.PanelBarraTitulo.Controls.Add(this.btnCerrar);
               this.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
               this.PanelBarraTitulo.Location = new System.Drawing.Point(0, 0);
               this.PanelBarraTitulo.Name = "PanelBarraTitulo";
               this.PanelBarraTitulo.Size = new System.Drawing.Size(1100, 43);
               this.PanelBarraTitulo.TabIndex = 1;
               this.PanelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarraTitulo_MouseDown);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.Color.White;
               this.label1.Location = new System.Drawing.Point(12, 13);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(145, 16);
               this.label1.TabIndex = 4;
               this.label1.Text = "FVM LandScaping LLC";
               // 
               // btnNormal
               // 
               this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.btnNormal.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnNormal.FlatAppearance.BorderSize = 0;
               this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnNormal.Image = global::COMPLETE_FLAT_UI.Properties.Resources.Normal;
               this.btnNormal.Location = new System.Drawing.Point(996, 0);
               this.btnNormal.Name = "btnNormal";
               this.btnNormal.Size = new System.Drawing.Size(43, 43);
               this.btnNormal.TabIndex = 3;
               this.btnNormal.UseVisualStyleBackColor = true;
               this.btnNormal.Visible = false;
               this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
               // 
               // btnMinimizar
               // 
               this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnMinimizar.FlatAppearance.BorderSize = 0;
               this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnMinimizar.Image = global::COMPLETE_FLAT_UI.Properties.Resources.Minimize;
               this.btnMinimizar.Location = new System.Drawing.Point(950, 0);
               this.btnMinimizar.Name = "btnMinimizar";
               this.btnMinimizar.Size = new System.Drawing.Size(43, 43);
               this.btnMinimizar.TabIndex = 2;
               this.btnMinimizar.UseVisualStyleBackColor = true;
               this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
               // 
               // btnMaximizar
               // 
               this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnMaximizar.FlatAppearance.BorderSize = 0;
               this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnMaximizar.Image = global::COMPLETE_FLAT_UI.Properties.Resources.maximize3;
               this.btnMaximizar.Location = new System.Drawing.Point(996, 0);
               this.btnMaximizar.Name = "btnMaximizar";
               this.btnMaximizar.Size = new System.Drawing.Size(43, 43);
               this.btnMaximizar.TabIndex = 1;
               this.btnMaximizar.UseVisualStyleBackColor = true;
               this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
               // 
               // btnCerrar
               // 
               this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnCerrar.FlatAppearance.BorderSize = 0;
               this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnCerrar.Image = global::COMPLETE_FLAT_UI.Properties.Resources.Close;
               this.btnCerrar.Location = new System.Drawing.Point(1043, 2);
               this.btnCerrar.Name = "btnCerrar";
               this.btnCerrar.Size = new System.Drawing.Size(39, 39);
               this.btnCerrar.TabIndex = 0;
               this.btnCerrar.UseVisualStyleBackColor = true;
               this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
               // 
               // tmExpandirMenu
               // 
               this.tmExpandirMenu.Interval = 15;
               this.tmExpandirMenu.Tick += new System.EventHandler(this.tmExpandirMenu_Tick);
               // 
               // tmContraerMenu
               // 
               this.tmContraerMenu.Interval = 15;
               this.tmContraerMenu.Tick += new System.EventHandler(this.tmContraerMenu_Tick);
               // 
               // tmFechaHora
               // 
               this.tmFechaHora.Enabled = true;
               this.tmFechaHora.Tick += new System.EventHandler(this.tmFechaHora_Tick);
               // 
               // FormMenuPrincipal
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1100, 600);
               this.Controls.Add(this.panelContenedorPrincipal);
               this.DoubleBuffered = true;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MinimumSize = new System.Drawing.Size(680, 500);
               this.Name = "FormMenuPrincipal";
               this.Opacity = 0.95D;
               this.Text = "Form1";
               this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
               this.panelContenedorPrincipal.ResumeLayout(false);
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               this.panelMenu.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.PanelBarraTitulo.ResumeLayout(false);
               this.PanelBarraTitulo.PerformLayout();
               this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedorPrincipal;
        private System.Windows.Forms.Panel PanelBarraTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelContenedorForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnListaServicios;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnMembresia;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnListaClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmExpandirMenu;
        private System.Windows.Forms.Timer tmContraerMenu;
        private System.Windows.Forms.Timer tmFechaHora;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.PictureBox btnSalir;
     }
}

