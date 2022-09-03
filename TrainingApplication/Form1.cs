using TrainingApplication.Models;

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


            ///Creation of Employee Objecct
            Employee emp = new Employee();
            emp.Id = Guid.NewGuid().ToString();
            emp.Gender = cmbGender.SelectedItem.ToString();
            emp.Email = txtEmail.Text.ToString();
            emp.Active = chkActive.Checked;
            emp.Password = txtPassword.Text;
            emp.UserName = txtUserName.Text;
            emp.Address = txtAddress.Text;



            lblUserName.Text = emp.UserName;
            lblPassword.Text = emp.Password;
            lblGender.Text = emp.Gender;
            lblEmail.Text = emp.Email;
            lblActive.Text = emp.Active.ToString();
            lblAddress.Text = emp.Address;
            lblDob.Text = emp.CreationDate.ToShortDateString();
                 


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}