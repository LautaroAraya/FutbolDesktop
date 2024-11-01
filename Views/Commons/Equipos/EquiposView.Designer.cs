namespace FutbolDesktop.Views
{
    partial class EquiposView
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
            dataGridViewEquipos = new DataGridView();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquipos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 22);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 7;
            label1.Text = "EQUIPOS:";
            // 
            // dataGridViewEquipos
            // 
            dataGridViewEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEquipos.Location = new Point(59, 51);
            dataGridViewEquipos.Name = "dataGridViewEquipos";
            dataGridViewEquipos.RowHeadersWidth = 51;
            dataGridViewEquipos.Size = new Size(815, 383);
            dataGridViewEquipos.TabIndex = 6;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 25;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(827, 450);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(115, 29);
            iconButton1.TabIndex = 15;
            iconButton1.Text = "Cancelar";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 18;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(378, 450);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(109, 29);
            iconButton2.TabIndex = 14;
            iconButton2.Text = "Eliminar";
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Edit;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 18;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(224, 450);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(109, 29);
            iconButton3.TabIndex = 13;
            iconButton3.Text = "Editar";
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.File;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 18;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(70, 450);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(109, 29);
            iconButton4.TabIndex = 12;
            iconButton4.Text = "Agregar";
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // EquiposView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 504);
            Controls.Add(iconButton1);
            Controls.Add(iconButton2);
            Controls.Add(iconButton3);
            Controls.Add(iconButton4);
            Controls.Add(label1);
            Controls.Add(dataGridViewEquipos);
            Name = "EquiposView";
            Text = "Equipos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquipos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridViewEquipos;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}