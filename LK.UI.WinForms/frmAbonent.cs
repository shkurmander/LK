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
    public partial class frmAbonent : Form
    {
        CompositionRoot container;
        DateTime abonentBirth;
        public frmAbonent()
        {
            InitializeComponent();

        }

        private void CbxAccount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmAbonent_Load(object sender, EventArgs e)
        {
            container = new CompositionRoot();
            container.BuildApplication();
            GetAbonetsData();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Year - dateTimePicker1.Value.Year < 18)
            {
                MessageBox.Show("Неокрректная дата рождения, либо гражданин еще не достиг правового возраста");
                return;
            }
            var tarr = new Tariff
            {
                Name = "Tariff #1",
                Bandwidth = 100,
                Measure = "Mbit"
            };
            var tariffLst = new List<Tariff>();
            tariffLst.Add(tarr);
            var acc = new Account
            {
                Number = 622011020330,
                Login = "fttx0403-155-000",
                Password = "dummypass",
                Tariff = tariffLst
            };
            var accLst = new List<Account>();
            accLst.Add(acc);


            Abonent abon = new Abonent
            {
                FirstName = txbFirstName.Text,
                Patronimyc = txbPatronimyc.Text,
                LastName = txbLastName.Text,
                BirthDate = abonentBirth,
                Address = txbAddress.Text,
                EMail = txbEmail.Text,
                Passport = txbPassport.Text,
                Phone = txbPhone.Text,
                Accounts = accLst
            };
            container.root.AddAbonent(abon);
            ClearForm();
            GetAbonetsData();
        }


        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            abonentBirth = dateTimePicker1.Value;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearForm()
        {
            txbFirstName.Text = "";
            txbPatronimyc.Text = "";
            txbLastName.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            txbAddress.Text = "";
            txbEmail.Text = "";
            txbPassport.Text = "";
            txbPhone.Text = "";
        }
        private void GetAbonetsData()
        {
            var abon = container.root.GetData().Abonent;
            //abonSet.Set<Abonent>().Load();
            abon.Load();
            this.dataGridView.DataSource = abon.Local.ToBindingList();
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell.RowIndex < dataGridView.RowCount - 1)
            {
                var selRowNum = dataGridView.CurrentCell.RowIndex;
                txbId.Text = dataGridView[0, selRowNum].Value.ToString();
                txbFirstName.Text = dataGridView[1, selRowNum].Value.ToString(); ;
                txbPatronimyc.Text = dataGridView[2, selRowNum].Value.ToString(); ;
                txbLastName.Text = dataGridView[3, selRowNum].Value.ToString(); ;
                //dateTimePicker1.Value = Convert.ToDateTime(dataGridView[5, selRowNum].Value.ToString());
                txbAddress.Text = dataGridView[5, selRowNum].Value.ToString(); ;
                txbEmail.Text = dataGridView[6, selRowNum].Value.ToString(); ;
                txbPassport.Text = dataGridView[7, selRowNum].Value.ToString(); ;
                txbPhone.Text = dataGridView[8, selRowNum].Value.ToString(); ;
            }

            /*string s = "";
            for (int i = 0; i < dataGridView.Columns.Count-1; i++)
            {
                s += dataGridView[i, selRowNum].Value.ToString() + "\n";
            }
            MessageBox.Show(s);
            */
        }
    }
}
