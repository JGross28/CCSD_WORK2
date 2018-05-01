namespace Week_1
{
    partial class Assignment1
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
            this.m_tb1stInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_tb2ndInput = new System.Windows.Forms.TextBox();
            this.m_btnAdd = new System.Windows.Forms.Button();
            this.m_btnMultiply = new System.Windows.Forms.Button();
            this.m_lblFeedback = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearEntriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "1st Input";
            // 
            // m_tb1stInput
            // 
            this.m_tb1stInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_tb1stInput.Location = new System.Drawing.Point(160, 102);
            this.m_tb1stInput.Name = "m_tb1stInput";
            this.m_tb1stInput.Size = new System.Drawing.Size(149, 38);
            this.m_tb1stInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "2nd Input";
            // 
            // m_tb2ndInput
            // 
            this.m_tb2ndInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_tb2ndInput.Location = new System.Drawing.Point(160, 171);
            this.m_tb2ndInput.Name = "m_tb2ndInput";
            this.m_tb2ndInput.Size = new System.Drawing.Size(149, 38);
            this.m_tb2ndInput.TabIndex = 3;
            // 
            // m_btnAdd
            // 
            this.m_btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnAdd.Location = new System.Drawing.Point(24, 232);
            this.m_btnAdd.Name = "m_btnAdd";
            this.m_btnAdd.Size = new System.Drawing.Size(96, 39);
            this.m_btnAdd.TabIndex = 4;
            this.m_btnAdd.Text = "+";
            this.m_btnAdd.UseVisualStyleBackColor = true;
            this.m_btnAdd.Click += new System.EventHandler(this.m_btnAdd_Click);
            // 
            // m_btnMultiply
            // 
            this.m_btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnMultiply.Location = new System.Drawing.Point(154, 232);
            this.m_btnMultiply.Name = "m_btnMultiply";
            this.m_btnMultiply.Size = new System.Drawing.Size(96, 39);
            this.m_btnMultiply.TabIndex = 5;
            this.m_btnMultiply.Text = "X";
            this.m_btnMultiply.UseVisualStyleBackColor = true;
            this.m_btnMultiply.Click += new System.EventHandler(this.m_btnMultiply_Click);
            // 
            // m_lblFeedback
            // 
            this.m_lblFeedback.AutoSize = true;
            this.m_lblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblFeedback.Location = new System.Drawing.Point(18, 324);
            this.m_lblFeedback.Name = "m_lblFeedback";
            this.m_lblFeedback.Size = new System.Drawing.Size(0, 31);
            this.m_lblFeedback.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(453, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearEntriesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearEntriesToolStripMenuItem
            // 
            this.clearEntriesToolStripMenuItem.Name = "clearEntriesToolStripMenuItem";
            this.clearEntriesToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.clearEntriesToolStripMenuItem.Text = "Clear Entries";
            this.clearEntriesToolStripMenuItem.Click += new System.EventHandler(this.Clear_Entries);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit_Application);
            // 
            // Assignment1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 617);
            this.Controls.Add(this.m_lblFeedback);
            this.Controls.Add(this.m_btnMultiply);
            this.Controls.Add(this.m_btnAdd);
            this.Controls.Add(this.m_tb2ndInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_tb1stInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Assignment1";
            this.Text = "Assignment1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_tb1stInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_tb2ndInput;
        private System.Windows.Forms.Button m_btnAdd;
        private System.Windows.Forms.Button m_btnMultiply;
        private System.Windows.Forms.Label m_lblFeedback;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearEntriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}