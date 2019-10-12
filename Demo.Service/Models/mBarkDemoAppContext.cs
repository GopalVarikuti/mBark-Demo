using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Demo.Service.Models
{
    public partial class mBarkDemoAppContext : DbContext
    {
        public mBarkDemoAppContext()
        {
        }

        public mBarkDemoAppContext(DbContextOptions<mBarkDemoAppContext> options)
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
                optionsBuilder.UseSqlServer("Server=VGPCDOTNET-02;Database=mBarkDemoApp;user id = sa;password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Manifest>(entity =>
            {
                entity.HasKey(e => e.BookingNo)
                    .HasName("PK__Manifest__C6D06266B7747427");

                entity.Property(e => e.BookingNo)
                    .HasColumnName("bookingNo")
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.AgentName)
                    .HasColumnName("agentName")
                    .HasMaxLength(100);

                entity.Property(e => e.AuthNo)
                    .HasColumnName("authNo")
                    .HasMaxLength(100);

                entity.Property(e => e.Barcode)
                    .HasColumnName("barcode")
                    .HasMaxLength(100);

                entity.Property(e => e.CabinCategory)
                    .HasColumnName("cabinCategory")
                    .HasMaxLength(100);

                entity.Property(e => e.CcExpiry)
                    .HasColumnName("ccExpiry")
                    .HasMaxLength(100);

                entity.Property(e => e.CcHolderName)
                    .HasColumnName("ccHolderName")
                    .HasMaxLength(100);

                entity.Property(e => e.CcMaskedNo)
                    .HasColumnName("ccMaskedNo")
                    .HasMaxLength(100);

                entity.Property(e => e.CcToken)
                    .HasColumnName("ccToken")
                    .HasMaxLength(100);

                entity.Property(e => e.CcType)
                    .HasColumnName("ccType")
                    .HasMaxLength(100);

                entity.Property(e => e.CheckInStatus)
                    .HasColumnName("checkInStatus")
                    .HasMaxLength(100);

                entity.Property(e => e.CheckInWindow)
                    .HasColumnName("checkInWindow")
                    .HasMaxLength(100);

                entity.Property(e => e.CheckoutDate)
                    .HasColumnName("checkoutDate")
                    .HasMaxLength(100);

                entity.Property(e => e.ChkInDateTime)
                    .HasColumnName("chkInDateTime")
                    .HasMaxLength(100);

                entity.Property(e => e.DateofBirth)
                    .HasColumnName("dateofBirth")
                    .HasMaxLength(100);

                entity.Property(e => e.DepartTime)
                    .HasColumnName("departTime")
                    .HasMaxLength(100);

                entity.Property(e => e.DeviceId)
                    .HasColumnName("deviceId")
                    .HasMaxLength(100);

                entity.Property(e => e.DocExpiryDate)
                    .HasColumnName("docExpiryDate")
                    .HasMaxLength(100);

                entity.Property(e => e.DocIssueCountry)
                    .HasColumnName("docIssueCountry")
                    .HasMaxLength(100);

                entity.Property(e => e.DocIssueDate)
                    .HasColumnName("docIssueDate")
                    .HasMaxLength(100);

                entity.Property(e => e.DocNumber)
                    .HasColumnName("docNumber")
                    .HasMaxLength(100);

                entity.Property(e => e.DocType)
                    .HasColumnName("docType")
                    .HasMaxLength(100);

                entity.Property(e => e.EmbarkationDate)
                    .HasColumnName("embarkationDate")
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .HasColumnName("firstName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FlagStatus)
                    .HasColumnName("flagStatus")
                    .HasMaxLength(100);

                entity.Property(e => e.Folio)
                    .HasColumnName("folio")
                    .HasMaxLength(100);

                entity.Property(e => e.GQuestionRes1)
                    .HasColumnName("gQuestionRes1")
                    .HasMaxLength(100);

                entity.Property(e => e.GQuestionRes2)
                    .HasColumnName("gQuestionRes2")
                    .HasMaxLength(100);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(100);

                entity.Property(e => e.GuestId)
                    .HasColumnName("guestId")
                    .HasMaxLength(100);

                entity.Property(e => e.GuestImage)
                    .HasColumnName("guestImage")
                    .HasMaxLength(100);

                entity.Property(e => e.GuestStatus)
                    .HasColumnName("guestStatus")
                    .HasMaxLength(100);

                entity.Property(e => e.GuestType)
                    .HasColumnName("guestType")
                    .HasMaxLength(100);

                entity.Property(e => e.HttpStatusCode)
                    .HasColumnName("httpStatusCode")
                    .HasMaxLength(100);

                entity.Property(e => e.IsCheckedIn)
                    .HasColumnName("isCheckedIn")
                    .HasMaxLength(100);

                entity.Property(e => e.IsOlc)
                    .HasColumnName("isOLC")
                    .HasMaxLength(100);

                entity.Property(e => e.IsResponsible)
                    .HasColumnName("isResponsible")
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .HasColumnName("lastName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Loyalty)
                    .HasColumnName("loyalty")
                    .HasMaxLength(100);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .IsUnicode(false);

                entity.Property(e => e.MusterStation)
                    .HasColumnName("musterStation")
                    .HasMaxLength(100);

                entity.Property(e => e.Nationality)
                    .HasColumnName("nationality")
                    .HasMaxLength(100);

                entity.Property(e => e.OnboardStatus)
                    .HasColumnName("onboardStatus")
                    .HasMaxLength(100);

                entity.Property(e => e.PQuestionRes1)
                    .HasColumnName("pQuestionRes1")
                    .HasMaxLength(100);

                entity.Property(e => e.PQuestionRes2)
                    .HasColumnName("pQuestionRes2")
                    .HasMaxLength(100);

                entity.Property(e => e.PictureType)
                    .HasColumnName("pictureType")
                    .HasMaxLength(100);

                entity.Property(e => e.PlaceofBirth)
                    .HasColumnName("placeofBirth")
                    .HasMaxLength(100);

                entity.Property(e => e.ProcessingStatus)
                    .HasColumnName("processingStatus")
                    .HasMaxLength(100);

                entity.Property(e => e.PurposeofVisit)
                    .HasColumnName("purposeofVisit")
                    .HasMaxLength(100);

                entity.Property(e => e.RequestId)
                    .HasColumnName("requestId")
                    .HasMaxLength(100);

                entity.Property(e => e.RequestedBy)
                    .HasColumnName("requestedBy")
                    .HasMaxLength(100);

                entity.Property(e => e.RequestorName)
                    .HasColumnName("requestorName")
                    .HasMaxLength(100);

                entity.Property(e => e.RowId)
                    .HasColumnName("rowId")
                    .HasMaxLength(100);

                entity.Property(e => e.SailDate)
                    .HasColumnName("sailDate")
                    .HasMaxLength(100);

                entity.Property(e => e.SeqNo).HasColumnName("seqNo");

                entity.Property(e => e.ShipCode)
                    .HasColumnName("shipCode")
                    .HasMaxLength(100);

                entity.Property(e => e.ShipId)
                    .HasColumnName("shipId")
                    .HasMaxLength(100);

                entity.Property(e => e.ShipName)
                    .HasColumnName("shipName")
                    .IsUnicode(false);

                entity.Property(e => e.StateRoom)
                    .HasColumnName("stateRoom")
                    .HasMaxLength(100);

                entity.Property(e => e.Success)
                    .HasColumnName("success")
                    .HasMaxLength(100);

                entity.Property(e => e.TimeInMillis)
                    .HasColumnName("timeInMillis")
                    .HasMaxLength(100);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);

                entity.Property(e => e.VoyNo)
                    .HasColumnName("voyNo")
                    .HasMaxLength(100);

                entity.Property(e => e.Zone)
                    .HasColumnName("zone")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Metadata>(entity =>
            {
                entity.HasKey(e => e.BookingNo)
                    .HasName("PK__Metadata__C6D062663506F0C7");

                entity.Property(e => e.BookingNo)
                    .HasColumnName("bookingNo")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Ageminor)
                    .HasColumnName("ageminor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CntryCode)
                    .IsRequired()
                    .HasColumnName("cntryCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CntryName)
                    .IsRequired()
                    .HasColumnName("cntryName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocName)
                    .IsRequired()
                    .HasColumnName("docName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocType)
                    .IsRequired()
                    .HasColumnName("docType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocValidityReq)
                    .IsRequired()
                    .HasColumnName("docValidityReq")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeportCntry)
                    .IsRequired()
                    .HasColumnName("homeportCntry")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsAutoDeleteManifest)
                    .IsRequired()
                    .HasColumnName("isAutoDeleteManifest")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsB1b2visaCheckIn)
                    .IsRequired()
                    .HasColumnName("isB1B2VisaCheckIn")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDocAllowedInForeign)
                    .IsRequired()
                    .HasColumnName("isDocAllowedInForeign")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDocExpdtReq)
                    .IsRequired()
                    .HasColumnName("isDocExpdtReq")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDocIssueCntryReq)
                    .IsRequired()
                    .HasColumnName("isDocIssueCntryReq")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDocIssueDate)
                    .IsRequired()
                    .HasColumnName("isDocIssueDate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDocNumReq)
                    .IsRequired()
                    .HasColumnName("isDocNumReq")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsHealthQuestionsReq)
                    .IsRequired()
                    .HasColumnName("isHealthQuestionsReq")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsNonVisaWaiverAllowed)
                    .IsRequired()
                    .HasColumnName("isNonVisaWaiverAllowed")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsPassportReceiptReq)
                    .IsRequired()
                    .HasColumnName("isPassportReceiptReq")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsPlaceBirth)
                    .IsRequired()
                    .HasColumnName("isPlaceBirth")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsPregQuestionsReq)
                    .IsRequired()
                    .HasColumnName("isPregQuestionsReq")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsRetryRfidlift)
                    .IsRequired()
                    .HasColumnName("isRetryRFIDLift")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsVisaWaiver)
                    .IsRequired()
                    .HasColumnName("isVisaWaiver")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfflineTimeout)
                    .IsRequired()
                    .HasColumnName("offlineTimeout")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasColumnName("question")
                    .IsUnicode(false);

                entity.Property(e => e.QuestionNo)
                    .IsRequired()
                    .HasColumnName("questionNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionType)
                    .IsRequired()
                    .HasColumnName("questionType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCode)
                    .IsRequired()
                    .HasColumnName("shipCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Voyno)
                    .IsRequired()
                    .HasColumnName("voyno")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Userslogin>(entity =>
            {
                entity.HasKey(e => e.Username);

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
