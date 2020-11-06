namespace Test
{
    partial class MainUsersForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.userTable = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.skillTable = new System.Windows.Forms.DataGridView();
            this.Фреймворки = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interviewerTable = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.FileAddButton = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Файлы = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interviewersSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.языкиПрограммированияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.библиотекиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ссылкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаСобеседованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рейтингDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поясненияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interviewerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interviewersSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userTable
            // 
            this.userTable.AllowUserToAddRows = false;
            this.userTable.AutoGenerateColumns = false;
            this.userTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.ссылкаDataGridViewTextBoxColumn,
            this.датаСобеседованияDataGridViewTextBoxColumn,
            this.рейтингDataGridViewTextBoxColumn,
            this.поясненияDataGridViewTextBoxColumn,
            this.Файлы});
            this.userTable.DataSource = this.usersSetBindingSource;
            this.userTable.Location = new System.Drawing.Point(31, 35);
            this.userTable.Name = "userTable";
            this.userTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userTable.Size = new System.Drawing.Size(743, 108);
            this.userTable.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(31, 302);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(164, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить пользователя";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // skillTable
            // 
            this.skillTable.AllowUserToAddRows = false;
            this.skillTable.AutoGenerateColumns = false;
            this.skillTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.skillTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skillTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.языкиПрограммированияDataGridViewTextBoxColumn,
            this.Фреймворки,
            this.библиотекиDataGridViewTextBoxColumn});
            this.skillTable.DataSource = this.skillsBindingSource;
            this.skillTable.Location = new System.Drawing.Point(31, 149);
            this.skillTable.Name = "skillTable";
            this.skillTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.skillTable.Size = new System.Drawing.Size(421, 119);
            this.skillTable.TabIndex = 2;
            // 
            // Фреймворки
            // 
            this.Фреймворки.DataPropertyName = "Фреймворки";
            this.Фреймворки.HeaderText = "Фреймворки";
            this.Фреймворки.Name = "Фреймворки";
            // 
            // interviewerTable
            // 
            this.interviewerTable.AllowUserToAddRows = false;
            this.interviewerTable.AutoGenerateColumns = false;
            this.interviewerTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.interviewerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.interviewerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn});
            this.interviewerTable.DataSource = this.interviewersSetBindingSource;
            this.interviewerTable.Location = new System.Drawing.Point(458, 149);
            this.interviewerTable.Name = "interviewerTable";
            this.interviewerTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.interviewerTable.Size = new System.Drawing.Size(316, 119);
            this.interviewerTable.TabIndex = 3;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(407, 302);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(169, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Удалить пользователя";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(211, 302);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(180, 23);
            this.EditButton.TabIndex = 5;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // FileAddButton
            // 
            this.FileAddButton.Location = new System.Drawing.Point(714, 302);
            this.FileAddButton.Name = "FileAddButton";
            this.FileAddButton.Size = new System.Drawing.Size(60, 23);
            this.FileAddButton.TabIndex = 6;
            this.FileAddButton.Text = "Файл";
            this.FileAddButton.UseVisualStyleBackColor = true;
            this.FileAddButton.Click += new System.EventHandler(this.FileAddButton_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Файлы
            // 
            this.Файлы.DataPropertyName = "Файлы";
            this.Файлы.HeaderText = "Файлы";
            this.Файлы.Name = "Файлы";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // interviewersSetBindingSource
            // 
            this.interviewersSetBindingSource.DataSource = typeof(Test.InterviewersSet);
            // 
            // языкиПрограммированияDataGridViewTextBoxColumn
            // 
            this.языкиПрограммированияDataGridViewTextBoxColumn.DataPropertyName = "ЯзыкиПрограммирования";
            this.языкиПрограммированияDataGridViewTextBoxColumn.HeaderText = "ЯзыкиПрограммирования";
            this.языкиПрограммированияDataGridViewTextBoxColumn.Name = "языкиПрограммированияDataGridViewTextBoxColumn";
            // 
            // библиотекиDataGridViewTextBoxColumn
            // 
            this.библиотекиDataGridViewTextBoxColumn.DataPropertyName = "Библиотеки";
            this.библиотекиDataGridViewTextBoxColumn.HeaderText = "Библиотеки";
            this.библиотекиDataGridViewTextBoxColumn.Name = "библиотекиDataGridViewTextBoxColumn";
            // 
            // skillsBindingSource
            // 
            this.skillsBindingSource.DataSource = typeof(Test.Skills);
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // ссылкаDataGridViewTextBoxColumn
            // 
            this.ссылкаDataGridViewTextBoxColumn.DataPropertyName = "Ссылка";
            this.ссылкаDataGridViewTextBoxColumn.HeaderText = "Ссылка на резюме";
            this.ссылкаDataGridViewTextBoxColumn.Name = "ссылкаDataGridViewTextBoxColumn";
            // 
            // датаСобеседованияDataGridViewTextBoxColumn
            // 
            this.датаСобеседованияDataGridViewTextBoxColumn.DataPropertyName = "ДатаСобеседования";
            this.датаСобеседованияDataGridViewTextBoxColumn.HeaderText = "Дата собеседования";
            this.датаСобеседованияDataGridViewTextBoxColumn.Name = "датаСобеседованияDataGridViewTextBoxColumn";
            // 
            // рейтингDataGridViewTextBoxColumn
            // 
            this.рейтингDataGridViewTextBoxColumn.DataPropertyName = "Рейтинг";
            this.рейтингDataGridViewTextBoxColumn.HeaderText = "Рейтинг";
            this.рейтингDataGridViewTextBoxColumn.Name = "рейтингDataGridViewTextBoxColumn";
            // 
            // поясненияDataGridViewTextBoxColumn
            // 
            this.поясненияDataGridViewTextBoxColumn.DataPropertyName = "Пояснения";
            this.поясненияDataGridViewTextBoxColumn.HeaderText = "Пояснения";
            this.поясненияDataGridViewTextBoxColumn.Name = "поясненияDataGridViewTextBoxColumn";
            // 
            // usersSetBindingSource
            // 
            this.usersSetBindingSource.DataSource = typeof(Test.UsersSet);
            // 
            // MainUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 392);
            this.Controls.Add(this.FileAddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.interviewerTable);
            this.Controls.Add(this.skillTable);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.userTable);
            this.Name = "MainUsersForm";
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interviewerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interviewersSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userTable;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView skillTable;
        protected internal System.Windows.Forms.DataGridView interviewerTable;
        private System.Windows.Forms.BindingSource usersSetBindingSource;        
        private System.Windows.Forms.BindingSource skillsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource interviewersSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn языкиПрограммированияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Фреймворки;
        private System.Windows.Forms.DataGridViewTextBoxColumn библиотекиDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button FileAddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ссылкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаСобеседованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рейтингDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поясненияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Файлы;
    }
}

