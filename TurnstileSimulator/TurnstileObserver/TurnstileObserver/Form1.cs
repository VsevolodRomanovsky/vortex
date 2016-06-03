using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using TurnstileObserver.TurnstileService;

namespace TurnstileObserver
{

    public partial class Form1 : Form
    {
        List<Visitor> _visitorsList;
        private List<Visit> _visitList;

        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var vc = new ServiceVisitClient();
            _visitorsList = vc.AllVisitors();

            _visitList = _visitorsList.Where(t => t.Id == _visitorsList[0].Id).SelectMany(t => t.Visits).ToList();

            dgvVisitors.DataSource = _visitorsList;
            dgvVisits.DataSource = _visitList;
            pbPhoto.Image = PictureFormat(_visitorsList[0].Picture);

            dgvVisitors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVisitors.Rows[0].Selected = true;
            

        }

        private void dgvVisitors_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvVisitors.SelectedRows.Count !=0)
            {
                var userId = (int)dgvVisitors.SelectedRows[0].Cells["Id"].Value;
                var img = _visitorsList.Where(t => t.Id == userId).Select(t => t.Picture).FirstOrDefault();
                pbPhoto.Image = PictureFormat(img);
                _visitList = _visitorsList.Where(t => t.Id == userId).SelectMany(t => t.Visits).ToList();
                dgvVisits.DataSource = _visitList;
            }
 
        }

        private Image PictureFormat(byte[] image)
        {
            var ms = new MemoryStream(image);
            var img = Image.FromStream(ms);
            return img;
        }

        private void dgvVisitors_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (((DataGridView) sender).Columns[e.ColumnIndex].Name != "IsValid") return;
            e.Value = (bool)e.Value ? string.Empty : "Заблокирован";
            e.FormattingApplied = true;
        }

        private void dgvVisits_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (((DataGridView) sender).Columns[e.ColumnIndex].Name != "VisitType") return;

            if (e.Value is int)
            {
                e.Value = (int) e.Value == 1 ? "Пришел" : "Ушел";
            }
            e.FormattingApplied = true;
        }
    }
}
