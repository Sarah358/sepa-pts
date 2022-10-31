namespace AdminApplication
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.menu = new System.Windows.Forms.Panel();
            this.buttonlogout = new System.Windows.Forms.Button();
            this.buttonusers = new System.Windows.Forms.Button();
            this.buttontasks = new System.Windows.Forms.Button();
            this.buttonprojects = new System.Windows.Forms.Button();
            this.buttonhome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonmaxed = new System.Windows.Forms.Button();
            this.buttonmin = new System.Windows.Forms.Button();
            this.buttonmax = new System.Windows.Forms.Button();
            this.buttonclose = new System.Windows.Forms.Button();
            this.panelhome = new System.Windows.Forms.Panel();
            this.labelhome = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.addProject1 = new AdminApplication.AddProject();
            this.menu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelhome.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.menu.Controls.Add(this.buttonlogout);
            this.menu.Controls.Add(this.buttonusers);
            this.menu.Controls.Add(this.buttontasks);
            this.menu.Controls.Add(this.buttonprojects);
            this.menu.Controls.Add(this.buttonhome);
            this.menu.Controls.Add(this.panel3);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.ForeColor = System.Drawing.Color.White;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(253, 650);
            this.menu.TabIndex = 0;
            // 
            // buttonlogout
            // 
            this.buttonlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.buttonlogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonlogout.FlatAppearance.BorderSize = 0;
            this.buttonlogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogout.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonlogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonlogout.Image")));
            this.buttonlogout.Location = new System.Drawing.Point(0, 547);
            this.buttonlogout.Name = "buttonlogout";
            this.buttonlogout.Size = new System.Drawing.Size(253, 76);
            this.buttonlogout.TabIndex = 5;
            this.buttonlogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonlogout.UseVisualStyleBackColor = false;
            this.buttonlogout.Click += new System.EventHandler(this.buttonlogout_Click);
            // 
            // buttonusers
            // 
            this.buttonusers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.buttonusers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonusers.FlatAppearance.BorderSize = 0;
            this.buttonusers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonusers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonusers.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonusers.Image = ((System.Drawing.Image)(resources.GetObject("buttonusers.Image")));
            this.buttonusers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonusers.Location = new System.Drawing.Point(0, 453);
            this.buttonusers.Name = "buttonusers";
            this.buttonusers.Size = new System.Drawing.Size(253, 94);
            this.buttonusers.TabIndex = 4;
            this.buttonusers.Text = "Manage Users";
            this.buttonusers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonusers.UseVisualStyleBackColor = false;
            this.buttonusers.Click += new System.EventHandler(this.buttonusers_Click);
            // 
            // buttontasks
            // 
            this.buttontasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.buttontasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttontasks.FlatAppearance.BorderSize = 0;
            this.buttontasks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttontasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttontasks.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttontasks.Image = global::AdminApplication.Properties.Resources.icons8_task_64;
            this.buttontasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttontasks.Location = new System.Drawing.Point(0, 355);
            this.buttontasks.Name = "buttontasks";
            this.buttontasks.Size = new System.Drawing.Size(253, 98);
            this.buttontasks.TabIndex = 3;
            this.buttontasks.Text = "Tasks";
            this.buttontasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttontasks.UseVisualStyleBackColor = false;
            this.buttontasks.Click += new System.EventHandler(this.buttontasks_Click);
            // 
            // buttonprojects
            // 
            this.buttonprojects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.buttonprojects.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonprojects.FlatAppearance.BorderSize = 0;
            this.buttonprojects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonprojects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonprojects.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonprojects.Image = global::AdminApplication.Properties.Resources.icons8_group_of_projects_48;
            this.buttonprojects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonprojects.Location = new System.Drawing.Point(0, 259);
            this.buttonprojects.Name = "buttonprojects";
            this.buttonprojects.Size = new System.Drawing.Size(253, 96);
            this.buttonprojects.TabIndex = 2;
            this.buttonprojects.Text = "Projects";
            this.buttonprojects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonprojects.UseVisualStyleBackColor = false;
            this.buttonprojects.Click += new System.EventHandler(this.buttonprojects_Click);
            // 
            // buttonhome
            // 
            this.buttonhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.buttonhome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonhome.FlatAppearance.BorderSize = 0;
            this.buttonhome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhome.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonhome.Image = ((System.Drawing.Image)(resources.GetObject("buttonhome.Image")));
            this.buttonhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonhome.Location = new System.Drawing.Point(0, 162);
            this.buttonhome.Name = "buttonhome";
            this.buttonhome.Size = new System.Drawing.Size(253, 97);
            this.buttonhome.TabIndex = 1;
            this.buttonhome.Text = "Home";
            this.buttonhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonhome.UseVisualStyleBackColor = false;
            this.buttonhome.Click += new System.EventHandler(this.buttonhome_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 162);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdminApplication.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(38, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.buttonmaxed);
            this.panel2.Controls.Add(this.buttonmin);
            this.panel2.Controls.Add(this.buttonmax);
            this.panel2.Controls.Add(this.buttonclose);
            this.panel2.Controls.Add(this.panelhome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(253, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 60);
            this.panel2.TabIndex = 1;
            // 
            // buttonmaxed
            // 
            this.buttonmaxed.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonmaxed.FlatAppearance.BorderSize = 0;
            this.buttonmaxed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonmaxed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmaxed.Image = ((System.Drawing.Image)(resources.GetObject("buttonmaxed.Image")));
            this.buttonmaxed.Location = new System.Drawing.Point(524, 0);
            this.buttonmaxed.Name = "buttonmaxed";
            this.buttonmaxed.Size = new System.Drawing.Size(51, 60);
            this.buttonmaxed.TabIndex = 6;
            this.buttonmaxed.UseVisualStyleBackColor = true;
            this.buttonmaxed.Visible = false;
            this.buttonmaxed.Click += new System.EventHandler(this.buttonmaxed_Click);
            // 
            // buttonmin
            // 
            this.buttonmin.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonmin.FlatAppearance.BorderSize = 0;
            this.buttonmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmin.Image = global::AdminApplication.Properties.Resources.icons8_minimize_window_48;
            this.buttonmin.Location = new System.Drawing.Point(575, 0);
            this.buttonmin.Name = "buttonmin";
            this.buttonmin.Size = new System.Drawing.Size(69, 60);
            this.buttonmin.TabIndex = 5;
            this.buttonmin.UseVisualStyleBackColor = true;
            this.buttonmin.Click += new System.EventHandler(this.buttonmin_Click);
            // 
            // buttonmax
            // 
            this.buttonmax.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonmax.FlatAppearance.BorderSize = 0;
            this.buttonmax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmax.Image = ((System.Drawing.Image)(resources.GetObject("buttonmax.Image")));
            this.buttonmax.Location = new System.Drawing.Point(644, 0);
            this.buttonmax.Name = "buttonmax";
            this.buttonmax.Size = new System.Drawing.Size(66, 60);
            this.buttonmax.TabIndex = 4;
            this.buttonmax.UseVisualStyleBackColor = true;
            this.buttonmax.Click += new System.EventHandler(this.buttonmax_Click);
            // 
            // buttonclose
            // 
            this.buttonclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonclose.FlatAppearance.BorderSize = 0;
            this.buttonclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonclose.Image = ((System.Drawing.Image)(resources.GetObject("buttonclose.Image")));
            this.buttonclose.Location = new System.Drawing.Point(710, 0);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(68, 60);
            this.buttonclose.TabIndex = 3;
            this.buttonclose.UseVisualStyleBackColor = true;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // panelhome
            // 
            this.panelhome.Controls.Add(this.labelhome);
            this.panelhome.Location = new System.Drawing.Point(61, 6);
            this.panelhome.Name = "panelhome";
            this.panelhome.Size = new System.Drawing.Size(300, 51);
            this.panelhome.TabIndex = 2;
            this.panelhome.Paint += new System.Windows.Forms.PaintEventHandler(this.panelhome_Paint);
            // 
            // labelhome
            // 
            this.labelhome.AutoSize = true;
            this.labelhome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelhome.ForeColor = System.Drawing.Color.White;
            this.labelhome.Location = new System.Drawing.Point(87, 6);
            this.labelhome.Name = "labelhome";
            this.labelhome.Size = new System.Drawing.Size(86, 32);
            this.labelhome.TabIndex = 0;
            this.labelhome.Text = "HOME";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.addProject1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(253, 60);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(778, 590);
            this.panelContainer.TabIndex = 2;
            // 
            // addProject1
            // 
            this.addProject1.Location = new System.Drawing.Point(0, 0);
            this.addProject1.Name = "addProject1";
            this.addProject1.Size = new System.Drawing.Size(1170, 764);
            this.addProject1.TabIndex = 0;
            this.addProject1.Load += new System.EventHandler(this.addProject1_Load);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1031, 650);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.menu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelhome.ResumeLayout(false);
            this.panelhome.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menu;
        private Button buttonusers;
        private Button buttontasks;
        private Button buttonprojects;
        private Button buttonhome;
        private Panel panel3;
        private BindingSource bindingSource1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button buttonmin;
        private Button buttonmax;
        private Button buttonclose;
        private Panel panelhome;
        private Label labelhome;
        private Button buttonlogout;
        private Button buttonmaxed;
        private Panel panelContainer;
        private AddProject addProject1;
    }
}