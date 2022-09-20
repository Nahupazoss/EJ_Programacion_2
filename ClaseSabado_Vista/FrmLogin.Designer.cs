
namespace ClaseSabado_Vista
{
    partial class FrmLogin
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
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_Aceptar_Click = new System.Windows.Forms.Button();
            this.lbl_Mensaje_Error = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_RegistrarUsuario_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(227, 94);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.PlaceholderText = "Ingrese Usuario";
            this.txt_usuario.Size = new System.Drawing.Size(306, 23);
            this.txt_usuario.TabIndex = 0;
            this.txt_usuario.TextChanged += new System.EventHandler(this.txt_usuario_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(227, 178);
            this.txt_password.Name = "txt_password";
            this.txt_password.PlaceholderText = "Ingrese Password";
            this.txt_password.Size = new System.Drawing.Size(306, 23);
            this.txt_password.TabIndex = 1;
            this.txt_password.Tag = "";
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // btn_Aceptar_Click
            // 
            this.btn_Aceptar_Click.Location = new System.Drawing.Point(227, 285);
            this.btn_Aceptar_Click.Name = "btn_Aceptar_Click";
            this.btn_Aceptar_Click.Size = new System.Drawing.Size(136, 64);
            this.btn_Aceptar_Click.TabIndex = 2;
            this.btn_Aceptar_Click.Tag = "";
            this.btn_Aceptar_Click.Text = "ACEPTAR";
            this.btn_Aceptar_Click.UseVisualStyleBackColor = true;
            this.btn_Aceptar_Click.Click += new System.EventHandler(this.btn_Aceptar_Click_Click);
            // 
            // lbl_Mensaje_Error
            // 
            this.lbl_Mensaje_Error.AutoSize = true;
            this.lbl_Mensaje_Error.Location = new System.Drawing.Point(40, 250);
            this.lbl_Mensaje_Error.Name = "lbl_Mensaje_Error";
            this.lbl_Mensaje_Error.Size = new System.Drawing.Size(58, 15);
            this.lbl_Mensaje_Error.TabIndex = 3;
            this.lbl_Mensaje_Error.Text = "MENSAJE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_RegistrarUsuario_Click
            // 
            this.btn_RegistrarUsuario_Click.Location = new System.Drawing.Point(399, 285);
            this.btn_RegistrarUsuario_Click.Name = "btn_RegistrarUsuario_Click";
            this.btn_RegistrarUsuario_Click.Size = new System.Drawing.Size(134, 64);
            this.btn_RegistrarUsuario_Click.TabIndex = 5;
            this.btn_RegistrarUsuario_Click.Text = "REGISTRARSE";
            this.btn_RegistrarUsuario_Click.UseVisualStyleBackColor = true;
            this.btn_RegistrarUsuario_Click.Click += new System.EventHandler(this.btn_RegistrarUsuario_Click_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 382);
            this.Controls.Add(this.btn_RegistrarUsuario_Click);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Mensaje_Error);
            this.Controls.Add(this.btn_Aceptar_Click);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_usuario);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_Aceptar_Click;
        private System.Windows.Forms.Label lbl_Mensaje_Error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_RegistrarUsuario_Click;
    }
}