﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Equin.ApplicationFramework;
using Microsoft.Access.Data.Contexts;
using Microsoft.Access.Data.LanguageExtensions;
using Microsoft.Access.Data.WorkingClasses;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Access.Data
{
    public partial class Form1 : Form
    {
        //https://github.com/waynebloss/BindingListView
        private BindingListView<CustomerEntity> _customersView;
        private BindingSource _customersBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            using (var context = new NorthWindAccessContext())
            {
                var customerData = (from customer in context.Customers
                    join country in context.Countries on customer.CountryIdentifier equals country.CountryIdentifier
                    select new CustomerEntity
                    {
                        CustomerIdentifier = customer.CustomerIdentifier,
                        CustomerName = customer.CompanyName,
                        CountryIdentifier = customer.CountryIdentifier,
                        Country = country.Name
                    }).ToList();

                _customersView = new BindingListView<CustomerEntity>(customerData);
                _customersBindingSource.DataSource = _customersView;
                dataGridView1.DataSource = _customersBindingSource;
            }
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            var currentCustomer = _customersBindingSource.CurrentCustomerEntity();
            MessageBox.Show($"Id: {currentCustomer.CustomerIdentifier} country id: {currentCustomer.CountryIdentifier}");
        }
    }
}
