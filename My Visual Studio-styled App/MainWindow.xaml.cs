using MahApps.Metro.Controls;
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
using TaskDialogInterop;

namespace My_Visual_Studio_styled_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            OpenFileDialog openFileDlg = new OpenFileDialog();

            // Launch OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = openFileDlg.ShowDialog();
            // Get the selected file name and display in a TextBox.
            // Load content of file in a TextBlock
            if (result == true)
            {
                TaskDialogOptions config = new TaskDialogOptions();

                config.Owner = this;
                config.Title = "Open File";
                config.MainInstruction = "File opened";
                config.Content = "You opened an file at all! You nailed it!";
                config.ExpandedInfo = "File was opened.";
                config.VerificationText = "Don't show me this message again";
                config.CustomButtons = new string[] { "&OK", "C&ancel", "Hel&p" };
                config.MainIcon = VistaTaskDialogIcon.Shield;
                config.FooterText = "You have opened a file.";
                config.FooterIcon = VistaTaskDialogIcon.Warning;

                TaskDialogResult res = TaskDialog.Show(config);
            }
        }

        private void OpenImage_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            OpenFileDialog openImageDlg = new OpenFileDialog();

            openImageDlg.InitialDirectory = "E:\\";
            openImageDlg.Filter = "Joint Photographic Experts Group (*.jpg)|*.jpg|Portable Network Graphics (*.png)|*.png|Scalable Vector Graphics (*.svg)|*.svg|Bitmap (*.bmp)|*.bmp|Device Independent Bitmap (*.dib)|*.dib|All Files (*.*)|*.*";
            openImageDlg.RestoreDirectory = true;
            // Launch OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = openImageDlg.ShowDialog();
            // Get the selected file name and display in a TextBox.
            // Load content of file in a TextBlock
            if (result == true)
            {
                TaskDialogOptions config = new TaskDialogOptions();

                config.Owner = this;
                config.Title = "Open Image";
                config.MainInstruction = "Image opened";
                config.Content = "You opened an image at all! You nailed it again!";
                config.ExpandedInfo = "Image was opened.";
                config.VerificationText = "Don't show me this message again";
                config.CustomButtons = new string[] { "&OK", "Hel&p" };
                config.MainIcon = VistaTaskDialogIcon.Shield;
                config.FooterText = "You have opened a image.";
                config.FooterIcon = VistaTaskDialogIcon.Warning;

                TaskDialogResult res = TaskDialog.Show(config);

                string selectedFileName = openImageDlg.FileName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(selectedFileName);
                bitmap.EndInit();
                ImageViewer1.Source = bitmap;


                string selectedFileName1 = openImageDlg.FileName;
                BitmapImage bitmap1 = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(selectedFileName1);
                bitmap.EndInit();
                ImageViewer2.Source = bitmap1;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            /*
            MenuItem menuItem = sender as MenuItem;
            menuItem.FontFamily = new FontFamily("Comic Sans MS");
            menuItem.Foreground = SystemColors.WindowBrush;
             */
            label.FontSize = 30;
            label.FontFamily = new FontFamily("Comic Sans MS");
            label.Foreground = SystemColors.WindowBrush;
            label.Content = "You nailed it!!!";

            e.Handled = true;
        }
    }
}
