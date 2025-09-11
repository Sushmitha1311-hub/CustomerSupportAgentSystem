using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerSupportSystem
{
    public partial class FormTickets : Form
    {
        private string v;

        public FormTickets()
        {
            InitializeComponent();
        }

        public FormTickets(string v)
        {
            this.v = v;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
            private void txtSearch_TextChanged(object sender, EventArgs e)
          {
            string searchValue = txtSearch.Text.ToLower();

            foreach (DataGridViewRow row in dgvTickets.Rows)
            {
                if (row.IsNewRow) continue;

                bool match = row.Cells["ticketId"].Value.ToString().ToLower().Contains(searchValue) ||
                             row.Cells["subject"].Value.ToString().ToLower().Contains(searchValue);

                row.Visible = match;
            }
          }

        private void txtSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

