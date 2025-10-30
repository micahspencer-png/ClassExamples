namespace FormControlFunctions
{
    partial class FormControlsFeatures
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
            groupBox1 = new GroupBox();
            PhoneTextBox = new TextBox();
            PhoneLabel = new Label();
            AgeTextBox = new TextBox();
            AgeLabel = new Label();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            groupBox2 = new GroupBox();
            ClientComboBox = new ComboBox();
            ResultsListBox = new ListBox();
            groupBox3 = new GroupBox();
            EmailCheckBox = new CheckBox();
            FormatCheckBox = new CheckBox();
            ReverseRadioButton = new RadioButton();
            LowerRadioButton = new RadioButton();
            UpperRadioButton = new RadioButton();
            groupBox4 = new GroupBox();
            exitButton = new Button();
            clearButton = new Button();
            submitButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PhoneTextBox);
            groupBox1.Controls.Add(PhoneLabel);
            groupBox1.Controls.Add(AgeTextBox);
            groupBox1.Controls.Add(AgeLabel);
            groupBox1.Controls.Add(NameTextBox);
            groupBox1.Controls.Add(NameLabel);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 274);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Client Information";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(62, 103);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(283, 27);
            PhoneTextBox.TabIndex = 3;
            PhoneTextBox.TextChanged += Text_Changed;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(6, 106);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(50, 20);
            PhoneLabel.TabIndex = 0;
            PhoneLabel.Text = "Phone";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(62, 70);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(283, 27);
            AgeTextBox.TabIndex = 2;
            AgeTextBox.TextChanged += Text_Changed;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(6, 73);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(36, 20);
            AgeLabel.TabIndex = 0;
            AgeLabel.Text = "Age";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(62, 37);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(283, 27);
            NameTextBox.TabIndex = 1;
            NameTextBox.TextChanged += Text_Changed;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(6, 40);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ClientComboBox);
            groupBox2.Controls.Add(ResultsListBox);
            groupBox2.Location = new Point(496, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(486, 274);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Results";
            // 
            // ClientComboBox
            // 
            ClientComboBox.FormattingEnabled = true;
            ClientComboBox.Location = new Point(168, 26);
            ClientComboBox.Name = "ClientComboBox";
            ClientComboBox.Size = new Size(294, 28);
            ClientComboBox.TabIndex = 1;
            // 
            // ResultsListBox
            // 
            ResultsListBox.FormattingEnabled = true;
            ResultsListBox.Location = new Point(10, 69);
            ResultsListBox.Name = "ResultsListBox";
            ResultsListBox.Size = new Size(452, 184);
            ResultsListBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(EmailCheckBox);
            groupBox3.Controls.Add(FormatCheckBox);
            groupBox3.Controls.Add(ReverseRadioButton);
            groupBox3.Controls.Add(LowerRadioButton);
            groupBox3.Controls.Add(UpperRadioButton);
            groupBox3.Location = new Point(6, 292);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(484, 258);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Options";
            // 
            // EmailCheckBox
            // 
            EmailCheckBox.AutoSize = true;
            EmailCheckBox.Location = new Point(290, 95);
            EmailCheckBox.Name = "EmailCheckBox";
            EmailCheckBox.Size = new Size(115, 24);
            EmailCheckBox.TabIndex = 4;
            EmailCheckBox.Text = "Create Email";
            EmailCheckBox.UseVisualStyleBackColor = true;
            // 
            // FormatCheckBox
            // 
            FormatCheckBox.AutoSize = true;
            FormatCheckBox.Location = new Point(290, 65);
            FormatCheckBox.Name = "FormatCheckBox";
            FormatCheckBox.Size = new Size(121, 24);
            FormatCheckBox.TabIndex = 3;
            FormatCheckBox.Text = "Apply Format";
            FormatCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReverseRadioButton
            // 
            ReverseRadioButton.AutoSize = true;
            ReverseRadioButton.Location = new Point(12, 125);
            ReverseRadioButton.Name = "ReverseRadioButton";
            ReverseRadioButton.Size = new Size(81, 24);
            ReverseRadioButton.TabIndex = 2;
            ReverseRadioButton.TabStop = true;
            ReverseRadioButton.Text = "Reverse";
            ReverseRadioButton.UseVisualStyleBackColor = true;
            // 
            // LowerRadioButton
            // 
            LowerRadioButton.AutoSize = true;
            LowerRadioButton.Location = new Point(12, 95);
            LowerRadioButton.Name = "LowerRadioButton";
            LowerRadioButton.Size = new Size(105, 24);
            LowerRadioButton.TabIndex = 1;
            LowerRadioButton.TabStop = true;
            LowerRadioButton.Text = "Lower Case";
            LowerRadioButton.UseVisualStyleBackColor = true;
            // 
            // UpperRadioButton
            // 
            UpperRadioButton.AutoSize = true;
            UpperRadioButton.Location = new Point(12, 65);
            UpperRadioButton.Name = "UpperRadioButton";
            UpperRadioButton.Size = new Size(106, 24);
            UpperRadioButton.TabIndex = 0;
            UpperRadioButton.TabStop = true;
            UpperRadioButton.Text = "Upper Case";
            UpperRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(exitButton);
            groupBox4.Controls.Add(clearButton);
            groupBox4.Controls.Add(submitButton);
            groupBox4.Location = new Point(496, 292);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(477, 258);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Controls";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(276, 168);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(129, 64);
            exitButton.TabIndex = 2;
            exitButton.Text = "E&xit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(141, 168);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(129, 64);
            clearButton.TabIndex = 1;
            clearButton.Text = "&Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(6, 168);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(129, 64);
            submitButton.TabIndex = 0;
            submitButton.Text = "&Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // FormControlsFeatures
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 562);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormControlsFeatures";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormControlFeatures";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private GroupBox groupBox1;
        private TextBox PhoneTextBox;
        private Label PhoneLabel;
        private TextBox AgeTextBox;
        private Label AgeLabel;
        private TextBox NameTextBox;
        private Label NameLabel;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private CheckBox EmailCheckBox;
        private CheckBox FormatCheckBox;
        private RadioButton ReverseRadioButton;
        private RadioButton LowerRadioButton;
        private RadioButton UpperRadioButton;
        private Button exitButton;
        private Button clearButton;
        private Button submitButton;
        private ListBox ResultsListBox;
        private ComboBox ClientComboBox;
    }
}
