namespace DigitalClock
{
    public class Clock
    {
        private int hour;
        private int minutes;
        private int day;
        private int month;
        private int year;

        public Clock()
        {
            this.Mode = ClockMode.DisplayTime;
            this.Hour = 0;
            this.Minutes = 0;
            this.Day = 1;
            this.Month = 1;
            this.Year = 1000;
        }

        public ClockMode Mode { get; private set; }

        public int Hour 
        { 
            get => this.hour; 
            private set
            {
                // If value is lower than 0 set it back to 0
                if (value < 0)
                {
                    value = 0;
                }

                // If value is higher than 23 find the correct value to be set
                if (value > 23)
                {
                    value %= 24;
                }

                this.hour = value;
            }
        }

        public int Minutes
        {
            get => this.minutes;
            private set
            {
                // If value is lower than 0 set it back to 0
                if (value < 0)
                {
                    value = 0;
                }

                // If value is higher than 59 find the correct value to be set
                if (value > 59)
                {
                    value %= 60;
                }

                this.minutes = value;
            }
        }

        public int Day
        {
            get => this.day;
            private set
            {
                // If value is lower than 1 set it back to 1
                if (value < 1)
                {
                    value = 1;
                }

                // If value is higher than 31 find the correct value to be set
                if (value > 31)
                {
                    value %= 31;
                }

                this.day = value;
            }
        }

        public int Month
        {
            get => this.month;
            private set
            {
                // If value is lower than 1 set it back to 1
                if (value < 1)
                {
                    value = 1;
                }

                // If value is higher than 12 find the correct value to be set
                if (value > 12)
                {
                    value %= 12;
                }

                this.month = value;
            }
        }

        public int Year
        {
            get => this.year;
            private set
            {
                // If value is higher than 3000 find the correct value to be set
                if (value > 3000)
                {
                    value %= 3000;
                }

                // If value is lower than 1000 set it back to 1000
                if (value < 1000)
                {
                    value = 1000;
                }

                this.year = value;
            }
        }

        public string PushTopButton(int repeatCount = 1)
        {
            // Top button shows time or
            // changes hour / minute / day / month / year by the value
            switch (this.Mode)
            {
                case ClockMode.SetHour:
                    this.Hour += repeatCount;
                    return $"Set hour to {this.Hour}";
                case ClockMode.SetMinute:
                    this.Minutes += repeatCount;
                    return $"Set minutes to {this.Minutes}";
                case ClockMode.SetDay:
                    this.Day += repeatCount;
                    return $"Set day to {this.Day}";
                case ClockMode.SetMonth:
                    this.Month += repeatCount;
                    return $"Set month to {this.Month}";
                case ClockMode.SetYear:
                    this.Year += repeatCount;
                    return $"Set year to {this.Year}";
                default:
                    return 
                        $"{this.Hour:d2}:{this.Minutes:d2}" +
                        $" / {this.Day:d2}.{this.Month:d2}.{this.Year:d4}";
            }
        }

        public string PushMiddleButton()
        {
            // Middle button transitions from changing hours to minutes to displaying time again
            switch (this.Mode)
            {
                case ClockMode.DisplayTime:
                    this.Mode = ClockMode.SetHour;
                    return "Mode: Set Hour";
                case ClockMode.SetHour:
                    this.Mode = ClockMode.SetMinute;
                    return "Mode: Set Minutes";
                case ClockMode.SetMinute:
                    this.Mode = ClockMode.DisplayTime;
                    return "Mode: Display Time";
                default:
                    this.Mode = ClockMode.SetHour;
                    return "Mode: Set Hour";
            }
        }

        public string PushBottomButton()
        {
            // Bottom button transitions from changing months to days to years to displaying time again
            switch (this.Mode)
            {
                case ClockMode.DisplayTime:
                    this.Mode = ClockMode.SetMonth;
                    return "Mode: Set Month";
                case ClockMode.SetMonth:
                    this.Mode = ClockMode.SetDay;
                    return "Mode: Set Day";
                case ClockMode.SetDay:
                    this.Mode = ClockMode.SetYear;
                    return "Mode: Set Year";
                case ClockMode.SetYear:
                    this.Mode = ClockMode.DisplayTime;
                    return "Mode: Display Time";
                default:
                    this.Mode = ClockMode.SetMonth;
                    return "Mode: Set Month";
            }
        }
    }
}
