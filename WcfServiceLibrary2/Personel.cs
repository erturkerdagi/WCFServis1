using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary2
{
    [DataContract]
    public class Personel
    {
        private int personelID;
        private string personelAdi;
        private string personelSoyad;

        [DataMember]
        public int PersonelID
        {
            get { return personelID; }
            set { personelID = value; }
        }

        [DataMember]
        public string PersonelAd
        {
            get { return personelAdi; }
            set { personelAdi = value; }
        }

        [DataMember]
        public string PersonelSoyad
        {
            get { return PersonelSoyad; }
            set { PersonelSoyad = value; }
        }
    }
}
