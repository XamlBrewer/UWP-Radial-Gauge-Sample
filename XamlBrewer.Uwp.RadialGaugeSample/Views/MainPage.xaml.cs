﻿using Mvvm;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using XamlBrewer.Uwp.RadialGaugeSample.ViewModels;

namespace XamlBrewer.Uwp.RadialGaugeSample
{
    public sealed partial class MainPage : Page
    {
        private MainPageViewModel vm;

        public MainPage()
        {
            this.InitializeComponent();

            vm = new MainPageViewModel();
            this.DataContext = vm;
        }
    }
}
