﻿namespace FutbolDesktop.Views
{
    partial class PartidosView
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
            label1 = new Label();
            dataGridViewPartidos = new DataGridView();
            CancelarBtn = new FontAwesome.Sharp.IconButton();
            EliminarBtn = new FontAwesome.Sharp.IconButton();
            EditarBtn = new FontAwesome.Sharp.IconButton();
            AgregarBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartidos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 22);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 13;
            label1.Text = "PARTIDOS:";
            // 
            // dataGridViewPartidos
            // 
            dataGridViewPartidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPartidos.Location = new Point(59, 51);
            dataGridViewPartidos.Name = "dataGridViewPartidos";
            dataGridViewPartidos.RowHeadersWidth = 51;
            dataGridViewPartidos.Size = new Size(815, 383);
            dataGridViewPartidos.TabIndex = 12;
            // 
            // CancelarBtn
            // 
            CancelarBtn.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            CancelarBtn.IconColor = Color.Black;
            CancelarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CancelarBtn.IconSize = 25;
            CancelarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CancelarBtn.Location = new Point(823, 449);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(115, 29);
            CancelarBtn.TabIndex = 17;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.TextAlign = ContentAlignment.MiddleRight;
            CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // EliminarBtn
            // 
            EliminarBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            EliminarBtn.IconColor = Color.Black;
            EliminarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EliminarBtn.IconSize = 18;
            EliminarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            EliminarBtn.Location = new Point(374, 449);
            EliminarBtn.Name = "EliminarBtn";
            EliminarBtn.Size = new Size(109, 29);
            EliminarBtn.TabIndex = 16;
            EliminarBtn.Text = "Eliminar";
            EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // EditarBtn
            // 
            EditarBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            EditarBtn.IconColor = Color.Black;
            EditarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EditarBtn.IconSize = 18;
            EditarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            EditarBtn.Location = new Point(220, 449);
            EditarBtn.Name = "EditarBtn";
            EditarBtn.Size = new Size(109, 29);
            EditarBtn.TabIndex = 15;
            EditarBtn.Text = "Editar";
            EditarBtn.UseVisualStyleBackColor = true;
            // 
            // AgregarBtn
            // 
            AgregarBtn.IconChar = FontAwesome.Sharp.IconChar.File;
            AgregarBtn.IconColor = Color.Black;
            AgregarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AgregarBtn.IconSize = 18;
            AgregarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AgregarBtn.Location = new Point(75, 449);
            AgregarBtn.Name = "AgregarBtn";
            AgregarBtn.Size = new Size(109, 29);
            AgregarBtn.TabIndex = 14;
            AgregarBtn.Text = "Agregar";
            AgregarBtn.UseVisualStyleBackColor = true;
            // 
            // PartidosView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 504);
            Controls.Add(CancelarBtn);
            Controls.Add(EliminarBtn);
            Controls.Add(EditarBtn);
            Controls.Add(AgregarBtn);
            Controls.Add(label1);
            Controls.Add(dataGridViewPartidos);
            Name = "PartidosView";
            Text = "Partidos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridViewPartidos;
        private FontAwesome.Sharp.IconButton CancelarBtn;
        private FontAwesome.Sharp.IconButton EliminarBtn;
        private FontAwesome.Sharp.IconButton EditarBtn;
        private FontAwesome.Sharp.IconButton AgregarBtn;
    }
}