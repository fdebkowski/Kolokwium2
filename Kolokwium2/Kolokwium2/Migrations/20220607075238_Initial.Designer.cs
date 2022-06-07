﻿// <auto-generated />
using System;
using Kolokwium2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kolokwium2.Migrations
{
    [DbContext(typeof(ManagementContext))]
    [Migration("20220607075238_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Kolokwium2.Entities.Event", b =>
                {
                    b.Property<int>("IdEvent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEvent"), 1L, 1);

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateTo")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdEvent");

                    b.ToTable("Event", (string)null);
                });

            modelBuilder.Entity("Kolokwium2.Entities.EventOrganiser", b =>
                {
                    b.Property<int>("IdEvent")
                        .HasColumnType("int");

                    b.Property<int>("IdOrganiser")
                        .HasColumnType("int");

                    b.Property<bool>("MainOrganiser")
                        .HasColumnType("bit");

                    b.HasKey("IdEvent", "IdOrganiser");

                    b.HasIndex("IdOrganiser");

                    b.ToTable("Event_Organiser", (string)null);
                });

            modelBuilder.Entity("Kolokwium2.Entities.Organiser", b =>
                {
                    b.Property<int>("IdOrganiser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdOrganiser"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdOrganiser");

                    b.ToTable("Organisers", (string)null);
                });

            modelBuilder.Entity("Kolokwium2.Entities.EventOrganiser", b =>
                {
                    b.HasOne("Kolokwium2.Entities.Event", "IdEventNavigation")
                        .WithMany("EventOrganisers")
                        .HasForeignKey("IdEvent")
                        .IsRequired()
                        .HasConstraintName("EventOrganiser_Event");

                    b.HasOne("Kolokwium2.Entities.Organiser", "IdOrganiserNavigation")
                        .WithMany("EventOrganisers")
                        .HasForeignKey("IdOrganiser")
                        .IsRequired()
                        .HasConstraintName("EventOrganiser_Organiser");

                    b.Navigation("IdEventNavigation");

                    b.Navigation("IdOrganiserNavigation");
                });

            modelBuilder.Entity("Kolokwium2.Entities.Event", b =>
                {
                    b.Navigation("EventOrganisers");
                });

            modelBuilder.Entity("Kolokwium2.Entities.Organiser", b =>
                {
                    b.Navigation("EventOrganisers");
                });
#pragma warning restore 612, 618
        }
    }
}
