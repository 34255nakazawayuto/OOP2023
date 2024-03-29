﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            lbColor.Background = new SolidColorBrush(Color.FromRgb((byte)slider1.Value, (byte)slider2.Value, (byte)slider3.Value));

        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            lbColor1.Items.Add(new ColorSave {
                Color = Color.FromRgb((byte)slider1.Value, (byte)slider2.Value, (byte)slider3.Value)
            });
        }
        private void lbColor1_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            slider1.Value = ((ColorSave)(lbColor1.SelectedItem)).Color.R;
            slider2.Value = ((ColorSave)(lbColor1.SelectedItem)).Color.G;
            slider3.Value = ((ColorSave)(lbColor1.SelectedItem)).Color.B;
        }
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void CombBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var c = ((MyColor)(((ComboBox)sender).SelectedItem)).Color;
            lbColor.Background = new SolidColorBrush(c);
            slider1.Value = c.R;
            slider2.Value = c.G;
            slider3.Value = c.B;
        }
    }

}
