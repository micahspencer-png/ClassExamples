using System.Diagnostics;

namespace FormsExample
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
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
            DisplayButton = new Button();
            ExitButton = new Button();
            ClearButton = new Button();
            FirstName = new Label();
            textBox1 = new TextBox();
            LastName = new Label();
            textBox2 = new TextBox();
            Streetname = new Label();
            textBox3 = new TextBox();
            city = new Label();
            textBox4 = new TextBox();
            state = new Label();
            textBox5 = new TextBox();
            zipcode = new Label();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // DisplayButton
            // 
            DisplayButton.Location = new Point(365, 372);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(137, 66);
            DisplayButton.TabIndex = 0;
            DisplayButton.Text = "Display Label";
            DisplayButton.UseVisualStyleBackColor = true;
            DisplayButton.Click += DisplayButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(651, 372);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(137, 66);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(508, 372);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(137, 66);
            ClearButton.TabIndex = 0;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Location = new Point(32, 85);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(80, 20);
            FirstName.TabIndex = 1;
            FirstName.Text = "First Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 27);
            textBox1.TabIndex = 2;
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Location = new Point(32, 118);
            LastName.Name = "LastName";
            LastName.Size = new Size(79, 20);
            LastName.TabIndex = 1;
            LastName.Text = "Last Name";
            LastName.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 27);
            textBox2.TabIndex = 2;
            // 
            // Streetname
            // 
            Streetname.AutoSize = true;
            Streetname.Location = new Point(32, 151);
            Streetname.Name = "Streetname";
            Streetname.Size = new Size(105, 20);
            Streetname.TabIndex = 1;
            Streetname.Text = "Street Address";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(143, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 27);
            textBox3.TabIndex = 2;
            // 
            // city
            // 
            city.AutoSize = true;
            city.Location = new Point(32, 184);
            city.Name = "city";
            city.Size = new Size(34, 20);
            city.TabIndex = 1;
            city.Text = "City";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(143, 177);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(140, 27);
            textBox4.TabIndex = 2;
            // 
            // state
            // 
            state.AutoSize = true;
            state.Location = new Point(32, 217);
            state.Name = "state";
            state.Size = new Size(43, 20);
            state.TabIndex = 1;
            state.Text = "State";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(143, 210);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(140, 27);
            textBox5.TabIndex = 2;
            // 
            // zipcode
            // 
            zipcode.AutoSize = true;
            zipcode.Location = new Point(32, 250);
            zipcode.Name = "zipcode";
            zipcode.Size = new Size(64, 20);
            zipcode.TabIndex = 1;
            zipcode.Text = "Zipcode";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(143, 243);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(140, 27);
            textBox6.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(zipcode);
            Controls.Add(textBox5);
            Controls.Add(state);
            Controls.Add(textBox4);
            Controls.Add(city);
            Controls.Add(textBox3);
            Controls.Add(Streetname);
            Controls.Add(textBox2);
            Controls.Add(LastName);
            Controls.Add(textBox1);
            Controls.Add(FirstName);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(DisplayButton);
            Name = "Form1";
            Text = "Form1";
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
        private Label FirstName;
        private TextBox textBox1;
        private Label LastName;
        private TextBox textBox2;
        private Label Streetname;
        private TextBox textBox3;
        private Label city;
        private TextBox textBox4;
        private Label state;
        private TextBox textBox5;
        private Label zipcode;
        private TextBox textBox6;
    }
}
