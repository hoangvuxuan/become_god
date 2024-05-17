using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace become_god.all_class
{
    public class Plan_Item
    {
        private string title;
        private string content;
        private Point start_time;
        private Point end_time;
        private int study_time;
        private string status;
        private DateTime day;

        public static List<string> list_status = new List<string>() { "done", "doing", "coming", "missed" };

        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public Point Start_time { get => start_time; set => start_time = value; }
        public Point End_time { get => end_time; set => end_time = value; }
        public int Study_time { get => study_time; set => study_time = value; }
        public string Status { get => status; set => status = value; }
        public DateTime Day { get => day; set => day = value; }
    }
}
