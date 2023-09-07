namespace Tournament_App
{
    partial class tournamentList
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
            crownDropDownList1 = new ReaLTaiizor.Controls.CrownDropDownList();
            crownDropDownList2 = new ReaLTaiizor.Controls.CrownDropDownList();
            SuspendLayout();
            // 
            // crownDropDownList1
            // 
            crownDropDownList1.Location = new Point(0, 0);
            crownDropDownList1.Name = "crownDropDownList1";
            crownDropDownList1.Size = new Size(184, 26);
            crownDropDownList1.TabIndex = 0;
            crownDropDownList1.Text = "Current";
            // 
            // crownDropDownList2
            // 
            crownDropDownList2.Location = new Point(0, 32);
            crownDropDownList2.Name = "crownDropDownList2";
            crownDropDownList2.Size = new Size(184, 26);
            crownDropDownList2.TabIndex = 1;
            crownDropDownList2.Text = "Finished";
            // 
            // tournamentList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(184, 483);
            Controls.Add(crownDropDownList2);
            Controls.Add(crownDropDownList1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "tournamentList";
            Text = "tournamentList";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CrownDropDownList crownDropDownList1;
        private ReaLTaiizor.Controls.CrownDropDownList crownDropDownList2;
    }
}