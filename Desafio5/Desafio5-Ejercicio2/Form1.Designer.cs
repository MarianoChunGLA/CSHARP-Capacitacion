namespace Desafio5_Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblExtranjero = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.datePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.radioHombre = new System.Windows.Forms.RadioButton();
            this.radioMujer = new System.Windows.Forms.RadioButton();
            this.checkBoxExtranjero = new System.Windows.Forms.CheckBox();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.dataGridAlumnos = new System.Windows.Forms.DataGridView();
            this.NombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistroAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCivilAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexoAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsExtranjeroAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(103, 19);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(280, 23);
            this.lblDatos.TabIndex = 0;
            this.lblDatos.Text = "Ingrese los siguientes datos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(50, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistro.Location = new System.Drawing.Point(50, 97);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(111, 13);
            this.lblFechaRegistro.TabIndex = 2;
            this.lblFechaRegistro.Text = "Fecha de registro:";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.Location = new System.Drawing.Point(50, 122);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(76, 13);
            this.lblEstadoCivil.TabIndex = 3;
            this.lblEstadoCivil.Text = "Estado civil:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(50, 149);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 13);
            this.lblSexo.TabIndex = 4;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblExtranjero
            // 
            this.lblExtranjero.AutoSize = true;
            this.lblExtranjero.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtranjero.Location = new System.Drawing.Point(50, 172);
            this.lblExtranjero.Name = "lblExtranjero";
            this.lblExtranjero.Size = new System.Drawing.Size(89, 13);
            this.lblExtranjero.TabIndex = 5;
            this.lblExtranjero.Text = "Es extranjero:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(167, 69);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 6;
            // 
            // datePickerFecha
            // 
            this.datePickerFecha.Location = new System.Drawing.Point(167, 97);
            this.datePickerFecha.Name = "datePickerFecha";
            this.datePickerFecha.Size = new System.Drawing.Size(200, 20);
            this.datePickerFecha.TabIndex = 7;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Viudo/a",
            "Divorciado/a"});
            this.comboBoxEstado.Location = new System.Drawing.Point(167, 123);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstado.TabIndex = 8;
            // 
            // radioHombre
            // 
            this.radioHombre.AutoSize = true;
            this.radioHombre.Location = new System.Drawing.Point(167, 150);
            this.radioHombre.Name = "radioHombre";
            this.radioHombre.Size = new System.Drawing.Size(62, 17);
            this.radioHombre.TabIndex = 9;
            this.radioHombre.TabStop = true;
            this.radioHombre.Text = "Hombre";
            this.radioHombre.UseVisualStyleBackColor = true;
            // 
            // radioMujer
            // 
            this.radioMujer.AutoSize = true;
            this.radioMujer.Location = new System.Drawing.Point(258, 150);
            this.radioMujer.Name = "radioMujer";
            this.radioMujer.Size = new System.Drawing.Size(51, 17);
            this.radioMujer.TabIndex = 10;
            this.radioMujer.TabStop = true;
            this.radioMujer.Text = "Mujer";
            this.radioMujer.UseVisualStyleBackColor = true;
            // 
            // checkBoxExtranjero
            // 
            this.checkBoxExtranjero.AutoSize = true;
            this.checkBoxExtranjero.Location = new System.Drawing.Point(167, 173);
            this.checkBoxExtranjero.Name = "checkBoxExtranjero";
            this.checkBoxExtranjero.Size = new System.Drawing.Size(151, 17);
            this.checkBoxExtranjero.TabIndex = 11;
            this.checkBoxExtranjero.Text = "Marque en caso afirmativo";
            this.checkBoxExtranjero.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlumno.Location = new System.Drawing.Point(167, 196);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(135, 44);
            this.btnAgregarAlumno.TabIndex = 12;
            this.btnAgregarAlumno.Text = "Agregar alumno";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // dataGridAlumnos
            // 
            this.dataGridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreAlumno,
            this.FechaRegistroAlumno,
            this.EstadoCivilAlumno,
            this.SexoAlumno,
            this.EsExtranjeroAlumno});
            this.dataGridAlumnos.Location = new System.Drawing.Point(405, 97);
            this.dataGridAlumnos.Name = "dataGridAlumnos";
            this.dataGridAlumnos.Size = new System.Drawing.Size(523, 143);
            this.dataGridAlumnos.TabIndex = 13;
            // 
            // NombreAlumno
            // 
            this.NombreAlumno.HeaderText = "Nombre";
            this.NombreAlumno.Name = "NombreAlumno";
            // 
            // FechaRegistroAlumno
            // 
            this.FechaRegistroAlumno.HeaderText = "Fecha Registro";
            this.FechaRegistroAlumno.Name = "FechaRegistroAlumno";
            // 
            // EstadoCivilAlumno
            // 
            this.EstadoCivilAlumno.HeaderText = "Estado Civil";
            this.EstadoCivilAlumno.Name = "EstadoCivilAlumno";
            // 
            // SexoAlumno
            // 
            this.SexoAlumno.HeaderText = "Sexo";
            this.SexoAlumno.Name = "SexoAlumno";
            // 
            // EsExtranjeroAlumno
            // 
            this.EsExtranjeroAlumno.HeaderText = "Es extranjero";
            this.EsExtranjeroAlumno.Name = "EsExtranjeroAlumno";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(308, 196);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 44);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.Location = new System.Drawing.Point(50, 259);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(639, 14);
            this.lblAviso.TabIndex = 15;
            this.lblAviso.Text = "Cuidado! Los campos de Nombre, Estado Civil y Sexo no deben ser vacíos. Ingrese n" +
    "uevamente los datos";
            this.lblAviso.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 308);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dataGridAlumnos);
            this.Controls.Add(this.btnAgregarAlumno);
            this.Controls.Add(this.checkBoxExtranjero);
            this.Controls.Add(this.radioMujer);
            this.Controls.Add(this.radioHombre);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.datePickerFecha);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.lblExtranjero);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.lblFechaRegistro);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblExtranjero;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.DateTimePicker datePickerFecha;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.RadioButton radioHombre;
        private System.Windows.Forms.RadioButton radioMujer;
        private System.Windows.Forms.CheckBox checkBoxExtranjero;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.DataGridView dataGridAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistroAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCivilAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexoAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn EsExtranjeroAlumno;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblAviso;
    }
}

