namespace AdminApplication
{
    partial class AddProject
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbcust = new System.Windows.Forms.ComboBox();
            this.btnaddproject = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textend = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textstart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelcustomer = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonedit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbProjects = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 482);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbcust);
            this.tabPage1.Controls.Add(this.btnaddproject);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textend);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textstart);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textname);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(746, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbcust
            // 
            this.cbcust.FormattingEnabled = true;
            this.cbcust.Location = new System.Drawing.Point(409, 232);
            this.cbcust.Name = "cbcust";
            this.cbcust.Size = new System.Drawing.Size(284, 33);
            this.cbcust.TabIndex = 18;
            // 
            // btnaddproject
            // 
            this.btnaddproject.BackColor = System.Drawing.Color.Teal;
            this.btnaddproject.FlatAppearance.BorderSize = 0;
            this.btnaddproject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddproject.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnaddproject.ForeColor = System.Drawing.Color.White;
            this.btnaddproject.Location = new System.Drawing.Point(211, 328);
            this.btnaddproject.Name = "btnaddproject";
            this.btnaddproject.Size = new System.Drawing.Size(329, 62);
            this.btnaddproject.TabIndex = 17;
            this.btnaddproject.Text = "Add Project";
            this.btnaddproject.UseVisualStyleBackColor = false;
            this.btnaddproject.Click += new System.EventHandler(this.btnaddproject_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Customer:";
            // 
            // textend
            // 
            this.textend.Location = new System.Drawing.Point(54, 218);
            this.textend.Multiline = true;
            this.textend.Name = "textend";
            this.textend.Size = new System.Drawing.Size(275, 46);
            this.textend.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Expected End :";
            // 
            // textstart
            // 
            this.textstart.Location = new System.Drawing.Point(409, 93);
            this.textstart.Multiline = true;
            this.textstart.Name = "textstart";
            this.textstart.Size = new System.Drawing.Size(275, 46);
            this.textstart.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Expected Start :";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(63, 93);
            this.textname.Multiline = true;
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(275, 46);
            this.textname.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Project Name :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelcustomer);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.lblEndDate);
            this.tabPage2.Controls.Add(this.lblStartDate);
            this.tabPage2.Controls.Add(this.buttondelete);
            this.tabPage2.Controls.Add(this.buttonedit);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbProjects);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "projects";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelcustomer
            // 
            this.labelcustomer.AutoSize = true;
            this.labelcustomer.Location = new System.Drawing.Point(277, 282);
            this.labelcustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcustomer.Name = "labelcustomer";
            this.labelcustomer.Size = new System.Drawing.Size(0, 25);
            this.labelcustomer.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(96, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Customer :";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(299, 228);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(0, 25);
            this.lblEndDate.TabIndex = 20;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(299, 162);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(0, 25);
            this.lblStartDate.TabIndex = 19;
            // 
            // buttondelete
            // 
            this.buttondelete.BackColor = System.Drawing.Color.Red;
            this.buttondelete.FlatAppearance.BorderSize = 0;
            this.buttondelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttondelete.ForeColor = System.Drawing.Color.White;
            this.buttondelete.Location = new System.Drawing.Point(561, 338);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(119, 53);
            this.buttondelete.TabIndex = 18;
            this.buttondelete.Text = "DELETE";
            this.buttondelete.UseVisualStyleBackColor = false;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonedit
            // 
            this.buttonedit.BackColor = System.Drawing.Color.Teal;
            this.buttonedit.FlatAppearance.BorderSize = 0;
            this.buttonedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonedit.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonedit.ForeColor = System.Drawing.Color.White;
            this.buttonedit.Location = new System.Drawing.Point(139, 338);
            this.buttonedit.Name = "buttonedit";
            this.buttonedit.Size = new System.Drawing.Size(119, 53);
            this.buttonedit.TabIndex = 17;
            this.buttonedit.Text = "EDIT";
            this.buttonedit.UseVisualStyleBackColor = false;
            this.buttonedit.Click += new System.EventHandler(this.buttonedit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Expected end date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Expected start date :";
            // 
            // cbProjects
            // 
            this.cbProjects.FormattingEnabled = true;
            this.cbProjects.Location = new System.Drawing.Point(260, 87);
            this.cbProjects.Name = "cbProjects";
            this.cbProjects.Size = new System.Drawing.Size(441, 33);
            this.cbProjects.TabIndex = 13;
            this.cbProjects.SelectedIndexChanged += new System.EventHandler(this.cbProjects_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(96, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "EXISTING PROJECTS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Select project :";
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "AddProject";
            this.Size = new System.Drawing.Size(780, 508);
            this.Load += new System.EventHandler(this.AddProject_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ComboBox cbProjects;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ComboBox cbCustomer;
        private Button btnaddproject;
        private Label label4;
        private TextBox textend;
        private Label label3;
        private TextBox textstart;
        private Label label2;
        private TextBox textname;
        private Label label1;
        private TabPage tabPage2;
        private ComboBox cbcust;
        private TextBox textBox1;
        private Button buttondelete;
        private Button buttonedit;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lblEndDate;
        private Label lblStartDate;
        private Label label9;
        private Label labelcustomer;
    }
}
