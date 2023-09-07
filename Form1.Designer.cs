namespace Tournament_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            min_btn = new Button();
            close_btn = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            show_pass_checkbox = new ReaLTaiizor.Controls.CyberCheckBox();
            password_textbox = new ReaLTaiizor.Controls.CyberTextBox();
            email_textbox = new ReaLTaiizor.Controls.CyberTextBox();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            label8 = new Label();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            register_btn = new Button();
            panel6 = new Panel();
            mainPanelForm = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(9, 44, 79);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(min_btn);
            panel1.Controls.Add(close_btn);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 64);
            panel1.TabIndex = 0;
            panel1.MouseDown += OnMouseDown;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.icons8_account_40;
            button3.Location = new Point(291, 20);
            button3.Name = "button3";
            button3.Size = new Size(51, 44);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.icons8_house_48;
            button2.Location = new Point(230, 16);
            button2.Name = "button2";
            button2.Size = new Size(55, 48);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(146, 4);
            label5.Name = "label5";
            label5.Size = new Size(81, 23);
            label5.TabIndex = 8;
            label5.Text = "HITMAN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(129, 13);
            label4.Name = "label4";
            label4.Size = new Size(19, 13);
            label4.TabIndex = 7;
            label4.Text = "by";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(32, 4);
            label3.Name = "label3";
            label3.Size = new Size(101, 23);
            label3.TabIndex = 6;
            label3.Text = " Tourni App";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Tourni_logos_white__1_;
            pictureBox1.InitialImage = Properties.Resources.Tourni_logos_white__1_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 47);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.icons8_settings_501;
            button1.Location = new Point(729, 0);
            button1.Name = "button1";
            button1.Size = new Size(47, 36);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            // 
            // min_btn
            // 
            min_btn.FlatAppearance.BorderSize = 0;
            min_btn.FlatStyle = FlatStyle.Flat;
            min_btn.Image = Properties.Resources.icons8_minus_24;
            min_btn.Location = new Point(771, 0);
            min_btn.Name = "min_btn";
            min_btn.Size = new Size(47, 36);
            min_btn.TabIndex = 3;
            min_btn.UseVisualStyleBackColor = true;
            min_btn.Click += min_btn_Click;
            // 
            // close_btn
            // 
            close_btn.FlatAppearance.BorderSize = 0;
            close_btn.FlatStyle = FlatStyle.Flat;
            close_btn.Image = Properties.Resources.icons8_cross_30;
            close_btn.Location = new Point(815, 0);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(47, 36);
            close_btn.TabIndex = 2;
            close_btn.UseVisualStyleBackColor = true;
            close_btn.Click += close_btn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(0, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Location = new Point(2, -1);
            panel4.Name = "panel4";
            panel4.Size = new Size(860, 523);
            panel4.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(34, 34, 34);
            panel5.Controls.Add(show_pass_checkbox);
            panel5.Controls.Add(password_textbox);
            panel5.Controls.Add(email_textbox);
            panel5.Controls.Add(cyberButton1);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(register_btn);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(0, 64);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 522);
            panel5.TabIndex = 1;
            // 
            // show_pass_checkbox
            // 
            show_pass_checkbox.BackColor = Color.Transparent;
            show_pass_checkbox.Background = true;
            show_pass_checkbox.Background_WidthPen = 2F;
            show_pass_checkbox.BackgroundPen = true;
            show_pass_checkbox.Checked = false;
            show_pass_checkbox.ColorBackground = Color.FromArgb(37, 52, 68);
            show_pass_checkbox.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            show_pass_checkbox.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            show_pass_checkbox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            show_pass_checkbox.ColorChecked = Color.FromArgb(29, 200, 238);
            show_pass_checkbox.ColorPen_1 = Color.FromArgb(37, 52, 68);
            show_pass_checkbox.ColorPen_2 = Color.FromArgb(41, 63, 86);
            show_pass_checkbox.CyberCheckBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Default;
            show_pass_checkbox.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            show_pass_checkbox.Effect_1_Transparency = 25;
            show_pass_checkbox.Effect_2 = true;
            show_pass_checkbox.Effect_2_ColorBackground = Color.White;
            show_pass_checkbox.Effect_2_Transparency = 15;
            show_pass_checkbox.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            show_pass_checkbox.ForeColor = Color.FromArgb(245, 245, 245);
            show_pass_checkbox.LinearGradient_Background = false;
            show_pass_checkbox.LinearGradientPen = false;
            show_pass_checkbox.Location = new Point(12, 193);
            show_pass_checkbox.Name = "show_pass_checkbox";
            show_pass_checkbox.RGB = false;
            show_pass_checkbox.Rounding = true;
            show_pass_checkbox.RoundingInt = 100;
            show_pass_checkbox.Size = new Size(170, 45);
            show_pass_checkbox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            show_pass_checkbox.TabIndex = 0;
            show_pass_checkbox.Tag = "Cyber";
            show_pass_checkbox.TextButton = "CyberCheckBox";
            show_pass_checkbox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            show_pass_checkbox.Timer_Effect_1 = 1;
            show_pass_checkbox.Timer_RGB = 300;
            show_pass_checkbox.Load += show_pass_checkbox_Load;
            // 
            // password_textbox
            // 
            password_textbox.Alpha = 20;
            password_textbox.BackColor = Color.Transparent;
            password_textbox.Background_WidthPen = 3F;
            password_textbox.BackgroundPen = true;
            password_textbox.ColorBackground = Color.FromArgb(37, 52, 68);
            password_textbox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            password_textbox.ColorLighting = Color.FromArgb(29, 200, 238);
            password_textbox.ColorPen_1 = Color.FromArgb(29, 200, 238);
            password_textbox.ColorPen_2 = Color.FromArgb(37, 52, 68);
            password_textbox.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            password_textbox.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            password_textbox.ForeColor = Color.FromArgb(245, 245, 245);
            password_textbox.Lighting = false;
            password_textbox.LinearGradientPen = false;
            password_textbox.Location = new Point(2, 147);
            password_textbox.Name = "password_textbox";
            password_textbox.Password = true;
            password_textbox.PasswordChar = '*';
            password_textbox.PenWidth = 15;
            password_textbox.RGB = true;
            password_textbox.Rounding = true;
            password_textbox.RoundingInt = 60;
            password_textbox.Size = new Size(193, 40);
            password_textbox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            password_textbox.TabIndex = 12;
            password_textbox.Tag = "Cyber";
            password_textbox.TextButton = "";
            password_textbox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            password_textbox.Timer_RGB = 300;
            // 
            // email_textbox
            // 
            email_textbox.Alpha = 20;
            email_textbox.BackColor = Color.Transparent;
            email_textbox.Background_WidthPen = 3F;
            email_textbox.BackgroundPen = true;
            email_textbox.ColorBackground = Color.FromArgb(37, 52, 68);
            email_textbox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            email_textbox.ColorLighting = Color.FromArgb(29, 200, 238);
            email_textbox.ColorPen_1 = Color.FromArgb(29, 200, 238);
            email_textbox.ColorPen_2 = Color.FromArgb(37, 52, 68);
            email_textbox.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            email_textbox.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            email_textbox.ForeColor = Color.FromArgb(245, 245, 245);
            email_textbox.Lighting = false;
            email_textbox.LinearGradientPen = false;
            email_textbox.Location = new Point(3, 68);
            email_textbox.Name = "email_textbox";
            email_textbox.PenWidth = 15;
            email_textbox.RGB = true;
            email_textbox.Rounding = true;
            email_textbox.RoundingInt = 60;
            email_textbox.Size = new Size(193, 40);
            email_textbox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            email_textbox.TabIndex = 0;
            email_textbox.Tag = "Cyber";
            email_textbox.TextButton = "";
            email_textbox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            email_textbox.Timer_RGB = 300;
            // 
            // cyberButton1
            // 
            cyberButton1.Alpha = 20;
            cyberButton1.BackColor = Color.Transparent;
            cyberButton1.Background = true;
            cyberButton1.Background_WidthPen = 4F;
            cyberButton1.BackgroundPen = true;
            cyberButton1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton1.Effect_1_Transparency = 25;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.White;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cyberButton1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton1.Lighting = false;
            cyberButton1.LinearGradient_Background = false;
            cyberButton1.LinearGradientPen = false;
            cyberButton1.Location = new Point(44, 361);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.RGB = true;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(114, 37);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            cyberButton1.TabIndex = 11;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "LOGIN";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton1.Timer_Effect_1 = 5;
            cyberButton1.Timer_RGB = 300;
            cyberButton1.Click += cyberButton1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(18, 323);
            label8.Name = "label8";
            label8.Size = new Size(171, 19);
            label8.TabIndex = 10;
            label8.Text = "[ Already Registered ]";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(54, 8);
            label7.Name = "label7";
            label7.Size = new Size(110, 19);
            label7.TabIndex = 9;
            label7.Text = "[ REGISTER ]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(53, 123);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 7;
            label2.Text = "PASSWORD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(69, 44);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 6;
            label1.Text = "E-MAIL";
            // 
            // register_btn
            // 
            register_btn.FlatAppearance.BorderSize = 0;
            register_btn.FlatStyle = FlatStyle.Flat;
            register_btn.Image = Properties.Resources.icons8_login_64;
            register_btn.Location = new Point(68, 244);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(64, 65);
            register_btn.TabIndex = 3;
            register_btn.UseVisualStyleBackColor = true;
            register_btn.Click += register_btn_Click;
            // 
            // panel6
            // 
            panel6.Location = new Point(202, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 100);
            panel6.TabIndex = 2;
            // 
            // mainPanelForm
            // 
            mainPanelForm.BackColor = Color.FromArgb(12, 27, 41);
            mainPanelForm.Location = new Point(200, 64);
            mainPanelForm.Name = "mainPanelForm";
            mainPanelForm.Size = new Size(662, 522);
            mainPanelForm.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 584);
            Controls.Add(mainPanelForm);
            Controls.Add(panel5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private Panel panel5;
        private Panel panel6;
        private Panel mainPanelForm;
        private Button close_btn;
        private Button min_btn;
        private Button button1;
        private Button register_btn;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label8;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private ReaLTaiizor.Controls.CyberTextBox email_textbox;
        private ReaLTaiizor.Controls.CyberTextBox password_textbox;
        private ReaLTaiizor.Controls.CyberCheckBox show_pass_checkbox;
        private Button button2;
        private Button button3;
    }
}