namespace TrainingApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //==Premitive types
            //int, char, string, double, float

            int age = 30;
            char gender = 'M';
            string name = "Arslan Haider";
           double marks = 3.322;
            float dt = 3.42f;
            string psswrd = txtPassword.Text;

            string email = "abc@gmail.com";
            txtUserName.Text = name;
            txtEmail.Text = email;
            txtGender.Text = gender.ToString();
            lblPassword.Text = psswrd;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}