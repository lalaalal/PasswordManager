namespace PasswordManager
{
    partial class PasswordViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newNameLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.newNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.passwordColumnLabel = new System.Windows.Forms.Label();
            this.nameColumnLabel = new System.Windows.Forms.Label();
            this.numColumnLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.passwordTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.Controls.Add(this.newPasswordTextBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.newNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.newPasswordLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.newNameTextBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 403);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 35);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.newPasswordTextBox.Location = new System.Drawing.Point(428, 7);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '*';
            this.newPasswordTextBox.Size = new System.Drawing.Size(269, 21);
            this.newPasswordTextBox.TabIndex = 5;
            // 
            // newNameLabel
            // 
            this.newNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newNameLabel.AutoSize = true;
            this.newNameLabel.Location = new System.Drawing.Point(18, 11);
            this.newNameLabel.Name = "newNameLabel";
            this.newNameLabel.Size = new System.Drawing.Size(39, 12);
            this.newNameLabel.TabIndex = 2;
            this.newNameLabel.Text = "Name";
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(703, 6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(70, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(372, 11);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(31, 12);
            this.newPasswordLabel.TabIndex = 3;
            this.newPasswordLabel.Text = "P.W.";
            // 
            // newNameTextBox
            // 
            this.newNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.newNameTextBox.Location = new System.Drawing.Point(78, 7);
            this.newNameTextBox.Name = "newNameTextBox";
            this.newNameTextBox.Size = new System.Drawing.Size(269, 21);
            this.newNameTextBox.TabIndex = 4;
            // 
            // passwordTableLayout
            // 
            this.passwordTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTableLayout.AutoScroll = true;
            this.passwordTableLayout.AutoSize = true;
            this.passwordTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.passwordTableLayout.ColumnCount = 4;
            this.passwordTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.passwordTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.passwordTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.passwordTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.passwordTableLayout.Controls.Add(this.passwordColumnLabel, 2, 0);
            this.passwordTableLayout.Controls.Add(this.nameColumnLabel, 1, 0);
            this.passwordTableLayout.Controls.Add(this.numColumnLabel, 0, 0);
            this.passwordTableLayout.Location = new System.Drawing.Point(12, 12);
            this.passwordTableLayout.Name = "passwordTableLayout";
            this.passwordTableLayout.RowCount = 1;
            this.passwordTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.passwordTableLayout.Size = new System.Drawing.Size(776, 39);
            this.passwordTableLayout.TabIndex = 0;
            // 
            // passwordColumnLabel
            // 
            this.passwordColumnLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordColumnLabel.AutoSize = true;
            this.passwordColumnLabel.Location = new System.Drawing.Point(489, 13);
            this.passwordColumnLabel.Name = "passwordColumnLabel";
            this.passwordColumnLabel.Size = new System.Drawing.Size(62, 12);
            this.passwordColumnLabel.TabIndex = 3;
            this.passwordColumnLabel.Text = "Password";
            // 
            // nameColumnLabel
            // 
            this.nameColumnLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameColumnLabel.AutoSize = true;
            this.nameColumnLabel.Location = new System.Drawing.Point(205, 13);
            this.nameColumnLabel.Name = "nameColumnLabel";
            this.nameColumnLabel.Size = new System.Drawing.Size(39, 12);
            this.nameColumnLabel.TabIndex = 2;
            this.nameColumnLabel.Text = "Name";
            // 
            // numColumnLabel
            // 
            this.numColumnLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numColumnLabel.AutoSize = true;
            this.numColumnLabel.Location = new System.Drawing.Point(26, 13);
            this.numColumnLabel.Name = "numColumnLabel";
            this.numColumnLabel.Size = new System.Drawing.Size(25, 12);
            this.numColumnLabel.TabIndex = 1;
            this.numColumnLabel.Text = "No.";
            // 
            // PasswordViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordTableLayout);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PasswordViewer";
            this.Text = "PasswordViewer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.passwordTableLayout.ResumeLayout(false);
            this.passwordTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label newNameLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox newNameTextBox;
        private System.Windows.Forms.TableLayoutPanel passwordTableLayout;
        private System.Windows.Forms.Label passwordColumnLabel;
        private System.Windows.Forms.Label nameColumnLabel;
        private System.Windows.Forms.Label numColumnLabel;
    }
}