
namespace ClaseSabado_Vista
{
    partial class FrmMenuPrincipal
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
            this.lb_Mensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Mensaje
            // 
            this.lb_Mensaje.AutoSize = true;
            this.lb_Mensaje.Location = new System.Drawing.Point(362, 180);
            this.lb_Mensaje.Name = "lb_Mensaje";
            this.lb_Mensaje.Size = new System.Drawing.Size(200, 200);
            this.lb_Mensaje.TabIndex = 0;
            this.lb_Mensaje.Text = "label1";
            this.lb_Mensaje.Click += new System.EventHandler(this.lb_Mensaje_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Mensaje);
            this.Name = "FrmMenuPrincipal";
            this.Text = "FrmMenuPrincipal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Mensaje;
    }
}