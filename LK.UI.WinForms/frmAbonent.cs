using LK.BL.DomainModel;
using LK.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
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
            var accLst =  new List<Account>();
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
    }
}
