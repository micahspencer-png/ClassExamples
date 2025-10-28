namespace FormControlFunctions
{
    public partial class FormControlsFeatures : Form
    {
        public FormControlsFeatures()
        {
            InitializeComponent();
            SetDefaults();
        }

        //Program Logic-------------------------------------------------------------------------------------------------

        void SetDefaults()
        {
            //info fields
            NameTextBox.Text = "";
            AgeTextBox.Text = "";
            PhoneTextBox.Text = "";
            NameTextBox.Focus();
            //options
            UpperRadioButton.Checked = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            //output

            //buttons
            submitButton.Enabled = ValidateInputFields();
        }

        bool ValidateInputFields() 
        {
            bool allFieldsAreValid = false;
            AgeTextBox.BackColor = Color.White;
            NameTextBox.BackColor = Color.White;
            PhoneTextBox.BackColor = Color.White;

            //actual validation
            if (NameTextBox.Text != "" && AgeTextBox.Text != "" && PhoneTextBox.Text != "") 
            {
                allFieldsAreValid = true;
            }
           
                if (PhoneTextBox.Text == "")
                {
                PhoneTextBox.BackColor = Color.LightYellow;
                allFieldsAreValid = false;
                }
            

                if (AgeTextBox.Text == "")
                {
                    AgeTextBox.BackColor = Color.LightYellow;
                    allFieldsAreValid = false;
                }
                
                if (NameTextBox.Text == "") 
                { 
                    NameTextBox.BackColor = Color.LightYellow;
                    allFieldsAreValid = false;
                }
                
                return allFieldsAreValid;
        }

        void Submit() 
        { 
        
        }

        //Event Handlers------------------------------------------------------------------------------------------------
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Submit();
        }
        private void Text_Changed(object sender, EventArgs e) 
        {
            ValidateInputFields();
            submitButton.Enabled = ValidateInputFields();
        }
    }
}
