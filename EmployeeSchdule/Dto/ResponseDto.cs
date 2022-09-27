using System;

namespace EmployeeSchdule.Dto
{
    public class ResponseDto
    {
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
    }
}