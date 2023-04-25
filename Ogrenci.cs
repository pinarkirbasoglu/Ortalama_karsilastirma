using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ortalama_Karsilastirma
{
    public class Ogrenci
    {
        private string[] isimler = new string[2];
        private int[] notlar = new int[3];
        private double[] ortalama = new double[2];

        public string[] Isimler { get => isimler; set => isimler = value; }
        public int[] Notlar { get => notlar; set => notlar = value; }
        public double[] Ortalama { get => ortalama; set => ortalama = value; }

        public void ort_hesapla(int x)//int x dediğimiz öğrenci isminin dizideki indexini alacak.
        {
            int top = 0;
            foreach(int not in Notlar)
            {
                top += not;
            }
            Ortalama[x] = top / 3;/*öğrenci nesenesinin isim dizisi ile ortalama dizisinin uyumlu olması için;
            isim dizindeki oda numarasında(index) de tutulan bilgi ortlama dizisinde de aynı oda numarasında(indexinde) tutarak uyum 
            sağlanır.Biz i.elemanın bilgilerine uyumlu şekilde erişelim.
            *** ÖĞRENCİ NESENESİNİN İ. ELEMANINA AİT BİLGİLER TÜM DİZİLERDE İ.ODA NUMARASINDA(İNDEXİNDE) TUTULMALI */
        }/*ort_hesapla metodu öğrenci nesenesinin ortlama özelliğinini doldurur.*/


        public string sırala()
        {
            int eboi = 0;
            int ekoi = 0;
            double ebo = Ortalama[0];
            double eko = Ortalama[0];
            for (int i =0; i < 2; i++)//eb ek nin dizideki indexini bulup o indexi diziden çağırarak kullandık eb ek olan öğrenciyi.
            {
                if (ebo < Ortalama[i]) eboi = i;

                if (eko > Ortalama[i]) ekoi = i;
            }
            string sonuc = Isimler[eboi] + " isimli öğrenci" + Ortalama[eboi] + " ortalma ile en yüksek ortlamaya sahiptir<br>" +
                Isimler[ekoi] + " isimli öğrenci" + Ortalama[ekoi] + " ortalma ile en düşük ortlamaya sahiptir<br>";
            return sonuc;
        }
    }
}