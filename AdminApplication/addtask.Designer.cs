namespace AdminApplication
{
    partial class addtask
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newtask = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbprojects = new System.Windows.Forms.ComboBox();
            this.cbteam = new System.Windows.Forms.ComboBox();
            this.btnaddtask = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textend2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textstart2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cbtasks = new System.Windows.Forms.ComboBox();
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.newtask.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // newtask
            // 
            this.newtask.Controls.Add(this.tabPage1);
            this.newtask.Controls.Add(this.tabPage2);
            this.newtask.Location = new System.Drawing.Point(16, 19);
            this.newtask.Name = "newtask";
            this.newtask.SelectedIndex = 0;
            this.newtask.Size = new System.Drawing.Size(721, 479);
            this.newtask.TabIndex = 0;
            this.newtask.Selected += new System.Windows.Forms.TabControlEventHandler(this.newtask_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textname);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cbprojects);
            this.tabPage1.Controls.Add(this.cbteam);
            this.tabPage1.Controls.Add(this.btnaddtask);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textend2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textstart2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(713, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(366, 67);
            this.textname.Multiline = true;
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(275, 46);
            this.textname.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Name :";
            // 
            // cbprojects
            // 
            this.cbprojects.FormattingEnabled = true;
            this.cbprojects.Location = new System.Drawing.Point(18, 80);
            this.cbprojects.Name = "cbprojects";
            this.cbprojects.Size = new System.Drawing.Size(266, 33);
            this.cbprojects.TabIndex = 28;
            this.cbprojects.SelectedIndexChanged += new System.EventHandler(this.cbprojects_SelectedIndexChanged);
            // 
            // cbteam
            // 
            this.cbteam.FormattingEnabled = true;
            this.cbteam.Location = new System.Drawing.Point(200, 288);
            this.cbteam.Name = "cbteam";
            this.cbteam.Size = new System.Drawing.Size(284, 33);
            this.cbteam.TabIndex = 27;
            this.cbteam.SelectedIndexChanged += new System.EventHandler(this.cbteam_SelectedIndexChanged);
            // 
            // btnaddtask
            // 
            this.btnaddtask.BackColor = System.Drawing.Color.Teal;
            this.btnaddtask.FlatAppearance.BorderSize = 0;
            this.btnaddtask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddtask.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnaddtask.ForeColor = System.Drawing.Color.White;
            this.btnaddtask.Location = new System.Drawing.Point(181, 373);
            this.btnaddtask.Name = "btnaddtask";
            this.btnaddtask.Size = new System.Drawing.Size(328, 62);
            this.btnaddtask.TabIndex = 26;
            this.btnaddtask.Text = "Add Task";
            this.btnaddtask.UseVisualStyleBackColor = false;
            this.btnaddtask.Click += new System.EventHandler(this.btnaddtask_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Team:";
            // 
            // textend2
            // 
            this.textend2.Location = new System.Drawing.Point(382, 189);
            this.textend2.Multiline = true;
            this.textend2.Name = "textend2";
            this.textend2.Size = new System.Drawing.Size(275, 46);
            this.textend2.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Expected End :";
            // 
            // textstart2
            // 
            this.textstart2.Location = new System.Drawing.Point(18, 189);
            this.textstart2.Multiline = true;
            this.textstart2.Name = "textstart2";
            this.textstart2.Size = new System.Drawing.Size(275, 46);
            this.textstart2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Expected Start :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Select Project :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbtasks);
            this.tabPage2.Controls.Add(this.cbProject);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(713, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tasks";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Tasks : ";
            // 
            // cbtasks
            // 
            this.cbtasks.FormattingEnabled = true;
            this.cbtasks.Location = new System.Drawing.Point(105, 177);
            this.cbtasks.Name = "cbtasks";
            this.cbtasks.Size = new System.Drawing.Size(458, 33);
            this.cbtasks.TabIndex = 31;
            // 
            // cbProject
            // 
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Location = new System.Drawing.Point(105, 68);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(472, 33);
            this.cbProject.TabIndex = 30;
            this.cbProject.SelectedIndexChanged += new System.EventHandler(this.comboBoxprojects_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Select Project :";
            // 
            // addtask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newtask);
            this.Name = "addtask";
            this.Size = new System.Drawing.Size(756, 501);
            this.Load += new System.EventHandler(this.addtask_Load);
            this.newtask.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl newtask;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox cbteam;
        private Button btnaddtask;
        private Label label4;
        private TextBox textend2;
        private Label label3;
        private TextBox textstart2;
        private Label label2;
        private Label label1;
        private ComboBox cbprojects;
        private TextBox textname;
        private Label label5;
        private ComboBox cbProject;
        private Label label6;
        private Label label7;
        private ComboBox cbtasks;
    }
}
