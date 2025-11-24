namespace Practica
{
    partial class Practica6
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
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.tbBuscarNumero = new System.Windows.Forms.TextBox();
            this.btnBuscarNumero = new System.Windows.Forms.Button();
            this.btnGenerarMatriz = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Location = new System.Drawing.Point(12, 12);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(86, 23);
            this.btnRetroceder.TabIndex = 15;
            this.btnRetroceder.Text = "Retroceder";
            this.btnRetroceder.UseVisualStyleBackColor = true;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Location = new System.Drawing.Point(49, 217);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.RowHeadersWidth = 51;
            this.dgvMatriz.RowTemplate.Height = 24;
            this.dgvMatriz.Size = new System.Drawing.Size(361, 201);
            this.dgvMatriz.TabIndex = 16;
            // 
            // tbBuscarNumero
            // 
            this.tbBuscarNumero.Location = new System.Drawing.Point(49, 181);
            this.tbBuscarNumero.Name = "tbBuscarNumero";
            this.tbBuscarNumero.Size = new System.Drawing.Size(225, 22);
            this.tbBuscarNumero.TabIndex = 17;
            // 
            // btnBuscarNumero
            // 
            this.btnBuscarNumero.Location = new System.Drawing.Point(294, 174);
            this.btnBuscarNumero.Name = "btnBuscarNumero";
            this.btnBuscarNumero.Size = new System.Drawing.Size(90, 37);
            this.btnBuscarNumero.TabIndex = 18;
            this.btnBuscarNumero.Text = "Buscar";
            this.btnBuscarNumero.UseVisualStyleBackColor = true;
            // 
            // btnGenerarMatriz
            // 
            this.btnGenerarMatriz.Location = new System.Drawing.Point(421, 157);
            this.btnGenerarMatriz.Name = "btnGenerarMatriz";
            this.btnGenerarMatriz.Size = new System.Drawing.Size(101, 46);
            this.btnGenerarMatriz.TabIndex = 19;
            this.btnGenerarMatriz.Text = "Generar";
            this.btnGenerarMatriz.UseVisualStyleBackColor = true;
            this.btnGenerarMatriz.Click += new System.EventHandler(this.btnGenerarMatriz_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Location = new System.Drawing.Point(49, 38);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(361, 112);
            this.lblResultado.TabIndex = 20;
            // 
            // Practica6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnGenerarMatriz);
            this.Controls.Add(this.btnBuscarNumero);
            this.Controls.Add(this.tbBuscarNumero);
            this.Controls.Add(this.dgvMatriz);
            this.Controls.Add(this.btnRetroceder);
            this.Name = "Practica6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practica6";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.TextBox tbBuscarNumero;
        private System.Windows.Forms.Button btnBuscarNumero;
        private System.Windows.Forms.Button btnGenerarMatriz;
        private System.Windows.Forms.Label lblResultado;
    }
}