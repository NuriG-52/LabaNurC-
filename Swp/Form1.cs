namespace Swp
{
    public partial class Form1 : Form
    {
        Person student;
        public Form1()


        {
            InitializeComponent();
            this.student = new Student();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SmwForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show("Завершить работу ?",
                "Завершение работы",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    e.Cancel = false;
                    break;

                case DialogResult.No:
                    e.Cancel = true;
                    break;

                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;

            }
        }

        private void Input_SNFN_Click(object sender, EventArgs e)
        {
            this.student.Surname = this.Surname.Text;
            this.student.Firstname = this.Firstname.Text;
            this.student.Pass = this.Pass.Text;

            try
            {
                this.student.BDate = DateTime.Parse(this.BDate.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show
                   ("Форамт ввода даты рождения: дд.мм.гггг",
                    "ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (BdExpection error)
            {
                MessageBox.Show
                   (error.code.ToString() + "Дата рождения превышает текущую",
                    "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void OpenMenuDataBase_Click(object sender, EventArgs e)
        {

        }

        private void базаДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GetAddress_Click(object sender, EventArgs e)
        {
            NewForm newform = new NewForm();
            newform.Show();

        }
    }
}
