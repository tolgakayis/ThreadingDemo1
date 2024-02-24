namespace ThreadingDemo1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProcess1 = new System.Windows.Forms.Button();
            btnProcess2 = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            brownToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            brownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnProcess1
            // 
            btnProcess1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnProcess1.Location = new System.Drawing.Point(558, 215);
            btnProcess1.Name = "btnProcess1";
            btnProcess1.Size = new System.Drawing.Size(181, 74);
            btnProcess1.TabIndex = 0;
            btnProcess1.Text = "İşlem 1";
            btnProcess1.UseVisualStyleBackColor = true;
            btnProcess1.Click += btnProcess1_Click;
            // 
            // btnProcess2
            // 
            btnProcess2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnProcess2.Location = new System.Drawing.Point(208, 12);
            btnProcess2.Name = "btnProcess2";
            btnProcess2.Size = new System.Drawing.Size(181, 74);
            btnProcess2.TabIndex = 1;
            btnProcess2.Text = "İşlem 2";
            btnProcess2.UseVisualStyleBackColor = true;
            btnProcess2.Click += btnProcess2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { colorToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1300, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { blueToolStripMenuItem, redToolStripMenuItem, brownToolStripMenuItem });
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            colorToolStripMenuItem.Text = "color";
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            blueToolStripMenuItem.Text = "blue";
            blueToolStripMenuItem.Click += blueToolStripMenuItem_Click;
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { brownToolStripMenuItem1 });
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            redToolStripMenuItem.Text = "red";
            // 
            // brownToolStripMenuItem1
            // 
            brownToolStripMenuItem1.Name = "brownToolStripMenuItem1";
            brownToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            brownToolStripMenuItem1.Text = "brown";
            // 
            // brownToolStripMenuItem
            // 
            brownToolStripMenuItem.Name = "brownToolStripMenuItem";
            brownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            brownToolStripMenuItem.Text = "brown";
            // 
            // progressBar1
            // 
            progressBar1.Location = new System.Drawing.Point(527, 305);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(244, 23);
            progressBar1.TabIndex = 6;
            progressBar1.Click += progressBar1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1300, 546);
            Controls.Add(progressBar1);
            Controls.Add(btnProcess2);
            Controls.Add(btnProcess1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnProcess1;
        private System.Windows.Forms.Button btnProcess2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brownToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem brownToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
