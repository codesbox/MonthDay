namespace Month
{
    public class DayMonth
    {
        public Dictionary<int, int> map = new Dictionary<int, int>()
            {
                { 1, 31},
                {2, 28},
                { 3, 31},
                { 4, 30},
                { 5, 31},
                { 6, 30},
                { 7, 31},
                { 8, 31},
                { 9, 30},
                { 10, 31},
                { 11, 30},
                { 12, 31 }

            };
        public int day;
        public int month;
        public DayMonth(int month, int day)
        {
            this.day = day;
            this.month = month;
        }
        public void DaysBetween(DayMonth dayMonth)
        {
            int days = 0;
            if (dayMonth.month == month)
            {
                days = dayMonth.day - day;
            }
            else
            {
                for (int i = month; i < dayMonth.month; i++)
                {
                    days += map[i];
                }
                days += dayMonth.day - day;
            }
            Console.WriteLine(days);
        }
        
        public void AddingDays(int days) {
            int daysInMonth = map[month];
            if (daysInMonth - day >= days)
            {
                day += days;
            }
            else
            {
                days -= daysInMonth - day;
                month++;
                while (days > map[month])
                {
                    days -= map[month];
                    month++;
                }
                day = days;
            }
            Console.WriteLine($"{month}.{day}");
        }

        public void SubtractingDays(int days) {
            if (day - days > 0)
            {
                day -= days;
            }
            else
            {
                days -= day;
                month--;
                while (days > map[month])
                {
                    days -= map[month];
                    month--;
                }
                day = map[month] - days;
            }
            Console.WriteLine($"{month}.{day}");
        }
        
        public void DayFromTheBeginningOfTheYear() {
            int days = 0;
            for (int i = 1; i < month; i++)
            {
                days += map[i];
            }
            days += day;
            Console.WriteLine(days);
        }



    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DayMonth dayMonth = new DayMonth(2, 1);
            DayMonth dayMonth1 = new DayMonth(3, 1);
            dayMonth.SubtractingDays(5);

        }
    }
}