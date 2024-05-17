using become_god.all_class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace become_god
{
    public partial class daily_plain : Form
    {
        private List<Plan_Item> list_items;
        public daily_plain(List<Plan_Item> list_items)
        {
            this.list_items = list_items;
            InitializeComponent();
        }

        private void dp_add_job_Click(object sender, EventArgs e)
        {
            Point start_time = new Point(Convert.ToInt32(dp_nud_from_h.Value), Convert.ToInt32(dp_nud_from_minute.Value));
            Point end_time = new Point(Convert.ToInt32(dp_nup_to_h.Value), Convert.ToInt32(dp_nup_to_minute.Value));


            Plan_Item item = new Plan_Item();
            item.Start_time = start_time;
            item.End_time = end_time;
            item.Study_time = Convert.ToInt32(dp_study_times.Value);
            item.Status = "doing";
            item.Title = dp_title.Text;
            item.Content = dp_content.Text;
            item.Day = dp_pick_day.Value;
            
            list_items.Add(item);
            Close();
        }
    }
}
