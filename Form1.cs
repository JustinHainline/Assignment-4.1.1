namespace Assignment_4._1._1
{
    public partial class Form1 : Form
    {
        static Dictionary<string, Person> contactBook = new Dictionary<string, Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person newperson = new Person();

            newperson.FirstName = FirstNametextbox.Text;
            newperson.LastName = LastNametextbox.Text;
            newperson.MobilePhone = MobilePhonetextbox.Text;
            newperson.WorkPhone = WorkPhonetextbox.Text;
            newperson.Address = Addresstextbox.Text;

            string fullName = LastNametextbox.Text + FirstNametextbox.Text;
            contactBook.Add(fullName, newperson);

        }
    }
}
