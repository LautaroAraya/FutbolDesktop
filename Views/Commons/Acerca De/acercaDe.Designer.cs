namespace FutbolDesktop.Views.Commons.Acerca_De
{
    partial class acercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(acercaDe));
            lblInformacion = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Location = new Point(314, 80);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(50, 20);
            lblInformacion.TabIndex = 0;
            lblInformacion.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoISP20_mini_1;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(77, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 199);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // acercaDe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lblInformacion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "acercaDe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acerca De";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInformacion;
        private PictureBox pictureBox1;
    }
}