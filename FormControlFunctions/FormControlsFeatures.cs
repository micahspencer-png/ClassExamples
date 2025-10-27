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
            return false;
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
    }
}
