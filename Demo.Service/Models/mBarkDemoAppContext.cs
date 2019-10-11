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

        public virtual DbSet<Metadata> Metadata { get; set; }
        public virtual DbSet<Passengers> Passengers { get; set; }
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

            modelBuilder.Entity<Metadata>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ageminor)
                    .HasColumnName("ageminor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CntryCode)
                    .HasColumnName("cntryCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CntryName)
                    .HasColumnName("cntryName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocName)
                    .HasColumnName("docName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocType)
                    .HasColumnName("docType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocValidityReq)
                    .HasColumnName("docValidityReq")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeportCntry)
                    .HasColumnName("homeportCntry")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsAutoDeleteManifest)
                    .HasColumnName("isAutoDeleteManifest")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsB1b2visaCheckIn)
                    .HasColumnName("isB1B2VisaCheckIn")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDocAllowedInForeign)
                    .HasColumnName("isDocAllowedInForeign")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDocExpdtReq)
                    .HasColumnName("isDocExpdtReq")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDocIssueCntryReq)
                    .HasColumnName("isDocIssueCntryReq")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDocIssueDate)
                    .HasColumnName("isDocIssueDate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDocNumReq)
                    .HasColumnName("isDocNumReq")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsHealthQuestionsReq)
                    .HasColumnName("isHealthQuestionsReq")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsNonVisaWaiverAllowed)
                    .HasColumnName("isNonVisaWaiverAllowed")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsPassportReceiptReq)
                    .HasColumnName("isPassportReceiptReq")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsPlaceBirth)
                    .HasColumnName("isPlaceBirth")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsPregQuestionsReq)
                    .HasColumnName("isPregQuestionsReq")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsRetryRfidlift)
                    .HasColumnName("isRetryRFIDLift")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsVisaWaiver)
                    .HasColumnName("isVisaWaiver")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfflineTimeout)
                    .HasColumnName("offlineTimeout")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Question)
                    .HasColumnName("question")
                    .IsUnicode(false);

                entity.Property(e => e.QuestionNo)
                    .HasColumnName("questionNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionType)
                    .HasColumnName("questionType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecordType)
                    .HasColumnName("recordType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCode)
                    .HasColumnName("shipCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Voyno)
                    .HasColumnName("voyno")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Passengers>(entity =>
            {
                entity.ToTable("PASSENGERS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuthNo)
                    .HasColumnName("authNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Barcode)
                    .HasColumnName("barcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CabinCategory)
                    .HasColumnName("cabinCategory")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeCardExpiration)
                    .HasColumnName("chargeCardExpiration")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeCardMask)
                    .HasColumnName("chargeCardMask")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeCardName)
                    .HasColumnName("chargeCardName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeCardToken)
                    .HasColumnName("chargeCardToken")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeCardType)
                    .HasColumnName("chargeCardType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckInCheckOutDate)
                    .HasColumnName("checkInCheckOutDate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckInMessage)
                    .HasColumnName("checkInMessage")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckInStatus)
                    .HasColumnName("checkInStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckInWindow)
                    .HasColumnName("checkInWindow")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChkInDateTime)
                    .HasColumnName("chkInDateTime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryOfNationality)
                    .HasColumnName("countryOfNationality")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryOfResidence)
                    .HasColumnName("countryOfResidence")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CruiseReferenceNumber)
                    .HasColumnName("cruiseReferenceNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataTimeStamp)
                    .HasColumnName("dataTimeStamp")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("dateOfBirth")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartTime)
                    .HasColumnName("departTime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocType)
                    .HasColumnName("docType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmbarkationDate)
                    .HasColumnName("embarkationDate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlagStatus)
                    .HasColumnName("flagStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Folio)
                    .HasColumnName("folio")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GQuestionRes1)
                    .HasColumnName("gQuestionRes1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GQuestionRes2)
                    .HasColumnName("gQuestionRes2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GuestStatus)
                    .HasColumnName("guestStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsOlc)
                    .HasColumnName("isOLC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsResponsible)
                    .HasColumnName("isResponsible")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Loyalty)
                    .HasColumnName("loyalty")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MusterStation)
                    .HasColumnName("musterStation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OnsiteStatus)
                    .HasColumnName("onsiteStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PQuestionRes1)
                    .HasColumnName("pQuestionRes1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PQuestionRes2)
                    .HasColumnName("pQuestionRes2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassportComments)
                    .HasColumnName("passportComments")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassportExpirationDate)
                    .HasColumnName("passportExpirationDate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassportFirstName)
                    .HasColumnName("passportFirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassportIssuedBy)
                    .HasColumnName("passportIssuedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassportIssuedCity)
                    .HasColumnName("passportIssuedCity")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassportIssuedCountryCode)
                    .HasColumnName("passportIssuedCountryCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassportIssuedDate)
                    .HasColumnName("passportIssuedDate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassportLastName)
                    .HasColumnName("passportLastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassportNumber)
                    .HasColumnName("passportNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId)
                    .HasColumnName("personId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonImage)
                    .HasColumnName("personImage")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonType)
                    .HasColumnName("personType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PictureType)
                    .HasColumnName("pictureType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfBirth)
                    .HasColumnName("placeOfBirth")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessingStatus)
                    .HasColumnName("processingStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurposeOfVisit)
                    .HasColumnName("purposeOfVisit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivedFromDevice)
                    .HasColumnName("receivedFromDevice")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedBy)
                    .HasColumnName("requestedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestorName)
                    .HasColumnName("requestorName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoomNumber)
                    .HasColumnName("roomNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SailDate)
                    .HasColumnName("sailDate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SeqNo)
                    .HasColumnName("seqNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCode)
                    .HasColumnName("shipCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipId)
                    .HasColumnName("shipId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipName)
                    .HasColumnName("shipName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TokenExReferenceNumber)
                    .HasColumnName("tokenExReferenceNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zone)
                    .HasColumnName("zone")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Userslogin>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK_Usersloginreq");

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
