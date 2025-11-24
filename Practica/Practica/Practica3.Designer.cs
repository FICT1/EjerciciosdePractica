namespace Practica
{
    partial class Practica3
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
            this.tbPalabra = new System.Windows.Forms.TextBox();
            this.tbParrafo = new System.Windows.Forms.MaskedTextBox();
            this.ASD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarTexto = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPalabra
            // 
            this.tbPalabra.Location = new System.Drawing.Point(67, 88);
            this.tbPalabra.Name = "tbPalabra";
            this.tbPalabra.Size = new System.Drawing.Size(146, 22);
            this.tbPalabra.TabIndex = 0;
            this.tbPalabra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbParrafo
            // 
            this.tbParrafo.Location = new System.Drawing.Point(67, 177);
            this.tbParrafo.Name = "tbParrafo";
            this.tbParrafo.Size = new System.Drawing.Size(362, 22);
            this.tbParrafo.TabIndex = 1;
            this.tbParrafo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // ASD
            // 
            this.ASD.AutoSize = true;
            this.ASD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ASD.Location = new System.Drawing.Point(64, 59);
            this.ASD.Name = "ASD";
            this.ASD.Size = new System.Drawing.Size(176, 25);
            this.ASD.TabIndex = 2;
            this.ASD.Text = "Ingresar palabra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresar parrafo: ";
            // 
            // btnBuscarTexto
            // 
            this.btnBuscarTexto.Location = new System.Drawing.Point(255, 67);
            this.btnBuscarTexto.Name = "btnBuscarTexto";
            this.btnBuscarTexto.Size = new System.Drawing.Size(112, 64);
            this.btnBuscarTexto.TabIndex = 7;
            this.btnBuscarTexto.Text = "Buscar";
            this.btnBuscarTexto.UseVisualStyleBackColor = true;
            this.btnBuscarTexto.Click += new System.EventHandler(this.btnBuscarTexto_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Location = new System.Drawing.Point(67, 246);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(319, 121);
            this.lblResultado.TabIndex = 8;
            // 
            // Practica3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnBuscarTexto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ASD);
            this.Controls.Add(this.tbParrafo);
            this.Controls.Add(this.tbPalabra);
            this.Name = "Practica3";
            this.Text = "Practica3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPalabra;
        private System.Windows.Forms.MaskedTextBox tbParrafo;
        private System.Windows.Forms.Label ASD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarTexto;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblResultado;
    }
}