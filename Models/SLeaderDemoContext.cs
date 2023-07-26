using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Cap01App.Models;

public partial class SLeaderDemoContext : DbContext
{
    public SLeaderDemoContext()
    {
    }

    public SLeaderDemoContext(DbContextOptions<SLeaderDemoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ambarlar> Ambarlars { get; set; }

    public virtual DbSet<AmbarlarT> AmbarlarTs { get; set; }

    public virtual DbSet<Bankahesaplari> Bankahesaplaris { get; set; }

    public virtual DbSet<Belgeler> Belgelers { get; set; }

    public virtual DbSet<Bildirimler> Bildirimlers { get; set; }

    public virtual DbSet<Birimler> Birimlers { get; set; }

    public virtual DbSet<BirimlerT> BirimlerTs { get; set; }

    public virtual DbSet<Birimsetler> Birimsetlers { get; set; }

    public virtual DbSet<BirimsetlerT> BirimsetlerTs { get; set; }

    public virtual DbSet<Bolumler> Bolumlers { get; set; }

    public virtual DbSet<BolumlerT> BolumlerTs { get; set; }

    public virtual DbSet<Borctakip> Borctakips { get; set; }

    public virtual DbSet<BorctakipT> BorctakipTs { get; set; }

    public virtual DbSet<Borcyaslandirmaraporu> Borcyaslandirmaraporus { get; set; }

    public virtual DbSet<Bulunurlukolcum> Bulunurlukolcums { get; set; }

    public virtual DbSet<Bulunurluksinif> Bulunurluksinifs { get; set; }

    public virtual DbSet<Bulunurlukurunleri> Bulunurlukurunleris { get; set; }

    public virtual DbSet<Cariistatistik> Cariistatistiks { get; set; }

    public virtual DbSet<Cariler> Carilers { get; set; }

    public virtual DbSet<CarilerT> CarilerTs { get; set; }

    public virtual DbSet<Dovizler> Dovizlers { get; set; }

    public virtual DbSet<DovizlerT> DovizlerTs { get; set; }

    public virtual DbSet<Duyurular> Duyurulars { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Faturalar> Faturalars { get; set; }

    public virtual DbSet<FaturalarT> FaturalarTs { get; set; }

    public virtual DbSet<Faturasatirlari> Faturasatirlaris { get; set; }

    public virtual DbSet<FaturasatirlariT> FaturasatirlariTs { get; set; }

    public virtual DbSet<Faturaturleri> Faturaturleris { get; set; }

    public virtual DbSet<Fisturleri> Fisturleris { get; set; }

    public virtual DbSet<Fiyatlar> Fiyatlars { get; set; }

    public virtual DbSet<FiyatlarT> FiyatlarTs { get; set; }

    public virtual DbSet<Goruntuluarama> Goruntuluaramas { get; set; }

    public virtual DbSet<Hatirlaticilar> Hatirlaticilars { get; set; }

    public virtual DbSet<Hedefler> Hedeflers { get; set; }

    public virtual DbSet<Hedefrealize> Hedefrealizes { get; set; }

    public virtual DbSet<Hedeftipleri> Hedeftipleris { get; set; }

    public virtual DbSet<Iadesebepleri> Iadesebepleris { get; set; }

    public virtual DbSet<Iskontolar> Iskontolars { get; set; }

    public virtual DbSet<Isyerleri> Isyerleris { get; set; }

    public virtual DbSet<Kampanyadetaylari> Kampanyadetaylaris { get; set; }

    public virtual DbSet<Kampanyalar> Kampanyalars { get; set; }

    public virtual DbSet<Kampanyatipleri> Kampanyatipleris { get; set; }

    public virtual DbSet<Kapsamkontrol> Kapsamkontrols { get; set; }

    public virtual DbSet<Kasalar> Kasalars { get; set; }

    public virtual DbSet<Klasorler> Klasorlers { get; set; }

    public virtual DbSet<Konumlar> Konumlars { get; set; }

    public virtual DbSet<Liderpanosu> Liderpanosus { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<Loglar> Loglars { get; set; }

    public virtual DbSet<Mesajlar> Mesajlars { get; set; }

    public virtual DbSet<Mesajlardetay> Mesajlardetays { get; set; }

    public virtual DbSet<Musteritipleri> Musteritipleris { get; set; }

    public virtual DbSet<MusteritipleriT> MusteritipleriTs { get; set; }

    public virtual DbSet<Odemeplanlari> Odemeplanlaris { get; set; }

    public virtual DbSet<OdemeplanlariT> OdemeplanlariTs { get; set; }

    public virtual DbSet<Parametreler> Parametrelers { get; set; }

    public virtual DbSet<Periyotlar> Periyotlars { get; set; }

    public virtual DbSet<Pskuliste> Pskulistes { get; set; }

    public virtual DbSet<Pskurapor> Pskurapors { get; set; }

    public virtual DbSet<Pskusati> Pskusatis { get; set; }

    public virtual DbSet<Pskuurunlistesi> Pskuurunlistesis { get; set; }

    public virtual DbSet<RotaOlusturStListe> RotaOlusturStListes { get; set; }

    public virtual DbSet<RutGunMevcut> RutGunMevcuts { get; set; }

    public virtual DbSet<Sanalasistan> Sanalasistans { get; set; }

    public virtual DbSet<Satistemsilcileri> Satistemsilcileris { get; set; }

    public virtual DbSet<SatistemsilcileriT> SatistemsilcileriTs { get; set; }

    public virtual DbSet<Sepet> Sepets { get; set; }

    public virtual DbSet<Servisseviyesi> Servisseviyesis { get; set; }

    public virtual DbSet<Servisseviyesi1> Servisseviyesis1 { get; set; }

    public virtual DbSet<Sevkadresleri> Sevkadresleris { get; set; }

    public virtual DbSet<SevkadresleriT> SevkadresleriTs { get; set; }

    public virtual DbSet<SiparisReferan> SiparisReferans { get; set; }

    public virtual DbSet<SiparisReferanslar> SiparisReferanslars { get; set; }

    public virtual DbSet<Siparisler> Siparislers { get; set; }

    public virtual DbSet<SiparislerT> SiparislerTs { get; set; }

    public virtual DbSet<Siparissatirlari> Siparissatirlaris { get; set; }

    public virtual DbSet<SiparissatirlariT> SiparissatirlariTs { get; set; }

    public virtual DbSet<Stistatistik> Stistatistiks { get; set; }

    public virtual DbSet<StistatistikEski> StistatistikEskis { get; set; }

    public virtual DbSet<Stoklar> Stoklars { get; set; }

    public virtual DbSet<StoklarT> StoklarTs { get; set; }

    public virtual DbSet<Stokraporu> Stokraporus { get; set; }

    public virtual DbSet<StokraporuT> StokraporuTs { get; set; }

    public virtual DbSet<Strut> Struts { get; set; }

    public virtual DbSet<Strutgun> Strutguns { get; set; }

    public virtual DbSet<Strutziyaretplan> Strutziyaretplans { get; set; }

    public virtual DbSet<Tahsilatlar> Tahsilatlars { get; set; }

    public virtual DbSet<Tahsilatperforman> Tahsilatperformans { get; set; }

    public virtual DbSet<Tahsilatturleri> Tahsilatturleris { get; set; }

    public virtual DbSet<Takvim> Takvims { get; set; }

    public virtual DbSet<Talepler> Taleplers { get; set; }

    public virtual DbSet<Talepsatirlari> Talepsatirlaris { get; set; }

    public virtual DbSet<Tanimlamalar> Tanimlamalars { get; set; }

    public virtual DbSet<Urunbirimleri> Urunbirimleris { get; set; }

    public virtual DbSet<UrunbirimleriT> UrunbirimleriTs { get; set; }

    public virtual DbSet<Urunkategorileri> Urunkategorileris { get; set; }

    public virtual DbSet<Urunler> Urunlers { get; set; }

    public virtual DbSet<UrunlerT> UrunlerTs { get; set; }

    public virtual DbSet<ZiyaretPerforman> ZiyaretPerformans { get; set; }

    public virtual DbSet<Ziyaretler> Ziyaretlers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=188.132.151.143;Database=S_Leader_Demo;Trusted_Connection=False;User ID=sa;Password=@Martek2024;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ambarlar>(entity =>
        {
            entity.ToTable("AMBARLAR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ambarnr).HasColumnName("AMBARNR");
            entity.Property(e => e.Ambarref).HasColumnName("AMBARREF");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Isim)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("ISIM");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<AmbarlarT>(entity =>
        {
            entity.ToTable("AMBARLAR_T");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ambarnr).HasColumnName("AMBARNR");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Isim)
                .HasMaxLength(50)
                .HasColumnName("ISIM");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<Bankahesaplari>(entity =>
        {
            entity.ToTable("BANKAHESAPLARI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bakahesapturu)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("BAKAHESAPTURU");
            entity.Property(e => e.Bankaadi)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("BANKAADI");
            entity.Property(e => e.Bankahesapadi)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("BANKAHESAPADI");
            entity.Property(e => e.Bankahesapkodu)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("BANKAHESAPKODU");
            entity.Property(e => e.Bankahesapref).HasColumnName("BANKAHESAPREF");
            entity.Property(e => e.Bankahesapturnr).HasColumnName("BANKAHESAPTURNR");
            entity.Property(e => e.Bankakodu)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("BANKAKODU");
            entity.Property(e => e.Bankaref).HasColumnName("BANKAREF");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.Muhasebekodu)
                .HasMaxLength(101)
                .HasDefaultValueSql("('')")
                .HasColumnName("MUHASEBEKODU");
        });

        modelBuilder.Entity<Belgeler>(entity =>
        {
            entity.ToTable("BELGELER");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Baslik).HasColumnName("BASLIK");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Isim).HasColumnName("ISIM");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Klasorid).HasColumnName("KLASORID");
            entity.Property(e => e.Kullaniciid).HasColumnName("KULLANICIID");
            entity.Property(e => e.Link).HasColumnName("LINK");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<Bildirimler>(entity =>
        {
            entity.ToTable("BILDIRIMLER");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Kullaniciid).HasColumnName("KULLANICIID");
            entity.Property(e => e.Mesaj).HasColumnName("MESAJ");
            entity.Property(e => e.Tarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Birimler>(entity =>
        {
            entity.ToTable("BIRIMLER");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Anabirim).HasColumnName("ANABIRIM");
            entity.Property(e => e.Birimref).HasColumnName("BIRIMREF");
            entity.Property(e => e.Birimsetid).HasColumnName("BIRIMSETID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Isim)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("KOD");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<BirimlerT>(entity =>
        {
            entity.ToTable("BIRIMLER_T");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Anabirim).HasColumnName("ANABIRIM");
            entity.Property(e => e.Birimref).HasColumnName("BIRIMREF");
            entity.Property(e => e.Birimsetid).HasColumnName("BIRIMSETID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Isim)
                .HasMaxLength(50)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .HasColumnName("KOD");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<Birimsetler>(entity =>
        {
            entity.ToTable("BIRIMSETLER");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Isim)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("KOD");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<BirimsetlerT>(entity =>
        {
            entity.ToTable("BIRIMSETLER_T");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Isim)
                .HasMaxLength(50)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .HasColumnName("KOD");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<Bolumler>(entity =>
        {
            entity.ToTable("BOLUMLER");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bolum)
                .HasMaxLength(61)
                .IsUnicode(false)
                .HasColumnName("BOLUM");
            entity.Property(e => e.Bolumnr).HasColumnName("BOLUMNR");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Kanal).HasColumnName("KANAL");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("datetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<BolumlerT>(entity =>
        {
            entity.ToTable("BOLUMLER_T");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bolum)
                .HasMaxLength(20)
                .HasColumnName("BOLUM");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Kanal).HasColumnName("KANAL");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<Borctakip>(entity =>
        {
            entity.ToTable("BORCTAKIP");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(251)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Alacak).HasColumnName("ALACAK");
            entity.Property(e => e.Borc).HasColumnName("BORC");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.Cariref).HasColumnName("CARIREF");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Doviz)
                .HasMaxLength(50)
                .HasColumnName("DOVIZ");
            entity.Property(e => e.Fisno)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("FISNO");
            entity.Property(e => e.Fisturudetay)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FISTURUDETAY");
            entity.Property(e => e.Fisturuid).HasColumnName("FISTURUID");
            entity.Property(e => e.Isyeri).HasColumnName("ISYERI");
            entity.Property(e => e.Kalan).HasColumnName("KALAN");
            entity.Property(e => e.Kapali).HasColumnName("KAPALI");
            entity.Property(e => e.Kapanan).HasColumnName("KAPANAN");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Stref).HasColumnName("STREF");
            entity.Property(e => e.Tarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Vadetarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("VADETARIHI");
        });

        modelBuilder.Entity<BorctakipT>(entity =>
        {
            entity.ToTable("BORCTAKIP_T");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Alacak)
                .HasColumnType("money")
                .HasColumnName("ALACAK");
            entity.Property(e => e.Ay).HasColumnName("AY");
            entity.Property(e => e.Borc)
                .HasColumnType("money")
                .HasColumnName("BORC");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.Cariref).HasColumnName("CARIREF");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Doviz)
                .HasMaxLength(20)
                .HasColumnName("DOVIZ");
            entity.Property(e => e.Fisno)
                .HasMaxLength(50)
                .HasColumnName("FISNO");
            entity.Property(e => e.Fisturudetay)
                .HasMaxLength(50)
                .HasColumnName("FISTURUDETAY");
            entity.Property(e => e.Fisturuid).HasColumnName("FISTURUID");
            entity.Property(e => e.Isyeri).HasColumnName("ISYERI");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Kalan)
                .HasColumnType("money")
                .HasColumnName("KALAN");
            entity.Property(e => e.Kapali).HasColumnName("KAPALI");
            entity.Property(e => e.Kapanan)
                .HasColumnType("money")
                .HasColumnName("KAPANAN");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Stref).HasColumnName("STREF");
            entity.Property(e => e.Tarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Vadetarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("VADETARIHI");
            entity.Property(e => e.Yil).HasColumnName("YIL");
        });

        modelBuilder.Entity<Borcyaslandirmaraporu>(entity =>
        {
            entity.ToTable("BORCYASLANDIRMARAPORU");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Alacak)
                .HasColumnType("money")
                .HasColumnName("ALACAK");
            entity.Property(e => e.Ay).HasColumnName("AY");
            entity.Property(e => e.Bakiye)
                .HasColumnType("money")
                .HasColumnName("BAKIYE");
            entity.Property(e => e.Borc)
                .HasColumnType("money")
                .HasColumnName("BORC");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Yil).HasColumnName("YIL");
        });

        modelBuilder.Entity<Bulunurlukolcum>(entity =>
        {
            entity.ToTable("BULUNURLUKOLCUM");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bulunurluk).HasColumnName("BULUNURLUK");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.Rafpayi)
                .HasColumnType("decimal(3, 0)")
                .HasColumnName("RAFPAYI");
            entity.Property(e => e.Sevkid).HasColumnName("SEVKID");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Tarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Urunid).HasColumnName("URUNID");
            entity.Property(e => e.Ziyaretid).HasColumnName("ZIYARETID");
            entity.Property(e => e.Ziyaretuid)
                .HasMaxLength(50)
                .HasColumnName("ZIYARETUID");
        });

        modelBuilder.Entity<Bulunurluksinif>(entity =>
        {
            entity.ToTable("BULUNURLUKSINIF");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(50)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Bastar)
                .HasColumnType("date")
                .HasColumnName("BASTAR");
            entity.Property(e => e.Bittar)
                .HasColumnType("date")
                .HasColumnName("BITTAR");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Kullaniciid).HasColumnName("KULLANICIID");
            entity.Property(e => e.Periyot).HasColumnName("PERIYOT");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<Bulunurlukurunleri>(entity =>
        {
            entity.ToTable("BULUNURLUKURUNLERI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Firma)
                .HasMaxLength(50)
                .HasColumnName("FIRMA");
            entity.Property(e => e.Kullaniciid).HasColumnName("KULLANICIID");
            entity.Property(e => e.Marka)
                .HasMaxLength(50)
                .HasColumnName("MARKA");
            entity.Property(e => e.Sinifid).HasColumnName("SINIFID");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Urunadi)
                .HasMaxLength(100)
                .HasColumnName("URUNADI");
            entity.Property(e => e.Urunkodu)
                .HasMaxLength(50)
                .HasColumnName("URUNKODU");
        });

        modelBuilder.Entity<Cariistatistik>(entity =>
        {
            entity.ToTable("CARIISTATISTIK");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ay).HasColumnName("AY");
            entity.Property(e => e.Bakiye)
                .HasColumnType("money")
                .HasColumnName("BAKIYE");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.Ciroix)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("CIROIX");
            entity.Property(e => e.Gecikenbakiye)
                .HasColumnType("money")
                .HasColumnName("GECIKENBAKIYE");
            entity.Property(e => e.Guncelrisk)
                .HasColumnType("money")
                .HasColumnName("GUNCELRISK");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Markaoran)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("MARKAORAN");
            entity.Property(e => e.Pskuoran)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("PSKUORAN");
            entity.Property(e => e.Pskusatilanlar).HasColumnName("PSKUSATILANLAR");
            entity.Property(e => e.Pskusayisisatilan).HasColumnName("PSKUSAYISISATILAN");
            entity.Property(e => e.Pskusayisitoplam).HasColumnName("PSKUSAYISITOPLAM");
            entity.Property(e => e.Risklimiti)
                .HasColumnType("money")
                .HasColumnName("RISKLIMITI");
            entity.Property(e => e.Satisdurum).HasColumnName("SATISDURUM");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("datetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Yil).HasColumnName("YIL");
            entity.Property(e => e.Ziyaretortalamasure).HasColumnName("ZIYARETORTALAMASURE");
        });

        modelBuilder.Entity<Cariler>(entity =>
        {
            entity.ToTable("CARILER");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adres)
                .HasMaxLength(403)
                .HasColumnName("ADRES");
            entity.Property(e => e.Aktarim).HasColumnName("AKTARIM");
            entity.Property(e => e.Bakiye).HasColumnName("BAKIYE");
            entity.Property(e => e.Bolge)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("BOLGE");
            entity.Property(e => e.Cariref).HasColumnName("CARIREF");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.Efatura).HasColumnName("EFATURA");
            entity.Property(e => e.Eposta)
                .HasMaxLength(251)
                .IsUnicode(false)
                .HasColumnName("EPOSTA");
            entity.Property(e => e.Eposta2)
                .HasMaxLength(251)
                .IsUnicode(false)
                .HasColumnName("EPOSTA2");
            entity.Property(e => e.Faks)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("FAKS");
            entity.Property(e => e.Grupkodu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("GRUPKODU");
            entity.Property(e => e.Gsm)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("GSM");
            entity.Property(e => e.Gsm2)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("GSM2");
            entity.Property(e => e.Guncelrisk)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("GUNCELRISK");
            entity.Property(e => e.Ilce)
                .HasMaxLength(50)
                .HasColumnName("ILCE");
            entity.Property(e => e.Ilgili)
                .HasMaxLength(50)
                .HasColumnName("ILGILI");
            entity.Property(e => e.Ilgili2)
                .HasMaxLength(50)
                .HasColumnName("ILGILI2");
            entity.Property(e => e.Indirimkod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("INDIRIMKOD");
            entity.Property(e => e.Kampanyakod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("KAMPANYAKOD");
            entity.Property(e => e.Kanal1)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("KANAL1");
            entity.Property(e => e.Kanal2)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("KANAL2");
            entity.Property(e => e.Kanal3)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("KANAL3");
            entity.Property(e => e.Kanal4)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("KANAL4");
            entity.Property(e => e.Kanal5)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("KANAL5");
            entity.Property(e => e.Kodu)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("KODU");
            entity.Property(e => e.Latitude)
                .HasColumnType("decimal(12, 8)")
                .HasColumnName("LATITUDE");
            entity.Property(e => e.Longitude)
                .HasColumnType("decimal(12, 8)")
                .HasColumnName("LONGITUDE");
            entity.Property(e => e.Muhkodu)
                .HasMaxLength(101)
                .IsUnicode(false)
                .HasColumnName("MUHKODU");
            entity.Property(e => e.Onay).HasColumnName("ONAY");
            entity.Property(e => e.Opaciklama)
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("OPACIKLAMA");
            entity.Property(e => e.Opkodu)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("OPKODU");
            entity.Property(e => e.Opref).HasColumnName("OPREF");
            entity.Property(e => e.Ozelalan1)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("OZELALAN1");
            entity.Property(e => e.Ozelalan2)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("OZELALAN2");
            entity.Property(e => e.Ozelalan3)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("OZELALAN3");
            entity.Property(e => e.Ozelalan4)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("OZELALAN4");
            entity.Property(e => e.Ozelalan5)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("OZELALAN5");
            entity.Property(e => e.Risklimiti)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("RISKLIMITI");
            entity.Property(e => e.Sehir)
                .HasMaxLength(50)
                .HasColumnName("SEHIR");
            entity.Property(e => e.Sevkadresref).HasColumnName("SEVKADRESREF");
            entity.Property(e => e.Sipariseacik).HasColumnName("SIPARISEACIK");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Tel)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("TEL");
            entity.Property(e => e.Ticislgrb)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("TICISLGRB");
            entity.Property(e => e.Ulke)
                .HasMaxLength(50)
                .HasColumnName("ULKE");
            entity.Property(e => e.Unvani)
                .HasMaxLength(201)
                .HasColumnName("UNVANI");
            entity.Property(e => e.Vdairesi)
                .HasMaxLength(50)
                .HasColumnName("VDAIRESI");
            entity.Property(e => e.Vno)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("VNO");
            entity.Property(e => e.Yetkikodu)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("YETKIKODU");
        });

        modelBuilder.Entity<CarilerT>(entity =>
        {
            entity.ToTable("CARILER_T");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adres).HasColumnName("ADRES");
            entity.Property(e => e.Aktarim).HasColumnName("AKTARIM");
            entity.Property(e => e.Bolge)
                .HasMaxLength(30)
                .HasColumnName("BOLGE");
            entity.Property(e => e.Cariref).HasColumnName("CARIREF");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.Efatura).HasColumnName("EFATURA");
            entity.Property(e => e.Eposta)
                .HasMaxLength(250)
                .HasColumnName("EPOSTA");
            entity.Property(e => e.Eposta2)
                .HasMaxLength(250)
                .HasColumnName("EPOSTA2");
            entity.Property(e => e.Faks)
                .HasMaxLength(50)
                .HasColumnName("FAKS");
            entity.Property(e => e.Fotograf1).HasColumnName("FOTOGRAF1");
            entity.Property(e => e.Fotograf2).HasColumnName("FOTOGRAF2");
            entity.Property(e => e.Fotograf3).HasColumnName("FOTOGRAF3");
            entity.Property(e => e.Fotograf4).HasColumnName("FOTOGRAF4");
            entity.Property(e => e.Fotograf5).HasColumnName("FOTOGRAF5");
            entity.Property(e => e.Grupkodu)
                .HasMaxLength(50)
                .HasColumnName("GRUPKODU");
            entity.Property(e => e.Gsm)
                .HasMaxLength(50)
                .HasColumnName("GSM");
            entity.Property(e => e.Gsm2)
                .HasMaxLength(20)
                .HasColumnName("GSM2");
            entity.Property(e => e.GuncellendiMi).HasColumnName("GUNCELLENDI_MI");
            entity.Property(e => e.GuncellenecekMi).HasColumnName("GUNCELLENECEK_MI");
            entity.Property(e => e.Ilce)
                .HasMaxLength(50)
                .HasColumnName("ILCE");
            entity.Property(e => e.Ilgili)
                .HasMaxLength(50)
                .HasColumnName("ILGILI");
            entity.Property(e => e.Ilgili2)
                .HasMaxLength(50)
                .HasColumnName("ILGILI2");
            entity.Property(e => e.Indirimkod)
                .HasMaxLength(5)
                .HasColumnName("INDIRIMKOD");
            entity.Property(e => e.Islem)
                .HasMaxLength(50)
                .HasColumnName("ISLEM");
            entity.Property(e => e.Kampanyakod)
                .HasMaxLength(5)
                .HasColumnName("KAMPANYAKOD");
            entity.Property(e => e.Kanal1)
                .HasMaxLength(50)
                .HasColumnName("KANAL1");
            entity.Property(e => e.Kanal2)
                .HasMaxLength(50)
                .HasColumnName("KANAL2");
            entity.Property(e => e.Kanal3)
                .HasMaxLength(50)
                .HasColumnName("KANAL3");
            entity.Property(e => e.Kanal4)
                .HasMaxLength(50)
                .HasColumnName("KANAL4");
            entity.Property(e => e.Kanal5)
                .HasMaxLength(50)
                .HasColumnName("KANAL5");
            entity.Property(e => e.Kayittarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("KAYITTARIHI");
            entity.Property(e => e.Kodu)
                .HasMaxLength(20)
                .HasColumnName("KODU");
            entity.Property(e => e.Latitude)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("LATITUDE");
            entity.Property(e => e.Longitude)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("LONGITUDE");
            entity.Property(e => e.Muhkodu)
                .HasMaxLength(50)
                .HasColumnName("MUHKODU");
            entity.Property(e => e.Not)
                .HasDefaultValueSql("('')")
                .HasColumnName("NOT");
            entity.Property(e => e.Onay).HasColumnName("ONAY");
            entity.Property(e => e.Opaciklama)
                .HasMaxLength(250)
                .HasColumnName("OPACIKLAMA");
            entity.Property(e => e.Opkodu)
                .HasMaxLength(50)
                .HasColumnName("OPKODU");
            entity.Property(e => e.Ozelalan1)
                .HasMaxLength(50)
                .HasColumnName("OZELALAN1");
            entity.Property(e => e.Ozelalan2)
                .HasMaxLength(50)
                .HasColumnName("OZELALAN2");
            entity.Property(e => e.Ozelalan3)
                .HasMaxLength(50)
                .HasColumnName("OZELALAN3");
            entity.Property(e => e.Ozelalan4)
                .HasMaxLength(50)
                .HasColumnName("OZELALAN4");
            entity.Property(e => e.Ozelalan5)
                .HasMaxLength(50)
                .HasColumnName("OZELALAN5");
            entity.Property(e => e.Risklimiti)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("RISKLIMITI");
            entity.Property(e => e.Sehir)
                .HasMaxLength(50)
                .HasColumnName("SEHIR");
            entity.Property(e => e.Sevkadresref).HasColumnName("SEVKADRESREF");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Tel)
                .HasMaxLength(50)
                .HasColumnName("TEL");
            entity.Property(e => e.Ticislgrb)
                .HasMaxLength(50)
                .HasColumnName("TICISLGRB");
            entity.Property(e => e.Ulke)
                .HasMaxLength(50)
                .HasColumnName("ULKE");
            entity.Property(e => e.Unvani)
                .HasMaxLength(250)
                .HasColumnName("UNVANI");
            entity.Property(e => e.Vdairesi)
                .HasMaxLength(50)
                .HasColumnName("VDAIRESI");
            entity.Property(e => e.Vno)
                .HasMaxLength(20)
                .HasColumnName("VNO");
            entity.Property(e => e.Yetkikodu)
                .HasMaxLength(50)
                .HasColumnName("YETKIKODU");
        });

        modelBuilder.Entity<Dovizler>(entity =>
        {
            entity.ToTable("DOVIZLER");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Doviz)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("DOVIZ");
            entity.Property(e => e.Kod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("KOD");
            entity.Property(e => e.Kur1).HasColumnName("KUR1");
            entity.Property(e => e.Kur2).HasColumnName("KUR2");
            entity.Property(e => e.Kur3).HasColumnName("KUR3");
            entity.Property(e => e.Kur4).HasColumnName("KUR4");
            entity.Property(e => e.Nr).HasColumnName("NR");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<DovizlerT>(entity =>
        {
            entity.ToTable("DOVIZLER_T");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Doviz)
                .HasMaxLength(50)
                .HasColumnName("DOVIZ");
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .HasColumnName("KOD");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<Duyurular>(entity =>
        {
            entity.ToTable("DUYURULAR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Baslik)
                .HasMaxLength(250)
                .HasColumnName("BASLIK");
            entity.Property(e => e.Bastarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("BASTARIH");
            entity.Property(e => e.Bittarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("BITTARIH");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Duyuru).HasColumnName("DUYURU");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Kayittarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYITTARIHI");
            entity.Property(e => e.Kullaniciid)
                .HasMaxLength(4000)
                .HasColumnName("KULLANICIID");
            entity.Property(e => e.Okuyanstler).HasColumnName("OKUYANSTLER");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("datetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK_TAKVIM");

            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.AllDay).HasColumnName("all_day");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.EventEnd)
                .HasColumnType("datetime")
                .HasColumnName("event_end");
            entity.Property(e => e.EventStart)
                .HasColumnType("datetime")
                .HasColumnName("event_start");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Renk)
                .HasMaxLength(50)
                .HasColumnName("RENK");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Faturalar>(entity =>
        {
            entity.ToTable("FATURALAR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ambarid).HasColumnName("AMBARID");
            entity.Property(e => e.Ay).HasColumnName("AY");
            entity.Property(e => e.Belgeno)
                .HasMaxLength(33)
                .IsUnicode(false)
                .HasColumnName("BELGENO");
            entity.Property(e => e.Bruttutar).HasColumnName("BRUTTUTAR");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Dovizid).HasColumnName("DOVIZID");
            entity.Property(e => e.Faturano)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("FATURANO");
            entity.Property(e => e.Faturaref).HasColumnName("FATURAREF");
            entity.Property(e => e.Faturaturid).HasColumnName("FATURATURID");
            entity.Property(e => e.Indirim).HasColumnName("INDIRIM");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Kayittarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("KAYITTARIHI");
            entity.Property(e => e.Kdv).HasColumnName("KDV");
            entity.Property(e => e.Kur).HasColumnName("KUR");
            entity.Property(e => e.Miktar).HasColumnName("MIKTAR");
            entity.Property(e => e.Musteriid).HasColumnName("MUSTERIID");
            entity.Property(e => e.Nettutar).HasColumnName("NETTUTAR");
            entity.Property(e => e.Odemeplanid).HasColumnName("ODEMEPLANID");
            entity.Property(e => e.Sevkref).HasColumnName("SEVKREF");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Tarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tur)
                .HasMaxLength(20)
                .HasColumnName("TUR");
            entity.Property(e => e.Yil).HasColumnName("YIL");
        });

        modelBuilder.Entity<FaturalarT>(entity =>
        {
            entity.ToTable("FATURALAR_T");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktarimdurum).HasColumnName("AKTARIMDURUM");
            entity.Property(e => e.Ambar)
                .HasMaxLength(50)
                .HasColumnName("AMBAR");
            entity.Property(e => e.Ambarid).HasColumnName("AMBARID");
            entity.Property(e => e.Ay).HasColumnName("AY");
            entity.Property(e => e.Belgeno)
                .HasMaxLength(50)
                .HasColumnName("BELGENO");
            entity.Property(e => e.Bruttutar)
                .HasColumnType("money")
                .HasColumnName("BRUTTUTAR");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Dovizid).HasColumnName("DOVIZID");
            entity.Property(e => e.Faturano)
                .HasMaxLength(50)
                .HasColumnName("FATURANO");
            entity.Property(e => e.Faturaref).HasColumnName("FATURAREF");
            entity.Property(e => e.Faturaturid).HasColumnName("FATURATURID");
            entity.Property(e => e.Iadesebebi)
                .HasMaxLength(50)
                .HasColumnName("IADESEBEBI");
            entity.Property(e => e.Iadeyialan)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IADEYIALAN");
            entity.Property(e => e.Indirim)
                .HasColumnType("money")
                .HasColumnName("INDIRIM");
            entity.Property(e => e.Iptal).HasColumnName("IPTAL");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Kayittarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("KAYITTARIHI");
            entity.Property(e => e.Kdv)
                .HasColumnType("money")
                .HasColumnName("KDV");
            entity.Property(e => e.Kdvtutari)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("KDVTUTARI");
            entity.Property(e => e.Kur)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("KUR");
            entity.Property(e => e.Miktar)
                .HasColumnType("money")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Musteriid).HasColumnName("MUSTERIID");
            entity.Property(e => e.Nettutar)
                .HasColumnType("money")
                .HasColumnName("NETTUTAR");
            entity.Property(e => e.Odemeplani)
                .HasMaxLength(50)
                .HasColumnName("ODEMEPLANI");
            entity.Property(e => e.Onay1).HasColumnName("ONAY1");
            entity.Property(e => e.Onaydurum).HasColumnName("ONAYDURUM");
            entity.Property(e => e.Sayfasayisi).HasColumnName("SAYFASAYISI");
            entity.Property(e => e.Sevkid).HasColumnName("SEVKID");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Tamamla)
                .HasDefaultValueSql("((0))")
                .HasColumnName("TAMAMLA");
            entity.Property(e => e.Tarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tur)
                .HasMaxLength(50)
                .HasColumnName("TUR");
            entity.Property(e => e.Uid)
                .HasMaxLength(50)
                .HasColumnName("UID");
            entity.Property(e => e.Yil).HasColumnName("YIL");
        });

        modelBuilder.Entity<Faturasatirlari>(entity =>
        {
            entity.ToTable("FATURASATIRLARI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ambarid).HasColumnName("AMBARID");
            entity.Property(e => e.Ay).HasColumnName("AY");
            entity.Property(e => e.Birimfiyat).HasColumnName("BIRIMFIYAT");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Bruttutar).HasColumnName("BRUTTUTAR");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Dovizid).HasColumnName("DOVIZID");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.Faturaturid).HasColumnName("FATURATURID");
            entity.Property(e => e.Indirim).HasColumnName("INDIRIM");
            entity.Property(e => e.Irsaliyebelgeno)
                .HasMaxLength(33)
                .IsUnicode(false)
                .HasColumnName("IRSALIYEBELGENO");
            entity.Property(e => e.Irsaliyeno)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("IRSALIYENO");
            entity.Property(e => e.Irsaliyeref).HasColumnName("IRSALIYEREF");
            entity.Property(e => e.Kampanyadetayid).HasColumnName("KAMPANYADETAYID");
            entity.Property(e => e.Kayittarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("KAYITTARIHI");
            entity.Property(e => e.Kdv).HasColumnName("KDV");
            entity.Property(e => e.Kur).HasColumnName("KUR");
            entity.Property(e => e.Miktar).HasColumnName("MIKTAR");
            entity.Property(e => e.Nettutar).HasColumnName("NETTUTAR");
            entity.Property(e => e.Satiraciklama)
                .HasMaxLength(251)
                .IsUnicode(false)
                .HasColumnName("SATIRACIKLAMA");
            entity.Property(e => e.Satirref).HasColumnName("SATIRREF");
            entity.Property(e => e.Satirturu).HasColumnName("SATIRTURU");
            entity.Property(e => e.Sevkid).HasColumnName("SEVKID");
            entity.Property(e => e.Siparisid).HasColumnName("SIPARISID");
            entity.Property(e => e.Siparisno)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("SIPARISNO");
            entity.Property(e => e.Siparisref).HasColumnName("SIPARISREF");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Tarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Urunid).HasColumnName("URUNID");
            entity.Property(e => e.Urunref).HasColumnName("URUNREF");
            entity.Property(e => e.Yil).HasColumnName("YIL");
        });

        modelBuilder.Entity<FaturasatirlariT>(entity =>
        {
            entity.ToTable("FATURASATIRLARI_T");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ambarid).HasColumnName("AMBARID");
            entity.Property(e => e.Ay).HasColumnName("AY");
            entity.Property(e => e.Birimfiyat)
                .HasColumnType("money")
                .HasColumnName("BIRIMFIYAT");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Bruttutar)
                .HasColumnType("money")
                .HasColumnName("BRUTTUTAR");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Dovizid).HasColumnName("DOVIZID");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.Faturaturid).HasColumnName("FATURATURID");
            entity.Property(e => e.Indirim)
                .HasColumnType("money")
                .HasColumnName("INDIRIM");
            entity.Property(e => e.Indirimorani)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("INDIRIMORANI");
            entity.Property(e => e.Irsaliyebelgeno)
                .HasMaxLength(50)
                .HasColumnName("IRSALIYEBELGENO");
            entity.Property(e => e.Irsaliyeno)
                .HasMaxLength(50)
                .HasColumnName("IRSALIYENO");
            entity.Property(e => e.Irsaliyeref).HasColumnName("IRSALIYEREF");
            entity.Property(e => e.Kampanyadetayid).HasColumnName("KAMPANYADETAYID");
            entity.Property(e => e.Kayittarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("KAYITTARIHI");
            entity.Property(e => e.Kdv)
                .HasColumnType("money")
                .HasColumnName("KDV");
            entity.Property(e => e.Kdvorani)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("KDVORANI");
            entity.Property(e => e.Kdvtutari)
                .HasColumnType("money")
                .HasColumnName("KDVTUTARI");
            entity.Property(e => e.Kur)
                .HasColumnType("money")
                .HasColumnName("KUR");
            entity.Property(e => e.Miktar)
                .HasColumnType("money")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Nettutar)
                .HasColumnType("money")
                .HasColumnName("NETTUTAR");
            entity.Property(e => e.Satirref).HasColumnName("SATIRREF");
            entity.Property(e => e.Satirturu).HasColumnName("SATIRTURU");
            entity.Property(e => e.Siparisid).HasColumnName("SIPARISID");
            entity.Property(e => e.Siparisno)
                .HasMaxLength(50)
                .HasColumnName("SIPARISNO");
            entity.Property(e => e.Siparisref).HasColumnName("SIPARISREF");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Tarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Uid)
                .HasMaxLength(50)
                .HasColumnName("UID");
            entity.Property(e => e.Urunid).HasColumnName("URUNID");
            entity.Property(e => e.Urunref).HasColumnName("URUNREF");
            entity.Property(e => e.Yil).HasColumnName("YIL");
        });

        modelBuilder.Entity<Faturaturleri>(entity =>
        {
            entity.ToTable("FATURATURLERI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Isim)
                .HasMaxLength(50)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .HasColumnName("KOD");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<Fisturleri>(entity =>
        {
            entity.ToTable("FISTURLERI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Isim)
                .HasMaxLength(50)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .HasColumnName("KOD");
            entity.Property(e => e.Modul).HasColumnName("MODUL");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<Fiyatlar>(entity =>
        {
            entity.ToTable("FIYATLAR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bastarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("BASTARIH");
            entity.Property(e => e.Birimref).HasColumnName("BIRIMREF");
            entity.Property(e => e.Bittarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("BITTARIH");
            entity.Property(e => e.Carikod)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("CARIKOD");
            entity.Property(e => e.Cariozelkod1)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("CARIOZELKOD1");
            entity.Property(e => e.Cariozelkod2)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("CARIOZELKOD2");
            entity.Property(e => e.Cariozelkod3)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("CARIOZELKOD3");
            entity.Property(e => e.Cariozelkod4)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("CARIOZELKOD4");
            entity.Property(e => e.Cariozelkod5)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("CARIOZELKOD5");
            entity.Property(e => e.Caritig)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("CARITIG");
            entity.Property(e => e.Cariyetkikodu)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("CARIYETKIKODU");
            entity.Property(e => e.Carpan)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Dovizid).HasColumnName("DOVIZID");
            entity.Property(e => e.Fiyat)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Ftip).HasColumnName("FTIP");
            entity.Property(e => e.Grupkodu)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("GRUPKODU");
            entity.Property(e => e.Itemref).HasColumnName("ITEMREF");
            entity.Property(e => e.Kayittarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("KAYITTARIHI");
            entity.Property(e => e.Kdvdahil).HasColumnName("KDVDAHIL");
            entity.Property(e => e.Odemeplanref).HasColumnName("ODEMEPLANREF");
            entity.Property(e => e.Oncelik).HasColumnName("ONCELIK");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<FiyatlarT>(entity =>
        {
            entity.HasKey(e => e.Distid);

            entity.ToTable("FIYATLAR_T");

            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Bastarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("BASTARIH");
            entity.Property(e => e.Bittarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("BITTARIH");
            entity.Property(e => e.Carikod)
                .HasMaxLength(50)
                .HasColumnName("CARIKOD");
            entity.Property(e => e.Cariozelkod1)
                .HasMaxLength(50)
                .HasColumnName("CARIOZELKOD1");
            entity.Property(e => e.Cariozelkod2)
                .HasMaxLength(50)
                .HasColumnName("CARIOZELKOD2");
            entity.Property(e => e.Cariozelkod3)
                .HasMaxLength(50)
                .HasColumnName("CARIOZELKOD3");
            entity.Property(e => e.Cariozelkod4)
                .HasMaxLength(50)
                .HasColumnName("CARIOZELKOD4");
            entity.Property(e => e.Cariozelkod5)
                .HasMaxLength(50)
                .HasColumnName("CARIOZELKOD5");
            entity.Property(e => e.Caritig)
                .HasMaxLength(50)
                .HasColumnName("CARITIG");
            entity.Property(e => e.Cariyetkikodu)
                .HasMaxLength(50)
                .HasColumnName("CARIYETKIKODU");
            entity.Property(e => e.Carpan)
                .HasColumnType("money")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Dovizid).HasColumnName("DOVIZID");
            entity.Property(e => e.Fiyat)
                .HasColumnType("money")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Ftip).HasColumnName("FTIP");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Itemref).HasColumnName("ITEMREF");
            entity.Property(e => e.Kayittarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("KAYITTARIHI");
            entity.Property(e => e.Oncelik).HasColumnName("ONCELIK");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<Goruntuluarama>(entity =>
        {
            entity.ToTable("GORUNTULUARAMA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Arananid).HasColumnName("ARANANID");
            entity.Property(e => e.Arayanid).HasColumnName("ARAYANID");
            entity.Property(e => e.Bastarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("BASTARIH");
            entity.Property(e => e.Bildirildi).HasColumnName("BILDIRILDI");
            entity.Property(e => e.Bittarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("BITTARIH");
            entity.Property(e => e.Devam).HasColumnName("DEVAM");
            entity.Property(e => e.Odano)
                .HasMaxLength(50)
                .HasColumnName("ODANO");
        });

        modelBuilder.Entity<Hatirlaticilar>(entity =>
        {
            entity.ToTable("HATIRLATICILAR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(1500)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Baslik)
                .HasMaxLength(250)
                .HasColumnName("BASLIK");
            entity.Property(e => e.Bastarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("BASTARIH");
            entity.Property(e => e.Bittarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("BITTARIH");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.Gonderildi).HasColumnName("GONDERILDI");
            entity.Property(e => e.Hid).HasColumnName("HID");
            entity.Property(e => e.Kullaniciid).HasColumnName("KULLANICIID");
            entity.Property(e => e.Lat)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("LAT");
            entity.Property(e => e.Lng)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("LNG");
            entity.Property(e => e.Mesafe).HasColumnName("MESAFE");
            entity.Property(e => e.Saat)
                .HasMaxLength(10)
                .HasColumnName("SAAT");
            entity.Property(e => e.Sevkid).HasColumnName("SEVKID");
            entity.Property(e => e.Silinecek).HasColumnName("SILINECEK");
            entity.Property(e => e.Songosterim)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGOSTERIM");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Tur).HasColumnName("TUR");
        });

        modelBuilder.Entity<Hedefler>(entity =>
        {
            entity.ToTable("HEDEFLER");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ay).HasColumnName("AY");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Ceyrek).HasColumnName("CEYREK");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Dovizid).HasColumnName("DOVIZID");
            entity.Property(e => e.Hedef)
                .HasColumnType("money")
                .HasColumnName("HEDEF");
            entity.Property(e => e.Hedefmiktar)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("HEDEFMIKTAR");
            entity.Property(e => e.Hedeftipiid).HasColumnName("HEDEFTIPIID");
            entity.Property(e => e.Hedeftutar)
                .HasColumnType("money")
                .HasColumnName("HEDEFTUTAR");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Kanal)
                .HasMaxLength(100)
                .HasColumnName("KANAL");
            entity.Property(e => e.Kayittarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("KAYITTARIHI");
            entity.Property(e => e.Kullaniciid).HasColumnName("KULLANICIID");
            entity.Property(e => e.Periyodid).HasColumnName("PERIYODID");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Sonislemtarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONISLEMTARIHI");
            entity.Property(e => e.StKodu)
                .HasMaxLength(50)
                .HasColumnName("ST_KODU");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Urunkategoriid)
                .HasMaxLength(200)
                .HasColumnName("URUNKATEGORIID");
            entity.Property(e => e.Yarim).HasColumnName("YARIM");
            entity.Property(e => e.Yil).HasColumnName("YIL");
        });

        modelBuilder.Entity<Hedefrealize>(entity =>
        {
            entity.ToTable("HEDEFREALIZE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ay).HasColumnName("AY");
            entity.Property(e => e.Baslik)
                .HasMaxLength(50)
                .HasColumnName("BASLIK");
            entity.Property(e => e.Carikanal)
                .HasMaxLength(50)
                .HasColumnName("CARIKANAL");
            entity.Property(e => e.Gerceklesen)
                .HasColumnType("money")
                .HasColumnName("GERCEKLESEN");
            entity.Property(e => e.Hedef)
                .HasColumnType("money")
                .HasColumnName("HEDEF");
            entity.Property(e => e.Isyerid).HasColumnName("ISYERID");
            entity.Property(e => e.Oran)
                .HasColumnType("money")
                .HasColumnName("ORAN");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Urunkategori)
                .HasMaxLength(50)
                .HasColumnName("URUNKATEGORI");
            entity.Property(e => e.Yil).HasColumnName("YIL");
        });

        modelBuilder.Entity<Hedeftipleri>(entity =>
        {
            entity.ToTable("HEDEFTIPLERI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adi)
                .HasMaxLength(50)
                .HasColumnName("ADI");
            entity.Property(e => e.Baslangicayi).HasColumnName("BASLANGICAYI");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Periyodid).HasColumnName("PERIYODID");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<Iadesebepleri>(entity =>
        {
            entity.ToTable("IADESEBEPLERI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Iadesebepref)
                .HasMaxLength(50)
                .HasColumnName("IADESEBEPREF");
            entity.Property(e => e.Siralama).HasColumnName("SIRALAMA");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<Iskontolar>(entity =>
        {
            entity.ToTable("ISKONTOLAR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Isim)
                .HasMaxLength(50)
                .HasColumnName("ISIM");
            entity.Property(e => e.Iskcarikod)
                .HasMaxLength(5)
                .HasColumnName("ISKCARIKOD");
            entity.Property(e => e.Iskontoref).HasColumnName("ISKONTOREF");
            entity.Property(e => e.Iskstokkod)
                .HasMaxLength(5)
                .HasColumnName("ISKSTOKKOD");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Yuzde)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("YUZDE");
        });

        modelBuilder.Entity<Isyerleri>(entity =>
        {
            entity.ToTable("ISYERLERI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Isyeri)
                .HasMaxLength(61)
                .IsUnicode(false)
                .HasColumnName("ISYERI");
            entity.Property(e => e.Isyerinr).HasColumnName("ISYERINR");
            entity.Property(e => e.Kanal).HasColumnName("KANAL");
            entity.Property(e => e.Pskukanal).HasColumnName("PSKUKANAL");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<Kampanyadetaylari>(entity =>
        {
            entity.ToTable("KAMPANYADETAYLARI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .HasColumnName("AD");
            entity.Property(e => e.Bastarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("BASTARIH");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Bittarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("BITTARIH");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.Cariidnot).HasColumnName("CARIIDNOT");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Dovizid).HasColumnName("DOVIZID");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.Grupkodu).HasColumnName("GRUPKODU");
            entity.Property(e => e.Grupkodunot).HasColumnName("GRUPKODUNOT");
            entity.Property(e => e.Guncelleyenkullanici)
                .HasDefaultValueSql("('İLK KAYIT')")
                .HasColumnName("GUNCELLEYENKULLANICI");
            entity.Property(e => e.Hedefurunid).HasColumnName("HEDEFURUNID");
            entity.Property(e => e.Isk1)
                .HasColumnType("money")
                .HasColumnName("ISK1");
            entity.Property(e => e.Isk2)
                .HasColumnType("money")
                .HasColumnName("ISK2");
            entity.Property(e => e.Isk3)
                .HasColumnType("money")
                .HasColumnName("ISK3");
            entity.Property(e => e.Isk4)
                .HasColumnType("money")
                .HasColumnName("ISK4");
            entity.Property(e => e.Kampanyaid).HasColumnName("KAMPANYAID");
            entity.Property(e => e.Kampanyatipid).HasColumnName("KAMPANYATIPID");
            entity.Property(e => e.Kanal1).HasColumnName("KANAL1");
            entity.Property(e => e.Kanal1not).HasColumnName("KANAL1NOT");
            entity.Property(e => e.Kanal2).HasColumnName("KANAL2");
            entity.Property(e => e.Kanal2not).HasColumnName("KANAL2NOT");
            entity.Property(e => e.Kanal3).HasColumnName("KANAL3");
            entity.Property(e => e.Kanal3not).HasColumnName("KANAL3NOT");
            entity.Property(e => e.Kanal4).HasColumnName("KANAL4");
            entity.Property(e => e.Kanal4not).HasColumnName("KANAL4NOT");
            entity.Property(e => e.Kanal5).HasColumnName("KANAL5");
            entity.Property(e => e.Kanal5not).HasColumnName("KANAL5NOT");
            entity.Property(e => e.Katli).HasColumnName("KATLI");
            entity.Property(e => e.Kisaad)
                .HasMaxLength(50)
                .HasColumnName("KISAAD");
            entity.Property(e => e.Kullanilanmiktarlimit)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("KULLANILANMIKTARLIMIT");
            entity.Property(e => e.Kullanilantutarlimit)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("KULLANILANTUTARLIMIT");
            entity.Property(e => e.Limitbirimid).HasColumnName("LIMITBIRIMID");
            entity.Property(e => e.Limitdovizid).HasColumnName("LIMITDOVIZID");
            entity.Property(e => e.Mf).HasColumnName("MF");
            entity.Property(e => e.Mfbirimid).HasColumnName("MFBIRIMID");
            entity.Property(e => e.Miktar)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Miktarlimit)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("MIKTARLIMIT");
            entity.Property(e => e.Odemeplanid).HasColumnName("ODEMEPLANID");
            entity.Property(e => e.Odemeplanidnot).HasColumnName("ODEMEPLANIDNOT");
            entity.Property(e => e.Odemeplanlari).HasColumnName("ODEMEPLANLARI");
            entity.Property(e => e.Odemeplanlarinot).HasColumnName("ODEMEPLANLARINOT");
            entity.Property(e => e.Oncelik).HasColumnName("ONCELIK");
            entity.Property(e => e.Ozelalan1).HasColumnName("OZELALAN1");
            entity.Property(e => e.Ozelalan1not).HasColumnName("OZELALAN1NOT");
            entity.Property(e => e.Ozelalan2).HasColumnName("OZELALAN2");
            entity.Property(e => e.Ozelalan2not).HasColumnName("OZELALAN2NOT");
            entity.Property(e => e.Ozelalan3).HasColumnName("OZELALAN3");
            entity.Property(e => e.Ozelalan3not).HasColumnName("OZELALAN3NOT");
            entity.Property(e => e.Ozelalan4).HasColumnName("OZELALAN4");
            entity.Property(e => e.Ozelalan4not).HasColumnName("OZELALAN4NOT");
            entity.Property(e => e.Ozelalan5).HasColumnName("OZELALAN5");
            entity.Property(e => e.Ozelalan5not).HasColumnName("OZELALAN5NOT");
            entity.Property(e => e.Ozelfiyat)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("OZELFIYAT");
            entity.Property(e => e.Silindi).HasColumnName("SILINDI");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Stidnot)
                .HasMaxLength(4000)
                .HasColumnName("STIDNOT");
            entity.Property(e => e.Turid).HasColumnName("TURID");
            entity.Property(e => e.Tutar)
                .HasColumnType("money")
                .HasColumnName("TUTAR");
            entity.Property(e => e.Tutarlimit)
                .HasColumnType("money")
                .HasColumnName("TUTARLIMIT");
            entity.Property(e => e.Urunid).HasColumnName("URUNID");
            entity.Property(e => e.Urunidnot)
                .HasMaxLength(4000)
                .HasColumnName("URUNIDNOT");
            entity.Property(e => e.Urunkategoriid).HasColumnName("URUNKATEGORIID");
            entity.Property(e => e.Urunkategorinot)
                .HasMaxLength(4000)
                .HasColumnName("URUNKATEGORINOT");
            entity.Property(e => e.Urunozelkod1).HasColumnName("URUNOZELKOD1");
            entity.Property(e => e.Urunozelkod1not).HasColumnName("URUNOZELKOD1NOT");
            entity.Property(e => e.Urunozelkod2).HasColumnName("URUNOZELKOD2");
            entity.Property(e => e.Urunozelkod2not).HasColumnName("URUNOZELKOD2NOT");
            entity.Property(e => e.Urunozelkod3).HasColumnName("URUNOZELKOD3");
            entity.Property(e => e.Urunozelkod3not).HasColumnName("URUNOZELKOD3NOT");
            entity.Property(e => e.Urunozelkod4).HasColumnName("URUNOZELKOD4");
            entity.Property(e => e.Urunozelkod4not).HasColumnName("URUNOZELKOD4NOT");
            entity.Property(e => e.Urunozelkod5).HasColumnName("URUNOZELKOD5");
            entity.Property(e => e.Urunozelkod5not).HasColumnName("URUNOZELKOD5NOT");
            entity.Property(e => e.Urunyetkikodu).HasColumnName("URUNYETKIKODU");
            entity.Property(e => e.Urunyetkikodunot).HasColumnName("URUNYETKIKODUNOT");
            entity.Property(e => e.Zorunlu).HasColumnName("ZORUNLU");
        });

        modelBuilder.Entity<Kampanyalar>(entity =>
        {
            entity.ToTable("KAMPANYALAR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(250)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .HasColumnName("AD");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Guncelleyenkullanici)
                .HasDefaultValueSql("('İLK KAYIT')")
                .HasColumnName("GUNCELLEYENKULLANICI");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Kisaad)
                .HasMaxLength(20)
                .HasColumnName("KISAAD");
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .HasColumnName("KOD");
            entity.Property(e => e.Limitdovizid).HasColumnName("LIMITDOVIZID");
            entity.Property(e => e.Oncelik).HasColumnName("ONCELIK");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Tutarlimit)
                .HasColumnType("money")
                .HasColumnName("TUTARLIMIT");
        });

        modelBuilder.Entity<Kampanyatipleri>(entity =>
        {
            entity.ToTable("KAMPANYATIPLERI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Isim)
                .HasMaxLength(50)
                .HasColumnName("ISIM");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .HasColumnName("KOD");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<Kapsamkontrol>(entity =>
        {
            entity.ToTable("KAPSAMKONTROL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ay).HasColumnName("AY");
            entity.Property(e => e.Bgcolor)
                .HasMaxLength(10)
                .HasColumnName("BGCOLOR");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Nettutar)
                .HasColumnType("money")
                .HasColumnName("NETTUTAR");
            entity.Property(e => e.Sevkid).HasColumnName("SEVKID");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Yil).HasColumnName("YIL");
        });

        modelBuilder.Entity<Kasalar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KASALAR");

            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Kasaadi)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("KASAADI");
            entity.Property(e => e.Kasaid).HasColumnName("KASAID");
            entity.Property(e => e.Kasakodu)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("KASAKODU");
            entity.Property(e => e.Muhkodu)
                .HasMaxLength(101)
                .IsUnicode(false)
                .HasColumnName("MUHKODU");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<Klasorler>(entity =>
        {
            entity.ToTable("KLASORLER");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Isim).HasColumnName("ISIM");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Klasorisim).HasColumnName("KLASORISIM");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<Konumlar>(entity =>
        {
            entity.ToTable("KONUMLAR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Islemid).HasColumnName("ISLEMID");
            entity.Property(e => e.Islemturuid).HasColumnName("ISLEMTURUID");
            entity.Property(e => e.Kullaniciid).HasColumnName("KULLANICIID");
            entity.Property(e => e.Lat)
                .HasColumnType("decimal(18, 10)")
                .HasColumnName("LAT");
            entity.Property(e => e.Lng)
                .HasColumnType("decimal(18, 10)")
                .HasColumnName("LNG");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Tarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Liderpanosu>(entity =>
        {
            entity.ToTable("LIDERPANOSU");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ay).HasColumnName("AY");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Rozet).HasColumnName("ROZET");
            entity.Property(e => e.Sira).HasColumnName("SIRA");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("datetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stadi)
                .HasMaxLength(50)
                .HasColumnName("STADI");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Stkodu)
                .HasMaxLength(50)
                .HasColumnName("STKODU");
            entity.Property(e => e.Yil).HasColumnName("YIL");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.ToTable("LOG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Islem)
                .HasMaxLength(40)
                .HasColumnName("ISLEM");
            entity.Property(e => e.Kullaniciid).HasColumnName("KULLANICIID");
            entity.Property(e => e.Oncekideger).HasColumnName("ONCEKIDEGER");
            entity.Property(e => e.Sonrakideger).HasColumnName("SONRAKIDEGER");
            entity.Property(e => e.Tablo)
                .HasMaxLength(40)
                .HasColumnName("TABLO");
            entity.Property(e => e.Tarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Loglar>(entity =>
        {
            entity.ToTable("LOGLAR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(50)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Ipadres)
                .HasMaxLength(50)
                .HasColumnName("IPADRES");
            entity.Property(e => e.Kullaniciid).HasColumnName("KULLANICIID");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Tarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Mesajlar>(entity =>
        {
            entity.ToTable("MESAJLAR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Gonderenid).HasColumnName("GONDERENID");
            entity.Property(e => e.Gonderilenid).HasColumnName("GONDERILENID");
            entity.Property(e => e.Isimsoyisim).HasColumnName("ISIMSOYISIM");
            entity.Property(e => e.Mesaj).HasColumnName("MESAJ");
            entity.Property(e => e.Ozelid).HasColumnName("OZELID");
            entity.Property(e => e.Tarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tarihstr).HasColumnName("TARIHSTR");
        });

        modelBuilder.Entity<Mesajlardetay>(entity =>
        {
            entity.ToTable("MESAJLARDETAY");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Okundu).HasColumnName("OKUNDU");
            entity.Property(e => e.Ozelid).HasColumnName("OZELID");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
        });

        modelBuilder.Entity<Musteritipleri>(entity =>
        {
            entity.ToTable("MUSTERITIPLERI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Isim)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("ISIM");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Kod)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("KOD");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<MusteritipleriT>(entity =>
        {
            entity.ToTable("MUSTERITIPLERI_T");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Isim)
                .HasMaxLength(50)
                .HasColumnName("ISIM");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .HasColumnName("KOD");
            entity.Property(e => e.Mustertipref).HasColumnName("MUSTERTIPREF");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<Odemeplanlari>(entity =>
        {
            entity.ToTable("ODEMEPLANLARI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.Kodu)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("KODU");
            entity.Property(e => e.No).HasColumnName("NO");
            entity.Property(e => e.Odemeref).HasColumnName("ODEMEREF");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<OdemeplanlariT>(entity =>
        {
            entity.ToTable("ODEMEPLANLARI_T");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .HasColumnName("KOD");
            entity.Property(e => e.No).HasColumnName("NO");
            entity.Property(e => e.Odemeref)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ODEMEREF");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<Parametreler>(entity =>
        {
            entity.ToTable("PARAMETRELER");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adetgozuksun)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ADETGOZUKSUN");
            entity.Property(e => e.Alokasyon).HasColumnName("ALOKASYON");
            entity.Property(e => e.Alokasyonuyariyuzde).HasColumnName("ALOKASYONUYARIYUZDE");
            entity.Property(e => e.Ambarfiyatgosterimi)
                .IsUnicode(false)
                .HasColumnName("AMBARFIYATGOSTERIMI");
            entity.Property(e => e.Ambaridvarsayilan).HasColumnName("AMBARIDVARSAYILAN");
            entity.Property(e => e.Ambarminimumsiparistutar)
                .IsUnicode(false)
                .HasColumnName("AMBARMINIMUMSIPARISTUTAR");
            entity.Property(e => e.Ambarminimumtutaretkin).HasColumnName("AMBARMINIMUMTUTARETKIN");
            entity.Property(e => e.Ambarsecim).HasColumnName("AMBARSECIM");
            entity.Property(e => e.Birimfiyatsecsin).HasColumnName("BIRIMFIYATSECSIN");
            entity.Property(e => e.Borctakipturu).HasColumnName("BORCTAKIPTURU");
            entity.Property(e => e.Caritahsilatbilgisi).HasColumnName("CARITAHSILATBILGISI");
            entity.Property(e => e.Cirogozuksun)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CIROGOZUKSUN");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Dovizid)
                .HasDefaultValueSql("(N'[]')")
                .HasColumnName("DOVIZID");
            entity.Property(e => e.Dovizkuru).HasColumnName("DOVIZKURU");
            entity.Property(e => e.Faturazorunlukayit).HasColumnName("FATURAZORUNLUKAYIT");
            entity.Property(e => e.Fiyatdurum).HasColumnName("FIYATDURUM");
            entity.Property(e => e.Gunbasiirsaliyezorunlu).HasColumnName("GUNBASIIRSALIYEZORUNLU");
            entity.Property(e => e.Iadesebepidvarsayilan).HasColumnName("IADESEBEPIDVARSAYILAN");
            entity.Property(e => e.Iadesebepsecim).HasColumnName("IADESEBEPSECIM");
            entity.Property(e => e.Iadestbilgisi)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IADESTBILGISI");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Kampanyaolmayanstok).HasColumnName("KAMPANYAOLMAYANSTOK");
            entity.Property(e => e.Kapsamgozuksun)
                .HasDefaultValueSql("((1))")
                .HasColumnName("KAPSAMGOZUKSUN");
            entity.Property(e => e.Kdvdegissin).HasColumnName("KDVDEGISSIN");
            entity.Property(e => e.Konumtoleransi).HasColumnName("KONUMTOLERANSI");
            entity.Property(e => e.Liderpanosusayisi)
                .HasDefaultValueSql("((3))")
                .HasColumnName("LIDERPANOSUSAYISI");
            entity.Property(e => e.Lokasyonguncelleme).HasColumnName("LOKASYONGUNCELLEME");
            entity.Property(e => e.Maileposta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAILEPOSTA");
            entity.Property(e => e.Mailisim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAILISIM");
            entity.Property(e => e.Mailport)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAILPORT");
            entity.Property(e => e.Mailsifre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAILSIFRE");
            entity.Property(e => e.Mailsmtp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAILSMTP");
            entity.Property(e => e.Odemeplanidegistirilsin).HasColumnName("ODEMEPLANIDEGISTIRILSIN");
            entity.Property(e => e.Onaydurumu).HasColumnName("ONAYDURUMU");
            entity.Property(e => e.Openweatherapi)
                .HasMaxLength(50)
                .HasColumnName("OPENWEATHERAPI");
            entity.Property(e => e.Parabirimiid).HasColumnName("PARABIRIMIID");
            entity.Property(e => e.Photo1)
                .HasMaxLength(50)
                .HasColumnName("PHOTO1");
            entity.Property(e => e.Photo1aktiflik).HasColumnName("PHOTO1AKTIFLIK");
            entity.Property(e => e.Photo2)
                .HasMaxLength(50)
                .HasColumnName("PHOTO2");
            entity.Property(e => e.Photo2aktiflik).HasColumnName("PHOTO2AKTIFLIK");
            entity.Property(e => e.Photo3)
                .HasMaxLength(50)
                .HasColumnName("PHOTO3");
            entity.Property(e => e.Photo3aktiflik).HasColumnName("PHOTO3AKTIFLIK");
            entity.Property(e => e.Photo4)
                .HasMaxLength(50)
                .HasColumnName("PHOTO4");
            entity.Property(e => e.Photo4aktiflik).HasColumnName("PHOTO4AKTIFLIK");
            entity.Property(e => e.Photo5)
                .HasMaxLength(50)
                .HasColumnName("PHOTO5");
            entity.Property(e => e.Photo5aktiflik).HasColumnName("PHOTO5AKTIFLIK");
            entity.Property(e => e.Pmarkagozuksun)
                .HasDefaultValueSql("((1))")
                .HasColumnName("PMARKAGOZUKSUN");
            entity.Property(e => e.Pskukanal).HasColumnName("PSKUKANAL");
            entity.Property(e => e.Pskumslgozuksun)
                .HasDefaultValueSql("((1))")
                .HasColumnName("PSKUMSLGOZUKSUN");
            entity.Property(e => e.Randomcount).HasColumnName("RANDOMCOUNT");
            entity.Property(e => e.Risklimitiuyarisi)
                .HasDefaultValueSql("((1))")
                .HasColumnName("RISKLIMITIUYARISI");
            entity.Property(e => e.Senkronizasyon).HasColumnName("SENKRONIZASYON");
            entity.Property(e => e.Sepetiadehesabi)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SEPETIADEHESABI");
            entity.Property(e => e.Sicaksatis).HasColumnName("SICAKSATIS");
            entity.Property(e => e.Siparisonay).HasColumnName("SIPARISONAY");
            entity.Property(e => e.Siparispaylas).HasColumnName("SIPARISPAYLAS");
            entity.Property(e => e.Siparissatir).HasColumnName("SIPARISSATIR");
            entity.Property(e => e.Siparistutar)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("SIPARISTUTAR");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stidvarsayilan).HasColumnName("STIDVARSAYILAN");
            entity.Property(e => e.Stokondaliklisayilar).HasColumnName("STOKONDALIKLISAYILAR");
            entity.Property(e => e.Strutgozuksun)
                .HasDefaultValueSql("((1))")
                .HasColumnName("STRUTGOZUKSUN");
            entity.Property(e => e.Stsecim).HasColumnName("STSECIM");
            entity.Property(e => e.Sureklikonumalma).HasColumnName("SUREKLIKONUMALMA");
            entity.Property(e => e.Varsayilandovizidbo).HasColumnName("VARSAYILANDOVIZIDBO");
            entity.Property(e => e.Varsayilandovizidmo).HasColumnName("VARSAYILANDOVIZIDMO");
            entity.Property(e => e.VidyoIoAppid)
                .HasMaxLength(50)
                .HasColumnName("VIDYO_IO_APPID");
            entity.Property(e => e.VidyoIoKey)
                .HasMaxLength(50)
                .HasColumnName("VIDYO_IO_KEY");
            entity.Property(e => e.Ziyaretsizsiparis)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ZIYARETSIZSIPARIS");
            entity.Property(e => e.Ziyarettekonumuyarisi).HasColumnName("ZIYARETTEKONUMUYARISI");
            entity.Property(e => e.Ziyarettekonumuyarisi2)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ZIYARETTEKONUMUYARISI2");
        });

        modelBuilder.Entity<Periyotlar>(entity =>
        {
            entity.ToTable("PERIYOTLAR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Gun).HasColumnName("GUN");
            entity.Property(e => e.Periyottur)
                .HasMaxLength(20)
                .HasColumnName("PERIYOTTUR");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<Pskuliste>(entity =>
        {
            entity.ToTable("PSKULISTE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adi)
                .HasMaxLength(50)
                .HasColumnName("ADI");
            entity.Property(e => e.Baslangicay).HasColumnName("BASLANGICAY");
            entity.Property(e => e.Baslangictarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("BASLANGICTARIHI");
            entity.Property(e => e.Baslangicyil).HasColumnName("BASLANGICYIL");
            entity.Property(e => e.Bitistarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("BITISTARIHI");
            entity.Property(e => e.Carikanal)
                .HasMaxLength(50)
                .HasColumnName("CARIKANAL");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Kullaniciid).HasColumnName("KULLANICIID");
            entity.Property(e => e.Periyot).HasColumnName("PERIYOT");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Urunkodu)
                .HasMaxLength(50)
                .HasColumnName("URUNKODU");
            entity.Property(e => e.Urunyetkikodu)
                .HasMaxLength(50)
                .HasColumnName("URUNYETKIKODU");
        });

        modelBuilder.Entity<Pskurapor>(entity =>
        {
            entity.ToTable("PSKURAPOR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ay).HasColumnName("AY");
            entity.Property(e => e.Bperiod).HasColumnName("BPERIOD");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.Carikodu)
                .HasMaxLength(50)
                .HasColumnName("CARIKODU");
            entity.Property(e => e.Cariunvani)
                .HasMaxLength(50)
                .HasColumnName("CARIUNVANI");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Kanal).HasColumnName("KANAL");
            entity.Property(e => e.Rperiod).HasColumnName("RPERIOD");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stadi)
                .HasMaxLength(50)
                .HasColumnName("STADI");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Urunadi).HasColumnName("URUNADI");
            entity.Property(e => e.Urunkodu)
                .HasMaxLength(50)
                .HasColumnName("URUNKODU");
            entity.Property(e => e.Urunyetkikodu)
                .HasMaxLength(50)
                .HasColumnName("URUNYETKIKODU");
            entity.Property(e => e.Yil).HasColumnName("YIL");
        });

        modelBuilder.Entity<Pskusati>(entity =>
        {
            entity.ToTable("PSKUSATIS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ay).HasColumnName("AY");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Pskulistid).HasColumnName("PSKULISTID");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Urunid).HasColumnName("URUNID");
            entity.Property(e => e.Yil).HasColumnName("YIL");
        });

        modelBuilder.Entity<Pskuurunlistesi>(entity =>
        {
            entity.ToTable("PSKUURUNLISTESI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ay).HasColumnName("AY");
            entity.Property(e => e.Ceyrek).HasColumnName("CEYREK");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Kanal)
                .HasMaxLength(50)
                .HasColumnName("KANAL");
            entity.Property(e => e.Kullaniciid).HasColumnName("KULLANICIID");
            entity.Property(e => e.Periyodid).HasColumnName("PERIYODID");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Tarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Urunref).HasColumnName("URUNREF");
            entity.Property(e => e.Yarim).HasColumnName("YARIM");
            entity.Property(e => e.Yil).HasColumnName("YIL");
        });

        modelBuilder.Entity<RotaOlusturStListe>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ROTA_OLUSTUR_ST_LISTE");

            entity.Property(e => e.Guncellemebaslangic)
                .HasColumnType("datetime")
                .HasColumnName("GUNCELLEMEBASLANGIC");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Periyodbaslangic)
                .HasColumnType("smalldatetime")
                .HasColumnName("PERIYODBASLANGIC");
            entity.Property(e => e.Periyodgun).HasColumnName("PERIYODGUN");
            entity.Property(e => e.Stid).HasColumnName("STID");
        });

        modelBuilder.Entity<RutGunMevcut>(entity =>
        {
            entity.ToTable("RUT_GUN_MEVCUT");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Carikodu)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("CARIKODU");
            entity.Property(e => e.Cariunvani)
                .HasMaxLength(50)
                .HasColumnName("CARIUNVANI");
            entity.Property(e => e.Gun).HasColumnName("GUN");
            entity.Property(e => e.Gunadi)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("GUNADI");
            entity.Property(e => e.Gundurum)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("GUNDURUM");
            entity.Property(e => e.Kanal1)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("KANAL1");
            entity.Property(e => e.Kanal1isim)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("KANAL1ISIM");
            entity.Property(e => e.Kanal2)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("KANAL2");
            entity.Property(e => e.Kanal2isim)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KANAL2ISIM");
            entity.Property(e => e.Kanal3)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("KANAL3");
            entity.Property(e => e.Kanal3isim)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KANAL3ISIM");
            entity.Property(e => e.Sevkadresi)
                .HasMaxLength(50)
                .HasColumnName("SEVKADRESI");
            entity.Property(e => e.Sevkkodu)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SEVKKODU");
            entity.Property(e => e.Stadi)
                .HasMaxLength(50)
                .HasColumnName("STADI");
            entity.Property(e => e.Stkodu)
                .HasMaxLength(50)
                .HasColumnName("STKODU");
        });

        modelBuilder.Entity<Sanalasistan>(entity =>
        {
            entity.ToTable("SANALASISTAN");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Baslik)
                .HasMaxLength(100)
                .HasColumnName("BASLIK");
            entity.Property(e => e.Detay).HasColumnName("DETAY");
            entity.Property(e => e.Image)
                .HasMaxLength(100)
                .HasColumnName("IMAGE");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("datetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Satistemsilcileri>(entity =>
        {
            entity.ToTable("SATISTEMSILCILERI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adi)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("ADI");
            entity.Property(e => e.Bolge)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("BOLGE");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.Gorev)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("GOREV");
            entity.Property(e => e.Kodu)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("KODU");
            entity.Property(e => e.Kullaniciid).HasColumnName("KULLANICIID");
            entity.Property(e => e.Period).HasColumnName("PERIOD");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stref).HasColumnName("STREF");
            entity.Property(e => e.Strefler)
                .HasMaxLength(10)
                .HasColumnName("STREFLER");
        });

        modelBuilder.Entity<SatistemsilcileriT>(entity =>
        {
            entity.ToTable("SATISTEMSILCILERI_T");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adi)
                .HasMaxLength(50)
                .HasColumnName("ADI");
            entity.Property(e => e.Bolge)
                .HasMaxLength(30)
                .HasColumnName("BOLGE");
            entity.Property(e => e.Dashgorunurluk)
                .HasDefaultValueSql("((1))")
                .HasColumnName("DASHGORUNURLUK");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.Excelrotaguncelleme).HasColumnName("EXCELROTAGUNCELLEME");
            entity.Property(e => e.Gorev)
                .HasMaxLength(10)
                .HasColumnName("GOREV");
            entity.Property(e => e.Isbusy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ISBUSY");
            entity.Property(e => e.Isyerleri).HasColumnName("ISYERLERI");
            entity.Property(e => e.Kasalar)
                .HasMaxLength(100)
                .HasColumnName("KASALAR");
            entity.Property(e => e.Kodu)
                .HasMaxLength(50)
                .HasColumnName("KODU");
            entity.Property(e => e.Kullaniciid).HasColumnName("KULLANICIID");
            entity.Property(e => e.Period).HasColumnName("PERIOD");
            entity.Property(e => e.Soneklenenstrutgun).HasColumnName("SONEKLENENSTRUTGUN");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stref).HasColumnName("STREF");
            entity.Property(e => e.Strefler).HasColumnName("STREFLER");
            entity.Property(e => e.Strutguncellemebaslangic)
                .HasColumnType("smalldatetime")
                .HasColumnName("STRUTGUNCELLEMEBASLANGIC");
            entity.Property(e => e.Strutguncellemehafta)
                .HasColumnType("smalldatetime")
                .HasColumnName("STRUTGUNCELLEMEHAFTA");
            entity.Property(e => e.Strutsonguncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("STRUTSONGUNCELLEME");
            entity.Property(e => e.Strutsonislem)
                .HasColumnType("smalldatetime")
                .HasColumnName("STRUTSONISLEM");
            entity.Property(e => e.Yaziciismi).HasColumnName("YAZICIISMI");
        });

        modelBuilder.Entity<Sepet>(entity =>
        {
            entity.ToTable("SEPET");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Birim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BIRIM");
            entity.Property(e => e.Birimfiyat)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("BIRIMFIYAT");
            entity.Property(e => e.Kampanya)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KAMPANYA");
            entity.Property(e => e.Kdv)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("KDV");
            entity.Property(e => e.Kdvtutari)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("KDVTUTARI");
            entity.Property(e => e.Kullaniciid).HasColumnName("KULLANICIID");
            entity.Property(e => e.Miktar)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Nettutar)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("NETTUTAR");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Toplamtutar)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("TOPLAMTUTAR");
            entity.Property(e => e.Urunadi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("URUNADI");
            entity.Property(e => e.Urunkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("URUNKOD");
        });

        modelBuilder.Entity<Servisseviyesi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SERVIS_SEVIYESI");

            entity.ToTable("SERVISSEVIYESI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ay).HasColumnName("AY");
            entity.Property(e => e.Birimfiyat)
                .HasColumnType("money")
                .HasColumnName("BIRIMFIYAT");
            entity.Property(e => e.CariKodu)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CARI_KODU");
            entity.Property(e => e.CariOzelalan1)
                .HasMaxLength(50)
                .HasColumnName("CARI_OZELALAN1");
            entity.Property(e => e.CariOzelalan2)
                .HasMaxLength(50)
                .HasColumnName("CARI_OZELALAN2");
            entity.Property(e => e.CariOzelalan3)
                .HasMaxLength(50)
                .HasColumnName("CARI_OZELALAN3");
            entity.Property(e => e.CariOzelalan4)
                .HasMaxLength(50)
                .HasColumnName("CARI_OZELALAN4");
            entity.Property(e => e.CariOzelalan5)
                .HasMaxLength(50)
                .HasColumnName("CARI_OZELALAN5");
            entity.Property(e => e.CariUnvani)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CARI_UNVANI");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.Doviz)
                .HasMaxLength(50)
                .HasColumnName("DOVIZ");
            entity.Property(e => e.FaturaBirim)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FATURA_BIRIM");
            entity.Property(e => e.FaturaMiktar)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FATURA_MIKTAR");
            entity.Property(e => e.FaturaTutar)
                .HasColumnType("money")
                .HasColumnName("FATURA_TUTAR");
            entity.Property(e => e.Isyeri)
                .HasMaxLength(50)
                .HasColumnName("ISYERI");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.KalanMiktar)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("KALAN_MIKTAR");
            entity.Property(e => e.LogoBirim)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("LOGO_BIRIM");
            entity.Property(e => e.LogoMiktar)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("LOGO_MIKTAR");
            entity.Property(e => e.LogoSevkedilenMiktar)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("LOGO_SEVKEDILEN_MIKTAR");
            entity.Property(e => e.LogoTarih)
                .HasColumnType("datetime")
                .HasColumnName("LOGO_TARIH");
            entity.Property(e => e.SatirTuru)
                .HasMaxLength(25)
                .HasColumnName("SATIR_TURU");
            entity.Property(e => e.SevkAdi)
                .HasMaxLength(50)
                .HasColumnName("SEVK_ADI");
            entity.Property(e => e.SiparisNo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SIPARIS_NO");
            entity.Property(e => e.Siparisid).HasColumnName("SIPARISID");
            entity.Property(e => e.SlBirim)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("SL_BIRIM");
            entity.Property(e => e.SlMiktar)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("SL_MIKTAR");
            entity.Property(e => e.SlTarih)
                .HasColumnType("datetime")
                .HasColumnName("SL_TARIH");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("datetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.StAdi)
                .HasMaxLength(50)
                .HasColumnName("ST_ADI");
            entity.Property(e => e.StKodu)
                .HasMaxLength(50)
                .HasColumnName("ST_KODU");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.UrunAdi)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("URUN_ADI");
            entity.Property(e => e.UrunGrupkodu)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("URUN_GRUPKODU");
            entity.Property(e => e.UrunKodu)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("URUN_KODU");
            entity.Property(e => e.UrunOzelkod1)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("URUN_OZELKOD1");
            entity.Property(e => e.UrunOzelkod2)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("URUN_OZELKOD2");
            entity.Property(e => e.UrunOzelkod3)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("URUN_OZELKOD3");
            entity.Property(e => e.UrunOzelkod4)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("URUN_OZELKOD4");
            entity.Property(e => e.UrunOzelkod5)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("URUN_OZELKOD5");
            entity.Property(e => e.UrunYetkikodu)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("URUN_YETKIKODU");
            entity.Property(e => e.Yil).HasColumnName("YIL");
        });

        modelBuilder.Entity<Servisseviyesi1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SERVISSEVIYESI_");

            entity.Property(e => e.Ay).HasColumnName("AY");
            entity.Property(e => e.CariKodu)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CARI_KODU");
            entity.Property(e => e.CariUnvani)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CARI_UNVANI");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.FaturaBirim)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("FATURA_BIRIM");
            entity.Property(e => e.FaturaMiktar)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FATURA_MIKTAR");
            entity.Property(e => e.FaturaTutar)
                .HasColumnType("money")
                .HasColumnName("FATURA_TUTAR");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.KalanMiktar)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("KALAN_MIKTAR");
            entity.Property(e => e.LogoBirim)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("LOGO_BIRIM");
            entity.Property(e => e.LogoMiktar)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("LOGO_MIKTAR");
            entity.Property(e => e.LogoSevkedilenMiktar)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("LOGO_SEVKEDILEN_MIKTAR");
            entity.Property(e => e.LogoTarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("LOGO_TARIH");
            entity.Property(e => e.SatirTuru)
                .HasMaxLength(25)
                .HasColumnName("SATIR_TURU");
            entity.Property(e => e.SiparisNo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SIPARIS_NO");
            entity.Property(e => e.Siparisid).HasColumnName("SIPARISID");
            entity.Property(e => e.SlBirim)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("SL_BIRIM");
            entity.Property(e => e.SlMiktar)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("SL_MIKTAR");
            entity.Property(e => e.SlTarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("SL_TARIH");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("datetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.UrunAdi)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("URUN_ADI");
            entity.Property(e => e.UrunGrupkodu)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("URUN_GRUPKODU");
            entity.Property(e => e.UrunKodu)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("URUN_KODU");
            entity.Property(e => e.UrunOzelkod1)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("URUN_OZELKOD1");
            entity.Property(e => e.UrunOzelkod2)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("URUN_OZELKOD2");
            entity.Property(e => e.UrunOzelkod3)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("URUN_OZELKOD3");
            entity.Property(e => e.UrunOzelkod4)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("URUN_OZELKOD4");
            entity.Property(e => e.UrunOzelkod5)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("URUN_OZELKOD5");
            entity.Property(e => e.UrunYetkikodu)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("URUN_YETKIKODU");
            entity.Property(e => e.Yil).HasColumnName("YIL");
        });

        modelBuilder.Entity<Sevkadresleri>(entity =>
        {
            entity.ToTable("SEVKADRESLERI");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Adres)
                .HasMaxLength(50)
                .HasColumnName("ADRES");
            entity.Property(e => e.Bolge)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("BOLGE");
            entity.Property(e => e.Cariref).HasColumnName("CARIREF");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.Eposta)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("EPOSTA");
            entity.Property(e => e.Faks)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("FAKS");
            entity.Property(e => e.Grupkodu)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("GRUPKODU");
            entity.Property(e => e.Ilce)
                .HasMaxLength(50)
                .HasColumnName("ILCE");
            entity.Property(e => e.Ilgili)
                .HasMaxLength(50)
                .HasColumnName("ILGILI");
            entity.Property(e => e.Indirimkod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("INDIRIMKOD");
            entity.Property(e => e.Kampanyakod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("KAMPANYAKOD");
            entity.Property(e => e.Kanal1)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("KANAL1");
            entity.Property(e => e.Kodu)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("KODU");
            entity.Property(e => e.Latitude)
                .HasColumnType("decimal(12, 8)")
                .HasColumnName("LATITUDE");
            entity.Property(e => e.Longitude)
                .HasColumnType("decimal(12, 8)")
                .HasColumnName("LONGITUDE");
            entity.Property(e => e.Muhkodu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("MUHKODU");
            entity.Property(e => e.Opaciklama)
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("OPACIKLAMA");
            entity.Property(e => e.Opkodu)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("OPKODU");
            entity.Property(e => e.Ozelalan1)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("OZELALAN1");
            entity.Property(e => e.Sehir)
                .HasMaxLength(50)
                .HasColumnName("SEHIR");
            entity.Property(e => e.Sevkref).HasColumnName("SEVKREF");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Tel1)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("TEL1");
            entity.Property(e => e.Tel2)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("TEL2");
            entity.Property(e => e.Ulke)
                .HasMaxLength(50)
                .HasColumnName("ULKE");
            entity.Property(e => e.Unvani)
                .HasMaxLength(50)
                .HasColumnName("UNVANI");
            entity.Property(e => e.Vdairesi)
                .HasMaxLength(50)
                .HasColumnName("VDAIRESI");
            entity.Property(e => e.Vno)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("VNO");
        });

        modelBuilder.Entity<SevkadresleriT>(entity =>
        {
            entity.ToTable("SEVKADRESLERI_T");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adres).HasColumnName("ADRES");
            entity.Property(e => e.Aktarim).HasColumnName("AKTARIM");
            entity.Property(e => e.Bolge).HasColumnName("BOLGE");
            entity.Property(e => e.Cariref).HasColumnName("CARIREF");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.Eposta).HasColumnName("EPOSTA");
            entity.Property(e => e.Faks).HasColumnName("FAKS");
            entity.Property(e => e.Grupkodu).HasColumnName("GRUPKODU");
            entity.Property(e => e.Ilce).HasColumnName("ILCE");
            entity.Property(e => e.Ilgili).HasColumnName("ILGILI");
            entity.Property(e => e.Indirimkod).HasColumnName("INDIRIMKOD");
            entity.Property(e => e.Kampanyakod).HasColumnName("KAMPANYAKOD");
            entity.Property(e => e.Kanal1).HasColumnName("KANAL1");
            entity.Property(e => e.Kodu).HasColumnName("KODU");
            entity.Property(e => e.Latitude)
                .HasColumnType("decimal(12, 8)")
                .HasColumnName("LATITUDE");
            entity.Property(e => e.Longitude)
                .HasColumnType("decimal(12, 8)")
                .HasColumnName("LONGITUDE");
            entity.Property(e => e.Muhkodu).HasColumnName("MUHKODU");
            entity.Property(e => e.Onay).HasColumnName("ONAY");
            entity.Property(e => e.Opaciklama).HasColumnName("OPACIKLAMA");
            entity.Property(e => e.Opkodu).HasColumnName("OPKODU");
            entity.Property(e => e.Ozelalan1).HasColumnName("OZELALAN1");
            entity.Property(e => e.Sehir).HasColumnName("SEHIR");
            entity.Property(e => e.Sevkref).HasColumnName("SEVKREF");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Tel1).HasColumnName("TEL1");
            entity.Property(e => e.Tel2).HasColumnName("TEL2");
            entity.Property(e => e.Ulke).HasColumnName("ULKE");
            entity.Property(e => e.Unvani).HasColumnName("UNVANI");
            entity.Property(e => e.Vdairesi).HasColumnName("VDAIRESI");
            entity.Property(e => e.Vno).HasColumnName("VNO");
        });

        modelBuilder.Entity<SiparisReferan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SIPARIS_REFERANS");

            entity.Property(e => e.Sipno)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("SIPNO");
            entity.Property(e => e.Sipref).HasColumnName("SIPREF");
        });

        modelBuilder.Entity<SiparisReferanslar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SIPARIS_REFERANSLAR");

            entity.Property(e => e.Basimtarihi).HasColumnName("BASIMTARIHI");
            entity.Property(e => e.Durum)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("DURUM");
            entity.Property(e => e.Faturano)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("FATURANO");
            entity.Property(e => e.Faturatarihi)
                .HasColumnType("datetime")
                .HasColumnName("FATURATARIHI");
            entity.Property(e => e.Irsaliyeno)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("IRSALIYENO");
            entity.Property(e => e.Irsaliyetarihi)
                .HasColumnType("datetime")
                .HasColumnName("IRSALIYETARIHI");
            entity.Property(e => e.Siparisid).HasColumnName("SIPARISID");
            entity.Property(e => e.Sipno)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("SIPNO");
            entity.Property(e => e.Sipref).HasColumnName("SIPREF");
            entity.Property(e => e.Songuncelleme).HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Teslimtarihi).HasColumnName("TESLIMTARIHI");
            entity.Property(e => e.Yuklemetarihi).HasColumnName("YUKLEMETARIHI");
        });

        modelBuilder.Entity<Siparisler>(entity =>
        {
            entity.ToTable("SIPARISLER");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktarimdurum).HasColumnName("AKTARIMDURUM");
            entity.Property(e => e.Bruttl)
                .HasColumnType("money")
                .HasColumnName("BRUTTL");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Erpid).HasColumnName("ERPID");
            entity.Property(e => e.Iadesebepid).HasColumnName("IADESEBEPID");
            entity.Property(e => e.Ilgili).HasColumnName("ILGILI");
            entity.Property(e => e.Kargodurum)
                .HasMaxLength(50)
                .HasColumnName("KARGODURUM");
            entity.Property(e => e.Kayittarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("KAYITTARIHI");
            entity.Property(e => e.Kdvtl)
                .HasColumnType("money")
                .HasColumnName("KDVTL");
            entity.Property(e => e.Kullaniciid).HasColumnName("KULLANICIID");
            entity.Property(e => e.Nettl)
                .HasColumnType("money")
                .HasColumnName("NETTL");
            entity.Property(e => e.Odemeplani).HasColumnName("ODEMEPLANI");
            entity.Property(e => e.Odemeplaniid).HasColumnName("ODEMEPLANIID");
            entity.Property(e => e.Onaydurum).HasColumnName("ONAYDURUM");
            entity.Property(e => e.Sevkid).HasColumnName("SEVKID");
            entity.Property(e => e.Sid).HasColumnName("SID");
            entity.Property(e => e.Siparisturu).HasColumnName("SIPARISTURU");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Takipurl)
                .HasMaxLength(200)
                .HasColumnName("TAKIPURL");
            entity.Property(e => e.Termintarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("TERMINTARIHI");
            entity.Property(e => e.Toplamindirim)
                .HasColumnType("money")
                .HasColumnName("TOPLAMINDIRIM");
            entity.Property(e => e.Toplamtl)
                .HasColumnType("money")
                .HasColumnName("TOPLAMTL");
            entity.Property(e => e.Ziyaretid).HasColumnName("ZIYARETID");
        });

        modelBuilder.Entity<SiparislerT>(entity =>
        {
            entity.ToTable("SIPARISLER_T");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktarimdurum).HasColumnName("AKTARIMDURUM");
            entity.Property(e => e.Aktarimmesaji).HasColumnName("AKTARIMMESAJI");
            entity.Property(e => e.Ambar).HasColumnName("AMBAR");
            entity.Property(e => e.Ambarid).HasColumnName("AMBARID");
            entity.Property(e => e.Bruttl)
                .HasColumnType("money")
                .HasColumnName("BRUTTL");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Erpid).HasColumnName("ERPID");
            entity.Property(e => e.Fatura).HasColumnName("FATURA");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.Faturauid)
                .HasMaxLength(50)
                .HasColumnName("FATURAUID");
            entity.Property(e => e.Iadesebepid).HasColumnName("IADESEBEPID");
            entity.Property(e => e.Ilgili).HasColumnName("ILGILI");
            entity.Property(e => e.Iptal).HasColumnName("IPTAL");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Kargodurum)
                .HasMaxLength(50)
                .HasColumnName("KARGODURUM");
            entity.Property(e => e.Kayittarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("KAYITTARIHI");
            entity.Property(e => e.Kdvtl)
                .HasColumnType("money")
                .HasColumnName("KDVTL");
            entity.Property(e => e.Kullaniciid).HasColumnName("KULLANICIID");
            entity.Property(e => e.Nettl)
                .HasColumnType("money")
                .HasColumnName("NETTL");
            entity.Property(e => e.Odemeplani).HasColumnName("ODEMEPLANI");
            entity.Property(e => e.Odemeplaniid).HasColumnName("ODEMEPLANIID");
            entity.Property(e => e.Onaydurum).HasColumnName("ONAYDURUM");
            entity.Property(e => e.Sevkid).HasColumnName("SEVKID");
            entity.Property(e => e.Sid).HasColumnName("SID");
            entity.Property(e => e.Sipariskanal).HasColumnName("SIPARISKANAL");
            entity.Property(e => e.Siparisturu).HasColumnName("SIPARISTURU");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Tabid)
                .HasMaxLength(255)
                .HasColumnName("TABID");
            entity.Property(e => e.Takipurl)
                .HasMaxLength(200)
                .HasColumnName("TAKIPURL");
            entity.Property(e => e.Tamamla).HasColumnName("TAMAMLA");
            entity.Property(e => e.Termintarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("TERMINTARIHI");
            entity.Property(e => e.Toplamindirim)
                .HasColumnType("money")
                .HasColumnName("TOPLAMINDIRIM");
            entity.Property(e => e.Toplamtl)
                .HasColumnType("money")
                .HasColumnName("TOPLAMTL");
            entity.Property(e => e.Uid).HasColumnName("UID");
        });

        modelBuilder.Entity<Siparissatirlari>(entity =>
        {
            entity.ToTable("SIPARISSATIRLARI");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktarimdurum).HasColumnName("AKTARIMDURUM");
            entity.Property(e => e.Birimfiyat)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("BIRIMFIYAT");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Dovizid).HasColumnName("DOVIZID");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.Faturaref).HasColumnName("FATURAREF");
            entity.Property(e => e.Indirimorani).HasColumnName("INDIRIMORANI");
            entity.Property(e => e.Iptaldurum).HasColumnName("IPTALDURUM");
            entity.Property(e => e.Iptalmiktar)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("IPTALMIKTAR");
            entity.Property(e => e.Iptaltarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("IPTALTARIHI");
            entity.Property(e => e.Irsaliyeref).HasColumnName("IRSALIYEREF");
            entity.Property(e => e.Itemref).HasColumnName("ITEMREF");
            entity.Property(e => e.Kampanyadetayid).HasColumnName("KAMPANYADETAYID");
            entity.Property(e => e.Kampanyaisim).HasColumnName("KAMPANYAISIM");
            entity.Property(e => e.Kdv)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("KDV");
            entity.Property(e => e.Miktar)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Satirkdvtl)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("SATIRKDVTL");
            entity.Property(e => e.Satirnettl)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("SATIRNETTL");
            entity.Property(e => e.Satirtoplamtl)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("SATIRTOPLAMTL");
            entity.Property(e => e.Sevkmiktar)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("SEVKMIKTAR");
            entity.Property(e => e.Sid).HasColumnName("SID");
            entity.Property(e => e.Siparisid).HasColumnName("SIPARISID");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Tip).HasColumnName("TIP");
            entity.Property(e => e.Tipstr)
                .HasMaxLength(50)
                .HasColumnName("TIPSTR");
            entity.Property(e => e.Urunid).HasColumnName("URUNID");
        });

        modelBuilder.Entity<SiparissatirlariT>(entity =>
        {
            entity.ToTable("SIPARISSATIRLARI_T", tb => tb.HasTrigger("KAMPANYA_ALOKASYON_HESAPLA_TRIGGER"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktarimdurum).HasColumnName("AKTARIMDURUM");
            entity.Property(e => e.Birimfiyat)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("BIRIMFIYAT");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Dovizid).HasColumnName("DOVIZID");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.Faturaref).HasColumnName("FATURAREF");
            entity.Property(e => e.Indirimorani).HasColumnName("INDIRIMORANI");
            entity.Property(e => e.Iptaldurum).HasColumnName("IPTALDURUM");
            entity.Property(e => e.Iptalmiktar)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("IPTALMIKTAR");
            entity.Property(e => e.Iptaltarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("IPTALTARIHI");
            entity.Property(e => e.Irsaliyeref).HasColumnName("IRSALIYEREF");
            entity.Property(e => e.Itemref).HasColumnName("ITEMREF");
            entity.Property(e => e.Kampanyadetayid).HasColumnName("KAMPANYADETAYID");
            entity.Property(e => e.Kampanyaisim).HasColumnName("KAMPANYAISIM");
            entity.Property(e => e.Kdv)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("KDV");
            entity.Property(e => e.Miktar)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Satirkdvtl)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("SATIRKDVTL");
            entity.Property(e => e.Satirnettl)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("SATIRNETTL");
            entity.Property(e => e.Satirtoplamtl)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("SATIRTOPLAMTL");
            entity.Property(e => e.Sevkmiktar)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("SEVKMIKTAR");
            entity.Property(e => e.Sid).HasColumnName("SID");
            entity.Property(e => e.Siparisid).HasColumnName("SIPARISID");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Tip).HasColumnName("TIP");
            entity.Property(e => e.Tipstr)
                .HasMaxLength(50)
                .HasColumnName("TIPSTR");
            entity.Property(e => e.Urunid).HasColumnName("URUNID");
        });

        modelBuilder.Entity<Stistatistik>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STISTATISTIK");

            entity.Property(e => e.Adetgercek).HasColumnName("ADETGERCEK");
            entity.Property(e => e.Adethedef).HasColumnName("ADETHEDEF");
            entity.Property(e => e.Ay).HasColumnName("AY");
            entity.Property(e => e.Cirogercek)
                .HasColumnType("money")
                .HasColumnName("CIROGERCEK");
            entity.Property(e => e.Cirohakedis)
                .HasColumnType("money")
                .HasColumnName("CIROHAKEDIS");
            entity.Property(e => e.Cirohedef)
                .HasColumnType("money")
                .HasColumnName("CIROHEDEF");
            entity.Property(e => e.Hakedis)
                .HasColumnType("money")
                .HasColumnName("HAKEDIS");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Kapsamgercek).HasColumnName("KAPSAMGERCEK");
            entity.Property(e => e.Kapsamhakedis)
                .HasColumnType("money")
                .HasColumnName("KAPSAMHAKEDIS");
            entity.Property(e => e.Kapsamhedef).HasColumnName("KAPSAMHEDEF");
            entity.Property(e => e.Markagercek).HasColumnName("MARKAGERCEK");
            entity.Property(e => e.Markahakedis)
                .HasColumnType("money")
                .HasColumnName("MARKAHAKEDIS");
            entity.Property(e => e.Markahedef).HasColumnName("MARKAHEDEF");
            entity.Property(e => e.Pmarkagercek).HasColumnName("PMARKAGERCEK");
            entity.Property(e => e.Pmarkahedef).HasColumnName("PMARKAHEDEF");
            entity.Property(e => e.Pskugercek).HasColumnName("PSKUGERCEK");
            entity.Property(e => e.Pskuhakedis)
                .HasColumnType("money")
                .HasColumnName("PSKUHAKEDIS");
            entity.Property(e => e.Pskuhedef).HasColumnName("PSKUHEDEF");
            entity.Property(e => e.Pwmhakedis)
                .HasColumnType("money")
                .HasColumnName("PWMHAKEDIS");
            entity.Property(e => e.Rozet).HasColumnName("ROZET");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("datetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Stsiralama).HasColumnName("STSIRALAMA");
            entity.Property(e => e.Tahsilat)
                .HasColumnType("money")
                .HasColumnName("TAHSILAT");
            entity.Property(e => e.Tahsilatgercek)
                .HasColumnType("money")
                .HasColumnName("TAHSILATGERCEK");
            entity.Property(e => e.Tahsilathakedis)
                .HasColumnType("money")
                .HasColumnName("TAHSILATHAKEDIS");
            entity.Property(e => e.Tahsilathedef)
                .HasColumnType("money")
                .HasColumnName("TAHSILATHEDEF");
            entity.Property(e => e.Toplamhakedis)
                .HasColumnType("money")
                .HasColumnName("TOPLAMHAKEDIS");
            entity.Property(e => e.Yil).HasColumnName("YIL");
        });

        modelBuilder.Entity<StistatistikEski>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_STISTATISTIK");

            entity.ToTable("STISTATISTIK_ESKI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adetgercek)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ADETGERCEK");
            entity.Property(e => e.Adethedef)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ADETHEDEF");
            entity.Property(e => e.Ay).HasColumnName("AY");
            entity.Property(e => e.Cirogercek)
                .HasColumnType("money")
                .HasColumnName("CIROGERCEK");
            entity.Property(e => e.Cirohakedis)
                .HasColumnType("money")
                .HasColumnName("CIROHAKEDIS");
            entity.Property(e => e.Cirohedef)
                .HasColumnType("money")
                .HasColumnName("CIROHEDEF");
            entity.Property(e => e.Dovizid).HasColumnName("DOVIZID");
            entity.Property(e => e.Hakedis)
                .HasColumnType("money")
                .HasColumnName("HAKEDIS");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Kapsamgercek).HasColumnName("KAPSAMGERCEK");
            entity.Property(e => e.Kapsamhakedis)
                .HasColumnType("money")
                .HasColumnName("KAPSAMHAKEDIS");
            entity.Property(e => e.Kapsamhedef).HasColumnName("KAPSAMHEDEF");
            entity.Property(e => e.Markagercek).HasColumnName("MARKAGERCEK");
            entity.Property(e => e.Markahakedis)
                .HasColumnType("money")
                .HasColumnName("MARKAHAKEDIS");
            entity.Property(e => e.Markahedef).HasColumnName("MARKAHEDEF");
            entity.Property(e => e.Pmarkagercek).HasColumnName("PMARKAGERCEK");
            entity.Property(e => e.Pmarkahedef).HasColumnName("PMARKAHEDEF");
            entity.Property(e => e.Pskugercek).HasColumnName("PSKUGERCEK");
            entity.Property(e => e.Pskuhakedis)
                .HasColumnType("money")
                .HasColumnName("PSKUHAKEDIS");
            entity.Property(e => e.Pskuhedef).HasColumnName("PSKUHEDEF");
            entity.Property(e => e.Pwmhakedis)
                .HasColumnType("money")
                .HasColumnName("PWMHAKEDIS");
            entity.Property(e => e.Rozet).HasColumnName("ROZET");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("datetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Stsiralama).HasColumnName("STSIRALAMA");
            entity.Property(e => e.Tahsilat)
                .HasColumnType("money")
                .HasColumnName("TAHSILAT");
            entity.Property(e => e.Tahsilatgercek)
                .HasColumnType("money")
                .HasColumnName("TAHSILATGERCEK");
            entity.Property(e => e.Tahsilathakedis)
                .HasColumnType("money")
                .HasColumnName("TAHSILATHAKEDIS");
            entity.Property(e => e.Tahsilathedef)
                .HasColumnType("money")
                .HasColumnName("TAHSILATHEDEF");
            entity.Property(e => e.Toplamhakedis)
                .HasColumnType("money")
                .HasColumnName("TOPLAMHAKEDIS");
            entity.Property(e => e.Yil).HasColumnName("YIL");
        });

        modelBuilder.Entity<Stoklar>(entity =>
        {
            entity.ToTable("STOKLAR");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Ambarnr).HasColumnName("AMBARNR");
            entity.Property(e => e.Ambarref).HasColumnName("AMBARREF");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Fiilistok)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("FIILISTOK");
            entity.Property(e => e.Gercekstok)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("GERCEKSTOK");
            entity.Property(e => e.Itemref).HasColumnName("ITEMREF");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Tarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<StoklarT>(entity =>
        {
            entity.ToTable("STOKLAR_T");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ambarnr).HasColumnName("AMBARNR");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Fiilistok)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FIILISTOK");
            entity.Property(e => e.Gercekstok)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("GERCEKSTOK");
            entity.Property(e => e.Itemref).HasColumnName("ITEMREF");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Tarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Stokraporu>(entity =>
        {
            entity.ToTable("STOKRAPORU");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Ambarid).HasColumnName("AMBARID");
            entity.Property(e => e.Satinalmafiyati)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("SATINALMAFIYATI");
            entity.Property(e => e.Satisfiyati)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("SATISFIYATI");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stok)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("STOK");
            entity.Property(e => e.Urunid).HasColumnName("URUNID");
        });

        modelBuilder.Entity<StokraporuT>(entity =>
        {
            entity.ToTable("STOKRAPORU_T");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Ambarid).HasColumnName("AMBARID");
            entity.Property(e => e.Satinalmafiyati)
                .HasColumnType("money")
                .HasColumnName("SATINALMAFIYATI");
            entity.Property(e => e.Satisfiyati)
                .HasColumnType("money")
                .HasColumnName("SATISFIYATI");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stok)
                .HasColumnType("money")
                .HasColumnName("STOK");
            entity.Property(e => e.Urunid).HasColumnName("URUNID");
        });

        modelBuilder.Entity<Strut>(entity =>
        {
            entity.ToTable("STRUT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Kayittarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("KAYITTARIHI");
            entity.Property(e => e.Sevkid).HasColumnName("SEVKID");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
        });

        modelBuilder.Entity<Strutgun>(entity =>
        {
            entity.ToTable("STRUTGUN");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Gun).HasColumnName("GUN");
            entity.Property(e => e.Kayitid).HasColumnName("KAYITID");
            entity.Property(e => e.Kayittarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("KAYITTARIHI");
            entity.Property(e => e.Sevkid).HasColumnName("SEVKID");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
        });

        modelBuilder.Entity<Strutziyaretplan>(entity =>
        {
            entity.ToTable("STRUTZIYARETPLAN");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Hesaplananhafta).HasColumnName("HESAPLANANHAFTA");
            entity.Property(e => e.Hesaplananhaftatarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("HESAPLANANHAFTATARIH");
            entity.Property(e => e.Kayitid).HasColumnName("KAYITID");
            entity.Property(e => e.Kayittarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("KAYITTARIHI");
            entity.Property(e => e.Sevkid).HasColumnName("SEVKID");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Ziyarettarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("ZIYARETTARIHI");
            entity.Property(e => e.Ziyarettarihistr).HasColumnName("ZIYARETTARIHISTR");
        });

        modelBuilder.Entity<Tahsilatlar>(entity =>
        {
            entity.ToTable("TAHSILATLAR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktarim).HasColumnName("AKTARIM");
            entity.Property(e => e.Bankaadi).HasColumnName("BANKAADI");
            entity.Property(e => e.Bankahesabi).HasColumnName("BANKAHESABI");
            entity.Property(e => e.Borclu).HasColumnName("BORCLU");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Dovizid).HasColumnName("DOVIZID");
            entity.Property(e => e.Gid).HasColumnName("GID");
            entity.Property(e => e.Gonderildi).HasColumnName("GONDERILDI");
            entity.Property(e => e.Hesapno).HasColumnName("HESAPNO");
            entity.Property(e => e.Islemtarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("ISLEMTARIH");
            entity.Property(e => e.Kasaid).HasColumnName("KASAID");
            entity.Property(e => e.Kaydet).HasColumnName("KAYDET");
            entity.Property(e => e.Kayitid).HasColumnName("KAYITID");
            entity.Property(e => e.Kayittarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("KAYITTARIHI");
            entity.Property(e => e.Makbuznumarasi).HasColumnName("MAKBUZNUMARASI");
            entity.Property(e => e.Onay).HasColumnName("ONAY");
            entity.Property(e => e.Resim).HasColumnName("RESIM");
            entity.Property(e => e.Serino).HasColumnName("SERINO");
            entity.Property(e => e.Sevkid).HasColumnName("SEVKID");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Subeadi).HasColumnName("SUBEADI");
            entity.Property(e => e.Tahsilatturid).HasColumnName("TAHSILATTURID");
            entity.Property(e => e.Tamamla).HasColumnName("TAMAMLA");
            entity.Property(e => e.Tanzimtarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("TANZIMTARIHI");
            entity.Property(e => e.Tid).HasColumnName("TID");
            entity.Property(e => e.Tutar)
                .HasColumnType("money")
                .HasColumnName("TUTAR");
            entity.Property(e => e.Uid).HasColumnName("UID");
            entity.Property(e => e.Vadetarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("VADETARIH");
            entity.Property(e => e.Vkn).HasColumnName("VKN");
            entity.Property(e => e.Yetkili).HasColumnName("YETKILI");
            entity.Property(e => e.Yontem).HasColumnName("YONTEM");
        });

        modelBuilder.Entity<Tahsilatperforman>(entity =>
        {
            entity.ToTable("TAHSILATPERFORMANS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Alacak)
                .HasColumnType("money")
                .HasColumnName("ALACAK");
            entity.Property(e => e.Ay).HasColumnName("AY");
            entity.Property(e => e.Bakiye)
                .HasColumnType("money")
                .HasColumnName("BAKIYE");
            entity.Property(e => e.Borc)
                .HasColumnType("money")
                .HasColumnName("BORC");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Odemeturu)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ODEMETURU");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Yil).HasColumnName("YIL");
        });

        modelBuilder.Entity<Tahsilatturleri>(entity =>
        {
            entity.ToTable("TAHSILATTURLERI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Tur)
                .HasMaxLength(50)
                .HasColumnName("TUR");
        });

        modelBuilder.Entity<Takvim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TAKVIM_1");

            entity.ToTable("TAKVIM");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Baslangictarihi)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGICTARIHI");
            entity.Property(e => e.Baslangictarihistr).HasColumnName("BASLANGICTARIHISTR");
            entity.Property(e => e.Baslik)
                .HasMaxLength(50)
                .HasColumnName("BASLIK");
            entity.Property(e => e.Bitistarihi)
                .HasColumnType("datetime")
                .HasColumnName("BITISTARIHI");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Renk)
                .HasMaxLength(50)
                .HasColumnName("RENK");
            entity.Property(e => e.Tumgun).HasColumnName("TUMGUN");
        });

        modelBuilder.Entity<Talepler>(entity =>
        {
            entity.ToTable("TALEPLER");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ambarid).HasColumnName("AMBARID");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Tarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Termintarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("TERMINTARIHI");
        });

        modelBuilder.Entity<Talepsatirlari>(entity =>
        {
            entity.ToTable("TALEPSATIRLARI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Miktar)
                .HasColumnType("money")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Talepid).HasColumnName("TALEPID");
            entity.Property(e => e.Urunid).HasColumnName("URUNID");
        });

        modelBuilder.Entity<Tanimlamalar>(entity =>
        {
            entity.ToTable("TANIMLAMALAR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .HasColumnName("KOD");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Tanim)
                .HasMaxLength(100)
                .HasColumnName("TANIM");
            entity.Property(e => e.Tip).HasColumnName("TIP");
        });

        modelBuilder.Entity<Urunbirimleri>(entity =>
        {
            entity.ToTable("URUNBIRIMLERI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Anabirim).HasColumnName("ANABIRIM");
            entity.Property(e => e.Birimref).HasColumnName("BIRIMREF");
            entity.Property(e => e.Cevrimkatsayi)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("CEVRIMKATSAYI");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Itemref).HasColumnName("ITEMREF");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<UrunbirimleriT>(entity =>
        {
            entity.ToTable("URUNBIRIMLERI_T");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Anabirim).HasColumnName("ANABIRIM");
            entity.Property(e => e.Birimref).HasColumnName("BIRIMREF");
            entity.Property(e => e.Cevrimkatsayi)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("CEVRIMKATSAYI");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Itemref).HasColumnName("ITEMREF");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
        });

        modelBuilder.Entity<Urunkategorileri>(entity =>
        {
            entity.ToTable("URUNKATEGORILERI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.Isim)
                .HasMaxLength(50)
                .HasColumnName("ISIM");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .HasColumnName("KOD");
            entity.Property(e => e.Kullaniciid).HasColumnName("KULLANICIID");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Ustid).HasColumnName("USTID");
        });

        modelBuilder.Entity<Urunler>(entity =>
        {
            entity.ToTable("URUNLER");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Adi)
                .HasMaxLength(50)
                .HasColumnName("ADI");
            entity.Property(e => e.Barkod)
                .HasMaxLength(101)
                .IsUnicode(false)
                .HasColumnName("BARKOD");
            entity.Property(e => e.Birimsetid).HasColumnName("BIRIMSETID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.Grupkodu)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("GRUPKODU");
            entity.Property(e => e.Imgurl1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("IMGURL1");
            entity.Property(e => e.Imgurl2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("IMGURL2");
            entity.Property(e => e.Imgurl3)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("IMGURL3");
            entity.Property(e => e.Imgurl4)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("IMGURL4");
            entity.Property(e => e.Imgurl5)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("IMGURL5");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Kategoriid).HasColumnName("KATEGORIID");
            entity.Property(e => e.Kayittarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("KAYITTARIHI");
            entity.Property(e => e.Kdvalis)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("KDVALIS");
            entity.Property(e => e.Kdvsatis)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("KDVSATIS");
            entity.Property(e => e.Kisaadi)
                .HasMaxLength(50)
                .HasColumnName("KISAADI");
            entity.Property(e => e.Kodu)
                .HasMaxLength(25)
                .HasColumnName("KODU");
            entity.Property(e => e.Muadil)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("MUADIL");
            entity.Property(e => e.Ozelalan1)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("OZELALAN1");
            entity.Property(e => e.Ozelalan2)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("OZELALAN2");
            entity.Property(e => e.Ozelalan3)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("OZELALAN3");
            entity.Property(e => e.Ozelalan4)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("OZELALAN4");
            entity.Property(e => e.Ozelalan5)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("OZELALAN5");
            entity.Property(e => e.Psku).HasColumnName("PSKU");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Tur)
                .HasMaxLength(30)
                .HasColumnName("TUR");
            entity.Property(e => e.Uretici)
                .HasMaxLength(101)
                .IsUnicode(false)
                .HasColumnName("URETICI");
            entity.Property(e => e.Urunref).HasColumnName("URUNREF");
            entity.Property(e => e.Yenimi).HasColumnName("YENIMI");
            entity.Property(e => e.Yetkikodu)
                .HasMaxLength(25)
                .HasColumnName("YETKIKODU");
        });

        modelBuilder.Entity<UrunlerT>(entity =>
        {
            entity.ToTable("URUNLER_T");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Adi)
                .HasMaxLength(50)
                .HasColumnName("ADI");
            entity.Property(e => e.Barkod)
                .HasMaxLength(50)
                .HasColumnName("BARKOD");
            entity.Property(e => e.Birimsetid).HasColumnName("BIRIMSETID");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Dovizid).HasColumnName("DOVIZID");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.Fiyat)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Grupkodu)
                .HasMaxLength(200)
                .HasColumnName("GRUPKODU");
            entity.Property(e => e.Imgurl1)
                .HasMaxLength(200)
                .HasColumnName("IMGURL1");
            entity.Property(e => e.Imgurl2)
                .HasMaxLength(200)
                .HasColumnName("IMGURL2");
            entity.Property(e => e.Imgurl3)
                .HasMaxLength(200)
                .HasColumnName("IMGURL3");
            entity.Property(e => e.Imgurl4)
                .HasMaxLength(200)
                .HasColumnName("IMGURL4");
            entity.Property(e => e.Imgurl5)
                .HasMaxLength(200)
                .HasColumnName("IMGURL5");
            entity.Property(e => e.Isyeriid).HasColumnName("ISYERIID");
            entity.Property(e => e.Kasa)
                .HasMaxLength(50)
                .HasColumnName("KASA");
            entity.Property(e => e.Kategoriid).HasColumnName("KATEGORIID");
            entity.Property(e => e.Kayittarihi)
                .HasColumnType("smalldatetime")
                .HasColumnName("KAYITTARIHI");
            entity.Property(e => e.Kdvalis)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("KDVALIS");
            entity.Property(e => e.Kdvsatis)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("KDVSATIS");
            entity.Property(e => e.Kisaadi)
                .HasMaxLength(50)
                .HasColumnName("KISAADI");
            entity.Property(e => e.Kodu)
                .HasMaxLength(50)
                .HasColumnName("KODU");
            entity.Property(e => e.Marka)
                .HasMaxLength(50)
                .HasColumnName("MARKA");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .HasColumnName("MODEL");
            entity.Property(e => e.Muadil)
                .HasMaxLength(50)
                .HasColumnName("MUADIL");
            entity.Property(e => e.Ozelalan1)
                .HasMaxLength(200)
                .HasColumnName("OZELALAN1");
            entity.Property(e => e.Ozelalan2)
                .HasMaxLength(200)
                .HasColumnName("OZELALAN2");
            entity.Property(e => e.Ozelalan3)
                .HasMaxLength(200)
                .HasColumnName("OZELALAN3");
            entity.Property(e => e.Ozelalan4)
                .HasMaxLength(200)
                .HasColumnName("OZELALAN4");
            entity.Property(e => e.Ozelalan5)
                .HasMaxLength(200)
                .HasColumnName("OZELALAN5");
            entity.Property(e => e.Psku).HasColumnName("PSKU");
            entity.Property(e => e.Raf)
                .HasMaxLength(50)
                .HasColumnName("RAF");
            entity.Property(e => e.Sezon)
                .HasMaxLength(50)
                .HasColumnName("SEZON");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stok)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("STOK");
            entity.Property(e => e.Tur)
                .HasMaxLength(50)
                .HasColumnName("TUR");
            entity.Property(e => e.Uretici)
                .HasMaxLength(50)
                .HasColumnName("URETICI");
            entity.Property(e => e.Urunref).HasColumnName("URUNREF");
            entity.Property(e => e.Yenimi).HasColumnName("YENIMI");
        });

        modelBuilder.Entity<ZiyaretPerforman>(entity =>
        {
            entity.ToTable("ZIYARET_PERFORMANS");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CariKodu)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("CARI_KODU");
            entity.Property(e => e.CariUnvani)
                .HasMaxLength(50)
                .HasColumnName("CARI_UNVANI");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.Gunno)
                .HasDefaultValueSql("((1))")
                .HasColumnName("GUNNO");
            entity.Property(e => e.HaritadaGoster)
                .HasMaxLength(116)
                .IsUnicode(false)
                .HasColumnName("HARITADA_GOSTER");
            entity.Property(e => e.Isyeri)
                .HasMaxLength(10)
                .HasColumnName("ISYERI");
            entity.Property(e => e.PlanlananZiyaretTarihi)
                .HasMaxLength(4000)
                .HasColumnName("PLANLANAN_ZIYARET_TARIHI");
            entity.Property(e => e.RaporTarihFiltresi)
                .HasColumnType("date")
                .HasColumnName("RAPOR_TARIH_FILTRESI");
            entity.Property(e => e.RotaIciMi)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("ROTA_ICI_MI");
            entity.Property(e => e.SevkAdresiKodu)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SEVK_ADRESI_KODU");
            entity.Property(e => e.SevkAdresiUnvani)
                .HasMaxLength(50)
                .HasColumnName("SEVK_ADRESI_UNVANI");
            entity.Property(e => e.SiparisVarMi)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("SIPARIS_VAR_MI");
            entity.Property(e => e.StAdi)
                .HasMaxLength(50)
                .HasColumnName("ST_ADI");
            entity.Property(e => e.StKodu)
                .HasMaxLength(50)
                .HasColumnName("ST_KODU");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.TahsilatVarMi)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("TAHSILAT_VAR_MI");
            entity.Property(e => e.YerindeMi)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("YERINDE_MI");
            entity.Property(e => e.ZiyaretBaslangici)
                .HasMaxLength(4000)
                .HasColumnName("ZIYARET_BASLANGICI");
            entity.Property(e => e.ZiyaretBitisi)
                .HasMaxLength(4000)
                .HasColumnName("ZIYARET_BITISI");
            entity.Property(e => e.ZiyaretSuresi)
                .HasMaxLength(57)
                .IsUnicode(false)
                .HasColumnName("ZIYARET_SURESI");
        });

        modelBuilder.Entity<Ziyaretler>(entity =>
        {
            entity.ToTable("ZIYARETLER");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Baslat)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("BASLAT");
            entity.Property(e => e.Baslng)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("BASLNG");
            entity.Property(e => e.Bastarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("BASTARIH");
            entity.Property(e => e.Bitlat)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("BITLAT");
            entity.Property(e => e.Bitlng)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("BITLNG");
            entity.Property(e => e.Bittarih)
                .HasColumnType("smalldatetime")
                .HasColumnName("BITTARIH");
            entity.Property(e => e.Cariid).HasColumnName("CARIID");
            entity.Property(e => e.Devam).HasColumnName("DEVAM");
            entity.Property(e => e.Distid).HasColumnName("DISTID");
            entity.Property(e => e.Iadetutari)
                .HasColumnType("money")
                .HasColumnName("IADETUTARI");
            entity.Property(e => e.Rotaici).HasColumnName("ROTAICI");
            entity.Property(e => e.Sevklat)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SEVKLAT");
            entity.Property(e => e.Sevklng)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("SEVKLNG");
            entity.Property(e => e.Sevkref).HasColumnName("SEVKREF");
            entity.Property(e => e.Siparistutari)
                .HasColumnType("money")
                .HasColumnName("SIPARISTUTARI");
            entity.Property(e => e.Songuncelleme)
                .HasColumnType("smalldatetime")
                .HasColumnName("SONGUNCELLEME");
            entity.Property(e => e.Stid).HasColumnName("STID");
            entity.Property(e => e.Stref).HasColumnName("STREF");
            entity.Property(e => e.Tahsilattutari)
                .HasColumnType("money")
                .HasColumnName("TAHSILATTUTARI");
            entity.Property(e => e.Uid).HasColumnName("UID");
            entity.Property(e => e.Yerindemi).HasColumnName("YERINDEMI");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
