namespace Re_entrega_Proyecto_Segundo_Sabor
{
    partial class FrmInicio
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
            btnUsuario = new Button();
            btnProducto = new Button();
            btnProductoVendido = new Button();
            btnVenta = new Button();
            SuspendLayout();
            // 
            // btnUsuario
            // 
            btnUsuario.Location = new Point(302, 134);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(185, 49);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "Usuarios";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnProducto
            // 
            btnProducto.Location = new Point(302, 189);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(185, 49);
            btnProducto.TabIndex = 1;
            btnProducto.Text = "Productos";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnProductoVendido
            // 
            btnProductoVendido.Location = new Point(302, 244);
            btnProductoVendido.Name = "btnProductoVendido";
            btnProductoVendido.Size = new Size(185, 49);
            btnProductoVendido.TabIndex = 2;
            btnProductoVendido.Text = "Productos Vendidos";
            btnProductoVendido.UseVisualStyleBackColor = true;
            btnProductoVendido.Click += btnProductoVendido_Click;
            // 
            // btnVenta
            // 
            btnVenta.Location = new Point(302, 299);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(185, 49);
            btnVenta.TabIndex = 3;
            btnVenta.Text = "Ventas";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVenta);
            Controls.Add(btnProductoVendido);
            Controls.Add(btnProducto);
            Controls.Add(btnUsuario);
            Name = "FrmInicio";
            Text = "Form1";
         
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuario;
        private Button btnProducto;
        private Button btnProductoVendido;
        private Button btnVenta;
    }
}
