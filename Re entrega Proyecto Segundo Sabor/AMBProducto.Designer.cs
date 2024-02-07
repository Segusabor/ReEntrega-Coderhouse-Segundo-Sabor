namespace Re_entrega_Proyecto_Segundo_Sabor
{
    partial class AMBProducto
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
            btnAceptar = new Button();
            txtDescripciones = new TextBox();
            txtCosto = new TextBox();
            txtPrecioVenta = new TextBox();
            txtStock = new TextBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(85, 261);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(151, 47);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtDescripciones
            // 
            txtDescripciones.Location = new Point(73, 77);
            txtDescripciones.Name = "txtDescripciones";
            txtDescripciones.PlaceholderText = "Descripciones";
            txtDescripciones.Size = new Size(100, 23);
            txtDescripciones.TabIndex = 1;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(73, 106);
            txtCosto.Name = "txtCosto";
            txtCosto.PlaceholderText = "Costo";
            txtCosto.Size = new Size(100, 23);
            txtCosto.TabIndex = 2;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(73, 135);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.PlaceholderText = "Precio Venta";
            txtPrecioVenta.Size = new Size(100, 23);
            txtPrecioVenta.TabIndex = 3;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(73, 164);
            txtStock.Name = "txtStock";
            txtStock.PlaceholderText = "Stock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 4;
            // 
            // AMBProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 450);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtCosto);
            Controls.Add(txtDescripciones);
            Controls.Add(btnAceptar);
            Name = "AMBProducto";
            Text = "AMBProducto";
            Load += AMBProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private TextBox txtDescripciones;
        private TextBox txtCosto;
        private TextBox txtPrecioVenta;
        private TextBox txtStock;
    }
}