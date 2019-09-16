﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TitheEnvelope.Models;

namespace TitheEnvelopeApi.Migrations
{
    [DbContext(typeof(TitheContext))]
    [Migration("20190831153454_TitheEnvelope.Models.TitheContext")]
    partial class TitheEnvelopeModelsTitheContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TitheEnvelopeApi.Models.TithePaymentDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<DateTime>("DateOfPayment")
                        .HasColumnType("datetime");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<long>("TitherDetailId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TitherDetailId");

                    b.ToTable("TithePaymentDetail","dbo");
                });

            modelBuilder.Entity("TitheEnvelopeApi.Models.TitherDetail", b =>
                {
                    b.Property<long>("TitherDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameOfTither")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("TitherDetailId");

                    b.ToTable("TitherDetail","dbo");
                });

            modelBuilder.Entity("TitheEnvelopeApi.Models.TithePaymentDetail", b =>
                {
                    b.HasOne("TitheEnvelopeApi.Models.TitherDetail", "TitherDetail")
                        .WithMany("TithePaymentDetails")
                        .HasForeignKey("TitherDetailId")
                        .OnDelete(DeleteBehavior.SetNull);
                });
#pragma warning restore 612, 618
        }
    }
}
