namespace FormsExample
{
    public partial class FormsExample : Form
    {
        public FormsExample()
        {
            InitializeComponent();
        }

        void DisplayContent() 
        { 
            if (EvaluateFields() != "")
            {
                MessageBox.Show(EvaluateFields());
            }

            else
            {
                DisplayLabel.Text = $"{FirstNametextbox.Text} {LastNametextbox.Text} \n{StreetAddresstextbox.Text} \n{Citytextbox.Text}, {Statetextbox.Text} {Zipcodetextbox.Text}";
            }
        }

        string EvaluateFields() 
        {
            string message = "";
            
            if (Zipcodetextbox.Text == "")
            {
                Zipcodetextbox.Focus();
                message += "Zipcode is Required\n";
            }
            
            if (Statetextbox.Text == "")
            {
                Statetextbox.Focus();
                message += "State is Required\n";
            }

            if (Citytextbox.Text == "")
            {
                Citytextbox.Focus();
                message += "City is Required\n";
            }

            if (StreetAddresstextbox.Text == "")
            {
                StreetAddresstextbox.Focus();
                message += "Street Address is Required\n";
            }

            if (LastNametextbox.Text == "")
            { 
                LastNametextbox.Focus();
                message += "Last Name is Required\n";
            }

            if (FirstNametextbox.Text == "")
            {
                FirstNametextbox.Focus();
                message += "First Name is Required\n";
            }

            return message;
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        { 
            DisplayContent(); 
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = string.Empty ;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
