namespace MenaxhimiRestorantit
{
    partial class frmRegjistrimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegjistrimi));
            this.bttRegjistro = new System.Windows.Forms.Button();
            this.txtFjalekalimi = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.cmbRolet = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttRegjistro
            // 
            this.bttRegjistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttRegjistro.Location = new System.Drawing.Point(261, 367);
            this.bttRegjistro.Name = "bttRegjistro";
            this.bttRegjistro.Size = new System.Drawing.Size(75, 23);
            this.bttRegjistro.TabIndex = 0;
            this.bttRegjistro.Text = "Regjistro";
            this.bttRegjistro.UseVisualStyleBackColor = true;
            // 
            // txtFjalekalimi
            // 
            this.txtFjalekalimi.BackColor = System.Drawing.Color.Silver;
            this.txtFjalekalimi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFjalekalimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFjalekalimi.Location = new System.Drawing.Point(221, 237);
            this.txtFjalekalimi.Multiline = true;
            this.txtFjalekalimi.Name = "txtFjalekalimi";
            this.txtFjalekalimi.Size = new System.Drawing.Size(163, 24);
            this.txtFjalekalimi.TabIndex = 8;
            this.txtFjalekalimi.Text = "Fjalekalimi";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Silver;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(221, 195);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(163, 24);
            this.txtUsername.TabIndex = 7;
            this.txtUsername.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(257, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Regjistrimi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(221, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmri
            // 
            this.txtEmri.BackColor = System.Drawing.Color.Silver;
            this.txtEmri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmri.Location = new System.Drawing.Point(221, 276);
            this.txtEmri.Multiline = true;
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(163, 24);
            this.txtEmri.TabIndex = 9;
            this.txtEmri.Text = "Emri";
            // 
            // cmbRolet
            // 
            this.cmbRolet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbRolet.DisplayMember = "2";
            this.cmbRolet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRolet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRolet.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbRolet.FormattingEnabled = true;
            this.cmbRolet.Items.AddRange(new object[] {
            "Administrator",
            "Staf"});
            this.cmbRolet.Location = new System.Drawing.Point(221, 315);
            this.cmbRolet.MaxDropDownItems = 2;
            this.cmbRolet.Name = "cmbRolet";
            this.cmbRolet.Size = new System.Drawing.Size(170, 21);
            this.cmbRolet.TabIndex = 10;
            this.cmbRolet.Text = "Roli";
            // 
            // frmRegjistrimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.cmbRolet);
            this.Controls.Add(this.txtEmri);
            this.Controls.Add(this.txtFjalekalimi);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttRegjistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegjistrimi";
            this.Text = "frmRegjistrimi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttRegjistro;
        private System.Windows.Forms.TextBox txtFjalekalimi;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmri;
        private System.Windows.Forms.ComboBox cmbRolet;
    }
}