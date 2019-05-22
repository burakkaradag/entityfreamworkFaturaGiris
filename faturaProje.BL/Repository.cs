using faturaProje.REP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static faturaProje.DTO.DTOS;
using static faturaProje.ENT.Entities;

namespace faturaProje.BL
{
    public class Repository
    {
        public class RepFaturaMaster : BaseRepository<FaturaMaster>
        {
            public bool faturakontrol(int id)
            {
               FaturaMaster fm= bul(id);
                if (fm == null)
                {
                    return false;
                }
                else return true;
            }

            public void  toplamal(decimal toplam,int id)
            {
                bul(id).FatToplam = toplam;
                kaydet();
            }

        }
        public class RepFaturaDetay : BaseRepository<FaturaDetay>
        {
            public List<FaturaDetayDTO> doldur(int id)
            {
                return genelliste().Select(x => new FaturaDetayDTO
                {
                    FaturaNo = x.FaturaNo,
                    UunId = x.UrunId,
                    UrunAd = x.Urun.UrunAd,
                    Adet = x.Adet,
                    birimfiyat=x.Urun.BirimFiyat,
                    Toplam = x.Toplam //x.adet*x.urun.birimfiyat
                }).Where(x=>x.FaturaNo==id).ToList();
            }
        }
        public class RepUrun : BaseRepository<Urun>, IComboRep
        {
            public List<UrunDTO> Doldur()
            {
                return genelliste().Select(x => new UrunDTO
                {
                    UrunId=x.UrunId,
                    UrunAd=x.UrunAd,
                    BirimFiyat=x.BirimFiyat,
                    kdv=x.KDV,
                    kategoriad=x.Kategori.KategoriAd,
                    birimad=x.Birim.BirimAd

                }).ToList();
            }
            public ComboBox combodoldur(ComboBox cmb)
            {
                cmb.DataSource = genelliste().Select(x => new
                {
                    x.UrunId,
                    x.UrunAd

                }).ToList();
                cmb.DisplayMember = "UrunAd";
                cmb.ValueMember = "UrunId";
                return cmb;

            }
        }
        public class RepMusteri : BaseRepository<Musteri>, IComboRep
        {
            public List<MusteriDTO> doldur()
            {
               return genelliste().Select(x => new MusteriDTO
                {
                    MusteriId = x.MusteriId,
                    Musteriad = x.MusteriAd,
                    Adres = x.Adres,
                    vergidai = x.VergiDairesi,
                    ilcead = x.Ilce.IlceAd,
                    ilad = x.Ilce.Il.IlAd

                }).ToList();
            }
            public ComboBox combodoldur(ComboBox cmb)
            {
                cmb.DataSource = genelliste().Select(x => new
                {
                    x.MusteriId,
                    x.MusteriAd

                }).ToList();
                cmb.DisplayMember = "MusteriAd";
                cmb.ValueMember = "MusteriId";
                return cmb;
            }
        }
        public class RepKategori : BaseRepository<Kategori>, IComboRep
        {
            public ComboBox combodoldur(ComboBox cmb)
            {
                cmb.DataSource = genelliste().Select(x => new
                {
                    x.KategoriId,
                    x.KategoriAd

                }).ToList();
                cmb.DisplayMember = "KategoriAd";
                cmb.ValueMember = "KategoriId";
                return cmb;
            }

            public List<TanimDTO> Doldur()
            {
                return genelliste().Select(x => new TanimDTO
                {
                    Id = x.KategoriId,
                    Ad = x.KategoriAd

                }).ToList();
            }
        }
        public class RepIl : BaseRepository<Il>, IComboRep
        {
            public ComboBox combodoldur(ComboBox cmb)
            {
                cmb.DataSource = genelliste().Select(x => new
                {
                    x.IlId,
                    x.IlAd

                }).ToList();
                cmb.DisplayMember = "IlAd";
                cmb.ValueMember = "IlId";
                return cmb;
            }

            public List<TanimDTO> Doldur()
            {
                return genelliste().Select(x => new TanimDTO
                {
                    Id = x.IlId,
                    Ad = x.IlAd

                }).ToList();
            }
        }
        public class RepIlce : BaseRepository<Ilce>
        {
            public List<IlceDTO> Doldur()
            {
                return genelliste().Select(x => new IlceDTO
                {
                   IlceId=x.IlceId,
                   IlceAd=x.IlceAd,
                   IlAd=x.Il.IlAd

                }).ToList();
            }
            
            public ComboBox combodoldur(ComboBox cmb)
            {
                cmb.DataSource = genelliste().Select(x => new
                {
                    x.IlceAd,
                    x.IlceId
                }).ToList();

                cmb.DisplayMember = "IlceAd";
                cmb.ValueMember = "IlceId";
                return cmb;
            }

        }
        public class RepBirim : BaseRepository<Birim>, IComboRep
        {
            public ComboBox combodoldur(ComboBox cmb)
            {
                cmb.DataSource = genelliste().Select(x => new
                {
                    x.BirimId,
                    x.BirimAd

                }).ToList();
                cmb.DisplayMember = "BirimAd";
                cmb.ValueMember = "BirimId";
                return cmb;
            }

            public List<TanimDTO> Doldur()
            {
                return genelliste().Select(x => new TanimDTO
                {
                    Id = x.BirimId,
                    Ad = x.BirimAd

                }).ToList();
            }
        }
    }
}
