namespace Week02
{
    partial class Week02
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnTennis = new System.Windows.Forms.Button();
            this.btnFootball = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(13, 120);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 17);
            this.lblOutput.TabIndex = 0;
            // 
            // btnTennis
            // 
            this.btnTennis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTennis.Location = new System.Drawing.Point(18, 59);
            this.btnTennis.Name = "btnTennis";
            this.btnTennis.Size = new System.Drawing.Size(114, 37);
            this.btnTennis.TabIndex = 1;
            this.btnTennis.Text = "Tennis";
            this.btnTennis.UseVisualStyleBackColor = true;
            this.btnTennis.Click += new System.EventHandler(this.btnTennis_Click);
            // 
            // btnFootball
            // 
            this.btnFootball.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFootball.Location = new System.Drawing.Point(156, 59);
            this.btnFootball.Name = "btnFootball";
            this.btnFootball.Size = new System.Drawing.Size(125, 37);
            this.btnFootball.TabIndex = 2;
            this.btnFootball.Text = "Football";
            this.btnFootball.UseVisualStyleBackColor = true;
            this.btnFootball.Click += new System.EventHandler(this.btnFootball_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(268, 29);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Please Select A Sport";
            // 
            // Week02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 375);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnFootball);
            this.Controls.Add(this.btnTennis);
            this.Controls.Add(this.lblOutput);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Week02";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnTennis;
        private System.Windows.Forms.Button btnFootball;
        private System.Windows.Forms.Label lblTitle;

    }
}

