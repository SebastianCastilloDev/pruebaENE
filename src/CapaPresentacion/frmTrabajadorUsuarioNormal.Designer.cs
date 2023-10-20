namespace CapaPresentacion
{
    partial class frmTrabajadorUsuarioNormal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSueldoLiquido = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSueldoBruto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSalud = new System.Windows.Forms.ComboBox();
            this.cbxAfp = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOperacion = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHorasExtra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtHorasTrabajadas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSueldoLiquido);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblSueldoBruto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(53, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 106);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cálculo de sueldo";
            // 
            // lblSueldoLiquido
            // 
            this.lblSueldoLiquido.AutoSize = true;
            this.lblSueldoLiquido.Location = new System.Drawing.Point(131, 64);
            this.lblSueldoLiquido.Name = "lblSueldoLiquido";
            this.lblSueldoLiquido.Size = new System.Drawing.Size(84, 13);
            this.lblSueldoLiquido.TabIndex = 0;
            this.lblSueldoLiquido.Text = "lblSueldoLiquido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sueldo Liquido: ";
            // 
            // lblSueldoBruto
            // 
            this.lblSueldoBruto.AutoSize = true;
            this.lblSueldoBruto.Location = new System.Drawing.Point(131, 37);
            this.lblSueldoBruto.Name = "lblSueldoBruto";
            this.lblSueldoBruto.Size = new System.Drawing.Size(75, 13);
            this.lblSueldoBruto.TabIndex = 0;
            this.lblSueldoBruto.Text = "lblSueldoBruto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sueldo Bruto";
            // 
            // cbxSalud
            // 
            this.cbxSalud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSalud.FormattingEnabled = true;
            this.cbxSalud.Location = new System.Drawing.Point(365, 138);
            this.cbxSalud.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSalud.Name = "cbxSalud";
            this.cbxSalud.Size = new System.Drawing.Size(120, 21);
            this.cbxSalud.TabIndex = 20;
            // 
            // cbxAfp
            // 
            this.cbxAfp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAfp.FormattingEnabled = true;
            this.cbxAfp.Location = new System.Drawing.Point(365, 110);
            this.cbxAfp.Margin = new System.Windows.Forms.Padding(2);
            this.cbxAfp.Name = "cbxAfp";
            this.cbxAfp.Size = new System.Drawing.Size(120, 21);
            this.cbxAfp.TabIndex = 19;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(316, 301);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 28);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnOperacion
            // 
            this.btnOperacion.Location = new System.Drawing.Point(122, 301);
            this.btnOperacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnOperacion.Name = "btnOperacion";
            this.btnOperacion.Size = new System.Drawing.Size(85, 28);
            this.btnOperacion.TabIndex = 21;
            this.btnOperacion.Text = "Operacion";
            this.btnOperacion.UseVisualStyleBackColor = true;
            this.btnOperacion.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sistema de salud";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "AFP";
            // 
            // txtHorasExtra
            // 
            this.txtHorasExtra.Location = new System.Drawing.Point(122, 137);
            this.txtHorasExtra.Margin = new System.Windows.Forms.Padding(2);
            this.txtHorasExtra.Name = "txtHorasExtra";
            this.txtHorasExtra.Size = new System.Drawing.Size(121, 20);
            this.txtHorasExtra.TabIndex = 18;
            this.txtHorasExtra.Leave += new System.EventHandler(this.txtHorasExtra_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Horas extra";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(122, 72);
            this.txtRut.Margin = new System.Windows.Forms.Padding(2);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(363, 20);
            this.txtRut.TabIndex = 16;
            this.txtRut.Leave += new System.EventHandler(this.txtRut_Leave);
            // 
            // txtHorasTrabajadas
            // 
            this.txtHorasTrabajadas.Location = new System.Drawing.Point(122, 108);
            this.txtHorasTrabajadas.Margin = new System.Windows.Forms.Padding(2);
            this.txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            this.txtHorasTrabajadas.Size = new System.Drawing.Size(121, 20);
            this.txtHorasTrabajadas.TabIndex = 17;
            this.txtHorasTrabajadas.Leave += new System.EventHandler(this.txtHorasTrabajadas_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Buscar por rut:";
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.Location = new System.Drawing.Point(130, 35);
            this.lblOperacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(100, 17);
            this.lblOperacion.TabIndex = 14;
            this.lblOperacion.Text = "lblOperacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Horas trabajadas";
            // 
            // frmTrabajadorUsuarioNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 374);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxSalud);
            this.Controls.Add(this.cbxAfp);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOperacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHorasExtra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.txtHorasTrabajadas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.label1);
            this.Name = "frmTrabajadorUsuarioNormal";
            this.Text = "frmTrabajadorUsuarioNormal";
            this.Load += new System.EventHandler(this.frmTrabajadorUsuarioNormal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSueldoLiquido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSueldoBruto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxSalud;
        private System.Windows.Forms.ComboBox cbxAfp;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOperacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHorasExtra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtHorasTrabajadas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Label label1;
    }
}