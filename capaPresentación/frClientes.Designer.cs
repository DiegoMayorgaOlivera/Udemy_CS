namespace capaPresentación
{
    partial class frmClientes
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lnkFoto = new LinkLabel();
            txtId = new NumericUpDown();
            picFoto = new PictureBox();
            ofdFoto = new OpenFileDialog();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            gridDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)txtId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 50);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 95);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 146);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 0;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 194);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 0;
            label4.Text = "Foto";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(159, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(152, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(159, 143);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(152, 23);
            txtApellido.TabIndex = 2;
            // 
            // lnkFoto
            // 
            lnkFoto.AutoSize = true;
            lnkFoto.Location = new Point(41, 248);
            lnkFoto.Name = "lnkFoto";
            lnkFoto.Size = new Size(67, 15);
            lnkFoto.TabIndex = 3;
            lnkFoto.TabStop = true;
            lnkFoto.Text = "Seleccionar";
            lnkFoto.LinkClicked += lnkFoto_LinkClicked;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(159, 48);
            txtId.Name = "txtId";
            txtId.Size = new Size(152, 23);
            txtId.TabIndex = 3;
            // 
            // picFoto
            // 
            picFoto.BackColor = SystemColors.ButtonShadow;
            picFoto.Location = new Point(159, 194);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(152, 135);
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            picFoto.TabIndex = 4;
            picFoto.TabStop = false;
            // 
            // ofdFoto
            // 
            ofdFoto.FileName = "openFileDialog1";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(41, 353);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(158, 353);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(239, 353);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // gridDatos
            // 
            gridDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDatos.Location = new Point(348, 48);
            gridDatos.Name = "gridDatos";
            gridDatos.Size = new Size(451, 281);
            gridDatos.TabIndex = 6;
            gridDatos.CellDoubleClick += gridDatos_CellDoubleClick;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 450);
            Controls.Add(gridDatos);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(picFoto);
            Controls.Add(txtId);
            Controls.Add(lnkFoto);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmClientes";
            Text = "Clientes";
            Load += frmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)txtId).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private LinkLabel lnkFoto;
        private NumericUpDown txtId;
        private PictureBox picFoto;
        private OpenFileDialog ofdFoto;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnGuardar;
        private DataGridView gridDatos;
    }
}
