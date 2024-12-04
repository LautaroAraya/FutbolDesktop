namespace FutbolDesktop.Views.Commons.Ligas
{
    partial class AgregarEditarLigas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEditarLigas));
            CancelarBtn = new FontAwesome.Sharp.IconButton();
            AgregarBtn = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            label2 = new Label();
            SuspendLayout();
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
            CancelarBtn.Location = new Point(475, 301);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(115, 29);
            CancelarBtn.TabIndex = 17;
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
            AgregarBtn.Location = new Point(266, 301);
            AgregarBtn.Name = "AgregarBtn";
            AgregarBtn.Size = new Size(109, 29);
            AgregarBtn.TabIndex = 16;
            AgregarBtn.Text = "Agregar";
            AgregarBtn.UseVisualStyleBackColor = false;
            AgregarBtn.Click += AgregarBtn_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(266, 158);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(324, 27);
            txtNombre.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 165);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 14;
            label2.Text = "Nombre de la Liga:";
            // 
            // AgregarEditarLigas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelarBtn);
            Controls.Add(AgregarBtn);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AgregarEditarLigas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Editar Ligas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton CancelarBtn;
        private FontAwesome.Sharp.IconButton AgregarBtn;
        private TextBox txtNombre;
        private Label label2;
    }
}