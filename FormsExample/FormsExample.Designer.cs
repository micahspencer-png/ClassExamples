using System.Diagnostics;

namespace FormsExample
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    partial class FormsExample
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
            ExitButton = new Button();
            ClearButton = new Button();
            FirstNamelabel = new Label();
            FirstNametextbox = new TextBox();
            LastNamelabel = new Label();
            LastNametextbox = new TextBox();
            Streetaddresslabel = new Label();
            StreetAddresstextbox = new TextBox();
            citylabel = new Label();
            Citytextbox = new TextBox();
            statelabel = new Label();
            Statetextbox = new TextBox();
            zipcodelabel = new Label();
            Zipcodetextbox = new TextBox();
            DisplayLabel = new Label();
            toolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // DisplayButton
            // 
            DisplayButton.Location = new Point(290, 343);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(137, 66);
            DisplayButton.TabIndex = 0;
            DisplayButton.Text = "&Display Label";
            toolTip.SetToolTip(DisplayButton, "Displays Data from User");
            DisplayButton.UseVisualStyleBackColor = true;
            DisplayButton.Click += DisplayButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(576, 343);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(137, 66);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "E&xit";
            toolTip.SetToolTip(ExitButton, "Closes the Program");
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(433, 343);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(137, 66);
            ClearButton.TabIndex = 0;
            ClearButton.Text = "&Clear";
            toolTip.SetToolTip(ClearButton, "Clears the Current Label");
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // FirstNamelabel
            // 
            FirstNamelabel.AutoSize = true;
            FirstNamelabel.Location = new Point(32, 85);
            FirstNamelabel.Name = "FirstNamelabel";
            FirstNamelabel.Size = new Size(80, 20);
            FirstNamelabel.TabIndex = 1;
            FirstNamelabel.Text = "First Name";
            // 
            // FirstNametextbox
            // 
            FirstNametextbox.Location = new Point(143, 78);
            FirstNametextbox.Name = "FirstNametextbox";
            FirstNametextbox.Size = new Size(140, 27);
            FirstNametextbox.TabIndex = 2;
            // 
            // LastNamelabel
            // 
            LastNamelabel.AutoSize = true;
            LastNamelabel.Location = new Point(32, 118);
            LastNamelabel.Name = "LastNamelabel";
            LastNamelabel.Size = new Size(79, 20);
            LastNamelabel.TabIndex = 1;
            LastNamelabel.Text = "Last Name";
            // 
            // LastNametextbox
            // 
            LastNametextbox.Location = new Point(143, 111);
            LastNametextbox.Name = "LastNametextbox";
            LastNametextbox.Size = new Size(140, 27);
            LastNametextbox.TabIndex = 2;
            // 
            // Streetaddresslabel
            // 
            Streetaddresslabel.AutoSize = true;
            Streetaddresslabel.Location = new Point(32, 151);
            Streetaddresslabel.Name = "Streetaddresslabel";
            Streetaddresslabel.Size = new Size(105, 20);
            Streetaddresslabel.TabIndex = 1;
            Streetaddresslabel.Text = "Street Address";
            // 
            // StreetAddresstextbox
            // 
            StreetAddresstextbox.Location = new Point(143, 144);
            StreetAddresstextbox.Name = "StreetAddresstextbox";
            StreetAddresstextbox.Size = new Size(140, 27);
            StreetAddresstextbox.TabIndex = 2;
            // 
            // citylabel
            // 
            citylabel.AutoSize = true;
            citylabel.Location = new Point(32, 184);
            citylabel.Name = "citylabel";
            citylabel.Size = new Size(34, 20);
            citylabel.TabIndex = 1;
            citylabel.Text = "City";
            // 
            // Citytextbox
            // 
            Citytextbox.Location = new Point(143, 177);
            Citytextbox.Name = "Citytextbox";
            Citytextbox.Size = new Size(140, 27);
            Citytextbox.TabIndex = 2;
            // 
            // statelabel
            // 
            statelabel.AutoSize = true;
            statelabel.Location = new Point(32, 217);
            statelabel.Name = "statelabel";
            statelabel.Size = new Size(43, 20);
            statelabel.TabIndex = 1;
            statelabel.Text = "State";
            // 
            // Statetextbox
            // 
            Statetextbox.Location = new Point(143, 210);
            Statetextbox.Name = "Statetextbox";
            Statetextbox.Size = new Size(140, 27);
            Statetextbox.TabIndex = 2;
            // 
            // zipcodelabel
            // 
            zipcodelabel.AutoSize = true;
            zipcodelabel.Location = new Point(32, 250);
            zipcodelabel.Name = "zipcodelabel";
            zipcodelabel.Size = new Size(64, 20);
            zipcodelabel.TabIndex = 1;
            zipcodelabel.Text = "Zipcode";
            // 
            // Zipcodetextbox
            // 
            Zipcodetextbox.Location = new Point(143, 243);
            Zipcodetextbox.Name = "Zipcodetextbox";
            Zipcodetextbox.Size = new Size(140, 27);
            Zipcodetextbox.TabIndex = 2;
            // 
            // DisplayLabel
            // 
            DisplayLabel.BorderStyle = BorderStyle.FixedSingle;
            DisplayLabel.Font = new Font("Times New Roman", 20F);
            DisplayLabel.Location = new Point(319, 44);
            DisplayLabel.Name = "DisplayLabel";
            DisplayLabel.Size = new Size(374, 279);
            DisplayLabel.TabIndex = 3;
            // 
            // FormsExample
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 419);
            Controls.Add(DisplayLabel);
            Controls.Add(Zipcodetextbox);
            Controls.Add(zipcodelabel);
            Controls.Add(Statetextbox);
            Controls.Add(statelabel);
            Controls.Add(Citytextbox);
            Controls.Add(citylabel);
            Controls.Add(StreetAddresstextbox);
            Controls.Add(Streetaddresslabel);
            Controls.Add(LastNametextbox);
            Controls.Add(LastNamelabel);
            Controls.Add(FirstNametextbox);
            Controls.Add(FirstNamelabel);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(DisplayButton);
            Name = "FormsExample";
            Text = "Address Label";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DisplayButton;
        private Button ExitButton;
        private Button ClearButton;

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
        private Label FirstNamelabel;
        private TextBox FirstNametextbox;
        private Label LastNamelabel;
        private TextBox LastNametextbox;
        private Label Streetaddresslabel;
        private TextBox StreetAddresstextbox;
        private Label citylabel;
        private TextBox Citytextbox;
        private Label statelabel;
        private TextBox Statetextbox;
        private Label zipcodelabel;
        private TextBox Zipcodetextbox;
        private Label DisplayLabel;
        private ToolTip toolTip;
    }
}
