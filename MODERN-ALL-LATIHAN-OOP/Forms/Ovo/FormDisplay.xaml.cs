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

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MODERN_ALL_LATIHAN_OOP.Forms.Ovo
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FormDisplay : Window
    {
        //Global Variable
        FormOvo formOvo = new FormOvo();
        public FormDisplay()
        {
            InitializeComponent();

            //window configuration
            IntPtr hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            Microsoft.UI.WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            Microsoft.UI.Windowing.AppWindow appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
            appWindow.TitleBar.PreferredTheme = TitleBarTheme.UseDefaultAppMode;
            appWindow.Resize(new Windows.Graphics.SizeInt32(400, 600));

            AppWindow.TitleBar.PreferredTheme = TitleBarTheme.UseDefaultAppMode;
            OverlappedPresenter presenter = OverlappedPresenter.Create();

            presenter.IsAlwaysOnTop = false;
            presenter.IsMaximizable = false;
            presenter.IsMinimizable = true;
            presenter.IsResizable = false;
            presenter.SetBorderAndTitleBar(true, true);

            AppWindow.SetPresenter(presenter);
            listBoxDisplay.Items.Clear();
            foreach (OvoClass display in FormOvo.listAccount)
            {
                listBoxDisplay.Items.Add(display.DisplayData());
                listBoxDisplay.Items.Add("");
            }
        }
    }
}
