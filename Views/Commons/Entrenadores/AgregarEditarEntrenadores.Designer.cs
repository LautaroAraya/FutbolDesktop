namespace FutbolDesktop.Views.Commons.Entrenadores
{
    partial class AgregarEditarEntrenadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEditarEntrenadores));
            label1 = new Label();
            txtNombre = new TextBox();
            CancelarBtn = new FontAwesome.Sharp.IconButton();
            AgregarBtn = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 181);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre del entrenador:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(272, 178);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(324, 27);
            txtNombre.TabIndex = 1;
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
            CancelarBtn.Location = new Point(481, 300);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(115, 29);
            CancelarBtn.TabIndex = 7;
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
            AgregarBtn.Location = new Point(232, 300);
            AgregarBtn.Name = "AgregarBtn";
            AgregarBtn.Size = new Size(109, 29);
            AgregarBtn.TabIndex = 6;
            AgregarBtn.Text = "Agregar";
            AgregarBtn.UseVisualStyleBackColor = false;
            AgregarBtn.Click += AgregarBtn_Click;
            // 
            // AgregarEditarEntrenadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelarBtn);
            Controls.Add(AgregarBtn);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AgregarEditarEntrenadores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar/Editar Entrenadores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private FontAwesome.Sharp.IconButton CancelarBtn;
        private FontAwesome.Sharp.IconButton AgregarBtn;
    }
}