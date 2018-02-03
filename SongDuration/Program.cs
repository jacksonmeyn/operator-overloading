using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongDuration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adding extra comments

            Console.WriteLine("Test the constructor by entering some invalid parameters");
            SongDuration invalidDuration1 = new SongDuration(-5, 43);
            SongDuration invalidDuration2 = new SongDuration(1, 65);
            SongDuration invalidDuration3 = new SongDuration(20, 59);

            SongDuration song1 = new SongDuration(1, 59);
            Console.WriteLine(song1.ToString());
            SongDuration song3 = new SongDuration(20, 0);
            Console.WriteLine(song3.ToString());
            SongDuration song4 = new SongDuration(3, 30);
            Console.WriteLine(song4.ToString());
            SongDuration song5 = new SongDuration(3, 30);
            Console.WriteLine(song5.ToString());

            //Test the + and - operators
            SongDuration calculate = song1 + song4;
            Console.WriteLine(calculate.ToString());
            calculate = song4 - song1;
            Console.WriteLine(calculate.ToString());
            calculate = song1 - song4;
            Console.WriteLine(calculate.ToString());

            //Test the == and != operators
            Console.WriteLine(song4 == song5); //true
            Console.WriteLine(song4 == song1); //false
            Console.WriteLine(song4 != song5); //false
            Console.WriteLine(song4 != song3); //true

            //Test the < and <= operators
            Console.WriteLine(song4 < song5); //false
            Console.WriteLine(song4 < song3); //true
            Console.WriteLine(song4 <= song5); //true
            Console.WriteLine(song4 <= song1); //false

            //Test the > and >= operators
            Console.WriteLine(song4 > song5); //false
            Console.WriteLine(song4 > song3); //false
            Console.WriteLine(song4 >= song5); //true
            Console.WriteLine(song4 >= song1); //true

            //Hold the screen
            Console.ReadLine();
        }
    }

    
}
