namespace Re_entrega_Proyecto_Segundo_Sabor
{
    partial class FrmUsuario
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
            btnVolver = new Button();
            btnListar = new Button();
            btnBuscarId = new Button();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            dgbUsuario = new DataGridView();
            txtBuscarId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgbUsuario).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 43);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(121, 59);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(12, 108);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(121, 59);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar Usuarios";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnBuscarId
            // 
            btnBuscarId.Location = new Point(12, 173);
            btnBuscarId.Name = "btnBuscarId";
            btnBuscarId.Size = new Size(121, 59);
            btnBuscarId.TabIndex = 2;
            btnBuscarId.Text = "Buscar Por Id";
            btnBuscarId.UseVisualStyleBackColor = true;
            btnBuscarId.Click += btnBuscarId_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 238);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(121, 59);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar Usuario";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 303);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(121, 59);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar Usuario";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(12, 368);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(121, 59);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar Usuario";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dgbUsuario
            // 
            dgbUsuario.AllowUserToAddRows = false;
            dgbUsuario.AllowUserToDeleteRows = false;
            dgbUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbUsuario.Location = new Point(244, 43);
            dgbUsuario.Name = "dgbUsuario";
            dgbUsuario.ReadOnly = true;
            dgbUsuario.RowTemplate.Height = 25;
            dgbUsuario.Size = new Size(544, 384);
            dgbUsuario.TabIndex = 6;
            // 
            // txtBuscarId
            // 
            txtBuscarId.Location = new Point(139, 192);
            txtBuscarId.Name = "txtBuscarId";
            txtBuscarId.Size = new Size(100, 23);
            txtBuscarId.TabIndex = 7;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBuscarId);
            Controls.Add(dgbUsuario);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscarId);
            Controls.Add(btnListar);
            Controls.Add(btnVolver);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgbUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Button btnListar;
        private Button btnBuscarId;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnActualizar;
        private DataGridView dgbUsuario;
        private TextBox txtBuscarId;
    }
}