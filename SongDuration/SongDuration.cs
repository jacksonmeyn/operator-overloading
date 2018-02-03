using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongDuration
{
    class SongDuration
    {
        private int minutes;
        private int seconds;

        public int Minutes { get => minutes; set => minutes = value; }
        public int Seconds { get => seconds; set => seconds = value; }

        public SongDuration()
        {
            Minutes = 0;
            Seconds = 0;
        }

        public SongDuration(int _minutes, int _seconds)
        {
            if (_minutes < 0 || _minutes > 20 || _minutes == 20 && _seconds > 0)
            {
                try
                {
                    throw new ArgumentOutOfRangeException();
                }
                catch (ArgumentOutOfRangeException e)
                {

                    Console.WriteLine(e.Message);

                }
            }
            else
            {
                Minutes = _minutes;
            }

            if (_seconds < 0 || _seconds > 59)
            {
                try
                {
                    throw new ArgumentOutOfRangeException();
                }
                catch (ArgumentOutOfRangeException e)
                {

                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Seconds = _seconds;
            }


        }

        public override string ToString()
        {
            return string.Format("{0} minutes {1} seconds", Minutes, Seconds);
        }

        //Operator overloading
        public static bool operator !=(SongDuration a, SongDuration b)
        {
            if (a.Minutes == b.Minutes && a.Seconds == b.Seconds)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator ==(SongDuration a, SongDuration b)
        {
            if (a.Minutes == b.Minutes && a.Seconds == b.Seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <=(SongDuration a, SongDuration b)
        {
            if (a.Minutes < b.Minutes)
            {
                return true;
            }
            else if (a.Minutes == b.Minutes && a.Seconds <= b.Seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >=(SongDuration a, SongDuration b)
        {
            if (a.Minutes > b.Minutes)
            {
                return true;
            }
            else if (a.Minutes == b.Minutes && a.Seconds >= b.Seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(SongDuration a, SongDuration b)
        {
            if (a.Minutes > b.Minutes)
            {
                return true;
            }
            else if (a.Minutes == b.Minutes && a.Seconds > b.Seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(SongDuration a, SongDuration b)
        {
            if (a.Minutes < b.Minutes)
            {
                return true;
            }
            else if (a.Minutes == b.Minutes && a.Seconds < b.Seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static SongDuration operator +(SongDuration a, SongDuration b)
        {

            SongDuration tempSong = new SongDuration();
            tempSong.Minutes = a.Minutes + b.Minutes;
            tempSong.Seconds = a.Seconds + b.Seconds;
            if (tempSong.Seconds > 59)
            {
                tempSong.Minutes++;
                tempSong.Seconds -= 60;
            }

            if (tempSong.Minutes > 20 ||
                tempSong.Minutes == 20 && tempSong.Seconds > 0)
            {
                Console.WriteLine("Error: The result is greater than 20 minutes 0 seconds. Setting to that instead.");
                tempSong.Minutes = 20;
                tempSong.Seconds = 0;
            }

            return tempSong;
        }

        public static SongDuration operator -(SongDuration a, SongDuration b)
        {

            SongDuration tempSong = new SongDuration();
            tempSong.Minutes = a.Minutes - b.Minutes;
            tempSong.Seconds = a.Seconds - b.Seconds;
            if (tempSong.Seconds < 0)
            {
                tempSong.Minutes--;
                tempSong.Seconds += 60;
            }

            if (tempSong.Minutes < 0 || tempSong.Seconds < 0)
            {
                Console.WriteLine("Error: The result is less than 0 minutes 0 seconds. Setting to that instead.");
                tempSong.Minutes = 0;
                tempSong.Seconds = 0;
            }

            return tempSong;
        }
        //End operator overloading

    }
}
