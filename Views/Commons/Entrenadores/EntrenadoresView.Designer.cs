namespace FutbolDesktop.Views
{
    partial class EntrenadoresView
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
            dataGridViewEntrenadores = new DataGridView();
            label1 = new Label();
            AgregarBtn = new FontAwesome.Sharp.IconButton();
            EditarBtn = new FontAwesome.Sharp.IconButton();
            EliminarBtn = new FontAwesome.Sharp.IconButton();
            CancelarBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEntrenadores).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEntrenadores
            // 
            dataGridViewEntrenadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEntrenadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEntrenadores.Location = new Point(81, 41);
            dataGridViewEntrenadores.Name = "dataGridViewEntrenadores";
            dataGridViewEntrenadores.RowHeadersWidth = 51;
            dataGridViewEntrenadores.Size = new Size(815, 383);
            dataGridViewEntrenadores.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 12);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 1;
            label1.Text = "ENTRENADORES:";
            // 
            // AgregarBtn
            // 
            AgregarBtn.IconChar = FontAwesome.Sharp.IconChar.File;
            AgregarBtn.IconColor = Color.Black;
            AgregarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AgregarBtn.IconSize = 18;
            AgregarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AgregarBtn.Location = new Point(104, 444);
            AgregarBtn.Name = "AgregarBtn";
            AgregarBtn.Size = new Size(109, 29);
            AgregarBtn.TabIndex = 2;
            AgregarBtn.Text = "Agregar";
            AgregarBtn.UseVisualStyleBackColor = true;
            AgregarBtn.Click += AgregarBtn_Click;
            // 
            // EditarBtn
            // 
            EditarBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            EditarBtn.IconColor = Color.Black;
            EditarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EditarBtn.IconSize = 18;
            EditarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            EditarBtn.Location = new Point(249, 444);
            EditarBtn.Name = "EditarBtn";
            EditarBtn.Size = new Size(109, 29);
            EditarBtn.TabIndex = 3;
            EditarBtn.Text = "Editar";
            EditarBtn.UseVisualStyleBackColor = true;
            EditarBtn.Click += EditarBtn_Click;
            // 
            // EliminarBtn
            // 
            EliminarBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            EliminarBtn.IconColor = Color.Black;
            EliminarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EliminarBtn.IconSize = 18;
            EliminarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            EliminarBtn.Location = new Point(403, 444);
            EliminarBtn.Name = "EliminarBtn";
            EliminarBtn.Size = new Size(109, 29);
            EliminarBtn.TabIndex = 4;
            EliminarBtn.Text = "Eliminar";
            EliminarBtn.UseVisualStyleBackColor = true;
            EliminarBtn.Click += EliminarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            CancelarBtn.IconColor = Color.Black;
            CancelarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CancelarBtn.IconSize = 25;
            CancelarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CancelarBtn.Location = new Point(852, 444);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(115, 29);
            CancelarBtn.TabIndex = 5;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.TextAlign = ContentAlignment.MiddleRight;
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // EntrenadoresView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 504);
            Controls.Add(CancelarBtn);
            Controls.Add(EliminarBtn);
            Controls.Add(EditarBtn);
            Controls.Add(AgregarBtn);
            Controls.Add(label1);
            Controls.Add(dataGridViewEntrenadores);
            Name = "EntrenadoresView";
            Text = "Entrenadores";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEntrenadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEntrenadores;
        private Label label1;
        private FontAwesome.Sharp.IconButton AgregarBtn;
        private FontAwesome.Sharp.IconButton EditarBtn;
        private FontAwesome.Sharp.IconButton EliminarBtn;
        private FontAwesome.Sharp.IconButton CancelarBtn;
    }
}