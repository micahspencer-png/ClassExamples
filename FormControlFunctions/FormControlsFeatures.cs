using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormControlFunctions
{
    /*TODO
        [x] save client info in a data structure
        [x] use list box to display a single client record
        [x] use combobox to select the right client
        [x] when selected, populate text fields and listbox with client details
        [] submit will update client record or create it if nonexistant
        [] may need a unique id number for each client
        [] save and restore clients using a file
        [] file dialogue controls
     */
    public partial class FormControlsFeatures : Form
    {
        List<string> clientData = new();
        string currentDBFilePath = "";
        public FormControlsFeatures()
        {
            InitializeComponent();

            //SelectDBFile();
            if (clientData.Count == 0)
            {
                clientData.Add("$$$$");
                this.currentDBFilePath = $"..\\..\\..\\ClientDB.cdb";
            }
           
            SetDefaults();
        }

        //Program Logic-------------------------------------------------------------------------------------------------

        void SetDefaults()
        {
            UpdateClientComboBox();
            if (ClientComboBox.Items.Count > 0)
            {
                ClientComboBox.SelectedIndex = 0;
            }
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
            bool allFieldsAreValid = true;
            AgeTextBox.BackColor = Color.White;
            NameTextBox.BackColor = Color.White;
            PhoneTextBox.BackColor = Color.White;
            int _age = 0;

            //actual validation

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
            if (ValidateInputFields())
            {
                ResultsListBox.Items.Clear();
                ResultsListBox.Items.Add(FormatName());
                ResultsListBox.Items.Add($"Max Heart Rate: {GetMaxHeartRate()}bpm");
                if (EmailCheckBox.Checked == true)
                {
                    ResultsListBox.Items.Add(CreateEmail());
                }
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

        void UpdateClientData()
        {
            string currentRecord = $"{NameTextBox.Text}$${AgeTextBox.Text}$${PhoneTextBox.Text}";
            if (!this.clientData.Contains(currentRecord))
            {
                if (ClientComboBox.SelectedIndex >= 1)
                {
                    this.clientData.RemoveAt(ClientComboBox.SelectedIndex);
                    this.clientData.Insert(ClientComboBox.SelectedIndex, currentRecord);
                }
                else
                {
                    this.clientData.Add(currentRecord);
                }
            }
            
            UpdateClientComboBox();
            UpdateClientDBFile();
        }

        void UpdateClientComboBox()
        {

            string[] temp;
            ClientComboBox.Items.Clear();


            //make combobox content match content of client data list
            //add names only
            foreach (string thing in this.clientData)
            {
                temp = thing.Split("$$");
                if (temp[0] == "")
                {
                    ClientComboBox.Items.Add("New");
                }
                else
                {
                    ClientComboBox.Items.Add(temp[0]);
                }
            }
            ClientComboBox.SelectedIndex = 0;
            DisplayText();
        }

        void SelectDBFile() 
        {
            DialogResult choice = DialogResult.Cancel;
            OpenFileDialog1.InitialDirectory = Application.StartupPath;
            OpenFileDialog1.FileName = "";
            OpenFileDialog1.Filter = "Client Data(*.cdb)|*.cdb|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            choice = OpenFileDialog1.ShowDialog();

            if (choice == DialogResult.OK)
            {
                this.currentDBFilePath = OpenFileDialog1.FileName;
                OpenClientDBFile(OpenFileDialog1.FileName);
                
            }
            else
            {
                //MessageBox.Show("Cancel");
            }
        }

        void OpenClientDBFile(string FilePath) 
        {
            using (StreamReader testFile = new StreamReader(FilePath))
            {
                this.clientData.Clear();
                do
                {
                    //Console.WriteLine(testFile.ReadLine());
                    this.clientData.Add(testFile.ReadLine());

                } while (testFile.EndOfStream == false);
                //this.currentDBFilePath = FilePath;
                //MessageBox.Show(FilePath);
            }
        }

        void UpdateClientDBFile() 
        {
            using (StreamWriter dbFile = File.CreateText(this.currentDBFilePath))
            {
                foreach (string thing in this.clientData)
                {
                    dbFile.WriteLine(thing);
                }
            }
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
            UpdateClientData();
        }
        private void Text_Changed(object sender, EventArgs e)
        {
            ValidateInputFields();
            submitButton.Enabled = true;
        }

        private void ClientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] temp;
            

            ResultsListBox.Items.Clear();
            temp = this.clientData[ClientComboBox.SelectedIndex].Split("$$");
            NameTextBox.Text = temp[0];
            AgeTextBox.Text = temp[1];
            PhoneTextBox.Text = temp[2];
            
            DisplayText();
            
        }

        private void OpenTopStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectDBFile();
        }
    }
}
