namespace Re_entrega_Proyecto_Segundo_Sabor
{
    partial class FrmProducto
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
            dgbProducto = new DataGridView();
            btnVolver = new Button();
            btnListar = new Button();
            btnBuscarId = new Button();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            txtBuscarId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgbProducto).BeginInit();
            SuspendLayout();
            // 
            // dgbProducto
            // 
            dgbProducto.AllowUserToAddRows = false;
            dgbProducto.AllowUserToDeleteRows = false;
            dgbProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbProducto.Location = new Point(245, 54);
            dgbProducto.Name = "dgbProducto";
            dgbProducto.ReadOnly = true;
            dgbProducto.RowTemplate.Height = 25;
            dgbProducto.Size = new Size(543, 384);
            dgbProducto.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(10, 54);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(121, 59);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(10, 119);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(121, 59);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar Producto";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnBuscarId
            // 
            btnBuscarId.Location = new Point(12, 184);
            btnBuscarId.Name = "btnBuscarId";
            btnBuscarId.Size = new Size(121, 59);
            btnBuscarId.TabIndex = 3;
            btnBuscarId.Text = "Buscar Por Id";
            btnBuscarId.UseVisualStyleBackColor = true;
            btnBuscarId.Click += btnBuscarId_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(10, 249);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(121, 59);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar Producto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(10, 314);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(121, 59);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(10, 379);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(121, 59);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar Producto";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtBuscarId
            // 
            txtBuscarId.Location = new Point(139, 203);
            txtBuscarId.Name = "txtBuscarId";
            txtBuscarId.Size = new Size(100, 23);
            txtBuscarId.TabIndex = 8;
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBuscarId);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscarId);
            Controls.Add(btnListar);
            Controls.Add(btnVolver);
            Controls.Add(dgbProducto);
            Name = "FrmProducto";
            Text = "FrmProducto";
            ((System.ComponentModel.ISupportInitialize)dgbProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgbProducto;
        private Button btnVolver;
        private Button btnListar;
        private Button btnBuscarId;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnActualizar;
        private TextBox txtBuscarId;
    }
}