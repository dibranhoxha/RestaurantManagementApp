﻿
namespace RestaurantManagementApp
{
	partial class Form1
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
<<<<<<< HEAD
            this.btnStafi = new MetroSet_UI.Controls.MetroSetButton();
            this.btnStatistikat = new MetroSet_UI.Controls.MetroSetButton();
            this.btnProduktet = new MetroSet_UI.Controls.MetroSetButton();
            this.btnTavolinat = new MetroSet_UI.Controls.MetroSetButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bttnKycu = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStafi
            // 
            this.btnStafi.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStafi.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStafi.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnStafi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStafi.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnStafi.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnStafi.HoverTextColor = System.Drawing.Color.White;
            this.btnStafi.IsDerivedStyle = true;
            this.btnStafi.Location = new System.Drawing.Point(3, 3);
            this.btnStafi.Name = "btnStafi";
            this.btnStafi.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStafi.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStafi.NormalTextColor = System.Drawing.Color.White;
            this.btnStafi.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStafi.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStafi.PressTextColor = System.Drawing.Color.White;
            this.btnStafi.Size = new System.Drawing.Size(187, 76);
            this.btnStafi.Style = MetroSet_UI.Enums.Style.Light;
            this.btnStafi.StyleManager = null;
            this.btnStafi.TabIndex = 0;
            this.btnStafi.Text = "Stafi";
            this.btnStafi.ThemeAuthor = "Narwin";
            this.btnStafi.ThemeName = "MetroLite";
            // 
            // btnStatistikat
            // 
            this.btnStatistikat.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStatistikat.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStatistikat.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnStatistikat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStatistikat.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnStatistikat.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnStatistikat.HoverTextColor = System.Drawing.Color.White;
            this.btnStatistikat.IsDerivedStyle = true;
            this.btnStatistikat.Location = new System.Drawing.Point(196, 3);
            this.btnStatistikat.Name = "btnStatistikat";
            this.btnStatistikat.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStatistikat.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStatistikat.NormalTextColor = System.Drawing.Color.White;
            this.btnStatistikat.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStatistikat.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStatistikat.PressTextColor = System.Drawing.Color.White;
            this.btnStatistikat.Size = new System.Drawing.Size(187, 76);
            this.btnStatistikat.Style = MetroSet_UI.Enums.Style.Light;
            this.btnStatistikat.StyleManager = null;
            this.btnStatistikat.TabIndex = 1;
            this.btnStatistikat.Text = "Statistikat";
            this.btnStatistikat.ThemeAuthor = "Narwin";
            this.btnStatistikat.ThemeName = "MetroLite";
            this.btnStatistikat.Click += new System.EventHandler(this.btnStatistikat_Click);
            // 
            // btnProduktet
            // 
            this.btnProduktet.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnProduktet.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnProduktet.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnProduktet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProduktet.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnProduktet.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnProduktet.HoverTextColor = System.Drawing.Color.White;
            this.btnProduktet.IsDerivedStyle = true;
            this.btnProduktet.Location = new System.Drawing.Point(389, 3);
            this.btnProduktet.Name = "btnProduktet";
            this.btnProduktet.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnProduktet.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnProduktet.NormalTextColor = System.Drawing.Color.White;
            this.btnProduktet.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnProduktet.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnProduktet.PressTextColor = System.Drawing.Color.White;
            this.btnProduktet.Size = new System.Drawing.Size(187, 76);
            this.btnProduktet.Style = MetroSet_UI.Enums.Style.Light;
            this.btnProduktet.StyleManager = null;
            this.btnProduktet.TabIndex = 2;
            this.btnProduktet.Text = "Produktet";
            this.btnProduktet.ThemeAuthor = "Narwin";
            this.btnProduktet.ThemeName = "MetroLite";
            this.btnProduktet.Click += new System.EventHandler(this.btnProduktet_Click);
            // 
            // btnTavolinat
            // 
            this.btnTavolinat.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnTavolinat.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnTavolinat.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnTavolinat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTavolinat.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnTavolinat.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnTavolinat.HoverTextColor = System.Drawing.Color.White;
            this.btnTavolinat.IsDerivedStyle = true;
            this.btnTavolinat.Location = new System.Drawing.Point(582, 3);
            this.btnTavolinat.Name = "btnTavolinat";
            this.btnTavolinat.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnTavolinat.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnTavolinat.NormalTextColor = System.Drawing.Color.White;
            this.btnTavolinat.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnTavolinat.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnTavolinat.PressTextColor = System.Drawing.Color.White;
            this.btnTavolinat.Size = new System.Drawing.Size(187, 76);
            this.btnTavolinat.Style = MetroSet_UI.Enums.Style.Light;
            this.btnTavolinat.StyleManager = null;
            this.btnTavolinat.TabIndex = 3;
            this.btnTavolinat.Text = "Tavolinat";
            this.btnTavolinat.ThemeAuthor = "Narwin";
            this.btnTavolinat.ThemeName = "MetroLite";
            this.btnTavolinat.Click += new System.EventHandler(this.btnTavolinat_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnStafi);
            this.flowLayoutPanel1.Controls.Add(this.btnStatistikat);
            this.flowLayoutPanel1.Controls.Add(this.btnProduktet);
            this.flowLayoutPanel1.Controls.Add(this.btnTavolinat);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 363);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // bttnKycu
            // 
            this.bttnKycu.Location = new System.Drawing.Point(570, 381);
            this.bttnKycu.Name = "bttnKycu";
            this.bttnKycu.Size = new System.Drawing.Size(138, 59);
            this.bttnKycu.TabIndex = 4;
            this.bttnKycu.Text = "KYCU";
            this.bttnKycu.UseVisualStyleBackColor = true;
            this.bttnKycu.Click += new System.EventHandler(this.bttnKycu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.bttnKycu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
=======
			this.btnStafi = new MetroSet_UI.Controls.MetroSetButton();
			this.btnStatistikat = new MetroSet_UI.Controls.MetroSetButton();
			this.btnProduktet = new MetroSet_UI.Controls.MetroSetButton();
			this.btnTavolinat = new MetroSet_UI.Controls.MetroSetButton();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnPorosia = new MetroSet_UI.Controls.MetroSetButton();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnStafi
			// 
			this.btnStafi.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
			this.btnStafi.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
			this.btnStafi.DisabledForeColor = System.Drawing.Color.Gray;
			this.btnStafi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnStafi.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
			this.btnStafi.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
			this.btnStafi.HoverTextColor = System.Drawing.Color.White;
			this.btnStafi.IsDerivedStyle = true;
			this.btnStafi.Location = new System.Drawing.Point(4, 4);
			this.btnStafi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnStafi.Name = "btnStafi";
			this.btnStafi.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
			this.btnStafi.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
			this.btnStafi.NormalTextColor = System.Drawing.Color.White;
			this.btnStafi.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
			this.btnStafi.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
			this.btnStafi.PressTextColor = System.Drawing.Color.White;
			this.btnStafi.Size = new System.Drawing.Size(249, 94);
			this.btnStafi.Style = MetroSet_UI.Enums.Style.Light;
			this.btnStafi.StyleManager = null;
			this.btnStafi.TabIndex = 0;
			this.btnStafi.Text = "Stafi";
			this.btnStafi.ThemeAuthor = "Narwin";
			this.btnStafi.ThemeName = "MetroLite";
			// 
			// btnStatistikat
			// 
			this.btnStatistikat.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
			this.btnStatistikat.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
			this.btnStatistikat.DisabledForeColor = System.Drawing.Color.Gray;
			this.btnStatistikat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnStatistikat.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
			this.btnStatistikat.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
			this.btnStatistikat.HoverTextColor = System.Drawing.Color.White;
			this.btnStatistikat.IsDerivedStyle = true;
			this.btnStatistikat.Location = new System.Drawing.Point(261, 4);
			this.btnStatistikat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnStatistikat.Name = "btnStatistikat";
			this.btnStatistikat.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
			this.btnStatistikat.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
			this.btnStatistikat.NormalTextColor = System.Drawing.Color.White;
			this.btnStatistikat.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
			this.btnStatistikat.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
			this.btnStatistikat.PressTextColor = System.Drawing.Color.White;
			this.btnStatistikat.Size = new System.Drawing.Size(249, 94);
			this.btnStatistikat.Style = MetroSet_UI.Enums.Style.Light;
			this.btnStatistikat.StyleManager = null;
			this.btnStatistikat.TabIndex = 1;
			this.btnStatistikat.Text = "Statistikat";
			this.btnStatistikat.ThemeAuthor = "Narwin";
			this.btnStatistikat.ThemeName = "MetroLite";
			this.btnStatistikat.Click += new System.EventHandler(this.btnStatistikat_Click);
			// 
			// btnProduktet
			// 
			this.btnProduktet.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
			this.btnProduktet.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
			this.btnProduktet.DisabledForeColor = System.Drawing.Color.Gray;
			this.btnProduktet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnProduktet.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
			this.btnProduktet.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
			this.btnProduktet.HoverTextColor = System.Drawing.Color.White;
			this.btnProduktet.IsDerivedStyle = true;
			this.btnProduktet.Location = new System.Drawing.Point(518, 4);
			this.btnProduktet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnProduktet.Name = "btnProduktet";
			this.btnProduktet.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
			this.btnProduktet.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
			this.btnProduktet.NormalTextColor = System.Drawing.Color.White;
			this.btnProduktet.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
			this.btnProduktet.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
			this.btnProduktet.PressTextColor = System.Drawing.Color.White;
			this.btnProduktet.Size = new System.Drawing.Size(249, 94);
			this.btnProduktet.Style = MetroSet_UI.Enums.Style.Light;
			this.btnProduktet.StyleManager = null;
			this.btnProduktet.TabIndex = 2;
			this.btnProduktet.Text = "Produktet";
			this.btnProduktet.ThemeAuthor = "Narwin";
			this.btnProduktet.ThemeName = "MetroLite";
			this.btnProduktet.Click += new System.EventHandler(this.btnProduktet_Click);
			// 
			// btnTavolinat
			// 
			this.btnTavolinat.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
			this.btnTavolinat.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
			this.btnTavolinat.DisabledForeColor = System.Drawing.Color.Gray;
			this.btnTavolinat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnTavolinat.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
			this.btnTavolinat.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
			this.btnTavolinat.HoverTextColor = System.Drawing.Color.White;
			this.btnTavolinat.IsDerivedStyle = true;
			this.btnTavolinat.Location = new System.Drawing.Point(775, 4);
			this.btnTavolinat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnTavolinat.Name = "btnTavolinat";
			this.btnTavolinat.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
			this.btnTavolinat.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
			this.btnTavolinat.NormalTextColor = System.Drawing.Color.White;
			this.btnTavolinat.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
			this.btnTavolinat.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
			this.btnTavolinat.PressTextColor = System.Drawing.Color.White;
			this.btnTavolinat.Size = new System.Drawing.Size(249, 94);
			this.btnTavolinat.Style = MetroSet_UI.Enums.Style.Light;
			this.btnTavolinat.StyleManager = null;
			this.btnTavolinat.TabIndex = 3;
			this.btnTavolinat.Text = "Tavolinat";
			this.btnTavolinat.ThemeAuthor = "Narwin";
			this.btnTavolinat.ThemeName = "MetroLite";
			this.btnTavolinat.Click += new System.EventHandler(this.btnTavolinat_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.btnStafi);
			this.flowLayoutPanel1.Controls.Add(this.btnStatistikat);
			this.flowLayoutPanel1.Controls.Add(this.btnProduktet);
			this.flowLayoutPanel1.Controls.Add(this.btnTavolinat);
			this.flowLayoutPanel1.Controls.Add(this.btnPorosia);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 15);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1035, 524);
			this.flowLayoutPanel1.TabIndex = 4;
			// 
			// btnPorosia
			// 
			this.btnPorosia.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
			this.btnPorosia.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
			this.btnPorosia.DisabledForeColor = System.Drawing.Color.Gray;
			this.btnPorosia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnPorosia.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
			this.btnPorosia.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
			this.btnPorosia.HoverTextColor = System.Drawing.Color.White;
			this.btnPorosia.IsDerivedStyle = true;
			this.btnPorosia.Location = new System.Drawing.Point(4, 106);
			this.btnPorosia.Margin = new System.Windows.Forms.Padding(4);
			this.btnPorosia.Name = "btnPorosia";
			this.btnPorosia.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
			this.btnPorosia.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
			this.btnPorosia.NormalTextColor = System.Drawing.Color.White;
			this.btnPorosia.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
			this.btnPorosia.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
			this.btnPorosia.PressTextColor = System.Drawing.Color.White;
			this.btnPorosia.Size = new System.Drawing.Size(249, 94);
			this.btnPorosia.Style = MetroSet_UI.Enums.Style.Light;
			this.btnPorosia.StyleManager = null;
			this.btnPorosia.TabIndex = 4;
			this.btnPorosia.Text = "Porosia";
			this.btnPorosia.ThemeAuthor = "Narwin";
			this.btnPorosia.ThemeName = "MetroLite";
			this.btnPorosia.Click += new System.EventHandler(this.btnPorosia_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
>>>>>>> 4983142e25fe093a83eafc67f2be1f2456f72c2e

		}

        #endregion

        private MetroSet_UI.Controls.MetroSetButton btnStafi;
        private MetroSet_UI.Controls.MetroSetButton btnStatistikat;
        private MetroSet_UI.Controls.MetroSetButton btnProduktet;
        private MetroSet_UI.Controls.MetroSetButton btnTavolinat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
<<<<<<< HEAD
        private System.Windows.Forms.Button bttnKycu;
    }
=======
		private MetroSet_UI.Controls.MetroSetButton btnPorosia;
	}
>>>>>>> 4983142e25fe093a83eafc67f2be1f2456f72c2e
}

