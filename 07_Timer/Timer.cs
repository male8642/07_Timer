using System.Timers;

namespace _07_Timer
{
    public class Timer

    {
        private int seconds = 0;
        public int Seconds
        {
            get
            {
                return seconds;
            }
            set
            {
                seconds = value;
            }
        }

        public override string ToString()
        {
            int minutes = seconds / 60;
            seconds = seconds - 60 * minutes;
            int hours = minutes / 60;
            minutes = minutes - 60 * hours;

      
           if (seconds < 10)
            {
                return "0" + hours + ":" + "0" + minutes + ":" + "0" + seconds;
            }

            
            return "0" + hours + ":" + "0" + minutes + ":" + seconds;
           

            }

        

           
        }

       

    }

    
