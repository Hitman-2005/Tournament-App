namespace Tournament_App
{
    partial class AccountList
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
            account_list_box = new ReaLTaiizor.Controls.CrownListView();
            SuspendLayout();
            // 
            // account_list_box
            // 
            account_list_box.BackColor = Color.FromArgb(12, 27, 41);
            account_list_box.ForeColor = SystemColors.ButtonFace;
            account_list_box.Location = new Point(0, -1);
            account_list_box.Name = "account_list_box";
            account_list_box.Size = new Size(674, 523);
            account_list_box.TabIndex = 0;
            account_list_box.Text = "crownListView1";
            account_list_box.Click += account_list_box_Click;
            // 
            // AccountList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 27, 41);
            ClientSize = new Size(671, 523);
            Controls.Add(account_list_box);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccountList";
            Text = "AccountList";
            Load += AccountList_Load;
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CrownListView account_list_box;
    }
}