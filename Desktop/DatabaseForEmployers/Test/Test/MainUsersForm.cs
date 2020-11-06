using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class MainUsersForm : System.Windows.Forms.Form
    {
        readonly TestBaseEntities database;
        public MainUsersForm()
        {
            InitializeComponent();

            database = new TestBaseEntities();
            database.UsersSet.Load();
            userTable.DataSource = database.UsersSet.Local.ToBindingList();
            database.SkillsSet.Load();
            skillTable.DataSource = database.SkillsSet.Local.ToBindingList();
            database.InterviewersSet.Load();
            interviewerTable.DataSource = database.InterviewersSet.Local.ToBindingList();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            UserInformationForm userInformationForm = new UserInformationForm();
            List<Skills> skillsSet = database.SkillsSet.ToList();

            DialogResult result = userInformationForm.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;
            skillsSet.Clear();

            UsersSet user = new UsersSet
            {
                Фамилия = userInformationForm.textBox1.Text,
                Имя = userInformationForm.textBox2.Text,
                Отчество = userInformationForm.textBox3.Text,
                Ссылка = userInformationForm.textBox4.Text,
                ДатаСобеседования = userInformationForm.dateTimePicker1.Value.ToShortDateString(),
                Рейтинг = userInformationForm.comboBox4.Text,
                Пояснения = userInformationForm.textBox5.Text
            };
            database.UsersSet.Add(user);
            userTable.Refresh();

            Skills skills = new Skills
            {
                ЯзыкиПрограммирования = string.Join(", ", userInformationForm.listBox1.Items.Cast<Skills>()),
                Фреймворки = string.Join(", ", userInformationForm.listBox2.Items.Cast<Skills>()),
                Библиотеки = string.Join(", ", userInformationForm.listBox3.Items.Cast<Skills>())
            };

            database.SkillsSet.Add(skills);
            skillTable.Refresh();

            InterviewersSet interviewersSet = new InterviewersSet
            {
                ФИО = string.Join(", ", userInformationForm.listBox5.Items.Cast<InterviewersSet>())
            };
            database.InterviewersSet.Add(interviewersSet);
            interviewerTable.Refresh();
            database.SaveChanges();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (userTable.SelectedRows.Count > 0)
                {
                    int index = (Int32)userTable.CurrentCell.Value;
                    UsersSet userSet = database.UsersSet.Find(index);
                    database.UsersSet.Remove(userSet);
                    Skills skills = database.SkillsSet.Find(index);
                    database.SkillsSet.Remove(skills);
                    InterviewersSet interviewersSet = database.InterviewersSet.Find(index);
                    database.InterviewersSet.Remove(interviewersSet);
                    database.SaveChanges();
                    userTable.Refresh();
                    skillTable.Refresh();
                    interviewerTable.Refresh();
                }
            }
            catch
            {
                MessageBox.Show("Выберите номер Id строки, которую требуется удалить!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (userTable.SelectedRows.Count > 0)
            {
                try
                {
                    int index = (Int32)userTable.CurrentCell.Value;
                    UsersSet userSet = database.UsersSet.Find(index);
                    UserInformationForm userInformationForm = new UserInformationForm();

                    userInformationForm.textBox1.Text = userSet.Фамилия;
                    userInformationForm.textBox2.Text = userSet.Имя;
                    userInformationForm.textBox3.Text = userSet.Отчество;
                    userInformationForm.textBox4.Text = userSet.Ссылка;
                    userInformationForm.comboBox4.Text = userSet.Рейтинг;
                    userInformationForm.textBox5.Text = userSet.Пояснения;

                    DialogResult result = userInformationForm.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                        return;

                    userSet.Фамилия = userInformationForm.textBox1.Text;
                    userSet.Имя = userInformationForm.textBox2.Text;
                    userSet.Отчество = userInformationForm.textBox3.Text;
                    userSet.Ссылка = userInformationForm.textBox4.Text;
                    userSet.ДатаСобеседования = userInformationForm.dateTimePicker1.Value.ToShortDateString();
                    userSet.Рейтинг = userInformationForm.comboBox4.Text;
                    userSet.Пояснения = userInformationForm.textBox5.Text;

                    Skills skills = database.SkillsSet.Find(index);
                    skills.ЯзыкиПрограммирования = string.Join(", ", userInformationForm.listBox1.Items.Cast<Skills>());
                    skills.Фреймворки = string.Join(", ", userInformationForm.listBox2.Items.Cast<Skills>());
                    skills.Библиотеки = string.Join(", ", userInformationForm.listBox3.Items.Cast<Skills>());

                    InterviewersSet interviewersSet = database.InterviewersSet.Find(index);
                    interviewersSet.ФИО = string.Join(", ", userInformationForm.listBox5.Items.Cast<InterviewersSet>());
                    database.SaveChanges();
                    userTable.Refresh();
                    skillTable.Refresh();
                    interviewerTable.Refresh();
                }
                catch
                {
                    MessageBox.Show("Выберите номер Id строки, которую требуется отредактировать!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
            }
        }
        private void FileAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog() { FileName = "" })
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string name = Path.GetFileName (dialog.FileName);
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.System);
                        int index = (Int32)userTable.CurrentCell.Value;
                        UsersSet userSet = database.UsersSet.Find(index);
                        userSet.Файлы = path + "\\" + name;
                        database.SaveChanges();
                        userTable.Refresh();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Выберите номер Id строки, к которой требуется добавить файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }
    }
}


