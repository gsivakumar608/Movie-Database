using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class RoleForm : Form
    {
        Form1 form1;
        public RoleForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            roleBindingSource.DataSource = form1.database.Roles;
        }

        private void roleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movieDatabaseDataSet);
            form1.database.SubmitChanges();

        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDatabaseDataSet.Role' table. You can move, or remove it, as needed.
            this.roleTableAdapter.Fill(this.movieDatabaseDataSet.Role);

        }
    }
}
