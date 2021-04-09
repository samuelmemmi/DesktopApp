﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlightSimulatorApp.View {
    using FlightSimulatorApp.ViewModel;
    using FlightSimulatorApp.Model;
    using OxyPlot.Series;

    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page {
        private Page3ViewModel viewmodel;

        public Page3(ModelCSV model) {
            InitializeComponent();
            this.viewmodel = new Page3ViewModel(model);
            DataContext = viewmodel;
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(100);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e) {
            Graph.InvalidatePlot(true);
            Graph_Correlative.InvalidatePlot(true);
            //Graph_Regression.InvalidatePlot(true);
            Console.WriteLine("the first point X is: " + this.viewmodel.VM_Regression_points[0].X);

        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            DataMember selected = (DataMember)((ListView)sender).SelectedItem;
            Graph.Title = selected.Name;
            Graph_Correlative.Title = selected.Correlative_string;
            //Graph_Correlative.Title = selected.Correlative.Name; 
            viewmodel.modelCSV.Data_member = selected;
        }
    }
}