using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сalculator_calor
{
    public partial class IMT : Form
    {
        public IMT()
        {
            InitializeComponent();
        }

        private void IMT_Load(object sender, EventArgs e)
        {
            IMT_dataGridView.Rows.Add("16 и менее", "Выраженный дефицит массы тела");
            IMT_dataGridView.Rows.Add("16—18,5", "Недостаточная (дефицит) масса тела");
            IMT_dataGridView.Rows.Add("18,5—25", "Норма");
            IMT_dataGridView.Rows.Add("25—30", "Избыточная масса тела (предожирение)");
            IMT_dataGridView.Rows.Add("30—35", "Ожирение");
            IMT_dataGridView.Rows.Add("35—40", "Ожирение резкое");
            IMT_dataGridView.Rows.Add("40 и более", "Очень резкое ожирение");
        }
    }
}
