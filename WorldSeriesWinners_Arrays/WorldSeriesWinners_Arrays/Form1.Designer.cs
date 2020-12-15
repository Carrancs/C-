namespace WorldSeriesWinners_Arrays
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
            this.label1 = new System.Windows.Forms.Label();
            this.findOutBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.teamsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select one of the teams in the list below \r\nand find out how many times it has wo" +
    "n\r\n the World Series between 1903 and 2012";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // findOutBtn
            // 
            this.findOutBtn.Location = new System.Drawing.Point(24, 312);
            this.findOutBtn.Name = "findOutBtn";
            this.findOutBtn.Size = new System.Drawing.Size(108, 34);
            this.findOutBtn.TabIndex = 4;
            this.findOutBtn.Text = "Find Out!";
            this.findOutBtn.UseVisualStyleBackColor = true;
            this.findOutBtn.Click += new System.EventHandler(this.findOutBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(187, 312);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(108, 34);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Close";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // teamsListBox
            // 
            this.teamsListBox.FormattingEnabled = true;
            this.teamsListBox.Location = new System.Drawing.Point(50, 75);
            this.teamsListBox.Name = "teamsListBox";
            this.teamsListBox.Size = new System.Drawing.Size(208, 212);
            this.teamsListBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 358);
            this.Controls.Add(this.teamsListBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.findOutBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "World Series Winners";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findOutBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ListBox teamsListBox;
    }
}

