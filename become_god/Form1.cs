using become_god.all_class;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace become_god
{
    public partial class Form1 : Form
    {
        private List<Plan_Item> list_items;
        public Form1()
        {
            list_items = new List<Plan_Item>();
            Static_Class.create_file(Static_Class.file_path);
            read_form_file();

            InitializeComponent();

            show_job_by_day();
        }


        private void mf_pickday_ValueChanged(object sender, EventArgs e)
        {
            show_job_by_day();
        }


        private void mf_add_job_Click(object sender, EventArgs e)
        {


            daily_plain dp = new daily_plain(list_items);
            dp.ShowDialog();

            show_job_by_day();
        }

        private void read_form_file()
        {
            Plan_Item item;
            XDocument document = XDocument.Load(Static_Class.file_path);
            foreach (XElement element in document.Descendants("plan_item"))
            {
                List<int> start_time_arr = get_x_y(element.Element("Start_time").Value);

                Point start_time = new Point()
                {
                    X = start_time_arr[0],
                    Y = start_time_arr[1]
                };

                List<int> end_time_arr = get_x_y(element.Element("End_time").Value);
                Point end_time = new Point()
                {
                    X = end_time_arr[0],
                    Y = end_time_arr[1]
                };

                item = new Plan_Item()
                {
                    Title = element.Element("title").Value,
                    Content = element.Element("content").Value,
                    Start_time = start_time,
                    End_time = end_time,
                    Study_time = Convert.ToInt32(element.Element("Study_time").Value),
                    Day = Convert.ToDateTime(element.Element("Day").Value),
                    Status = element.Element("Status").Value,
                };

                list_items.Add(item);

            }
        }

        private List<int> get_x_y(string s)
        {
            MatchCollection matches = Regex.Matches(s, @"(\w+)=(\d+)");

            List<int> result = new List<int>();
            result.Add(int.Parse(matches[0].Groups[2].Value));
            result.Add(int.Parse(matches[1].Groups[2].Value));

            return result;
        }

        private void show_job_by_day()
        {

            mf_show_job.Controls.Clear();
            int y = 0;
            mf_show_job.Controls.Clear();
            if (list_items.Count > 0)
            {
                foreach (Plan_Item item in list_items)
                {
                    if (Static_Class.is_euqal_day(item.Day, mf_pickday.Value))
                    {
                        show_job job = new show_job(item);
                        job.Job_Update += Job_Job_Update;
                        job.Job_Delete += Job_Job_Delete;
                        job.Location = new Point(0, y);
                        y += 70;
                        mf_show_job.Controls.Add(job);
                    }

                }
            }
        }

        private void Job_Job_Update(object? sender, EventArgs e)
        {

        }

        private void Job_Job_Delete(object? sender, EventArgs e)
        {
            show_job show = sender as show_job;
            Plan_Item item = show.Item;
            mf_show_job.Controls.Remove(show);
            list_items.Remove(item);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(Static_Class.file_path))
            {
                File.Delete(Static_Class.file_path);
            }

            Static_Class.create_file(Static_Class.file_path);
            XDocument document = XDocument.Load(Static_Class.file_path);
            foreach(Plan_Item item in list_items)
            {
                XElement element = new XElement(
                            "plan_item",
                            new XElement("title", item.Title),
                            new XElement("content", item.Content),
                            new XElement("Start_time", item.Start_time),
                            new XElement("End_time", item.End_time),
                            new XElement("Study_time", item.Study_time),
                            new XElement("Status", item.Status),
                            new XElement("Day", item.Day)
                        );
                document.Root.Add(element);
            }
            document.Save(Static_Class.file_path);
        }
    }
}
