namespace Questionnaire
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2_no = new System.Windows.Forms.RadioButton();
            this.radioButton1_yes = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label_search = new System.Windows.Forms.Label();
            this.textBox_searchMail = new System.Windows.Forms.TextBox();
            this.button1_load = new System.Windows.Forms.Button();
            this.button2_save = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton_noNeed = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton1_male = new System.Windows.Forms.RadioButton();
            this.label_message = new System.Windows.Forms.Label();
            this.button_afterLoadSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label_name.Location = new System.Drawing.Point(41, 147);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(49, 20);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(41, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(41, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(41, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(41, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Birthdate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(41, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(41, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Driving license";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(125, 144);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(245, 25);
            this.textBox_name.TabIndex = 1;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(125, 177);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(245, 25);
            this.textBox_surname.TabIndex = 1;
            this.textBox_surname.TextChanged += new System.EventHandler(this.textBox_surname_TextChanged);
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(125, 246);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(245, 25);
            this.textBox_phone.TabIndex = 1;
            this.textBox_phone.TextChanged += new System.EventHandler(this.textBox_phone_TextChanged);
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(125, 281);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(245, 25);
            this.textBox_email.TabIndex = 1;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(128, 313);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 25);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2_no);
            this.panel1.Controls.Add(this.radioButton1_yes);
            this.panel1.Location = new System.Drawing.Point(169, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 62);
            this.panel1.TabIndex = 6;
            // 
            // radioButton2_no
            // 
            this.radioButton2_no.AutoSize = true;
            this.radioButton2_no.Checked = true;
            this.radioButton2_no.Location = new System.Drawing.Point(3, 32);
            this.radioButton2_no.Name = "radioButton2_no";
            this.radioButton2_no.Size = new System.Drawing.Size(110, 21);
            this.radioButton2_no.TabIndex = 1;
            this.radioButton2_no.TabStop = true;
            this.radioButton2_no.Text = "No,I have not";
            this.radioButton2_no.UseVisualStyleBackColor = true;
            // 
            // radioButton1_yes
            // 
            this.radioButton1_yes.AutoSize = true;
            this.radioButton1_yes.Location = new System.Drawing.Point(3, 3);
            this.radioButton1_yes.Name = "radioButton1_yes";
            this.radioButton1_yes.Size = new System.Drawing.Size(91, 21);
            this.radioButton1_yes.TabIndex = 0;
            this.radioButton1_yes.Text = "Yes, I have";
            this.radioButton1_yes.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(41, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Questionnaire";
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_search.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label_search.Location = new System.Drawing.Point(7, 63);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(116, 20);
            this.label_search.TabIndex = 0;
            this.label_search.Text = "Search For Mail";
            // 
            // textBox_searchMail
            // 
            this.textBox_searchMail.Location = new System.Drawing.Point(125, 58);
            this.textBox_searchMail.Name = "textBox_searchMail";
            this.textBox_searchMail.Size = new System.Drawing.Size(245, 25);
            this.textBox_searchMail.TabIndex = 1;
            // 
            // button1_load
            // 
            this.button1_load.AutoEllipsis = true;
            this.button1_load.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1_load.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1_load.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1_load.Location = new System.Drawing.Point(298, 91);
            this.button1_load.Name = "button1_load";
            this.button1_load.Size = new System.Drawing.Size(72, 33);
            this.button1_load.TabIndex = 8;
            this.button1_load.Text = "Load";
            this.button1_load.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1_load.UseVisualStyleBackColor = false;
            this.button1_load.Click += new System.EventHandler(this.button1_load_Click);
            // 
            // button2_save
            // 
            this.button2_save.AutoEllipsis = true;
            this.button2_save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2_save.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2_save.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button2_save.Location = new System.Drawing.Point(41, 445);
            this.button2_save.Name = "button2_save";
            this.button2_save.Size = new System.Drawing.Size(86, 39);
            this.button2_save.TabIndex = 9;
            this.button2_save.Text = "Save";
            this.button2_save.UseVisualStyleBackColor = false;
            this.button2_save.Click += new System.EventHandler(this.button2_save_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton_noNeed);
            this.panel2.Controls.Add(this.radioButton_female);
            this.panel2.Controls.Add(this.radioButton1_male);
            this.panel2.Location = new System.Drawing.Point(128, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 32);
            this.panel2.TabIndex = 10;
            // 
            // radioButton_noNeed
            // 
            this.radioButton_noNeed.AutoSize = true;
            this.radioButton_noNeed.Checked = true;
            this.radioButton_noNeed.Location = new System.Drawing.Point(141, 5);
            this.radioButton_noNeed.Name = "radioButton_noNeed";
            this.radioButton_noNeed.Size = new System.Drawing.Size(78, 21);
            this.radioButton_noNeed.TabIndex = 11;
            this.radioButton_noNeed.TabStop = true;
            this.radioButton_noNeed.Text = "No need";
            this.radioButton_noNeed.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(65, 5);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(70, 21);
            this.radioButton_female.TabIndex = 11;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton1_male
            // 
            this.radioButton1_male.AutoSize = true;
            this.radioButton1_male.Location = new System.Drawing.Point(8, 6);
            this.radioButton1_male.Name = "radioButton1_male";
            this.radioButton1_male.Size = new System.Drawing.Size(56, 21);
            this.radioButton1_male.TabIndex = 0;
            this.radioButton1_male.Text = "Male";
            this.radioButton1_male.UseVisualStyleBackColor = true;
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.ForeColor = System.Drawing.Color.Green;
            this.label_message.Location = new System.Drawing.Point(46, 487);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(0, 17);
            this.label_message.TabIndex = 11;
            this.label_message.Visible = false;
            // 
            // button_afterLoadSave
            // 
            this.button_afterLoadSave.AutoSize = true;
            this.button_afterLoadSave.BackColor = System.Drawing.Color.SeaGreen;
            this.button_afterLoadSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_afterLoadSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_afterLoadSave.Location = new System.Drawing.Point(40, 445);
            this.button_afterLoadSave.Name = "button_afterLoadSave";
            this.button_afterLoadSave.Size = new System.Drawing.Size(107, 39);
            this.button_afterLoadSave.TabIndex = 9;
            this.button_afterLoadSave.Text = "Save Change";
            this.button_afterLoadSave.UseVisualStyleBackColor = false;
            this.button_afterLoadSave.Visible = false;
            this.button_afterLoadSave.Click += new System.EventHandler(this.button_afterLoadSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(441, 523);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_afterLoadSave);
            this.Controls.Add(this.button2_save);
            this.Controls.Add(this.button1_load);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_searchMail);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.label_name);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_name;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox_name;
        private TextBox textBox_surname;
        private TextBox textBox_phone;
        private TextBox textBox_email;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private RadioButton radioButton2_no;
        private RadioButton radioButton1_yes;
        private Label label7;
        private Label label_search;
        private TextBox textBox_searchMail;
        private Button button1_load;
        private Button button2_save;
        private Panel panel2;
        private RadioButton radioButton_female;
        private RadioButton radioButton1_male;
        private RadioButton radioButton_noNeed;
        private Label label_message;
        private Button button_afterLoadSave;
    }
}