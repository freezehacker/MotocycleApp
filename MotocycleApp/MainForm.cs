using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotocycleApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuitOption_Click(object sender, EventArgs e)
        {
            Application.Exit(); // 整个程序退出
        }

        private void PrintOption_Click(object sender, EventArgs e)
        {

        }

        private void LoadOption_Click(object sender, EventArgs e)
        {
            // 录入个人信息，包括要重复输入的名字、身份证等信息
            LoadInfoForm loadInfoForm = new LoadInfoForm();
            loadInfoForm.fromForm = this;   // 将本Form实例传进去
            loadInfoForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        
        public void SetPerson(Person person)
        {
            // tab1
            T1Name.Text = person.name;
            T1Id.Text = person.id;

            // tab2
            T2Name.Text = person.name;
            T2Id.Text = person.id;

            // tab3
            T3Name.Text = person.name;
            T3Gender.SelectedIndex = person.gender == Person.Gender.MALE ? 0 : 1;
            T3Year.Text = person.birthDate.Year.ToString();
            T3Month.Text = person.birthDate.Month.ToString();
            T3Id.Text = person.id;

            // tab4
            T4Name.Text = person.name;
            T4Gender.SelectedIndex = person.gender == Person.Gender.MALE ? 0 : 1;
            T4BirthDate.Text = person.birthDate.Year.ToString() + "." 
                                    + person.birthDate.Month.ToString() + "." 
                                    + person.birthDate.Day.ToString();
            T4Id.Text = person.id;
        }
    }
}
