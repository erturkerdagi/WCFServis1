using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary2
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int HesapTopla(int Sayi1, int Sayi2);

        [OperationContract]
        int HesapCikar(int Sayi1, int Sayi2);

        [OperationContract]
        int HesapCarp(int Sayi1, int Sayi2);

        [OperationContract]
        double HesapBol(int Sayi1, int Sayi2);
    }
}
