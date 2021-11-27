﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211121165046_seeddata4")]
    partial class seeddata4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cateogries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Du lịch biển"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Du lịch quê"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Du lịch dã ngoại"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Du lịch ẩm thực"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Cost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CostCategoryId")
                        .HasColumnType("int");

                    b.Property<float>("Money")
                        .HasColumnType("real");

                    b.Property<int>("TouristGroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CostCategoryId");

                    b.HasIndex("TouristGroupId");

                    b.ToTable("Costs");
                });

            modelBuilder.Entity("DAL.Entities.CostCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CostCategories");
                });

            modelBuilder.Entity("DAL.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("IdentityNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "HCM",
                            FullName = "Trần Thanh Tùng",
                            Gender = 1,
                            IdentityNumber = "0123456789",
                            Nation = "Việt Nam",
                            PhoneNumber = "0123456789"
                        },
                        new
                        {
                            Id = 2,
                            Address = "HCM",
                            FullName = "Lê Hải Đăng",
                            Gender = 1,
                            IdentityNumber = "0123456789",
                            Nation = "Việt Nam",
                            PhoneNumber = "0123456789"
                        },
                        new
                        {
                            Id = 3,
                            Address = "HCM",
                            FullName = "Tô Trần Khánh Hoà",
                            Gender = 0,
                            IdentityNumber = "0123456789",
                            Nation = "Việt Nam",
                            PhoneNumber = "0123456789"
                        },
                        new
                        {
                            Id = 4,
                            Address = "HCM",
                            FullName = "Âu Đình Uy",
                            Gender = 1,
                            IdentityNumber = "0123456789",
                            Nation = "Việt Nam",
                            PhoneNumber = "0123456789"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LocationName = "Đà Lạt"
                        },
                        new
                        {
                            Id = 2,
                            LocationName = "Hà Nội"
                        },
                        new
                        {
                            Id = 3,
                            LocationName = "Hồ Chí Minh"
                        },
                        new
                        {
                            Id = 4,
                            LocationName = "Phú Quốc"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("Money")
                        .HasColumnType("real");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TourId");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("DAL.Entities.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Staffs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Nguyễn Văn A"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Nguyễn Văn B"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Nguyễn Văn C"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Nguyễn Thị D"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Tour", b =>
                {
                    b.Property<int>("TourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenGoi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TourId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Tours");

                    b.HasData(
                        new
                        {
                            TourId = 1,
                            CategoryId = 1,
                            MoTa = "Du lịch Đà Lạt- Thiền Viện Trúc Lâm Quê Garden - Kim Ngân Hills Resort từ Sài Gòn 2021. Khi tham gia tour cùng Du Lịch Việtngoài việc thưởng lãm vẻ đẹp đặc sắc của các loài hoa, khung cảnh thơ mộng với khí trời se lạnh của vùng đất phố núi, Quý khách sẽ được cảm nhận Đà Lạt chính là địa điểm du lịch đi hoài không chán bởi những “tọa độ sống ảo đẹp không góc chết” mang những phong cách hoàn toàn riêng biệt. Nếu như Đà Lạt View Coffee nổi danh với hình ảnh “Cổng trời thứ 2” phá cách và độc đáo, thì Quê Garden cũng đang làm mưa làm gió trên các trang mạng xã hội, là một khu vườn với lối kiến trúc Nhật Bản nằm giữa cao nguyên Lâm Viên. Cuối cùng là ngôi làng cổ kính Châu Âu - Kim Ngân Hills với cả bầu trời thú cưng hiền lành cùng khu ẩm thực đặc biệt mang dấu.",
                            TenGoi = "Du lịch Đà Lạt - QUÊ Garden - Đà Lạt View Coffee - Kim Ngân Hills Resort từ Sài Gòn 2021"
                        });
                });

            modelBuilder.Entity("DAL.Entities.TourDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("Serial")
                        .HasColumnType("int");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("TourId");

                    b.ToTable("TourDetails");
                });

            modelBuilder.Entity("DAL.Entities.TouristGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hotel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Revenue")
                        .HasColumnType("real");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TourId");

                    b.ToTable("TouristGroups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description",
                            EndDate = new DateTime(2021, 11, 21, 23, 50, 45, 928, DateTimeKind.Local).AddTicks(1883),
                            Hotel = "Khách sạn",
                            Revenue = 10000000f,
                            StartDate = new DateTime(2021, 11, 21, 23, 50, 45, 926, DateTimeKind.Local).AddTicks(9683),
                            TourId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description",
                            EndDate = new DateTime(2021, 11, 21, 23, 50, 45, 928, DateTimeKind.Local).AddTicks(3531),
                            Hotel = "Khách sạn",
                            Revenue = 10000000f,
                            StartDate = new DateTime(2021, 11, 21, 23, 50, 45, 928, DateTimeKind.Local).AddTicks(3522),
                            TourId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "Description",
                            EndDate = new DateTime(2021, 11, 21, 23, 50, 45, 928, DateTimeKind.Local).AddTicks(3536),
                            Hotel = "Khách sạn",
                            Revenue = 10000000f,
                            StartDate = new DateTime(2021, 11, 21, 23, 50, 45, 928, DateTimeKind.Local).AddTicks(3534),
                            TourId = 1
                        },
                        new
                        {
                            Id = 4,
                            Description = "Description",
                            EndDate = new DateTime(2021, 11, 21, 23, 50, 45, 928, DateTimeKind.Local).AddTicks(3540),
                            Hotel = "Khách sạn",
                            Revenue = 10000000f,
                            StartDate = new DateTime(2021, 11, 21, 23, 50, 45, 928, DateTimeKind.Local).AddTicks(3539),
                            TourId = 1
                        });
                });

            modelBuilder.Entity("DAL.Entities.TouristGroup_Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("TouristGroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TouristGroupId");

                    b.ToTable("TouristGroup_Customers");
                });

            modelBuilder.Entity("DAL.Entities.TouristGroup_Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Duty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.Property<int>("TouristGroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.HasIndex("TouristGroupId");

                    b.ToTable("TouristGroup_Staffs");
                });

            modelBuilder.Entity("DAL.Entities.Cost", b =>
                {
                    b.HasOne("DAL.Entities.CostCategory", "CostCategory")
                        .WithMany("Costs")
                        .HasForeignKey("CostCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.TouristGroup", "TouristGroup")
                        .WithMany("Costs")
                        .HasForeignKey("TouristGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CostCategory");

                    b.Navigation("TouristGroup");
                });

            modelBuilder.Entity("DAL.Entities.Price", b =>
                {
                    b.HasOne("DAL.Entities.Tour", "Tour")
                        .WithMany("Prices")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("DAL.Entities.Tour", b =>
                {
                    b.HasOne("DAL.Entities.Category", "Category")
                        .WithMany("Tours")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DAL.Entities.TourDetail", b =>
                {
                    b.HasOne("DAL.Entities.Location", "Location")
                        .WithMany("TourDetails")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Tour", "Tour")
                        .WithMany("TourDetails")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("DAL.Entities.TouristGroup", b =>
                {
                    b.HasOne("DAL.Entities.Tour", "Tour")
                        .WithMany("DSDoanDulich")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("DAL.Entities.TouristGroup_Customer", b =>
                {
                    b.HasOne("DAL.Entities.Customer", "Customer")
                        .WithMany("TouristGroup_Customers")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.TouristGroup", "TouristGroup")
                        .WithMany("TouristGroup_Customers")
                        .HasForeignKey("TouristGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("TouristGroup");
                });

            modelBuilder.Entity("DAL.Entities.TouristGroup_Staff", b =>
                {
                    b.HasOne("DAL.Entities.Staff", "Staff")
                        .WithMany("TouristGroup_Staffs")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.TouristGroup", "TouristGroup")
                        .WithMany("TouristGroup_Staffs")
                        .HasForeignKey("TouristGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Staff");

                    b.Navigation("TouristGroup");
                });

            modelBuilder.Entity("DAL.Entities.Category", b =>
                {
                    b.Navigation("Tours");
                });

            modelBuilder.Entity("DAL.Entities.CostCategory", b =>
                {
                    b.Navigation("Costs");
                });

            modelBuilder.Entity("DAL.Entities.Customer", b =>
                {
                    b.Navigation("TouristGroup_Customers");
                });

            modelBuilder.Entity("DAL.Entities.Location", b =>
                {
                    b.Navigation("TourDetails");
                });

            modelBuilder.Entity("DAL.Entities.Staff", b =>
                {
                    b.Navigation("TouristGroup_Staffs");
                });

            modelBuilder.Entity("DAL.Entities.Tour", b =>
                {
                    b.Navigation("DSDoanDulich");

                    b.Navigation("Prices");

                    b.Navigation("TourDetails");
                });

            modelBuilder.Entity("DAL.Entities.TouristGroup", b =>
                {
                    b.Navigation("Costs");

                    b.Navigation("TouristGroup_Customers");

                    b.Navigation("TouristGroup_Staffs");
                });
#pragma warning restore 612, 618
        }
    }
}
