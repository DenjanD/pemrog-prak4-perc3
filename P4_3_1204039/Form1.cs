using System.Text.RegularExpressions;

namespace P4_3_1204039
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, "Textbox Huruf tidak boleh kosong!");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
            else
            {
                if ((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtHuruf, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "");
                }
            }     
        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                epWarning.SetError(txtAngka, "Textbox Angka tidak boleh kosong!");
                epWrong.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "");
            }
            else
            {
                if ((txtAngka.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(txtAngka, "Betul!");
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "");
                }
                else
                {
                    epCorrect.SetError(txtAngka, "");
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "Inputan hanya boleh angka!");
                }
            }  
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtEmail, "Textbox Email tidak boleh kosong!");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
            else
            {
                if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtEmail, "Format email salah!\nContoh: a@b.c");
                    epWarning.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "");
                }
            }  
        }

        private void txtAngka1_TextChanged(object sender, EventArgs e)
        {
            if (txtAngka2.Text != "")
            {
                if (int.Parse(txtAngka1.Text) > int.Parse(txtAngka2.Text))
                {
                    epWrong.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka1, "Angka 1 tidak boleh lebih dari Angka 2");
                    epCorrect.SetError(txtAngka1, "");
                }
                else
                {
                    epWrong.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka1, "Betul!");

                    epWrong.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "Betul!");
                }
            }
            else
            {
                
            }
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            if (txtAngka1.Text != "")
            {
                if (int.Parse(txtAngka1.Text) > int.Parse(txtAngka2.Text))
                {
                    epWrong.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka1, "Angka 1 harus kurang dari Angka 2");
                    epCorrect.SetError(txtAngka1, "");
                }
                else
                {
                    epWrong.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka1, "Betul!");

                    epWrong.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka2, "");
                    epCorrect.SetError(txtAngka2, "Betul!");
                }
            }
            else
            {
                
            }
        }
    }
}