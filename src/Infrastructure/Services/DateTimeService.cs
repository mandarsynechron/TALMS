using TALMS.Application.Common.Interfaces;
using System;

namespace TALMS.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
