using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LastCrm;

namespace CrmUI
{
    public partial class ServiceForm : Form
    {
        public Service Service { set; get; }
        public ServiceForm()
        {
            InitializeComponent();
        }

        public ServiceForm(Service service) : this()
        {
            Service = service;
            textBox1.Text = Service.Name;
            numericUpDown1.Value = Service.Price;
            numericUpDown2.Value = Service.Count;
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var s = Service ?? new Service();
            s.Name = textBox1.Text;
            s.Price = numericUpDown1.Value;
            s.Count = Convert.ToInt32(numericUpDown2.Value);
                
            
            Close();
        }
    }
}
