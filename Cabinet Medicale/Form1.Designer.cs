namespace Cabinet_Medicale
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
            this.components = new System.ComponentModel.Container();
            Bunifu.Framework.UI.BunifuElipse bunifuElipse13;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.count_rdv = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pat_panel = new System.Windows.Forms.PictureBox();
            this.rdv_panel = new System.Windows.Forms.PictureBox();
            this.doc_panel = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            bunifuElipse13 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pat_panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdv_panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doc_panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse13
            // 
            bunifuElipse13.ElipseRadius = 35;
            bunifuElipse13.TargetControl = this.bunifuGradientPanel1;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.count_rdv);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(749, 76);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(35, 35);
            this.bunifuGradientPanel1.TabIndex = 58;
            this.bunifuGradientPanel1.Click += new System.EventHandler(this.label15_Click);
            // 
            // count_rdv
            // 
            this.count_rdv.AutoSize = true;
            this.count_rdv.BackColor = System.Drawing.Color.Transparent;
            this.count_rdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_rdv.ForeColor = System.Drawing.SystemColors.Control;
            this.count_rdv.Location = new System.Drawing.Point(7, 5);
            this.count_rdv.Name = "count_rdv";
            this.count_rdv.Size = new System.Drawing.Size(21, 22);
            this.count_rdv.TabIndex = 56;
            this.count_rdv.Text = "0";
            this.count_rdv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.count_rdv.Click += new System.EventHandler(this.label15_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel10.Controls.Add(this.label1);
            this.panel10.Location = new System.Drawing.Point(124, 402);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(208, 44);
            this.panel10.TabIndex = 3;
            this.panel10.Click += new System.EventHandler(this.doc_panel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion Medecins";
            this.label1.Click += new System.EventHandler(this.doc_panel_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel11.Controls.Add(this.label2);
            this.panel11.Location = new System.Drawing.Point(350, 402);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(208, 44);
            this.panel11.TabIndex = 4;
            this.panel11.Click += new System.EventHandler(this.pat_panel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(34, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gestion Patients";
            this.label2.Click += new System.EventHandler(this.pat_panel_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel12.Controls.Add(this.label3);
            this.panel12.Location = new System.Drawing.Point(573, 402);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(208, 44);
            this.panel12.TabIndex = 4;
            this.panel12.Click += new System.EventHandler(this.rdv_panel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(54, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gestion RDV";
            this.label3.Click += new System.EventHandler(this.rdv_panel_Click);
            // 
            // pat_panel
            // 
            this.pat_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pat_panel.Image = ((System.Drawing.Image)(resources.GetObject("pat_panel.Image")));
            this.pat_panel.Location = new System.Drawing.Point(350, 138);
            this.pat_panel.Name = "pat_panel";
            this.pat_panel.Size = new System.Drawing.Size(208, 257);
            this.pat_panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pat_panel.TabIndex = 13;
            this.pat_panel.TabStop = false;
            this.pat_panel.Click += new System.EventHandler(this.pat_panel_Click);
            // 
            // rdv_panel
            // 
            this.rdv_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rdv_panel.Image = ((System.Drawing.Image)(resources.GetObject("rdv_panel.Image")));
            this.rdv_panel.Location = new System.Drawing.Point(573, 138);
            this.rdv_panel.Name = "rdv_panel";
            this.rdv_panel.Size = new System.Drawing.Size(208, 257);
            this.rdv_panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rdv_panel.TabIndex = 17;
            this.rdv_panel.TabStop = false;
            this.rdv_panel.Click += new System.EventHandler(this.rdv_panel_Click);
            // 
            // doc_panel
            // 
            this.doc_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doc_panel.Image = ((System.Drawing.Image)(resources.GetObject("doc_panel.Image")));
            this.doc_panel.Location = new System.Drawing.Point(124, 138);
            this.doc_panel.Name = "doc_panel";
            this.doc_panel.Size = new System.Drawing.Size(208, 257);
            this.doc_panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doc_panel.TabIndex = 40;
            this.doc_panel.TabStop = false;
            this.doc_panel.Click += new System.EventHandler(this.doc_panel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(608, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.label15_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel13.Controls.Add(this.pictureBox1);
            this.panel13.Controls.Add(this.label15);
            this.panel13.Location = new System.Drawing.Point(124, 88);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(657, 44);
            this.panel13.TabIndex = 57;
            this.panel13.Click += new System.EventHandler(this.label15_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label15.Location = new System.Drawing.Point(12, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(549, 18);
            this.label15.TabIndex = 2;
            this.label15.Text = "Affaicher tous les rendez-vous d\'aujourd\'hui ou chercher un rdv par date";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 469);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.doc_panel);
            this.Controls.Add(this.rdv_panel);
            this.Controls.Add(this.pat_panel);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pat_panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdv_panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doc_panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pat_panel;
        private System.Windows.Forms.PictureBox rdv_panel;
        private System.Windows.Forms.PictureBox doc_panel;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        internal System.Windows.Forms.Label count_rdv;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
    }
}

