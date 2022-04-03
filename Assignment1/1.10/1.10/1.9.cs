using System;

namespace Application
{
    class E1_10
    {
        public static void E1_10(string[] args)
        {
            Console.WriteLine("How many seconds do you have available?");
            int second = Convert.ToInt32(Console.ReadLine());
            double yearo = second / 60 / 60 / 24 / 365;
            int year = Convert.ToInt32(Math.Floor(yearo));
            double restyear = second - 365 * 24 * 60 * 60 * year;
            double day = Convert.ToInt32(Math.Floor(restyear / 60 / 60 / 24));
            double restday = restyear -  24 * 60 * 60 * day;
            double hour = Convert.ToInt32(Math.Floor(restday / 60 / 60 ));
            double resthour = restday - 60 * 60 * hour;
            double minute = Convert.ToInt32(Math.Floor(resthour / 60));
            double restminute = resthour - 60 * minute;
            double secondr = Convert.ToInt32(Math.Floor(restminute));

            Console.WriteLine(second +" is equal to " + year + " years and " + day + " days " + hour + " hours " + minute + " minutes " + secondr + " seconds " ) ;
            
        }
    }
}
