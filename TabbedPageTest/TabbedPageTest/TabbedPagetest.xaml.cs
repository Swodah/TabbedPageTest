﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPageTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPagetest : TabbedPage
    {
        public TabbedPagetest()
        {
            InitializeComponent();
        }
    }
}