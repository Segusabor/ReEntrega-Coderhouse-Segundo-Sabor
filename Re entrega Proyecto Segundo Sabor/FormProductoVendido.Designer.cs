namespace Re_entrega_Proyecto_Segundo_Sabor
{
    partial class FormProductoVendido
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
            txtBuscarId = new TextBox();
            dgbProductoVendido = new DataGridView();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnBuscarId = new Button();
            btnListar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgbProductoVendido).BeginInit();
            SuspendLayout();
            // 
            // txtBuscarId
            // 
            txtBuscarId.Location = new Point(139, 182);
            txtBuscarId.Name = "txtBuscarId";
            txtBuscarId.Size = new Size(100, 23);
            txtBuscarId.TabIndex = 15;
            // 
            // dgbProductoVendido
            // 
            dgbProductoVendido.AllowUserToAddRows = false;
            dgbProductoVendido.AllowUserToDeleteRows = false;
            dgbProductoVendido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbProductoVendido.Location = new Point(244, 33);
            dgbProductoVendido.Name = "dgbProductoVendido";
            dgbProductoVendido.ReadOnly = true;
            dgbProductoVendido.RowTemplate.Height = 25;
            dgbProductoVendido.Size = new Size(544, 384);
            dgbProductoVendido.TabIndex = 14;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(12, 358);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(121, 59);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar Producto Vendido";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 293);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(121, 59);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar Producto Vendido";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 228);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(121, 59);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar Producto Vendido";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscarId
            // 
            btnBuscarId.Location = new Point(12, 163);
            btnBuscarId.Name = "btnBuscarId";
            btnBuscarId.Size = new Size(121, 59);
            btnBuscarId.TabIndex = 10;
            btnBuscarId.Text = "Buscar Por Id";
            btnBuscarId.UseVisualStyleBackColor = true;
            btnBuscarId.Click += btnBuscarId_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(12, 98);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(121, 59);
            btnListar.TabIndex = 9;
            btnListar.Text = "Listar Producto Vendido";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 33);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(121, 59);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // ProductoVendido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBuscarId);
            Controls.Add(dgbProductoVendido);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscarId);
            Controls.Add(btnListar);
            Controls.Add(btnVolver);
            Name = "ProductoVendido";
            Text = "ProductoVendido";
            Load += ProductoVendido_Load;
            ((System.ComponentModel.ISupportInitialize)dgbProductoVendido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscarId;
        private DataGridView dgbProductoVendido;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Button btnBuscarId;
        private Button btnListar;
        private Button btnVolver;
    }
}