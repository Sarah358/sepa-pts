namespace AdminApplication
{
    partial class deleteproject
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
            this.btncancel = new System.Windows.Forms.Button();
            this.btndeleteproject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncancel.ForeColor = System.Drawing.Color.Black;
            this.btncancel.Location = new System.Drawing.Point(58, 276);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(258, 62);
            this.btncancel.TabIndex = 38;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btndeleteproject
            // 
            this.btndeleteproject.BackColor = System.Drawing.Color.Crimson;
            this.btndeleteproject.FlatAppearance.BorderSize = 0;
            this.btndeleteproject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeleteproject.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndeleteproject.ForeColor = System.Drawing.Color.White;
            this.btndeleteproject.Location = new System.Drawing.Point(53, 158);
            this.btndeleteproject.Name = "btndeleteproject";
            this.btndeleteproject.Size = new System.Drawing.Size(263, 62);
            this.btndeleteproject.TabIndex = 36;
            this.btndeleteproject.Text = "Delete Project";
            this.btndeleteproject.UseVisualStyleBackColor = false;
            this.btndeleteproject.Click += new System.EventHandler(this.btndeleteproject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "Are you sure you want ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(105, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 30);
            this.label2.TabIndex = 39;
            this.label2.Text = "to delete this project ?";
            // 
            // deleteproject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 408);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndeleteproject);
            this.Controls.Add(this.label1);
            this.Name = "deleteproject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "deleteproject";
            this.Load += new System.EventHandler(this.deleteproject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btncancel;
        private Button btndeleteproject;
        private Label label1;
        private Label label2;
    }
}