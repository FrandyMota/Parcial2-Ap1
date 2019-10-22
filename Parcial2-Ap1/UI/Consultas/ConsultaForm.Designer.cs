namespace Parcial2_Ap1.UI.Consultas
{
    partial class ConsultaForm
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
            this.Desdelabel = new System.Windows.Forms.Label();
            this.Hastalabel = new System.Windows.Forms.Label();
            this.Filtrarlabel = new System.Windows.Forms.Label();
            this.Criteriolabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Consultarbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Desdelabel
            // 
            this.Desdelabel.AutoSize = true;
            this.Desdelabel.Location = new System.Drawing.Point(12, 39);
            this.Desdelabel.Name = "Desdelabel";
            this.Desdelabel.Size = new System.Drawing.Size(38, 13);
            this.Desdelabel.TabIndex = 0;
            this.Desdelabel.Text = "Desde";
            // 
            // Hastalabel
            // 
            this.Hastalabel.AutoSize = true;
            this.Hastalabel.Location = new System.Drawing.Point(194, 38);
            this.Hastalabel.Name = "Hastalabel";
            this.Hastalabel.Size = new System.Drawing.Size(35, 13);
            this.Hastalabel.TabIndex = 1;
            this.Hastalabel.Text = "Hasta";
            // 
            // Filtrarlabel
            // 
            this.Filtrarlabel.AutoSize = true;
            this.Filtrarlabel.Location = new System.Drawing.Point(379, 39);
            this.Filtrarlabel.Name = "Filtrarlabel";
            this.Filtrarlabel.Size = new System.Drawing.Size(32, 13);
            this.Filtrarlabel.TabIndex = 2;
            this.Filtrarlabel.Text = "Filtrar";
            // 
            // Criteriolabel
            // 
            this.Criteriolabel.AutoSize = true;
            this.Criteriolabel.Location = new System.Drawing.Point(556, 38);
            this.Criteriolabel.Name = "Criteriolabel";
            this.Criteriolabel.Size = new System.Drawing.Size(39, 13);
            this.Criteriolabel.TabIndex = 3;
            this.Criteriolabel.Text = "Criterio";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(235, 38);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(429, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(607, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Consultarbutton
            // 
            this.Consultarbutton.Location = new System.Drawing.Point(714, 34);
            this.Consultarbutton.Name = "Consultarbutton";
            this.Consultarbutton.Size = new System.Drawing.Size(75, 23);
            this.Consultarbutton.TabIndex = 8;
            this.Consultarbutton.Text = "Consultar";
            this.Consultarbutton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 338);
            this.dataGridView1.TabIndex = 9;
            // 
            // ConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Consultarbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Criteriolabel);
            this.Controls.Add(this.Filtrarlabel);
            this.Controls.Add(this.Hastalabel);
            this.Controls.Add(this.Desdelabel);
            this.Name = "ConsultaForm";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Desdelabel;
        private System.Windows.Forms.Label Hastalabel;
        private System.Windows.Forms.Label Filtrarlabel;
        private System.Windows.Forms.Label Criteriolabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Consultarbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}