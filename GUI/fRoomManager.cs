using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class fRoomManager : Form
    {

        private static CultureInfo culture = new CultureInfo("vi-VN");
        public fRoomManager()
        {
            InitializeComponent();
            LoadList();
        }
        void LoadList()
        {
            LoadRoom();
            LoadServiceList();
        }

        void LoadServiceList()
        {
            using var context = new HotelManagementContext();
            List<Service> ServiceList = context.Services.ToList();
            cbAddService.DataSource = ServiceList;
            cbAddService.DisplayMember = "NameService";
            cbAddService.SelectedItem = ServiceList.FirstOrDefault();
        }
        void LoadRoom()
        {
            flpRoom.Controls.Clear();
            using var context = new HotelManagementContext();
            List<Room> TableList = context.Rooms.ToList();
            foreach (Room item in TableList)
            {
                Button btn = new Button()
                {
                    Width = 80,
                    Height = 80
                };
                btn.Text = item.Name + Environment.NewLine + (item.Status ? "[Có người]" : "[Trống]");
                if (item.Status)
                {
                    btn.Font = new Font(btn.Font, FontStyle.Bold);
                }
                btn.Click += btn_click;
                btn.Tag = item;

                if (item.Status)
                {
                    btn.BackColor = Color.Aqua;
                }
                else {
                    btn.BackColor = Color.White;
                }
                flpRoom.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            using var context = new HotelManagementContext();
            List<RoomBillView> listBillInfo = context.GetRoomBill(id).ToList();
            lsvBill.Items.Clear();

            float totalPrice = 0;
            foreach (var item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.NameService.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());


                totalPrice += item.TotalPrice;

                lsvBill.Items.Add(lsvItem);
            }

            //Thread.CurrentThread.CurrentCulture = culture;

            txbTotalPrice.Text = totalPrice.ToString("c", culture);
            
        }
        private void btn_click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            Room room = (button.Tag as Room);
            int RoomID = room.Id;
            lsvBill.Tag = button.Tag;
            btnCheckOut.Enabled = room.Status;
            ShowBill(RoomID);
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            fCustomerInfomation open = new fCustomerInfomation();
            this.Hide();
            open.ShowDialog();
            this.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Room room = lsvBill.Tag as Room;
            if (room == null)
            {
                MessageBox.Show("Hãy chọn Phòng");
                return;
            }
            using var context = new HotelManagementContext();
            Bill bill = context.Bills.Where(b => b.RoomId == room.Id && !b.Status).FirstOrDefault();

            if (bill != null)
            {
                int servPrice = 0, roomPrice = 0, total = 0;
                roomPrice = context.RoomTypes.Find(room.IdType).Price;
                var dtReader = context.Services.ToList();
                foreach (var billServ in context.BillServices.Where(bs => bs.BillId == bill.Id))
                {
                    servPrice += billServ.Count * dtReader.FirstOrDefault(s => s.Id == billServ.ServiceId).Price;
                }
                total = roomPrice + servPrice;
                if (MessageBox.Show($"Bạn có chắc muốn thanh toán cho {room.Name} ?\n - Phòng: {roomPrice.ToString("c", culture)}\n - Dịch vụ: {servPrice.ToString("c", culture)}\n-------\n - Tổng: {total.ToString("c", culture)}",
                    "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    bill.Status = true;
                    bill.DateCheckOut = DateTime.Now;
                    context.SaveChanges();
                    ShowBill(room.Id);
                    LoadRoom();
                }
            }
        }

        private void btnadDV_Click(object sender, EventArgs e)
        {
            Room room = lsvBill.Tag as Room;
            if (room == null)
            {
                MessageBox.Show("Hãy chọn Phòng");
                return;
            }

            using var context = new HotelManagementContext();
            Bill bill = context.Bills.Where(b => b.RoomId == room.Id && !b.Status).FirstOrDefault();
            Service service = cbAddService.SelectedItem as Service;
            int intCount = (int)numericUpDownCount.Value;

            if (bill == null)
            {
                MessageBox.Show("Phòng này chưa có khách!");
                return;
            }
            if (service == null)
            {
                MessageBox.Show("Chưa có dịch vụ để thêm bill");
                return;
            }
            if (context.AddService2Bill(bill.Id, service.Id, intCount))
            {
                MessageBox.Show("Thêm dịch vụ vào thành công!");
                ShowBill(room.Id);
            }
            else
            {
                MessageBox.Show("Thêm dịch vụ thất bại!");
            }

        }
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            fDatPhong open = new fDatPhong(lsvBill.Tag as Room);
            this.Hide();
            open.ShowDialog();
            LoadList();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadRoom();
        }
    }
}
