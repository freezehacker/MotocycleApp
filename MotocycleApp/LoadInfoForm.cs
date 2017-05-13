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
    public partial class LoadInfoForm : Form
    {
        public Form fromForm; // 保存源Form的引用

        public LoadInfoForm()
        {
            InitializeComponent();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            idCheck.Text = StringUtils.splitId(id.Text);
        }


        private void submit_Click(object sender, EventArgs e)
        {
            Person person = new Person(
                name.Text, 
                id.Text, 
                birthDate.Value, 
                male.Checked ? Person.Gender.MALE : Person.Gender.FEMALE);
            ((MainForm)fromForm).SetPerson(person);

            this.Hide();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            fromForm = null;
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            //
            // 如果不是下面的候选按键，那就吃掉该事件
            // 身份证只能输入数字、x、X、退格
            //
            if (!(e.KeyChar == '\b'
                || (e.KeyChar >= '0' && e.KeyChar <= '9')
                || e.KeyChar == 'X'
                || e.KeyChar == 'x'))
            {
                e.Handled = true;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            //
            // 根据身份证号，识别出其中的生日、性别等
            //

            try
            {
                string birthPart = id.Text.Substring(6, 8);
                string year = birthPart.Substring(0, 4);
                string month = birthPart.Substring(4, 2);
                string day = birthPart.Substring(6, 2);
                DateTime dt = new DateTime(Int32.Parse(year), Int32.Parse(month), Int32.Parse(day));
                birthDate.Value = dt;

                string genderPart = id.Text.Substring(16, 1);
                int genderNum = Int32.Parse(genderPart);
                if (genderNum % 2 == 1) // 奇数，为男性
                {
                    male.Checked = true;
                }
                else
                {
                    female.Checked = true;   
                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            finally
            {

            }
        }

        private void LoadInfoForm_Load(object sender, EventArgs e)
        {
            birthDate.Format = DateTimePickerFormat.Custom;
            birthDate.CustomFormat = "yyyy-MM-dd";
            birthDate.ShowUpDown = true;
        }
    }
}
