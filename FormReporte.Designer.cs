namespace Laboratorio7_EmpresaAlquiler
{
    partial class FormReporte
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
            dataGridViewReporte = new DataGridView();
            buttonClose = new Button();
            label2 = new Label();
            labelKm = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReporte).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(326, 38);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 6;
            label1.Text = "Alquileres";
            // 
            // dataGridViewReporte
            // 
            dataGridViewReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReporte.Location = new Point(110, 93);
            dataGridViewReporte.Name = "dataGridViewReporte";
            dataGridViewReporte.Size = new Size(544, 241);
            dataGridViewReporte.TabIndex = 7;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(670, 383);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(94, 40);
            buttonClose.TabIndex = 13;
            buttonClose.Text = "Regresar";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 337);
            label2.Name = "label2";
            label2.Size = new Size(224, 15);
            label2.TabIndex = 14;
            label2.Text = "Mayor cantidad de kilometros recorridos:";
            // 
            // labelKm
            // 
            labelKm.AutoSize = true;
            labelKm.Location = new Point(394, 337);
            labelKm.Name = "labelKm";
            labelKm.Size = new Size(38, 15);
            labelKm.TabIndex = 15;
            labelKm.Text = "label3";
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelKm);
            Controls.Add(label2);
            Controls.Add(buttonClose);
            Controls.Add(dataGridViewReporte);
            Controls.Add(label1);
            Name = "FormReporte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormReporte";
            Load += FormReporte_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewReporte;
        private Button buttonClose;
        private Label label2;
        private Label labelKm;
    }
}