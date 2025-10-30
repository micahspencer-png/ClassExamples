using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormControlFunctions
{
    /*TODO
        [] save client info in a data structure
        [] use list box to display a single client record
        [] use combobox to select the right client
        [] when selected, populate text fields and listbox with client details
        [] submit will update client record or create it if nonexistant
        [] may need a unique id number for each client
        [] save and restore clients using a file
        [] file dialogue controls
     */
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
            FormatCheckBox.Checked = false;
            EmailCheckBox.Checked = false;
            //output
            ResultsListBox.Items.Clear();
            ClientComboBox.Items.Clear();

            //buttons
            submitButton.Enabled = ValidateInputFields();
        }

        bool ValidateInputFields() 
        {
            bool allFieldsAreValid = false;
            AgeTextBox.BackColor = Color.White;
            NameTextBox.BackColor = Color.White;
            PhoneTextBox.BackColor = Color.White;
            int _age = 0;

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


            try
            {
                _age = int.Parse(AgeTextBox.Text);
                if (_age <= 0 || _age >= 100)
                {
                    allFieldsAreValid = false;
                    AgeTextBox.BackColor = Color.LightYellow;
                }
            }
            catch (Exception)
            {
                allFieldsAreValid = false;
                AgeTextBox.BackColor = Color.LightYellow;

                if (NameTextBox.Text == "")
                {
                    NameTextBox.BackColor = Color.LightYellow;
                    allFieldsAreValid = false;
                }
            }
                
                return allFieldsAreValid;
        }

        string FormatName() 
        { 
            string _name = NameTextBox.Text;
            if (UpperRadioButton.Checked == true) 
            {
                _name = _name.ToUpper();
            }
            else if (LowerRadioButton.Checked == true)
            {
                _name = _name.ToLower();
            }
            else if (ReverseRadioButton.Checked == true)
            {
                //_name = (string)_name.Reverse();
                char[] chars = _name.ToCharArray();
                _name = "";
                for (int i = chars.GetUpperBound(0); i >= 0; i--)
                {
                    _name += chars[i];
                }
            }
            if (FormatCheckBox.Checked == true) 
            { 
               return _name; 
            }
            else 
            { 
                return NameTextBox.Text;
            }    
        }

        int GetMaxHeartRate()
        {
            int maxHR = 0;
            maxHR = 220 - int.Parse(AgeTextBox.Text);
            return maxHR;
        }
       
        void DisplayText() 
        {
            ClientComboBox.Items.Add(FormatName());
            ResultsListBox.Items.Add(FormatName());
            ResultsListBox.Items.Add($"Max Heart Rate: {GetMaxHeartRate()}bpm");
            if (EmailCheckBox.Checked == true) 
            {
                ResultsListBox.Items.Add(CreateEmail());
            }

        }

        string CreateEmail() 
        {
            string _email = "";
            _email = FormatName();
            _email = _email.Replace(" ", ".");
            _email = $"{_email}@acme.com";
            return _email;
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
            DisplayText();
        }
        private void Text_Changed(object sender, EventArgs e) 
        {
            ValidateInputFields();
            submitButton.Enabled = ValidateInputFields();
        }
    }
}
