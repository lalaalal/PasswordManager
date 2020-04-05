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
    public partial class PasswordViewer : Form
    {
        private PasswordManager passwordManager;

        public PasswordViewer(string userID, string userPW)
        {
            InitializeComponent();
            newPasswordTextBox.KeyDown += new KeyEventHandler(OnEnterKeyPress);
            try
            {
                passwordManager = new PasswordManager(userID, userPW);
                LoadPasswords();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "PasswordManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPasswords()
        {
            foreach (var data in passwordManager)
            {
                int no = passwordTableLayout.RowCount++;
                string name = data.Key;
                passwordManager.TryGetValue(name, out string password);
                AddRow(no, name, password);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                int no = passwordTableLayout.RowCount++;
                string name = newNameTextBox.Text;
                string password = newPasswordTextBox.Text;

                passwordManager.Add(name, password);
                passwordManager.Save();
                AddRow(no, name, password);
            }
            catch (Exception exception)
            {
                passwordTableLayout.RowCount--;
                MessageBox.Show(exception.Message, "PasswordManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddRow(int no, string name, string password)
        {
            passwordTableLayout.Controls.Add(new RowLabel(no.ToString(), "No"), 0, no);
            passwordTableLayout.Controls.Add(new RowLabel(name, "Name"), 1, no);
            passwordTableLayout.Controls.Add(new RowLabel(password, "Password"), 2, no);
            passwordTableLayout.Controls.Add(GetNewDeleteButton(no, name), 3, no);
            passwordTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
        }

        private Button GetNewDeleteButton(int no, string targetName)
        {
            Button deleteButton = new Button
            {
                Anchor = AnchorStyles.None,
                Text = "Delete",
                Name = "Delete"
            };
            deleteButton.Click += new EventHandler((sender, e) =>
            {
                passwordManager.Remove(targetName);
                passwordManager.Save();
                passwordTableLayout.Controls.Find("Name", true)[no - 1].Visible = false;
                passwordTableLayout.Controls.Find("Password", true)[no - 1].Visible = false;
                passwordTableLayout.Controls.Find("Delete", true)[no - 1].Visible = false;
            });
            return deleteButton;
        }

        private void OnEnterKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddButton_Click(sender, e);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
    }

    class RowLabel : Label
    {
        public RowLabel(string text, string name)
        {
            Anchor = AnchorStyles.None;
            AutoSize = true;
            Text = text;
            Name = name;
        }
    }
}
