namespace WinFormMoreControls
{
    partial class MoreControlsForm
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
            components = new System.ComponentModel.Container();
            DisplayButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            TopMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            submitToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ContextMenuStrip = new ContextMenuStrip(components);
            submitToolStripMenuItem1 = new ToolStripMenuItem();
            clearToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            testsTheSubmitToolStripMenuItem = new ToolStripMenuItem();
            testsTheClearToolStripMenuItem = new ToolStripMenuItem();
            testsTheExitToolStripMenuItem = new ToolStripMenuItem();
            TopMenuStrip.SuspendLayout();
            ContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // DisplayButton
            // 
            DisplayButton.Location = new Point(447, 326);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(148, 76);
            DisplayButton.TabIndex = 0;
            DisplayButton.Text = "&Submit";
            DisplayButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(601, 326);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(148, 76);
            ClearButton.TabIndex = 0;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(755, 326);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(148, 76);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.ImageScalingSize = new Size(20, 20);
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Size = new Size(915, 28);
            TopMenuStrip.TabIndex = 1;
            TopMenuStrip.Text = "TopMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { submitToolStripMenuItem, clearToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // submitToolStripMenuItem
            // 
            submitToolStripMenuItem.Name = "submitToolStripMenuItem";
            submitToolStripMenuItem.Size = new Size(224, 26);
            submitToolStripMenuItem.Text = "&Submit";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(224, 26);
            clearToolStripMenuItem.Text = "&Clear";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "E&xit";
            // 
            // ContextMenuStrip
            // 
            ContextMenuStrip.ImageScalingSize = new Size(20, 20);
            ContextMenuStrip.Items.AddRange(new ToolStripItem[] { submitToolStripMenuItem1, clearToolStripMenuItem1, exitToolStripMenuItem1 });
            ContextMenuStrip.Name = "ContextMenuStrip";
            ContextMenuStrip.Size = new Size(126, 76);
            // 
            // submitToolStripMenuItem1
            // 
            submitToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { testsTheSubmitToolStripMenuItem });
            submitToolStripMenuItem1.Name = "submitToolStripMenuItem1";
            submitToolStripMenuItem1.Size = new Size(125, 24);
            submitToolStripMenuItem1.Text = "Submit";
            // 
            // clearToolStripMenuItem1
            // 
            clearToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { testsTheClearToolStripMenuItem });
            clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            clearToolStripMenuItem1.Size = new Size(125, 24);
            clearToolStripMenuItem1.Text = "Clear";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { testsTheExitToolStripMenuItem });
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(125, 24);
            exitToolStripMenuItem1.Text = "Exit";
            // 
            // testsTheSubmitToolStripMenuItem
            // 
            testsTheSubmitToolStripMenuItem.Name = "testsTheSubmitToolStripMenuItem";
            testsTheSubmitToolStripMenuItem.Size = new Size(224, 26);
            testsTheSubmitToolStripMenuItem.Text = "Tests the submit";
            // 
            // testsTheClearToolStripMenuItem
            // 
            testsTheClearToolStripMenuItem.Name = "testsTheClearToolStripMenuItem";
            testsTheClearToolStripMenuItem.Size = new Size(224, 26);
            testsTheClearToolStripMenuItem.Text = "tests the clear";
            // 
            // testsTheExitToolStripMenuItem
            // 
            testsTheExitToolStripMenuItem.Name = "testsTheExitToolStripMenuItem";
            testsTheExitToolStripMenuItem.Size = new Size(224, 26);
            testsTheExitToolStripMenuItem.Text = "tests the exit";
            // 
            // MoreControlsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 414);
            ContextMenuStrip = ContextMenuStrip;
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(DisplayButton);
            Controls.Add(TopMenuStrip);
            MainMenuStrip = TopMenuStrip;
            Name = "MoreControlsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            ContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DisplayButton;
        private Button ClearButton;
        private Button ExitButton;
        private MenuStrip TopMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem submitToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ContextMenuStrip ContextMenuStrip;
        private ToolStripMenuItem submitToolStripMenuItem1;
        private ToolStripMenuItem clearToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem testsTheSubmitToolStripMenuItem;
        private ToolStripMenuItem testsTheClearToolStripMenuItem;
        private ToolStripMenuItem testsTheExitToolStripMenuItem;
    }
}
