﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderServiceProject.Services;
namespace OrderServiceProject.Views
{
    public partial class ClientMenuView : Form
    {
        private GlobalContextService _context;
        public ClientMenuView(GlobalContextService context)
        {
            InitializeComponent();
            _context = context;
        }

        private void UserMenuView_FormClosed(object sender, FormClosedEventArgs e)
        {
            AuthorizationView singInView = new AuthorizationView(_context);
            singInView.Visible = true;
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            var clientProductView = new ProductListView(_context);
            clientProductView.Show();
            this.Hide();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            OrderListView orderList = new OrderListView(_context);
            orderList.Show();
            this.Hide();
        }
    }
}
