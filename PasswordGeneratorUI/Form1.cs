using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static PasswordGeneratorUI.PasswordMaker;

namespace PasswordGeneratorUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string key = "";

        private void IncludeUppercase_CheckedChanged(object sender, EventArgs e) { }
      
        private void IncludeLowerCase_CheckedChanged(object sender, EventArgs e) { }
     
        private void IncludeNumbers_CheckedChanged(object sender, EventArgs e) { }
      
        private void Symbols_CheckedChanged(object sender, EventArgs e) { }
       
        private void PasswordLengthTrackBar_Scroll(object sender, EventArgs e)
        {
            LengthLabel.Text = PasswordLengthTrackBar.Value.ToString();
        }

        private void LengthLabel_Click(object sender, EventArgs e) { }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e) { }
      
        private void GeneratePasswordBtn_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Clear();

            key = SetSourceFile();

            List<char> characters = GeneratePassword(PasswordLengthTrackBar.Value,key);

            if(characters != null)
            {
                ErrorMessage.Text = "";

                foreach (var c in characters)
                {
                    PasswordTextBox.Text += c;
                }
            }
            else
            {
                ErrorMessage.Text = "You must check one of the boxes";
            }
            
        }

        private void Label_Click(object sender, EventArgs e) { }
        
        private string SetSourceFile()
        {
            if(IncludeUppercase.Checked == true && IncludeLowerCase.Checked == false 
                && IncludeNumbers.Checked == false && Symbols.Checked == false)
            {
                return "only_uppercase";
            }

            if (IncludeUppercase.Checked == false && IncludeLowerCase.Checked == true
               && IncludeNumbers.Checked == false && Symbols.Checked == false)
            {
                return "only_lowercase";
            }

            if (IncludeUppercase.Checked == false && IncludeLowerCase.Checked == false
               && IncludeNumbers.Checked == true && Symbols.Checked == false)
            {
                return "only_numbers";
            }

            if (IncludeUppercase.Checked == false && IncludeLowerCase.Checked == false
               && IncludeNumbers.Checked == false && Symbols.Checked == true)
            {
                return "only_symbols";
            }

            if (IncludeUppercase.Checked == true && IncludeLowerCase.Checked == true
               && IncludeNumbers.Checked == false && Symbols.Checked == false)
            {
                return "uppercase_lowercase";
            }

            if (IncludeUppercase.Checked == true && IncludeLowerCase.Checked == true
               && IncludeNumbers.Checked == true && Symbols.Checked == false)
            {
                return "upper_lower_numbers";
            }

            if (IncludeUppercase.Checked == true && IncludeLowerCase.Checked == false
               && IncludeNumbers.Checked == true && Symbols.Checked == false)
            {
                return "uppercase_numbers";
            }

            if (IncludeUppercase.Checked == false && IncludeLowerCase.Checked == true
              && IncludeNumbers.Checked == true && Symbols.Checked == false)
            {
                return "lowercase_numbers";
            }

            if (IncludeUppercase.Checked == true && IncludeLowerCase.Checked == false
              && IncludeNumbers.Checked == false && Symbols.Checked == true)
            {
                return "uppercase_symbols";
            }

            if (IncludeUppercase.Checked == false && IncludeLowerCase.Checked == true
              && IncludeNumbers.Checked == false && Symbols.Checked == true)
            {
                return "lowercase_symbols";
            }

            if (IncludeUppercase.Checked == false && IncludeLowerCase.Checked == false
             && IncludeNumbers.Checked == true && Symbols.Checked == true)
            {
                return "numbers_symbols";
            }

            if (IncludeUppercase.Checked == true && IncludeLowerCase.Checked == false
            && IncludeNumbers.Checked == true && Symbols.Checked == true)
            {
                return "uppercase_numbers_symbols";
            }

            if (IncludeUppercase.Checked == false && IncludeLowerCase.Checked == true
            && IncludeNumbers.Checked == true && Symbols.Checked == true)
            {
                return "lowercase_numbers_symbols";
            }

            if (IncludeUppercase.Checked == true && IncludeLowerCase.Checked == true
            && IncludeNumbers.Checked == false && Symbols.Checked == true)
            {
                return "upper_lower_symbols";
            }

            if (IncludeUppercase.Checked == false && IncludeLowerCase.Checked == false
            && IncludeNumbers.Checked == false && Symbols.Checked == false)
            {
                return "";
            }

            return "everything";
        }

        private void CopyToClipBoardBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                ErrorMessage.Text = "Nothing to copy to clipboard";
            }
            else
            {
                Clipboard.SetText(PasswordTextBox.Text);
            }
        }

        private void ErrorMessage_Click(object sender, EventArgs e) { }
    }
}
