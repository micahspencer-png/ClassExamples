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
            SubmitTopMenuItem = new ToolStripMenuItem();
            ClearTopMenuItem = new ToolStripMenuItem();
            ExitTopMenuItem = new ToolStripMenuItem();
            ContextMenuStrip = new ContextMenuStrip(components);
            submitToolStripMenuItem1 = new ToolStripMenuItem();
            clearToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            DisplayListBox = new ListBox();
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
            DisplayButton.Click += DisplayButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(601, 326);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(148, 76);
            ClearButton.TabIndex = 0;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(755, 326);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(148, 76);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
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
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SubmitTopMenuItem, ClearTopMenuItem, ExitTopMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // SubmitTopMenuItem
            // 
            SubmitTopMenuItem.Name = "SubmitTopMenuItem";
            SubmitTopMenuItem.Size = new Size(224, 26);
            SubmitTopMenuItem.Text = "&Submit";
            SubmitTopMenuItem.Click += SubmitTopMenuItem_Click;
            // 
            // ClearTopMenuItem
            // 
            ClearTopMenuItem.Name = "ClearTopMenuItem";
            ClearTopMenuItem.Size = new Size(224, 26);
            ClearTopMenuItem.Text = "&Clear";
            ClearTopMenuItem.Click += ClearTopMenuItem_Click;
            // 
            // ExitTopMenuItem
            // 
            ExitTopMenuItem.Name = "ExitTopMenuItem";
            ExitTopMenuItem.Size = new Size(224, 26);
            ExitTopMenuItem.Text = "E&xit";
            ExitTopMenuItem.Click += ExitTopMenuItem_Click;
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
            submitToolStripMenuItem1.Name = "submitToolStripMenuItem1";
            submitToolStripMenuItem1.Size = new Size(125, 24);
            submitToolStripMenuItem1.Text = "Submit";
            // 
            // clearToolStripMenuItem1
            // 
            clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            clearToolStripMenuItem1.Size = new Size(125, 24);
            clearToolStripMenuItem1.Text = "Clear";
            clearToolStripMenuItem1.Click += ClearButton_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(125, 24);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += ExitButton_Click;
            // 
            // DisplayListBox
            // 
            DisplayListBox.ContextMenuStrip = ContextMenuStrip;
            DisplayListBox.FormattingEnabled = true;
            DisplayListBox.Location = new Point(12, 32);
            DisplayListBox.Name = "DisplayListBox";
            DisplayListBox.Size = new Size(891, 284);
            DisplayListBox.TabIndex = 2;
            // 
            // MoreControlsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 414);
            Controls.Add(DisplayListBox);
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
        private ToolStripMenuItem SubmitTopMenuItem;
        private ToolStripMenuItem ClearTopMenuItem;
        private ToolStripMenuItem ExitTopMenuItem;
        private ContextMenuStrip ContextMenuStrip;
        private ToolStripMenuItem submitToolStripMenuItem1;
        private ToolStripMenuItem clearToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ListBox DisplayListBox;
    }
}
