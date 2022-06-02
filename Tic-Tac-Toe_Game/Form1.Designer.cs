namespace Tic_Tac_Toe_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.continueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGameToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(358, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuGameToolStripMenuItem
            // 
            this.menuGameToolStripMenuItem.BackgroundImage = global::Tic_Tac_Toe_Game.Properties.Resources.Screenshot_2022_06_03_002807_removebg_preview;
            this.menuGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.continueToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuGameToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuGameToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.menuGameToolStripMenuItem.Name = "menuGameToolStripMenuItem";
            this.menuGameToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.menuGameToolStripMenuItem.Text = "Game Menu";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // continueToolStripMenuItem
            // 
            this.continueToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.continueToolStripMenuItem.Name = "continueToolStripMenuItem";
            this.continueToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.continueToolStripMenuItem.Text = "Continue";
            this.continueToolStripMenuItem.Click += new System.EventHandler(this.continueToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.BackgroundImage")));
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(33, 20);
            this.toolStripMenuItem1.Text = "?   ";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Tic_Tac_Toe_Game.Properties.Resources.Screenshot_2022_06_02_222849;
            this.button1.Font = new System.Drawing.Font("Arial Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(21, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 95);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_click);
            this.button1.MouseEnter += new System.EventHandler(this.button_enter);
            this.button1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Tic_Tac_Toe_Game.Properties.Resources.Screenshot_2022_06_02_222849;
            this.button2.Font = new System.Drawing.Font("Arial Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.Location = new System.Drawing.Point(131, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 95);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_click);
            this.button2.MouseEnter += new System.EventHandler(this.button_enter);
            this.button2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Tic_Tac_Toe_Game.Properties.Resources.Screenshot_2022_06_02_222849;
            this.button3.Font = new System.Drawing.Font("Arial Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(241, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 95);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_click);
            this.button3.MouseEnter += new System.EventHandler(this.button_enter);
            this.button3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Tic_Tac_Toe_Game.Properties.Resources.Screenshot_2022_06_02_222849;
            this.button4.Font = new System.Drawing.Font("Arial Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button4.Location = new System.Drawing.Point(21, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 95);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_click);
            this.button4.MouseEnter += new System.EventHandler(this.button_enter);
            this.button4.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Tic_Tac_Toe_Game.Properties.Resources.Screenshot_2022_06_02_222849;
            this.button5.Font = new System.Drawing.Font("Arial Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button5.Location = new System.Drawing.Point(131, 163);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 95);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_click);
            this.button5.MouseEnter += new System.EventHandler(this.button_enter);
            this.button5.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::Tic_Tac_Toe_Game.Properties.Resources.Screenshot_2022_06_02_222849;
            this.button6.Font = new System.Drawing.Font("Arial Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button6.Location = new System.Drawing.Point(241, 163);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 95);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_click);
            this.button6.MouseEnter += new System.EventHandler(this.button_enter);
            this.button6.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::Tic_Tac_Toe_Game.Properties.Resources.Screenshot_2022_06_02_222849;
            this.button7.Font = new System.Drawing.Font("Arial Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button7.Location = new System.Drawing.Point(21, 276);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 95);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_click);
            this.button7.MouseEnter += new System.EventHandler(this.button_enter);
            this.button7.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::Tic_Tac_Toe_Game.Properties.Resources.Screenshot_2022_06_02_222849;
            this.button8.Font = new System.Drawing.Font("Arial Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button8.Location = new System.Drawing.Point(131, 276);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 95);
            this.button8.TabIndex = 8;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_click);
            this.button8.MouseEnter += new System.EventHandler(this.button_enter);
            this.button8.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::Tic_Tac_Toe_Game.Properties.Resources.Screenshot_2022_06_02_222849;
            this.button9.Font = new System.Drawing.Font("Arial Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button9.Location = new System.Drawing.Point(241, 276);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(95, 95);
            this.button9.TabIndex = 9;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_click);
            this.button9.MouseEnter += new System.EventHandler(this.button_enter);
            this.button9.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tic_Tac_Toe_Game.Properties.Resources.tic_tac_toe_seamless_background_on_dark_blue_illustration_vector1;
            this.ClientSize = new System.Drawing.Size(358, 389);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe Game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuGameToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem continueToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}