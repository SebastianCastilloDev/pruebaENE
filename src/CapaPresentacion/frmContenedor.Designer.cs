namespace CapaPresentacion
{
    partial class frmContenedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.administradorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTrabajadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTrabajadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarTrabajadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTrabajadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioNormalMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTrabajadorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarTrabajadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTrabajadores = new System.Windows.Forms.DataGridView();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Afp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasTrabajadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasExtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SueldoBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SueldoLiquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrabajadores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1013, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(1062, 6);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "lblUsuario";
            // 
            // contenedor
            // 
            this.contenedor.Location = new System.Drawing.Point(0, 26);
            this.contenedor.Margin = new System.Windows.Forms.Padding(2);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(568, 609);
            this.contenedor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1140, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rol:";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(1163, 6);
            this.lblRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(53, 13);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "lblUsuario";
            // 
            // administradorMenu
            // 
            this.administradorMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarTrabajadorToolStripMenuItem,
            this.consultarTrabajadorToolStripMenuItem,
            this.actualizarTrabajadorToolStripMenuItem,
            this.eliminarTrabajadorToolStripMenuItem});
            this.administradorMenu.Name = "administradorMenu";
            this.administradorMenu.Size = new System.Drawing.Size(95, 22);
            this.administradorMenu.Text = "Administrador";
            // 
            // agregarTrabajadorToolStripMenuItem
            // 
            this.agregarTrabajadorToolStripMenuItem.Name = "agregarTrabajadorToolStripMenuItem";
            this.agregarTrabajadorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.agregarTrabajadorToolStripMenuItem.Text = "Agregar Trabajador";
            this.agregarTrabajadorToolStripMenuItem.Click += new System.EventHandler(this.agregarTrabajadorToolStripMenuItem_Click);
            // 
            // consultarTrabajadorToolStripMenuItem
            // 
            this.consultarTrabajadorToolStripMenuItem.Name = "consultarTrabajadorToolStripMenuItem";
            this.consultarTrabajadorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.consultarTrabajadorToolStripMenuItem.Text = "Consultar Trabajador";
            this.consultarTrabajadorToolStripMenuItem.Click += new System.EventHandler(this.consultarTrabajadorToolStripMenuItem_Click);
            // 
            // actualizarTrabajadorToolStripMenuItem
            // 
            this.actualizarTrabajadorToolStripMenuItem.Name = "actualizarTrabajadorToolStripMenuItem";
            this.actualizarTrabajadorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.actualizarTrabajadorToolStripMenuItem.Text = "Actualizar Trabajador";
            this.actualizarTrabajadorToolStripMenuItem.Click += new System.EventHandler(this.actualizarTrabajadorToolStripMenuItem_Click);
            // 
            // eliminarTrabajadorToolStripMenuItem
            // 
            this.eliminarTrabajadorToolStripMenuItem.Name = "eliminarTrabajadorToolStripMenuItem";
            this.eliminarTrabajadorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.eliminarTrabajadorToolStripMenuItem.Text = "Eliminar Trabajador";
            this.eliminarTrabajadorToolStripMenuItem.Click += new System.EventHandler(this.eliminarTrabajadorToolStripMenuItem_Click);
            // 
            // usuarioNormalMenu
            // 
            this.usuarioNormalMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarTrabajadorToolStripMenuItem1,
            this.editarTrabajadorToolStripMenuItem});
            this.usuarioNormalMenu.Name = "usuarioNormalMenu";
            this.usuarioNormalMenu.Size = new System.Drawing.Size(102, 22);
            this.usuarioNormalMenu.Text = "Usuario Normal";
            // 
            // consultarTrabajadorToolStripMenuItem1
            // 
            this.consultarTrabajadorToolStripMenuItem1.Name = "consultarTrabajadorToolStripMenuItem1";
            this.consultarTrabajadorToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.consultarTrabajadorToolStripMenuItem1.Text = "Consultar Trabajador";
            this.consultarTrabajadorToolStripMenuItem1.Click += new System.EventHandler(this.consultarTrabajadorToolStripMenuItem1_Click);
            // 
            // editarTrabajadorToolStripMenuItem
            // 
            this.editarTrabajadorToolStripMenuItem.Name = "editarTrabajadorToolStripMenuItem";
            this.editarTrabajadorToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.editarTrabajadorToolStripMenuItem.Text = "Editar Trabajador";
            this.editarTrabajadorToolStripMenuItem.Click += new System.EventHandler(this.editarTrabajadorToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorMenu,
            this.usuarioNormalMenu,
            this.salirToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(1248, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(597, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Listado de trabajadores";
            // 
            // dataGridViewTrabajadores
            // 
            this.dataGridViewTrabajadores.AllowUserToAddRows = false;
            this.dataGridViewTrabajadores.AllowUserToDeleteRows = false;
            this.dataGridViewTrabajadores.AllowUserToResizeColumns = false;
            this.dataGridViewTrabajadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewTrabajadores.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTrabajadores.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewTrabajadores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTrabajadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrabajadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rut,
            this.Nombre,
            this.Direccion,
            this.Afp,
            this.Salud,
            this.HorasTrabajadas,
            this.HorasExtra,
            this.SueldoBruto,
            this.SueldoLiquido});
            this.dataGridViewTrabajadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewTrabajadores.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridViewTrabajadores.Location = new System.Drawing.Point(600, 61);
            this.dataGridViewTrabajadores.MultiSelect = false;
            this.dataGridViewTrabajadores.Name = "dataGridViewTrabajadores";
            this.dataGridViewTrabajadores.ReadOnly = true;
            this.dataGridViewTrabajadores.RowHeadersVisible = false;
            this.dataGridViewTrabajadores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewTrabajadores.Size = new System.Drawing.Size(648, 516);
            this.dataGridViewTrabajadores.TabIndex = 7;
            this.dataGridViewTrabajadores.TabStop = false;
            // 
            // Rut
            // 
            this.Rut.HeaderText = "Rut";
            this.Rut.Name = "Rut";
            this.Rut.ReadOnly = true;
            this.Rut.Width = 52;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 75;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 86;
            // 
            // Afp
            // 
            this.Afp.HeaderText = "Afp";
            this.Afp.Name = "Afp";
            this.Afp.ReadOnly = true;
            this.Afp.Width = 51;
            // 
            // Salud
            // 
            this.Salud.HeaderText = "Salud";
            this.Salud.Name = "Salud";
            this.Salud.ReadOnly = true;
            this.Salud.Width = 64;
            // 
            // HorasTrabajadas
            // 
            this.HorasTrabajadas.HeaderText = "HT";
            this.HorasTrabajadas.Name = "HorasTrabajadas";
            this.HorasTrabajadas.ReadOnly = true;
            this.HorasTrabajadas.Width = 49;
            // 
            // HorasExtra
            // 
            this.HorasExtra.HeaderText = "HE";
            this.HorasExtra.Name = "HorasExtra";
            this.HorasExtra.ReadOnly = true;
            this.HorasExtra.Width = 49;
            // 
            // SueldoBruto
            // 
            this.SueldoBruto.HeaderText = "Sueldo Bruto";
            this.SueldoBruto.Name = "SueldoBruto";
            this.SueldoBruto.ReadOnly = true;
            this.SueldoBruto.Width = 96;
            // 
            // SueldoLiquido
            // 
            this.SueldoLiquido.HeaderText = "Sueldo Liquido";
            this.SueldoLiquido.Name = "SueldoLiquido";
            this.SueldoLiquido.ReadOnly = true;
            this.SueldoLiquido.Width = 106;
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(600, 592);
            this.btnRecargar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(107, 30);
            this.btnRecargar.TabIndex = 8;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // frmContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 633);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.dataGridViewTrabajadores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmContenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.frmContenedor_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrabajadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ToolStripMenuItem administradorMenu;
        private System.Windows.Forms.ToolStripMenuItem usuarioNormalMenu;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewTrabajadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Afp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salud;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasTrabajadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasExtra;
        private System.Windows.Forms.ToolStripMenuItem agregarTrabajadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTrabajadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarTrabajadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarTrabajadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTrabajadorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarTrabajadorToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn SueldoBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn SueldoLiquido;
        private System.Windows.Forms.Button btnRecargar;
    }
}