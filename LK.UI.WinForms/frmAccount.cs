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
    public partial class frmAccount : Form
    {
        CompositionRoot container; //контейнер DI
        List<Tariff> tarrList; // Список тарифов
        DbSet<Account> data;   // Набор аккаунтов
        public frmAccount()
        {
            InitializeComponent();

            //cbxTariff.DataSource = container.root.GetData().Tariffs;
            //cbxTariff.DisplayMember = "Name";
            //cbxTariff.DisplayMember = "Id";
        }

        //Кнопка Отмена
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Кнопка Добавить
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Tariff tarr = (Tariff)cbxTariff.SelectedItem;
            
            var acc = new Account
            {
                Number = Convert.ToInt64(txbNumber.Text),
                AccTariff = tarr,                
                Login = txbLogin.Text,
                Password = txbPassword.Text
            };
            container.root.AddAccount(acc);
            GetAccountData();

        }
        //Выбор строки в таблице
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell != null && dataGridView.CurrentCell.RowIndex < dataGridView.RowCount - 1) //Кидает исключение на щелчок по шапке
            {
                var selRowNum = dataGridView.CurrentCell.RowIndex;
                txbId.Text = dataGridView[0, selRowNum].Value.ToString();
                txbNumber.Text = dataGridView[1, selRowNum].Value.ToString();
                txbLogin.Text = dataGridView[2, selRowNum].Value.ToString();
                txbPassword.Text = dataGridView[3, selRowNum].Value.ToString();
            }
            else ClearForm();

        }
        //Подгрузка аккаунтов из базы
        private void GetAccountData()
        {
            data = container.root.GetData().Accounts;
            data.Load();
            this.dataGridView.DataSource = data.Local.ToBindingList();            
        }

        //Очистка формы
        private void ClearForm()
        {            
            txbId.Text = "";
            txbNumber.Text = "";
            cbxTariff.Text = "";
            txbLogin.Text = "";
            txbPassword.Text = "";

        }

        //Загрузка формы
        private void FrmAccount_Load(object sender, EventArgs e)
        {
            container = new CompositionRoot();
            container.BuildApplication();
            GetAccountData();
            tarrList = container.root.GetData().Tariffs.ToList();
        }

        private void CbxTariff_MouseClick(object sender, MouseEventArgs e)
        {
            cbxTariff.DataSource = tarrList;
            cbxTariff.DisplayMember = "Name";
            cbxTariff.ValueMember = "Id";
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tarrList.ToString());
        }
    }
}
