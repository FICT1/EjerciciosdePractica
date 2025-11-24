namespace Practica
{
    partial class Practica2
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
            this.tbBuscarBinario = new System.Windows.Forms.TextBox();
            this.btnBuscarBinario = new System.Windows.Forms.Button();
            this.lblProceso = new System.Windows.Forms.Label();
            this.btnCrearLista = new System.Windows.Forms.Button();
            this.lblListaOrdenada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbBuscarBinario
            // 
            this.tbBuscarBinario.Location = new System.Drawing.Point(67, 261);
            this.tbBuscarBinario.Name = "tbBuscarBinario";
            this.tbBuscarBinario.Size = new System.Drawing.Size(186, 22);
            this.tbBuscarBinario.TabIndex = 2;
            // 
            // btnBuscarBinario
            // 
            this.btnBuscarBinario.Location = new System.Drawing.Point(280, 236);
            this.btnBuscarBinario.Name = "btnBuscarBinario";
            this.btnBuscarBinario.Size = new System.Drawing.Size(93, 48);
            this.btnBuscarBinario.TabIndex = 3;
            this.btnBuscarBinario.Text = "Buscar";
            this.btnBuscarBinario.UseVisualStyleBackColor = true;
            this.btnBuscarBinario.Click += new System.EventHandler(this.btnBuscarBinario_Click);
            // 
            // lblProceso
            // 
            this.lblProceso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProceso.Location = new System.Drawing.Point(32, 18);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(319, 107);
            this.lblProceso.TabIndex = 5;
            // 
            // btnCrearLista
            // 
            this.btnCrearLista.Location = new System.Drawing.Point(375, 67);
            this.btnCrearLista.Name = "btnCrearLista";
            this.btnCrearLista.Size = new System.Drawing.Size(93, 48);
            this.btnCrearLista.TabIndex = 6;
            this.btnCrearLista.Text = "Crear";
            this.btnCrearLista.UseVisualStyleBackColor = true;
            this.btnCrearLista.Click += new System.EventHandler(this.btnCrearLista_Click);
            // 
            // lblListaOrdenada
            // 
            this.lblListaOrdenada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblListaOrdenada.Location = new System.Drawing.Point(32, 296);
            this.lblListaOrdenada.Name = "lblListaOrdenada";
            this.lblListaOrdenada.Size = new System.Drawing.Size(293, 104);
            this.lblListaOrdenada.TabIndex = 7;
            this.lblListaOrdenada.Click += new System.EventHandler(this.lblListaOrdenada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Buscar binario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Crear binario";
            // 
            // Practica2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblListaOrdenada);
            this.Controls.Add(this.btnCrearLista);
            this.Controls.Add(this.lblProceso);
            this.Controls.Add(this.btnBuscarBinario);
            this.Controls.Add(this.tbBuscarBinario);
            this.Name = "Practica2";
            this.Text = "Practica2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbBuscarBinario;
        private System.Windows.Forms.Button btnBuscarBinario;
        private System.Windows.Forms.Label lblProceso;
        private System.Windows.Forms.Button btnCrearLista;
        private System.Windows.Forms.Label lblListaOrdenada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}