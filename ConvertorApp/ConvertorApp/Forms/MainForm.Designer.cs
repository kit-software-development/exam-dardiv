namespace ConvertorApp
{
    partial class MainForm
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
            this.xLabel = new System.Windows.Forms.Label();
            this.xTextbox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.serverLabel = new System.Windows.Forms.Label();
            this.serverTextbox = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yLabel = new System.Windows.Forms.Label();
            this.yTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xLabel.Location = new System.Drawing.Point(42, 90);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(24, 20);
            this.xLabel.TabIndex = 0;
            this.xLabel.Text = "X:";
            // 
            // xTextbox
            // 
            this.xTextbox.Location = new System.Drawing.Point(82, 90);
            this.xTextbox.Multiline = true;
            this.xTextbox.Name = "xTextbox";
            this.xTextbox.Size = new System.Drawing.Size(327, 19);
            this.xTextbox.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(143, 237);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(138, 23);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Calculate";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.OnSend);
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serverLabel.Location = new System.Drawing.Point(43, 188);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(117, 18);
            this.serverLabel.TabIndex = 4;
            this.serverLabel.Text = "Spearman\'s rho:";
            // 
            // serverTextbox
            // 
            this.serverTextbox.Location = new System.Drawing.Point(166, 189);
            this.serverTextbox.Multiline = true;
            this.serverTextbox.Name = "serverTextbox";
            this.serverTextbox.ReadOnly = true;
            this.serverTextbox.Size = new System.Drawing.Size(243, 19);
            this.serverTextbox.TabIndex = 5;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem,
            this.historyMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(437, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(111, 20);
            this.aboutMenuItem.Text = "About coefficient";
            this.aboutMenuItem.Click += new System.EventHandler(this.OnAbout);
            // 
            // historyMenuItem
            // 
            this.historyMenuItem.Name = "historyMenuItem";
            this.historyMenuItem.Size = new System.Drawing.Size(121, 20);
            this.historyMenuItem.Text = "Recent calculations";
            this.historyMenuItem.Click += new System.EventHandler(this.OnArchive);
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yLabel.Location = new System.Drawing.Point(42, 139);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(24, 20);
            this.yLabel.TabIndex = 7;
            this.yLabel.Text = "Y:";
            // 
            // yTextbox
            // 
            this.yTextbox.Location = new System.Drawing.Point(82, 139);
            this.yTextbox.Name = "yTextbox";
            this.yTextbox.Size = new System.Drawing.Size(327, 20);
            this.yTextbox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnClear);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter numbers and separate them by comma, without spaces between them!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Please, remember that X and Y should contain equal amount of numbers!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 289);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yTextbox);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.serverTextbox);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.xTextbox);
            this.Controls.Add(this.xLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Spearman\'s rank correlation coefficient";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox xTextbox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.TextBox serverTextbox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem historyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.TextBox yTextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}