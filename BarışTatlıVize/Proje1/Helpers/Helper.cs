using Proje1.Enums;
using Proje1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1.Helpers
{
    class Helper
    {
        public static List<Movie> createMovies()
        {
            string basePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            return new List<Movie>()
            {
                new Movie()
                {
                    movieName = "Dünyanın Merkezine Yolculuk",
                    category = Category.bilimKurgu,
                    minute = "1 Saat 33 Dakika",
                    price = 50,
                    picturePath = basePath + "/dunyaninmerkezineyolculuk.jpg"
                },
                   new Movie()
                {
                    movieName = "Dünya Savaşı Z",
                    category = Category.bilimKurgu,
                    minute = "2 Saat 10 Dakika",
                    price = 60,
                    picturePath = basePath + "/dunyasavasiz.jpg"
                },
                new Movie()
                {
                    movieName = "Parçalanmış",
                    category = Category.bilimKurgu,
                    minute = "1 Saat 57 Dakika",
                    price = 20,
                    picturePath = basePath + "/parcalanmis.jpg"
                },
                new Movie()
                {
                    movieName = "Titanik",
                    category = Category.macera,
                    minute = "3 Saat 14 Dakika",
                    price = 30,
                    picturePath = basePath + "/titanik.png"
                },
                new Movie()
                {
                    movieName = "Yenilmezler",
                    category = Category.komedi,
                    minute = "2 Saat 23 Dakika",
                    price = 50,
                    picturePath = basePath + "/yenilmezler.jpg"
                },

             new Movie()
                {
                    movieName = "yildizlararasi",
                    category = Category.bilimKurgu,
                    minute = "2 Saat 49 Dakika",
                    price = 200,
                    picturePath = basePath + "/yildizlararasi.jpg"
                },


            };
        }
    }
}
