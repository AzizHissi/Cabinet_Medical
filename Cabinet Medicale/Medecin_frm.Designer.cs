namespace Cabinet_Medicale
{
    partial class Medecin_frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab_medecin = new MetroFramework.Controls.MetroTabControl();
            this.tab_add = new MetroFramework.Controls.MetroTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_tel_add = new System.Windows.Forms.MaskedTextBox();
            this.cb_speciliste_add = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dt_dateE_add = new System.Windows.Forms.DateTimePicker();
            this.txt_nom_add = new System.Windows.Forms.TextBox();
            this.txt_code_add = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.tab_modify = new MetroFramework.Controls.MetroTabPage();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tel_mod = new System.Windows.Forms.MaskedTextBox();
            this.cb_med_mod = new System.Windows.Forms.ComboBox();
            this.cb_specialite_mod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_dateE_mod = new System.Windows.Forms.DateTimePicker();
            this.txt_nom_mod = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.tab_grid = new MetroFramework.Controls.MetroTabPage();
            this.Grid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.tab_medecin.SuspendLayout();
            this.tab_add.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tab_modify.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tab_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_medecin
            // 
            this.tab_medecin.Controls.Add(this.tab_add);
            this.tab_medecin.Controls.Add(this.tab_modify);
            this.tab_medecin.Controls.Add(this.tab_grid);
            this.tab_medecin.Location = new System.Drawing.Point(23, 90);
            this.tab_medecin.Name = "tab_medecin";
            this.tab_medecin.SelectedIndex = 0;
            this.tab_medecin.Size = new System.Drawing.Size(780, 424);
            this.tab_medecin.TabIndex = 58;
            this.tab_medecin.UseSelectable = true;
            this.tab_medecin.SelectedIndexChanged += new System.EventHandler(this.tab_patient_SelectedIndexChanged);
            // 
            // tab_add
            // 
            this.tab_add.Controls.Add(this.groupBox2);
            this.tab_add.Controls.Add(this.btn_add);
            this.tab_add.HorizontalScrollbarBarColor = true;
            this.tab_add.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_add.HorizontalScrollbarSize = 10;
            this.tab_add.Location = new System.Drawing.Point(4, 38);
            this.tab_add.Name = "tab_add";
            this.tab_add.Size = new System.Drawing.Size(772, 382);
            this.tab_add.TabIndex = 0;
            this.tab_add.Text = "Ajouter";
            this.tab_add.VerticalScrollbarBarColor = true;
            this.tab_add.VerticalScrollbarHighlightOnWheel = false;
            this.tab_add.VerticalScrollbarSize = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            this.groupBox2.Controls.Add(this.txt_tel_add);
            this.groupBox2.Controls.Add(this.cb_speciliste_add);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dt_dateE_add);
            this.groupBox2.Controls.Add(this.txt_nom_add);
            this.groupBox2.Controls.Add(this.txt_code_add);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.groupBox2.Location = new System.Drawing.Point(7, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 290);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SUPRIMER UN MEDECIN :";
            // 
            // txt_tel_add
            // 
            this.txt_tel_add.Location = new System.Drawing.Point(318, 143);
            this.txt_tel_add.Mask = "0000-000000";
            this.txt_tel_add.Name = "txt_tel_add";
            this.txt_tel_add.Size = new System.Drawing.Size(219, 32);
            this.txt_tel_add.TabIndex = 24;
            // 
            // cb_speciliste_add
            // 
            this.cb_speciliste_add.FormattingEnabled = true;
            this.cb_speciliste_add.Location = new System.Drawing.Point(318, 235);
            this.cb_speciliste_add.Name = "cb_speciliste_add";
            this.cb_speciliste_add.Size = new System.Drawing.Size(219, 32);
            this.cb_speciliste_add.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(168, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Code Medecin :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(172, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nom Medecin :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(129, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Numero Telephone :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(156, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Date Embauche :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(197, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Specialite  :";
            // 
            // dt_dateE_add
            // 
            this.dt_dateE_add.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.dt_dateE_add.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_dateE_add.Location = new System.Drawing.Point(318, 189);
            this.dt_dateE_add.Name = "dt_dateE_add";
            this.dt_dateE_add.Size = new System.Drawing.Size(219, 32);
            this.dt_dateE_add.TabIndex = 22;
            // 
            // txt_nom_add
            // 
            this.txt_nom_add.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txt_nom_add.Location = new System.Drawing.Point(318, 97);
            this.txt_nom_add.Name = "txt_nom_add";
            this.txt_nom_add.Size = new System.Drawing.Size(219, 32);
            this.txt_nom_add.TabIndex = 8;
            // 
            // txt_code_add
            // 
            this.txt_code_add.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txt_code_add.Location = new System.Drawing.Point(318, 51);
            this.txt_code_add.Name = "txt_code_add";
            this.txt_code_add.Size = new System.Drawing.Size(219, 32);
            this.txt_code_add.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(325, 313);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(137, 36);
            this.btn_add.TabIndex = 28;
            this.btn_add.Text = "AJOUTER";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tab_modify
            // 
            this.tab_modify.Controls.Add(this.btn_delete);
            this.tab_modify.Controls.Add(this.groupBox1);
            this.tab_modify.Controls.Add(this.btn_save);
            this.tab_modify.HorizontalScrollbarBarColor = true;
            this.tab_modify.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_modify.HorizontalScrollbarSize = 10;
            this.tab_modify.Location = new System.Drawing.Point(4, 38);
            this.tab_modify.Name = "tab_modify";
            this.tab_modify.Size = new System.Drawing.Size(772, 382);
            this.tab_modify.TabIndex = 1;
            this.tab_modify.Text = "Modifier/Suprimer";
            this.tab_modify.VerticalScrollbarBarColor = true;
            this.tab_modify.VerticalScrollbarHighlightOnWheel = false;
            this.tab_modify.VerticalScrollbarSize = 10;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(193, 313);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(137, 36);
            this.btn_delete.TabIndex = 33;
            this.btn_delete.Text = "SUPRIMER";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            this.groupBox1.Controls.Add(this.txt_tel_mod);
            this.groupBox1.Controls.Add(this.cb_med_mod);
            this.groupBox1.Controls.Add(this.cb_specialite_mod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dt_dateE_mod);
            this.groupBox1.Controls.Add(this.txt_nom_mod);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.groupBox1.Location = new System.Drawing.Point(7, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 290);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SUPRIMER UN MEDECIN :";
            // 
            // txt_tel_mod
            // 
            this.txt_tel_mod.Location = new System.Drawing.Point(318, 143);
            this.txt_tel_mod.Mask = "0000-000000";
            this.txt_tel_mod.Name = "txt_tel_mod";
            this.txt_tel_mod.Size = new System.Drawing.Size(219, 32);
            this.txt_tel_mod.TabIndex = 25;
            // 
            // cb_med_mod
            // 
            this.cb_med_mod.FormattingEnabled = true;
            this.cb_med_mod.Location = new System.Drawing.Point(318, 51);
            this.cb_med_mod.Name = "cb_med_mod";
            this.cb_med_mod.Size = new System.Drawing.Size(219, 32);
            this.cb_med_mod.TabIndex = 24;
            // 
            // cb_specialite_mod
            // 
            this.cb_specialite_mod.FormattingEnabled = true;
            this.cb_specialite_mod.Location = new System.Drawing.Point(318, 235);
            this.cb_specialite_mod.Name = "cb_specialite_mod";
            this.cb_specialite_mod.Size = new System.Drawing.Size(219, 32);
            this.cb_specialite_mod.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(168, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Medecin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(172, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom Medecin :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(129, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numero Telephone :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(156, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date Embauche :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(197, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Specialite  :";
            // 
            // dt_dateE_mod
            // 
            this.dt_dateE_mod.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.dt_dateE_mod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_dateE_mod.Location = new System.Drawing.Point(318, 189);
            this.dt_dateE_mod.Name = "dt_dateE_mod";
            this.dt_dateE_mod.Size = new System.Drawing.Size(219, 32);
            this.dt_dateE_mod.TabIndex = 22;
            // 
            // txt_nom_mod
            // 
            this.txt_nom_mod.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txt_nom_mod.Location = new System.Drawing.Point(318, 97);
            this.txt_nom_mod.Name = "txt_nom_mod";
            this.txt_nom_mod.Size = new System.Drawing.Size(219, 32);
            this.txt_nom_mod.TabIndex = 8;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(372, 313);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(137, 36);
            this.btn_save.TabIndex = 29;
            this.btn_save.Text = "ENREISTRER";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tab_grid
            // 
            this.tab_grid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab_grid.Controls.Add(this.Grid);
            this.tab_grid.HorizontalScrollbarBarColor = true;
            this.tab_grid.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_grid.HorizontalScrollbarSize = 10;
            this.tab_grid.Location = new System.Drawing.Point(4, 38);
            this.tab_grid.Name = "tab_grid";
            this.tab_grid.Size = new System.Drawing.Size(772, 382);
            this.tab_grid.TabIndex = 3;
            this.tab_grid.Text = "Affaicher Tout";
            this.tab_grid.VerticalScrollbarBarColor = true;
            this.tab_grid.VerticalScrollbarHighlightOnWheel = false;
            this.tab_grid.VerticalScrollbarSize = 10;
            // 
            // Grid
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.DoubleBuffered = true;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(160)))), ((int)(((byte)(171)))));
            this.Grid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.Grid.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.Grid.Location = new System.Drawing.Point(6, 19);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Grid.Size = new System.Drawing.Size(751, 348);
            this.Grid.TabIndex = 31;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel13.Controls.Add(this.label14);
            this.panel13.Location = new System.Drawing.Point(23, 40);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(780, 44);
            this.panel13.TabIndex = 57;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(5, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(274, 33);
            this.label14.TabIndex = 40;
            this.label14.Text = "Gestion Des Medecins :";
            // 
            // Medecin_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 528);
            this.Controls.Add(this.tab_medecin);
            this.Controls.Add(this.panel13);
            this.Name = "Medecin_frm";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Medecin_frm_Load);
            this.tab_medecin.ResumeLayout(false);
            this.tab_add.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tab_modify.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tab_medecin;
        private MetroFramework.Controls.MetroTabPage tab_add;
        private System.Windows.Forms.Button btn_add;
        private MetroFramework.Controls.MetroTabPage tab_modify;
        private System.Windows.Forms.Button btn_save;
        private MetroFramework.Controls.MetroTabPage tab_grid;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_speciliste_add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dt_dateE_add;
        private System.Windows.Forms.TextBox txt_nom_add;
        private System.Windows.Forms.TextBox txt_code_add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_specialite_mod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_dateE_mod;
        private System.Windows.Forms.TextBox txt_nom_mod;
        private System.Windows.Forms.ComboBox cb_med_mod;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Grid;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.MaskedTextBox txt_tel_add;
        private System.Windows.Forms.MaskedTextBox txt_tel_mod;
    }
}