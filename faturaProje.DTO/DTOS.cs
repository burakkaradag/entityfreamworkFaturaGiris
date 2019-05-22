using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faturaProje.DTO
{
   public class DTOS
    {
        public class FaturaDetayDTO
        {
            public int FaturaNo { get; set; }
            public int UunId { get; set; }
            public string UrunAd { get; set; }
            public decimal Adet { get; set; }
            public decimal birimfiyat { get; set; }
            public decimal Toplam { get; set; }
        }

        public class TanimDTO
        {
            public int Id { get; set; }
            public string Ad { get; set; }
        }

        public class UrunDTO
        {
            public int UrunId { get; set; }
            public string UrunAd { get; set; }
            public decimal BirimFiyat { get; set; }
            public decimal kdv { get; set; }
            public string kategoriad { get; set; }
            public string birimad { get; set; }
        }

        public class IlceDTO
        {
            public int IlceId { get; set; }
            public string IlceAd { get; set; }
            public string IlAd { get; set; }

        }

        public class MusteriDTO
        {
            public int MusteriId { get; set; }
            public string Musteriad { get; set; }
            public string Adres { get; set; }
            public string vergidai { get; set; }
            public string ilcead { get; set; }
            public string ilad { get; set; }

        }


    }
}
