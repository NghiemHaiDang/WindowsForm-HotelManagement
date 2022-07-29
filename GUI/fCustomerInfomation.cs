using HotelManagement.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class fCustomerInfomation : Form
    {
        BindingSource CustomerList = new BindingSource();
        public fCustomerInfomation()
        {
            InitializeComponent();
            LoadList();
        }

        void LoadList()
        {
            dgvCustomer.DataSource = CustomerList;

            LoadTableCustomer();
            AddCustomerBinding();
        }

        void AddCustomerBinding()
        {
            txbNameCustomer.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "name", true, DataSourceUpdateMode.Never));
            cbGenderCustomer.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "gender", true, DataSourceUpdateMode.Never));
            txbAddressCustomer.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "address", true, DataSourceUpdateMode.Never));
            txbCMND.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "idNumber", true, DataSourceUpdateMode.Never));
            txbPhoneNumber.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "phoneNumber", true, DataSourceUpdateMode.Never));
            txbidCustomer.DataBindings.Add(new Binding("Text", dgvCustomer.DataSource, "id", true, DataSourceUpdateMode.Never));
        }
        void LoadTableCustomer()
        {
            using var context = new HotelManagementContext();
            CustomerList.DataSource = new BindingList<CustomerView>(context.GetCustomerView().ToList());
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                Name = txbNameCustomer.Text,
                AddDate = DateTime.Now,
                Gender = cbGenderCustomer.Text,
                Address = txbAddressCustomer.Text,
                IdCardNumber = txbCMND.Text,
                PhoneNumber = txbPhoneNumber.Text
            };
            using var context = new HotelManagementContext();
            context.Customers.Add(customer);
            try
            {
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Thêm Khách hàng thành công!");
                    LoadTableCustomer();
                }
                else
                {
                    throw new Exception();
                }
            } catch
            {
                MessageBox.Show("Thêm khách hàng thất bại!!!");
            }
        }

        private void btnRepairCustomer_Click(object sender, EventArgs e)
        {
            using var context = new HotelManagementContext();
            Customer customer = context.Customers.Find(int.Parse(txbidCustomer.Text));
            if (customer == null)
            {
                MessageBox.Show("Không thể Edit thông tin không tồn tại");
                return;
            }
            customer.Name = txbNameCustomer.Text;
            customer.AddDate = DateTime.Now;
            customer.Gender = cbGenderCustomer.Text;
            customer.Address = txbAddressCustomer.Text;
            customer.IdCardNumber = txbCMND.Text;
            customer.PhoneNumber = txbPhoneNumber.Text;
            context.Customers.Update(customer);
            try
            {
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Edit Khách hàng thành công!");
                    LoadTableCustomer();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Edit khách hàng thất bại!!!");
            }
        }
    }
}
