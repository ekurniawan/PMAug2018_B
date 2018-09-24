using SampleAppKelasB.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleAppKelasB.ViewModels
{
    public class BeritaViewModel : BindableObject
    {
        public BeritaViewModel()
        {
            listBerita = new List<Berita>()
            {
                new Berita{Judul="Xamarin Forms",Deskripsi="Belajar Xamarin Forms dan Visual Studio"},
                new Berita{Judul="CSharp Programming",Deskripsi="Belajar Pemrograman CSharp"},
                new Berita{Judul="Xamarin Android",Deskripsi="Pengembangan Aplikasi Mobile dengan Xamarin for Android"}
            };
        }

        private List<Berita> listBerita;
        public List<Berita> ListBerita
        {
            get { return listBerita; }
            set { listBerita = value; OnPropertyChanged("ListBerita"); }
        }

    }
}
