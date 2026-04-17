using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using MODERN_ALL_LATIHAN_OOP.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MODERN_ALL_LATIHAN_OOP.Forms.Ovo
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FormRegister : Window
    {
        OvoClass createAccount;
        FormOvo formOvo = new FormOvo();
        public FormRegister()
        {
            this.InitializeComponent();
            //window configuration
            IntPtr hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            Microsoft.UI.WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            Microsoft.UI.Windowing.AppWindow appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
            appWindow.TitleBar.PreferredTheme = TitleBarTheme.UseDefaultAppMode;
            appWindow.Resize(new Windows.Graphics.SizeInt32(400, 600));
            //theme title bar
            AppWindow.TitleBar.PreferredTheme = TitleBarTheme.UseDefaultAppMode;
            OverlappedPresenter presenter = OverlappedPresenter.Create();

            presenter.IsAlwaysOnTop = false;
            presenter.IsMaximizable = false;
            presenter.IsMinimizable = true;
            presenter.IsResizable = false;
            presenter.SetBorderAndTitleBar(true, true);

            AppWindow.SetPresenter(presenter);

        }

        private async void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = textBoxName.Text;
                int.TryParse(textBoxPhoneNumber.Text, out int phoneNumber);
                int.TryParse(textBoxPIN.Password, out int pin);
                string ovoID = textBoxOvoID.Text;

                createAccount = new OvoClass(name, phoneNumber, pin, ovoID);
                FormOvo.dictAccount.Add(createAccount.Nama, createAccount);
                FormOvo.listAccount.Add(createAccount);

                ContentDialog successDialog = new ContentDialog();
                successDialog.XamlRoot = this.Content.XamlRoot;
                successDialog.Title = "Account Created \nSuccessfully";
                successDialog.Content = createAccount.DisplayData();
                successDialog.CloseButtonText = "OK";
                successDialog.DefaultButton = ContentDialogButton.Close;
                ContentDialogResult result = await successDialog.ShowAsync();
            }
            catch(Exception ex)
            {
                ContentDialog errDialog = new ContentDialog();
                errDialog.XamlRoot = this.Content.XamlRoot;
                errDialog.Title = "Error:";
                errDialog.Content = ex.Message;
                errDialog.CloseButtonText = "OK";
                errDialog.DefaultButton = ContentDialogButton.Close;
                ContentDialogResult result = await errDialog.ShowAsync();
            }
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
