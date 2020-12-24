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
    public partial class SpecialistForm : Form

        
    {
        public Specialist Specialist { set; get; }
        public SpecialistForm()
        {
            InitializeComponent();
        }

        public SpecialistForm(Specialist specialist) : this()
        {
            textBox1.Text = specialist.Name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SpecialistForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sp = Specialist ?? new Specialist();


               sp.Name = textBox1.Text;
            
            Close();
        }
    }
}
