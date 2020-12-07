﻿// <auto-generated />
using System;
using Crud.App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Crud.App.Data.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20201207063004_itemGroupID")]
    partial class itemGroupID
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Crud.App.Domains.Adress", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Building")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Index")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Adress");
                });

            modelBuilder.Entity("Crud.App.Domains.Branch", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AdressID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BranchName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("ClientID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DeliveryAdressID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AdressID");

                    b.HasIndex("ClientID");

                    b.HasIndex("DeliveryAdressID");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Crud.App.Domains.Client", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AdressID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BussinessID")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("ClientsGroupID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("CreditLimit")
                        .HasColumnType("float");

                    b.Property<Guid>("DeliveryAdressID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PricelistCode")
                        .HasColumnType("int");

                    b.Property<string>("VAT_ID")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("AdressID");

                    b.HasIndex("ClientsGroupID");

                    b.HasIndex("DeliveryAdressID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Crud.App.Domains.ClientGroup", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ClientsGroups");
                });

            modelBuilder.Entity("Crud.App.Domains.Discount", b =>
                {
                    b.Property<Guid>("DiscountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientGroupID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("DiscountMultiplier")
                        .HasColumnType("float");

                    b.Property<Guid>("ItemGroupID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ItemID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PricelictCode")
                        .HasColumnType("int");

                    b.HasKey("DiscountID");

                    b.HasIndex("ClientGroupID");

                    b.HasIndex("ClientID");

                    b.HasIndex("ItemGroupID");

                    b.HasIndex("ItemID");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("Crud.App.Domains.Item", b =>
                {
                    b.Property<Guid>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ItemNameEN")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ItemNameRU")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ItemNomNr")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ItemQR")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("ItemsGroupID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Measure")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Package")
                        .HasColumnType("int");

                    b.Property<double>("Pricelist_A")
                        .HasColumnType("float");

                    b.Property<double>("Pricelist_B")
                        .HasColumnType("float");

                    b.Property<double>("Pricelist_C")
                        .HasColumnType("float");

                    b.Property<double>("Pricelist_D")
                        .HasColumnType("float");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<double>("WharehouseQNT")
                        .HasColumnType("float");

                    b.HasKey("ItemID");

                    b.HasIndex("ItemsGroupID");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Crud.App.Domains.ItemsGroup", b =>
                {
                    b.Property<Guid>("ItemsGroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ItemsGroupCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ItemsGroupName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ItemsGroupNameEN")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ItemsGroupNameRU")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("ParentItemsGroupID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ItemsGroupID");

                    b.HasIndex("ParentItemsGroupID");

                    b.ToTable("ItemsGroups");
                });

            modelBuilder.Entity("Crud.App.Domains.Order", b =>
                {
                    b.Property<Guid>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BranchID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DeliveryAdressID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("OrderData")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.HasKey("OrderID");

                    b.HasIndex("BranchID");

                    b.HasIndex("ClientID");

                    b.HasIndex("DeliveryAdressID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Crud.App.Domains.OrderedItem", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DiscountID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ItemID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Ordered_QNT")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("ItemID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderedItems");
                });

            modelBuilder.Entity("Crud.App.Domains.Branch", b =>
                {
                    b.HasOne("Crud.App.Domains.Adress", "Adress")
                        .WithMany()
                        .HasForeignKey("AdressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Crud.App.Domains.Client", "Client")
                        .WithMany("Branches")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Crud.App.Domains.Adress", "DeliveryAdress")
                        .WithMany()
                        .HasForeignKey("DeliveryAdressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adress");

                    b.Navigation("Client");

                    b.Navigation("DeliveryAdress");
                });

            modelBuilder.Entity("Crud.App.Domains.Client", b =>
                {
                    b.HasOne("Crud.App.Domains.Adress", "Adress")
                        .WithMany()
                        .HasForeignKey("AdressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Crud.App.Domains.ClientGroup", "Group")
                        .WithMany("Clients")
                        .HasForeignKey("ClientsGroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Crud.App.Domains.Adress", "DeliveryAdress")
                        .WithMany()
                        .HasForeignKey("DeliveryAdressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adress");

                    b.Navigation("DeliveryAdress");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("Crud.App.Domains.Discount", b =>
                {
                    b.HasOne("Crud.App.Domains.ClientGroup", "ClientGroup")
                        .WithMany()
                        .HasForeignKey("ClientGroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Crud.App.Domains.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Crud.App.Domains.ItemsGroup", "ItemGroup")
                        .WithMany()
                        .HasForeignKey("ItemGroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Crud.App.Domains.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("ClientGroup");

                    b.Navigation("Item");

                    b.Navigation("ItemGroup");
                });

            modelBuilder.Entity("Crud.App.Domains.Item", b =>
                {
                    b.HasOne("Crud.App.Domains.ItemsGroup", "ItemsGroup")
                        .WithMany("Items")
                        .HasForeignKey("ItemsGroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ItemsGroup");
                });

            modelBuilder.Entity("Crud.App.Domains.ItemsGroup", b =>
                {
                    b.HasOne("Crud.App.Domains.ItemsGroup", "ParentItemsGroup")
                        .WithMany("ChildItemsGroups")
                        .HasForeignKey("ParentItemsGroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParentItemsGroup");
                });

            modelBuilder.Entity("Crud.App.Domains.Order", b =>
                {
                    b.HasOne("Crud.App.Domains.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchID");

                    b.HasOne("Crud.App.Domains.Client", "Client")
                        .WithMany("ClientsOrders")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Crud.App.Domains.Adress", "DeliveryAdress")
                        .WithMany()
                        .HasForeignKey("DeliveryAdressID");

                    b.Navigation("Branch");

                    b.Navigation("Client");

                    b.Navigation("DeliveryAdress");
                });

            modelBuilder.Entity("Crud.App.Domains.OrderedItem", b =>
                {
                    b.HasOne("Crud.App.Domains.Item", "Item")
                        .WithMany("OrderedItems")
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Crud.App.Domains.Order", "Order")
                        .WithMany("OrderedItems")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Crud.App.Domains.Client", b =>
                {
                    b.Navigation("Branches");

                    b.Navigation("ClientsOrders");
                });

            modelBuilder.Entity("Crud.App.Domains.ClientGroup", b =>
                {
                    b.Navigation("Clients");
                });

            modelBuilder.Entity("Crud.App.Domains.Item", b =>
                {
                    b.Navigation("OrderedItems");
                });

            modelBuilder.Entity("Crud.App.Domains.ItemsGroup", b =>
                {
                    b.Navigation("ChildItemsGroups");

                    b.Navigation("Items");
                });

            modelBuilder.Entity("Crud.App.Domains.Order", b =>
                {
                    b.Navigation("OrderedItems");
                });
#pragma warning restore 612, 618
        }
    }
}
