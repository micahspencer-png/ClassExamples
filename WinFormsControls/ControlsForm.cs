namespace WinFormsControls
{
    public partial class ControlsForm : Form
    {
        public ControlsForm()
        {
            InitializeComponent();
            SetDefaults();
        }

        void SetDefaults() 
        {
            radioButton1.Checked = true;
            radioButton4.Checked = true;
            radioButton6.Checked = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }
    }
}
