using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ProductPrint : Form
    {
        public ProductPrint()
        {
            InitializeComponent();
        }

        private void ProductPrint_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_D__DESKTOP_INVENTORYMANAGEMENTSYSTEM_TUTORIAL_DATABASE_DBIMS_MDFDataSet2.tbProduct". При необходимости она может быть перемещена или удалена.
            this.tbProductTableAdapter.Fill(this._D__DESKTOP_INVENTORYMANAGEMENTSYSTEM_TUTORIAL_DATABASE_DBIMS_MDFDataSet2.tbProduct);

            this.reportViewer1.RefreshReport();
        }
    }
}
