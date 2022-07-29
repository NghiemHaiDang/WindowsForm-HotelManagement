using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace HotelManagement.Models
{
    public partial class HotelManagementContext : DbContext
    {
        public HotelManagementContext()
        {
        }

        public HotelManagementContext(DbContextOptions<HotelManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillService> BillServices { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<RentRoomView> RentRoomView { get; set; }
        public virtual DbSet<CustomerView> CustomerView { get; set; }
        public virtual DbSet<RoomView> RoomView { get; set; }
        public virtual DbSet<RoomBillView> RoomBillView { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conf = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true)
                .Build();
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(conf.GetConnectionString("DbConnection"));
            }
        }

        public IEnumerable<RoomView> GetRoomList()
        {
            return RoomView.FromSqlRaw("EXEC [HotelManagement].[dbo].[USP_GetRoomList]").AsEnumerable();
        }
        public IEnumerable<CustomerView> GetCustomerView()
        {
            return CustomerView.FromSqlRaw("EXEC [HotelManagement].[dbo].[USP_LoadCustomer]").AsEnumerable();
        }
        public IEnumerable<RentRoomView> GetRentRoomView(bool onlyNoPaid)
        {
            return RentRoomView.FromSqlRaw("EXEC [HotelManagement].[dbo].[USP_LoadDatPhong] @onlyNoPaid",
                new SqlParameter { ParameterName = "onlyNoPaid", Value = onlyNoPaid }).AsEnumerable();
        }
        public IEnumerable<RoomBillView> GetRoomBill(int roomId)
        {
            return RoomBillView.FromSqlRaw("EXEC [HotelManagement].[dbo].[USP_GetBillRoom] @roomId",
                new SqlParameter { ParameterName = "roomId", Value = roomId }).AsEnumerable();
        }
        public Account Login(string username, string password)
        {
            return Accounts.FromSqlRaw("EXEC [HotelManagement].[dbo].[USP_Login] @userName, @passWord",
                new SqlParameter { ParameterName = "userName", Value = username },
                new SqlParameter { ParameterName = "passWord", Value = password }).AsEnumerable().FirstOrDefault();
        }
        public bool AddService2Bill(int billId, int servId, int count)
        {
            try
            {
                if (Database.ExecuteSqlRaw("EXEC [HotelManagement].[dbo].[USP_AddBillService] @billId, @serviceId, @count",
                    new SqlParameter { ParameterName = "billId", Value = billId },
                    new SqlParameter { ParameterName = "serviceId", Value = servId },
                    new SqlParameter { ParameterName = "count", Value = count }) > 0)
                {
                    return true;
                }
            } catch {}
            return false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("PK__Account__66DCF95DF0FB9C5C");

                entity.ToTable("Account");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .HasColumnName("userName")
                    .IsFixedLength(true);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("displayName")
                    .HasDefaultValueSql("(N'Account')");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("password")
                    .IsFixedLength(true);

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.ToTable("Bill");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.DateCheckIn)
                    .HasColumnType("date")
                    .HasColumnName("dateCheckIn")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateCheckOut)
                    .HasColumnType("date")
                    .HasColumnName("dateCheckOut");

                entity.Property(e => e.ExtraCharge).HasColumnName("extraCharge");

                entity.Property(e => e.RoomId).HasColumnName("roomId");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Bill__customerId__1CF15040");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK__Bill__roomId__1DE57479");
            });

            modelBuilder.Entity<BillService>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bill_Service");

                entity.Property(e => e.BillId).HasColumnName("billID");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.ServiceId).HasColumnName("serviceID");

                entity.HasOne(d => d.Bill)
                    .WithMany()
                    .HasForeignKey(d => d.BillId)
                    .HasConstraintName("FK__Bill_Serv__billI__21B6055D");

                entity.HasOne(d => d.Service)
                    .WithMany()
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK__Bill_Serv__servi__22AA2996");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("addDate");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .HasColumnName("address");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("gender");

                entity.Property(e => e.IdCardNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("idCardNumber")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .HasColumnName("phoneNumber")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("Room");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdType).HasColumnName("idType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.IdType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Room__idType__164452B1");
            });

            modelBuilder.Entity<RoomType>(entity =>
            {
                entity.ToTable("RoomType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NameType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nameType");

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("Service");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NameService)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nameService");

                entity.Property(e => e.Price).HasColumnName("price");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
    [Keyless]
    public partial class RentRoomView
    {
        [DisplayName("Phòng")]
        public string roomName { get; set; }
        [DisplayName("Khách hàng")]
        public string customerName { get; set; }
        [DisplayName("CMND")]
        public string idCard { get; set; }
        [DisplayName("Ngày đặt")]
        public DateTime checkInTime { get; set; }
        [DisplayName("Loại phòng")]
        public string roomType { get; set; }
        [DisplayName("Giá Phòng")]
        public int price { get; set; }
        [DisplayName("Trạng thái")]
        public string status { get; set; }
    }
    [Keyless]
    public partial class CustomerView
    {
        public int id { get; set; }
        [DisplayName("Tên KH")]
        public string name { get; set; }
        [DisplayName("Ngày Đăng ký")]
        public DateTime addDate { get; set; }
        [DisplayName("Giới tính")]
        public string gender { get; set; }
        [DisplayName("Địa chỉ")]
        public string address { get; set; }
        [DisplayName("Số CM")]
        public string idNumber { get; set; }
        [DisplayName("Điện thoại")]
        public string phoneNumber { get; set; }
    }
    [Keyless]
    public partial class RoomView
    {
        public int id { get; set; }
        [DisplayName("Tên Phòng")]
        public string name { get; set; }
        [DisplayName("Trạng Thái")]
        public string status { get; set; }
        [DisplayName("Loại Phòng")]
        public string nameType { get; set; }
    }
    [Keyless]
    public partial class RoomBillView
    {
        public string NameService { get; set; }
        public int Count { get; set; }
        public int TotalPrice { get; set; }
    }
}
