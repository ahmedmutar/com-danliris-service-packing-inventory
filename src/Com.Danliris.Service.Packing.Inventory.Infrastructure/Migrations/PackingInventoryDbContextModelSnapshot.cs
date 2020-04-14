﻿// <auto-generated />
using System;
using Com.Danliris.Service.Packing.Inventory.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Com.Danliris.Service.Packing.Inventory.Infrastructure.Migrations
{
    [DbContext(typeof(PackingInventoryDbContext))]
    partial class PackingInventoryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Com.Danliris.Service.Packing.Inventory.Data.Models.DyeingPrintingAreaMovementHistoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Area")
                        .HasMaxLength(64);

                    b.Property<string>("CreatedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<DateTimeOffset>("Date");

                    b.Property<string>("DeletedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<int>("DyeingPrintingAreaMovementId");

                    b.Property<int>("Index");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("Shift")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("DyeingPrintingAreaMovementId");

                    b.ToTable("DyeingPrintingAreaMovementHistories");
                });

            modelBuilder.Entity("Com.Danliris.Service.Packing.Inventory.Data.Models.DyeingPrintingAreaMovementModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Area")
                        .HasMaxLength(64);

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BonNo")
                        .HasMaxLength(64);

                    b.Property<string>("Buyer")
                        .HasMaxLength(4096);

                    b.Property<string>("CartNo")
                        .HasMaxLength(128);

                    b.Property<string>("Color")
                        .HasMaxLength(4096);

                    b.Property<string>("Construction")
                        .HasMaxLength(1024);

                    b.Property<string>("CreatedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<DateTimeOffset>("Date");

                    b.Property<string>("DeletedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("Grade")
                        .HasMaxLength(4096);

                    b.Property<bool>("IsChecked");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("MaterialCode")
                        .HasMaxLength(32);

                    b.Property<string>("MaterialConstructionCode")
                        .HasMaxLength(32);

                    b.Property<int>("MaterialConstructionId");

                    b.Property<string>("MaterialConstructionName")
                        .HasMaxLength(4096);

                    b.Property<int>("MaterialId");

                    b.Property<string>("MaterialName")
                        .HasMaxLength(4096);

                    b.Property<string>("MaterialWidth")
                        .HasMaxLength(1024);

                    b.Property<double>("MeterLength");

                    b.Property<string>("Motif")
                        .HasMaxLength(4096);

                    b.Property<string>("Mutation")
                        .HasMaxLength(64);

                    b.Property<string>("PackingInstruction")
                        .HasMaxLength(4096);

                    b.Property<string>("ProductionOrderCode")
                        .HasMaxLength(32);

                    b.Property<long>("ProductionOrderId");

                    b.Property<string>("ProductionOrderNo")
                        .HasMaxLength(128);

                    b.Property<double>("ProductionOrderQuantity");

                    b.Property<string>("ProductionOrderType")
                        .HasMaxLength(4096);

                    b.Property<double>("QtyKg");

                    b.Property<string>("Remark")
                        .HasMaxLength(1024);

                    b.Property<string>("Shift")
                        .HasMaxLength(64);

                    b.Property<string>("SourceArea")
                        .HasMaxLength(64);

                    b.Property<string>("Status")
                        .HasMaxLength(32);

                    b.Property<string>("UOMUnit")
                        .HasMaxLength(32);

                    b.Property<string>("UnitCode")
                        .HasMaxLength(1024);

                    b.Property<int>("UnitId");

                    b.Property<string>("UnitName")
                        .HasMaxLength(4096);

                    b.Property<double>("YardsLength");

                    b.HasKey("Id");

                    b.HasIndex("BonNo")
                        .IsUnique()
                        .HasFilter("[IsDeleted]=(0)");

                    b.ToTable("DyeingPrintingAreaMovements");
                });

            modelBuilder.Entity("Com.Danliris.Service.Packing.Inventory.Data.Models.FabricQualityControl.CriteriaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(32);

                    b.Property<int>("FabricGradeTestId");

                    b.Property<string>("Group")
                        .HasMaxLength(4096);

                    b.Property<int>("Index");

                    b.Property<string>("Name")
                        .HasMaxLength(4096);

                    b.Property<double>("ScoreA");

                    b.Property<double>("ScoreB");

                    b.Property<double>("ScoreC");

                    b.Property<double>("ScoreD");

                    b.HasKey("Id");

                    b.HasIndex("FabricGradeTestId");

                    b.ToTable("NewCriterias");
                });

            modelBuilder.Entity("Com.Danliris.Service.Packing.Inventory.Data.Models.FabricQualityControl.FabricGradeTestModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<double>("AvalLength");

                    b.Property<string>("CreatedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<double>("FabricGradeTest");

                    b.Property<int>("FabricQualityControlId");

                    b.Property<double>("FinalArea");

                    b.Property<double>("FinalGradeTest");

                    b.Property<double>("FinalLength");

                    b.Property<double>("FinalScore");

                    b.Property<string>("Grade")
                        .HasMaxLength(512);

                    b.Property<double>("InitLength");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("ItemIndex");

                    b.Property<string>("LastModifiedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("PcsNo")
                        .HasMaxLength(4096);

                    b.Property<double>("PointLimit");

                    b.Property<double>("PointSystem");

                    b.Property<double>("SampleLength");

                    b.Property<double>("Score");

                    b.Property<string>("Type")
                        .HasMaxLength(1024);

                    b.Property<double>("Width");

                    b.HasKey("Id");

                    b.HasIndex("FabricQualityControlId");

                    b.ToTable("NewFabricGradeTests");
                });

            modelBuilder.Entity("Com.Danliris.Service.Packing.Inventory.Data.Models.FabricQualityControl.FabricQualityControlModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(32);

                    b.Property<string>("CreatedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<DateTimeOffset>("DateIm");

                    b.Property<string>("DeletedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("DyeingPrintingAreaMovementBonNo")
                        .HasMaxLength(64);

                    b.Property<int>("DyeingPrintingAreaMovementId");

                    b.Property<string>("Group")
                        .HasMaxLength(4096);

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsUsed");

                    b.Property<string>("LastModifiedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("MachineNoIm")
                        .HasMaxLength(4096);

                    b.Property<string>("OperatorIm")
                        .HasMaxLength(4096);

                    b.Property<double>("PointLimit");

                    b.Property<double>("PointSystem");

                    b.Property<string>("ProductionOrderNo")
                        .HasMaxLength(128);

                    b.Property<string>("UId")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("NewFabricQualityControls");
                });

            modelBuilder.Entity("Com.Danliris.Service.Packing.Inventory.Data.Models.InventoryDocumentPackingItemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<int?>("InventoryDocumentPackingId");

                    b.Property<int>("InventoryDocumentSKUId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<int>("PackingId");

                    b.Property<decimal>("Quantity");

                    b.Property<int>("SKUId");

                    b.Property<string>("UOMUnit")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("InventoryDocumentPackingId");

                    b.ToTable("InventoryDocumentPackingItems");
                });

            modelBuilder.Entity("Com.Danliris.Service.Packing.Inventory.Data.Models.InventoryDocumentPackingModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(32);

                    b.Property<string>("CreatedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<DateTimeOffset>("Date");

                    b.Property<string>("DeletedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("ReferenceNo")
                        .HasMaxLength(256);

                    b.Property<string>("ReferenceType")
                        .HasMaxLength(256);

                    b.Property<string>("Remark")
                        .HasMaxLength(1024);

                    b.Property<string>("Storage");

                    b.Property<int>("StorageId");

                    b.Property<string>("Type")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("InventoryDocumentPackings");
                });

            modelBuilder.Entity("Com.Danliris.Service.Packing.Inventory.Data.Models.InventoryDocumentSKUItemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<decimal>("BeforeQuantity");

                    b.Property<string>("CreatedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<decimal>("CurrentQuantity");

                    b.Property<string>("DeletedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<int>("InventoryDocumentSKUId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<decimal>("Quantity");

                    b.Property<int>("SKUId");

                    b.Property<string>("UOMUnit")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("InventoryDocumentSKUId");

                    b.ToTable("InventoryDocumentSKUItems");
                });

            modelBuilder.Entity("Com.Danliris.Service.Packing.Inventory.Data.Models.InventoryDocumentSKUModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(32);

                    b.Property<string>("CreatedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<DateTimeOffset>("Date");

                    b.Property<string>("DeletedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("ReferenceNo")
                        .HasMaxLength(256);

                    b.Property<string>("ReferenceType")
                        .HasMaxLength(256);

                    b.Property<string>("Remark")
                        .HasMaxLength(1024);

                    b.Property<string>("Storage");

                    b.Property<int>("StorageId");

                    b.Property<string>("Type")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("InventoryDocumentSKUs");
                });

            modelBuilder.Entity("Com.Danliris.Service.Packing.Inventory.Data.Models.Product.CategoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(32);

                    b.Property<string>("CreatedAgent");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent");

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("IPCategories");
                });

            modelBuilder.Entity("Com.Danliris.Service.Packing.Inventory.Data.Models.Product.PackingModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedAgent");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent");

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<double>("Size");

                    b.HasKey("Id");

                    b.ToTable("IPPackings");
                });

            modelBuilder.Entity("Com.Danliris.Service.Packing.Inventory.Data.Models.Product.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Code")
                        .HasMaxLength(32);

                    b.Property<string>("CreatedAgent");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent");

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<int>("PackingId");

                    b.Property<int>("UOMId");

                    b.HasKey("Id");

                    b.ToTable("IPProducts");
                });

            modelBuilder.Entity("Com.Danliris.Service.Packing.Inventory.Data.Models.Product.UnitOfMeasurementModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedAgent");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent");

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("Unit")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("IPUnitOfMeasurements");
                });

            modelBuilder.Entity("Com.Danliris.Service.Packing.Inventory.Data.Models.ProductPackingModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(32);

                    b.Property<string>("CreatedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("PackingType")
                        .HasMaxLength(32);

                    b.Property<decimal>("Quantity");

                    b.Property<int>("SKUId");

                    b.HasKey("Id");

                    b.ToTable("ProductPackings");
                });

            modelBuilder.Entity("Com.Danliris.Service.Packing.Inventory.Data.Models.ProductSKUModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(32);

                    b.Property<string>("Composition")
                        .HasMaxLength(128);

                    b.Property<string>("Construction")
                        .HasMaxLength(128);

                    b.Property<string>("CreatedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("Design")
                        .HasMaxLength(128);

                    b.Property<string>("Grade")
                        .HasMaxLength(32);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .HasMaxLength(128);

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(128);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("LotNo")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("ProductType")
                        .HasMaxLength(32);

                    b.Property<string>("UOMUnit")
                        .HasMaxLength(64);

                    b.Property<string>("Width")
                        .HasMaxLength(128);

                    b.Property<string>("WovenType")
                        .HasMaxLength(128);

                    b.Property<string>("YarnType1")
                        .HasMaxLength(128);

                    b.Property<string>("YarnType2")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("ProductSKUs");
                });

            modelBuilder.Entity("Com.Danliris.Service.Packing.Inventory.Data.Models.DyeingPrintingAreaMovementHistoryModel", b =>
                {
                    b.HasOne("Com.Danliris.Service.Packing.Inventory.Data.Models.DyeingPrintingAreaMovementModel", "DyeingPrintingAreaMovement")
                        .WithMany("DyeingPrintingAreaMovementHistories")
                        .HasForeignKey("DyeingPrintingAreaMovementId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Com.Danliris.Service.Packing.Inventory.Data.Models.FabricQualityControl.CriteriaModel", b =>
                {
                    b.HasOne("Com.Danliris.Service.Packing.Inventory.Data.Models.FabricQualityControl.FabricGradeTestModel", "FabricGradeTest")
                        .WithMany("Criteria")
                        .HasForeignKey("FabricGradeTestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Com.Danliris.Service.Packing.Inventory.Data.Models.FabricQualityControl.FabricGradeTestModel", b =>
                {
                    b.HasOne("Com.Danliris.Service.Packing.Inventory.Data.Models.FabricQualityControl.FabricQualityControlModel", "FabricQualityControl")
                        .WithMany("FabricGradeTests")
                        .HasForeignKey("FabricQualityControlId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Com.Danliris.Service.Packing.Inventory.Data.Models.InventoryDocumentPackingItemModel", b =>
                {
                    b.HasOne("Com.Danliris.Service.Packing.Inventory.Data.Models.InventoryDocumentPackingModel")
                        .WithMany("Items")
                        .HasForeignKey("InventoryDocumentPackingId");
                });

            modelBuilder.Entity("Com.Danliris.Service.Packing.Inventory.Data.Models.InventoryDocumentSKUItemModel", b =>
                {
                    b.HasOne("Com.Danliris.Service.Packing.Inventory.Data.Models.InventoryDocumentSKUModel")
                        .WithMany("Items")
                        .HasForeignKey("InventoryDocumentSKUId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
