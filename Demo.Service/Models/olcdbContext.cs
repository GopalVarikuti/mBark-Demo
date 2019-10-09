using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Demo.Service.Models
{
    public partial class olcdbContext : DbContext
    {
        public olcdbContext()
        {
        }

        public olcdbContext(DbContextOptions<olcdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bookingdetails> Bookingdetails { get; set; }
        public virtual DbSet<Cardtype> Cardtype { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Metadata> Metadata { get; set; }
        public virtual DbSet<Title> Title { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=VGPCDOTNET-03\\SQLEXPRESS;Database=olcdb;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Bookingdetails>(entity =>
            {
                entity.HasKey(e => new { e.Bookingno, e.Guestid })
                    .HasName("PK_composite");

                entity.ToTable("bookingdetails", "dbo");

                entity.Property(e => e.Bookingno)
                    .HasColumnName("bookingno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Guestid)
                    .HasColumnName("guestid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Barcode)
                    .HasColumnName("barcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cabin)
                    .HasColumnName("cabin")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ccexpiry)
                    .HasColumnName("ccexpiry")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ccholdername)
                    .HasColumnName("ccholdername")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ccissuedate)
                    .HasColumnName("ccissuedate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ccmaskedno)
                    .HasColumnName("ccmaskedno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cctoken)
                    .HasColumnName("cctoken")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cctype)
                    .HasColumnName("cctype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Currencycode)
                    .HasColumnName("currencycode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dateofbirth)
                    .HasColumnName("dateofbirth")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Debarkationdate)
                    .HasColumnName("debarkationdate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dlastname)
                    .HasColumnName("dlastname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Docexpirydate)
                    .HasColumnName("docexpirydate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Docissuecountry)
                    .HasColumnName("docissuecountry")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Docissuedate)
                    .HasColumnName("docissuedate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Docnumber)
                    .HasColumnName("docnumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Doctype)
                    .HasColumnName("doctype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Embarkationdate)
                    .HasColumnName("embarkationdate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Folio)
                    .HasColumnName("folio")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Givenname)
                    .HasColumnName("givenname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Guesttype)
                    .HasColumnName("guesttype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Iscctokenpresent)
                    .HasColumnName("iscctokenpresent")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdocumentinfocomplete)
                    .HasColumnName("isdocumentinfocomplete")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isolc)
                    .HasColumnName("isolc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ispaymentcomplete)
                    .HasColumnName("ispaymentcomplete")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isresponsible)
                    .HasColumnName("isresponsible")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Loyalty)
                    .HasColumnName("loyalty")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Middlename)
                    .HasColumnName("middlename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nationality)
                    .HasColumnName("nationality")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Olcenabled)
                    .HasColumnName("olcenabled")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Placeofbirth)
                    .HasColumnName("placeofbirth")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plastname)
                    .HasColumnName("plastname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreauthorisedToken)
                    .HasColumnName("preauthorisedToken")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Registeredcardid)
                    .HasColumnName("registeredcardid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Seqno)
                    .HasColumnName("seqno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Shipcode)
                    .HasColumnName("shipcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Shipname)
                    .HasColumnName("shipname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Voyno)
                    .HasColumnName("voyno")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cardtype>(entity =>
            {
                entity.HasKey(e => e.Cardid)
                    .HasName("PK__cardtype__4D66F8D962651B6F");

                entity.ToTable("cardtype", "dbo");

                entity.Property(e => e.Cardid)
                    .HasColumnName("cardid")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Displayname)
                    .HasColumnName("displayname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Voyno)
                    .HasColumnName("voyno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.VoynoNavigation)
                    .WithMany(p => p.Cardtype)
                    .HasForeignKey(d => d.Voyno)
                    .HasConstraintName("FK__cardtype__voyno__1BFD2C07");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.Cntryid)
                    .HasName("PK__country__F394C4F666EE356D");

                entity.ToTable("country", "dbo");

                entity.Property(e => e.Cntryid)
                    .HasColumnName("cntryid")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Cntrycode)
                    .HasColumnName("cntrycode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cntryname)
                    .HasColumnName("cntryname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Voyno)
                    .HasColumnName("voyno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.VoynoNavigation)
                    .WithMany(p => p.Country)
                    .HasForeignKey(d => d.Voyno)
                    .HasConstraintName("FK__country__voyno__1CF15040");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasKey(e => e.Docid)
                    .HasName("PK__document__0638DBFA2A7E745E");

                entity.ToTable("document", "dbo");

                entity.Property(e => e.Docid)
                    .HasColumnName("docid")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Docexpirymessage)
                    .HasColumnName("docexpirymessage")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Docexpirytolerancedays)
                    .HasColumnName("docexpirytolerancedays")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Docexpiryyears)
                    .HasColumnName("docexpiryyears")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Docname)
                    .HasColumnName("docname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Docnote)
                    .HasColumnName("docnote")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Doctype)
                    .HasColumnName("doctype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdocallowedinforeign)
                    .HasColumnName("isdocallowedinforeign")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdocexpdtreq)
                    .HasColumnName("isdocexpdtreq")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdocissuecntryreq)
                    .HasColumnName("isdocissuecntryreq")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdocissuedate)
                    .HasColumnName("isdocissuedate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdocnumreq)
                    .HasColumnName("isdocnumreq")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdocvalidityreq)
                    .HasColumnName("isdocvalidityreq")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Voyno)
                    .HasColumnName("voyno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.VoynoNavigation)
                    .WithMany(p => p.Document)
                    .HasForeignKey(d => d.Voyno)
                    .HasConstraintName("FK__document__voyno__1DE57479");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("PK__gender__DCD80EF8F1B9C91B");

                entity.ToTable("gender", "dbo");

                entity.Property(e => e.Gid)
                    .HasColumnName("gid")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Voyno)
                    .HasColumnName("voyno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.VoynoNavigation)
                    .WithMany(p => p.Gender)
                    .HasForeignKey(d => d.Voyno)
                    .HasConstraintName("FK__gender__voyno__1ED998B2");
            });

            modelBuilder.Entity<Metadata>(entity =>
            {
                entity.HasKey(e => e.Voyno)
                    .HasName("PK__metadata__B3F974A93D662710");

                entity.ToTable("metadata", "dbo");

                entity.Property(e => e.Voyno)
                    .HasColumnName("voyno")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Cardexpirymessage)
                    .HasColumnName("cardexpirymessage")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cardexpirytolerancedays)
                    .HasColumnName("cardexpirytolerancedays")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cardexpiryyears)
                    .HasColumnName("cardexpiryyears")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cruisecontract)
                    .HasColumnName("cruisecontract")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Currencycode)
                    .HasColumnName("currencycode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Debarkationdate)
                    .HasColumnName("debarkationdate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dobyears)
                    .HasColumnName("dobyears")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Embarkationdate)
                    .HasColumnName("embarkationdate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Shipcode)
                    .HasColumnName("shipcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Shipname)
                    .HasColumnName("shipname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vurl)
                    .HasColumnName("vurl")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Title>(entity =>
            {
                entity.HasKey(e => e.Tid)
                    .HasName("PK__title__DC105B0FA8A5EEA5");

                entity.ToTable("title", "dbo");

                entity.Property(e => e.Tid)
                    .HasColumnName("tid")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Voyno)
                    .HasColumnName("voyno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.VoynoNavigation)
                    .WithMany(p => p.Title)
                    .HasForeignKey(d => d.Voyno)
                    .HasConstraintName("FK__title__voyno__1FCDBCEB");
            });
        }
    }
}
