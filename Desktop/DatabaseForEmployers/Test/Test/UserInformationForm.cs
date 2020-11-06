using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class UserInformationForm : System.Windows.Forms.Form
    {
        public UserInformationForm()
        {
            InitializeComponent();
            List<Skills> frameworkSet = new List<Skills>
            {
                  new Skills { Id = 0, Фреймворки = "Express"},
                  new Skills { Id = 0, Фреймворки = "Django" },
                  new Skills { Id = 0, Фреймворки = "Rails" },
                  new Skills { Id = 0, Фреймворки = "Spring" },
                  new Skills { Id = 0, Фреймворки = "Angular" },
                  new Skills { Id = 0, Фреймворки = "-" },
            };

            List<Skills> languagesSet = new List<Skills>
            {
                new Skills {Id = 1, ЯзыкиПрограммирования = "Java" },
                new Skills {Id = 1, ЯзыкиПрограммирования = "C#" },
                new Skills {Id = 1, ЯзыкиПрограммирования = "SQL" },
                new Skills {Id = 1, ЯзыкиПрограммирования = "C++" },
                new Skills {Id = 1, ЯзыкиПрограммирования = "JavaScript" },
                new Skills {Id = 1, ЯзыкиПрограммирования = "Delphi" },
                new Skills {Id = 1, ЯзыкиПрограммирования = "-" },
            };

            List<Skills> librarySet = new List<Skills>
            {
                new Skills {Id = 2, Библиотеки = "HtmlAgilityPack" },
                new Skills {Id = 2, Библиотеки = "LinqToXml" },
                new Skills {Id = 2, Библиотеки = "V8" },
                new Skills {Id = 2, Библиотеки = "WebKit" },
                new Skills {Id = 2, Библиотеки = "Libcurl" },
                new Skills {Id = 2, Библиотеки = "Libpq" },
                new Skills {Id = 2, Библиотеки = "-" },
            };

            comboBox1.DataSource = languagesSet;
            comboBox1.DisplayMember = "ЯзыкиПрограммирования";
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            listBox1.DisplayMember = "ЯзыкиПрограммирования";

            comboBox2.DataSource = frameworkSet;
            comboBox2.DisplayMember = "Фреймворки";
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            listBox2.DisplayMember = "Фреймворки";
            comboBox2.SelectedItem = " ";

            comboBox3.DataSource = librarySet;
            comboBox3.DisplayMember = "Библиотеки";
            comboBox3.SelectedIndexChanged += ComboBox3_SelectedIndexChanged;
            listBox3.DisplayMember = "Библиотеки";

            List<InterviewersSet> interviewersSet = new List<InterviewersSet>
            {
                  new InterviewersSet { Id = 0, ФИО = "Иванов Петр Владимирович"},
                  new InterviewersSet { Id = 1, ФИО = "Петров Владимир Павлович" },
                  new InterviewersSet { Id = 2, ФИО = "Стариков Артём Викторович " },
                  new InterviewersSet { Id = 3, ФИО = "Малышева Ева Ивановна" },
                  new InterviewersSet { Id = 4, ФИО = "Воробцов Павел Андреевич" },

            };
            listBox4.DataSource = interviewersSet;           
        }

        public void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Skills languages = (Skills)comboBox1.SelectedItem;
            listBox1.Items.Add(languages);
        }

        public void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Skills frameworks = (Skills)comboBox2.SelectedItem;
            listBox2.Items.Add(frameworks);          
        }

        public void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Skills libraries = (Skills)comboBox3.SelectedItem;
            listBox3.Items.Add(libraries);
        }

        private void SelectionButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox4.SelectedItems.Count; i++)
            {
                listBox5.Items.Add(listBox4.SelectedItems[i]);
            }
        }        
    }
}
