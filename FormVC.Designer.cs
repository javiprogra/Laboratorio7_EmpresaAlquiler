namespace Laboratorio7_EmpresaAlquiler
{
    partial class FormVC
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
            dataGridViewVehiculos = new DataGridView();
            dataGridViewClientes = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            buttonClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 31);
            label1.Name = "label1";
            label1.Size = new Size(239, 32);
            label1.TabIndex = 7;
            label1.Text = "Vehiculos y Clientes";
            // 
            // dataGridViewVehiculos
            // 
            dataGridViewVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVehiculos.Location = new Point(66, 135);
            dataGridViewVehiculos.Name = "dataGridViewVehiculos";
            dataGridViewVehiculos.Size = new Size(316, 209);
            dataGridViewVehiculos.TabIndex = 8;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(424, 135);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.Size = new Size(316, 209);
            dataGridViewClientes.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 117);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 10;
            label2.Text = "Vehiculos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(563, 117);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 11;
            label3.Text = "Clientes";
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(646, 381);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(94, 40);
            buttonClose.TabIndex = 12;
            buttonClose.Text = "Regresar";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // FormVC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClose);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridViewClientes);
            Controls.Add(dataGridViewVehiculos);
            Controls.Add(label1);
            Name = "FormVC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVC";
            Load += FormVC_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewVehiculos;
        private DataGridView dataGridViewClientes;
        private Label label2;
        private Label label3;
        private Button buttonClose;
    }
}