using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using LastCrm;


namespace CrmUI
{
    public partial class Catalog<T> : Form where T : class
    {
        ContextCrm db;
        DbSet<T> set;
        public Catalog(DbSet<T> set, ContextCrm db)
        
        {
            this.set = set;
            this.db = db;
            set.Load();
            InitializeComponent();
            dataGridView.DataSource = set.Local.ToBindingList();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var id = dataGridView.SelectedRows[0].Cells[0].Value;
            
            if (typeof(T) == typeof(Service))
            {
                 var service = set.Find(id) as Service;
                if (service != null)
                {
                    var form = new ServiceForm(service);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        service = form.Service;
                        db.SaveChanges();
                        dataGridView.Update();
                    }
                }

                 }
            else if(typeof(T) == typeof(Client))
            {
                var client = set.Find(id) as Client;
                if (client != null)
                {
                    var form = new ClientForm(client);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        client = form.Client;
                        db.SaveChanges();
                        dataGridView.Update();
                    }
                }

            }else if (typeof(T) == typeof(Specialist))
            {
                var specialist = set.Find(id) as Specialist;
                if (specialist != null)
                {
                    var form = new SpecialistForm(specialist);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        specialist = form.Specialist;
                        db.SaveChanges();
                        dataGridView.Update();
                    }
                }

            }

        }
    }
}
