using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Demo.Service.Models
{
    public partial class mBarkDemoContext : DbContext
    {
        public mBarkDemoContext()
        {
        }

        public mBarkDemoContext(DbContextOptions<mBarkDemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Manifest> Manifest { get; set; }
        public virtual DbSet<Metadata> Metadata { get; set; }
        public virtual DbSet<Userslogin> Userslogin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=VGPCDOTNET-03\\SQLEXPRESS;Database=mBarkDemo;user id = sa;password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Manifest>(entity =>
            {
                entity.HasKey(e => new { e.VoyNo, e.BookingNo })
                    .HasName("PK__Manifest__CF977EA7F12907BC");

                entity.Property(e => e.VoyNo).HasColumnName("voyNo");

                entity.Property(e => e.BookingNo).HasColumnName("bookingNo");

                entity.Property(e => e.AuthNo)
                    .IsRequired()
                    .HasColumnName("authNo")
                    .HasMaxLength(450);

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasColumnName("barcode")
                    .HasMaxLength(450);

                entity.Property(e => e.CabinCategory)
                    .IsRequired()
                    .HasColumnName("cabinCategory")
                    .HasMaxLength(450);

                entity.Property(e => e.CcExpiry)
                    .IsRequired()
                    .HasColumnName("ccExpiry")
                    .HasMaxLength(450);

                entity.Property(e => e.CcHolderName)
                    .IsRequired()
                    .HasColumnName("ccHolderName")
                    .HasMaxLength(450);

                entity.Property(e => e.CcMaskedNo)
                    .IsRequired()
                    .HasColumnName("ccMaskedNo")
                    .HasMaxLength(450);

                entity.Property(e => e.CcToken)
                    .IsRequired()
                    .HasColumnName("ccToken")
                    .HasMaxLength(450);

                entity.Property(e => e.CcType)
                    .IsRequired()
                    .HasColumnName("ccType")
                    .HasMaxLength(450);

                entity.Property(e => e.CheckInStatus)
                    .IsRequired()
                    .HasColumnName("checkInStatus")
                    .HasMaxLength(450);

                entity.Property(e => e.CheckInWindow)
                    .IsRequired()
                    .HasColumnName("checkInWindow")
                    .HasMaxLength(450);

                entity.Property(e => e.CheckoutDate)
                    .IsRequired()
                    .HasColumnName("checkoutDate")
                    .HasMaxLength(450);

                entity.Property(e => e.ChkInDateTime)
                    .IsRequired()
                    .HasColumnName("chkInDateTime")
                    .HasMaxLength(450);

                entity.Property(e => e.DateofBirth)
                    .IsRequired()
                    .HasColumnName("dateofBirth")
                    .HasMaxLength(450);

                entity.Property(e => e.DepartTime)
                    .IsRequired()
                    .HasColumnName("departTime")
                    .HasMaxLength(450);

                entity.Property(e => e.DocExpiryDate)
                    .IsRequired()
                    .HasColumnName("docExpiryDate")
                    .HasMaxLength(450);

                entity.Property(e => e.DocIssueCountry)
                    .IsRequired()
                    .HasColumnName("docIssueCountry")
                    .HasMaxLength(450);

                entity.Property(e => e.DocIssueDate)
                    .IsRequired()
                    .HasColumnName("docIssueDate")
                    .HasMaxLength(450);

                entity.Property(e => e.DocNumber)
                    .IsRequired()
                    .HasColumnName("docNumber")
                    .HasMaxLength(450);

                entity.Property(e => e.DocType)
                    .IsRequired()
                    .HasColumnName("docType")
                    .HasMaxLength(450);

                entity.Property(e => e.EmbarkationDate)
                    .IsRequired()
                    .HasColumnName("embarkationDate")
                    .HasMaxLength(450);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("firstName")
                    .IsUnicode(false);

                entity.Property(e => e.FlagStatus)
                    .IsRequired()
                    .HasColumnName("flagStatus")
                    .HasMaxLength(450);

                entity.Property(e => e.Folio)
                    .IsRequired()
                    .HasColumnName("folio")
                    .HasMaxLength(450);

                entity.Property(e => e.GQuestionRes1)
                    .IsRequired()
                    .HasColumnName("gQuestionRes1")
                    .HasMaxLength(450);

                entity.Property(e => e.GQuestionRes2)
                    .IsRequired()
                    .HasColumnName("gQuestionRes2")
                    .HasMaxLength(450);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasMaxLength(450);

                entity.Property(e => e.GuestId)
                    .IsRequired()
                    .HasColumnName("guestId")
                    .HasMaxLength(450);

                entity.Property(e => e.GuestImage)
                    .IsRequired()
                    .HasColumnName("guestImage")
                    .HasMaxLength(450);

                entity.Property(e => e.GuestStatus)
                    .IsRequired()
                    .HasColumnName("guestStatus")
                    .HasMaxLength(450);

                entity.Property(e => e.GuestType)
                    .IsRequired()
                    .HasColumnName("guestType")
                    .HasMaxLength(450);

                entity.Property(e => e.HttpStatusCode)
                    .HasColumnName("httpStatusCode")
                    .HasMaxLength(450);

                entity.Property(e => e.IsCheckedIn)
                    .IsRequired()
                    .HasColumnName("isCheckedIn")
                    .HasMaxLength(450);

                entity.Property(e => e.IsOlc)
                    .IsRequired()
                    .HasColumnName("isOLC")
                    .HasMaxLength(450);

                entity.Property(e => e.IsResponsible)
                    .IsRequired()
                    .HasColumnName("isResponsible")
                    .HasMaxLength(450);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("lastName")
                    .IsUnicode(false);

                entity.Property(e => e.Loyalty)
                    .IsRequired()
                    .HasColumnName("loyalty")
                    .HasMaxLength(450);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .IsUnicode(false);

                entity.Property(e => e.MusterStation)
                    .IsRequired()
                    .HasColumnName("musterStation")
                    .HasMaxLength(450);

                entity.Property(e => e.Nationality)
                    .IsRequired()
                    .HasColumnName("nationality")
                    .HasMaxLength(450);

                entity.Property(e => e.OnboardStatus)
                    .IsRequired()
                    .HasColumnName("onboardStatus")
                    .HasMaxLength(450);

                entity.Property(e => e.PQuestionRes1)
                    .IsRequired()
                    .HasColumnName("pQuestionRes1")
                    .HasMaxLength(450);

                entity.Property(e => e.PQuestionRes2)
                    .IsRequired()
                    .HasColumnName("pQuestionRes2")
                    .HasMaxLength(450);

                entity.Property(e => e.PictureType)
                    .IsRequired()
                    .HasColumnName("pictureType")
                    .HasMaxLength(450);

                entity.Property(e => e.PlaceofBirth)
                    .IsRequired()
                    .HasColumnName("placeofBirth")
                    .HasMaxLength(450);

                entity.Property(e => e.PurposeofVisit)
                    .IsRequired()
                    .HasColumnName("purposeofVisit")
                    .HasMaxLength(450);

                entity.Property(e => e.RequestedBy)
                    .IsRequired()
                    .HasColumnName("requestedBy")
                    .HasMaxLength(450);

                entity.Property(e => e.RequestorName)
                    .IsRequired()
                    .HasColumnName("requestorName")
                    .HasMaxLength(450);

                entity.Property(e => e.SailDate)
                    .IsRequired()
                    .HasColumnName("sailDate")
                    .HasMaxLength(450);

                entity.Property(e => e.SeqNo).HasColumnName("seqNo");

                entity.Property(e => e.ShipCode)
                    .IsRequired()
                    .HasColumnName("shipCode")
                    .HasMaxLength(450);

                entity.Property(e => e.ShipName)
                    .IsRequired()
                    .HasColumnName("shipName")
                    .IsUnicode(false);

                entity.Property(e => e.StateRoom)
                    .IsRequired()
                    .HasColumnName("stateRoom")
                    .HasMaxLength(450);

                entity.Property(e => e.Success)
                    .HasColumnName("success")
                    .HasMaxLength(450);

                entity.Property(e => e.TimeInMillis)
                    .HasColumnName("timeInMillis")
                    .HasMaxLength(450);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(450);

                entity.Property(e => e.Zone)
                    .IsRequired()
                    .HasColumnName("zone")
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<Metadata>(entity =>
            {
                entity.HasKey(e => e.Voyno);

                entity.Property(e => e.Voyno)
                    .HasColumnName("voyno")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgeMinor)
                    .IsRequired()
                    .HasColumnName("ageMinor")
                    .HasMaxLength(450);

                entity.Property(e => e.CntryCode)
                    .IsRequired()
                    .HasColumnName("cntryCode")
                    .HasMaxLength(450);

                entity.Property(e => e.CntryName)
                    .IsRequired()
                    .HasColumnName("cntryName")
                    .IsUnicode(false);

                entity.Property(e => e.Docname)
                    .IsRequired()
                    .HasColumnName("docname")
                    .HasMaxLength(450);

                entity.Property(e => e.Doctype)
                    .IsRequired()
                    .HasColumnName("doctype")
                    .HasMaxLength(450);

                entity.Property(e => e.Docvalidityreq)
                    .IsRequired()
                    .HasColumnName("docvalidityreq")
                    .HasMaxLength(450);

                entity.Property(e => e.Homeportcntry)
                    .IsRequired()
                    .HasColumnName("homeportcntry")
                    .HasMaxLength(450);

                entity.Property(e => e.IsAutoDeleteManifest)
                    .IsRequired()
                    .HasColumnName("isAutoDeleteManifest")
                    .HasMaxLength(450);

                entity.Property(e => e.IsB1b2visaCheckin)
                    .IsRequired()
                    .HasColumnName("isB1B2VisaCheckin")
                    .HasMaxLength(450);

                entity.Property(e => e.IsDocallowedinForeign)
                    .IsRequired()
                    .HasColumnName("isDocallowedinForeign")
                    .HasMaxLength(450);

                entity.Property(e => e.IsHealthQuestionsReq)
                    .IsRequired()
                    .HasColumnName("isHealthQuestionsReq")
                    .HasMaxLength(450);

                entity.Property(e => e.IsNonVisaWaiverAllowed)
                    .IsRequired()
                    .HasColumnName("isNonVisaWaiverAllowed")
                    .HasMaxLength(450);

                entity.Property(e => e.IsPassportReceiptReq)
                    .IsRequired()
                    .HasColumnName("isPassportReceiptReq")
                    .HasMaxLength(450);

                entity.Property(e => e.IsPlaceBirth)
                    .IsRequired()
                    .HasColumnName("isPlaceBirth")
                    .HasMaxLength(450);

                entity.Property(e => e.IsPregQuestionsReq)
                    .IsRequired()
                    .HasColumnName("isPregQuestionsReq")
                    .HasMaxLength(450);

                entity.Property(e => e.IsRetryRfidlift)
                    .IsRequired()
                    .HasColumnName("isRetryRFIDLift")
                    .HasMaxLength(450);

                entity.Property(e => e.IsVisaWaiver)
                    .IsRequired()
                    .HasColumnName("isVisaWaiver")
                    .HasMaxLength(450);

                entity.Property(e => e.Isdocexpdtreq)
                    .IsRequired()
                    .HasColumnName("isdocexpdtreq")
                    .HasMaxLength(450);

                entity.Property(e => e.Isdocissuecntryreq)
                    .IsRequired()
                    .HasColumnName("isdocissuecntryreq")
                    .HasMaxLength(450);

                entity.Property(e => e.Isdocissuedate)
                    .IsRequired()
                    .HasColumnName("isdocissuedate")
                    .HasMaxLength(450);

                entity.Property(e => e.Isdocnumreq)
                    .IsRequired()
                    .HasColumnName("isdocnumreq")
                    .HasMaxLength(450);

                entity.Property(e => e.OfflineTimeout)
                    .IsRequired()
                    .HasColumnName("offlineTimeout")
                    .HasMaxLength(450);

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasColumnName("question")
                    .IsUnicode(false);

                entity.Property(e => e.QuestionNo)
                    .IsRequired()
                    .HasColumnName("questionNo")
                    .HasMaxLength(450);

                entity.Property(e => e.QuestionType)
                    .IsRequired()
                    .HasColumnName("questionType")
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<Userslogin>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__Userslog__F3DBC5739E6D3E02");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasColumnName("client_id")
                    .HasMaxLength(450);

                entity.Property(e => e.ClientSecret)
                    .IsRequired()
                    .HasColumnName("client_secret")
                    .HasMaxLength(450);

                entity.Property(e => e.GrantType)
                    .IsRequired()
                    .HasColumnName("grant_type")
                    .HasMaxLength(450);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(450);
            });
        }
    }
}
