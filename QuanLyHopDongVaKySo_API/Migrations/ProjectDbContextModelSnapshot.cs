﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyHopDongVaKySo_API.Database;

#nullable disable

namespace QuanLyHopDongVaKySo_API.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    partial class ProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.ContractCoordinate", b =>
                {
                    b.Property<int>("ContractCoorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContractCoorID"));

                    b.Property<string>("FieldName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SignaturePage")
                        .HasColumnType("int");

                    b.Property<int>("TContractID")
                        .HasColumnType("int");

                    b.Property<float>("X")
                        .HasColumnType("real");

                    b.Property<float>("Y")
                        .HasColumnType("real");

                    b.HasKey("ContractCoorID");

                    b.HasIndex("TContractID");

                    b.ToTable("ContractCoordinate", (string)null);
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.Customer", b =>
                {
                    b.Property<Guid?>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("BNDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BNPlace")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("BankAccount")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("BankName")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("BillingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("BuisinessName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("BuisinessNumber")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ChargeNoticeAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatePOA")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FAX")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IssuedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IssuedPlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PowerOfAttorneyNum")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("SerialPFX")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TaxIDNumber")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("WhoPOA")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("typeofCustomer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.HasIndex("SerialPFX");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.DoneContract", b =>
                {
                    b.Property<int>("DContractID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DContractID"));

                    b.Property<string>("Base64File")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DConTractName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DContractFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateDone")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUnEffect")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DirectorSignedId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("DoneMinuteId")
                        .HasColumnType("int");

                    b.Property<Guid?>("EmployeeCreatedId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("InstallationAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInEffect")
                        .HasColumnType("bit");

                    b.Property<int>("TOS_ID")
                        .HasColumnType("int");

                    b.HasKey("DContractID");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DoneMinuteId");

                    b.HasIndex("EmployeeCreatedId");

                    b.HasIndex("TOS_ID");

                    b.ToTable("DoneContract", (string)null);
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.DoneMinute", b =>
                {
                    b.Property<int>("DoneMinuteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoneMinuteID"));

                    b.Property<string>("Base64File")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateDone")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MinuteFile")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("MinuteName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DoneMinuteID");

                    b.HasIndex("EmployeeId");

                    b.ToTable("DoneMinute", (string)null);
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.Employee", b =>
                {
                    b.Property<Guid?>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Image")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsFirstLogin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PositionID")
                        .HasColumnType("int");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("SerialPFX")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("PositionID");

                    b.HasIndex("RoleID");

                    b.HasIndex("SerialPFX");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.InstallationDevice", b =>
                {
                    b.Property<int>("Device_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Device_ID"));

                    b.Property<string>("DeviceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DeviceQuantity")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DeviceStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TOS_ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Device_ID");

                    b.HasIndex("TOS_ID");

                    b.ToTable("InstallationDevice", (string)null);
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.InstallationRequirement", b =>
                {
                    b.Property<int>("InstallRequireID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InstallRequireID"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoneContractId")
                        .HasColumnType("int");

                    b.Property<string>("InstallationAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MinuteName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("InstallRequireID");

                    b.HasIndex("DoneContractId");

                    b.ToTable("InstallationRequirement", (string)null);
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.MinuteCoordinate", b =>
                {
                    b.Property<int>("MinuteCoorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MinuteCoorID"));

                    b.Property<string>("FieldName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SignaturePage")
                        .HasColumnType("int");

                    b.Property<int>("TMinuteID")
                        .HasColumnType("int");

                    b.Property<float>("X")
                        .HasColumnType("real");

                    b.Property<float>("Y")
                        .HasColumnType("real");

                    b.HasKey("MinuteCoorID");

                    b.HasIndex("TMinuteID");

                    b.ToTable("MinuteCoordinate", (string)null);
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.OperationHistoryCus", b =>
                {
                    b.Property<int>("HistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HistoryID"));

                    b.Property<Guid?>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("OperationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("HistoryID");

                    b.HasIndex("CustomerID");

                    b.ToTable("OperationHistoryCus", t =>
                        {
                            t.HasTrigger("tr_DeleteOldCusHistoryRecords");
                        });
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.OperationHistoryEmp", b =>
                {
                    b.Property<int>("HistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HistoryID"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EmployeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OperationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("HistoryID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("OperationHistoryEmp", t =>
                        {
                            t.HasTrigger("tr_DeleteOldEmpHistoryRecords");
                        });
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.PFXCertificate", b =>
                {
                    b.Property<string>("Serial")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Id");

                    b.Property<string>("DefaultImageSignature")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageSignature1")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageSignature2")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageSignature3")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageSignature4")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageSignature5")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsEmployee")
                        .HasColumnType("bit");

                    b.Property<string>("Issuer")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Issuer");

                    b.Property<string>("PfxFileName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<string>("PfxFilePath")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FilePath");

                    b.Property<string>("PfxPassword")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Password");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Subject");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime2")
                        .HasColumnName("ValidFrom");

                    b.Property<DateTime>("ValidUntil")
                        .HasColumnType("datetime2")
                        .HasColumnName("ValidUntil");

                    b.HasKey("Serial");

                    b.ToTable("PFXCertificate", (string)null);
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.PendingContract", b =>
                {
                    b.Property<int>("PContractID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PContractID"));

                    b.Property<string>("Base64File")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DirectorSignedId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeeCreatedId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("InstallationAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCustomer")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDirector")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRefuse")
                        .HasColumnType("bit");

                    b.Property<string>("PContractFile")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("PContractName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TOS_ID")
                        .HasColumnType("int");

                    b.HasKey("PContractID");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeCreatedId");

                    b.HasIndex("TOS_ID");

                    b.ToTable("PendingContract", (string)null);
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.PendingMinute", b =>
                {
                    b.Property<int>("PendingMinuteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PendingMinuteId"));

                    b.Property<string>("Base64File")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoneContractId")
                        .HasColumnType("int");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("InstallationAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsCustomer")
                        .HasColumnType("bit");

                    b.Property<bool>("IsIntallation")
                        .HasColumnType("bit");

                    b.Property<string>("MinuteFile")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("MinuteName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PendingMinuteId");

                    b.HasIndex("DoneContractId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("PendingMinute", (string)null);
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.Position", b =>
                {
                    b.Property<int>("PositionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PositionID"));

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("isHidden")
                        .HasColumnType("bit");

                    b.HasKey("PositionID");

                    b.ToTable("Position", (string)null);
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("isHidden")
                        .HasColumnType("bit");

                    b.HasKey("RoleID");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.Stamp", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("StampPath")
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ID");

                    b.ToTable("Stamp", (string)null);
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.TemplateContract", b =>
                {
                    b.Property<int>("TContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TContactID"));

                    b.Property<string>("Base64File")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("TContractFile")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("TContractName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("jsonCustomerZone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("jsonDirectorZone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TContactID");

                    b.ToTable("TemplateContract", (string)null);
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.TemplateMinute", b =>
                {
                    b.Property<int>("TMinuteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TMinuteID"));

                    b.Property<string>("Base64File")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("TMinuteFile")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("TMinuteName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("jsonCustomerZone")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("jsonIntallationZone")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TMinuteID");

                    b.ToTable("TemplateMinute", (string)null);
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.TypeOfService", b =>
                {
                    b.Property<int>("TOS_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TOS_ID"));

                    b.Property<DateTime?>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("PerTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("isHidden")
                        .HasColumnType("bit");

                    b.Property<int>("templateContractID")
                        .HasColumnType("int");

                    b.Property<int>("templateMinuteID")
                        .HasColumnType("int");

                    b.HasKey("TOS_ID");

                    b.HasIndex("templateContractID");

                    b.HasIndex("templateMinuteID");

                    b.ToTable("TypeOfService", (string)null);
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.ContractCoordinate", b =>
                {
                    b.HasOne("QuanLyHopDongVaKySo_API.Models.TemplateContract", "TemplateContract")
                        .WithMany("ContractCoordinates")
                        .HasForeignKey("TContractID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TemplateContract");
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.Customer", b =>
                {
                    b.HasOne("QuanLyHopDongVaKySo_API.Models.PFXCertificate", "PFXCertificate")
                        .WithMany()
                        .HasForeignKey("SerialPFX");

                    b.Navigation("PFXCertificate");
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.DoneContract", b =>
                {
                    b.HasOne("QuanLyHopDongVaKySo_API.Models.Customer", "Customer")
                        .WithMany("DoneContract")
                        .HasForeignKey("CustomerId");

                    b.HasOne("QuanLyHopDongVaKySo_API.Models.DoneMinute", "DoneMinute")
                        .WithMany()
                        .HasForeignKey("DoneMinuteId");

                    b.HasOne("QuanLyHopDongVaKySo_API.Models.Employee", "Employee")
                        .WithMany("DoneContract")
                        .HasForeignKey("EmployeeCreatedId");

                    b.HasOne("QuanLyHopDongVaKySo_API.Models.TypeOfService", "TypeOfService")
                        .WithMany()
                        .HasForeignKey("TOS_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("DoneMinute");

                    b.Navigation("Employee");

                    b.Navigation("TypeOfService");
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.DoneMinute", b =>
                {
                    b.HasOne("QuanLyHopDongVaKySo_API.Models.Employee", "Employee")
                        .WithMany("DoneMinute")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.Employee", b =>
                {
                    b.HasOne("QuanLyHopDongVaKySo_API.Models.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyHopDongVaKySo_API.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyHopDongVaKySo_API.Models.PFXCertificate", "PFXCertificate")
                        .WithMany()
                        .HasForeignKey("SerialPFX");

                    b.Navigation("PFXCertificate");

                    b.Navigation("Position");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.InstallationDevice", b =>
                {
                    b.HasOne("QuanLyHopDongVaKySo_API.Models.TypeOfService", "TypeOfService")
                        .WithMany("InstallationDevice")
                        .HasForeignKey("TOS_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeOfService");
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.InstallationRequirement", b =>
                {
                    b.HasOne("QuanLyHopDongVaKySo_API.Models.DoneContract", "DoneContract")
                        .WithMany()
                        .HasForeignKey("DoneContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DoneContract");
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.MinuteCoordinate", b =>
                {
                    b.HasOne("QuanLyHopDongVaKySo_API.Models.TemplateMinute", "TemplateMinute")
                        .WithMany("MinuteCoordinates")
                        .HasForeignKey("TMinuteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TemplateMinute");
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.OperationHistoryCus", b =>
                {
                    b.HasOne("QuanLyHopDongVaKySo_API.Models.Customer", "Customer")
                        .WithMany("OperationHistoryCus")
                        .HasForeignKey("CustomerID");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.OperationHistoryEmp", b =>
                {
                    b.HasOne("QuanLyHopDongVaKySo_API.Models.Employee", "Employee")
                        .WithMany("OperationHistoryEmp")
                        .HasForeignKey("EmployeeID");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.PendingContract", b =>
                {
                    b.HasOne("QuanLyHopDongVaKySo_API.Models.Customer", "Customer")
                        .WithMany("PendingContract")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyHopDongVaKySo_API.Models.Employee", "Employee")
                        .WithMany("PendingContract")
                        .HasForeignKey("EmployeeCreatedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyHopDongVaKySo_API.Models.TypeOfService", "TypeOfService")
                        .WithMany()
                        .HasForeignKey("TOS_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");

                    b.Navigation("TypeOfService");
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.PendingMinute", b =>
                {
                    b.HasOne("QuanLyHopDongVaKySo_API.Models.DoneContract", "DoneContract")
                        .WithMany()
                        .HasForeignKey("DoneContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyHopDongVaKySo_API.Models.Employee", "Employee")
                        .WithMany("PendingMinute")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DoneContract");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.TypeOfService", b =>
                {
                    b.HasOne("QuanLyHopDongVaKySo_API.Models.TemplateContract", "TemplateContact")
                        .WithMany()
                        .HasForeignKey("templateContractID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyHopDongVaKySo_API.Models.TemplateMinute", "TemplateMinute")
                        .WithMany()
                        .HasForeignKey("templateMinuteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TemplateContact");

                    b.Navigation("TemplateMinute");
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.Customer", b =>
                {
                    b.Navigation("DoneContract");

                    b.Navigation("OperationHistoryCus");

                    b.Navigation("PendingContract");
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.Employee", b =>
                {
                    b.Navigation("DoneContract");

                    b.Navigation("DoneMinute");

                    b.Navigation("OperationHistoryEmp");

                    b.Navigation("PendingContract");

                    b.Navigation("PendingMinute");
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.TemplateContract", b =>
                {
                    b.Navigation("ContractCoordinates");
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.TemplateMinute", b =>
                {
                    b.Navigation("MinuteCoordinates");
                });

            modelBuilder.Entity("QuanLyHopDongVaKySo_API.Models.TypeOfService", b =>
                {
                    b.Navigation("InstallationDevice");
                });
#pragma warning restore 612, 618
        }
    }
}
