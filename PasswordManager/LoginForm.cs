﻿using System;
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
    public partial class LoginForm : Form
    {
        private UserData userData;

        public LoginForm()
        {
            userData = UserData.GetInstance();

            InitializeComponent();
            idTextBox.KeyDown += new KeyEventHandler(OnEnterKeyPress);
            pwTextBox.KeyDown += new KeyEventHandler(OnEnterKeyPress);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string pw = pwTextBox.Text;
            try
            {
                if (!userData.Authorize(id, pw))
                    throw new Exception("IncorrectPassword");
                Visible = false;
                PasswordViewer passwordViewer = new PasswordViewer(id, pw);
                passwordViewer.ShowDialog();
                Dispose();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }

        private void OnEnterKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoginButton_Click(sender, e);
        }
    }
}
