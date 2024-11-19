namespace FutbolDesktop.Views
{
    partial class InciarSesionView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InciarSesionView));
            checkContra = new CheckBox();
            txtContraseña = new TextBox();
            txtEmail = new TextBox();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // checkContra
            // 
            checkContra.AutoSize = true;
            checkContra.Location = new Point(222, 132);
            checkContra.Name = "checkContra";
            checkContra.Size = new Size(128, 24);
            checkContra.TabIndex = 18;
            checkContra.Text = "Ver contraseña";
            checkContra.UseVisualStyleBackColor = true;
            checkContra.CheckedChanged += checkContra_CheckedChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(164, 79);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(335, 27);
            txtContraseña.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(164, 18);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(339, 27);
            txtEmail.TabIndex = 16;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.CircleRight;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnCancelar.IconSize = 24;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(328, 178);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 40);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(128, 255, 128);
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.User;
            btnIngresar.IconColor = Color.Black;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnIngresar.IconSize = 24;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(67, 178);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(150, 40);
            btnIngresar.TabIndex = 14;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 86);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 13;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 12;
            label1.Text = "Email:";
            // 
            // InciarSesionView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 228);
            Controls.Add(checkContra);
            Controls.Add(txtContraseña);
            Controls.Add(txtEmail);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InciarSesionView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inciar Sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkContra;
        private TextBox txtContraseña;
        private TextBox txtEmail;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private Label label2;
        private Label label1;
    }
}