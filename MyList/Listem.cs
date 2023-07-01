using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class Listem<T> // Burasi List<string, int vs.> icin. T ise kullanicinin belli bir sey degil istedigi type a gore sekil almasi icin. Buraya T yerine istedigimizi de girebiliriz.
    {
        T[] list; // T cinsinden bir Array tanimliyoruz. Buradaki T type olarak geciyor ve burasi kullanicinin istegine gore sekil aliyor.

        public Listem() // Her new olarak tanimlandiginda burasi calisacak ve list'in index'i 0 dan baslayacak.
        {
            list = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = list; // list elemanlarinin silinmesini onlemek adina bunlari tempArray'de tutuyoruz.
            list = new T[list.Length + 1]; // Listemizin index'i her calismada bir artiyor ki out of range hatasi almayalim.
            for (int i = 0; i < tempArray.Length; i++) // tempArray deki her bir elemani yeniden list'in icine aktariyoruz.
            {
                list[i] = tempArray[i];
            }
            list[list.Length - 1] = item; // En son eklenen itemi her seferinde list'in sonuna ekliyoruz.
        }

        public int Length
        {
            get{ return list.Length; } // Bunu get ile yapmazsak bize anlamayacagimiz bir dilde veriyor.
        }

        public T[] List
        {
            get { return list; } // Bunu Array olarak gosteriyoruz.
        }
    }
}
