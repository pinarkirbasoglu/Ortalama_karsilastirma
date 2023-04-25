using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;

namespace Ortalama_Karsilastirma
{
    public partial class Ogr_web : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            string[] isim = new string[2];
            int[] not = new int[3];
            int[] ortalama = new int[2];
            for(int i = 0;i < isim.Length; i++)
            {
                isim[i] = Interaction.InputBox((i + 1) + ".öğrencinin ismini girin:");
            }
            for(int i = 0; i<2; i++)
            {
                for(int j = 0; j<not.Length; j++)
                {
                    not[j]=Convert.ToInt32(Interaction.InputBox((i+1)+".öğrencinin"+" " +(j+1)+". notunu giriniz:"));
                }
                ogrenci.Notlar = not;//önce aspx deki not dizisine notlar alıpnıp bu dizi cs deki notlar dizisine kayıtedilmeli bunu yapmadan ort_hesapla çağırılmaz çünkü metot cs deki notlar dizisinin elemanalrını toplayıp bölerek ortlama buluyor.
                ogrenci.ort_hesapla(i);//öğrenci nesensin isim dizi ile ortalama dizinde ki uyumu cs dosyasında sıra metotdunda ÖĞRENCİ NESENSİNİ İ.ELEMANI DİZİLERDE İ.İNDEXDE TUTULMALI prensibi ile sağladık.
            }

            Response.Write(ogrenci.sırala());
        }
    }
}