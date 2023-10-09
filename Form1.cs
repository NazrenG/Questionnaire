
using Questionnaire.Class;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Questionnaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool IsJsonFileEmpty(string filePath)
        {
            try
            {
                string jsonContent = File.ReadAllText(filePath);
                return string.IsNullOrWhiteSpace(jsonContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
        public List<Person> people = new();
        //yadda saxla
        private void button2_save_Click(object sender, EventArgs e)
        {
            button2_save.Visible = true;
            button_afterLoadSave.Visible = false;
            label_message.Visible = false;
            string name = textBox_name.Text;
            string surname = textBox_surname.Text;
            string phone = textBox_phone.Text;
            string mail = textBox_email.Text;
            DateTime date = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            Gender gender = Gender.none;
            if (radioButton1_male.Checked) gender = Gender.male;
            else if (radioButton_female.Checked) { gender = Gender.female; }
            else if (radioButton_noNeed.Checked) { gender = Gender.none; }
            bool drivingLicence;
            if (radioButton1_yes.Checked) drivingLicence = true;
            else drivingLicence = false;

            bool checkError = true;
            CheckError(ref checkError);
            if (checkError)
            {
                if (ControlToMail())
                {
                    Person person = new Person(name, surname, phone, mail, date, gender, drivingLicence);
                    //Json
                    string json = File.ReadAllText("../../../Json/personJson.json");
                    bool isEmpty = IsJsonFileEmpty("../../../Json/personJson.json");
                    if (isEmpty)//file bosdursa
                    {
                        people.Add(person);
                    }
                    else
                    {
                        var listt = JsonSerializer.Deserialize<List<Person>>(json);
                        listt?.Add(person);
                        people = listt!;
                    }

                    JsonSerializerOptions options = new();
                    options.WriteIndented = true;
                    string txt = JsonSerializer.Serialize(people, options);
                    File.WriteAllText("../../../Json/personJson.json", txt);
                    ///
                    label_message.Visible = true;
                    label_message.Text = "Succesfull!!";


                    textBox_email.Text = null;
                    textBox_phone.Text = null;
                    textBox_name.Text = null;
                    textBox_surname.Text = null;
                    radioButton_noNeed.Checked = true;
                    radioButton2_no.Checked = false;

                    button_afterLoadSave.Enabled = false;
                    button2_save.Enabled = true;
                }
                else
                {
                    MessageBox.Show("This email address is valid,write another one!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        //maile gore axtaris et
        private void button1_load_Click(object sender, EventArgs e)
        {
            button_afterLoadSave.Visible = true;
            button2_save.Visible = false;
            label_message.Visible = false;
            string json = File.ReadAllText("../../../Json/personJson.json");
            bool isEmpty = IsJsonFileEmpty("../../../Json/personJson.json");
            if (isEmpty)//file bosdursa
            {
                MessageBox.Show("Database is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var list = JsonSerializer.Deserialize<List<Person>>(json);
                bool check = true;
                foreach (var item in list!)
                {
                    if (textBox_searchMail.Text == item.Email)
                    {
                        check = false;
                        textBox_name.Text = item.Name;
                        textBox_surname.Text = item.Surname;
                        textBox_email.Text = item.Email;
                        textBox_phone.Text = item.Phone;
                        if (item.Gender == Gender.male) radioButton1_male.Checked = true;
                        else if (item.Gender == Gender.female) radioButton_female.Checked = true;
                        else if (item.Gender == Gender.none) radioButton_noNeed.Checked = true;

                        if (item.DrivingLicence == true) radioButton1_yes.Checked = true;
                        else radioButton2_no.Checked = true;

                        dateTimePicker1.Value = new DateTime(item.DateTime.Year, item.DateTime.Month, item.DateTime.Day);
                        break;
                    }
                }
                if (check)
                {
                    label_message.Visible = true;
                    label_message.ForeColor = Color.Red;
                    label_message.Text = "Not found this person!!";
                }
            }

        }
        //serach etdikden sonra deyisiklikler yazilsin
        private void button_afterLoadSave_Click(object sender, EventArgs e)
        {
            label_message.Visible = false;
            bool checkError = true;
            string json = File.ReadAllText("../../../Json/personJson.json");
            var list = JsonSerializer.Deserialize<List<Person>>(json);
            foreach (var item in list!)
            {
                if (textBox_searchMail.Text == item.Email)
                {
                    list.Remove(item);
                    item.Name = textBox_name.Text;
                    item.Surname = textBox_surname.Text;
                    item.Email = textBox_email.Text;
                    item.Phone = textBox_phone.Text;
                    if (radioButton1_male.Checked) item.Gender = Gender.male;
                    else if (radioButton_female.Checked) { item.Gender = Gender.female; }
                    else if (radioButton_noNeed.Checked) { item.Gender = Gender.none; }

                    if (radioButton1_yes.Checked) item.DrivingLicence = true;
                    else item.DrivingLicence = false;

                    DateTime date = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
                    button_afterLoadSave.Visible = true;
                    button2_save.Visible = false;
                    CheckError(ref checkError);
                    if (checkError)
                    {
                        list.Add(item);
                    }
                    break;
                }
            }
            if (checkError)
            {
                people = list;
                JsonSerializerOptions options = new();
                options.WriteIndented = true;
                string txt = JsonSerializer.Serialize(people, options);
                File.WriteAllText("../../../Json/personJson.json", txt);

                label_message.ForeColor = Color.Green;
                label_message.Text = "Edited successfully!!";
                label_message.Visible = true;

                textBox_email.Text = null;
                textBox_phone.Text = null;
                textBox_name.Text = null;
                textBox_surname.Text = null;
            }

        }
        //eyni mail daxil etmek olmasin
        public bool ControlToMail()
        {
            string json = File.ReadAllText("../../../Json/personJson.json");
            bool isEmpty = IsJsonFileEmpty("../../../Json/personJson.json");
            if (!isEmpty)//file bos deyilse
            {
                var list = JsonSerializer.Deserialize<List<Person>>(json);
                foreach (var item in list!)
                {
                    if (textBox_email.Text == item.Email) return false;
                }
                return true;
            }
            else return true;
        }

        //ad ve soyada mehdudiyyet qoyulmasi
        public void CheckNameSurname(ref TextBox textBox, string text)
        {
            if (text.Length < 3) textBox.ForeColor = Color.Red;
            else textBox.ForeColor = Color.Black;
        }
        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            var MyTextBox = sender as TextBox;
            CheckNameSurname(ref MyTextBox!, textBox_name.Text);
        }

        private void textBox_surname_TextChanged(object sender, EventArgs e)
        {
            var MyTextBox = sender as TextBox;
            CheckNameSurname(ref MyTextBox!, textBox_surname.Text);
        }
        //telefon ve mail ucun regex
        public void CheckRegex(ref TextBox textBox, Regex regex, string text)
        {
            if (regex.IsMatch(textBox.Text)) textBox!.ForeColor = Color.Green;
            else textBox!.ForeColor = Color.Red;
        }
        private void textBox_phone_TextChanged(object sender, EventArgs e)
        {
            var PhoneTextBox = sender as TextBox;
            Regex regex = new Regex(@"\d{3}-\d{3}-\d{2}-\d{2}");
            CheckRegex(ref PhoneTextBox!, regex, textBox_phone.Text);
        }
        private void textBox_email_TextChanged(object sender, EventArgs e)
        {
            var EmailTextBox = sender as TextBox;
            Regex regex = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
            CheckRegex(ref EmailTextBox!, regex, textBox_email.Text);
        }
        //error message
        public void CheckError(ref bool checkError)
        {
            Regex regex_phone = new Regex(@"\d{3}-\d{3}-\d{2}-\d{2}");
            Regex regex_mail = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
            if (textBox_name.Text.Length < 3)
            {
                MessageBox.Show("Name length must be min 3 characther!", "Name Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkError = false;
            }
            if (textBox_surname.Text.Length < 3)
            {
                MessageBox.Show("Surname length must be min 3 characther!", "Surame Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkError = false;
            }

            if (!(regex_phone.IsMatch(textBox_phone.Text)))
            {
                MessageBox.Show("Correct syntax=>000-00-00!", "Phone Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkError = false;
            }
            if (!(regex_mail.IsMatch(textBox_email.Text)))
            {
                MessageBox.Show("You must use @ and .  at least once", "Email Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkError = false;
            }
        }


    }
}