
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
            this.btnStafi = new MetroSet_UI.Controls.MetroSetButton();
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
            this.btnStafi.Location = new System.Drawing.Point(55, 24);
            this.btnStafi.Name = "btnStafi";
            this.btnStafi.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStafi.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStafi.NormalTextColor = System.Drawing.Color.White;
            this.btnStafi.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStafi.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStafi.PressTextColor = System.Drawing.Color.White;
            this.btnStafi.Size = new System.Drawing.Size(204, 76);
            this.btnStafi.Style = MetroSet_UI.Enums.Style.Light;
            this.btnStafi.StyleManager = null;
            this.btnStafi.TabIndex = 0;
            this.btnStafi.Text = "Stafi";
            this.btnStafi.ThemeAuthor = "Narwin";
            this.btnStafi.ThemeName = "MetroLite";
            this.btnStafi.Click += new System.EventHandler(this.btnStafi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStafi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

		}

        #endregion

        private MetroSet_UI.Controls.MetroSetButton btnStafi;
    }
}

