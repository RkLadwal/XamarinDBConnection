﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class ListItems : ContentPage
    {
        SqlHelper
        public ListItems()
        {
            InitializeComponent();
        }

        public void ListData()
        {

            lstFruits.ItemsSource = null;
        }
    }
}
