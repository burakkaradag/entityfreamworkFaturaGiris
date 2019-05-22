using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faturaProje.ENT
{
    public class Entities
    {
        [Table("FaturaMaster")]
        public class FaturaMaster
        {
            public FaturaMaster()
            {
                FaturaDetay = new HashSet<FaturaDetay>();
            }   
            [Key]
            public int FaturaNo { get; set; }
            public int MusteriId { get; set; }
            public DateTime Tarih { get; set; }
            public decimal FatToplam { get; set; }

            public virtual ICollection<FaturaDetay> FaturaDetay { get; set; }
            [ForeignKey("MusteriId")]
            public virtual Musteri Musteri { get; set; }
        }

        [Table("FaturaDetay")]
        public class FaturaDetay
        {
            [Key,Column(Order =0)]
            public int FaturaNo { get; set; }
            [Key,Column(Order =1)]
            public int UrunId { get; set; }
            public decimal Adet { get; set; }
            public decimal Toplam { get; set; }
            [ForeignKey("FaturaNo")]
            public virtual FaturaMaster FaturaMaster { get; set; }
            [ForeignKey("UrunId")]
            public virtual Urun Urun { get; set; }

        }

        [Table("Urun")]
        public class Urun
        {
            public Urun()
            {
                FaturaDetay = new HashSet<FaturaDetay>();     
            }
            [Key]
            public int UrunId { get; set; }
            public string UrunAd { get; set; }
            public decimal BirimFiyat { get; set; }
            public int BirimId { get; set; }
            public int KategoriId { get; set; }
            public decimal KDV { get; set; }

            public virtual ICollection<FaturaDetay> FaturaDetay { get; set; }

            [ForeignKey("BirimId")]
            public virtual Birim Birim { get; set; }

            [ForeignKey("KategoriId")]
            public virtual Kategori Kategori { get; set; }

        }

        [Table("Birim")]
        public class Birim
        {
            public Birim()
            {
                Urun = new HashSet<Urun>();
            }
            [Key]
            public int BirimId { get; set; }
            public string BirimAd { get; set; }

            public virtual ICollection<Urun> Urun { get; set; }

        }

        [Table("Kategori")]
        public class Kategori
        {
            public Kategori()
            {
                Urun = new HashSet<Urun>();
            }
            [Key]
            public int KategoriId { get; set; }
            public string KategoriAd { get; set; }

            public virtual ICollection<Urun> Urun { get; set; }

        }

        [Table("Musteri")]
        public class Musteri
        {
            public Musteri()
            {
                FaturaMaster = new HashSet<FaturaMaster>();    
            }
            [Key]
            public int MusteriId { get; set; }
            public string MusteriAd { get; set; }
            public string Adres { get; set; }
            public string VergiDairesi { get; set; }
            public int IlceId { get; set; }

            [ForeignKey("IlceId")]
            public virtual Ilce Ilce { get; set; }

            public virtual ICollection<FaturaMaster> FaturaMaster { get; set; }

        }

        [Table("Il")]
        public class Il
        {
            public Il()
            {
                Ilce = new HashSet<Ilce>();
            }
            [Key]
            public int IlId { get; set; }
            public string IlAd { get; set; }

            public virtual ICollection<Ilce> Ilce { get; set; }

        }

        [Table("Ilce")]
        public class Ilce
        {
            public Ilce()
            {
                Musteri = new HashSet<Musteri>();
            }
            [Key]
            public int IlceId { get; set; }
            public string IlceAd { get; set; }
            public int IlId { get; set; }

            [ForeignKey("IlId")]
            public virtual Il Il { get; set; }

            public virtual ICollection<Musteri> Musteri { get; set; }


        }


    }
}
