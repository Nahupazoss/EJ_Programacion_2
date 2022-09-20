
namespace Practicando_Ejercicio
{
    partial class Form1
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
            this.btn_AgregarGerente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AgregarGerente
            // 
            this.btn_AgregarGerente.Location = new System.Drawing.Point(12, 23);
            this.btn_AgregarGerente.Name = "btn_AgregarGerente";
            this.btn_AgregarGerente.Size = new System.Drawing.Size(211, 57);
            this.btn_AgregarGerente.TabIndex = 0;
            this.btn_AgregarGerente.Text = "Agregar Gerente";
            this.btn_AgregarGerente.UseVisualStyleBackColor = true;
            this.btn_AgregarGerente.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 326);
            this.Controls.Add(this.btn_AgregarGerente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AgregarGerente;
    }
}

