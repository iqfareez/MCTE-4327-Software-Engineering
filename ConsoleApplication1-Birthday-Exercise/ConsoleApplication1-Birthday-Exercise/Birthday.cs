using System;

namespace ConsoleApplication1_Birthday_Exercise
{
    public class Birthday
    {
        public event EventHandler ImpossibleAgeEntered;
        public event EventHandler ImproperDateEntered;
        public event EventHandler ImproperInputEntered;
        public event Action TodayIsBirthday;
        public event Action<int, string> EverythingIsOkay;

        public void Start(string userInput)
        {
            var date = userInput.Split('/');

            try
            {
                var day = int.Parse(date[0]);
                var month = int.Parse(date[1]);
                var year = int.Parse(date[2]);

                DateTime birthday = new DateTime(year, month, day);
                int age = DateTime.Now.Year - birthday.Year;

                if (age > 135 || age == 0)
                {
                    ImpossibleAgeEntered?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    EverythingIsOkay?.Invoke(age, birthday.DayOfWeek.ToString());

                    if (birthday.Day == DateTime.Now.Day && birthday.Month == DateTime.Now.Month)
                    {
                        TodayIsBirthday?.Invoke();
                    }
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                ImproperDateEntered?.Invoke(this, EventArgs.Empty);
            }
            catch (FormatException)
            {
                ImproperInputEntered.Invoke(this, EventArgs.Empty);
            }
        }
    }
}