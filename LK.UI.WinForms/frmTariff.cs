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
    public partial class frmTariff : Form
    {
        CompositionRoot container;
        public frmTariff()
        {
            InitializeComponent();
        }

        //Кнопка Добавить
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Tariff tarrifInst = new Tariff
            {
                Name = txbName.Text,
                Bandwidth = Int32.Parse(txbBandwidth.Text),
                Measure = cbxMeasure.SelectedItem.ToString()
            };
            container.root.AddTariff(tarrifInst);
            ClearForm();
            GetTariffData();
        }

        //Кнопка Отмена
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Загрузка формы
        private void FrmTariff_Load(object sender, EventArgs e)
        {
            container = new CompositionRoot();
            container.BuildApplication();
            GetTariffData();
        }

        //Подгрузка тарифов из базы
        private void GetTariffData()
        {
            var tariff = container.root.GetData().Tariffs;           
            tariff.Load();
            this.dataGridView.DataSource = tariff.Local.ToBindingList();
        }


        //Выбор строки в таблице
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell!=null && dataGridView.CurrentCell.RowIndex < dataGridView.RowCount - 1) //Кидает исключение на щелчок по шапке
            {
                var selRowNum = dataGridView.CurrentCell.RowIndex;
                txbId.Text = dataGridView[0, selRowNum].Value.ToString();
                txbName.Text = dataGridView[1, selRowNum].Value.ToString(); ;
                txbBandwidth.Text = dataGridView[2, selRowNum].Value.ToString(); ;
                var schVar = dataGridView[3, selRowNum].Value.ToString();
                cbxMeasure.SelectedIndex = cbxMeasure.FindString(schVar);                
            }
            
        }
        //Очистка формы
        private void ClearForm()
        {
            txbId.Text = "";
            txbName.Text = "";
            txbBandwidth.Text = "";
            cbxMeasure.Text = "";            
        }

        /*private void DataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClearForm();
            dataGridView.ClearSelection();
            dataGridView.Rows[dataGridView.RowCount - 1].Selected = true;

        }

        private void DataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            return;
        }*/
    }
}
