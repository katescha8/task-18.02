using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_18._02
{
    public partial class Form1 : Form
    {
        public List<Person> guests = new List<Person>();
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Elapsed += timer_Tick;
            timer.Enabled = true;
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            Person p1 = new Person(Status.Зарезервировано, "Иванов Иван Иванович", 1);
            Person p2 = new Person(Status.Свободно, "Карлов Карл Карлович", 2);
            Person p3 = new Person(Status.Заняты, "Моль Ольга Юрьевна", 3);
            Person p4 = new Person(Status.Выписываются, "Рожок Александра Юнусовна", 4);
            guests.Add(p1); guests.Add(p2); guests.Add(p3); guests.Add(p4);
            dataGridView1.Visible = false;
        }
        System.Timers.Timer timer = new System.Timers.Timer();
        DataGridViewRow row1 = new DataGridViewRow();
        DataGridViewRow row2 = new DataGridViewRow();
        DataGridViewRow row3 = new DataGridViewRow();
        DataGridViewRow row4 = new DataGridViewRow();
        public void timer_Tick(object sender, EventArgs e)
        {
            var str = DateTime.Now.ToString("HH:mm:ss");
            if (label1.InvokeRequired) label1.Invoke(new Action<string>((s) => label1.Text = s), str);
            else label1.Text = str;
        }
        private void Card_view(object sender, EventArgs e)
        {
            Form2 newForm = new Form2((string)dataGridView1.Rows[0].Cells[0].Value);
            newForm.Show();
        }
        public void Table_reserve(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = true;
            DataGridViewCell fio = new DataGridViewTextBoxCell();
            DataGridViewCell room = new DataGridViewTextBoxCell();
            DataGridViewCell id = new DataGridViewTextBoxCell();
            fio.Value = guests[0].name;
            room.Value = guests[0].room;
            id.Value = guests[0].number;
            row1.Cells.AddRange(fio,room,id);
            dataGridView1.Rows.Add(row1);
        }
        public void Table_free(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = true;
            DataGridViewCell fio = new DataGridViewTextBoxCell();
            DataGridViewCell room = new DataGridViewTextBoxCell();
            DataGridViewCell id = new DataGridViewTextBoxCell();
            fio.Value = guests[1].name;
            room.Value = guests[1].room;
            id.Value = guests[1].number;
            row2.Cells.AddRange(fio, room, id);
            dataGridView1.Rows.Add(row2);
        }
        public void Table_busy(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = true;
            DataGridViewCell fio = new DataGridViewTextBoxCell();
            DataGridViewCell room = new DataGridViewTextBoxCell();
            DataGridViewCell id = new DataGridViewTextBoxCell();
            fio.Value = guests[2].name;
            room.Value = guests[2].room;
            id.Value = guests[2].number;
            row3.Cells.AddRange(fio, room, id);
            dataGridView1.Rows.Add(row3);
        }
        public void Table_out(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = true;
            DataGridViewCell fio = new DataGridViewTextBoxCell();
            DataGridViewCell room = new DataGridViewTextBoxCell();
            DataGridViewCell id = new DataGridViewTextBoxCell();
            fio.Value = guests[3].name;
            room.Value = guests[3].room;
            id.Value = guests[3].number;
            row4.Cells.AddRange(fio, room, id);
            dataGridView1.Rows.Add(row4);
        }
        public void Info(object sender, EventArgs e)
        {
            label4.Text = "Номер №" + dataGridView1.Rows[0].Cells[1].Value;
            int i = (int)dataGridView1.Rows[0].Cells[2].Value;
            pictureBox11.Image=imageList1.Images[i];
            label6.Text = "Статус: " + (Status)i;
            label7.Text = (string)dataGridView1.Rows[0].Cells[0].Value;
        }
    }
}
