using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class SignUpForm : Form
    {
        private UserData userData;

        public SignUpForm()
        {
            userData = UserData.GetInstance();
            InitializeComponent();
            idTextBox.KeyDown += new KeyEventHandler(OnEnterKeyPress);
            pwTextBox.KeyDown += new KeyEventHandler(OnEnterKeyPress);
            pwCheckTextBox.KeyDown += new KeyEventHandler(OnEnterKeyPress);
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (!CheckIdExists() && CheckPwIsCorrect())
            {
                MessageBox.Show("Succeed!", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userData.AddUser(idTextBox.Text, pwTextBox.Text);
                userData.Save();
                Dispose();
            }
            
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CheckIdExists())
            {
                warningLabel.Text = "ID Exists";
                warningLabel.Visible = true;
            }
            else
            {
                warningLabel.Visible = false;
            }
        }

        private void PwCheckTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!CheckPwIsCorrect())
            {
                warningLabel.Text = "PW Not Matches";
                warningLabel.Visible = true;
            } 
            else
            {
                warningLabel.Visible = false;
            }
        }

        private bool CheckIdExists()
        {
            return userData.IdExists(idTextBox.Text);
        }

        private bool CheckPwIsCorrect()
        {
            return pwTextBox.Text == pwCheckTextBox.Text;
        }

        private void OnEnterKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SignUpButton_Click(sender, e);
        }
    }

}
