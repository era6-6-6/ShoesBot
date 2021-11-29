﻿using System;
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
        public MainWindow()
        {
            InitializeComponent();
           
        }
        private ChromeDriver InitBrowser()
        {
            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            var chromeSetting = new ChromeOptions();
            var chromeDriver = new ChromeDriver();
            return chromeDriver;
        }
        private Task StartBrowser()
        {
            _driver = InitBrowser();
            return Task.CompletedTask;
        }



    }
}
