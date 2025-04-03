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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            monthCalendarAlquiler = new MonthCalendar();
            monthCalendarDevolucion = new MonthCalendar();
            buttonGuardar = new Button();
            comboBoxCliente = new ComboBox();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 46);
            label1.Name = "label1";
            label1.Size = new Size(213, 32);
            label1.TabIndex = 5;
            label1.Text = "Ingresar Vehiculo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 120);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 6;
            label2.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 172);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "Placa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(376, 120);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 8;
            label4.Text = "Fecha de Alquiler:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(608, 120);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 9;
            label5.Text = "Fecha de devolución:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 216);
            label6.Name = "label6";
            label6.Size = new Size(123, 15);
            label6.TabIndex = 10;
            label6.Text = "Kilometros recorridos:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(178, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(178, 216);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 13;
            // 
            // monthCalendarAlquiler
            // 
            monthCalendarAlquiler.Location = new Point(310, 144);
            monthCalendarAlquiler.Name = "monthCalendarAlquiler";
            monthCalendarAlquiler.TabIndex = 14;
            // 
            // monthCalendarDevolucion
            // 
            monthCalendarDevolucion.Location = new Point(555, 144);
            monthCalendarDevolucion.Name = "monthCalendarDevolucion";
            monthCalendarDevolucion.TabIndex = 15;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(607, 388);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 40);
            buttonGuardar.TabIndex = 16;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(178, 117);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(100, 23);
            comboBoxCliente.TabIndex = 17;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(688, 388);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(94, 40);
            buttonClose.TabIndex = 18;
            buttonClose.Text = "Regresar";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // FormAlquiler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClose);
            Controls.Add(comboBoxCliente);
            Controls.Add(buttonGuardar);
            Controls.Add(monthCalendarDevolucion);
            Controls.Add(monthCalendarAlquiler);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAlquiler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guardar un Alquiler";
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
        private TextBox textBox2;
        private TextBox textBox3;
        private MonthCalendar monthCalendarAlquiler;
        private MonthCalendar monthCalendarDevolucion;
        private Button buttonGuardar;
        private ComboBox comboBoxCliente;
        private Button buttonClose;
    }
}