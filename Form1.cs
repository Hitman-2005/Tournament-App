using System.Runtime.InteropServices;

namespace Tournament_App
{
    public partial class Form1 : Form
    {
        List<AccountModel> account = new List<AccountModel>();
        public Form1()
        {
            InitializeComponent();
            this.mainPanelForm.Controls.Clear();
            frontNotice FrontNotice = new frontNotice() { Dock = DockStyle.Fill, TopLevel = false };
            this.mainPanelForm.Controls.Add(FrontNotice);
            FrontNotice.Show();

            LoadAccountList();
        }

        private void LoadAccountList()
        {
            account = SqliteDataAccess.LoadAccount();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void min_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void show_pass_checkbox_Load(object sender, EventArgs e)
        {
            if (show_pass_checkbox.Checked)
            {
                
            }
            else
            {
                
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            AccountModel a = new()
            {
                Email = email_textbox.Text.ToString().Trim(),
                Password = email_textbox.Text.ToString().Trim()
            };

            SqliteDataAccess.SaveAccount(a);
            MessageBox.Show("Account have been Registered");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.mainPanelForm.Controls.Clear();
            frontNotice FrontNotice = new frontNotice() { Dock = DockStyle.Fill, TopLevel = false };
            this.mainPanelForm.Controls.Add(FrontNotice);
            FrontNotice.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.mainPanelForm.Controls.Clear();
            AccountList accountList = new AccountList() { Dock = DockStyle.Fill, TopLevel = false };
            this.mainPanelForm.Controls.Add(accountList);
            accountList.Show();
        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {

        }
    }
}