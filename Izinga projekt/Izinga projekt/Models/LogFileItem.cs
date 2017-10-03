using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IzingaProjekt.Models
{
    public class LogFileItem
    {
        public string Time { get; set; }
        public int ID { get; set; }
        public string Alarm { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Accommodation { get; set; }
        public bool Unsubscribed { get; set; }

        public LogFileItem()
        { }
    }
}