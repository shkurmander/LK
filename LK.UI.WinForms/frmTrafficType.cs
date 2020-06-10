using LK.BL.DomainModel;
using LK.Config;
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

namespace LK.UI.WinForms
{
    public partial class frmTrafficType : Form
    {
        CompositionRoot container;
        public frmTrafficType()
        {
            InitializeComponent();
        }

        //Кнопка добавить
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            TrafficType trType = new TrafficType
            {
                Name = txbType.Text
            };
            container.root.AddTrafficType(trType);
            GetTrafficTypeData();
        }

        //Загрузка формы
        private void FrmTrafficType_Load(object sender, EventArgs e)
        {
            container = new CompositionRoot();
            container.BuildApplication();
            GetTrafficTypeData();
        }

        //Подгрузка типов трафика из базы
        private void GetTrafficTypeData()
        {
            var data = container.root.GetData().TrafficTypes;
            data.Load();
            this.dataGridView.DataSource = data.Local.ToBindingList();
        }

        //Кнопка отмена
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Выбор строки в таблице
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell != null && dataGridView.CurrentCell.RowIndex < dataGridView.RowCount - 1) //Кидает исключение на щелчок по шапке
            {
                var selRowNum = dataGridView.CurrentCell.RowIndex;
                txbId.Text = dataGridView[0, selRowNum].Value.ToString();
                txbType.Text = dataGridView[1, selRowNum].Value.ToString(); ;              
            }

        }

        //Очистка формы
        private void ClearForm()
        {
            txbType.Text = "";
            txbId.Text = "";            
        }

        
    }
}
