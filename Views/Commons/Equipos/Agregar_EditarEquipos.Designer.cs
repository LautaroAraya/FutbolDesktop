namespace FutbolDesktop.Views.Commons.Equipos
{
    partial class Agregar_EditarEquipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_EditarEquipos));
            label3 = new Label();
            cmbEntrenadores = new ComboBox();
            CancelarBtn = new FontAwesome.Sharp.IconButton();
            AgregarBtn = new FontAwesome.Sharp.IconButton();
            txtEstadio = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            agregarEntrenadorbtn = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 247);
            label3.Name = "label3";
            label3.Size = new Size(169, 20);
            label3.TabIndex = 23;
            label3.Text = "Nombre del Entrenador:";
            // 
            // cmbEntrenadores
            // 
            cmbEntrenadores.FormattingEnabled = true;
            cmbEntrenadores.Location = new Point(243, 244);
            cmbEntrenadores.Name = "cmbEntrenadores";
            cmbEntrenadores.Size = new Size(324, 28);
            cmbEntrenadores.TabIndex = 22;
            // 
            // CancelarBtn
            // 
            CancelarBtn.BackColor = Color.LightCoral;
            CancelarBtn.FlatStyle = FlatStyle.Flat;
            CancelarBtn.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            CancelarBtn.IconColor = Color.Black;
            CancelarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CancelarBtn.IconSize = 25;
            CancelarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CancelarBtn.Location = new Point(500, 337);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(115, 29);
            CancelarBtn.TabIndex = 21;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.TextAlign = ContentAlignment.MiddleRight;
            CancelarBtn.UseVisualStyleBackColor = false;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // AgregarBtn
            // 
            AgregarBtn.BackColor = Color.SpringGreen;
            AgregarBtn.FlatStyle = FlatStyle.Flat;
            AgregarBtn.IconChar = FontAwesome.Sharp.IconChar.File;
            AgregarBtn.IconColor = Color.Black;
            AgregarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AgregarBtn.IconSize = 18;
            AgregarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AgregarBtn.Location = new Point(291, 337);
            AgregarBtn.Name = "AgregarBtn";
            AgregarBtn.Size = new Size(109, 29);
            AgregarBtn.TabIndex = 20;
            AgregarBtn.Text = "Agregar";
            AgregarBtn.UseVisualStyleBackColor = false;
            AgregarBtn.Click += AgregarBtn_Click;
            // 
            // txtEstadio
            // 
            txtEstadio.Location = new Point(291, 161);
            txtEstadio.Name = "txtEstadio";
            txtEstadio.Size = new Size(324, 27);
            txtEstadio.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 168);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 18;
            label2.Text = "Nombre del Estadio:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(291, 103);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(324, 27);
            txtNombre.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 106);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 16;
            label1.Text = "Nombre del Equipo:";
            // 
            // agregarEntrenadorbtn
            // 
            agregarEntrenadorbtn.BackColor = SystemColors.ButtonHighlight;
            agregarEntrenadorbtn.FlatStyle = FlatStyle.Flat;
            agregarEntrenadorbtn.IconChar = FontAwesome.Sharp.IconChar.User;
            agregarEntrenadorbtn.IconColor = Color.Black;
            agregarEntrenadorbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            agregarEntrenadorbtn.IconSize = 18;
            agregarEntrenadorbtn.ImageAlign = ContentAlignment.MiddleLeft;
            agregarEntrenadorbtn.Location = new Point(595, 247);
            agregarEntrenadorbtn.Name = "agregarEntrenadorbtn";
            agregarEntrenadorbtn.Size = new Size(193, 29);
            agregarEntrenadorbtn.TabIndex = 24;
            agregarEntrenadorbtn.Text = "Agregar Entrenador";
            agregarEntrenadorbtn.UseVisualStyleBackColor = false;
            agregarEntrenadorbtn.Click += agregarEntrenadorbtn_Click;
            // 
            // Agregar_EditarEquipos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(agregarEntrenadorbtn);
            Controls.Add(label3);
            Controls.Add(cmbEntrenadores);
            Controls.Add(CancelarBtn);
            Controls.Add(AgregarBtn);
            Controls.Add(txtEstadio);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Agregar_EditarEquipos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar EditarEquipos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox cmbEntrenadores;
        private FontAwesome.Sharp.IconButton CancelarBtn;
        private FontAwesome.Sharp.IconButton AgregarBtn;
        private TextBox txtEstadio;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private FontAwesome.Sharp.IconButton agregarEntrenadorbtn;
    }
}