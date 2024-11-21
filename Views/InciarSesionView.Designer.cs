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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            txtContraseña.Location = new Point(111, 79);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(335, 27);
            txtContraseña.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(111, 18);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(339, 27);
            txtEmail.TabIndex = 16;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.FlatStyle = FlatStyle.Flat;
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
            btnIngresar.BackColor = Color.SpringGreen;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.User;
            btnIngresar.IconColor = Color.Black;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnIngresar.IconSize = 24;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(67, 178);
            btnIngresar.Margin = new Padding(0);
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
            label2.Location = new Point(19, 86);
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._431030374_969421444925969_1909409229281767033_n;
            pictureBox1.Location = new Point(564, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // InciarSesionView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(726, 228);
            Controls.Add(pictureBox1);
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
            Text = "Iniciar Sesion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}