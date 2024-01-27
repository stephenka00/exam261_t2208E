﻿namespace Exam261.Migrations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using Microsoft.EntityFrameworkCore.Metadata;
    using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
    using Exam261.DbFirst;

#nullable disable

    namespace examAzure.Migrations
    {
        [DbContext(typeof(MyDbContext))]
        partial class MyDbContextModelSnapshot : ModelSnapshot
        {
            protected override void BuildModel(ModelBuilder modelBuilder)
            {
#pragma warning disable 612, 618
                modelBuilder
                    .HasAnnotation("ProductVersion", "8.0")
                    .HasAnnotation("Relational:MaxIdentifierLength", 128);

                SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

                modelBuilder.Entity("examAzure.Entities.OrderTbl", b =>
                {
                    b.Property<string>("itemCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemQty")
                        .HasColumnType("int");

                    b.Property<string>("OrderAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderDelivery")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("itemCode");

                    b.ToTable("OrderTbl");
                });
#pragma warning restore 612, 618
            }
        }
    }
}
    
