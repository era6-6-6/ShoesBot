using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using OpenQA.Selenium.Chrome;


namespace ShoesBot
{
   
    public partial class MainWindow : MetroForm
    {
        public static ChromeDriver _driver;
        Thread _thread;
        public MainWindow()
        {
            InitializeComponent();
           
        }
        private ChromeDriver InitBrowser()
        {
            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            var chromeSetting = new ChromeOptions();
            var chromeDriver = new ChromeDriver(service);
            return chromeDriver;
        }
        private Task StartBrowser()
        {
            _driver = InitBrowser();
            return Task.CompletedTask;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
                Task.Run(() => StartBrowser());
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            _driver.Quit();
            
        }
    }
}
