namespace FutbolDesktop.Views.Commons.Partidos
{
    partial class AgregarEditarPartidos
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
            label3 = new Label();
            CancelarBtn = new FontAwesome.Sharp.IconButton();
            AgregarBtn = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label1 = new Label();
            cmbLocal = new ComboBox();
            cmbVisitante = new ComboBox();
            dateTimeFecha = new DateTimePicker();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 184);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 22;
            label3.Text = "Equipo Visitante:";
            // 
            // CancelarBtn
            // 
            CancelarBtn.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            CancelarBtn.IconColor = Color.Black;
            CancelarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CancelarBtn.IconSize = 25;
            CancelarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CancelarBtn.Location = new Point(487, 339);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(115, 29);
            CancelarBtn.TabIndex = 21;
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
            AgregarBtn.Location = new Point(278, 339);
            AgregarBtn.Name = "AgregarBtn";
            AgregarBtn.Size = new Size(109, 29);
            AgregarBtn.TabIndex = 20;
            AgregarBtn.Text = "Agregar";
            AgregarBtn.UseVisualStyleBackColor = true;
            AgregarBtn.Click += AgregarBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 259);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 18;
            label2.Text = "Fecha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 112);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 16;
            label1.Text = "Equipo Local:";
            // 
            // cmbLocal
            // 
            cmbLocal.FormattingEnabled = true;
            cmbLocal.Location = new Point(278, 112);
            cmbLocal.Name = "cmbLocal";
            cmbLocal.Size = new Size(324, 28);
            cmbLocal.TabIndex = 23;
            // 
            // cmbVisitante
            // 
            cmbVisitante.FormattingEnabled = true;
            cmbVisitante.Location = new Point(278, 184);
            cmbVisitante.Name = "cmbVisitante";
            cmbVisitante.Size = new Size(324, 28);
            cmbVisitante.TabIndex = 24;
            // 
            // dateTimeFecha
            // 
            dateTimeFecha.Location = new Point(278, 268);
            dateTimeFecha.Name = "dateTimeFecha";
            dateTimeFecha.Size = new Size(324, 27);
            dateTimeFecha.TabIndex = 25;
            // 
            // AgregarEditarPartidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimeFecha);
            Controls.Add(cmbVisitante);
            Controls.Add(cmbLocal);
            Controls.Add(label3);
            Controls.Add(CancelarBtn);
            Controls.Add(AgregarBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarEditarPartidos";
            Text = "Agregar/Editar Partidos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private FontAwesome.Sharp.IconButton CancelarBtn;
        private FontAwesome.Sharp.IconButton AgregarBtn;
        private Label label2;
        private Label label1;
        private ComboBox cmbLocal;
        private ComboBox cmbVisitante;
        private DateTimePicker dateTimeFecha;
    }
}