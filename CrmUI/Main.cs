using System;
using LastCrm;
using System.Windows.Forms;

namespace CrmUI
{
    
    public partial class Main : Form
    {
        ContextCrm db;
        public Main()
        {
            InitializeComponent();
            db = new ContextCrm();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogService = new Catalog<Service>(db.Services,db);
            catalogService.Show();
        }


        private void SpecialistToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var catalogSpecialist = new Catalog<Specialist>(db.Specialists,db);
            catalogSpecialist.Show();

        }

        private void ClientToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var catalogClient = new Catalog<Client>(db.Clients,db);
            catalogClient.Show();
        }

        private void CheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCheck = new Catalog<Check1>(db.Checks,db);
            catalogCheck.Show();
        }

        private void AddServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ServiceForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Services.Add(form.Service);
                db.SaveChanges();
            }
        }

        private void AddClientToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new ClientForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Clients.Add(form.Client);
                db.SaveChanges();
            }
        }

        private void AddSpecialistToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new SpecialistForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Specialists.Add(form.Specialist);
                db.SaveChanges();
            }

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
