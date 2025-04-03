namespace Laboratorio7_EmpresaAlquiler
{
    partial class FormVehiculos
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
            textBoxPlaca = new TextBox();
            textBoxMarca = new TextBox();
            textBoxModelo = new TextBox();
            textBoxColor = new TextBox();
            textBoxPrecioKm = new TextBox();
            buttonGuardar = new Button();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(282, 40);
            label1.Name = "label1";
            label1.Size = new Size(213, 32);
            label1.TabIndex = 4;
            label1.Text = "Ingresar Vehiculo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 132);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "Placa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 179);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "Marca:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(232, 227);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "Modelo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(241, 271);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 8;
            label5.Text = "Color:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(182, 314);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 9;
            label6.Text = "Precio Kilometro:";
            // 
            // textBoxPlaca
            // 
            textBoxPlaca.Location = new Point(286, 132);
            textBoxPlaca.Name = "textBoxPlaca";
            textBoxPlaca.Size = new Size(100, 23);
            textBoxPlaca.TabIndex = 10;
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(286, 176);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(100, 23);
            textBoxMarca.TabIndex = 11;
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(286, 224);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(100, 23);
            textBoxModelo.TabIndex = 12;
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(286, 268);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(100, 23);
            textBoxColor.TabIndex = 13;
            // 
            // textBoxPrecioKm
            // 
            textBoxPrecioKm.Location = new Point(286, 311);
            textBoxPrecioKm.Name = "textBoxPrecioKm";
            textBoxPrecioKm.Size = new Size(100, 23);
            textBoxPrecioKm.TabIndex = 14;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(587, 386);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(86, 40);
            buttonGuardar.TabIndex = 15;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(679, 386);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(94, 40);
            buttonClose.TabIndex = 16;
            buttonClose.Text = "Regresar";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // FormVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClose);
            Controls.Add(buttonGuardar);
            Controls.Add(textBoxPrecioKm);
            Controls.Add(textBoxColor);
            Controls.Add(textBoxModelo);
            Controls.Add(textBoxMarca);
            Controls.Add(textBoxPlaca);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormVehiculos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Vehiculo";
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
        private TextBox textBoxPlaca;
        private TextBox textBoxMarca;
        private TextBox textBoxModelo;
        private TextBox textBoxColor;
        private TextBox textBoxPrecioKm;
        private Button buttonGuardar;
        private Button buttonClose;
    }
}