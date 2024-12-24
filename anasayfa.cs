using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatbotv1
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        List<string> akademikAnahtarKelimeler = new List<string>
        {
         "akademik", "akademi", "akafemik", "akdemik", "akadmik", "akademk", "akademic", "akademıc",
         "akademik işlem", "akademik islemler", "akadamik", "akadmik işlem", "akadmik islemler",
         "akademk işlem", "akadimik", "akadamik islemler", "akadimek", "akamedik", "akadimik işlem",
         "akdmik", "akadimik islemler", "akadami", "akademia", "akademis", "akdm islemler", "akademe",
         "akdm işlem", "akadami işlem", "akafimik", "akdmk", "akdmik", "akadimia", "akadmık", "akdmık",
         "akade", "akademk islemleri", "akadık", "akademık işlem", "akademii", "akdımı", "akadimm",
         "akadım", "akadmı", "akademiş", "akademik işlemi", "akademik islemi", "akadimik işlm", "akademiş",
         "akademı işlem", "akadım işlemler", "akdimi", "akademici", "akademisyeni", "akademikss",
         "akademik işlemesi", "akademislemleri", "akadı", "akadmi", "akadımis", "akadık islemleri",
         "akademik islemler", "akdm islemi", "akademim", "akademisi", "akadim işlemi", "akadımla",
         "akademi işlemleri", "akadamak", "akademisi", "akadermik", "akademik işle", "akadmis", "akademislemi",
         "akademişme", "akademisyen", "akademik işlemcisi", "akademişlem", "akdemik islemci", "akadım işlemi",
         "akadamic", "akademikle", "akademy", "akemik", "akemi", "akademi işlm", "akademik işlemeler",
         "akdm ik", "akdms", "akademl"
        };

        List<string> kayitAnahtarKelimeler = new List<string>
{
    "kayıt", "kayit", "kıayt", "kayyt", "kaıt", "kayyt", "kayıd", "kaydı", "kayid", "kayyd",
    "kayıt işlemleri", "kayit islemleri", "kıayit", "kayıyt", "kayit işlem", "kayıt işlem",
    "kayyt işlemleri", "kaıt islemleri", "kayyd islemleri", "kayıyt islemler", "kayyt islemler",
    "kayyıt işlemler", "kayıyt işlem", "kaytt işlem", "kayıid", "kayıid islemler", "kayt islemler",
    "kaid islemler", "kayyt islemi", "kayıt işlemi", "kayt işlemleri", "kayıt işlemleri", "kaydı islemleri",
    "kayit işlemi", "kaytt islemler", "kayit islemi", "kayitt", "kaytım", "kaydim", "kayıt islemi",
    "kayyıt", "kayit işlemeleri", "kayıt işlemci", "kayıt işlemler", "kayit islemesi", "kayit işlemes",
    "kayyd işlem", "kaıt işlemi", "kayıd islemleri", "kayıt işlemesi", "kaytt işlemesi", "kayıt işlemi",
    "kayıt işlemlerim", "kayıt islemlerim", "kayıt işlm", "kayıt işlmeleri", "kaydı işlemi", "kaydı işlemleri",
    "kayit islemleri", "kayit işlm", "kayt islemleri", "kaıt işlem", "kaydı işlem", "kaydi işlemi",
    "kayit islemi", "kayyt işlm", "kayyıt islemleri"
};

        List<string> belgeAnahtarKelimeler = new List<string>
{
    "belge", "belgeler", "belgelerim", "belger", "belges", "belgele", "belgeleme", "belgelemeler",
    "belgeim", "belgesel", "belgeleri", "belgr", "belg", "belgrler", "belgelr", "belgler",
    "belgelar", "belgesler", "belgeişlemleri", "belgeselr", "belgelemeleri", "belgelem", "belgerim",
    "belgerler", "belgeleri", "belgerlerim", "belgelerim", "belgerleme", "belgelerme", "belgesel",
    "belgelerin", "belgeleriyle", "belgerlerim", "belgerleme", "belgelerimle", "belgelerli", "belgelr",
    "belgemi", "belgelerimi", "belgeli", "belgelerimiz", "belgesi", "belgelerimle", "belgelerden",
    "belgeislem", "belgesle", "belgesleri", "belgelerde", "belgelerinin", "belgeyim", "belgem",
    "belgeslerim", "belgeleriniz", "belgelee", "belgelerimden", "belgeselr", "belgeleme işlemleri",
    "belgelerim işlemleri", "belgeselr işlemleri", "belgeli işlem", "belgesel işlemleri", "belgeleme işlem",
    "belgelerim işlm", "belgelerim işlem", "belgesel işlemi", "belgelr işlemi", "belgeleme işlemi",
    "belgelemelerim", "belger işlemleri", "belgeleme islemleri", "belgelr işlemi", "belgelar işlemleri"
};

        List<string> hizlierisimAnahtarKelimeler = new List<string>
{
    "hızlıerişim", "hizlierisim", "hizlıerisim", "hızlı erşm", "hizli erşm", "hızl erşim",
    "hızlı erişimi", "hizli erişmi", "hızlı erişime", "hızle erişim", "hizle erşim",
    "hızlı erişiler", "hızly erişm", "hızlı erişim", "hızlı erişim işlemleri", "hizlierişim",
    "hızlırışım", "hizli erişimler", "hızlı erşim", "hızlıerisim", "hızlırişim", "hızlı erişimler",
    "hizl erışım", "hızlı erışim", "hızlı erişimle", "hızlı erişm", "hizli erişimler", "hizl erişim",
    "hızlı erişm", "hızlı erişimlerin", "hızlıerışım", "hızlı erişimler", "hızlı erişim",
    "hızlı erişimle", "hızlı erşm", "hızlır erişim", "hızlır erşim", "hızlı erşimle", "hızlı erşim",
    "hızlı erişimle", "hizli erişm", "hızlı erisim", "hızlı erişim"
};

        List<string> odemeAnahtarKelimeler = new List<string>
{
    "ödeme", "odeme", "ödemeler", "odemeler", "ödeme işlemleri", "odeme islemleri", "ödemeislemleri",
    "odemeislemleri", "ödeme işlem", "odeme islem", "ödemeislem", "odemeislem", "ödemesi",
    "odemesi", "ödeme işlemi", "odeme islemi", "ödemelerim", "odemelerim", "ödemele", "ödemle",
    "ödmlr", "ödmler", "ödemlr", "ödöme", "odmee", "ödmeler", "ödeme işlemleri", "odeme islemleri",
    "ödeme islem", "odeme islemleri", "ödeme islem", "odme islem", "odmelr", "ödme islemleri",
    "ödöme islemleri", "odeme işlemeleri", "ödemelerim", "ödemesi", "ödeme işlemesi", "ödemeislem",
    "odme işlemi", "ödemeleri", "odeme işlemlerim", "odmelr işlemleri", "odmelr işlem", "odme işlemleri",
    "ödemelerim işlemleri", "ödme işlemlerim", "odeme islemesi", "ödemeleri işlem", "odeme işlem",
    "ödeme işlemleri", "odeme islemleri", "ödme işlemi", "ödeme işlm", "odeme işlemi", "odeme islem",
    "ödemeislem", "odemeislem", "ödemelerim islemleri", "ödemesi islemleri", "odeme islemi"
};

        List<string> iletisimAnahtarKelimeler = new List<string>
{
    "iletişim", "iletisim", "iletişim sayfası", "iletisim sayfasi", "iletişm", "iletis", "ileti",
    "iletyşim", "iletşm", "iletyşm", "iletişmm", "iletsm", "iletişi", "iletisi", "iletşm",
    "ileteşim", "ileteşm", "ileytisim", "ileytşm", "iletisim sayfasi", "iletisim sayfasi",
    "iletişim sayfası", "iletişim", "iletsm", "iletişimle", "iletisimle", "iletişim işlemleri",
    "iletisimle sayfa", "iletisim sayfası", "iletisim islem", "iletisim işlemi", "iletişmle",
    "iletişim sayfası", "iletişim sayfa", "iletişim", "iletişm sayfasi", "iletişimi"
};
        List<string> dersProgramiAnahtarKelimeler = new List<string>
{
    "ders programı", "dersprogramı", "dersprogram", "ders prgramı", "ders progrmı", "ders prgarmı",
    "ders progarmı", "ders prgram", "dersprogarmı", "ders program", "dersprogrami", "ders prog",
    "dersproğramı", "dersprgramı", "dersprogamı", "dersprogramı", "dersprogarmı", "ders proframı",
    "ders prgramı", "ders progarmı", "ders progarmı", "dersprogrammi", "ders progıramı"
};
        List<string> devamsizlikAnahtarKelimeler = new List<string>
{
    "devamsızlık bilgisi", "devamsızlık", "devamsızlık durumu", "devamsızlık bilgileri", "devamsızlık raporu",
    "devamsızlık oranı", "devamsızlık işlemleri", "devamsızlık kaydı", "devamsızlık durumu bilgisi", "devamsızlık bilgisi raporu",
    "devamsızlık sorgulama", "devamsızlık sorgusu", "devamsızlık işlemi", "devamsızlık belgesi", "devamsızlık takibi",
    "devamsızlık verisi", "devamsızlıkları", "devamsızlıklar", "devamsızlık listesi", "devamsızlık kaydı sorgulama",
    "devamsızlık oranı sorgulama", "devamsızlık sorgulaması", "devamsızlık raporu sorgulama", "devamsızlık takip bilgisi",
    "devamsızlıkla ilgili bilgi", "devamsızlık bilgi", "devamsızlık kayıtları", "devamsızlık durumu öğrenme", "devamsızlık bilgisi sorgulama"
};
        List<string> notAnahtarKelimeler = new List<string>
{
    "not görüntüleme", "notlarım", "notlar", "not", "not bilgisi", "notlarımı", "notlar",
    "not görüntüle", "not göster", "notlarımı göster", "not bak", "not gösterme", "notlarımı öğren",
    "not sorgula", "not sorgulama", "not öğren", "not bilgin", "not kontrol et", "not bilgisi görüntüle"
};
        List<string> sinavTarihiYerAnahtarKelimeler = new List<string>
{
    "sınav tarihi", "sınav yeri", "sınav tarihi ve yeri", "sınav ne zaman", "sınav nerede",
    "sınav tarihleri", "sınav yerleri", "sınav tarihi öğren", "sınav yeri öğren", "sınav tarihleri öğren",
    "sınav yeri bilgisi", "sınav tarih bilgisi", "sınav ne zaman olacak", "sınav hangi gün", "sınavın tarihi",
    "sınavın yeri", "sınav tarihlerim", "sınav yerim", "sınav tarihim", "sınav yerim neresi",
    "sınav günü", "sınav günü ve yeri", "sınav tarihi ve saati", "sınav nerede yapılacak", "sınav yerini öğren", "sınav", "sınavlarım"
};
        List<string> dersKayitAnahtarKelimeler = new List<string>
{
    "kayıt yenileme", "kayit yenileme", "kayit yenileme", "kayıtyenileme", "kayityenileme", "kayıt yenıleme",
    "kayıt yenilemm", "kayıt yenilemesi", "kayıtyenıleme", "kayit yenıleme", "kayit yenılemesi", "ders kaydı",
    "ders kayit", "ders kayit işlemi", "ders kayit işlemleri", "ders kayıt", "derskayit", "derskaydı",
    "ders kayit yenileme", "ders kayıt yenileme", "ders kayit sorgulama", "ders kayıt sorgulama", "ders kayıt işlemleri",
    "ders kaydi yenileme", "ders kayıdı yenileme", "ders kaydi", "ders kayıdı", "ders kayit durumu",
    "ders kayit durumu sorgulama", "ders kayit durumu sorgula", "ders kayıt durumu sorgulama", "ders kayıt sorgula",
    "ders kaydınız", "ders kaydınız yenileme", "ders kaydınızı yenileyin", "ders kaydı sorgulama",
    "ders kaydını sorgula", "ders kaydınız", "ders kayıt işlemleri", "kayıt durumunu sorgulama",
    "kayıt durumu sorgulama", "kayıt durumu", "kayit durumu", "kayıt durum", "kayit durum sorgulama",
    "kayıt işlemi", "kayit işlemi", "ders kayit işlemi", "ders kaydı sorgulama", "ders kaydınız",
    "ders kaydını", "ders kaydını sorgulama", "ders kaydınızı sorgulayın", "ders kaydı yenileme",
    "ders kaydınızı yenileyin", "ders kaydı yenileme işlemi", "ders kaydı yenileme işlemleri",
    "ders kayit yeniden", "ders kaydi yenileme", "ders kaydını yenileyin", "ders kaydınızı yenileyin",
    "ders kayıt sorgulama", "ders kayıt durumu", "kayit durumu sorgulama", "ders kaydı bilgileriniz"
};
        List<string> transkriptAnahtarKelimeler = new List<string>
{
    "transkript", "transkrip", "transkripte", "transcripte", "transkrip belgesi", "transkript belgesi",
    "transkrip belgesi", "transcript belgesi", "transkriptem", "transkriptt", "transkipt", "transkript belgeleri",
    "transkriptn", "transkriptler", "transcript", "transkript işlemi", "transkript alma", "transkript talep",
    "transkript sorgulama", "transkript alma işlemi", "transkript bilgisi", "transkript sorgula",
    "transkript belgelerini", "transkript almak", "transkripti", "transkript belgesi almak",
    "transkripti alma", "transkript almak istiyorum", "transkript sorgulama işlemi", "transkript almak için",
    "transkript başvurusu", "transkript işlemi", "transkript belgesi sorgulama", "transkriptlerim",
    "transkript belgesini al", "transkript al", "transkript isteği", "transkript belgesi talebi",
    "transkript belgesi almak", "transkript başvurusu", "transkript belgemi", "transkript belgesini al",
    "transkript belge", "transkripti sorgulama", "transkript belgelerim", "transkripti göster",
    "transkript gösterme", "transkripti iste", "transkript belgesi alma", "transkript belgesine başvur"
};
        List<string> ogrenciBelgesiAnahtarKelimeler = new List<string>
{
    "öğrenci belgesi", "ogrenci belgesi", "öğrenci belgesi sorgulama", "öğrenci belgesi al",
    "ogrenci belgesi al", "öğrenci belgesini al", "ogrenci belgesini al", "öğrenci belge",
    "ogrenci belge", "öğrenci belge sorgulama", "ogrenci belge sorgulama", "öğrenci belgesi sorgula",
    "ogrenci belgesi sorgula", "öğrenci belgeleri", "ogrenci belgeleri", "öğrenci diploması",
    "ogrenci diplomasi", "öğrenci transkripti", "ogrenci transkript", "öğrenci belgemi al",
    "ogrenci belgemi al", "öğrenci kimlik belgesi", "ogrenci kimlik belgesi", "öğrenci kimlik",
    "ogrenci kimlik", "öğrenci belgemi", "ogrenci belgemi"
};
        List<string> mezuniyetBelgesiAnahtarKelimeler = new List<string>
{
    "mezuniyet belgesi", "mezuniyetbelgesi", "mezuniyet", "mezuniyet belgesi talep", "mezuniyet belgesi alma",
    "mezuniyet belge", "mezuniyet yazısı", "mezuniyet yazısı talep", "mezuniyet diploması", "mezuniyet belgemi",
    "diploma", "mezuniyet sertifikası", "mezuniyet sertifikası talep", "mezuniyet belgesi almak", "mezuniyet belgemi almak",
    "mezuniyet işlemi", "mezuniyet talebi", "mezuniyet belgesini almak"
};
        List<string> kutuphaneBilgileriAnahtarKelimeler = new List<string>
{
    "kütüphane bilgileri", "kutuphane bilgileri", "kutuphane", "kütüphane", "kutuphane durumu", "kütüphane durumu",
    "kütüphane saatleri", "kutuphane saatleri", "kütüphane çalışma saatleri", "kutuphane calisma saatleri",
    "kütüphane kaynaklar", "kutuphane kaynaklar", "kütüphane kitaplar", "kutuphane kitaplar", "kütüphane randevu",
    "kutuphane randevu", "kütüphane sistem", "kutuphane sistem", "kütüphane üyelik", "kutuphane üyelik"
};
        List<string> yemekhaneMenusuAnahtarKelimeler = new List<string>
{
    "yemekhane menüsü", "yemekhane", "yemekhane menusu", "yemek menüsü", "yemek listesi",
    "yemekler", "yemekhane yemekleri", "yemekhane menüsü haftalık", "yemek menüsü haftalık", "yemek listesi haftalık",
    "bugün yemekhane menüsü", "yemekhane günü", "yemek günü", "yemek saatleri", "yemek programı", "yemek fiyatları",
    "yemekhane fiyatları", "yemek ücreti"
};
        List<string> duyuruHaberlerAnahtarKelimeler = new List<string>
{
    "duyuru ve haberler", "duyuru", "haberler", "duyurular", "güncel duyurular",
    "duyuru ve haber", "kampüs haberleri", "kampüs duyuruları", "üniversite duyuruları", "üniversite haberleri",
    "duyuru sayfası", "duyuru metni", "kampüs haber", "öğrenci duyuruları", "öğrenci haberleri",
    "yeni duyurular", "öğrenci işleri duyurusu", "güncel haberler", "yeni haberler"
};
        List<string> harcBorcBursAnahtarKelimeler = new List<string>
{
    "harç ödeme", "harc odemesi", "harc ödemesi", "harç ödemek", "harç ödeme işlemi",
    "harc öde", "harc ödemek istiyorum", "harc ödemesi yapmak", "harc odeme",
    "harc odeme islemi", "harç ödeme işlemi", "harç odemek", "harcı ödeme",
    "harcı ödemek", "harcı ödeme işlemi", "harç ödemeniz", "harc ödemesi",
    "harcı ödedi", "harcı ödemek", "harç öde", "harç ödeme yapmak",
    "borç sorgulama", "borc sorgulama", "borç durumu", "borç öğrenme", "borç sorgula",
    "borcumu öğrenmek istiyorum", "borç bilgisi", "borç öğren", "borcumu sorgulamak istiyorum",
    "borç", "borcumu sorgulamak", "borç durumu sorgulama", "borç bilgisi sorgulama",
    "borç hesaplama", "borcumu gör", "borcum", "borcumu", "borç ödeme", "borç borç",
    "burs durumu", "burs başvurusu", "burs sorgulama", "burs başvurusu durumu",
    "burs başvuru durumu", "burs durumu sorgulama", "burs alıp almadığını öğrenme",
    "burs sorgulama işlemi", "burs başvuru bilgisi", "burs başvurusu sonucu",
    "burs verildi mi", "burs almam", "burs başvurusu bilgisi", "burs ödemesi durumu","harç", "harc", "borc", "borç", "burs",
    "burs başvuru durumu", "bursun durumu"
};
        List<string> danismanIdariPersonelAnahtarKelimeler = new List<string>
{
    "danışman bilgileri", "danisman bilgileri", "danisman", "danışman", "danisman iletisimi", "danışman iletişimi",
    "danisman numarası", "danışman numarası", "danisman iletişim", "danışman iletişim", "danisman irtibat",
    "danışman irtibat", "danisman telefon", "danışman telefon", "danisman mail", "danışman mail", "idari personel",
    "idari personel iletişim", "idari personel iletisim", "idari personel telefon", "idari personel mail",
    "idari personel numarası", "idari personel irtibat", "idari personel maili", "idari personel bilgileri",
    "talep", "şikayet", "talep şikayet", "şikayet talep", "şikayet iletimi", "talep iletimi", "şikayet başvurusu",
    "talep başvurusu", "talep durumu", "şikayet durumu", "talep çözümü", "şikayet çözümü", "talep formu",
    "şikayet formu", "talep formu gönderme", "şikayet formu gönderme", "danışman bilgi", "idari iletişim",
    "danışman şikayet", "idari talep", "idari şikayet", "danışman talep", "danışman şikayet formu", "danısman", "danışman", "idari"
};
        List<string> selamlasmaAnahtarKelimeler = new List<string>
{
    "merhaba", "selam", "merhabalar", "selamlar", "günaydın", "iyi günler", "iyi akşamlar", "iyi geceler",
    "nasılsın", "nasılsınız", "naber", "ne var ne yok"
};
        List<string> selamunAleykumAnahtarKelimeler = new List<string>
{
    "selamünaleyküm", "aleykümselam", "selamunaleyküm", "aleyküm selam", "selamün aleyküm",
    "aleykümün selam", "aleykümün selam", "selamün aleyküm", "aleykümün selamün",
    "selamün aleyküm olsun", "aleyküm selam olsun", "selamün aleyküm kardeşim", "aleyküm selam kardeşim", "sa", "sea"
};
        List<string> erdemhocamız = new List<string>
{
    "erdem", "erdem yücesan","erdem hoca", "erdem yucesan", "ben erdem hoca", "ben erdem yücesan", "ben erdem"
};

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_akademi_Click(object sender, EventArgs e)
        {
            akademikislemler akademikislemler = new akademikislemler();
            akademikislemler.Show();
            this.Close();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            kayitislemleri kayitislemleri = new kayitislemleri();
            kayitislemleri.Show();
            this.Close();
        }

        private void btn_belgeler_Click(object sender, EventArgs e)
        {
            belgeler belgeler = new belgeler();
            belgeler.Show();
            this.Close();
        }

        private void btn_erisim_Click(object sender, EventArgs e)
        {
            hizlierisim hizlierisim = new hizlierisim();
            hizlierisim.Show();
            this.Close();
        }

        private void btn_odeme_Click(object sender, EventArgs e)
        {
            odemeislemleri odemeislemleri = new odemeislemleri();
            odemeislemleri.Show();
            this.Close();

        }

        private void btn_iletisim_Click(object sender, EventArgs e)
        {
            iletisim iletisim = new iletisim();
            iletisim.Show();
            this.Close();
        }

        private void chatbot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string girilenMetin = chatbot.Text.ToLower();
                bool eslesmeBulundu = false;

                if (!eslesmeBulundu)
                {
                    foreach (string anahtarKelime in akademikAnahtarKelimeler)
                    {
                        if (girilenMetin.Contains(anahtarKelime))
                        {
                            eslesmeBulundu = true;
                            MessageBox.Show("Sizi Akademik İşlemler sayfasına yönlendiriyorum.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            akademikislemler akademikForm = new akademikislemler();
                            akademikForm.Show();
                            this.Hide();
                            break;
                        }
                    }
                }

                if (!eslesmeBulundu)
                {
                    foreach (string anahtarKelime in dersKayitAnahtarKelimeler)
                    {
                        if (girilenMetin.Contains(anahtarKelime))
                        {
                            eslesmeBulundu = true;
                            MessageBox.Show("Sizi Ders Kayıt İşlemleri sayfasına yönlendiriyorum.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            kayitislemleri kayitForm = new kayitislemleri();
                            kayitForm.Show();
                            this.Hide();
                            break;
                        }
                    }
                }

                if (!eslesmeBulundu)
                {
                    foreach (string anahtarKelime in sinavTarihiYerAnahtarKelimeler)
                    {
                        if (girilenMetin.Contains(anahtarKelime))
                        {
                            eslesmeBulundu = true;
                            MessageBox.Show("Sizi Sınav Sayfasına yönlendiriyorum.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            sinavsayfasi sinavForm = new sinavsayfasi();
                            sinavForm.Show();
                            this.Hide();
                            break;
                        }
                    }
                }

                if (!eslesmeBulundu)
                {
                    foreach (string anahtarKelime in mezuniyetBelgesiAnahtarKelimeler)
                    {
                        if (girilenMetin.Contains(anahtarKelime))
                        {
                            eslesmeBulundu = true;
                            MessageBox.Show("Sizi Mezuniyet Belgesi sayfasına yönlendiriyorum.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            mezuniyetbelgesiform mezuniyetForm = new mezuniyetbelgesiform();
                            mezuniyetForm.Show();
                            this.Hide();
                            break;
                        }
                    }
                }

                if (!eslesmeBulundu)
                {
                    foreach (string anahtarKelime in yemekhaneMenusuAnahtarKelimeler)
                    {
                        if (girilenMetin.Contains(anahtarKelime))
                        {
                            eslesmeBulundu = true;
                            MessageBox.Show("Sizi Yemekhane Bilgileri sayfasına yönlendiriyorum.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            yemekhanebilgileriform yemekhanebilgileriForm = new yemekhanebilgileriform();
                            yemekhanebilgileriForm.Show();
                            this.Hide();
                            break;
                        }
                    }
                }

                foreach (string anahtarKelime in selamlasmaAnahtarKelimeler)
                {
                    if (girilenMetin.Contains(anahtarKelime))
                    {
                        eslesmeBulundu = true;
                        MessageBox.Show("Hoşgeldiniz, size nasıl yardımcı olabilirim?", "Selamlaşma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }

                if (!eslesmeBulundu)
                {
                    foreach (string anahtarKelime in duyuruHaberlerAnahtarKelimeler)
                    {
                        if (girilenMetin.Contains(anahtarKelime))
                        {
                            eslesmeBulundu = true;
                            MessageBox.Show("Sizi Duyuru ve Haberler sayfasına yönlendiriyorum.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            duyuruvehaberlerform duyuruForm = new duyuruvehaberlerform();
                            duyuruForm.Show();
                            this.Hide();
                            break;
                        }
                    }
                }

                if (!eslesmeBulundu)
                {
                    foreach (string anahtarKelime in selamunAleykumAnahtarKelimeler)
                    {
                        if (girilenMetin.Contains(anahtarKelime))
                        {
                            eslesmeBulundu = true;
                            MessageBox.Show("Aleyküm selam, size nasıl yardımcı olabilirim?", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }
                }


                if (!eslesmeBulundu)
                {
                    foreach (string anahtarKelime in kutuphaneBilgileriAnahtarKelimeler)
                    {
                        if (girilenMetin.Contains(anahtarKelime))
                        {
                            eslesmeBulundu = true;
                            MessageBox.Show("Sizi Kütüphane Bilgileri sayfasına yönlendiriyorum.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            kutuphanebilgileriform kutuphaneForm = new kutuphanebilgileriform();
                            kutuphaneForm.Show();
                            this.Hide();
                            break;
                        }
                    }
                }

                if (!eslesmeBulundu)
                {
                    foreach (string anahtarKelime in ogrenciBelgesiAnahtarKelimeler)
                    {
                        if (girilenMetin.Contains(anahtarKelime))
                        {
                            eslesmeBulundu = true;
                            MessageBox.Show("Sizi Öğrenci Belgesi sayfasına yönlendiriyorum.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ogrencibelgesiform ogrenciBelgesiForm = new ogrencibelgesiform();
                            ogrenciBelgesiForm.Show();
                            this.Hide();
                            break;
                        }
                    }
                }

                if (!eslesmeBulundu)
                {
                    foreach (string anahtarKelime in notAnahtarKelimeler)
                    {
                        if (girilenMetin.Contains(anahtarKelime))
                        {
                            eslesmeBulundu = true;
                            MessageBox.Show("Sizi Notlar Sayfasına yönlendiriyorum.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            notlarsayfasi notlarForm = new notlarsayfasi();
                            notlarForm.Show();
                            this.Hide();
                            break;
                        }
                    }
                }

                if (!eslesmeBulundu)
                {
                    foreach (string anahtarKelime in devamsizlikAnahtarKelimeler)
                    {
                        if (girilenMetin.Contains(anahtarKelime))
                        {
                            eslesmeBulundu = true;
                            MessageBox.Show("Sizi Devamsızlık Bilgisi sayfasına yönlendiriyorum.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            devamsizlikbilgisi devamsizlikForm = new devamsizlikbilgisi();
                            devamsizlikForm.Show();
                            this.Hide();
                            break;
                        }
                    }
                }

                if (!eslesmeBulundu)
                {
                    foreach (string anahtarKelime in kayitAnahtarKelimeler)
                    {
                        if (girilenMetin.Contains(anahtarKelime))
                        {
                            eslesmeBulundu = true;
                            MessageBox.Show("Sizi Kayıt İşlemleri sayfasına yönlendiriyorum.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            kayitislemleri kayitForm = new kayitislemleri();
                            kayitForm.Show();
                            this.Hide();
                            break;
                        }
                    }
                }

                if (!eslesmeBulundu)
                {
                    foreach (string anahtarKelime in dersProgramiAnahtarKelimeler)
                    {
                        if (girilenMetin.Contains(anahtarKelime))
                        {
                            eslesmeBulundu = true;
                            MessageBox.Show("Sizi Ders Programı sayfasına yönlendiriyorum.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            dersprogrami dersProgramiForm = new dersprogrami();
                            dersProgramiForm.Show();
                            this.Hide();
                            break;
                        }
                    }
                }


                if (!eslesmeBulundu)
                {
                    foreach (string anahtarKelime in belgeAnahtarKelimeler)
                    {
                        if (girilenMetin.Contains(anahtarKelime))
                        {
                            eslesmeBulundu = true;
                            MessageBox.Show("Sizi Belgeler sayfasına yönlendiriyorum.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            belgeler belgeForm = new belgeler();
                            belgeForm.Show();
                            this.Hide();
                            break;
                        }
                    }
                }

                if (!eslesmeBulundu)
                {
                    foreach (string anahtarKelime in transkriptAnahtarKelimeler)
                    {
                        if (girilenMetin.Contains(anahtarKelime))
                        {
                            eslesmeBulundu = true;
                            MessageBox.Show("Sizi Transkript Belgesi sayfasına yönlendiriyorum.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            transkriptbelgesi transkriptForm = new transkriptbelgesi();
                            transkriptForm.Show();
                            this.Hide();
                            break;
                        }
                    }
                }


                if (!eslesmeBulundu)
                {
                    foreach (string anahtarKelime in hizlierisimAnahtarKelimeler)
                    {
                        if (girilenMetin.Contains(anahtarKelime))
                        {
                            eslesmeBulundu = true;
                            MessageBox.Show("Sizi Hızlı Erişim sayfasına yönlendiriyorum.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            hizlierisim hizliForm = new hizlierisim();
                            hizliForm.Show();
                            this.Hide();
                            break;
                        }
                    }
                }

                if (!eslesmeBulundu)
                {
                    foreach (string anahtarKelime in erdemhocamız)
                    {
                        if (girilenMetin.Contains(anahtarKelime))
                        {
                            eslesmeBulundu = true;
                            MessageBox.Show("Değerli hocamız hoşgeldiniz, size nasıl yardımcı olabilirim?", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }
                }

                if (!eslesmeBulundu)
                {
                    foreach (string anahtarKelime in danismanIdariPersonelAnahtarKelimeler)
                    {
                        if (girilenMetin.Contains(anahtarKelime))
                        {
                            eslesmeBulundu = true;
                            MessageBox.Show("Sizi İletişim sayfasına yönlendiriyorum.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            iletisim iletişimForm = new iletisim();
                            iletişimForm.Show();
                            this.Hide();
                            break;
                        }
                    }
                }

                if (!eslesmeBulundu)
                {
                    foreach (string anahtarKelime in odemeAnahtarKelimeler)
                    {
                        if (girilenMetin.Contains(anahtarKelime))
                        {
                            eslesmeBulundu = true;
                            MessageBox.Show("Sizi Ödeme İşlemleri sayfasına yönlendiriyorum.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            odemeislemleri odemeForm = new odemeislemleri();
                            odemeForm.Show();
                            this.Hide();
                            break;
                        }
                    }
                }

                if (!eslesmeBulundu)
                {
                    foreach (string anahtarKelime in iletisimAnahtarKelimeler)
                    {
                        if (girilenMetin.Contains(anahtarKelime))
                        {
                            eslesmeBulundu = true;
                            MessageBox.Show("Sizi İletişim sayfasına yönlendiriyorum.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            iletisim iletisimForm = new iletisim();
                            iletisimForm.Show();
                            this.Hide();
                            break;
                        }
                    }
                }

                if (!eslesmeBulundu)
                {
                    foreach (string anahtarKelime in harcBorcBursAnahtarKelimeler)
                    {
                        if (girilenMetin.Contains(anahtarKelime))
                        {
                            eslesmeBulundu = true;
                            MessageBox.Show("Sizi Ödeme İşlemleri sayfasına yönlendiriyorum.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            odemeislemleri odemeForm = new odemeislemleri();
                            odemeForm.Show();
                            this.Hide();
                            break;
                        }
                    }
                }

                if (!eslesmeBulundu)
                {
                    MessageBox.Show("Anlamadım, tekrar deneyebilir misiniz?", "Yanıt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                chatbot.Clear();
                e.SuppressKeyPress = true;
            }
        }
    }
}