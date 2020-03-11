﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace KetNoi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                try

                {

                    using (SqlConnection connection =

                        new SqlConnection(@"Server=DESKTOP-25QNV3J\SQLEXPRESS; Database=QuanLySinhVien; Integrated Security=SSPI"))

                    {

                        connection.Open();

                    }

                    MessageBox.Show("Mo va dong co so du lieu thanh cong.");

                }

                catch (Exception ex)

                {

                    MessageBox.Show("Loi khi mo  ket noi: " + ex.Message);

                }
        }
    }
}
