﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Slats.ViewModels;

namespace Slats.Views
{
    /// <summary>
    /// Interaction logic for CprSummaryPage.xaml
    /// </summary>
    public partial class CprSummaryPage : Page
    {
        public CprSummaryPage(CprSummaryVM viewmodel)
        {
            InitializeComponent();
            DataContext = viewmodel;

        }
    }
}
