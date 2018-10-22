using System;
using System.Collections.Generic;
using System.Text;

namespace SampleAppKelasB
{
    public class Global
    {
        private static Global _instance;
        public static Global Instance
        {
            get {
                if (_instance == null)
                {
                    _instance = new Global();
                }
                return _instance;
            }
        }
        public string Nama { get; set; }
        public string Email { get; set; }
    }
}
