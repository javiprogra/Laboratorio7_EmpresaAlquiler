namespace Laboratorio7_EmpresaAlquiler
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            buttonCliente = new Button();
            buttonVehiculo = new Button();
            buttonAlquiler = new Button();
            buttonReporte = new Button();
            buttonVC = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 22);
            label1.Name = "label1";
            label1.Size = new Size(255, 32);
            label1.TabIndex = 0;
            label1.Text = "Alquiler de Vehiculos";
            // 
            // buttonCliente
            // 
            buttonCliente.Location = new Point(162, 94);
            buttonCliente.Margin = new Padding(3, 2, 3, 2);
            buttonCliente.Name = "buttonCliente";
            buttonCliente.Size = new Size(116, 41);
            buttonCliente.TabIndex = 1;
            buttonCliente.Text = "Ingresar Cliente";
            buttonCliente.UseVisualStyleBackColor = true;
            buttonCliente.Click += buttonCliente_Click;
            // 
            // buttonVehiculo
            // 
            buttonVehiculo.Location = new Point(162, 158);
            buttonVehiculo.Margin = new Padding(3, 2, 3, 2);
            buttonVehiculo.Name = "buttonVehiculo";
            buttonVehiculo.Size = new Size(116, 41);
            buttonVehiculo.TabIndex = 2;
            buttonVehiculo.Text = "Ingresar Vehiculo";
            buttonVehiculo.UseVisualStyleBackColor = true;
            buttonVehiculo.Click += buttonVehiculo_Click;
            // 
            // buttonAlquiler
            // 
            buttonAlquiler.Location = new Point(162, 228);
            buttonAlquiler.Margin = new Padding(3, 2, 3, 2);
            buttonAlquiler.Name = "buttonAlquiler";
            buttonAlquiler.Size = new Size(116, 41);
            buttonAlquiler.TabIndex = 3;
            buttonAlquiler.Text = "Ingresar Alquiler";
            buttonAlquiler.UseVisualStyleBackColor = true;
            buttonAlquiler.Click += buttonAlquiler_Click;
            // 
            // buttonReporte
            // 
            buttonReporte.Location = new Point(400, 94);
            buttonReporte.Margin = new Padding(3, 2, 3, 2);
            buttonReporte.Name = "buttonReporte";
            buttonReporte.Size = new Size(116, 41);
            buttonReporte.TabIndex = 4;
            buttonReporte.Text = "Reportes";
            buttonReporte.UseVisualStyleBackColor = true;
            buttonReporte.Click += buttonReporte_Click;
            // 
            // buttonVC
            // 
            buttonVC.Location = new Point(400, 158);
            buttonVC.Name = "buttonVC";
            buttonVC.Size = new Size(116, 41);
            buttonVC.TabIndex = 5;
            buttonVC.Text = "Vehiculos y Clientes";
            buttonVC.UseVisualStyleBackColor = true;
            buttonVC.Click += buttonVC_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonVC);
            Controls.Add(buttonReporte);
            Controls.Add(buttonAlquiler);
            Controls.Add(buttonVehiculo);
            Controls.Add(buttonCliente);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empresa de alquiler de automoviles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonCliente;
        private Button buttonVehiculo;
        private Button buttonAlquiler;
        private Button buttonReporte;
        private Button buttonVC;
    }
}
