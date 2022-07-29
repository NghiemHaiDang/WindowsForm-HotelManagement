using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class fDatPhong : Form
    {
        private Room preChoose = null;
        public fDatPhong(Room r)
        {
            InitializeComponent();
            preChoose = r;
            LoadList();
        }
        public fDatPhong() : this(null) { }
        void LoadList()
        {
            LoadRoomType();
            LoadDgvDatPhong();
            LoadCustomer();
            AddDatPhongBinding();
        }
        void LoadDgvDatPhong()
        {
            using var context = new HotelManagementContext();
            dgvDatPhong.DataSource = new BindingList<RentRoomView>(context.GetRentRoomView(checkBox1.Checked).ToList());
        }
        void AddDatPhongBinding()
        {
            cbCustomer.DataBindings.Add(new Binding("Text", dgvDatPhong.DataSource, "customerName", true, DataSourceUpdateMode.Never));
            cbRoomtype.DataBindings.Add(new Binding("Text", dgvDatPhong.DataSource, "roomType", true, DataSourceUpdateMode.Never));
            cbRoom.DataBindings.Add(new Binding("Text", dgvDatPhong.DataSource, "roomName", true, DataSourceUpdateMode.Never));
        }
        void LoadRoomType()
        {
            using var context = new HotelManagementContext();
            RoomType[] listRoomType = context.RoomTypes.ToArray();
            cbRoomtype.DataSource = listRoomType;
            cbRoomtype.DisplayMember = "NameType";
            cbRoomtype.SelectedIndex = 0;
            if (preChoose != null)
            {
                for (int i = 0; i < listRoomType.Length; i++)
                {
                    if (listRoomType[i].Id == preChoose.IdType)
                    {
                        MessageBox.Show(preChoose.IdType.ToString());
                        cbRoomtype.SelectedItem = listRoomType[i];
                        break;
                    }
                }
            }
        }
        void LoadCustomer()
        {
            using var context = new HotelManagementContext();
            Customer[] CustomerList = context.Customers.ToArray();
            cbCustomer.DataSource = CustomerList;
            cbCustomer.DisplayMember = "UniqueName";
        }
        void LoadRoomListByRoomTypeID(int id)
        {
            using var context = new HotelManagementContext();
            Room[] listRoom = context.Rooms.Where(r => r.IdType == id && !r.Status).ToArray();
            cbRoom.DataSource = listRoom;
            cbRoom.DisplayMember = "Name";
            if (preChoose != null)
            {
                for (int i = 0; i < listRoom.Length; i++)
                {
                    if (listRoom[i].Id == preChoose.Id)
                    {
                        cbRoom.SelectedItem = listRoom[i];
                        break;
                    }
                }
            }
        }

        private void cbRoomtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            RoomType selected = cb.SelectedItem as RoomType;
            id = selected.Id;

            LoadRoomListByRoomTypeID(id);
        }

        private void btnAddCustomerByRoom_Click(object sender, EventArgs e)
        {
            if (cbCustomer.SelectedItem == null || cbRoom.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin trước khi thêm!!");
                return;
            }
            using var context = new HotelManagementContext();
            int idCustomer = (cbCustomer.SelectedItem as Customer).Id;
            int idRoom = (cbRoom.SelectedItem as Room).Id;

            if (context.Rooms.Where(r => r.Id == idRoom && !r.Status).Count() <= 0)
            {
                MessageBox.Show("Phòng không tồn tại hoặc đã được đặt, vui lòng thử lại!");
                return;
            }
            Bill bill = new Bill()
            {
                CustomerId = idCustomer,
                RoomId = idRoom,
                DateCheckIn = checkInDateInput.Value,
                DateCheckOut = null,
                Status = false
            };
            context.Bills.Add(bill);

            try
            {
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Đặt phòng thành công!");
                    LoadDgvDatPhong();
                }
                else
                {
                    throw new Exception();
                }
            } catch
            {
                MessageBox.Show("Đặt phòng thất bại!!!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            LoadDgvDatPhong();
        }
    }
}
