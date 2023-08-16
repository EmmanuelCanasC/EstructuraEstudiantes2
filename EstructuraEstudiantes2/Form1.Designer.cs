namespace EstructuraEstudiantes2
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
            btnAgregar = new Button();
            listBoxEstudiantes = new ListBox();
            btnVerDetalles = new Button();
            btnClean = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtNota3 = new TextBox();
            label5 = new Label();
            txtNota2 = new TextBox();
            txtNota1 = new TextBox();
            txtCorreo = new TextBox();
            label1 = new Label();
            label6 = new Label();
            lblNombre = new Label();
            txtNotaDefinitiva = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(79, 409);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agg";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // listBoxEstudiantes
            // 
            listBoxEstudiantes.FormattingEnabled = true;
            listBoxEstudiantes.ItemHeight = 15;
            listBoxEstudiantes.Location = new Point(489, 33);
            listBoxEstudiantes.Name = "listBoxEstudiantes";
            listBoxEstudiantes.Size = new Size(229, 109);
            listBoxEstudiantes.TabIndex = 15;
            // 
            // btnVerDetalles
            // 
            btnVerDetalles.Location = new Point(204, 409);
            btnVerDetalles.Name = "btnVerDetalles";
            btnVerDetalles.Size = new Size(75, 23);
            btnVerDetalles.TabIndex = 16;
            btnVerDetalles.Text = "Datos";
            btnVerDetalles.UseVisualStyleBackColor = true;
            btnVerDetalles.Click += btnVerDetalles_Click_1;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(347, 409);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(75, 23);
            btnClean.TabIndex = 19;
            btnClean.Text = "Limpiar";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 197);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 10;
            label3.Text = "Nota 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 147);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 9;
            label2.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 255);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 11;
            label4.Text = "Nota 2";
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(171, 302);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(165, 23);
            txtNota3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 310);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 12;
            label5.Text = "Nota 3";
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(171, 247);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(165, 23);
            txtNota2.TabIndex = 6;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(171, 194);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(165, 23);
            txtNota1.TabIndex = 5;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(171, 144);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(165, 23);
            txtCorreo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 91);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 353);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 17;
            label6.Text = "Definitiva:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(75, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNotaDefinitiva
            // 
            txtNotaDefinitiva.Location = new Point(171, 350);
            txtNotaDefinitiva.Name = "txtNotaDefinitiva";
            txtNotaDefinitiva.ReadOnly = true;
            txtNotaDefinitiva.Size = new Size(165, 23);
            txtNotaDefinitiva.TabIndex = 18;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(171, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(165, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(171, 88);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(165, 23);
            txtApellido.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 459);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnClean);
            Controls.Add(txtNotaDefinitiva);
            Controls.Add(listBoxEstudiantes);
            Controls.Add(lblNombre);
            Controls.Add(btnAgregar);
            Controls.Add(label6);
            Controls.Add(btnVerDetalles);
            Controls.Add(label1);
            Controls.Add(txtNota2);
            Controls.Add(txtCorreo);
            Controls.Add(label3);
            Controls.Add(txtNota1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtNota3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAgregar;
        private ListBox listBoxEstudiantes;
        private Button btnVerDetalles;
        private Button btnClean;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtNota3;
        private Label label5;
        private TextBox txtNota2;
        private TextBox txtNota1;
        private TextBox txtCorreo;
        private Label label1;
        private Label label6;
        private Label lblNombre;
        private TextBox txtNotaDefinitiva;
        private TextBox txtNombre;
        private TextBox txtApellido;
    }
}