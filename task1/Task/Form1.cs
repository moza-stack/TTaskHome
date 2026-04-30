using System.Xml.Linq;

namespace Task
{
    public partial class Form1 : Form
    {
        List<student> students = new List<student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            student s = new student
            {
                ID = int.Parse(txtID.Text),
                Name = txtName.Text,
                Major = txtMajor.Text
            };

            students.Add(s);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);

            var student = students.FirstOrDefault(x => x.ID == id);

            if (student != null)
            {
                students.Remove(student);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);

            var student = students.FirstOrDefault(x => x.ID == id);

            if (student != null)
            {
                txtName.Text = student.Name;
                txtMajor.Text = student.Major;
            }
            else
            {
                MessageBox.Show("الطالب غير موجود");
            }
        
    }
    }
}
