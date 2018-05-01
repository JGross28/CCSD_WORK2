namespace Week_1
{
    partial class MainWindow
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
            this.m_lbl_First_Name = new System.Windows.Forms.Label();
            this.m_tb_First_Name = new System.Windows.Forms.TextBox();
            this.m_btn_ClickMe = new System.Windows.Forms.Button();
            this.m_lbl_feedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_lbl_First_Name
            // 
            this.m_lbl_First_Name.AutoSize = true;
            this.m_lbl_First_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_First_Name.Location = new System.Drawing.Point(14, 28);
            this.m_lbl_First_Name.Name = "m_lbl_First_Name";
            this.m_lbl_First_Name.Size = new System.Drawing.Size(157, 31);
            this.m_lbl_First_Name.TabIndex = 0;
            this.m_lbl_First_Name.Text = "First Name";
            // 
            // m_tb_First_Name
            // 
            this.m_tb_First_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_tb_First_Name.Location = new System.Drawing.Point(177, 21);
            this.m_tb_First_Name.Name = "m_tb_First_Name";
            this.m_tb_First_Name.Size = new System.Drawing.Size(193, 38);
            this.m_tb_First_Name.TabIndex = 1;
            // 
            // m_btn_ClickMe
            // 
            this.m_btn_ClickMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_ClickMe.Location = new System.Drawing.Point(20, 71);
            this.m_btn_ClickMe.Name = "m_btn_ClickMe";
            this.m_btn_ClickMe.Size = new System.Drawing.Size(151, 50);
            this.m_btn_ClickMe.TabIndex = 2;
            this.m_btn_ClickMe.Text = "Click Me";
            this.m_btn_ClickMe.UseVisualStyleBackColor = true;
            this.m_btn_ClickMe.Click += new System.EventHandler(this.m_btn_ClickMe_Click);
            // 
            // m_lbl_feedback
            // 
            this.m_lbl_feedback.AutoSize = true;
            this.m_lbl_feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_feedback.Location = new System.Drawing.Point(20, 227);
            this.m_lbl_feedback.Name = "m_lbl_feedback";
            this.m_lbl_feedback.Size = new System.Drawing.Size(0, 31);
            this.m_lbl_feedback.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 795);
            this.Controls.Add(this.m_lbl_feedback);
            this.Controls.Add(this.m_btn_ClickMe);
            this.Controls.Add(this.m_tb_First_Name);
            this.Controls.Add(this.m_lbl_First_Name);
            this.Name = "MainWindow";
            this.Text = "My First Windows GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_lbl_First_Name;
        private System.Windows.Forms.TextBox m_tb_First_Name;
        private System.Windows.Forms.Button m_btn_ClickMe;
        private System.Windows.Forms.Label m_lbl_feedback;
    }
}

