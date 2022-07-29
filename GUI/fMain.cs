using HotelManagement.Models;
using System;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class fMain : Form
    {
        private Account account;
        public fMain(Account account)
        {
            InitializeComponent();
            this.account = account;
            label1.Text = $"Xin chào {account.DisplayName}";
            button1.Hide();
            if (account.Type == 1)
            {
                button1.Show();
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            fRoomManager open = new fRoomManager();
            this.Hide();
            open.ShowDialog();
            this.Show();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            fService open = new fService();
            this.Hide();
            open.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
