using HotelManagement.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class fService : Form
    {
        BindingSource ServiceList = new BindingSource();
        public fService()
        {
            InitializeComponent();
            LoadList();
        }

        void LoadList()
        {
            LoadService();
            dgvService.DataSource = ServiceList;
   
            AddServiceBinding();
        }
        void LoadService()
        {
            using var context = new HotelManagementContext();
            ServiceList.DataSource = new BindingList<Service>(context.Services.ToList());
        }
        void AddServiceBinding()
        {
            txbIDService.DataBindings.Add(new Binding("Text", dgvService.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txbNameService.DataBindings.Add(new Binding("Text", dgvService.DataSource, "NameService", true, DataSourceUpdateMode.Never));
            txbPriceService.DataBindings.Add(new Binding("Text", dgvService.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            using var context = new HotelManagementContext();
            int priceService = (int)txbPriceService.Value;
            Service service = new Service()
            {
                NameService = txbNameService.Text,
                Price = priceService
            };
            context.Services.Add(service);
            try
            {
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Thêm dịch vụ thành công!!");
                    LoadService();
                    txbPriceService.Value = priceService;
                }
                else
                {
                    throw new Exception();
                }
            } catch
            {
                MessageBox.Show("Thêm không thành công! Có lỗi khi thêm dịch vụ");
            }
        }

        private void btnRepairService_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txbIDService.Text, out int id))
            {
                MessageBox.Show("ID Dịch vụ không hợp lệ");
                return;
            }
            if (txbNameService.Text.Length <= 0)
            {
                MessageBox.Show("Tên dịch vụ không được để trống");
                return;
            }
            using var context = new HotelManagementContext();
            Service service = context.Services.Find(id);
            service.NameService = txbNameService.Text;
            service.Price = (int)txbPriceService.Value;
            context.Services.Update(service);
            try
            {
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Edit dịch vụ thành công!!!");
                    LoadService();
                    txbPriceService.Value = service.Price;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Edit không thành công");
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txbIDService.Text, out int id))
            {
                MessageBox.Show("ID Dịch vụ không hợp lệ");
                return;
            }
            using var context = new HotelManagementContext();
            Service service = context.Services.Find(id);
            if (MessageBox.Show($"Bạn có chắc chắn muốn xoá dịch vụ: \"{service.NameService}\" ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.Services.Remove(service);
                try
                {
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Xoá dịch vụ thành công!!");
                        LoadService();
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    MessageBox.Show("Xoá không thành công");
                }
            }
        }
    }
}
