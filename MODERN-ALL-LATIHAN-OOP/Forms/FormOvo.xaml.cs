using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using MODERN_ALL_LATIHAN_OOP.Forms.Ovo;
using WinRT;
using System.Threading.Tasks;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MODERN_ALL_LATIHAN_OOP.Forms
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FormOvo : Window
    {
        public FormOvo()
        {
            this.InitializeComponent();
            OverlappedPresenter presenter = OverlappedPresenter.Create();
            presenter.IsMaximizable = false;
            presenter.IsResizable = false;

            IntPtr hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            Microsoft.UI.WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            Microsoft.UI.Windowing.AppWindow appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
            appWindow.TitleBar.PreferredTheme = TitleBarTheme.UseDefaultAppMode;
            appWindow.Resize(new Windows.Graphics.SizeInt32(500, 300));
        }

        private void registerNewAccountToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var form = new FormRegister();
            form.Activate();
        }

        private void displayAccountsToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var form = new FormDisplay();
            form.Activate();
        }

        private void removeAccountToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var form = new FormRemove();
            form.Activate();
        }

        private void topUpToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var form = new FormTopUp();
            form.Activate();
        }

        private void buyToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var form = new FormBuy();
            form.Activate();
        }

        private void exitToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
