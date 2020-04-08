using System;
using Xunit;

namespace DemoAttribute
{
    public class Explicitǿ��ת��
    {
        [Fact]
        public void Test1()
        {
            var timeRange = new DateTimeRange(DateTime.Now, DateTime.Now.AddDays(1));
            double hours = timeRange;
            Console.WriteLine($"����ʱ�����{hours}Сʱ");
        }

        public class DateTimeRange
        {
            public DateTime StartTime { get; set; }

            public DateTime EndTime { get; set; }

            public DateTimeRange(DateTime startTime, DateTime endTime)
            {
                StartTime = startTime;
                EndTime = endTime;
            }

            //operator �������Ҫת��������
            //Explicit
            public static implicit operator double(DateTimeRange timeRange)
            {
                return (timeRange.EndTime - timeRange.StartTime).TotalHours;
            }
        }
    }
}
