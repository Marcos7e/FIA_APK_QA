using Microsoft.Win32;
using System;
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
using System.Windows.Forms;
using QA_ANDROID.core;

namespace QA_ANDROID
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string apkFolder = string.Empty;
        TextMessage tx = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSelectApk_Click(object sender, RoutedEventArgs e)
        {
            //Analyzer a = new Analyzer();
            tx = new TextMessage(TBGeneralInfo);
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                tx.SendMessage($"Seleccionado: {fbd.SelectedPath}");
                apkFolder = fbd.SelectedPath;
            }
                       
        }

        private void BtnExecAnalizys_Click(object sender, RoutedEventArgs e)
        {
            Analyzer a = new Analyzer();
            a.StartMetricVerification(apkFolder);
        }
    }
}
