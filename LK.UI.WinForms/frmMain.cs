using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LK.BL.DomainModel;
using LK.BL.DomainModel.Controller;

namespace LK.UI.WinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public object LKContext { get; private set; }

        private void Button1_Click(object sender, EventArgs e)
        {
            TrafficType trafficType = new TrafficType { Name = "Входящий" };
            LKContext data = new LKContext();
            
            data.TrafficTypes.Add(trafficType);
            data.SaveChanges();
            data.Set<TrafficType>().Load();
            label1.Text = data.TrafficTypes.FirstOrDefault<TrafficType>().Name;
        }
    }
}
