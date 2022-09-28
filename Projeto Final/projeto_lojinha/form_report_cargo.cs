using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_lojinha
{
    public partial class form_report_cargo : Form
    {
        public form_report_cargo()
        {
            InitializeComponent();
        }

        private void form_report_cargo_Load(object sender, EventArgs e)
        {
            //INSTANCIAR CLASSE CARGO PRA USAR O MÉTODO DE REPORT(SELECT)
            class_cargo ccargo = new class_cargo();
            class_cargoBindingSource.DataSource = ccargo.relatorio_cargo();

            this.reportViewer1.RefreshReport();
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
