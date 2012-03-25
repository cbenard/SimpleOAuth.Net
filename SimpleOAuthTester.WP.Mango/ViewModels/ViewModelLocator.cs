﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SimpleOAuthTester.WP.Mango.ViewModels
{
    public class ViewModelLocator
    {
        private static readonly MainViewModel _main = new MainViewModel();

        public MainViewModel Main { get { return _main; } }
    }
}