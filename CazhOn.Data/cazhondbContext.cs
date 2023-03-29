using CazhOn.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CazhOn.Data
{
    public partial class cazhondbContext : DbContext
    {
        IConfiguration Configuration;
        public cazhondbContext()
        {
        }

        public cazhondbContext(DbContextOptions<cazhondbContext> options, IConfiguration configuration)
           : base(options)
        {
            Configuration = configuration;
        }

        public virtual DbSet<Tblmissingcashback> Tblmissingcashback { get; set; }
        public virtual DbSet<Affiliatellink> Affiliatellinks { get; set; }
        public virtual DbSet<BrandEntity> BrandEntities { get; set; }
        public virtual DbSet<CampaignTermsEntity> CampaignTermsEntities { get; set; }
        public virtual DbSet<CategoryEntity> CategoryEntities { get; set; }
        public virtual DbSet<DealEntity> DealEntities { get; set; }
        public virtual DbSet<HibernateSequence> HibernateSequences { get; set; }
        public virtual DbSet<StgTblstorecampaign> StgTblstorecampaigns { get; set; }
        public virtual DbSet<StgTblstoreoffer> StgTblstoreoffers { get; set; }
        public virtual DbSet<RawTblGlobalPostBack> RawTblGlobalPostBacks  { get; set; }
        public virtual DbSet<StoreDetailsEntity> StoreDetailsEntities { get; set; }
        public virtual DbSet<Tbladmin> Tbladmins { get; set; }
        
        public virtual DbSet<Tblaudittrail> Tblaudittrails { get; set; }
    
        public virtual DbSet<Tblbanner> Tblbanners { get; set; }
        public virtual DbSet<TblBonusrewards> TblBonusrewards { get; set; }
        public virtual DbSet<Tblcampaigncondition> Tblcampaignconditions { get; set; }
        public virtual DbSet<Tblcampaignterm> Tblcampaignterms { get; set; }
        public virtual DbSet<Tblcategoryorder> Tblcategoryorders { get; set; }
        public virtual DbSet<Tblcouponfeed> Tblinrdealscoupons { get; set; }
        public virtual DbSet<Tblglobalpostback> Tblglobalpostbacks { get; set; }
        public virtual DbSet<Tblapirequestresponselogs> Tblapirequestresponselogs { get; set; }
        public virtual DbSet<Tbllkupgroupcode> Tbllkupgroupcodes { get; set; }
        public virtual DbSet<Tbllkuplist> Tbllkuplists { get; set; }
        public virtual DbSet<Tblofferhistory> Tblofferhistories { get; set; }
        public virtual DbSet<Tblofferlatest> Tblofferlatests { get; set; }
        public virtual DbSet<TblRechargeTransaction> TblRechargeTransactions { get; set; }
        public virtual DbSet<Tblrole> Tblroles { get; set; }
        public virtual DbSet<Tblrolemapping> Tblrolemappings { get; set; }
        public virtual DbSet<Tblshoppingtrip> Tblshoppingtrips { get; set; }
        public virtual DbSet<Tblshoppingtriphistory> Tblshoppingtriphistories { get; set; }
        public virtual DbSet<Tblstore> Tblstores { get; set; }
        public virtual DbSet<Tblstore1> Tblstores1 { get; set; }       

        public virtual DbSet<Tblstorecampaign> Tblstorecampaigns { get; set; }
        public virtual DbSet<Tblstorecity> Tblstorecities { get; set; }
        public virtual DbSet<Tblstoreoffer> Tblstoreoffers { get; set; }
        public virtual DbSet<Tblstoretype> Tblstoretypes { get; set; }
        public virtual DbSet<TblStoreProduct> TblStoreProducts { get; set; }
        public virtual DbSet<Tblproductype> TblProductTypes { get; set; }
        public virtual DbSet<Tbluser> Tblusers { get; set; }
        public virtual DbSet<Tbluser1> Tblusers1 { get; set; }
        public virtual DbSet<TbluserBkp> TbluserBkps { get; set; }
        public virtual DbSet<Tbluseraddress> Tbluseraddresses { get; set; }
        public virtual DbSet<Tbluserbank> TblIUserbank { get; set; }
        public virtual DbSet<Tbluserfavoritestore> Tbluserfavoritestores { get; set; }
        public virtual DbSet<Tbluserloginhistory> Tbluserloginhistories { get; set; }
        public virtual DbSet<Tbluserlogintype> Tbluserlogintypes { get; set; }
        public virtual DbSet<Tbluserpayment> Tbluserpayments { get; set; }
        public virtual DbSet<Tbluserpaymenthistory> Tbluserpaymenthistories { get; set; }
        public virtual DbSet<Tbluserpwdreset> Tbluserpwdresets { get; set; }
        public virtual DbSet<Tbluserpwdreset1> Tbluserpwdresets1 { get; set; }
        public virtual DbSet<Tblusersignupconfirm> Tblusersignupconfirms { get; set; }
        public virtual DbSet<TblUserTransaction> Tbluserstransaction { get; set; }
        public virtual DbSet<Tblvendor> Tblvendors { get; set; }
        public virtual DbSet<TempstgTblstoreoffer> TempstgTblstoreoffers { get; set; }
        public virtual DbSet<VwAllbrandscashbackdeal> VwAllbrandscashbackdeals { get; set; }
        public virtual DbSet<VwAllpopulardeal> VwAllpopulardeals { get; set; }
        public virtual DbSet<VwLkupcommcalctype> VwLkupcommcalctypes { get; set; }
        public virtual DbSet<VwRecordstatustype> VwRecordstatustypes { get; set; }
        public virtual DbSet<VwStoreCategoryOfferInfo> VwStoreCategoryOfferInfos { get; set; }
        public virtual DbSet<VwStoreCategoryOfferInfoBkp11042021> VwStoreCategoryOfferInfoBkp11042021s { get; set; }
        public virtual DbSet<VwStorecampaignmaxpayout> VwStorecampaignmaxpayouts { get; set; }
        public virtual DbSet<VwTodayspopulardeal> VwTodayspopulardeals { get; set; }
        public virtual DbSet<VwTopbrandscashbackdeal> VwTopbrandscashbackdeals { get; set; }
        public virtual DbSet<VwTopcategory> VwTopcategories { get; set; }
        public virtual DbSet<Tblemailnotificationbatch> Tblemailnotificationbatches { get; set; }

        public virtual DbSet<Tblnotificationlist> Tblnotificationlists { get; set; }


        public virtual DbSet<Tbloperator> Tbloperators { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code.
                //You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance
                //on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //  optionsBuilder.UseSqlServer("Data Source=208.91.198.59;Initial Catalog=devcazhondb;Trusted_Connection=False;User ID=devcazhonuser;Password=Cazhon@123;");
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("Default"));
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("devcazhonuser")
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Affiliatellink>(entity =>
            {
                entity.ToTable("affiliatellink", "dbo");

                entity.Property(e => e.Affiliatellinkid).HasColumnName("affiliatellinkid");

                entity.Property(e => e.Amount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("amount");

                entity.Property(e => e.Commission)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("commission");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate");

                entity.Property(e => e.Subid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("subid");

                entity.Property(e => e.Tid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tid");

                entity.Property(e => e.Updateddate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddate");

                entity.Property(e => e.Vendor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vendor");
            });

            modelBuilder.Entity<BrandEntity>(entity =>
            {
                entity.HasKey(e => e.StoreMdid)
                    .HasName("PK__brand_en__D213BB584C11C5B7");

                entity.ToTable("brand_entity");

                entity.Property(e => e.StoreMdid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");

                entity.Property(e => e.CashBackDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cash_back_desc");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("image_name");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("image_url");

                entity.Property(e => e.StoreMdname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("store_mdname");

                entity.Property(e => e.StoreName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("store_name");

                entity.Property(e => e.StorecampaignGuid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("storecampaign_guid");

                entity.Property(e => e.TotalCoupons)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("total_coupons");

                entity.Property(e => e.TotalOffers)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("total_offers");
            });
            modelBuilder.Entity<TblBonusrewards>(entity =>
            {
                entity.HasKey(e => e.BonusRewardsGuid)
                    .HasName("[pk_tblbonusrewards_bonusrewards_guid]");

                entity.ToTable("tblbonusrewards", "dbo");

                entity.Property(e => e.BonusRewardsGuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bonusrewards_guid");

                entity.Property(e => e.BonusRewardDesc)
                  .HasMaxLength(500)
                  .IsUnicode(false)
                  .HasColumnName("bonusrewards_desc");
                entity.Property(e => e.BonusRewardsName)
                 .HasMaxLength(500)
                 .IsUnicode(false)
                 .HasColumnName("bonusrewards_name");
                entity.Property(e => e.RewardTypeGuid)
                 .HasMaxLength(500)
                 .IsUnicode(false)
                 .HasColumnName("rewardtype_lkupmdid");

                entity.Property(e => e.CreatedBy)
                 .HasMaxLength(500)
                 .IsUnicode(false)
                 .HasColumnName("created_by");

                entity.Property(e => e.UpdatedBy)
                 .HasMaxLength(500)
                 .IsUnicode(false)
                 .HasColumnName("updated_by");
                entity.Property(e => e.BonusAmt)
             .HasColumnType("decimal")
             .HasColumnName("bonus_amt");

                entity.Property(e => e.IsActive)
                .HasColumnType("bit")
                .HasColumnName("active_flag");

                entity.Property(e => e.RedeemableType)
                .HasMaxLength(500)
                 .IsUnicode(false)
                .HasColumnName("redeemtype_lkupmdid");


                entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");

                entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");

                entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createddatetime");

                entity.Property(e => e.CreatedDateUTC)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.UpdatedDate)
              .HasColumnType("datetime")
              .HasColumnName("updateddatetime");

                entity.Property(e => e.UpdatedDateUTC)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");


            });
            modelBuilder.Entity<CampaignTermsEntity>(entity =>
            {
                entity.HasKey(e => e.StoreMdid)
                    .HasName("PK__campaign__D213BB58ACA3B76A");

                entity.ToTable("campaign_terms_entity");

                entity.Property(e => e.StoreMdid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");

                entity.Property(e => e.CampaignTerms)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("campaign_terms");

                entity.Property(e => e.StoreMdname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("store_mdname");

                entity.Property(e => e.StorecampaignGuid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("storecampaign_guid");
            });
            modelBuilder.Entity<Tblrolemapping>(entity =>
            {
                entity.HasKey(e => e.RoleMappingID)
                    .HasName("PK__tblrolem__rolemappingId");

                entity.ToTable("tblrolemapping", "dbo");

                entity.Property(e => e.admin_guid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("admin_guid");
                entity.Property(e => e.RoleName)
                  .HasMaxLength(20)
                  .IsUnicode(false)
                  .HasColumnName("RoleName");

                entity.Property(e => e.RoleID).HasColumnName("RoleID");


            });
            modelBuilder.Entity<Tblrole>(entity =>
            {
                entity.HasKey(e => e.RoleID)
                    .HasName("PK__tblrole__roleid");

                entity.ToTable("tblrole", "dbo");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Rolename");




            });
            modelBuilder.Entity<Tblnotificationlist>(entity =>
            {
                entity.HasKey(e => e.NotificationListMdid)
                    .HasName("pk_tblnotificationtype_notification_type_mdid");

                entity.ToTable("tblnotificationlist","dbo");

                entity.Property(e => e.NotificationListMdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("notification_list_mdid");

                entity.Property(e => e.ActiveFlag).HasColumnName("active_flag");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("created_by");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("image_name");

                entity.Property(e => e.ImageUrl)
                    .IsUnicode(false)
                    .HasColumnName("image_url");

                entity.Property(e => e.NotificationDescription)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("notification_description");

                entity.Property(e => e.NotificationPublishTypeMdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("notification_publish_type_mdid");

                entity.Property(e => e.NotificationTitle)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("notification_title");

                entity.Property(e => e.NotificationTypeMdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("notification_type_mdid");

                entity.Property(e => e.OpenNewTab).HasColumnName("open_new_tab");

                entity.Property(e => e.RedirectUrl)
                    .IsUnicode(false)
                    .HasColumnName("redirect_url");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("updated_by");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");
            });
            modelBuilder.Entity<CategoryEntity>(entity =>
            {
                entity.HasKey(e => e.StoreTypeLkupmdid)
                    .HasName("PK__category__3640A501345693F6");

                entity.ToTable("category_entity");

                entity.Property(e => e.StoreTypeLkupmdid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("store_type_lkupmdid");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("image_name");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("image_url");

                entity.Property(e => e.Storetype)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("storetype");
            });

            modelBuilder.Entity<DealEntity>(entity =>
            {
                entity.HasKey(e => new { e.StoreMdid, e.StoreofferGuid })
                    .HasName("PK__deal_ent__683785BA30B24FBD");

                entity.ToTable("deal_entity");

                entity.Property(e => e.StoreMdid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");

                entity.Property(e => e.StoreofferGuid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("storeoffer_guid");

                entity.Property(e => e.CashBackDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cash_back_desc");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("image_name");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("image_url");

                entity.Property(e => e.OfferCouponCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("offer_coupon_code");

                entity.Property(e => e.OfferEndDate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("offer_end_date");

                entity.Property(e => e.OfferTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("offer_title");

                entity.Property(e => e.StoreMdname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("store_mdname");

                entity.Property(e => e.StoreName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("store_name");

                entity.Property(e => e.StorecampaignGuid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("storecampaign_guid");
            });

            modelBuilder.Entity<HibernateSequence>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("hibernate_sequence", "dbo");

                entity.Property(e => e.NextVal).HasColumnName("next_val");
            });

            modelBuilder.Entity<StgTblstorecampaign>(entity =>
            {
                entity.ToTable("stg_tblstorecampaign", "dbo");

                entity.Property(e => e.StgTblstorecampaignId).HasColumnName("stg_tblstorecampaign_id");

                entity.Property(e => e.AffiliateUrl)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("affiliate_url");

                entity.Property(e => e.BaseUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("base_url");

                entity.Property(e => e.CampaignTerms)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("campaign_terms");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("category");



                entity.Property(e => e.CommCalcType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("comm_calc_type");

                entity.Property(e => e.CommCalcTypeLkupmdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("comm_calc_type_lkupmdid");

                entity.Property(e => e.CommPayout)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("comm_payout");

                entity.Property(e => e.CommType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("comm_type");

                entity.Property(e => e.CommTypeLkupmdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("comm_type_lkupmdid");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.LogoLargeUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("logo_large_url");

                entity.Property(e => e.LogoMediumUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("logo_medium_url");

                entity.Property(e => e.LogoSmallUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("logo_small_url");

                entity.Property(e => e.StoreMdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");

                entity.Property(e => e.StoreMdname)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_mdname");

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_name");

                entity.Property(e => e.StoreType)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_type");

                entity.Property(e => e.VendorNameLkupmdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vendor_name_lkupmdid");
            });

            modelBuilder.Entity<StgTblstoreoffer>(entity =>
            {
                entity.HasKey(e => e.StoreofferGuid)
                    .HasName("PK_stg_tblstoreoffer_storeoffer_guid");

                entity.ToTable("stg_tblstoreoffer", "dbo");

                entity.Property(e => e.StoreofferGuid).HasColumnName("storeoffer_guid");

                entity.Property(e => e.ActiveFlag).HasColumnName("active_flag");

                entity.Property(e => e.AffiliateUrl)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("affiliate_url");

                entity.Property(e => e.CampaignId).HasColumnName("campaign_id");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("campaign_name");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("image_url");

                entity.Property(e => e.OfferAddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("offer_added_date");

                entity.Property(e => e.OfferCouponCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("offer_coupon_code");

                entity.Property(e => e.OfferDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("offer_desc");

                entity.Property(e => e.OfferEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("offer_end_date");

                entity.Property(e => e.OfferId).HasColumnName("offer_id");

                entity.Property(e => e.OfferStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("offer_start_date");

                entity.Property(e => e.OfferTerms)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("offer_terms");

                entity.Property(e => e.OfferTitle)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("offer_title");

                entity.Property(e => e.StoreMdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_name");

                entity.Property(e => e.StoreType)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_type");

                entity.Property(e => e.VendorNameLkupid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vendor_name_lkupid");
            });

            modelBuilder.Entity<StoreDetailsEntity>(entity =>
            {
                entity.HasKey(e => e.StoreMdid)
                    .HasName("PK__store_de__D213BB58570C65CD");

                entity.ToTable("store_details_entity");

                entity.Property(e => e.StoreMdid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");

                entity.Property(e => e.AffiliateUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("affiliate_url");

                entity.Property(e => e.CashBackDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cash_back_desc");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("image_name");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("image_url");

                entity.Property(e => e.StoreMdname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("store_mdname");

                entity.Property(e => e.StoreName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("store_name");

                entity.Property(e => e.StorecampaignGuid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("storecampaign_guid");
            });

            modelBuilder.Entity<Tbladmin>(entity =>
            {
                entity.HasKey(e => e.AdminName)
                    .HasName("PK_tbladmin_admin_name");

                entity.ToTable("tbladmin", "dbo");

                entity.Property(e => e.AdminName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("admin_name");

                entity.Property(e => e.Activeflag).HasColumnName("activeflag");

                entity.Property(e => e.AdminGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("admin_guid");

                entity.Property(e => e.AdminPwd)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("admin_pwd");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");
            });

          

            modelBuilder.Entity<Tblaudittrail>(entity =>
            {
                entity.HasKey(e => e.AudittrailId)
                    .HasName("PK_tblaudittrail_audittrail_id");

                entity.ToTable("tblaudittrail", "dbo");

                entity.Property(e => e.AudittrailId).HasColumnName("audittrail_id");

                entity.Property(e => e.ActionType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("action_type");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("field_name");

                entity.Property(e => e.Functionality)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("functionality");

                entity.Property(e => e.KeyValue)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("key_value");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("module_name");

                entity.Property(e => e.NewValue)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("new_value");

                entity.Property(e => e.OldValue)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("old_value");

                entity.Property(e => e.TblName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("tbl_name");
            });

            modelBuilder.Entity<Tblbanner>(entity =>
            {
                entity.HasKey(e => e.BannerGuid)
                   .HasName("PK_tblbanner_banner_guid");

                entity.ToTable("tblbanner", "dbo");

                entity.Property(e => e.ActiveFlag).HasColumnName("active_flag");
                entity.Property(e => e.IsCustomURl).HasColumnName("is_custom_url");
                entity.Property(e => e.OpenNewTab   ).HasColumnName("open_new_tab");

                entity.Property(e => e.BannerGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("banner_guid");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("image_name");

                entity.Property(e => e.PageName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("page_name");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");

                entity.Property(e => e.Url)
                    .IsUnicode(false)
                    .HasColumnName("url");

                entity.Property(e => e.AffiliateUrl)
                 .IsUnicode(false)
                 .HasColumnName("affiliate_url");

                entity.Property(e => e.StoreId)
                .IsUnicode(false)
                .HasColumnName("store_mdid");

                entity.Property(e => e.StoreOfferId)
                .IsUnicode(false)
                .HasColumnName("store_offer_mdid");
            });

            modelBuilder.Entity<Tblcampaigncondition>(entity =>
            {
                entity.HasKey(e => e.CampaignconditionMdid)
                    .HasName("PK_tblcampaigncondition_campaigncondition_mdid");

                entity.ToTable("tblcampaigncondition", "dbo");

                entity.Property(e => e.CampaignconditionMdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("campaigncondition_mdid");

                entity.Property(e => e.ActiveFlag).HasColumnName("active_flag");

                entity.Property(e => e.CampaignconditionLkupmdid)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("campaigncondition_lkupmdid");

                entity.Property(e => e.CampaignconditionMdname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("campaigncondition_mdname");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.StoreMdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");

                entity.Property(e => e.StorecampaignGuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storecampaign_guid");

                entity.Property(e => e.StoreofferGuid)
                   .HasMaxLength(100)
                   .IsUnicode(false)
                   .HasColumnName("storeoffer_guid");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");

                entity.HasOne(d => d.StoreMd)
                    .WithMany(p => p.Tblcampaignconditions)
                    .HasForeignKey(d => d.StoreMdid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblcampaigncondition_fk_store_mdid");

                entity.HasOne(d => d.StorecampaignGu)
                    .WithMany(p => p.Tblcampaignconditions)
                    .HasForeignKey(d => d.StorecampaignGuid)
                    .HasConstraintName("tblcampaigncondition_fk_storecampaign_guid");

                entity.HasOne(d => d.StoreofferGu)
                  .WithMany(p => p.Tblcampaignconditions)
                  .HasForeignKey(d => d.StoreofferGuid)
                  .HasConstraintName("tblcampaigncondition_fk_storeoffer_guid");
            });

            modelBuilder.Entity<Tblcampaignterm>(entity =>
            {
                entity.HasKey(e => e.TblcampaigntermsId)
                    .HasName("PK_tblcampaignterms_tblcampaignterms_id");

                entity.ToTable("tblcampaignterms", "dbo");

                entity.HasIndex(e => e.StorecampaignGuid, "fk_tblcampaignterms_storecampaign_guid");

                entity.Property(e => e.TblcampaigntermsId).HasColumnName("tblcampaignterms_id");

                entity.Property(e => e.ActiveFlag).HasColumnName("active_flag");

                entity.Property(e => e.CampaignTerms)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("campaign_terms");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.RecordStatusLkupid).HasColumnName("record_status_lkupid");

                entity.Property(e => e.StorecampaignGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storecampaign_guid");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");

                entity.HasOne(d => d.StorecampaignGu)
                    .WithMany(p => p.Tblcampaignterms)
                    .HasForeignKey(d => d.StorecampaignGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblcampaignterms_fk_tblcampaignterms_storecampaign_guid");
            });

            modelBuilder.Entity<Tblcategoryorder>(entity =>
            {
                entity.HasKey(e => e.CategoryorderGuid)
                    .HasName("PK_tblcategoryorder_categoryorder_guid");

                entity.ToTable("tblcategoryorder", "dbo");

                entity.Property(e => e.CategoryorderGuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("categoryorder_guid");

                entity.Property(e => e.ActiveFlag).HasColumnName("active_flag");

                entity.Property(e => e.CategoryLkupmdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("category_lkupmdid");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.LkupgroupcodeMdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lkupgroupcode_mdid");

                entity.Property(e => e.UidisplayOrderId).HasColumnName("uidisplay_order_id");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");

                entity.HasOne(d => d.CategoryLkupmd)
                    .WithMany(p => p.Tblcategoryorders)
                    .HasForeignKey(d => d.CategoryLkupmdid)
                    .HasConstraintName("tblstore_fk_tblcategoryorder_category_lkupmdid");

                entity.HasOne(d => d.LkupgroupcodeMd)
                    .WithMany(p => p.Tblcategoryorders)
                    .HasForeignKey(d => d.LkupgroupcodeMdid)
                    .HasConstraintName("tblstore_fk_tblcategoryorder_lkupgroupcode_mdid");
            });

            modelBuilder.Entity<Tbllkupgroupcode>(entity =>
            {
                entity.HasKey(e => e.LkupgroupcodeMdid)
                    .HasName("PK_tbllkupgroupcode_lkupgroupcode_mdid");

                entity.ToTable("tbllkupgroupcode", "dbo");

                entity.Property(e => e.LkupgroupcodeMdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lkupgroupcode_mdid");

                entity.Property(e => e.ActiveFlag).HasColumnName("active_flag");

                entity.Property(e => e.Comments)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("comments");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.LkupgroupcodeCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lkupgroupcode_code");

                entity.Property(e => e.LkupgroupcodeMdname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lkupgroupcode_mdname");

                entity.Property(e => e.LkupgroupcodeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lkupgroupcode_name");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");
            });

            modelBuilder.Entity<Tbllkuplist>(entity =>
            {
                entity.HasKey(e => e.LkuplistMdid)
                    .HasName("PK_tbllkuplist_lkuplist_mdid");

                entity.ToTable("tbllkuplist", "dbo");

                entity.HasIndex(e => e.LkupgroupcodeMdid, "fk_lkupgroupcode_mdid");

                entity.Property(e => e.LkuplistMdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lkuplist_mdid");

                entity.Property(e => e.ActiveFlag).HasColumnName("active_flag");

                entity.Property(e => e.Comments)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("comments");
                entity.Property(e => e.DisplayName)
              .HasMaxLength(100)
              .IsUnicode(false)
              .HasColumnName("lkuplist_display_name");
                entity.Property(e => e.StartDate)
                   .HasColumnType("date")
                   .HasColumnName("start_date");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.IconName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("icon_name");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("image_url");

                entity.Property(e => e.LkupgroupcodeMdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lkupgroupcode_mdid");

                entity.Property(e => e.LkuplistCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lkuplist_code");

                entity.Property(e => e.LkuplistName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lkuplist_name");

                entity.HasOne(d => d.LkupgroupcodeMd)
                    .WithMany(p => p.Tbllkuplists)
                    .HasForeignKey(d => d.LkupgroupcodeMdid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbllkuplist_fk_lkupgroupcode_mdid");
            });

            modelBuilder.Entity<Tblofferhistory>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("PK_tblofferhistory_history_id");

                entity.ToTable("tblofferhistory", "dbo");

                entity.Property(e => e.HistoryId).HasColumnName("history_id");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.HistoryOfferAddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("history_offer_added_date");

                entity.Property(e => e.HistoryOfferCampaignId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("history_offer_campaign_id");

                entity.Property(e => e.HistoryOfferCampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("history_offer_campaign_name");

                entity.Property(e => e.HistoryOfferCategories)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("history_offer_categories");

                entity.Property(e => e.HistoryOfferCouponCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("history_offer_coupon_code");

                entity.Property(e => e.HistoryOfferDescription)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("history_offer_description");

                entity.Property(e => e.HistoryOfferEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("history_offer_end_date");

                entity.Property(e => e.HistoryOfferId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("history_offer_id");

                entity.Property(e => e.HistoryOfferImgUrl)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("history_offer_img_url");

                entity.Property(e => e.HistoryOfferMerchant)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("history_offer_merchant");

                entity.Property(e => e.HistoryOfferStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("history_offer_start_date");

                entity.Property(e => e.HistoryOfferStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("history_offer_status");

                entity.Property(e => e.HistoryOfferTerms)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("history_offer_terms");

                entity.Property(e => e.HistoryOfferTitle)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("history_offer_title");

                entity.Property(e => e.HistoryOfferUrl)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("history_offer_url");

                entity.Property(e => e.HistoryOfferValidStore).HasColumnName("history_offer_valid_store");

                entity.Property(e => e.HistoryVendorNameLkupid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("history_vendor_name_lkupid");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");
            });

            modelBuilder.Entity<Tblofferlatest>(entity =>
            {
                entity.HasKey(e => e.OfferId)
                    .HasName("PK_tblofferlatest_offer_id");

                entity.ToTable("tblofferlatest", "dbo");

                entity.Property(e => e.OfferId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("offer_id");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.OfferAddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("offer_added_date");

                entity.Property(e => e.OfferCampaignId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("offer_campaign_id");

                entity.Property(e => e.OfferCampaignName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("offer_campaign_name");

                entity.Property(e => e.OfferCategories)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("offer_categories");

                entity.Property(e => e.OfferCouponCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("offer_coupon_code");

                entity.Property(e => e.OfferDescription)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("offer_description");

                entity.Property(e => e.OfferEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("offer_end_date");

                entity.Property(e => e.OfferImgUrl)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("offer_img_url");

                entity.Property(e => e.OfferMerchant)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("offer_merchant");

                entity.Property(e => e.OfferStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("offer_start_date");

                entity.Property(e => e.OfferStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("offer_status");

                entity.Property(e => e.OfferTerms)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("offer_terms");

                entity.Property(e => e.OfferTitle)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("offer_title");

                entity.Property(e => e.OfferUrl)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("offer_url");

                entity.Property(e => e.OfferValidStore).HasColumnName("offer_valid_store");

                entity.Property(e => e.OfferVendorNameLkupid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("offer_vendor_name_lkupid");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");
            });

            modelBuilder.Entity<Tblshoppingtrip>(entity =>
            {
                entity.HasKey(e => e.ShoppingtripId)
                    .HasName("PK_tblshoppingtrip_shoppingtrip_id");

                entity.ToTable("tblshoppingtrip", "dbo");

                entity.HasIndex(e => e.StoreMdid, "fk_shoppingtrip_mdid");

                entity.Property(e => e.ShoppingtripId).HasColumnName("shoppingtrip_id");
                entity.Property(e => e.StatusUpdatedBy).HasColumnName("status_updated_by");
                entity.Property(e => e.AffiliateUrl)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("affiliate_url");

                entity.Property(e => e.Cashback)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cashback_amt");


                entity.Property(e => e.globalcashbackstatusId)
                   .HasMaxLength(100)
                   .IsUnicode(false)
                   .HasColumnName("globalpostbackstatus_lkupmdid");

                entity.Property(e => e.ShoppingTripStatusId).HasColumnName("shoppingtripstatus_lkupmdid");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");



                entity.Property(e => e.StoreMdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");

                entity.Property(e => e.StorecampaignGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storecampaign_guid");

                entity.Property(e => e.StoreofferGuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storeoffer_guid");

                entity.Property(e => e.SubId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("sub_id");

                entity.Property(e => e.UserGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_guid");

                entity.HasOne(d => d.User)
                  .WithMany(p => p.Tblshoppingtrip)
                  .HasForeignKey(d => d.UserGuid)
                  .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.StoreMd)
                   .WithMany(p => p.Tblshoppingtrips)
                   .HasForeignKey(d => d.StoreMdid)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("tblshoppingtr" +
                   "ip_fk_shoppingtrip_mdid");

                entity.HasOne(d => d.Storeoffer)
                 .WithMany(p => p.Tblshoppingtrips)
                 .HasForeignKey(d => d.StoreofferGuid)
                 .OnDelete(DeleteBehavior.ClientSetNull)
                 .HasConstraintName("tblshoppingtr" +
                 "ip_fk_storeoffer_guid");

            });

            modelBuilder.Entity<Tblshoppingtriphistory>(entity =>
            {
                entity.HasKey(e => e.ShoppingtriphistoryGuid)
                    .HasName("PK_tblshoppingtriphistory_shoppingtriphistory_guid");

                entity.ToTable("tblshoppingtriphistory", "dbo");

                entity.HasIndex(e => e.ShoppingtripId, "fk_tblshoppingtrip_id");

                entity.Property(e => e.ShoppingtriphistoryGuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("shoppingtriphistory_guid");

                entity.Property(e => e.Cashback)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cashback_amt");

                entity.Property(e => e.CashbackStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cashback_status");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.ShoppingtripId).HasColumnName("shoppingtrip_id");

                entity.Property(e => e.StatusComments)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status_comments");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");

            });
            modelBuilder.Entity<Tblmissingcashback>(entity =>
            {
                entity.HasKey(e => e.CashbackGuid)
                       .HasName("PK__tblmissingcashbackguid");

                entity.ToTable("tblmissingcashback", "dbo");

                entity.Property(e => e.CashbackGuid).HasColumnName("missingcashback_guid");
                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_guid");

                entity.Property(e => e.ShoppingtripId)

                    .HasColumnName("Shoppingtrip_Id");

                entity.Property(e => e.UserCmt)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("user_cmt");

                entity.Property(e => e.AdminCmt)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("admin_cmt");


                entity.Property(e => e.CashbackStatusId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("missingcashbackstatus_lkupmdid");
                entity.Property(e => e.ImageName)
                   .HasMaxLength(100)
                   .IsUnicode(false)
                   .HasColumnName("image_name");
                entity.Property(e => e.Url)
                   .HasMaxLength(5000)
                   .IsUnicode(false)
                   .HasColumnName("image_url");
                entity.Property(e => e.CashbackAmt)
                  .HasColumnType("decimal")
                   .IsUnicode(false)
                   .HasColumnName("cashback_amt");
                entity.Property(e => e.AapprovedAmt)
                .HasColumnType("decimal")
                 .IsUnicode(false)
                 .HasColumnName("approved_amt");
                entity.Property(e => e.BillingAmt)
               .HasColumnType("decimal")
                .IsUnicode(false)
                .HasColumnName("billing_amt");

                entity.Property(e => e.Createddatetime)
                  .HasColumnType("datetime")
                  .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.Updateddatetime)
                  .HasColumnType("datetime")
                  .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");
            }
            );
            modelBuilder.Entity<Tblstore>(entity =>
            {
                entity.HasKey(e => e.StoreMdid)
                    .HasName("PK_tblstore_store_mdid");

                entity.ToTable("tblstore", "dbo");

                entity.HasIndex(e => e.RecordStatusLkupid, "fk_tblstore_tbllkuplist_idx");

                entity.Property(e => e.StoreMdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");

                entity.Property(e => e.ActiveFlag).HasColumnName("active_flag");

                entity.Property(e => e.AffiliateUrl)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("affiliate_url");

                entity.Property(e => e.BaseUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("base_url");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("image_url");

                entity.Property(e => e.LogoLargeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("logo_large_name");

                entity.Property(e => e.LogoMediumName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("logo_medium_name");

                entity.Property(e => e.LogoSmallName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("logo_small_name");

                entity.Property(e => e.RecordStatusLkupid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("record_status_lkupid");

                entity.Property(e => e.StoreCazhonCommission)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("store_cazhon_commission")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.StoreMdname)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_mdname");

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_name");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");

                entity.HasOne(d => d.RecordStatusLkup)
                    .WithMany(p => p.Tblstores)
                    .HasForeignKey(d => d.RecordStatusLkupid)
                    .HasConstraintName("tblstore_fk_tblstore_tbllkuplist");
            });

            modelBuilder.Entity<Tblstore1>(entity =>
            {
                entity.HasKey(e => e.StoreMdid)
                    .HasName("PK__tblstore__D213BB58FAC14F2F");

                entity.ToTable("tblstore");

                entity.Property(e => e.StoreMdid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");

                entity.Property(e => e.StoreMdname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("store_mdname");

                entity.Property(e => e.StoreName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("store_name");
            });

            modelBuilder.Entity<Tblstorecampaign>(entity =>
            {
                entity.HasKey(e => e.StorecampaignGuid)
                    .HasName("PK_tblstorecampaign_storecampaign_guid");

                entity.ToTable("tblstorecampaign", "dbo");

                entity.HasIndex(e => e.StoreMdid, "fk_storecampaign_mdid");

                entity.HasIndex(e => e.RecordStatusLkupid, "fk_storecampaign_tbllkuplist_idx");

                entity.Property(e => e.StorecampaignGuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storecampaign_guid");

                entity.Property(e => e.ActiveFlag).HasColumnName("active_flag");

                entity.Property(e => e.Banner1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("banner_1");

                entity.Property(e => e.Banner2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("banner_2");

                entity.Property(e => e.Banner3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("banner_3");

                entity.Property(e => e.CampaignCazhonCommission)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("campaign_cazhon_commission")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.CampaignTerms)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("campaign_terms");

                entity.Property(e => e.CampaignUserCashback)
                    .HasColumnName("campaign_user_cashback")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("category");

                //entity.Property(e => e.CategoryDescription)                   
                //    .HasMaxLength(3000)
                //    .IsUnicode(false)
                //    .HasColumnName("category_description");

                entity.Property(e => e.CommCalcTypeLkupmdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("comm_calc_type_lkupmdid");

                entity.Property(e => e.CommPayout)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("comm_payout");

                entity.Property(e => e.CommTypeLkupmdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("comm_type_lkupmdid");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("image_url");

                entity.Property(e => e.RecordStatusLkupid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("record_status_lkupid");

                entity.Property(e => e.StoreMdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");

                entity.Property(e => e.VendorNameLkupmdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vendor_name_lkupmdid");

                entity.Property(e => e.AffiliateUrl)
                     .HasMaxLength(4000)
                     .IsUnicode(false)
                     .HasColumnName("affiliate_url");

                entity.HasOne(d => d.RecordStatusLkup)
                    .WithMany(p => p.Tblstorecampaigns)
                    .HasForeignKey(d => d.RecordStatusLkupid)
                    .HasConstraintName("tblstorecampaign_fk_storecampaign_tbllkuplist");

                entity.HasOne(d => d.StoreMd)
                    .WithMany(p => p.Tblstorecampaigns)
                    .HasForeignKey(d => d.StoreMdid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblstorecampaign_fk_storecampaign_mdid");
            });

            modelBuilder.Entity<Tblstorecity>(entity =>
            {
                entity.HasKey(e => e.StorecityMdid)
                    .HasName("PK_tblstorecity_storecity_mdid");

                entity.ToTable("tblstorecity", "dbo");

                entity.Property(e => e.StorecityMdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storecity_mdid");

                entity.Property(e => e.ActiveFlag).HasColumnName("active_flag");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.StoreCityLkupmdid)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_city_lkupmdid");

                entity.Property(e => e.StoreMdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");

                entity.Property(e => e.StorecampaignGuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storecampaign_guid");

                entity.Property(e => e.StorecityMdname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storecity_mdname");

                entity.Property(e => e.StoreofferGuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storeoffer_guid");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");

                entity.HasOne(d => d.StoreMd)
                    .WithMany(p => p.Tblstorecities)
                    .HasForeignKey(d => d.StoreMdid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblstorecity_fk_store_mdid");

                entity.HasOne(d => d.StorecampaignGu)
                    .WithMany(p => p.Tblstorecities)
                    .HasForeignKey(d => d.StorecampaignGuid)
                    .HasConstraintName("tblstorecity_fk_storecampaign_guid");

                entity.HasOne(d => d.StoreofferGu)
                    .WithMany(p => p.Tblstorecities)
                    .HasForeignKey(d => d.StoreofferGuid)
                    .HasConstraintName("tblstorecity_fk_storeoffer_guid");
            });

            modelBuilder.Entity<Tblstoreoffer>(entity =>
            {
                entity.HasKey(e => e.StoreofferGuid)
                    .HasName("PK_tblstoreoffer_storeoffer_guid");

                entity.ToTable("tblstoreoffer", "dbo");

                entity.HasIndex(e => e.StoreMdid, "fk_storeoffer_mdid");

                entity.HasIndex(e => e.RecordStatusLkupid, "fk_storeoffer_tbllkuplist_idx");

                entity.Property(e => e.StoreofferGuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storeoffer_guid");

                entity.Property(e => e.ActiveFlag).HasColumnName("active_flag");

                entity.Property(e => e.AffiliateUrl)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("affiliate_url");

                entity.Property(e => e.Banner1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("banner_1");

                entity.Property(e => e.Banner2)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("banner_2");

                entity.Property(e => e.Banner3)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("banner_3");

                entity.Property(e => e.CommCalcTypeLkupmdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("comm_calc_type_lkupmdid")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.CommPayout)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("comm_payout")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.CommTypeLkupmdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("comm_type_lkupmdid")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("image_url");

                entity.Property(e => e.OfferAddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("offer_added_date");

                entity.Property(e => e.OfferCazhonCommission)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("offer_cazhon_commission")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.OfferCouponCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("offer_coupon_code");

                entity.Property(e => e.OfferEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("offer_end_date");

                entity.Property(e => e.OfferStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("offer_start_date");

                entity.Property(e => e.OfferTerms)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("offer_terms");

                entity.Property(e => e.OfferTitle)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("offer_title");

                entity.Property(e => e.OfferUserCashback)
                    .HasColumnName("offer_user_cashback")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.RecordStatusLkupid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("record_status_lkupid");

                entity.Property(e => e.StoreMdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");

                entity.Property(e => e.VendorNameLkupid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vendor_name_lkupid");

                entity.HasOne(d => d.RecordStatusLkup)
                    .WithMany(p => p.Tblstoreoffers)
                    .HasForeignKey(d => d.RecordStatusLkupid)
                    .HasConstraintName("tblstoreoffer_fk_storeoffer_tbllkuplist");

                entity.HasOne(d => d.StoreMd)
                    .WithMany(p => p.Tblstoreoffers)
                    .HasForeignKey(d => d.StoreMdid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblstoreoffer_fk_storeoffer_mdid");
            });
            modelBuilder.Entity<TblStoreProduct>(entity =>
            {

                entity.HasKey(e => e.StoreProductGuid)
                                 .HasName("PK_storeProduct_storeProduct_guid");
                entity.ToTable("tblstoreProduct", "dbo");

                entity.HasIndex(e => e.StoreMdid, "fk_storeProduct_mdid");

                entity.HasIndex(e => e.RecordStatusLkupid, "fk_storeProduct_tbllkuplist");

                entity.Property(e => e.StoreProductGuid)
                             .HasMaxLength(100)
                             .IsUnicode(false)
                             .HasColumnName("storeproduct_guid");

                entity.Property(e => e.ActiveFlag).HasColumnName("active_flag");

                entity.Property(e => e.AffiliateUrl)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("affiliate_url");

                entity.Property(e => e.Banner1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("banner_1");

                entity.Property(e => e.Banner2)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("banner_2");

                entity.Property(e => e.Banner3)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("banner_3");

                entity.Property(e => e.CommCalcTypeLkupmdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("comm_calc_type_lkupmdid")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.CommPayout)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("comm_payout")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.CommTypeLkupmdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("comm_type_lkupmdid")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("image_url");

                entity.Property(e => e.ProductCazhonCommission)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Product_cazhon_commission")
                    .HasDefaultValueSql("((-1))");
                entity.Property(e => e.ProductCouponCode)
                 .HasMaxLength(1000)
                 .IsUnicode(false)
                 .HasColumnName("Product_coupon_code");

                entity.Property(e => e.ProductTitle)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Product_title");

                entity.Property(e => e.ProductUserCashback)
                    .HasColumnName("Product_user_cashback")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.RecordStatusLkupid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("record_status_lkupid");

                entity.Property(e => e.StoreMdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");

                entity.Property(e => e.VendorNameLkupid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vendor_name_lkupid");

                entity.HasOne(d => d.RecordStatusLkup)
                    .WithMany(p => p.Tblstoreproducts)
                    .HasForeignKey(d => d.RecordStatusLkupid)
                    .HasConstraintName("tblstoreproduct_fk_storeproduct_tbllkuplist");

                entity.HasOne(d => d.StoreMd)
                    .WithMany(p => p.TblStoreProducts)
                    .HasForeignKey(d => d.StoreMdid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblstoreproduct_fk_storeproduct_mdid");
            });

            modelBuilder.Entity<Tblstoretype>(entity =>
            {
                entity.HasKey(e => e.StoretypeMdid)
                    .HasName("PK_tblstoretype_storetype_mdid");

                entity.ToTable("tblstoretype", "dbo");

                entity.HasIndex(e => e.StoreMdid, "fk_store_mdid");

                entity.Property(e => e.StoretypeMdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storetype_mdid");

                entity.Property(e => e.ActiveFlag).HasColumnName("active_flag");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.PageType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("page_type")
                    .HasDefaultValueSql("('store')");

                entity.Property(e => e.StoreMdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");

                entity.Property(e => e.StoreTypeLkupmdid)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_type_lkupmdid");

                entity.Property(e => e.StorecampaignGuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storecampaign_guid");

                entity.Property(e => e.StoreofferGuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storeoffer_guid");
                entity.Property(e => e.StoreproductGuid)
                 .HasMaxLength(100)
                 .IsUnicode(false)
                 .HasColumnName("storeproduct_guid");


                entity.Property(e => e.StoretypeMdname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storetype_mdname");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");

                entity.HasOne(d => d.StoreMd)
                    .WithMany(p => p.Tblstoretypes)
                    .HasForeignKey(d => d.StoreMdid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblstoretype_fk_store_mdid");

                entity.HasOne(d => d.StorecampaignGu)
                    .WithMany(p => p.Tblstoretypes)
                    .HasForeignKey(d => d.StorecampaignGuid)
                    .HasConstraintName("tblstoretype_fk_storecampaign_guid");

                entity.HasOne(d => d.StoreofferGu)
                    .WithMany(p => p.Tblstoretypes)
                    .HasForeignKey(d => d.StoreofferGuid)
                    .HasConstraintName("tblstoretype_fk_storeoffer_guid");

                entity.HasOne(d => d.StoreproductGu)
                  .WithMany(p => p.Tblstoretypes)
                  .HasForeignKey(d => d.StoreproductGuid)
                  .HasConstraintName("tblstoretype_fk_storeproduct_guid");
            });
            modelBuilder.Entity<Tblproductype>(entity =>
            {
                entity.HasKey(e => e.ProducttypeMdid)
                    .HasName("PK_tblproducttype_producttype_mdid");

                entity.ToTable("tblproducttype", "dbo");

                entity.HasIndex(e => e.StoreMdid, "fk_store_mdid");

                entity.Property(e => e.ProducttypeMdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("producttype_mdid");

                entity.Property(e => e.ActiveFlag).HasColumnName("active_flag");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.PageType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("page_type")
                    .HasDefaultValueSql("('product')");

                entity.Property(e => e.StoreMdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");

                entity.Property(e => e.ProductLkupmdid)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("producttype_lkupmdid");


                entity.Property(e => e.StoreofferGuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storeoffer_guid");

                entity.Property(e => e.StoreCampaignGuid)
                  .HasMaxLength(100)
                  .IsUnicode(false)
                  .HasColumnName("storecampaign_guid");

                entity.Property(e => e.StoreProductGuid)
                  .HasMaxLength(100)
                  .IsUnicode(false)
                  .HasColumnName("storeproduct_guid");

                entity.Property(e => e.ProducttypeMdname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("producttype_mdname");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");

                entity.HasOne(d => d.StoreMd)
                    .WithMany(p => p.Tblproductypes)
                    .HasForeignKey(d => d.StoreMdid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblproducttype_fk_store_mdid");

                entity.HasOne(d => d.StoreProductGu)
                      .WithMany(p => p.Tblproducttypes)
                      .HasForeignKey(d => d.StoreProductGuid)
                      .HasConstraintName("tblproducttype_fk_storeproduct_guid");

                entity.HasOne(d => d.StoreofferGu)
                    .WithMany(p => p.Tblproducttypes)
                    .HasForeignKey(d => d.StoreofferGuid)
                    .HasConstraintName("tblproducttype_fk_storeoffer_guid");

            });
            modelBuilder.Entity<Tbluser>(entity =>
            {
                entity.HasKey(e => e.UserGuid)
                    .HasName("PK_tbluser_user_guid");

                entity.ToTable("tbluser", "dbo");

                entity.Property(e => e.UserEmailId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_email_id");

                entity.Property(e => e.Accountactiveflag).HasColumnName("accountactiveflag");

                entity.Property(e => e.Activeflag).HasColumnName("activeflag");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.LastLoginDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("last_login_datetime");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");

                entity.Property(e => e.LifetimeCashBack)
                   .HasColumnType("decimal")
                   .HasColumnName("lifetime_cash_back_amt");

                entity.Property(e => e.WelcomeBonus)
                 .HasColumnType("decimal")
                 .HasColumnName("welcomebonus_amt");

                entity.Property(e => e.AvailableWithdrawlCashBack)
                   .HasColumnType("decimal")
                   .HasColumnName("available_withdrawl_cash_amt");

                entity.Property(e => e.UserFirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_first_name");

                entity.Property(e => e.ReferralCode)
                  .HasMaxLength(100)
                  .IsUnicode(false)
                  .HasColumnName("referral_code");

                entity.Property(e => e.UserGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_guid");

                entity.Property(e => e.UserLastName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_last_name");

                entity.Property(e => e.UserMdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_mdid");

                entity.Property(e => e.UserPwd)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("user_pwd");

                entity.Property(e => e.UserlogintypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userlogintype_name");


                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");

                entity.Property(e => e.PhoneVerified).HasColumnName("phone_verified");

                entity.Property(e => e.PicName)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("pic_name");

                entity.Property(e => e.TimestampCnt)
                    .HasColumnName("timestamp_cnt")
                    .HasDefaultValueSql("((1))");
                entity.Property(e => e.EmailVerified).HasColumnName("email_verified");
            });

            modelBuilder.Entity<Tbluser1>(entity =>
            {
                entity.HasKey(e => e.UserGuid)
                    .HasName("PK__tbluser__2F6ECDD7C330781B");

                entity.ToTable("tbluser");

                entity.Property(e => e.UserGuid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("user_guid");

                entity.Property(e => e.Accountactiveflag).HasColumnName("accountactiveflag");

                entity.Property(e => e.Activeflag).HasColumnName("activeflag");

                entity.Property(e => e.Createddatetime)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.LastLoginDatetime)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("last_login_datetime");

                entity.Property(e => e.Updateddatetime)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("updateddatetimeutc");

                entity.Property(e => e.UserEmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("user_email_id");


                entity.Property(e => e.UserFirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("user_first_name");

                entity.Property(e => e.UserLastName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("user_last_name");

                entity.Property(e => e.UserPwd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("user_pwd");

                entity.Property(e => e.UserlogintypeName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("userlogintype_name");
            });

            modelBuilder.Entity<TbluserBkp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbluser_bkp", "dbo");

                entity.Property(e => e.Accountactiveflag).HasColumnName("accountactiveflag");

                entity.Property(e => e.Activeflag).HasColumnName("activeflag");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.LastLoginDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("last_login_datetime");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");

                entity.Property(e => e.UserEmailId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_email_id");

                entity.Property(e => e.UserFirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_first_name");

                entity.Property(e => e.UserGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_guid");

                entity.Property(e => e.UserLastName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_last_name");

                entity.Property(e => e.UserPwd)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("user_pwd");

                entity.Property(e => e.UserlogintypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userlogintype_name");
            });

            modelBuilder.Entity<Tbluseraddress>(entity =>
            {
                entity.HasKey(e => e.UseraddressId)
                    .HasName("PK_tbluseraddress_useraddress_id");

                entity.ToTable("tbluseraddress", "dbo");

                entity.Property(e => e.UseraddressId).HasColumnName("useraddress_id");

                entity.Property(e => e.Activeflag).HasColumnName("activeflag");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address_1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("address_2");

                entity.Property(e => e.Address3)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("address_3");

                entity.Property(e => e.AddressTypeLkupid).HasColumnName("address_type_lkupid");

                entity.Property(e => e.CityName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("city_name");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("country_name");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("state_code");

                entity.Property(e => e.StateName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("state_name");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("zip_code");
            });
            modelBuilder.Entity<Tbluserbank>(entity =>
            {
                entity.HasKey(e => e.UserBankGuid)
                  .HasName("PK_tbluserpayment_userbank_guid");

                entity.ToTable("tbluserbank", "dbo");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("account_number");

                entity.Property(e => e.Activeflag).HasColumnName("activeflag");



                entity.Property(e => e.BankAddresss)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("bank_addresss");

                entity.Property(e => e.BankBranch)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bank_branch");

                entity.Property(e => e.BankCenter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bank_center");

                entity.Property(e => e.BankCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bank_city");

                entity.Property(e => e.BankDistrict)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bank_district");

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bank_name");

                entity.Property(e => e.BankState)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bank_state");

                entity.Property(e => e.BeneficiaryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("beneficiary_name");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.IfscCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ifsc_code");

                entity.Property(e => e.BankJson)
                   .HasMaxLength(50)
                   .IsUnicode(false)
                   .HasColumnName("bank_json");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");

                entity.Property(e => e.UserBankGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_bank_guid");

                entity.Property(e => e.UserGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_guid");



                entity.HasOne(d => d.User)
               .WithMany(p => p.TbluserBank)
               .HasForeignKey(d => d.UserGuid)
               .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Tbluserfavoritestore>(entity =>
            {
                entity.HasKey(e => e.UserfavoritestoreId)
                    .HasName("PK_tbluserfavoritestore_userfavoritestore_id");

                entity.ToTable("tbluserfavoritestore", "dbo");

                entity.HasIndex(e => e.StoreMdid, "tbluserfavoritestore_store_mdid");

                entity.Property(e => e.UserfavoritestoreId).HasColumnName("userfavoritestore_id");

                entity.Property(e => e.ActiveFlag).HasColumnName("active_flag");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.StoreMdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");

                entity.Property(e => e.UserGuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_guid");

                entity.HasOne(d => d.StoreMd)
                    .WithMany(p => p.Tbluserfavoritestores)
                    .HasForeignKey(d => d.StoreMdid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("tbluserfavoritestore_tbluserfavoritestore_store_mdid");
            });

            modelBuilder.Entity<Tbluserloginhistory>(entity =>
            {
                entity.HasKey(e => e.LoginhistoryGuid)
                    .HasName("PK_tbluserloginhistory_loginhistory_guid");

                entity.ToTable("tbluserloginhistory", "dbo");

                entity.Property(e => e.LoginhistoryGuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("loginhistory_guid");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.SessionGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("session_guid");

                entity.Property(e => e.UserGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_guid");
            });

            modelBuilder.Entity<Tbluserlogintype>(entity =>
            {
                entity.HasKey(e => e.UserlogintypeId)
                    .HasName("PK_tbluserlogintype_userlogintype_id");

                entity.ToTable("tbluserlogintype", "dbo");

                entity.Property(e => e.UserlogintypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("userlogintype_id");

                entity.Property(e => e.Activeflag).HasColumnName("activeflag");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("comments");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");

                entity.Property(e => e.UserlogintypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userlogintype_name");
            });

            modelBuilder.Entity<Tbluserpayment>(entity =>
            {
                entity.HasKey(e => e.UserPaymentGuid)
                  .HasName("PK_tbluserpayment_user_payment_guid");

                entity.ToTable("tbluserpayment", "dbo");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("account_number");

                entity.Property(e => e.Activeflag).HasColumnName("activeflag");

                entity.Property(e => e.AvailWithdrawalAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("avail_withdrawal_amount");

                entity.Property(e => e.BankAddresss)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("bank_addresss");

                entity.Property(e => e.BankBranch)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bank_branch");

                entity.Property(e => e.BankCenter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bank_center");

                entity.Property(e => e.BankCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bank_city");

                entity.Property(e => e.BankDistrict)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bank_district");

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bank_name");

                entity.Property(e => e.BankState)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bank_state");

                entity.Property(e => e.BeneficiaryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("beneficiary_name");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.IfscCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ifsc_code");

                entity.Property(e => e.UTRNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UTR_Number");
                entity.Property(e => e.PaymentStatusLkupid).HasColumnName("payment_status_lkupid");

                entity.Property(e => e.RequestWithdrawalAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("request_withdrawal_amount");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");

                entity.Property(e => e.UserBankGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_bank_guid");

                entity.Property(e => e.UserGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_guid");

                entity.Property(e => e.UserPaymentGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_payment_guid");

                entity.HasOne(d => d.User)
               .WithMany(p => p.TbluserPayment)
               .HasForeignKey(d => d.UserGuid)
               .OnDelete(DeleteBehavior.ClientSetNull);
            });
            modelBuilder.Entity<TblUserTransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionID)
                    .HasName("pk_tblusertransaction_transaction_id");

                entity.ToTable("tblusertransaction", "dbo");

                entity.HasIndex(e => e.Transactiontypelkpmdid, "fk_tblusertransaction_transactiontype_lkupmdid");

                entity.Property(e => e.TransactionReferenceId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("transaction_reference_id");

                entity.Property(e => e.Transactiontypelkpmdid)
                    
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("transactiontype_lkupmdid");
                entity.Property(e => e.TransactionID)
                    .HasColumnType("bigint")
                    .HasColumnName("transaction_id");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("transaction_date");
                entity.Property(e => e.CreatedDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.CreatedDateTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");


                entity.Property(e => e.CreatedBy)
                    
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("created_by");

                entity.Property(e => e.UpdatedBy)
                    
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("updated_by");
                entity.Property(e => e.CouponCode)

                   .HasMaxLength(100)
                   .IsUnicode(false)
                   .HasColumnName("coupon_code");


                entity.Property(e => e.CommentDesc)

                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment_desc");
                entity.Property(e => e.UserGuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_guid");

                entity.Property(e => e.TransactionAmount)
                 .HasColumnName("transaction_amt");

                entity.Property(e => e.UpdatedDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.UpdatedDateTimeUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");
                entity.HasOne(d => d.User)
             .WithMany(p => p.TblUserTransaction)
             .HasForeignKey(d => d.UserGuid)
             .OnDelete(DeleteBehavior.ClientSetNull);

            });
            modelBuilder.Entity<RawTblGlobalPostBack>(entity =>
            {
                entity.HasKey(e => e.Rawlobalpostbackid)
                 .HasName("PK_tbl_raw_globalpostback");

                entity.ToTable("tbl_raw_globalpostback", "dbo");
                 entity.Property(e => e.Rawlobalpostbackid)
                     .HasColumnType("bigint")
                    .HasColumnName("raw_globalpostback_id");
            

              

                entity.Property(e => e.CashBackStatusId)
                    .HasColumnType("int")
                   .HasColumnName("cashback_status_id");

                entity.Property(e => e.Transactionid)
                   .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("transactionid");

                entity.Property(e => e.Advertisername)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("advertisername");

                entity.Property(e => e.Transactiondate)
                .HasMaxLength(100)
                 .IsUnicode(false)
                 .HasColumnName("transactiondate");

                entity.Property(e => e.Saleamount)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("saleamount");

                entity.Property(e => e.Ipaddress)
                 .HasMaxLength(100)
                  .IsUnicode(false)
                  .HasColumnName("ipaddress");

                entity.Property(e => e.status)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Subid)
                  .HasMaxLength(100)
                  .IsUnicode(false)
                  .HasColumnName("Subid");

                entity.Property(e => e.Source)
                  .HasMaxLength(100)
                  .IsUnicode(false)
                  .HasColumnName("source");

                entity.Property(e => e.Vendor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vendor");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Updateddate)
                    .HasColumnType("datetime")
                    .HasColumnName("Updateddatetime");

                entity.Property(e => e.JobRunDatetime)
               .HasColumnType("datetime")
               .HasColumnName("jobrundatetime");

                entity.Property(e => e.ExternalId)
               .HasMaxLength(30)
              .HasColumnName("external_id");

                entity.Property(e => e.ExternalUpdatedate)
            .HasColumnType("datetime")
            .HasColumnName("external_updatedate");

                entity.Property(e => e.ExternalClickId)
               .HasMaxLength(30)
              .HasColumnName("external_clickid");

                entity.Property(e => e.ExternalReferalUrl)
              .HasMaxLength(1000)
             .HasColumnName("external_referralurl");


            });
            modelBuilder.Entity<Tbluserpaymenthistory>(entity =>
            {
                entity.HasKey(e => e.UserpaymenthistoryGuid)
                    .HasName("PK_tbluserpaymenthistory_userpaymenthistory_guid");

                entity.ToTable("tbluserpaymenthistory", "dbo");

                entity.Property(e => e.UserpaymenthistoryGuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("userpaymenthistory_guid");

                entity.Property(e => e.Cashback)
                    .HasColumnType("decimal(28, 3)")
                    .HasColumnName("cashback");

                entity.Property(e => e.Comments)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("comments");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.PaymentStatusLkupid).HasColumnName("payment_status_lkupid");

                entity.Property(e => e.UserGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_guid");

                entity.Property(e => e.UserpaymentGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("userpayment_guid");
            });

            modelBuilder.Entity<Tblapirequestresponselogs>(entity =>
            {
                entity.HasKey(e => e.Loggingid)
                .HasName("PK__tblapirequestresponse_responselog_id");
                entity.ToTable("tblapirequestresponselogs", "dbo");

                entity.Property(e => e.Loggingid)
                     .HasColumnType("bigint")
                    .HasColumnName("responselog_id");
                entity.Property(e => e.RetryCount)
                     .HasColumnType("int")
                    .HasColumnName("retry_count");

                entity.Property(e => e.Apiurl)
                   .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("api_url");

                entity.Property(e => e.Apiresponse)
                   .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("api_response");

                entity.Property(e => e.Status)
                   .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Urltype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("url_type");

                entity.Property(e => e.startdate)
                   .HasColumnType("datetime")
                   .HasColumnName("start_date");

                entity.Property(e => e.enddate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Updateddate)
                    .HasColumnType("datetime")
                    .HasColumnName("Updateddatetime");

                entity.Property(e => e.Createddateutc)
                  .HasColumnType("datetime")
                  .HasColumnName("createddatetimeutc");

                entity.Property(e => e.Updateddateutc)
                    .HasColumnType("datetime")
                    .HasColumnName("Updateddatetimeutc");



            });
            modelBuilder.Entity<Tblcouponfeed>(entity =>
            {

                entity.HasKey(e => e.id)
               .HasName("PK_tblcouponfeed_coupon_id");
                entity.ToTable("tblcouponfeed", "dbo");

                entity.Property(e => e.id)
                     .HasColumnType("bigint")
                    .HasColumnName("coupon_id");

                entity.Property(e => e.storelogo_id)
                 .HasColumnType("bigint")
                .HasColumnName("external_storelogo_id");

                entity.Property(e => e.couponlogo_id)
                 .HasColumnType("int")
                .HasColumnName("couponlogo_id");

                entity.Property(e => e.url)
                   .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("coupon_url");

                entity.Property(e => e.label)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("coupon_label");

                entity.Property(e => e.offer)
                .HasMaxLength(250)
                 .IsUnicode(false)
                 .HasColumnName("offer");

                entity.Property(e => e.coupon_code)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("coupon_code");

                entity.Property(e => e.steps)
                 .HasMaxLength(10000)
                  .IsUnicode(false)
                  .HasColumnName("steps");

                entity.Property(e => e.description)
                    .HasMaxLength(10000)
                    .IsUnicode(false)
                    
                    .HasColumnName("coupon_desc");

                entity.Property(e => e.categories)
                  .HasMaxLength(100)
                  .IsUnicode(false)
                  .HasColumnName("external_category");


                entity.Property(e => e.storename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("store_name");
                entity.Property(e => e.vendor)
         .HasMaxLength(100)
         .IsUnicode(false)
         .HasColumnName("vendor");
                entity.Property(e => e.createdby)
         .HasMaxLength(100)
         .IsUnicode(false)
         .HasColumnName("createdby");
                entity.Property(e => e.updatedby)
         .HasMaxLength(100)
         .IsUnicode(false)
         .HasColumnName("updatedby");

                entity.Property(e => e.expire_date)
                       .HasColumnType("datetime")
                    .HasColumnName("expire_date");

                entity.Property(e => e.createddate)
                                   .HasColumnType("datetime")
                                   .HasColumnName("createddatetime");

                entity.Property(e => e.createddateutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.updateddate)
                                 .HasColumnType("datetime")
                                 .HasColumnName("updateddatetime");

                entity.Property(e => e.updateddateutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");


            });
            modelBuilder.Entity<Tblglobalpostback>(entity =>
            {

                entity.HasKey(e => e.Globalpostbackid)
               .HasName("PK__tblglobalpostback_globalpostbackid");
                entity.ToTable("tblglobalpostback", "dbo");

                entity.Property(e => e.Globalpostbackid)
                     .HasColumnType("bigint")
                    .HasColumnName("Globalpostbackid");

                entity.Property(e => e.Transactionid)
                   .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("transactionid");

                entity.Property(e => e.Advertisername)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("advertisername");

                entity.Property(e => e.Transactiondate)
                .HasMaxLength(100)
                 .IsUnicode(false)
                 .HasColumnName("transactiondate");

                entity.Property(e => e.Saleamount)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("saleamount"); 

                entity.Property(e => e.Ipaddress)
                 .HasMaxLength(100)
                  .IsUnicode(false)
                  .HasColumnName("ipaddress");

                entity.Property(e => e.status)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Subid)
                  .HasMaxLength(100)
                  .IsUnicode(false)
                  .HasColumnName("Subid");

                entity.Property(e => e.Source)
                  .HasMaxLength(100)
                  .IsUnicode(false)
                  .HasColumnName("source");

                entity.Property(e => e.Vendor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vendor");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate");

                entity.Property(e => e.Updateddate)
                    .HasColumnType("datetime")
                    .HasColumnName("Updateddate");

               
            });
            modelBuilder.Entity<Tbluserpwdreset>(entity =>
            {
                entity.HasKey(e => e.UserpwdresetId)
                    .HasName("PK_tbluserpwdreset_userpwdreset_id");

                entity.ToTable("tbluserpwdreset", "dbo");

                entity.Property(e => e.UserpwdresetId).HasColumnName("userpwdreset_id");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.PwdTokenId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pwd_token_id");

                entity.Property(e => e.Tokenexpirydatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("tokenexpirydatetime");

                entity.Property(e => e.UserGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_guid");
            });

            modelBuilder.Entity<Tbluserpwdreset>(entity =>
            {
                entity.HasKey(e => e.UserpwdresetId)
                    .HasName("PK_tbluserpwdreset_userpwdreset_id");

                entity.ToTable("tbluserpwdreset", "dbo");

                entity.Property(e => e.UserpwdresetId).HasColumnName("userpwdreset_id");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.PwdTokenId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pwd_token_id");

                entity.Property(e => e.Tokenexpirydatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("tokenexpirydatetime");

                entity.Property(e => e.UserGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_guid");
            });

            modelBuilder.Entity<Tbluserpwdreset1>(entity =>
            {
                entity.HasKey(e => e.UserpwdresetId)
                    .HasName("PK__tbluserp__60CCF009C9122C13");

                entity.ToTable("tbluserpwdreset");

                entity.Property(e => e.UserpwdresetId).HasColumnName("userpwdreset_id");

                entity.Property(e => e.Createddatetime).HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc).HasColumnName("createddatetimeutc");

                entity.Property(e => e.PwdTokenId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("pwd_token_id");

                entity.Property(e => e.Tokenexpirydatetime).HasColumnName("tokenexpirydatetime");

                entity.Property(e => e.UserGuid)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("user_guid");

                entity.HasOne(d => d.UserGu)
                    .WithMany(p => p.Tbluserpwdreset1s)
                    .HasForeignKey(d => d.UserGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK695an1v92bgkm14o57nmopvve");
            });

            modelBuilder.Entity<Tblusersignupconfirm>(entity =>
            {
                entity.HasKey(e => e.UsersignupconfirmId)
                    .HasName("PK_tblusersignupconfirm_usersignupconfirm_id");

                entity.ToTable("tblusersignupconfirm", "dbo");

                entity.Property(e => e.UsersignupconfirmId).HasColumnName("usersignupconfirm_id");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.SingupTokenId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("singup_token_id");

                entity.Property(e => e.Tokenexpirydatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("tokenexpirydatetime");

                entity.Property(e => e.UserGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_guid");
            });

            modelBuilder.Entity<Tblvendor>(entity =>
            {
                entity.HasKey(e => e.VendorGuidid)
                    .HasName("PK_tblvendor_vendor_guidid");

                entity.ToTable("tblvendor", "dbo");

                entity.Property(e => e.VendorGuidid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vendor_guidid");

                entity.Property(e => e.ActiveFlag).HasColumnName("active_flag");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");

                entity.Property(e => e.VendorCommPrcnt)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("vendor_comm_prcnt");

                entity.Property(e => e.VendorName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("vendor_name");
            });

            modelBuilder.Entity<TempstgTblstoreoffer>(entity =>
            {
                entity.HasKey(e => e.TempStoreofferQuid)
                    .HasName("PK_tempstg_tblstoreoffer_temp_storeoffer quid");

                entity.ToTable("tempstg_tblstoreoffer", "dbo");

                entity.Property(e => e.TempStoreofferQuid)
                    .ValueGeneratedNever()
                    .HasColumnName("temp_storeoffer quid");

                entity.Property(e => e.TempStoreMdid)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("temp_store mdid");

                entity.Property(e => e.TempStoreName)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("temp_store name");
            });

            modelBuilder.Entity<VwAllbrandscashbackdeal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_allbrandscashbackdeals", "dbo");

                entity.Property(e => e.CashBackDesc)
                    .HasMaxLength(73)
                    .HasColumnName("cash_back_desc");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("image_name");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("image_url");

                entity.Property(e => e.StoreMdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");

                entity.Property(e => e.StoreMdname)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_mdname");

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_name");

                entity.Property(e => e.StorecampaignGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storecampaign_guid");
            });

            modelBuilder.Entity<VwAllpopulardeal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_allpopulardeals", "dbo");

                entity.Property(e => e.CashBackDesc)
                    .HasMaxLength(58)
                    .HasColumnName("cash_back_desc");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("image_url");

                entity.Property(e => e.ImagesName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("images_name");

                entity.Property(e => e.OfferCouponCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("offer_coupon_code");

                entity.Property(e => e.OfferEndDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("offer_end_date");

                entity.Property(e => e.OfferTitle)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("offer_title");

                entity.Property(e => e.StoreMdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");

                entity.Property(e => e.StoreMdname)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_mdname");

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_name");

                entity.Property(e => e.StorecampaignGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storecampaign_guid");

                entity.Property(e => e.StoreofferGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storeoffer_guid");
            });

            modelBuilder.Entity<VwLkupcommcalctype>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_lkupcommcalctype", "dbo");

                entity.Property(e => e.CommCalcType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comm_calc_type");

                entity.Property(e => e.CommCalcTypeMdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("comm_calc_type_mdid");

                entity.Property(e => e.Comments)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("comments");

                entity.Property(e => e.LkupgroupcodeCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lkupgroupcode_code");

                entity.Property(e => e.LkupgroupcodeMdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lkupgroupcode_mdid");

                entity.Property(e => e.LkupgroupcodeMdname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lkupgroupcode_mdname");

                entity.Property(e => e.LkupgroupcodeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lkupgroupcode_name");

                entity.Property(e => e.LkuplistCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lkuplist_code");
            });

            modelBuilder.Entity<VwRecordstatustype>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_recordstatustype", "dbo");

                entity.Property(e => e.Comments)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("comments");

                entity.Property(e => e.LkupgroupcodeCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lkupgroupcode_code");

                entity.Property(e => e.LkupgroupcodeMdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lkupgroupcode_mdid");

                entity.Property(e => e.LkupgroupcodeMdname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lkupgroupcode_mdname");

                entity.Property(e => e.LkupgroupcodeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lkupgroupcode_name");

                entity.Property(e => e.LkuplistCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lkuplist_code");

                entity.Property(e => e.RecordStatusType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("record_status_type");

                entity.Property(e => e.RecordStatusTypeMdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("record_status_type_mdid");
            });

            modelBuilder.Entity<VwStoreCategoryOfferInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_store_category_offer_info", "dbo");

                entity.Property(e => e.AffiliateUrl)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("affiliate_url");

                entity.Property(e => e.BaseUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("base_url");

                entity.Property(e => e.CampaignActiveFlag).HasColumnName("campaign_active_flag");

                entity.Property(e => e.Category)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("image_url");

                entity.Property(e => e.IsPopularBrand).HasColumnName("is_popular_brand");

                entity.Property(e => e.IsTopBrand).HasColumnName("is_top_brand");

                entity.Property(e => e.IsTopStoreCashback).HasColumnName("is_top_store_cashback");

                entity.Property(e => e.LkuplistName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lkuplist_name");

                entity.Property(e => e.LogoLargeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("logo_large_name");

                entity.Property(e => e.LogoMediumName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("logo_medium_name");

                entity.Property(e => e.LogoSmallName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("logo_small_name");

                entity.Property(e => e.StoreActiveFlag).HasColumnName("store_active_flag");

                entity.Property(e => e.StoreCampaignUniqueRow).HasColumnName("store_campaign_unique_row");

                entity.Property(e => e.StoreCityLkupmdid)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_city_lkupmdid");

                entity.Property(e => e.StoreMaxCashBackDesc)
                    .HasMaxLength(37)
                    .IsUnicode(false)
                    .HasColumnName("store_max_cash_back_desc");

                entity.Property(e => e.StoreMdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");

                entity.Property(e => e.StoreMdname)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_mdname");

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_name");

                entity.Property(e => e.StoreStoreTypeUniqueRow).HasColumnName("store_store_type_unique_row");

                entity.Property(e => e.StoreTotalActiveCampaign).HasColumnName("store_total_active_campaign");

                entity.Property(e => e.StoreTypeLkupmdid)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_type_lkupmdid");

                entity.Property(e => e.StoreUniqueRow).HasColumnName("store_unique_row");

                entity.Property(e => e.StorecampaignGuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storecampaign_guid");

                entity.Property(e => e.StorecityMdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storecity_mdid");

                entity.Property(e => e.StorecityMdname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storecity_mdname");

                entity.Property(e => e.Storetype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("storetype");

                entity.Property(e => e.StoretypeActiveFlag).HasColumnName("storetype_active_flag");

                entity.Property(e => e.StoretypeMdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storetype_mdid");

                entity.Property(e => e.StoretypeMdname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storetype_mdname");

                entity.Property(e => e.StoretypeTotalActiveCampaign).HasColumnName("storetype_total_active_campaign");
            });

            modelBuilder.Entity<VwStoreCategoryOfferInfoBkp11042021>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_store_category_offer_info_bkp_11042021", "dbo");

                entity.Property(e => e.AffiliateUrl)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("affiliate_url");

                entity.Property(e => e.BaseUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("base_url");

                entity.Property(e => e.CampaignActiveFlag).HasColumnName("campaign_active_flag");

                entity.Property(e => e.Category)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("image_url");

                entity.Property(e => e.IsPopularBrand).HasColumnName("is_popular_brand");

                entity.Property(e => e.IsTopBrand).HasColumnName("is_top_brand");

                entity.Property(e => e.IsTopStoreCashback).HasColumnName("is_top_store_cashback");

                entity.Property(e => e.LogoLargeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("logo_large_name");

                entity.Property(e => e.LogoMediumName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("logo_medium_name");

                entity.Property(e => e.LogoSmallName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("logo_small_name");

                entity.Property(e => e.StoreActiveFlag).HasColumnName("store_active_flag");

                entity.Property(e => e.StoreCampaignUniqueRow).HasColumnName("store_campaign_unique_row");

                entity.Property(e => e.StoreMaxCashBackDesc)
                    .HasMaxLength(37)
                    .IsUnicode(false)
                    .HasColumnName("store_max_cash_back_desc");

                entity.Property(e => e.StoreMdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");

                entity.Property(e => e.StoreMdname)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_mdname");

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_name");

                entity.Property(e => e.StoreStoreTypeUniqueRow).HasColumnName("store_store_type_unique_row");

                entity.Property(e => e.StoreTotalActiveCampaign).HasColumnName("store_total_active_campaign");

                entity.Property(e => e.StoreTypeLkupmdid)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_type_lkupmdid");

                entity.Property(e => e.StoreUniqueRow).HasColumnName("store_unique_row");

                entity.Property(e => e.StorecampaignGuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storecampaign_guid");

                entity.Property(e => e.Storetype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("storetype");

                entity.Property(e => e.StoretypeActiveFlag).HasColumnName("storetype_active_flag");

                entity.Property(e => e.StoretypeMdid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storetype_mdid");

                entity.Property(e => e.StoretypeMdname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storetype_mdname");

                entity.Property(e => e.StoretypeTotalActiveCampaign).HasColumnName("storetype_total_active_campaign");
            });

            modelBuilder.Entity<VwStorecampaignmaxpayout>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_storecampaignmaxpayout", "dbo");

                entity.Property(e => e.CommCalcType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comm_calc_type");

                entity.Property(e => e.MaxCommPayout)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("max_comm_payout");

                entity.Property(e => e.StoreMdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");
            });

            modelBuilder.Entity<VwTodayspopulardeal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_todayspopulardeals", "dbo");

                entity.Property(e => e.CashBackDesc)
                    .HasMaxLength(58)
                    .HasColumnName("cash_back_desc");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("image_url");

                entity.Property(e => e.ImagesName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("images_name");

                entity.Property(e => e.OfferCouponCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("offer_coupon_code");

                entity.Property(e => e.OfferEndDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("offer_end_date");

                entity.Property(e => e.OfferTitle)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("offer_title");

                entity.Property(e => e.StoreMdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");

                entity.Property(e => e.StoreMdname)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_mdname");

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_name");

                entity.Property(e => e.StorecampaignGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storecampaign_guid");

                entity.Property(e => e.StoreofferGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storeoffer_guid");
            });

            modelBuilder.Entity<VwTopbrandscashbackdeal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_topbrandscashbackdeals", "dbo");

                entity.Property(e => e.CashBackDesc)
                    .HasMaxLength(73)
                    .HasColumnName("cash_back_desc");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("image_name");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("image_url");

                entity.Property(e => e.StoreMdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("store_mdid");

                entity.Property(e => e.StoreMdname)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_mdname");

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("store_name");

                entity.Property(e => e.StorecampaignGuid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storecampaign_guid");
            });

            modelBuilder.Entity<VwTopcategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_topcategories", "dbo");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("image_name");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("image_url");

                entity.Property(e => e.Storetype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("storetype");

                entity.Property(e => e.StoretypeMdid)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("storetype_mdid");
            });            

            modelBuilder.Entity<Tblemailnotificationbatch>(entity =>
            {
                entity.HasKey(e => e.BatchId);

                entity.ToTable("tblemailnotificationbatch", "dbo");

                entity.Property(e => e.BatchDate)
                    .HasColumnType("date")
                    .HasColumnName("batch_date");

                entity.Property(e => e.BatchEndDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("batch_end_datetime");

                entity.Property(e => e.BatchId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("batch_id");

                entity.Property(e => e.BatchStartDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("batch_start_datetime");

                entity.Property(e => e.BatchStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("batch_status");

                entity.Property(e => e.Comments)
                    .IsUnicode(false)
                    .HasColumnName("comments");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("created_by");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.FailureCount).HasColumnName("failure_count");

                entity.Property(e => e.SuccessCount).HasColumnName("success_count");

                entity.Property(e => e.TotalEmailCount).HasColumnName("total_email_count");

                entity.Property(e => e.BatchName).HasColumnName("batch_name");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("updated_by");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");
            });

            modelBuilder.Entity<TblRechargeTransaction>(entity =>
            {
                entity.HasKey(e => e.RechargeId)
                    .HasName("[PK_tblrechargetransaction]");
            
                entity.ToTable("tblrechargetransaction", "dbo");
                entity.Property(e => e.RechargeId).HasColumnName("recharge_id");
                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("reference_no");

                entity.Property(e => e.UserGuid)
                  .HasMaxLength(100)
                  .IsUnicode(false)
                  .HasColumnName("user_guid");
                entity.Property(e => e.RechargeMblNo)
                 .HasMaxLength(15)
                 .IsUnicode(false)
                 .HasColumnName("recharge_mobileno");
                entity.Property(e => e.TransactionId)
                 .HasMaxLength(60)
                 .IsUnicode(false)
                 .HasColumnName("ext_transaction_id");

                entity.Property(e => e.OperatorId)
                 .HasMaxLength(60)
                 .IsUnicode(false)
                 .HasColumnName("ext_Opr_id");

                entity.Property(e => e.TransactionDesc)
                 .HasMaxLength(int.MaxValue)
                 .IsUnicode(false)
                 .HasColumnName("ext_transaction_desc_lkupmdid");


                entity.Property(e => e.StatusMsg)
                 .HasMaxLength(60)
                 .IsUnicode(false)
                 .HasColumnName("ext_api_call_status_message");

                entity.Property(e => e.Operator)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ext_Operator");

                entity.Property(e => e.BalanceAmt)
             .HasColumnType("decimal")
             .HasColumnName("Cazhon_balance_amt");

                entity.Property(e => e.RechargeAmt)
             .HasColumnType("decimal")
             .HasColumnName("recharge_amt");

                entity.Property(e => e.AvailableWithdrawlAmt)
            .HasColumnType("decimal")
            .HasColumnName("avail_withdrawal_amount");

                entity.Property(e => e.BalanceWithdrawlAmt)
            .HasColumnType("decimal")
            .HasColumnName("balance_withdrawal_amount");

                entity.Property(e => e.RequestWithdrawlAmt)
            .HasColumnType("decimal")
            .HasColumnName("request_withdrawal_amount");
                entity.Property(e => e.CreateddateTime)
                               .HasColumnType("datetime")
                               .HasColumnName("createddatetime");

                entity.Property(e => e.UpdateddateTime)
                .HasColumnType("datetime")
                .HasColumnName("updateddatetime");



                entity.Property(e => e.CreateddateTimeUTC)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");


                entity.Property(e => e.UpdateddateTimeUTC)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");


            });

            modelBuilder.Entity<Tbloperator>(entity =>
            {
                entity.HasKey(e => e.OperatorValue);

                entity.ToTable("tbloperator", "dbo");

                entity.Property(e => e.OperatorValue)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("operator_value");

                entity.Property(e => e.Activeflag).HasColumnName("activeflag");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetime");

                entity.Property(e => e.Createddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("createddatetimeutc");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("image_name");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("image_url");

                entity.Property(e => e.OperatorDisplayname)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("operator_displayname");

                entity.Property(e => e.OperatorGuid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("operator_guid");

                entity.Property(e => e.Updateddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetime");

                entity.Property(e => e.Updateddatetimeutc)
                    .HasColumnType("datetime")
                    .HasColumnName("updateddatetimeutc");
            });

            modelBuilder.HasSequence("hibernate_sequence");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
