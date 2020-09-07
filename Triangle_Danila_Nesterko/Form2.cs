using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_Danila_Nesterko
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			txtA.Enabled = true;
			txtB.Enabled = true;
			txtC.Enabled = true;
			txtD.Enabled = false;
			txtH.Enabled = false;
            label13.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label25.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label14.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label24.Visible = true;
        }

		private void button2_Click(object sender, EventArgs e)
		{
			txtA.Enabled = false;
			txtB.Enabled = false;
			txtC.Enabled = false;
			txtD.Enabled = true;
			txtH.Enabled = true;
            label13.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label25.Visible = true;
            label26.Visible = true;
            label27.Visible = true;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label14.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;

        }

		private void run_Click(object sender, EventArgs e)
		{
            double a, b, c, h;
            if (txtA.Enabled == false)
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);



                Triangle triangle = new Triangle(a, b, c);
                listView1.Items.Clear();
                listView1.Items.Add("Сторона а");
                listView1.Items.Add("Сторона b");
                listView1.Items.Add("Сторона c");
                listView1.Items.Add("Полупериметр");
                listView1.Items.Add("Периметр");
                listView1.Items.Add("Площадь");
                listView1.Items.Add("Существует?");
                listView1.Items.Add("Спецификатор");
                listView1.Items[0].SubItems.Add(triangle.outputA());
                listView1.Items[1].SubItems.Add(triangle.outputB());
                listView1.Items[2].SubItems.Add(triangle.outputC());
                listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Half_Perimeter()));
                listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Perimeter()));
                listView1.Items[5].SubItems.Add(Convert.ToString(triangle.Surface()));
                if (triangle.ExistTriangle) { listView1.Items[6].SubItems.Add("Существует"); }
                else listView1.Items[6].SubItems.Add("Не существует");
                listView1.Items[7].SubItems.Add(triangle.Ttype());
            }
            if (txtA.Enabled == true)
            {
                a = Convert.ToDouble(txtD.Text);
                h = Convert.ToDouble(txtH.Text);

                Triangle triangle = new Triangle(a, h);
                listView1.Items.Clear();
                listView1.Items.Add("Сторона а");
                listView1.Items.Add("Сторона h");
                listView1.Items.Add("Площадь");
                listView1.Items[0].SubItems.Add(triangle.outputA());
                listView1.Items[1].SubItems.Add(triangle.outputH());
                listView1.Items[2].SubItems.Add(Convert.ToString(triangle.SurfaceH()));
            };
        }

		private void Form2_Load(object sender, EventArgs e)
		{

		}
	}
}
