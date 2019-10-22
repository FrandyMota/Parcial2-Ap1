namespace Parcial2_Ap1.UI.Registros
{
    partial class RegistroForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroForm));
            this.Idlabel = new System.Windows.Forms.Label();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.Totallabel = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.ServicioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Estudiantelabel = new System.Windows.Forms.Label();
            this.EstudiantetextBox = new System.Windows.Forms.TextBox();
            this.CategoriagroupBox = new System.Windows.Forms.GroupBox();
            this.Sbutton = new System.Windows.Forms.Button();
            this.ImportetextBox = new System.Windows.Forms.TextBox();
            this.Importelabel = new System.Windows.Forms.Label();
            this.Preciolabel = new System.Windows.Forms.Label();
            this.Cantidadlabel = new System.Windows.Forms.Label();
            this.Serviciolabel = new System.Windows.Forms.Label();
            this.CategoriacomboBox = new System.Windows.Forms.ComboBox();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrecionumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            this.CategoriagroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Idlabel
            // 
            this.Idlabel.AutoSize = true;
            this.Idlabel.Location = new System.Drawing.Point(22, 28);
            this.Idlabel.Name = "Idlabel";
            this.Idlabel.Size = new System.Drawing.Size(16, 13);
            this.Idlabel.TabIndex = 0;
            this.Idlabel.Text = "Id";
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Location = new System.Drawing.Point(413, 27);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(37, 13);
            this.Fechalabel.TabIndex = 1;
            this.Fechalabel.Text = "Fecha";
            // 
            // Totallabel
            // 
            this.Totallabel.AutoSize = true;
            this.Totallabel.Location = new System.Drawing.Point(453, 371);
            this.Totallabel.Name = "Totallabel";
            this.Totallabel.Size = new System.Drawing.Size(31, 13);
            this.Totallabel.TabIndex = 2;
            this.Totallabel.Text = "Total";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(182, 28);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 6;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Removerbutton
            // 
            this.Removerbutton.Location = new System.Drawing.Point(25, 371);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(75, 23);
            this.Removerbutton.TabIndex = 7;
            this.Removerbutton.Text = "Remover";
            this.Removerbutton.UseVisualStyleBackColor = true;
            this.Removerbutton.Click += new System.EventHandler(this.Removerbutton_Click);
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(456, 27);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(135, 20);
            this.FechadateTimePicker.TabIndex = 9;
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServicioColumn,
            this.CantidadColumn,
            this.PrecioColumn,
            this.ImporteColumn});
            this.DetalledataGridView.Location = new System.Drawing.Point(25, 233);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.Size = new System.Drawing.Size(566, 120);
            this.DetalledataGridView.TabIndex = 10;
            // 
            // ServicioColumn
            // 
            this.ServicioColumn.HeaderText = "Servicio";
            this.ServicioColumn.Name = "ServicioColumn";
            // 
            // CantidadColumn
            // 
            this.CantidadColumn.HeaderText = "Cantidad";
            this.CantidadColumn.Name = "CantidadColumn";
            // 
            // PrecioColumn
            // 
            this.PrecioColumn.HeaderText = "Precio";
            this.PrecioColumn.Name = "PrecioColumn";
            // 
            // ImporteColumn
            // 
            this.ImporteColumn.HeaderText = "Importe";
            this.ImporteColumn.Name = "ImporteColumn";
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(491, 368);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.Size = new System.Drawing.Size(100, 20);
            this.TotaltextBox.TabIndex = 11;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(516, 427);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 40);
            this.Eliminarbutton.TabIndex = 25;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(285, 427);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 40);
            this.Guardarbutton.TabIndex = 24;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(25, 427);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 40);
            this.Nuevobutton.TabIndex = 23;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Estudiantelabel
            // 
            this.Estudiantelabel.AutoSize = true;
            this.Estudiantelabel.Location = new System.Drawing.Point(22, 77);
            this.Estudiantelabel.Name = "Estudiantelabel";
            this.Estudiantelabel.Size = new System.Drawing.Size(57, 13);
            this.Estudiantelabel.TabIndex = 27;
            this.Estudiantelabel.Text = "Estudiante";
            // 
            // EstudiantetextBox
            // 
            this.EstudiantetextBox.Location = new System.Drawing.Point(88, 74);
            this.EstudiantetextBox.Name = "EstudiantetextBox";
            this.EstudiantetextBox.Size = new System.Drawing.Size(503, 20);
            this.EstudiantetextBox.TabIndex = 28;
            // 
            // CategoriagroupBox
            // 
            this.CategoriagroupBox.Controls.Add(this.PrecionumericUpDown);
            this.CategoriagroupBox.Controls.Add(this.CantidadnumericUpDown);
            this.CategoriagroupBox.Controls.Add(this.Sbutton);
            this.CategoriagroupBox.Controls.Add(this.ImportetextBox);
            this.CategoriagroupBox.Controls.Add(this.Importelabel);
            this.CategoriagroupBox.Controls.Add(this.Preciolabel);
            this.CategoriagroupBox.Controls.Add(this.Cantidadlabel);
            this.CategoriagroupBox.Controls.Add(this.Serviciolabel);
            this.CategoriagroupBox.Controls.Add(this.CategoriacomboBox);
            this.CategoriagroupBox.Location = new System.Drawing.Point(25, 110);
            this.CategoriagroupBox.Name = "CategoriagroupBox";
            this.CategoriagroupBox.Size = new System.Drawing.Size(566, 100);
            this.CategoriagroupBox.TabIndex = 29;
            this.CategoriagroupBox.TabStop = false;
            this.CategoriagroupBox.Text = "Categoria";
            // 
            // Sbutton
            // 
            this.Sbutton.Location = new System.Drawing.Point(493, 38);
            this.Sbutton.Name = "Sbutton";
            this.Sbutton.Size = new System.Drawing.Size(41, 23);
            this.Sbutton.TabIndex = 8;
            this.Sbutton.Text = "+";
            this.Sbutton.UseVisualStyleBackColor = true;
            this.Sbutton.Click += new System.EventHandler(this.Sbutton_Click);
            // 
            // ImportetextBox
            // 
            this.ImportetextBox.Location = new System.Drawing.Point(387, 42);
            this.ImportetextBox.Name = "ImportetextBox";
            this.ImportetextBox.Size = new System.Drawing.Size(100, 20);
            this.ImportetextBox.TabIndex = 7;
            this.ImportetextBox.TextChanged += new System.EventHandler(this.ImportetextBox_TextChanged);
            // 
            // Importelabel
            // 
            this.Importelabel.AutoSize = true;
            this.Importelabel.Location = new System.Drawing.Point(388, 22);
            this.Importelabel.Name = "Importelabel";
            this.Importelabel.Size = new System.Drawing.Size(42, 13);
            this.Importelabel.TabIndex = 6;
            this.Importelabel.Text = "Importe";
            // 
            // Preciolabel
            // 
            this.Preciolabel.AutoSize = true;
            this.Preciolabel.Location = new System.Drawing.Point(287, 19);
            this.Preciolabel.Name = "Preciolabel";
            this.Preciolabel.Size = new System.Drawing.Size(37, 13);
            this.Preciolabel.TabIndex = 4;
            this.Preciolabel.Text = "Precio";
            // 
            // Cantidadlabel
            // 
            this.Cantidadlabel.AutoSize = true;
            this.Cantidadlabel.Location = new System.Drawing.Point(154, 20);
            this.Cantidadlabel.Name = "Cantidadlabel";
            this.Cantidadlabel.Size = new System.Drawing.Size(49, 13);
            this.Cantidadlabel.TabIndex = 2;
            this.Cantidadlabel.Text = "Cantidad";
            // 
            // Serviciolabel
            // 
            this.Serviciolabel.AutoSize = true;
            this.Serviciolabel.Location = new System.Drawing.Point(7, 22);
            this.Serviciolabel.Name = "Serviciolabel";
            this.Serviciolabel.Size = new System.Drawing.Size(45, 13);
            this.Serviciolabel.TabIndex = 1;
            this.Serviciolabel.Text = "Servicio";
            // 
            // CategoriacomboBox
            // 
            this.CategoriacomboBox.FormattingEnabled = true;
            this.CategoriacomboBox.Location = new System.Drawing.Point(7, 41);
            this.CategoriacomboBox.Name = "CategoriacomboBox";
            this.CategoriacomboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoriacomboBox.TabIndex = 0;
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(45, 27);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.IdnumericUpDown.TabIndex = 30;
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(157, 41);
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(99, 20);
            this.CantidadnumericUpDown.TabIndex = 9;
            this.CantidadnumericUpDown.ValueChanged += new System.EventHandler(this.CantidadnumericUpDown_ValueChanged);
            // 
            // PrecionumericUpDown
            // 
            this.PrecionumericUpDown.Location = new System.Drawing.Point(283, 41);
            this.PrecionumericUpDown.Name = "PrecionumericUpDown";
            this.PrecionumericUpDown.Size = new System.Drawing.Size(98, 20);
            this.PrecionumericUpDown.TabIndex = 10;
            this.PrecionumericUpDown.ValueChanged += new System.EventHandler(this.PrecionumericUpDown_ValueChanged);
            // 
            // RegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 479);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.CategoriagroupBox);
            this.Controls.Add(this.EstudiantetextBox);
            this.Controls.Add(this.Estudiantelabel);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.DetalledataGridView);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.Removerbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Totallabel);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.Idlabel);
            this.Name = "RegistroForm";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.RegistroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            this.CategoriagroupBox.ResumeLayout(false);
            this.CategoriagroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Idlabel;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.Label Totallabel;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteColumn;
        private System.Windows.Forms.Label Estudiantelabel;
        private System.Windows.Forms.TextBox EstudiantetextBox;
        private System.Windows.Forms.GroupBox CategoriagroupBox;
        private System.Windows.Forms.Button Sbutton;
        private System.Windows.Forms.TextBox ImportetextBox;
        private System.Windows.Forms.Label Importelabel;
        private System.Windows.Forms.Label Preciolabel;
        private System.Windows.Forms.Label Cantidadlabel;
        private System.Windows.Forms.Label Serviciolabel;
        private System.Windows.Forms.ComboBox CategoriacomboBox;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.NumericUpDown PrecionumericUpDown;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
    }
}