namespace Laboratorio7_EmpresaAlquiler
{
    partial class FormClientes
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
            textBoxNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            maskedTextBoxNit = new MaskedTextBox();
            textBoxDireccion = new TextBox();
            buttonGuardar = new Button();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(291, 112);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(100, 23);
            textBoxNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(291, 38);
            label1.Name = "label1";
            label1.Size = new Size(195, 32);
            label1.TabIndex = 3;
            label1.Text = "Ingresar Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 115);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 172);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 5;
            label3.Text = "NIT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(225, 230);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 6;
            label4.Text = "Dirección:";
            // 
            // maskedTextBoxNit
            // 
            maskedTextBoxNit.Location = new Point(291, 169);
            maskedTextBoxNit.Mask = "9999999999999";
            maskedTextBoxNit.Name = "maskedTextBoxNit";
            maskedTextBoxNit.Size = new Size(100, 23);
            maskedTextBoxNit.TabIndex = 8;
            maskedTextBoxNit.ValidatingType = typeof(int);
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(291, 230);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(100, 23);
            textBoxDireccion.TabIndex = 9;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(411, 230);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(85, 45);
            buttonGuardar.TabIndex = 10;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGuardar);
            Controls.Add(textBoxDireccion);
            Controls.Add(maskedTextBoxNit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNombre);
            Name = "FormClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox maskedTextBoxNit;
        private TextBox textBoxDireccion;
        private Button buttonGuardar;
    }
}