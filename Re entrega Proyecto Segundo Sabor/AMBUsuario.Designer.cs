namespace Re_entrega_Proyecto_Segundo_Sabor
{
    partial class AMBUsuario
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtContraseña = new TextBox();
            txtNombreUsuario = new TextBox();
            txtMail = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(30, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(30, 94);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(30, 123);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PlaceholderText = "Contraseña";
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 2;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(30, 152);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.PlaceholderText = "Nombre Usuario";
            txtNombreUsuario.Size = new Size(100, 23);
            txtNombreUsuario.TabIndex = 3;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(30, 181);
            txtMail.Name = "txtMail";
            txtMail.PlaceholderText = "Mail";
            txtMail.Size = new Size(100, 23);
            txtMail.TabIndex = 4;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(30, 219);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(172, 48);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // AMBUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 373);
            Controls.Add(btnAceptar);
            Controls.Add(txtMail);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "AMBUsuario";
            Text = "te";
            Load += AMBUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtContraseña;
        private TextBox txtNombreUsuario;
        private TextBox txtMail;
        private Button btnAceptar;
    }
}