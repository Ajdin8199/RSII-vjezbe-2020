﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eProdaja.Models;

namespace eProdaja.Migrations
{
    [DbContext(typeof(eProdajaContext))]
    [Migration("20200531131416_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eProdaja.Models.Dobavljaci", b =>
                {
                    b.Property<int>("DobavljacId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DobavljacID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("KontaktOsoba")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Napomena")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("Web")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ZiroRacuni")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("DobavljacId");

                    b.ToTable("Dobavljaci");
                });

            modelBuilder.Entity("eProdaja.Models.IzlazStavke", b =>
                {
                    b.Property<int>("IzlazStavkaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IzlazStavkaID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cijena")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("IzlazId")
                        .HasColumnName("IzlazID")
                        .HasColumnType("int");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<decimal?>("Popust")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<int>("ProizvodId")
                        .HasColumnName("ProizvodID")
                        .HasColumnType("int");

                    b.HasKey("IzlazStavkaId");

                    b.HasIndex("IzlazId");

                    b.HasIndex("ProizvodId");

                    b.ToTable("IzlazStavke");
                });

            modelBuilder.Entity("eProdaja.Models.Izlazi", b =>
                {
                    b.Property<int>("IzlazId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IzlazID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrojRacuna")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime");

                    b.Property<decimal>("IznosBezPdv")
                        .HasColumnName("IznosBezPDV")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("IznosSaPdv")
                        .HasColumnName("IznosSaPDV")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("KorisnikId")
                        .HasColumnName("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int?>("NarudzbaId")
                        .HasColumnName("NarudzbaID")
                        .HasColumnType("int");

                    b.Property<int>("SkladisteId")
                        .HasColumnName("SkladisteID")
                        .HasColumnType("int");

                    b.Property<bool>("Zakljucen")
                        .HasColumnType("bit");

                    b.HasKey("IzlazId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("NarudzbaId");

                    b.HasIndex("SkladisteId");

                    b.ToTable("Izlazi");
                });

            modelBuilder.Entity("eProdaja.Models.JediniceMjere", b =>
                {
                    b.Property<int>("JedinicaMjereId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("JedinicaMjereID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("JedinicaMjereId");

                    b.ToTable("JediniceMjere");
                });

            modelBuilder.Entity("eProdaja.Models.Korisnici", b =>
                {
                    b.Property<int>("KorisnikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("KorisnikID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LozinkaHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("LozinkaSalt")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool?>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("KorisnikId");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasName("CS_Email")
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("KorisnickoIme")
                        .IsUnique()
                        .HasName("CS_KorisnickoIme");

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("eProdaja.Models.KorisniciUloge", b =>
                {
                    b.Property<int>("KorisnikUlogaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("KorisnikUlogaID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumIzmjene")
                        .HasColumnType("datetime");

                    b.Property<int>("KorisnikId")
                        .HasColumnName("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int>("UlogaId")
                        .HasColumnName("UlogaID")
                        .HasColumnType("int");

                    b.HasKey("KorisnikUlogaId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("UlogaId");

                    b.ToTable("KorisniciUloge");
                });

            modelBuilder.Entity("eProdaja.Models.Kupci", b =>
                {
                    b.Property<int>("KupacId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("KupacID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumRegistracije")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LozinkaHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LozinkaSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("KupacId");

                    b.ToTable("Kupci");
                });

            modelBuilder.Entity("eProdaja.Models.NarudzbaStavke", b =>
                {
                    b.Property<int>("NarudzbaStavkaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("NarudzbaStavkaID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int>("NarudzbaId")
                        .HasColumnName("NarudzbaID")
                        .HasColumnType("int");

                    b.Property<int>("ProizvodId")
                        .HasColumnName("ProizvodID")
                        .HasColumnType("int");

                    b.HasKey("NarudzbaStavkaId");

                    b.HasIndex("NarudzbaId");

                    b.HasIndex("ProizvodId");

                    b.ToTable("NarudzbaStavke");
                });

            modelBuilder.Entity("eProdaja.Models.Narudzbe", b =>
                {
                    b.Property<int>("NarudzbaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("NarudzbaID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrojNarudzbe")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime");

                    b.Property<int>("KupacId")
                        .HasColumnName("KupacID")
                        .HasColumnType("int");

                    b.Property<bool?>("Otkazano")
                        .HasColumnType("bit");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("NarudzbaId");

                    b.HasIndex("KupacId");

                    b.ToTable("Narudzbe");
                });

            modelBuilder.Entity("eProdaja.Models.Ocjene", b =>
                {
                    b.Property<int>("OcjenaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OcjenaID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime");

                    b.Property<int>("KupacId")
                        .HasColumnName("KupacID")
                        .HasColumnType("int");

                    b.Property<int>("Ocjena")
                        .HasColumnType("int");

                    b.Property<int>("ProizvodId")
                        .HasColumnName("ProizvodID")
                        .HasColumnType("int");

                    b.HasKey("OcjenaId");

                    b.HasIndex("KupacId");

                    b.HasIndex("ProizvodId");

                    b.ToTable("Ocjene");
                });

            modelBuilder.Entity("eProdaja.Models.Proizvodi", b =>
                {
                    b.Property<int>("ProizvodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ProizvodID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cijena")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("JedinicaMjereId")
                        .HasColumnName("JedinicaMjereID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Sifra")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("SlikaThumb")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool?>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("VrstaId")
                        .HasColumnName("VrstaID")
                        .HasColumnType("int");

                    b.HasKey("ProizvodId");

                    b.HasIndex("JedinicaMjereId");

                    b.HasIndex("VrstaId");

                    b.ToTable("Proizvodi");
                });

            modelBuilder.Entity("eProdaja.Models.Skladista", b =>
                {
                    b.Property<int>("SkladisteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SkladisteID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("SkladisteId");

                    b.ToTable("Skladista");
                });

            modelBuilder.Entity("eProdaja.Models.UlazStavke", b =>
                {
                    b.Property<int>("UlazStavkaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UlazStavkaID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cijena")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int>("ProizvodId")
                        .HasColumnName("ProizvodID")
                        .HasColumnType("int");

                    b.Property<int>("UlazId")
                        .HasColumnName("UlazID")
                        .HasColumnType("int");

                    b.HasKey("UlazStavkaId");

                    b.HasIndex("ProizvodId");

                    b.HasIndex("UlazId");

                    b.ToTable("UlazStavke");
                });

            modelBuilder.Entity("eProdaja.Models.Ulazi", b =>
                {
                    b.Property<int>("UlazId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UlazID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrojFakture")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime");

                    b.Property<int>("DobavljacId")
                        .HasColumnName("DobavljacID")
                        .HasColumnType("int");

                    b.Property<decimal>("IznosRacuna")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("KorisnikId")
                        .HasColumnName("KorisnikID")
                        .HasColumnType("int");

                    b.Property<string>("Napomena")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<decimal>("Pdv")
                        .HasColumnName("PDV")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<int>("SkladisteId")
                        .HasColumnName("SkladisteID")
                        .HasColumnType("int");

                    b.HasKey("UlazId");

                    b.HasIndex("DobavljacId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("SkladisteId");

                    b.ToTable("Ulazi");
                });

            modelBuilder.Entity("eProdaja.Models.Uloge", b =>
                {
                    b.Property<int>("UlogaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UlogaID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("UlogaId");

                    b.ToTable("Uloge");
                });

            modelBuilder.Entity("eProdaja.Models.VrsteProizvoda", b =>
                {
                    b.Property<int>("VrstaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("VrstaID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("VrstaId");

                    b.ToTable("VrsteProizvoda");
                });

            modelBuilder.Entity("eProdaja.Models.IzlazStavke", b =>
                {
                    b.HasOne("eProdaja.Models.Izlazi", "Izlaz")
                        .WithMany("IzlazStavke")
                        .HasForeignKey("IzlazId")
                        .HasConstraintName("FK_IzlazStavke_Izlazi")
                        .IsRequired();

                    b.HasOne("eProdaja.Models.Proizvodi", "Proizvod")
                        .WithMany("IzlazStavke")
                        .HasForeignKey("ProizvodId")
                        .HasConstraintName("FK_IzlazStavke_Proizvodi")
                        .IsRequired();
                });

            modelBuilder.Entity("eProdaja.Models.Izlazi", b =>
                {
                    b.HasOne("eProdaja.Models.Korisnici", "Korisnik")
                        .WithMany("Izlazi")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK_Izlazi_Korisnici")
                        .IsRequired();

                    b.HasOne("eProdaja.Models.Narudzbe", "Narudzba")
                        .WithMany("Izlazi")
                        .HasForeignKey("NarudzbaId")
                        .HasConstraintName("FK_Izlazi_Narudzbe");

                    b.HasOne("eProdaja.Models.Skladista", "Skladiste")
                        .WithMany("Izlazi")
                        .HasForeignKey("SkladisteId")
                        .HasConstraintName("FK_Izlazi_Skladista")
                        .IsRequired();
                });

            modelBuilder.Entity("eProdaja.Models.KorisniciUloge", b =>
                {
                    b.HasOne("eProdaja.Models.Korisnici", "Korisnik")
                        .WithMany("KorisniciUloge")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK_KorisniciUloge_Korisnici")
                        .IsRequired();

                    b.HasOne("eProdaja.Models.Uloge", "Uloga")
                        .WithMany("KorisniciUloge")
                        .HasForeignKey("UlogaId")
                        .HasConstraintName("FK_KorisniciUloge_Uloge")
                        .IsRequired();
                });

            modelBuilder.Entity("eProdaja.Models.NarudzbaStavke", b =>
                {
                    b.HasOne("eProdaja.Models.Narudzbe", "Narudzba")
                        .WithMany("NarudzbaStavke")
                        .HasForeignKey("NarudzbaId")
                        .HasConstraintName("FK_NarudzbaStavke_Narudzbe")
                        .IsRequired();

                    b.HasOne("eProdaja.Models.Proizvodi", "Proizvod")
                        .WithMany("NarudzbaStavke")
                        .HasForeignKey("ProizvodId")
                        .HasConstraintName("FK_NarudzbaStavke_Proizvodi")
                        .IsRequired();
                });

            modelBuilder.Entity("eProdaja.Models.Narudzbe", b =>
                {
                    b.HasOne("eProdaja.Models.Kupci", "Kupac")
                        .WithMany("Narudzbe")
                        .HasForeignKey("KupacId")
                        .HasConstraintName("FK_Narudzbe_Kupci")
                        .IsRequired();
                });

            modelBuilder.Entity("eProdaja.Models.Ocjene", b =>
                {
                    b.HasOne("eProdaja.Models.Kupci", "Kupac")
                        .WithMany("Ocjene")
                        .HasForeignKey("KupacId")
                        .HasConstraintName("FK_Ocjene_Kupci")
                        .IsRequired();

                    b.HasOne("eProdaja.Models.Proizvodi", "Proizvod")
                        .WithMany("Ocjene")
                        .HasForeignKey("ProizvodId")
                        .HasConstraintName("FK_Ocjene_Proizvodi")
                        .IsRequired();
                });

            modelBuilder.Entity("eProdaja.Models.Proizvodi", b =>
                {
                    b.HasOne("eProdaja.Models.JediniceMjere", "JedinicaMjere")
                        .WithMany("Proizvodi")
                        .HasForeignKey("JedinicaMjereId")
                        .HasConstraintName("FK_Proizvodi_JediniceMjere")
                        .IsRequired();

                    b.HasOne("eProdaja.Models.VrsteProizvoda", "Vrsta")
                        .WithMany("Proizvodi")
                        .HasForeignKey("VrstaId")
                        .HasConstraintName("FK_Proizvodi_VrsteProizvoda")
                        .IsRequired();
                });

            modelBuilder.Entity("eProdaja.Models.UlazStavke", b =>
                {
                    b.HasOne("eProdaja.Models.Proizvodi", "Proizvod")
                        .WithMany("UlazStavke")
                        .HasForeignKey("ProizvodId")
                        .HasConstraintName("FK_UlazStavke_Proizvodi")
                        .IsRequired();

                    b.HasOne("eProdaja.Models.Ulazi", "Ulaz")
                        .WithMany("UlazStavke")
                        .HasForeignKey("UlazId")
                        .HasConstraintName("FK_UlazStavke_Ulazi")
                        .IsRequired();
                });

            modelBuilder.Entity("eProdaja.Models.Ulazi", b =>
                {
                    b.HasOne("eProdaja.Models.Dobavljaci", "Dobavljac")
                        .WithMany("Ulazi")
                        .HasForeignKey("DobavljacId")
                        .HasConstraintName("FK_Ulazi_Dobavljaci")
                        .IsRequired();

                    b.HasOne("eProdaja.Models.Korisnici", "Korisnik")
                        .WithMany("Ulazi")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK_Ulazi_Korisnici")
                        .IsRequired();

                    b.HasOne("eProdaja.Models.Skladista", "Skladiste")
                        .WithMany("Ulazi")
                        .HasForeignKey("SkladisteId")
                        .HasConstraintName("FK_Ulazi_Skladista")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
