namespace C_Sharp
{
    partial class Form1
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
            this.lv_person = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.first_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.second_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txId = new System.Windows.Forms.TextBox();
            this.txFirstName = new System.Windows.Forms.TextBox();
            this.txSecondName = new System.Windows.Forms.TextBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_person
            // 
            this.lv_person.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.first_name,
            this.second_name});
            this.lv_person.GridLines = true;
            this.lv_person.Location = new System.Drawing.Point(12, 12);
            this.lv_person.MultiSelect = false;
            this.lv_person.Name = "lv_person";
            this.lv_person.Size = new System.Drawing.Size(350, 243);
            this.lv_person.TabIndex = 0;
            this.lv_person.UseCompatibleStateImageBehavior = false;
            this.lv_person.View = System.Windows.Forms.View.Details;
            this.lv_person.SelectedIndexChanged += new System.EventHandler(this.lv_person_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 50;
            // 
            // first_name
            // 
            this.first_name.Text = "First name";
            this.first_name.Width = 150;
            // 
            // second_name
            // 
            this.second_name.Text = "Second name";
            this.second_name.Width = 150;
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(366, 95);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(100, 20);
            this.txId.TabIndex = 1;
            // 
            // txFirstName
            // 
            this.txFirstName.Location = new System.Drawing.Point(366, 121);
            this.txFirstName.Name = "txFirstName";
            this.txFirstName.Size = new System.Drawing.Size(100, 20);
            this.txFirstName.TabIndex = 2;
            // 
            // txSecondName
            // 
            this.txSecondName.Location = new System.Drawing.Point(366, 147);
            this.txSecondName.Name = "txSecondName";
            this.txSecondName.Size = new System.Drawing.Size(100, 20);
            this.txSecondName.TabIndex = 3;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(368, 12);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(100, 23);
            this.btnFile.TabIndex = 4;
            this.btnFile.Text = "File";
            this.btnFile.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(366, 173);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(99, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(368, 232);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(368, 203);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(97, 23);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(480, 267);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.txSecondName);
            this.Controls.Add(this.txFirstName);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.lv_person);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_person;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader first_name;
        private System.Windows.Forms.ColumnHeader second_name;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.TextBox txFirstName;
        private System.Windows.Forms.TextBox txSecondName;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
    }
}

