namespace AdminApplication
{
    partial class editproject
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
            this.cbcust = new System.Windows.Forms.ComboBox();
            this.btnaddproject = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textend = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textstart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbcust
            // 
            this.cbcust.FormattingEnabled = true;
            this.cbcust.Location = new System.Drawing.Point(374, 207);
            this.cbcust.Name = "cbcust";
            this.cbcust.Size = new System.Drawing.Size(284, 33);
            this.cbcust.TabIndex = 27;
            // 
            // btnaddproject
            // 
            this.btnaddproject.BackColor = System.Drawing.Color.Teal;
            this.btnaddproject.FlatAppearance.BorderSize = 0;
            this.btnaddproject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddproject.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnaddproject.ForeColor = System.Drawing.Color.White;
            this.btnaddproject.Location = new System.Drawing.Point(24, 310);
            this.btnaddproject.Name = "btnaddproject";
            this.btnaddproject.Size = new System.Drawing.Size(263, 62);
            this.btnaddproject.TabIndex = 26;
            this.btnaddproject.Text = "Edit Project";
            this.btnaddproject.UseVisualStyleBackColor = false;
            this.btnaddproject.Click += new System.EventHandler(this.btnaddproject_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Customer:";
            // 
            // textend
            // 
            this.textend.Location = new System.Drawing.Point(12, 207);
            this.textend.Multiline = true;
            this.textend.Name = "textend";
            this.textend.Size = new System.Drawing.Size(275, 46);
            this.textend.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Expected End :";
            // 
            // textstart
            // 
            this.textstart.Location = new System.Drawing.Point(374, 81);
            this.textstart.Multiline = true;
            this.textstart.Name = "textstart";
            this.textstart.Size = new System.Drawing.Size(275, 46);
            this.textstart.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Expected Start :";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(24, 81);
            this.textname.Multiline = true;
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(275, 46);
            this.textname.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Project Name :";
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Crimson;
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncancel.ForeColor = System.Drawing.Color.Black;
            this.btncancel.Location = new System.Drawing.Point(374, 310);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(258, 62);
            this.btncancel.TabIndex = 28;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // editproject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 402);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.cbcust);
            this.Controls.Add(this.btnaddproject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textstart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.label1);
            this.Name = "editproject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editproject";
            this.Load += new System.EventHandler(this.editproject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbcust;
        private Button btnaddproject;
        private Label label4;
        private TextBox textend;
        private Label label3;
        private TextBox textstart;
        private Label label2;
        private TextBox textname;
        private Label label1;
        private Button btncancel;
    }
}