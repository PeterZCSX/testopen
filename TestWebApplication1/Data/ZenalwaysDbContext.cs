using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TestWebApplication1.Models;

namespace TestWebApplication1.Data;

public partial class ZenalwaysDbContext : DbContext
{
    public ZenalwaysDbContext()
    {
    }

    public ZenalwaysDbContext(DbContextOptions<ZenalwaysDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccessPrivilege> AccessPrivileges { get; set; }

    public virtual DbSet<ActionTakenDescription> ActionTakenDescriptions { get; set; }

    public virtual DbSet<Application> Applications { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<CompanyApplication> CompanyApplications { get; set; }

    public virtual DbSet<CompanyAudit> CompanyAudits { get; set; }

    public virtual DbSet<CompanyCustomField> CompanyCustomFields { get; set; }

    public virtual DbSet<CompanyProcessingMessage> CompanyProcessingMessages { get; set; }

    public virtual DbSet<Division> Divisions { get; set; }

    public virtual DbSet<DivisionLocationAssoc> DivisionLocationAssocs { get; set; }

    public virtual DbSet<IncidentReport> IncidentReports { get; set; }

    public virtual DbSet<IncidentReportActionTaken> IncidentReportActionTakens { get; set; }

    public virtual DbSet<IncidentReportActionTakenDescription> IncidentReportActionTakenDescriptions { get; set; }

    public virtual DbSet<IncidentReportAudit> IncidentReportAudits { get; set; }

    public virtual DbSet<IncidentReportCompanyCustomField> IncidentReportCompanyCustomFields { get; set; }

    public virtual DbSet<IncidentReportDialog> IncidentReportDialogs { get; set; }

    public virtual DbSet<IncidentReportDialogUserAccount> IncidentReportDialogUserAccounts { get; set; }

    public virtual DbSet<IncidentReportFile> IncidentReportFiles { get; set; }

    public virtual DbSet<IncidentReportFileUserAccount> IncidentReportFileUserAccounts { get; set; }

    public virtual DbSet<IncidentReportFollowUp> IncidentReportFollowUps { get; set; }

    public virtual DbSet<IncidentReportFollowUpUserAccount> IncidentReportFollowUpUserAccounts { get; set; }

    public virtual DbSet<IncidentReportRestrictedAccount> IncidentReportRestrictedAccounts { get; set; }

    public virtual DbSet<IncidentReportUserAccount> IncidentReportUserAccounts { get; set; }

    public virtual DbSet<IncidentType> IncidentTypes { get; set; }

    public virtual DbSet<IncidentTypeDefault> IncidentTypeDefaults { get; set; }

    public virtual DbSet<Industry> Industries { get; set; }

    public virtual DbSet<IndustryHierarchy> IndustryHierarchies { get; set; }

    public virtual DbSet<LinkedinIndustryList> LinkedinIndustryLists { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Priority> Priorities { get; set; }

    public virtual DbSet<Risk> Risks { get; set; }

    public virtual DbSet<Source> Sources { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<UserAccount> UserAccounts { get; set; }

    public virtual DbSet<UserAccountAccessLog> UserAccountAccessLogs { get; set; }

    public virtual DbSet<UserAccountAccessPrivilege> UserAccountAccessPrivileges { get; set; }

    public virtual DbSet<UserAccountAutoAssignRule> UserAccountAutoAssignRules { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<UserTimeZone> UserTimeZones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=PZenguana;initial catalog=ZENAlwaysDB;integrated security=true;multipleactiveresultsets=true;TrustServerCertificate=True;Trusted_Connection=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccessPrivilege>(entity =>
        {
            entity.ToTable("AccessPrivilege");

            entity.Property(e => e.AccessPrivilegeId).HasColumnName("AccessPrivilegeID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ActionTakenDescription>(entity =>
        {
            entity.ToTable("ActionTaken_Description");

            entity.Property(e => e.ActionTakenDescriptionId).HasColumnName("ActionTaken_DescriptionID");
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.PrepopulatedToCmsprovider).HasColumnName("PrepopulatedToCMSProvider");
        });

        modelBuilder.Entity<Application>(entity =>
        {
            entity.ToTable("Application");

            entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DisplayOrder).HasDefaultValue(10);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PaymentDeadline).HasColumnType("datetime");
            entity.Property(e => e.PriceByMonthByCompany).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PriceByMonthByUser).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PriceByYearByCompany).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PriceByYearByUser).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PriceDiscountRateByMonthByCompnay).HasColumnType("decimal(4, 2)");
            entity.Property(e => e.PriceDiscountRateByMonthByUser).HasColumnType("decimal(4, 2)");
            entity.Property(e => e.PriceDiscountRateByYearByCompnay).HasColumnType("decimal(4, 2)");
            entity.Property(e => e.PriceDiscountRateByYearByUser).HasColumnType("decimal(4, 2)");
            entity.Property(e => e.PriceDiscountRateEndDate).HasColumnType("datetime");
            entity.Property(e => e.PriceDiscountRateStartDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.ToTable("Company");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyAccessCode).HasMaxLength(10);
            entity.Property(e => e.CompanyAuthenLevel)
                .HasMaxLength(10)
                .HasDefaultValue("Legacy");
            entity.Property(e => e.CompanyMainContactEmail).HasMaxLength(1000);
            entity.Property(e => e.CompanyMainContactPersonDetail).HasMaxLength(1000);
            entity.Property(e => e.CompanyMainWebSite).HasMaxLength(250);
            entity.Property(e => e.CompanySizeId).HasColumnName("CompanySizeID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.EmailLinkCreatePasswordExpirationHours).HasDefaultValue(24);
            entity.Property(e => e.EmailLinkForgotPasswordExpirationHours).HasDefaultValue(24);
            entity.Property(e => e.EmailLinkPincodeExpirationHours)
                .HasDefaultValue(1)
                .HasColumnName("EmailLinkPINCodeExpirationHours");
            entity.Property(e => e.IndustryId).HasColumnName("IndustryID");
            entity.Property(e => e.IsCompanyLocked).HasDefaultValue(false);
            entity.Property(e => e.LogoImageLocation).HasMaxLength(1000);
            entity.Property(e => e.LogoImageName).HasMaxLength(250);
            entity.Property(e => e.MainAddress1).HasMaxLength(250);
            entity.Property(e => e.MainAddress2).HasMaxLength(100);
            entity.Property(e => e.MainAddressLatitude).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.MainAddressLongitude).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.MainCity).HasMaxLength(50);
            entity.Property(e => e.MainCountry).HasMaxLength(50);
            entity.Property(e => e.MainState).HasMaxLength(50);
            entity.Property(e => e.MainZipCode).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.Notes).HasMaxLength(1000);
            entity.Property(e => e.PasswordLength).HasDefaultValue(10);
            entity.Property(e => e.PasswordLowerCaseIncludeFlag).HasDefaultValue(true);
            entity.Property(e => e.PasswordNumbersIncludeFlag).HasDefaultValue(true);
            entity.Property(e => e.PasswordSymbolsIncludeFlag).HasDefaultValue(true);
            entity.Property(e => e.PasswordUpperCaseIncludeFlag).HasDefaultValue(true);
            entity.Property(e => e.PinauthenticationRequiredFlag).HasColumnName("PINAuthenticationRequiredFlag");
            entity.Property(e => e.RestrictAccessByIpflag)
                .HasDefaultValue(false)
                .HasColumnName("RestrictAccessByIPFlag");
            entity.Property(e => e.SessionTimeout).HasDefaultValue(30);
            entity.Property(e => e.SessionTimeoutWarning).HasDefaultValue(25);
            entity.Property(e => e.Subsidiary)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TwoFactorPinlength)
                .HasDefaultValue(6)
                .HasColumnName("TwoFactorPINLength");
            entity.Property(e => e.TwoFacttorPinlowerCaseIncludeFlag)
                .HasDefaultValue(true)
                .HasColumnName("TwoFacttorPINLowerCaseIncludeFlag");
            entity.Property(e => e.TwoFacttorPinnumbersIncludeFlag)
                .HasDefaultValue(true)
                .HasColumnName("TwoFacttorPINNumbersIncludeFlag");
            entity.Property(e => e.TwoFacttorPinsymbolsIncludeFlag).HasColumnName("TwoFacttorPINSymbolsIncludeFlag");
            entity.Property(e => e.TwoFacttorPinupperCaseIncludeFlag)
                .HasDefaultValue(true)
                .HasColumnName("TwoFacttorPINUpperCaseIncludeFlag");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.WebApiactiveFlag).HasColumnName("WebAPIActiveFlag");
            entity.Property(e => e.WebApikey)
                .HasMaxLength(50)
                .HasColumnName("WebAPIKey");
            entity.Property(e => e.WebApipassword)
                .HasMaxLength(50)
                .HasColumnName("WebAPIPassword");
            entity.Property(e => e.WebApirequestDatetime)
                .HasColumnType("datetime")
                .HasColumnName("WebAPIRequestDatetime");
            entity.Property(e => e.WebApirequestTimes).HasColumnName("WebAPIRequestTimes");
        });

        modelBuilder.Entity<CompanyApplication>(entity =>
        {
            entity.ToTable("Company_Application");

            entity.Property(e => e.CompanyApplicationId).HasColumnName("Company_ApplicationID");
            entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DisplayOrder).HasDefaultValue(10);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentDeadline).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Application).WithMany(p => p.CompanyApplications)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Company_Application_Application");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyApplications)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Company_Application_Company");
        });

        modelBuilder.Entity<CompanyAudit>(entity =>
        {
            entity.ToTable("Company_Audit");

            entity.Property(e => e.CompanyAuditId).HasColumnName("Company_AuditID");
            entity.Property(e => e.ChangedBy).HasMaxLength(100);
            entity.Property(e => e.ChangedByCompanyId).HasColumnName("ChangedByCompanyID");
            entity.Property(e => e.ChangedByUserAccountId).HasColumnName("ChangedByUserAccountID");
            entity.Property(e => e.ChangedByUserFromType).HasMaxLength(50);
            entity.Property(e => e.ChangedOn).HasColumnType("datetime");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.FieldName).HasMaxLength(350);
            entity.Property(e => e.NewValue).IsUnicode(false);
            entity.Property(e => e.OldValue).IsUnicode(false);

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyAudits)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_Company_Audit_Company");
        });

        modelBuilder.Entity<CompanyCustomField>(entity =>
        {
            entity.ToTable("Company_CustomField");

            entity.Property(e => e.CompanyCustomFieldId).HasColumnName("Company_CustomFieldID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.FieldLabelText).HasMaxLength(50);
            entity.Property(e => e.FieldRangeFrom)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FieldRangeTo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FieldToolTipText).HasMaxLength(250);
            entity.Property(e => e.FieldType).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyCustomFields)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_Company_CustomField_Company");
        });

        modelBuilder.Entity<CompanyProcessingMessage>(entity =>
        {
            entity.HasKey(e => e.CompanyProcessingMessageId).HasName("PK_CompanyProcessingMessage");

            entity.ToTable("Company_ProcessingMessage");

            entity.Property(e => e.CompanyProcessingMessageId).HasColumnName("Company_ProcessingMessageID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.ProcessingMessageType).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyProcessingMessages)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Company_ProcessingMessage_Company");
        });

        modelBuilder.Entity<Division>(entity =>
        {
            entity.ToTable("Division");

            entity.Property(e => e.DivisionId).HasColumnName("DivisionID");
            entity.Property(e => e.Address1).HasMaxLength(250);
            entity.Property(e => e.Address2).HasMaxLength(250);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DisplayOrder).HasDefaultValue(999);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValue(false);
            entity.Property(e => e.LockDivisionFromClient).HasDefaultValue(false);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.ProvinceRegion).HasMaxLength(50);
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Zip).HasMaxLength(10);

            entity.HasOne(d => d.Company).WithMany(p => p.Divisions)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_Division_Company");
        });

        modelBuilder.Entity<DivisionLocationAssoc>(entity =>
        {
            entity.ToTable("Division_Location_Assoc");

            entity.Property(e => e.DivisionLocationAssocId).HasColumnName("Division_Location_AssocID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DivisionId).HasColumnName("DivisionID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Company).WithMany(p => p.DivisionLocationAssocs)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_Division_Location_Assoc_Company");

            entity.HasOne(d => d.Division).WithMany(p => p.DivisionLocationAssocs)
                .HasForeignKey(d => d.DivisionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Division_Location_Assoc_Division");

            entity.HasOne(d => d.Location).WithMany(p => p.DivisionLocationAssocs)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Division_Location_Assoc_Location");
        });

        modelBuilder.Entity<IncidentReport>(entity =>
        {
            entity.ToTable("IncidentReport");

            entity.Property(e => e.IncidentReportId).HasColumnName("IncidentReportID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ComplainantContactDatetime).HasMaxLength(1000);
            entity.Property(e => e.ComplainantContactInfo).HasMaxLength(512);
            entity.Property(e => e.ComplainantContactedAttorney).HasMaxLength(1000);
            entity.Property(e => e.ComplainantContactedExternalAgency).HasMaxLength(1000);
            entity.Property(e => e.ComplainantCurrentSigninDate).HasColumnType("datetime");
            entity.Property(e => e.ComplainantEmailAddress).HasMaxLength(250);
            entity.Property(e => e.ComplainantExpectOutcome).HasMaxLength(1000);
            entity.Property(e => e.ComplainantFirstName).HasMaxLength(250);
            entity.Property(e => e.ComplainantLastName).HasMaxLength(250);
            entity.Property(e => e.ComplainantPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ComplainantPhone).HasMaxLength(20);
            entity.Property(e => e.ComplainantPincode)
                .HasMaxLength(50)
                .HasColumnName("ComplainantPINCode");
            entity.Property(e => e.ComplainantPincodeSalt)
                .HasMaxLength(50)
                .HasColumnName("ComplainantPINCodeSalt");
            entity.Property(e => e.ComplainantRelationshiptoCompany).HasMaxLength(100);
            entity.Property(e => e.ComplainantTimeZone).HasColumnType("datetime");
            entity.Property(e => e.ComplainantWantShareAllegedContactInfo).HasMaxLength(500);
            entity.Property(e => e.ComplainantWantShareVictimContactInfo).HasMaxLength(500);
            entity.Property(e => e.ComplainantWantShareWitnessContactInfo).HasMaxLength(500);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedNotes).HasMaxLength(500);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DivisionId).HasColumnName("DivisionID");
            entity.Property(e => e.GeneralNatureofIncidentReport).HasMaxLength(250);
            entity.Property(e => e.HowdoComplainantKnow).HasMaxLength(250);
            entity.Property(e => e.HowlongIncidentHappen).HasMaxLength(250);
            entity.Property(e => e.IncidentOccurDatetime).HasColumnType("datetime");
            entity.Property(e => e.IncidentOccurExactLoction).HasMaxLength(500);
            entity.Property(e => e.IncidentReportApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.IncidentReportApprovedby).HasMaxLength(100);
            entity.Property(e => e.IncidentReportAssignCode).HasMaxLength(20);
            entity.Property(e => e.IncidentReportCountry).HasMaxLength(100);
            entity.Property(e => e.IncidentReportLanguage).HasMaxLength(50);
            entity.Property(e => e.IncidentReportSubject).HasMaxLength(250);
            entity.Property(e => e.IncidentReportSubmitDate).HasColumnType("datetime");
            entity.Property(e => e.IncidentReportTobeResolutionDate).HasColumnType("datetime");
            entity.Property(e => e.IncidentTypeId).HasColumnName("IncidentTypeID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsLocked).HasDefaultValue(false);
            entity.Property(e => e.IsRestricted).HasDefaultValue(false);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.LockedBy).HasMaxLength(100);
            entity.Property(e => e.LockedByCompanyId).HasColumnName("LockedByCompanyID");
            entity.Property(e => e.LockedOn).HasColumnType("datetime");
            entity.Property(e => e.OriginalSubmittedBy).HasMaxLength(20);
            entity.Property(e => e.OtherCategory).HasMaxLength(250);
            entity.Property(e => e.OtherDivision).HasMaxLength(250);
            entity.Property(e => e.OtherIncidentType).HasMaxLength(250);
            entity.Property(e => e.OtherLocation).HasMaxLength(250);
            entity.Property(e => e.PriorityId).HasColumnName("PriorityID");
            entity.Property(e => e.RiskId).HasColumnName("RiskID");
            entity.Property(e => e.SourceId).HasColumnName("SourceID");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.SupervisorManagementNameList)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.WhoAttemptedToConcealNameList).HasMaxLength(500);

            entity.HasOne(d => d.Category).WithMany(p => p.IncidentReports)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_IncidentReport_Category");

            entity.HasOne(d => d.Company).WithMany(p => p.IncidentReports)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncidentReport_Company");

            entity.HasOne(d => d.Division).WithMany(p => p.IncidentReports)
                .HasForeignKey(d => d.DivisionId)
                .HasConstraintName("FK_IncidentReport_Division");

            entity.HasOne(d => d.Location).WithMany(p => p.IncidentReports)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_IncidentReport_Location");

            entity.HasOne(d => d.Priority).WithMany(p => p.IncidentReports)
                .HasForeignKey(d => d.PriorityId)
                .HasConstraintName("FK_IncidentReport_Priority");

            entity.HasOne(d => d.Risk).WithMany(p => p.IncidentReports)
                .HasForeignKey(d => d.RiskId)
                .HasConstraintName("FK_IncidentReport_Risk");

            entity.HasOne(d => d.Source).WithMany(p => p.IncidentReports)
                .HasForeignKey(d => d.SourceId)
                .HasConstraintName("FK_IncidentReport_Source");

            entity.HasOne(d => d.Status).WithMany(p => p.IncidentReports)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_IncidentReport_Status");
        });

        modelBuilder.Entity<IncidentReportActionTaken>(entity =>
        {
            entity.ToTable("IncidentReport_ActionTaken");

            entity.Property(e => e.IncidentReportActionTakenId).HasColumnName("IncidentReport_ActionTakenID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedByUserFromType).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedByUserFromType).HasMaxLength(50);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.IncidentReportDialogId).HasColumnName("IncidentReport_DialogID");
            entity.Property(e => e.IncidentReportId).HasColumnName("IncidentReportID");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedByUserFromType).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.ViewableByCmsproviderFlag)
                .HasDefaultValue(false)
                .HasColumnName("ViewableByCMSProviderFlag");
            entity.Property(e => e.ViewableByCompanyFlag).HasDefaultValue(false);
            entity.Property(e => e.ViewableByComplainantFlag).HasDefaultValue(false);

            entity.HasOne(d => d.IncidentReport).WithMany(p => p.IncidentReportActionTakens)
                .HasForeignKey(d => d.IncidentReportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncidentReport_ActionTaken_IncidentReport");
        });

        modelBuilder.Entity<IncidentReportActionTakenDescription>(entity =>
        {
            entity.HasKey(e => e.ActionTakenDescriptionId);

            entity.ToTable("IncidentReport_ActionTaken_Description");

            entity.Property(e => e.ActionTakenDescriptionId).HasColumnName("ActionTaken_DescriptionID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.DisplayOrder).HasDefaultValue(99999);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.PrepopulatedToCmsprovider).HasColumnName("PrepopulatedToCMSProvider");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<IncidentReportAudit>(entity =>
        {
            entity.ToTable("IncidentReport_Audit");

            entity.Property(e => e.IncidentReportAuditId).HasColumnName("IncidentReport_AuditID");
            entity.Property(e => e.ChangedBy).HasMaxLength(100);
            entity.Property(e => e.ChangedByCompanyId).HasColumnName("ChangedByCompanyID");
            entity.Property(e => e.ChangedByUserFromType).HasMaxLength(50);
            entity.Property(e => e.ChangedOn).HasColumnType("datetime");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.FieldName).HasMaxLength(350);
            entity.Property(e => e.IncidentReportId).HasColumnName("IncidentReportID");
            entity.Property(e => e.NewValue).IsUnicode(false);
            entity.Property(e => e.OldValue).IsUnicode(false);

            entity.HasOne(d => d.IncidentReport).WithMany(p => p.IncidentReportAudits)
                .HasForeignKey(d => d.IncidentReportId)
                .HasConstraintName("FK_IncidentReport_Audit_IncidentReport");
        });

        modelBuilder.Entity<IncidentReportCompanyCustomField>(entity =>
        {
            entity.HasKey(e => e.IncidentReportCustomFieldId);

            entity.ToTable("IncidentReport_Company_CustomField");

            entity.Property(e => e.IncidentReportCustomFieldId).HasColumnName("IncidentReport_CustomFieldID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CustomFieldData).IsUnicode(false);
            entity.Property(e => e.CustomFieldId).HasColumnName("CustomFieldID");
            entity.Property(e => e.IncidentReportId).HasColumnName("IncidentReportID");

            entity.HasOne(d => d.Company).WithMany(p => p.IncidentReportCompanyCustomFields)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_IncidentReport_Company_CustomField_Company");

            entity.HasOne(d => d.IncidentReport).WithMany(p => p.IncidentReportCompanyCustomFields)
                .HasForeignKey(d => d.IncidentReportId)
                .HasConstraintName("FK_IncidentReport_Company_CustomField_IncidentReport");
        });

        modelBuilder.Entity<IncidentReportDialog>(entity =>
        {
            entity.ToTable("IncidentReport_Dialog");

            entity.Property(e => e.IncidentReportDialogId).HasColumnName("IncidentReport_DialogID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedByUserFromType).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedByUserFromType).HasMaxLength(50);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.FileName).HasMaxLength(250);
            entity.Property(e => e.IncidentReportId).HasColumnName("IncidentReportID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedByUserFromType).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.ViewableByCmsproviderFlag)
                .HasDefaultValue(false)
                .HasColumnName("ViewableByCMSProviderFlag");
            entity.Property(e => e.ViewableByCompanyFlag).HasDefaultValue(false);
            entity.Property(e => e.ViewableByComplainantFlag).HasDefaultValue(false);

            entity.HasOne(d => d.IncidentReport).WithMany(p => p.IncidentReportDialogs)
                .HasForeignKey(d => d.IncidentReportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncidentReport_Dialog_IncidentReport");
        });

        modelBuilder.Entity<IncidentReportDialogUserAccount>(entity =>
        {
            entity.ToTable("IncidentReport_Dialog_UserAccount");

            entity.Property(e => e.IncidentReportDialogUserAccountId).HasColumnName("IncidentReport_Dialog_UserAccountID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.IncidentReportDialogId).HasColumnName("IncidentReport_DialogID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserAccountId).HasColumnName("UserAccountID");

            entity.HasOne(d => d.IncidentReportDialog).WithMany(p => p.IncidentReportDialogUserAccounts)
                .HasForeignKey(d => d.IncidentReportDialogId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncidentReport_Dialog_UserAccount_IncidentReport_Dialog");

            entity.HasOne(d => d.UserAccount).WithMany(p => p.IncidentReportDialogUserAccounts)
                .HasForeignKey(d => d.UserAccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncidentReport_Dialog_UserAccount_UserAccount");
        });

        modelBuilder.Entity<IncidentReportFile>(entity =>
        {
            entity.ToTable("IncidentReport_File");

            entity.Property(e => e.IncidentReportFileId).HasColumnName("IncidentReport_FileID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedByUserFromType).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedByUserFromType).HasMaxLength(50);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.FileDynamicRandomName).HasMaxLength(250);
            entity.Property(e => e.FileName).HasMaxLength(250);
            entity.Property(e => e.IncidentReportId).HasColumnName("IncidentReportID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedByUserFromType).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.ViewableByCmsproviderFlag)
                .HasDefaultValue(false)
                .HasColumnName("ViewableByCMSProviderFlag");
            entity.Property(e => e.ViewableByCompanyFlag).HasDefaultValue(false);
            entity.Property(e => e.ViewableByComplainantFlag).HasDefaultValue(false);

            entity.HasOne(d => d.Company).WithMany(p => p.IncidentReportFiles)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_IncidentReport_File_Company");

            entity.HasOne(d => d.IncidentReport).WithMany(p => p.IncidentReportFiles)
                .HasForeignKey(d => d.IncidentReportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncidentReport_File_IncidentReport");
        });

        modelBuilder.Entity<IncidentReportFileUserAccount>(entity =>
        {
            entity.ToTable("IncidentReport_File_UserAccount");

            entity.Property(e => e.IncidentReportFileUserAccountId).HasColumnName("IncidentReport_File_UserAccountID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.IncidentReportFileId).HasColumnName("IncidentReport_FileID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserAccountId).HasColumnName("UserAccountID");

            entity.HasOne(d => d.IncidentReportFile).WithMany(p => p.IncidentReportFileUserAccounts)
                .HasForeignKey(d => d.IncidentReportFileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncidentReport_File_UserAccount_IncidentReport_File");

            entity.HasOne(d => d.UserAccount).WithMany(p => p.IncidentReportFileUserAccounts)
                .HasForeignKey(d => d.UserAccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncidentReport_File_UserAccount_UserAccount");
        });

        modelBuilder.Entity<IncidentReportFollowUp>(entity =>
        {
            entity.ToTable("IncidentReport_FollowUp");

            entity.Property(e => e.IncidentReportFollowUpId).HasColumnName("IncidentReport_FollowUpID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedByUserFromType).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedByUserFromType).HasMaxLength(50);
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.FileName).HasMaxLength(250);
            entity.Property(e => e.IncidentReportDialogId).HasColumnName("IncidentReport_DialogID");
            entity.Property(e => e.IncidentReportId).HasColumnName("IncidentReportID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedByUserFromType).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.ViewableByCmsproviderFlag)
                .HasDefaultValue(false)
                .HasColumnName("ViewableByCMSProviderFlag");
            entity.Property(e => e.ViewableByCompanyFlag).HasDefaultValue(false);
            entity.Property(e => e.ViewableByComplainantFlag).HasDefaultValue(false);

            entity.HasOne(d => d.Company).WithMany(p => p.IncidentReportFollowUps)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncidentReport_FollowUp_Company");

            entity.HasOne(d => d.IncidentReport).WithMany(p => p.IncidentReportFollowUps)
                .HasForeignKey(d => d.IncidentReportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncidentReport_FollowUp_IncidentReport");
        });

        modelBuilder.Entity<IncidentReportFollowUpUserAccount>(entity =>
        {
            entity.ToTable("IncidentReport_FollowUp_UserAccount");

            entity.Property(e => e.IncidentReportFollowUpUserAccountId).HasColumnName("IncidentReport_FollowUp_UserAccountID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.IncidentReportFollowUpId).HasColumnName("IncidentReport_FollowUpID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserAccountId).HasColumnName("UserAccountID");

            entity.HasOne(d => d.IncidentReportFollowUp).WithMany(p => p.IncidentReportFollowUpUserAccounts)
                .HasForeignKey(d => d.IncidentReportFollowUpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncidentReport_FollowUp_UserAccount_IncidentReport_FollowUp");

            entity.HasOne(d => d.UserAccount).WithMany(p => p.IncidentReportFollowUpUserAccounts)
                .HasForeignKey(d => d.UserAccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncidentReport_FollowUp_UserAccount_UserAccount");
        });

        modelBuilder.Entity<IncidentReportRestrictedAccount>(entity =>
        {
            entity.ToTable("IncidentReport_RestrictedAccount");

            entity.Property(e => e.IncidentReportRestrictedAccountId).HasColumnName("IncidentReport_RestrictedAccountID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.IncidentReportId).HasColumnName("IncidentReportID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserAccountId).HasColumnName("UserAccountID");

            entity.HasOne(d => d.IncidentReport).WithMany(p => p.IncidentReportRestrictedAccounts)
                .HasForeignKey(d => d.IncidentReportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncidentReport_RestrictedAccount_IncidentReport");

            entity.HasOne(d => d.UserAccount).WithMany(p => p.IncidentReportRestrictedAccounts)
                .HasForeignKey(d => d.UserAccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncidentReport_RestrictedAccount_UserAccount");
        });

        modelBuilder.Entity<IncidentReportUserAccount>(entity =>
        {
            entity.ToTable("IncidentReport_UserAccount");

            entity.Property(e => e.IncidentReportUserAccountId).HasColumnName("IncidentReport_UserAccountID");
            entity.Property(e => e.AutoAssign).HasDefaultValue(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.IncidentReportId).HasColumnName("IncidentReportID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserAccountId).HasColumnName("UserAccountID");

            entity.HasOne(d => d.IncidentReport).WithMany(p => p.IncidentReportUserAccounts)
                .HasForeignKey(d => d.IncidentReportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncidentReport_UserAccount_IncidentReport");

            entity.HasOne(d => d.UserAccount).WithMany(p => p.IncidentReportUserAccounts)
                .HasForeignKey(d => d.UserAccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncidentReport_UserAccount_UserAccount");
        });

        modelBuilder.Entity<IncidentType>(entity =>
        {
            entity.ToTable("IncidentType");

            entity.Property(e => e.IncidentTypeId).HasColumnName("IncidentTypeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(250)
                .HasComputedColumnSql("([Name])", false);
            entity.Property(e => e.DisplayOrder).HasDefaultValue(99999);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Company).WithMany(p => p.IncidentTypes)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncidentType_Company");
        });

        modelBuilder.Entity<IncidentTypeDefault>(entity =>
        {
            entity.Property(e => e.IncidentTypeDefaultId).HasColumnName("IncidentTypeDefaultID");
            entity.Property(e => e.IncidentTypeName).HasMaxLength(250);
            entity.Property(e => e.LockIncidentTypeFromClient).HasDefaultValue(true);
        });

        modelBuilder.Entity<Industry>(entity =>
        {
            entity.ToTable("Industry");

            entity.Property(e => e.IndustryId).HasColumnName("IndustryID");
            entity.Property(e => e.DisplayOrder).HasDefaultValue(99999);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IndustryHierarchy>(entity =>
        {
            entity.ToTable("Industry_Hierarchy");

            entity.Property(e => e.IndustryHierarchyId).HasColumnName("Industry_HierarchyID");
            entity.Property(e => e.DisplayOrder).HasDefaultValue(99999);
            entity.Property(e => e.IndustryId).HasColumnName("IndustryID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.Industry).WithMany(p => p.IndustryHierarchies)
                .HasForeignKey(d => d.IndustryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Industry_Hierarchy_Industry");
        });

        modelBuilder.Entity<LinkedinIndustryList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Linkedin_Industry_List");

            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Hierarchy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("hierarchy");
            entity.Property(e => e.Label)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.ToTable("Location");

            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Address1).HasMaxLength(250);
            entity.Property(e => e.Address2).HasMaxLength(250);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DisplayOrder).HasDefaultValue(99999);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LockLocationFromClient).HasDefaultValue(false);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.ProvinceRegion).HasMaxLength(50);
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Zip).HasMaxLength(10);

            entity.HasOne(d => d.Company).WithMany(p => p.Locations)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Location_Company");
        });

        modelBuilder.Entity<Priority>(entity =>
        {
            entity.ToTable("Priority");

            entity.Property(e => e.PriorityId).HasColumnName("PriorityID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DisplayOrder).HasDefaultValue(10);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Risk>(entity =>
        {
            entity.ToTable("Risk");

            entity.Property(e => e.RiskId).HasColumnName("RiskID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DisplayOrder).HasDefaultValue(10);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Source>(entity =>
        {
            entity.ToTable("Source");

            entity.Property(e => e.SourceId).HasColumnName("SourceID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(250)
                .HasComputedColumnSql("([Name])", false);
            entity.Property(e => e.DisplayOrder).HasDefaultValue(10);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.ToTable("Status");

            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DisplayOrder).HasDefaultValue(10);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity.ToTable("UserAccount");

            entity.Property(e => e.UserAccountId).HasColumnName("UserAccountID");
            entity.Property(e => e.ActiveCode).HasMaxLength(50);
            entity.Property(e => e.ActiveCodeExpireDatetime).HasColumnType("datetime");
            entity.Property(e => e.Address1).HasMaxLength(250);
            entity.Property(e => e.Address2).HasMaxLength(250);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CompanyCmsuserFlag)
                .HasDefaultValue(false)
                .HasColumnName("CompanyCMSUserFlag");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.FailPasswordAttemptStartTime).HasColumnType("datetime");
            entity.Property(e => e.Fax).HasMaxLength(20);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.IsAllowAutoAssign).HasDefaultValue(false);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Nickname).HasMaxLength(50);
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PhoneAlt).HasMaxLength(20);
            entity.Property(e => e.PinAccessNumber).HasMaxLength(50);
            entity.Property(e => e.PinAccessNumberActiveTime).HasColumnType("datetime");
            entity.Property(e => e.ProvinceRegion).HasMaxLength(50);
            entity.Property(e => e.ReceiveNotifications).HasDefaultValue(true);
            entity.Property(e => e.RefreshTokenExpiryTime).HasColumnType("datetime");
            entity.Property(e => e.RestrictAccessByIpflag).HasColumnName("RestrictAccessByIPFlag");
            entity.Property(e => e.SecretAnswer).HasMaxLength(50);
            entity.Property(e => e.SecretQuestion).HasMaxLength(100);
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserCurrentSigninDate).HasColumnType("datetime");
            entity.Property(e => e.UserEmail).HasMaxLength(100);
            entity.Property(e => e.UserLocked).HasDefaultValue(false);
            entity.Property(e => e.UserPassword).HasMaxLength(50);
            entity.Property(e => e.UserPasswordLastUpdateOn).HasColumnType("datetime");
            entity.Property(e => e.UserPasswordSalt).HasMaxLength(50);
            entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");
            entity.Property(e => e.Zip).HasMaxLength(10);

            entity.HasOne(d => d.Company).WithMany(p => p.UserAccounts)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserAccount_Company");

            entity.HasOne(d => d.UserRole).WithMany(p => p.UserAccounts)
                .HasForeignKey(d => d.UserRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserAccount_UserRole");
        });

        modelBuilder.Entity<UserAccountAccessLog>(entity =>
        {
            entity.ToTable("UserAccount_AccessLog");

            entity.Property(e => e.UserAccountAccessLogId).HasColumnName("UserAccount_AccessLogID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.IpaddressFrom)
                .HasMaxLength(20)
                .HasColumnName("IPAddressFrom");
            entity.Property(e => e.SignOnDate).HasColumnType("datetime");
            entity.Property(e => e.UserAccountId).HasColumnName("UserAccountID");

            entity.HasOne(d => d.Company).WithMany(p => p.UserAccountAccessLogs)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserAccount_AccessLog_Company");

            entity.HasOne(d => d.UserAccount).WithMany(p => p.UserAccountAccessLogs)
                .HasForeignKey(d => d.UserAccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserAccount_AccessLog_UserAccount");
        });

        modelBuilder.Entity<UserAccountAccessPrivilege>(entity =>
        {
            entity.ToTable("UserAccount_AccessPrivilege");

            entity.Property(e => e.UserAccountAccessPrivilegeId).HasColumnName("UserAccount_AccessPrivilegeID");
            entity.Property(e => e.AccessPrivilegeId).HasColumnName("AccessPrivilegeID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserAccountId).HasColumnName("UserAccountID");

            entity.HasOne(d => d.AccessPrivilege).WithMany(p => p.UserAccountAccessPrivileges)
                .HasForeignKey(d => d.AccessPrivilegeId)
                .HasConstraintName("FK_UserAccount_AccessPrivilege_AccessPrivilege");

            entity.HasOne(d => d.UserAccount).WithMany(p => p.UserAccountAccessPrivileges)
                .HasForeignKey(d => d.UserAccountId)
                .HasConstraintName("FK_UserAccount_AccessPrivilege_UserAccount");
        });

        modelBuilder.Entity<UserAccountAutoAssignRule>(entity =>
        {
            entity.ToTable("UserAccount_AutoAssignRule");

            entity.Property(e => e.UserAccountAutoAssignRuleId).HasColumnName("UserAccount_AutoAssignRuleID");
            entity.Property(e => e.AllDivisionIncludedFlag).HasDefaultValue(false);
            entity.Property(e => e.AllIncidentTypeIncludedFalg).HasDefaultValue(false);
            entity.Property(e => e.AllLocationIncludedFlag).HasDefaultValue(false);
            entity.Property(e => e.AllPriorityIncludedFlag).HasDefaultValue(false);
            entity.Property(e => e.AllRiskIncludedFlag).HasDefaultValue(false);
            entity.Property(e => e.AllSourceIncludedFlag).HasDefaultValue(false);
            entity.Property(e => e.AllSubmittedByIncludedFlag).HasDefaultValue(false);
            entity.Property(e => e.AutoAssignToAllPreviousReportsFlag).HasDefaultValue(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DivisionIdassignedList).HasColumnName("DivisionIDAssignedList");
            entity.Property(e => e.IncidentTypeIdassignedList).HasColumnName("IncidentTypeIDAssignedList");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LocationIdassignedList).HasColumnName("LocationIDAssignedList");
            entity.Property(e => e.NewDivisionIncludedFlag).HasDefaultValue(false);
            entity.Property(e => e.NewIncidentTypeIncludedFalg).HasDefaultValue(false);
            entity.Property(e => e.NewLocationIncludedFlag).HasDefaultValue(false);
            entity.Property(e => e.PriorityIdassignedList)
                .HasMaxLength(500)
                .HasColumnName("PriorityIDAssignedList");
            entity.Property(e => e.RiskIdassignedList)
                .HasMaxLength(500)
                .HasColumnName("RiskIDAssignedList");
            entity.Property(e => e.SourceIdassignedList)
                .HasMaxLength(500)
                .HasColumnName("SourceIDAssignedList");
            entity.Property(e => e.SubmittedByAssignedList).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserAccountId).HasColumnName("UserAccountID");

            entity.HasOne(d => d.Company).WithMany(p => p.UserAccountAutoAssignRules)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserAccount_AutoAssignRule_Company");

            entity.HasOne(d => d.UserAccount).WithMany(p => p.UserAccountAutoAssignRules)
                .HasForeignKey(d => d.UserAccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserAccount_AutoAssignRule_UserAccount");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.ToTable("UserRole");

            entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedByCompanyId).HasColumnName("CreatedByCompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(100);
            entity.Property(e => e.DeletedByCompanyId).HasColumnName("DeletedByCompanyID");
            entity.Property(e => e.DeletedOn).HasColumnType("datetime");
            entity.Property(e => e.DisplayOrder).HasDefaultValue(9999);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedByCompanyId).HasColumnName("UpdatedByCompanyID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserTimeZone>(entity =>
        {
            entity.HasKey(e => e.TimeZoneId);

            entity.ToTable("UserTimeZone");

            entity.Property(e => e.TimeZoneId).HasColumnName("TimeZoneID");
            entity.Property(e => e.TimeZoneName).HasMaxLength(100);
            entity.Property(e => e.TimeZoneUtcOffset).HasColumnName("TimeZone_Utc_Offset");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
