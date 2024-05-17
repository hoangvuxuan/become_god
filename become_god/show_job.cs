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

namespace become_god
{
    public partial class show_job : UserControl
    {
        private Plan_Item item;

        public Plan_Item Item { get => item; set => item = value; }

        private event EventHandler job_delete;
        public event EventHandler Job_Delete
        {
            add { job_delete += value; }
            remove { job_delete -= value; }
        }


        private event EventHandler job_update;
        public event EventHandler Job_Update
        {
            add { job_update += value; }
            remove { job_update -= value; }
        }

        public show_job(Plan_Item plan_item)
        {
            this.Item = plan_item;

            InitializeComponent();

            aj_cb_status.DataSource = Plan_Item.list_status;
            show_item();
        }

        private void show_item()
        {
            aj_title.Text = Item.Title;
            aj_tb_job.Text = Item.Content;
            aj_nud_from_h.Value = Item.Start_time.X;
            aj_nud_from_minute.Value = Item.Start_time.Y;
            aj_nup_to_h.Value = Item.End_time.X;
            aj_nup_to_minute.Value = Item.End_time.Y;
            aj_cb_status.SelectedIndex = Plan_Item.list_status.IndexOf(Item.Status);


            aj_cb_done.Checked = Item.Status == "done" ? true : false;
        }

        private void aj_cb_done_CheckedChanged(object sender, EventArgs e)
        {
            if (aj_cb_done.Checked)
            {
                aj_cb_status.SelectedIndex = 0;
            }
        }

        private void aj_cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (aj_cb_status.SelectedItem.ToString() == "done")
            {
                aj_cb_done.Checked = true;
                return;
            }
            aj_cb_done.Checked = false;
        }

        private void aj_bt_delete_Click(object sender, EventArgs e)
        {
            if (job_delete != null)
            {
                job_delete(this, new EventArgs());
            }
        }

        private void aj_bt_edit_Click(object sender, EventArgs e)
        {
            Item.Status = aj_cb_status.SelectedItem.ToString();
            if (job_update != null)
            {
                job_update(this, new EventArgs());
            }
        }
    }
}
