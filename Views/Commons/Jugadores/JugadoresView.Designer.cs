namespace FutbolDesktop.Views
{
    partial class JugadoresView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JugadoresView));
            label1 = new Label();
            dataGridViewJugadores = new DataGridView();
            CancelarBtn = new FontAwesome.Sharp.IconButton();
            EliminarBtn = new FontAwesome.Sharp.IconButton();
            EditarBtn = new FontAwesome.Sharp.IconButton();
            AgregarBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJugadores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 22);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 13;
            label1.Text = "JUGADORES:";
            // 
            // dataGridViewJugadores
            // 
            dataGridViewJugadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewJugadores.Location = new Point(59, 51);
            dataGridViewJugadores.Name = "dataGridViewJugadores";
            dataGridViewJugadores.RowHeadersWidth = 51;
            dataGridViewJugadores.Size = new Size(815, 383);
            dataGridViewJugadores.TabIndex = 12;
            // 
            // CancelarBtn
            // 
            CancelarBtn.BackColor = Color.RosyBrown;
            CancelarBtn.FlatStyle = FlatStyle.Flat;
            CancelarBtn.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            CancelarBtn.IconColor = Color.Black;
            CancelarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CancelarBtn.IconSize = 25;
            CancelarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CancelarBtn.Location = new Point(809, 451);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(115, 29);
            CancelarBtn.TabIndex = 17;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.TextAlign = ContentAlignment.MiddleRight;
            CancelarBtn.UseVisualStyleBackColor = false;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // EliminarBtn
            // 
            EliminarBtn.BackColor = Color.LightCoral;
            EliminarBtn.FlatStyle = FlatStyle.Flat;
            EliminarBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            EliminarBtn.IconColor = Color.Black;
            EliminarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EliminarBtn.IconSize = 18;
            EliminarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            EliminarBtn.Location = new Point(360, 451);
            EliminarBtn.Name = "EliminarBtn";
            EliminarBtn.Size = new Size(109, 29);
            EliminarBtn.TabIndex = 16;
            EliminarBtn.Text = "Eliminar";
            EliminarBtn.UseVisualStyleBackColor = false;
            EliminarBtn.Click += EliminarBtn_Click;
            // 
            // EditarBtn
            // 
            EditarBtn.BackColor = Color.DeepSkyBlue;
            EditarBtn.FlatStyle = FlatStyle.Flat;
            EditarBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            EditarBtn.IconColor = Color.Black;
            EditarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EditarBtn.IconSize = 18;
            EditarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            EditarBtn.Location = new Point(206, 451);
            EditarBtn.Name = "EditarBtn";
            EditarBtn.Size = new Size(109, 29);
            EditarBtn.TabIndex = 15;
            EditarBtn.Text = "Editar";
            EditarBtn.UseVisualStyleBackColor = false;
            EditarBtn.Click += EditarBtn_Click;
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
            AgregarBtn.Location = new Point(61, 451);
            AgregarBtn.Name = "AgregarBtn";
            AgregarBtn.Size = new Size(109, 29);
            AgregarBtn.TabIndex = 14;
            AgregarBtn.Text = "Agregar";
            AgregarBtn.UseVisualStyleBackColor = false;
            AgregarBtn.Click += AgregarBtn_Click;
            // 
            // JugadoresView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(992, 504);
            Controls.Add(CancelarBtn);
            Controls.Add(EliminarBtn);
            Controls.Add(EditarBtn);
            Controls.Add(AgregarBtn);
            Controls.Add(label1);
            Controls.Add(dataGridViewJugadores);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "JugadoresView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jugadores";
            ((System.ComponentModel.ISupportInitialize)dataGridViewJugadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridViewJugadores;
        private FontAwesome.Sharp.IconButton CancelarBtn;
        private FontAwesome.Sharp.IconButton EliminarBtn;
        private FontAwesome.Sharp.IconButton EditarBtn;
        private FontAwesome.Sharp.IconButton AgregarBtn;
    }
}