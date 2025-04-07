namespace Laboratorio7_EmpresaAlquiler
{
    partial class FormAlquiler
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxKm = new TextBox();
            monthCalendarAlquiler = new MonthCalendar();
            monthCalendarDevolucion = new MonthCalendar();
            buttonGuardar = new Button();
            comboBoxCliente = new ComboBox();
            buttonClose = new Button();
            comboBoxPlaca = new ComboBox();
            dataGridViewVehiculos = new DataGridView();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(429, 19);
            label1.Name = "label1";
            label1.Size = new Size(255, 41);
            label1.TabIndex = 5;
            label1.Text = "Ingresar Alquiler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(352, 120);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 6;
            label2.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 189);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 7;
            label3.Text = "Placa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(640, 88);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 8;
            label4.Text = "Fecha de Alquiler:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(905, 88);
            label5.Name = "label5";
            label5.Size = new Size(148, 20);
            label5.TabIndex = 9;
            label5.Text = "Fecha de devolución:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(255, 248);
            label6.Name = "label6";
            label6.Size = new Size(155, 20);
            label6.TabIndex = 10;
            label6.Text = "Kilometros recorridos:";
            // 
            // textBoxKm
            // 
            textBoxKm.Location = new Point(412, 248);
            textBoxKm.Margin = new Padding(3, 4, 3, 4);
            textBoxKm.Name = "textBoxKm";
            textBoxKm.Size = new Size(114, 27);
            textBoxKm.TabIndex = 13;
            // 
            // monthCalendarAlquiler
            // 
            monthCalendarAlquiler.Location = new Point(564, 120);
            monthCalendarAlquiler.Margin = new Padding(10, 12, 10, 12);
            monthCalendarAlquiler.Name = "monthCalendarAlquiler";
            monthCalendarAlquiler.TabIndex = 14;
            // 
            // monthCalendarDevolucion
            // 
            monthCalendarDevolucion.Location = new Point(844, 120);
            monthCalendarDevolucion.Margin = new Padding(10, 12, 10, 12);
            monthCalendarDevolucion.Name = "monthCalendarDevolucion";
            monthCalendarDevolucion.TabIndex = 15;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(917, 505);
            buttonGuardar.Margin = new Padding(3, 4, 3, 4);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(86, 53);
            buttonGuardar.TabIndex = 16;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(412, 116);
            comboBoxCliente.Margin = new Padding(3, 4, 3, 4);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(114, 28);
            comboBoxCliente.TabIndex = 17;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(1019, 505);
            buttonClose.Margin = new Padding(3, 4, 3, 4);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(107, 53);
            buttonClose.TabIndex = 18;
            buttonClose.Text = "Regresar";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // comboBoxPlaca
            // 
            comboBoxPlaca.FormattingEnabled = true;
            comboBoxPlaca.Location = new Point(412, 186);
            comboBoxPlaca.Name = "comboBoxPlaca";
            comboBoxPlaca.Size = new Size(114, 28);
            comboBoxPlaca.TabIndex = 19;
            // 
            // dataGridViewVehiculos
            // 
            dataGridViewVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVehiculos.Location = new Point(38, 350);
            dataGridViewVehiculos.Name = "dataGridViewVehiculos";
            dataGridViewVehiculos.RowHeadersWidth = 51;
            dataGridViewVehiculos.Size = new Size(679, 188);
            dataGridViewVehiculos.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(67, 327);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 21;
            label7.Text = "Vehiculos:";
            // 
            // FormAlquiler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 600);
            Controls.Add(label7);
            Controls.Add(dataGridViewVehiculos);
            Controls.Add(comboBoxPlaca);
            Controls.Add(buttonClose);
            Controls.Add(comboBoxCliente);
            Controls.Add(buttonGuardar);
            Controls.Add(monthCalendarDevolucion);
            Controls.Add(monthCalendarAlquiler);
            Controls.Add(textBoxKm);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAlquiler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guardar un Alquiler";
            Load += FormAlquiler_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxKm;
        private MonthCalendar monthCalendarAlquiler;
        private MonthCalendar monthCalendarDevolucion;
        private Button buttonGuardar;
        private ComboBox comboBoxCliente;
        private Button buttonClose;
        private ComboBox comboBoxPlaca;
        private DataGridView dataGridViewVehiculos;
        private Label label7;
    }
}