namespace ShoesBot
{
    partial class MainWindow
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTab = new MetroFramework.Controls.MetroTabControl();
            this.StartPage = new MetroFramework.Controls.MetroTabPage();
            this.StatsPage = new MetroFramework.Controls.MetroTabPage();
            this.SettingsPage = new MetroFramework.Controls.MetroTabPage();
            this.MainPage = new MetroFramework.Controls.MetroPanel();
            this.StartBtn = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.StopBtn = new MetroFramework.Controls.MetroButton();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.MainTab.SuspendLayout();
            this.StartPage.SuspendLayout();
            this.MainPage.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.StartPage);
            this.MainTab.Controls.Add(this.StatsPage);
            this.MainTab.Controls.Add(this.SettingsPage);
            this.MainTab.Controls.Add(this.metroTabPage1);
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.ItemSize = new System.Drawing.Size(70, 40);
            this.MainTab.Location = new System.Drawing.Point(20, 60);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(911, 483);
            this.MainTab.TabIndex = 0;
            this.MainTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MainTab.UseSelectable = true;
            // 
            // StartPage
            // 
            this.StartPage.Controls.Add(this.metroPanel1);
            this.StartPage.Controls.Add(this.MainPage);
            this.StartPage.HorizontalScrollbarBarColor = true;
            this.StartPage.HorizontalScrollbarHighlightOnWheel = false;
            this.StartPage.HorizontalScrollbarSize = 10;
            this.StartPage.Location = new System.Drawing.Point(4, 44);
            this.StartPage.Name = "StartPage";
            this.StartPage.Size = new System.Drawing.Size(903, 435);
            this.StartPage.TabIndex = 0;
            this.StartPage.Text = "Start";
            this.StartPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StartPage.VerticalScrollbarBarColor = true;
            this.StartPage.VerticalScrollbarHighlightOnWheel = false;
            this.StartPage.VerticalScrollbarSize = 10;
            // 
            // StatsPage
            // 
            this.StatsPage.HorizontalScrollbarBarColor = true;
            this.StatsPage.HorizontalScrollbarHighlightOnWheel = false;
            this.StatsPage.HorizontalScrollbarSize = 10;
            this.StatsPage.Location = new System.Drawing.Point(4, 44);
            this.StatsPage.Name = "StatsPage";
            this.StatsPage.Size = new System.Drawing.Size(903, 435);
            this.StatsPage.TabIndex = 1;
            this.StatsPage.Text = "Stats";
            this.StatsPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StatsPage.VerticalScrollbarBarColor = true;
            this.StatsPage.VerticalScrollbarHighlightOnWheel = false;
            this.StatsPage.VerticalScrollbarSize = 10;
            // 
            // SettingsPage
            // 
            this.SettingsPage.HorizontalScrollbarBarColor = true;
            this.SettingsPage.HorizontalScrollbarHighlightOnWheel = false;
            this.SettingsPage.HorizontalScrollbarSize = 10;
            this.SettingsPage.Location = new System.Drawing.Point(4, 44);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Size = new System.Drawing.Size(903, 435);
            this.SettingsPage.TabIndex = 2;
            this.SettingsPage.Text = "Settings";
            this.SettingsPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SettingsPage.VerticalScrollbarBarColor = true;
            this.SettingsPage.VerticalScrollbarHighlightOnWheel = false;
            this.SettingsPage.VerticalScrollbarSize = 10;
            // 
            // MainPage
            // 
            this.MainPage.Controls.Add(this.StartBtn);
            this.MainPage.HorizontalScrollbarBarColor = true;
            this.MainPage.HorizontalScrollbarHighlightOnWheel = false;
            this.MainPage.HorizontalScrollbarSize = 10;
            this.MainPage.Location = new System.Drawing.Point(3, 3);
            this.MainPage.Name = "MainPage";
            this.MainPage.Size = new System.Drawing.Size(213, 40);
            this.MainPage.TabIndex = 2;
            this.MainPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MainPage.VerticalScrollbarBarColor = true;
            this.MainPage.VerticalScrollbarHighlightOnWheel = false;
            this.MainPage.VerticalScrollbarSize = 10;
            // 
            // StartBtn
            // 
            this.StartBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.StartBtn.Location = new System.Drawing.Point(0, 0);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(213, 34);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseSelectable = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.StopBtn);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 43);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(213, 40);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // StopBtn
            // 
            this.StopBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.StopBtn.Location = new System.Drawing.Point(0, 0);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(213, 34);
            this.StopBtn.TabIndex = 2;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseSelectable = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(903, 435);
            this.metroTabPage1.TabIndex = 3;
            this.metroTabPage1.Text = "Log";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 563);
            this.Controls.Add(this.MainTab);
            this.Name = "MainWindow";
            this.Text = "ShoesBot";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MainTab.ResumeLayout(false);
            this.StartPage.ResumeLayout(false);
            this.MainPage.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl MainTab;
        private MetroFramework.Controls.MetroTabPage StartPage;
        private MetroFramework.Controls.MetroTabPage StatsPage;
        private MetroFramework.Controls.MetroTabPage SettingsPage;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton StopBtn;
        private MetroFramework.Controls.MetroPanel MainPage;
        private MetroFramework.Controls.MetroButton StartBtn;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
    }
}

