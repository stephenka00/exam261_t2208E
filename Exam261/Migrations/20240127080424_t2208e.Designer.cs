using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Exam261.DbFirst;
namespace Exam261.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240127080424_t2208e")]
    partial class t2207a
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
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
