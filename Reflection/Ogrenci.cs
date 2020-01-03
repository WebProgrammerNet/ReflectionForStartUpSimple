using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Ogrenci
    {
        public string sinifi;
        public string anaadi;
        public string ataadi;
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string IdCard { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime StudyBegintYear { get; set; }

        public void Exercise()
        {
        }
        public void HomeWork()
        {
            Exercise();
        }
        public string Salamlas()
        {
            return "Selamin Eleykum";
        }

    }

}
