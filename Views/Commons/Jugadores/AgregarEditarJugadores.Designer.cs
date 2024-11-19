namespace FutbolDesktop.Views.Commons.Jugadores
{
    partial class AgregarEditarJugadores
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
            CancelarBtn = new FontAwesome.Sharp.IconButton();
            AgregarBtn = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNombreEquipo = new TextBox();
            label3 = new Label();
            txtPosicion = new TextBox();
            SuspendLayout();
            // 
            // CancelarBtn
            // 
            CancelarBtn.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            CancelarBtn.IconColor = Color.Black;
            CancelarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CancelarBtn.IconSize = 25;
            CancelarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CancelarBtn.Location = new Point(466, 330);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(115, 29);
            CancelarBtn.TabIndex = 13;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.TextAlign = ContentAlignment.MiddleRight;
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // AgregarBtn
            // 
            AgregarBtn.IconChar = FontAwesome.Sharp.IconChar.File;
            AgregarBtn.IconColor = Color.Black;
            AgregarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AgregarBtn.IconSize = 18;
            AgregarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AgregarBtn.Location = new Point(257, 330);
            AgregarBtn.Name = "AgregarBtn";
            AgregarBtn.Size = new Size(109, 29);
            AgregarBtn.TabIndex = 12;
            AgregarBtn.Text = "Agregar";
            AgregarBtn.UseVisualStyleBackColor = true;
            AgregarBtn.Click += AgregarBtn_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(257, 96);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(324, 27);
            txtNombre.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 99);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 8;
            label1.Text = "Nombre del Jugador:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 250);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 10;
            label2.Text = "Nombre del Equipo:";
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Location = new Point(257, 243);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.Size = new Size(324, 27);
            txtNombreEquipo.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 175);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 14;
            label3.Text = "Posición:";
            // 
            // txtPosicion
            // 
            txtPosicion.Location = new Point(257, 168);
            txtPosicion.Name = "txtPosicion";
            txtPosicion.Size = new Size(324, 27);
            txtPosicion.TabIndex = 15;
            // 
            // AgregarEditarJugadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPosicion);
            Controls.Add(label3);
            Controls.Add(CancelarBtn);
            Controls.Add(AgregarBtn);
            Controls.Add(txtNombreEquipo);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "AgregarEditarJugadores";
            Text = "Agregar/Editar Jugadores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton CancelarBtn;
        private FontAwesome.Sharp.IconButton AgregarBtn;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtNombreEquipo;
        private Label label3;
        private TextBox txtPosicion;
    }
}