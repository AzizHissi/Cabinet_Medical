namespace Cabinet_Medicale
{
    partial class RDV_frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab_rdv = new MetroFramework.Controls.MetroTabControl();
            this.tab_add = new MetroFramework.Controls.MetroTabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_heure_add = new System.Windows.Forms.MaskedTextBox();
            this.dt_date_add = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_pat_add = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.rd_f_add = new System.Windows.Forms.RadioButton();
            this.rd_m_add = new System.Windows.Forms.RadioButton();
            this.txt_nomp_add = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_med_add = new System.Windows.Forms.ComboBox();
            this.txt_sepci_add = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_nomm_add = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.tab_modify = new MetroFramework.Controls.MetroTabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.cb_med_mod = new System.Windows.Forms.ComboBox();
            this.txt_heure_mod = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dt_date_mod = new System.Windows.Forms.DateTimePicker();
            this.txt_code_mod = new System.Windows.Forms.TextBox();
            this.grid_mod = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_pat_mod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_dateN_mod = new System.Windows.Forms.DateTimePicker();
            this.rb_f_mod = new System.Windows.Forms.RadioButton();
            this.rb_m_mod = new System.Windows.Forms.RadioButton();
            this.txt_pat_mod = new System.Windows.Forms.TextBox();
            this.tab_grid = new MetroFramework.Controls.MetroTabPage();
            this.Grid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.tab_rdv.SuspendLayout();
            this.tab_add.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tab_modify.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_mod)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tab_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_rdv
            // 
            this.tab_rdv.Controls.Add(this.tab_add);
            this.tab_rdv.Controls.Add(this.tab_modify);
            this.tab_rdv.Controls.Add(this.tab_grid);
            this.tab_rdv.Location = new System.Drawing.Point(23, 90);
            this.tab_rdv.Name = "tab_rdv";
            this.tab_rdv.SelectedIndex = 0;
            this.tab_rdv.Size = new System.Drawing.Size(859, 508);
            this.tab_rdv.TabIndex = 60;
            this.tab_rdv.UseSelectable = true;
            // 
            // tab_add
            // 
            this.tab_add.Controls.Add(this.groupBox5);
            this.tab_add.Controls.Add(this.groupBox4);
            this.tab_add.Controls.Add(this.groupBox2);
            this.tab_add.Controls.Add(this.btn_add);
            this.tab_add.HorizontalScrollbarBarColor = true;
            this.tab_add.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_add.HorizontalScrollbarSize = 10;
            this.tab_add.Location = new System.Drawing.Point(4, 38);
            this.tab_add.Name = "tab_add";
            this.tab_add.Size = new System.Drawing.Size(851, 466);
            this.tab_add.TabIndex = 0;
            this.tab_add.Text = "Ajouter";
            this.tab_add.VerticalScrollbarBarColor = true;
            this.tab_add.VerticalScrollbarHighlightOnWheel = false;
            this.tab_add.VerticalScrollbarSize = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            this.groupBox5.Controls.Add(this.txt_heure_add);
            this.groupBox5.Controls.Add(this.dt_date_add);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.groupBox5.Location = new System.Drawing.Point(0, 207);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(848, 99);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "RDV :";
            // 
            // txt_heure_add
            // 
            this.txt_heure_add.Location = new System.Drawing.Point(555, 41);
            this.txt_heure_add.Mask = "00:00";
            this.txt_heure_add.Name = "txt_heure_add";
            this.txt_heure_add.Size = new System.Drawing.Size(196, 32);
            this.txt_heure_add.TabIndex = 24;
            this.txt_heure_add.ValidatingType = typeof(System.DateTime);
            // 
            // dt_date_add
            // 
            this.dt_date_add.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.dt_date_add.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_date_add.Location = new System.Drawing.Point(161, 39);
            this.dt_date_add.Name = "dt_date_add";
            this.dt_date_add.Size = new System.Drawing.Size(196, 32);
            this.dt_date_add.TabIndex = 23;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(11, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 24);
            this.label17.TabIndex = 0;
            this.label17.Text = "Date RDV :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(405, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 24);
            this.label18.TabIndex = 0;
            this.label18.Text = "Heure RDV :";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            this.groupBox4.Controls.Add(this.cb_pat_add);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.rd_f_add);
            this.groupBox4.Controls.Add(this.rd_m_add);
            this.groupBox4.Controls.Add(this.txt_nomp_add);
            this.groupBox4.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.groupBox4.Location = new System.Drawing.Point(0, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(402, 179);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PATIENT :";
            // 
            // cb_pat_add
            // 
            this.cb_pat_add.FormattingEnabled = true;
            this.cb_pat_add.Location = new System.Drawing.Point(161, 31);
            this.cb_pat_add.Name = "cb_pat_add";
            this.cb_pat_add.Size = new System.Drawing.Size(196, 32);
            this.cb_pat_add.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(11, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Code Patient :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(15, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nom Patient :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(66, 128);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 24);
            this.label19.TabIndex = 0;
            this.label19.Text = "Sexe  :";
            // 
            // rd_f_add
            // 
            this.rd_f_add.AutoSize = true;
            this.rd_f_add.Enabled = false;
            this.rd_f_add.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.rd_f_add.Location = new System.Drawing.Point(292, 126);
            this.rd_f_add.Name = "rd_f_add";
            this.rd_f_add.Size = new System.Drawing.Size(39, 28);
            this.rd_f_add.TabIndex = 20;
            this.rd_f_add.TabStop = true;
            this.rd_f_add.Text = "F";
            this.rd_f_add.UseVisualStyleBackColor = true;
            // 
            // rd_m_add
            // 
            this.rd_m_add.AutoSize = true;
            this.rd_m_add.Enabled = false;
            this.rd_m_add.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.rd_m_add.Location = new System.Drawing.Point(161, 126);
            this.rd_m_add.Name = "rd_m_add";
            this.rd_m_add.Size = new System.Drawing.Size(44, 28);
            this.rd_m_add.TabIndex = 19;
            this.rd_m_add.Text = "M";
            this.rd_m_add.UseVisualStyleBackColor = true;
            // 
            // txt_nomp_add
            // 
            this.txt_nomp_add.Enabled = false;
            this.txt_nomp_add.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txt_nomp_add.Location = new System.Drawing.Point(161, 77);
            this.txt_nomp_add.Name = "txt_nomp_add";
            this.txt_nomp_add.Size = new System.Drawing.Size(196, 32);
            this.txt_nomp_add.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            this.groupBox2.Controls.Add(this.cb_med_add);
            this.groupBox2.Controls.Add(this.txt_sepci_add);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_nomm_add);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.groupBox2.Location = new System.Drawing.Point(444, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 179);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MEDECIN :";
            // 
            // cb_med_add
            // 
            this.cb_med_add.FormattingEnabled = true;
            this.cb_med_add.Location = new System.Drawing.Point(160, 31);
            this.cb_med_add.Name = "cb_med_add";
            this.cb_med_add.Size = new System.Drawing.Size(196, 32);
            this.cb_med_add.TabIndex = 25;
            // 
            // txt_sepci_add
            // 
            this.txt_sepci_add.Enabled = false;
            this.txt_sepci_add.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txt_sepci_add.Location = new System.Drawing.Point(160, 125);
            this.txt_sepci_add.Name = "txt_sepci_add";
            this.txt_sepci_add.Size = new System.Drawing.Size(196, 32);
            this.txt_sepci_add.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(10, 34);
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
            this.label7.Location = new System.Drawing.Point(14, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nom Medecin :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(39, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Specialite  :";
            // 
            // txt_nomm_add
            // 
            this.txt_nomm_add.Enabled = false;
            this.txt_nomm_add.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txt_nomm_add.Location = new System.Drawing.Point(160, 78);
            this.txt_nomm_add.Name = "txt_nomm_add";
            this.txt_nomm_add.Size = new System.Drawing.Size(196, 32);
            this.txt_nomm_add.TabIndex = 8;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(361, 326);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(137, 36);
            this.btn_add.TabIndex = 28;
            this.btn_add.Text = "AJOUTER";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tab_modify
            // 
            this.tab_modify.Controls.Add(this.groupBox3);
            this.tab_modify.Controls.Add(this.grid_mod);
            this.tab_modify.Controls.Add(this.groupBox1);
            this.tab_modify.HorizontalScrollbarBarColor = true;
            this.tab_modify.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_modify.HorizontalScrollbarSize = 10;
            this.tab_modify.Location = new System.Drawing.Point(4, 38);
            this.tab_modify.Name = "tab_modify";
            this.tab_modify.Size = new System.Drawing.Size(851, 466);
            this.tab_modify.TabIndex = 1;
            this.tab_modify.Text = "Modifier/Suprimer";
            this.tab_modify.VerticalScrollbarBarColor = true;
            this.tab_modify.VerticalScrollbarHighlightOnWheel = false;
            this.tab_modify.VerticalScrollbarSize = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_save);
            this.groupBox3.Controls.Add(this.cb_med_mod);
            this.groupBox3.Controls.Add(this.txt_heure_mod);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.dt_date_mod);
            this.groupBox3.Controls.Add(this.txt_code_mod);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.groupBox3.Location = new System.Drawing.Point(3, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(845, 122);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RDV :";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(650, 66);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(137, 36);
            this.btn_delete.TabIndex = 37;
            this.btn_delete.Text = "SUPRIMER";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(650, 25);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(137, 36);
            this.btn_save.TabIndex = 36;
            this.btn_save.Text = "ENREGISTRER";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cb_med_mod
            // 
            this.cb_med_mod.FormattingEnabled = true;
            this.cb_med_mod.Location = new System.Drawing.Point(443, 69);
            this.cb_med_mod.Name = "cb_med_mod";
            this.cb_med_mod.Size = new System.Drawing.Size(177, 32);
            this.cb_med_mod.TabIndex = 24;
            // 
            // txt_heure_mod
            // 
            this.txt_heure_mod.Location = new System.Drawing.Point(443, 28);
            this.txt_heure_mod.Mask = "00:00";
            this.txt_heure_mod.Name = "txt_heure_mod";
            this.txt_heure_mod.Size = new System.Drawing.Size(177, 32);
            this.txt_heure_mod.TabIndex = 25;
            this.txt_heure_mod.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Code RDV :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Date RDV :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(323, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Heure RDV :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(306, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "Nom Medecin :";
            // 
            // dt_date_mod
            // 
            this.dt_date_mod.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.dt_date_mod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_date_mod.Location = new System.Drawing.Point(117, 69);
            this.dt_date_mod.Name = "dt_date_mod";
            this.dt_date_mod.Size = new System.Drawing.Size(172, 32);
            this.dt_date_mod.TabIndex = 22;
            // 
            // txt_code_mod
            // 
            this.txt_code_mod.Enabled = false;
            this.txt_code_mod.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txt_code_mod.Location = new System.Drawing.Point(117, 31);
            this.txt_code_mod.Name = "txt_code_mod";
            this.txt_code_mod.Size = new System.Drawing.Size(172, 32);
            this.txt_code_mod.TabIndex = 8;
            // 
            // grid_mod
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grid_mod.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_mod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_mod.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            this.grid_mod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_mod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_mod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_mod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_mod.DoubleBuffered = true;
            this.grid_mod.EnableHeadersVisualStyles = false;
            this.grid_mod.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(160)))), ((int)(((byte)(171)))));
            this.grid_mod.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.grid_mod.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.grid_mod.Location = new System.Drawing.Point(3, 130);
            this.grid_mod.Name = "grid_mod";
            this.grid_mod.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid_mod.Size = new System.Drawing.Size(845, 205);
            this.grid_mod.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            this.groupBox1.Controls.Add(this.cb_pat_mod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dt_dateN_mod);
            this.groupBox1.Controls.Add(this.rb_f_mod);
            this.groupBox1.Controls.Add(this.rb_m_mod);
            this.groupBox1.Controls.Add(this.txt_pat_mod);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.groupBox1.Location = new System.Drawing.Point(3, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 111);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHOISIR UN PATIENT :";
            // 
            // cb_pat_mod
            // 
            this.cb_pat_mod.FormattingEnabled = true;
            this.cb_pat_mod.Location = new System.Drawing.Point(134, 31);
            this.cb_pat_mod.Name = "cb_pat_mod";
            this.cb_pat_mod.Size = new System.Drawing.Size(191, 32);
            this.cb_pat_mod.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Patient :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom Patient :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(379, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date De Naissance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(486, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sexe  :";
            // 
            // dt_dateN_mod
            // 
            this.dt_dateN_mod.Enabled = false;
            this.dt_dateN_mod.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.dt_dateN_mod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_dateN_mod.Location = new System.Drawing.Point(560, 28);
            this.dt_dateN_mod.Name = "dt_dateN_mod";
            this.dt_dateN_mod.Size = new System.Drawing.Size(191, 32);
            this.dt_dateN_mod.TabIndex = 22;
            // 
            // rb_f_mod
            // 
            this.rb_f_mod.AutoSize = true;
            this.rb_f_mod.Enabled = false;
            this.rb_f_mod.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.rb_f_mod.Location = new System.Drawing.Point(683, 70);
            this.rb_f_mod.Name = "rb_f_mod";
            this.rb_f_mod.Size = new System.Drawing.Size(39, 28);
            this.rb_f_mod.TabIndex = 20;
            this.rb_f_mod.TabStop = true;
            this.rb_f_mod.Text = "F";
            this.rb_f_mod.UseVisualStyleBackColor = true;
            // 
            // rb_m_mod
            // 
            this.rb_m_mod.AutoSize = true;
            this.rb_m_mod.Enabled = false;
            this.rb_m_mod.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.rb_m_mod.Location = new System.Drawing.Point(576, 70);
            this.rb_m_mod.Name = "rb_m_mod";
            this.rb_m_mod.Size = new System.Drawing.Size(44, 28);
            this.rb_m_mod.TabIndex = 19;
            this.rb_m_mod.Text = "M";
            this.rb_m_mod.UseVisualStyleBackColor = true;
            // 
            // txt_pat_mod
            // 
            this.txt_pat_mod.Enabled = false;
            this.txt_pat_mod.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.txt_pat_mod.Location = new System.Drawing.Point(134, 69);
            this.txt_pat_mod.Name = "txt_pat_mod";
            this.txt_pat_mod.Size = new System.Drawing.Size(191, 32);
            this.txt_pat_mod.TabIndex = 8;
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
            this.tab_grid.Size = new System.Drawing.Size(851, 466);
            this.tab_grid.TabIndex = 3;
            this.tab_grid.Text = "Affaicher Tout";
            this.tab_grid.VerticalScrollbarBarColor = true;
            this.tab_grid.VerticalScrollbarHighlightOnWheel = false;
            this.tab_grid.VerticalScrollbarSize = 10;
            // 
            // Grid
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.DoubleBuffered = true;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(160)))), ((int)(((byte)(171)))));
            this.Grid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.Grid.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.Grid.Location = new System.Drawing.Point(6, 19);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Grid.Size = new System.Drawing.Size(840, 435);
            this.Grid.TabIndex = 31;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel13.Controls.Add(this.label14);
            this.panel13.Location = new System.Drawing.Point(23, 40);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(855, 44);
            this.panel13.TabIndex = 59;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(5, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(217, 33);
            this.label14.TabIndex = 40;
            this.label14.Text = "Gestion Des RDV :";
            // 
            // RDV_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 606);
            this.Controls.Add(this.tab_rdv);
            this.Controls.Add(this.panel13);
            this.Name = "RDV_frm";
            this.Load += new System.EventHandler(this.RDV_frm_Load);
            this.tab_rdv.ResumeLayout(false);
            this.tab_add.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tab_modify.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_mod)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tab_rdv;
        private MetroFramework.Controls.MetroTabPage tab_add;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_nomm_add;
        private System.Windows.Forms.Button btn_add;
        private MetroFramework.Controls.MetroTabPage tab_modify;
        private MetroFramework.Controls.MetroTabPage tab_grid;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Grid;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_sepci_add;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton rd_f_add;
        private System.Windows.Forms.RadioButton rd_m_add;
        private System.Windows.Forms.TextBox txt_nomp_add;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox txt_heure_add;
        private System.Windows.Forms.DateTimePicker dt_date_add;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox cb_med_mod;
        private System.Windows.Forms.MaskedTextBox txt_heure_mod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dt_date_mod;
        private System.Windows.Forms.TextBox txt_code_mod;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grid_mod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_pat_mod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_dateN_mod;
        private System.Windows.Forms.RadioButton rb_f_mod;
        private System.Windows.Forms.RadioButton rb_m_mod;
        private System.Windows.Forms.TextBox txt_pat_mod;
        private System.Windows.Forms.ComboBox cb_pat_add;
        private System.Windows.Forms.ComboBox cb_med_add;
    }
}