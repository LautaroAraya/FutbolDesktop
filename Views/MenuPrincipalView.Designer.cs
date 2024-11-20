namespace FutbolDesktop
{
    partial class MenuPrincipalView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalView));
            menuStrip1 = new MenuStrip();
            BtnIconInicio = new FontAwesome.Sharp.IconMenuItem();
            ClubBtn = new FontAwesome.Sharp.IconMenuItem();
            JugadoresBtn = new FontAwesome.Sharp.IconMenuItem();
            EntrenadoresBtn = new FontAwesome.Sharp.IconMenuItem();
            EquiposBtn = new FontAwesome.Sharp.IconMenuItem();
            PartidosBtn = new FontAwesome.Sharp.IconMenuItem();
            LigasBtn = new FontAwesome.Sharp.IconMenuItem();
            SalirBtn = new FontAwesome.Sharp.IconMenuItem();
            SalirSistemaBtn = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.DarkSeaGreen;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { BtnIconInicio, ClubBtn, SalirBtn });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(98, 450);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // BtnIconInicio
            // 
            BtnIconInicio.BackColor = Color.White;
            BtnIconInicio.ForeColor = Color.Black;
            BtnIconInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            BtnIconInicio.IconColor = Color.Black;
            BtnIconInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnIconInicio.Name = "BtnIconInicio";
            BtnIconInicio.Size = new Size(91, 32);
            BtnIconInicio.Text = "Inicio";
            // 
            // ClubBtn
            // 
            ClubBtn.DropDownItems.AddRange(new ToolStripItem[] { JugadoresBtn, EntrenadoresBtn, EquiposBtn, PartidosBtn, LigasBtn });
            ClubBtn.ForeColor = Color.Black;
            ClubBtn.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            ClubBtn.IconColor = Color.Black;
            ClubBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ClubBtn.Name = "ClubBtn";
            ClubBtn.Size = new Size(91, 32);
            ClubBtn.Text = "Club";
            // 
            // JugadoresBtn
            // 
            JugadoresBtn.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            JugadoresBtn.IconColor = Color.Black;
            JugadoresBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            JugadoresBtn.Name = "JugadoresBtn";
            JugadoresBtn.Size = new Size(224, 32);
            JugadoresBtn.Text = "Jugadores";
            JugadoresBtn.Click += JugadoresBtn_Click;
            // 
            // EntrenadoresBtn
            // 
            EntrenadoresBtn.IconChar = FontAwesome.Sharp.IconChar.PersonRunning;
            EntrenadoresBtn.IconColor = Color.Black;
            EntrenadoresBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EntrenadoresBtn.Name = "EntrenadoresBtn";
            EntrenadoresBtn.Size = new Size(224, 32);
            EntrenadoresBtn.Text = "Entrenadores";
            EntrenadoresBtn.Click += EntrenadoresBtn_Click;
            // 
            // EquiposBtn
            // 
            EquiposBtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            EquiposBtn.IconColor = Color.Black;
            EquiposBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EquiposBtn.Name = "EquiposBtn";
            EquiposBtn.Size = new Size(224, 32);
            EquiposBtn.Text = "Equipos";
            EquiposBtn.Click += EquiposBtn_Click;
            // 
            // PartidosBtn
            // 
            PartidosBtn.IconChar = FontAwesome.Sharp.IconChar.SoccerBall;
            PartidosBtn.IconColor = Color.Black;
            PartidosBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PartidosBtn.Name = "PartidosBtn";
            PartidosBtn.Size = new Size(224, 32);
            PartidosBtn.Text = "Partidos";
            PartidosBtn.Click += PartidosBtn_Click;
            // 
            // LigasBtn
            // 
            LigasBtn.IconChar = FontAwesome.Sharp.IconChar.Sitemap;
            LigasBtn.IconColor = Color.Black;
            LigasBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LigasBtn.Name = "LigasBtn";
            LigasBtn.Size = new Size(224, 32);
            LigasBtn.Text = "Ligas";
            LigasBtn.Click += LigasBtn_Click;
            // 
            // SalirBtn
            // 
            SalirBtn.DropDownItems.AddRange(new ToolStripItem[] { SalirSistemaBtn });
            SalirBtn.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            SalirBtn.IconColor = Color.Black;
            SalirBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SalirBtn.Name = "SalirBtn";
            SalirBtn.Size = new Size(91, 32);
            SalirBtn.Text = "Salir";
            // 
            // SalirSistemaBtn
            // 
            SalirSistemaBtn.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            SalirSistemaBtn.IconColor = Color.Black;
            SalirSistemaBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SalirSistemaBtn.Name = "SalirSistemaBtn";
            SalirSistemaBtn.Size = new Size(241, 32);
            SalirSistemaBtn.Text = "Salir del Sistema";
            SalirSistemaBtn.Click += SalirSistemaBtn_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = Properties.Resources.thumb_1920_510026;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipalView";
            Text = "Futbol Club Kenjhi";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem BtnIconInicio;
        private FontAwesome.Sharp.IconMenuItem ClubBtn;
        private FontAwesome.Sharp.IconMenuItem JugadoresBtn;
        private FontAwesome.Sharp.IconMenuItem EntrenadoresBtn;
        private FontAwesome.Sharp.IconMenuItem EquiposBtn;
        private FontAwesome.Sharp.IconMenuItem PartidosBtn;
        private FontAwesome.Sharp.IconMenuItem LigasBtn;
        private FontAwesome.Sharp.IconMenuItem SalirBtn;
        private FontAwesome.Sharp.IconMenuItem SalirSistemaBtn;
    }
}