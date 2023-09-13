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
using System.Windows.Forms.Integration;
using System.Windows.Forms; // эту билиотеку подключили для MaskedTextBox

namespace AutorisationForms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        WindowsFormsHost _host;
        MaskedTextBox _maskedTextBox;
        MaskedTextBox maskedTextBoxPassword = new MaskedTextBox(); //using System.Windows.Forms;
        public MainWindow()
        {
            InitializeComponent();
            Loaded += Window_Loaded; // прикрепили обработчик событий
        }

      

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WindowsFormsHost host = new WindowsFormsHost();
            _host = host;
            MaskedTextBox  maskedTextBoxPassword = new MaskedTextBox(); //using System.Windows.Forms;
            _maskedTextBox = maskedTextBoxPassword;
            maskedTextBoxPassword.PasswordChar = '*';
            maskedTextBoxPassword.Size = new System.Drawing.Size(253, 38);
            host.Child = maskedTextBoxPassword;
            myGrid.Children.Add(host);
            Grid.SetColumn(host, 2);
            Grid.SetRow(host, 2); // расставили по Grid
            maskedTextBoxPassword.BackColor = System.Drawing.Color.GhostWhite;

            maskedTextBoxPassword.Font =
                            new System.Drawing.Font(System.Drawing.FontFamily.GenericMonospace,
                            20F,
                            System.Drawing.FontStyle.Regular,
                            System.Drawing.GraphicsUnit.Point,
                            ((byte)(204)));

        }
        private void showPassword_Click(object sender, RoutedEventArgs e)
        {
            inputPassword.Text = _maskedTextBox.Text;

        }

       private void showPassword_MouseClick(object sender, RoutedEventArgs e)
        {
      
            _maskedTextBox.PasswordChar = '\0';
        }
        private void showPassword_Leave(object sender, RoutedEventArgs e)
        {
            _maskedTextBox.PasswordChar = '*';
        }
    }
}
