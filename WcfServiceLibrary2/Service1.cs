using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary2
{
    public class Service1 : IService1
    {
        public int HesapTopla(int Sayi1, int Sayi2)
        {
            return Sayi1 + Sayi2;   
        }

        public int HesapCikar(int Sayi1, int Sayi2)
        {
            if (Sayi1 > Sayi2)
            {
                return Sayi1 - Sayi2;
            }
            else
            {
                return Sayi2 - Sayi1;
            }
        }

        public int HesapCarp(int Sayi1, int Sayi2)
        {
            Sayi1 = Sayi1 + 10;
            return Sayi1 * Sayi2;
        }

        public double HesapBol(int Sayi1, int Sayi2)
        {
            if (Sayi1 > Sayi2)
            {
                if (Sayi2 == 0)
                {
                    DivideByZeroException hata = new DivideByZeroException();
                    throw new FaultException<DivideByZeroException>(hata, "Sayı sıfıra bölünemez");
                }
                return Convert.ToDouble(Sayi1) / Convert.ToDouble(Sayi2);
            }
            else
            {
                if (Sayi1 == 0)
                {
                    DivideByZeroException hata = new DivideByZeroException();
                    throw new FaultException<DivideByZeroException>(hata, "Sayı sıfıra bölünemez");
                }
                return Convert.ToDouble(Sayi2) / Convert.ToDouble(Sayi1);
            }
        }
    }
}
