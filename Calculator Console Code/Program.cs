using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Console_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            /* HESAP MAKİNESİ UYGULAMASI
             * 
             * 1- Toplama işlemi yap
             *      - Kaç adet sayı toplamak istersiniz?
             *      - Sonuç bilgisini ekrana yazdırsın.
             *      - Yeni işlem yap veya menüye dön.
             *      
             * 2- Çıkartma işlemi yap
             *      - Kaç adet sayı toplamak istersiniz?
             *      - Sonuç bilgisini ekrana yazdırsın.
             *      - Yeni işlem yap veya menüye dön.
             *      
             * 3- Çarpma işlemi yap
             *      - Kaç adet sayı toplamak istersiniz?
             *      - Sonuç bilgisini ekrana yazdırsın.
             *      - Yeni işlem yap veya menüye dön.
             *      
             * 4- Bölme işlemi yap
             *      - Kaç adet sayı toplamak istersiniz?
             *      - Sonuç bilgisini ekrana yazdırsın.
             *      - Yeni işlem yap veya menüye dön.
             *      
             * 5- Geçmiş işlemleri listele
             *      // geçmişe yönelik tüm işlemlerin ekrana yazdırsın.
             *      
             * 7- Programdan çık(e,h)
             * 
             * Programımızı kullanıdığınız için teşekkür ederiz
             * Programdan çıkmak için bir tuşa basın.
             * 
             * 
             */







            Console.WriteLine("                             " + "HESAP MAKİNESİ");

            Console.Write("Hangi İşlemi Yapmak istiyorsunuz?");
            Console.WriteLine();
            Console.Write("Toplama için (+) , Çıkarma İçin (-) , Çarpma için (*) , Bölme için (/) tuşuna basın. ");
            char islemTuru = char.Parse(Console.ReadLine());

            string cevap = "";
            do
            {
                int toplam = 0;
                int cikarma = 0;
                int carpma = 1;
                int bolme = 1;



                switch (islemTuru)
                {
                    case '+':
                        Console.Write("Kaç adet sayı toplamak istersiniz ?");
                        int adet = int.Parse(Console.ReadLine());

                        int[] adetSayisi = new int[adet];

                        for (int i = 0; i < adetSayisi.Length; i++)
                        {
                            Console.Write((i + 1) + ". sayıyı yazınız : ");
                            int sayi = int.Parse(Console.ReadLine());
                            adetSayisi[i] = sayi;

                        }

                        for (int i = 0; i < adetSayisi.Length; i++)
                        {
                            toplam += adetSayisi[i];


                        }


                        Console.WriteLine();
                        Console.WriteLine("Sayıların Toplamı: " + toplam);
                        Console.WriteLine();
                        Console.Write("Başka bir işlem yapmak istiyor musunuz? [E]vet , [H]ayır > ");
                        cevap = Console.ReadLine();
                        Console.Clear();

                        break;

                    case '-':
                        Console.Write("Kaç adet sayı çıkarmak istersiniz ?");
                        int adetc = int.Parse(Console.ReadLine());

                        int[] adetSayisic = new int[adetc];

                        for (int i = 0; i < adetSayisic.Length; i++)
                        {
                            Console.Write((i + 1) + ". sayıyı yazınız : ");
                            int sayi = int.Parse(Console.ReadLine());
                            adetSayisic[i] = sayi;

                        }

                        for (int i = 0; i < adetSayisic.Length; i++)
                        {
                            cikarma -= adetSayisic[i];

                        }


                        Console.WriteLine();
                        Console.WriteLine("Sayılarla Çıkarma İşleminin Sonucu: " + cikarma);
                        Console.WriteLine();
                        Console.Write("Başka bir işlem yapmak istiyor musunuz? [E]vet , [H]ayır > ");
                        cevap = Console.ReadLine();
                        Console.Clear();

                        break;

                    case '*':
                        Console.Write("Kaç adet sayı çarpmak istersiniz ?");
                        int adetca = int.Parse(Console.ReadLine());

                        int[] adetSayisica = new int[adetca];

                        for (int i = 0; i < adetSayisica.Length; i++)
                        {
                            Console.Write((i + 1) + ". sayıyı yazınız : ");
                            int sayi = int.Parse(Console.ReadLine());
                            adetSayisica[i] = sayi;

                        }

                        for (int i = 0; i < adetSayisica.Length; i++)
                        {
                            carpma *= adetSayisica[i];


                        }


                        Console.WriteLine();
                        Console.WriteLine("Sayıların Çarpımı: " + carpma);
                        Console.WriteLine();
                        Console.Write("Başka bir işlem yapmak istiyor musunuz? [E]vet , [H]ayır > ");
                        cevap = Console.ReadLine();
                        Console.Clear();

                        break;

                    case '/':
                        Console.Write("Kaç adet sayı bölmek istersiniz ?");
                        int adetb = int.Parse(Console.ReadLine());

                        int[] adetSayisib = new int[adetb];

                        for (int i = 0; i < adetSayisib.Length; i++)
                        {
                            Console.Write((i + 1) + ". sayıyı yazınız : ");
                            int sayi = int.Parse(Console.ReadLine());
                            adetSayisib[i] = sayi;

                        }

                        for (int i = 0; i < adetSayisib.Length; i++)
                        {
                            bolme /= adetSayisib[i];


                        }


                        Console.WriteLine();
                        Console.WriteLine("Sayıların Birbirine Bölümü: " + bolme);
                        Console.WriteLine();
                        Console.Write("Başka bir işlem yapmak istiyor musunuz? [E]vet , [H]ayır > ");
                        cevap = Console.ReadLine();
                        Console.Clear();

                        break;
                }


            } while (cevap == "e" || cevap == "E");

            Console.Write("Hesap Makinesini Kullandığınız için Teşekkürler :) ");
            Console.Write("Çıkmak için bir tuşa basın");



        }
    }
}
