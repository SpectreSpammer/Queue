﻿// <auto-generated />
using BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace QueueSettings.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240415065914_AddQueueSettingsToDatabase")]
    partial class AddQueueSettingsToDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.DataAccess.Data.QueueEmployeeSettings", b =>
                {
                    b.Property<int>("QueueGuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QueueGuid"));

                    b.Property<string>("QueueName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("isSharedQueue")
                        .HasColumnType("int");

                    b.HasKey("QueueGuid");

                    b.ToTable("queueEmployeeSettings");
                });
#pragma warning restore 612, 618
        }
    }
}
