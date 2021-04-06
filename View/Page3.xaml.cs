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
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page {
        private Page3ViewModel viewmodel;

        public Page3(ModelCSV model) {
            InitializeComponent();
            this.viewmodel = new Page3ViewModel(model);
            DataContext = viewmodel;
<<<<<<< HEAD

            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(100);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e) {
            Graph.InvalidatePlot(true);
        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            DataMember selected = (DataMember)((ListView)sender).SelectedItem;
            Graph.Title = selected.Name;
            viewmodel.modelCSV.Data_member = selected;
=======
        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e) {

            var selected = (DataMember)((ListView)sender).SelectedItem;
            DataMember myDataObject = (DataMember)((ListView)sender).SelectedItem;
            viewmodel.modelCSV.Data_member = myDataObject;

            //this.viewmodel.VM_Points = myDataObject.Points;


            /*Binding b = new Binding("VM_Points");
            b.Source = viewmodel;
            GraphPoints.SetBinding(ItemsControl.ItemsSourceProperty, b);*/

            //this.ItemsControlPoints.ItemsSource = selected.Points;*/
>>>>>>> 412fea775eb6bff312a4370332fc532dffbaa47c
        }
    }
}
