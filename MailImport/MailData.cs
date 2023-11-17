using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using OpenQA.Selenium.Support.UI;


namespace MailImport
{
    public partial class MailData : Form
    {
        private string[] listAccount = null;
        private string[] listUserAgent = null;
        private string[] listSock = null;
        private string[] listProfile = null;
        private BackgroundWorker backgroundWorker1;

        private void MailData_Load(object sender, EventArgs e)
        {
            // Thêm cột "Status" đầu tiên
            dgInfo.Columns.Add("Status", "Status");

            // Thêm các cột khác cho DataGridView
            dgInfo.Columns.Add("Account", "Account");
            dgInfo.Columns.Add("Socks", "Socks");
            dgInfo.Columns.Add("UserAgent", "UserAgent");
            dgInfo.Columns.Add("Profile", "Profile");
        }
        public MailData()
        {
            InitializeComponent();
            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các danh sách đều đã được nạp
            if (listAccount == null || listSock == null || listUserAgent == null || listProfile == null)
            {
                MessageBox.Show("Vui lòng chọn tất cả các danh sách trước khi bắt đầu.");
                return;
            }

            // Khởi động BackgroundWorker
            backgroundWorker1.RunWorkerAsync();
        }
        private int currentRowIndex = 0;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<string> mergedData = new List<string>();

            int maxRowCount = Math.Max(listAccount.Length, Math.Max(listSock.Length, Math.Max(listUserAgent.Length, listProfile.Length)));

            for (int i = 0; i < maxRowCount; i++)
            {
                string account = (i < listAccount.Length) ? listAccount[i] : "";
                string sock = (i < listSock.Length) ? listSock[i] : "";
                string userAgent = (i < listUserAgent.Length) ? listUserAgent[i] : "";
                string profile = (i < listProfile.Length) ? listProfile[i] : "";

                // Assuming you have a method to determine the status based on the current data
                string status = DetermineStatus(account, sock, userAgent, profile);

                // Gộp thành từng dòng
                string mergedRow = $"{status}\t{account}\t{sock}\t{userAgent}\t{profile}";
                // Assuming "account" is the first column in your DataGridView
                // Perform Selenium login for each account
                PerformSeleniumLogin(account);
                // Update currentRowIndex before reporting progress
                currentRowIndex = i;

                // Báo cáo trạng thái xử lý
                backgroundWorker1.ReportProgress((i + 1) * 100 / maxRowCount, mergedRow);

                mergedData.Add(mergedRow);
            }

            e.Result = mergedData;
        }

        private string DetermineStatus(string account, string sock, string userAgent, string profile)
        {
            // Your logic to determine the status based on the input parameters
            // For example, you might check if certain conditions are met and return a corresponding status.

            // Replace this with your actual logic
            if (!string.IsNullOrEmpty(account) && !string.IsNullOrEmpty(sock) && !string.IsNullOrEmpty(userAgent) && !string.IsNullOrEmpty(profile))
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Ensure the currentRowIndex is within the range of rows in the DataGridView
            if (currentRowIndex >= 0 && currentRowIndex < dgInfo.Rows.Count)
            {
                // Update the "Status" column for the currentRowIndex
                dgInfo.Rows[currentRowIndex].Cells["Status"].Value = e.UserState.ToString();
            }
        }


        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Kết thúc công việc và cập nhật UI
            if (e.Error != null)
            {
                MessageBox.Show($"Lỗi: {e.Error.Message}");
            }
            else
            {
                List<string> mergedData = (List<string>)e.Result;
                DisplayDataInDataGridView(mergedData);
            }
        }

        private void DisplayDataInDataGridView(List<string> data)
        {
            // Kiểm tra xem DataGridView có ít nhất một cột không
            if (dgInfo.Columns.Count == 0)
            {
                MessageBox.Show("DataGridView chưa có cột. Hãy thêm ít nhất một cột trước khi thêm dữ liệu.");
                return;
            }

            // Xóa dữ liệu hiện tại trong DataGridView
            dgInfo.Rows.Clear();

            // Thêm dữ liệu mới vào DataGridView
            foreach (string row in data)
            {
                dgInfo.Rows.Add(row.Split('\t'));
            }
        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Đọc nội dung tệp tin .txt
                listAccount = File.ReadAllLines(filePath);

                // Hiển thị nội dung lên listAccount
                lstAccount.Items.Clear(); // Xóa dữ liệu hiện có trong listAccount
                lstAccount.Items.AddRange(listAccount); // Thêm nội dung từ tệp tin vào listAccount
            }
        }

        private void btnSocks_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Đọc nội dung tệp tin .txt
                listSock = File.ReadAllLines(filePath);

                // Hiển thị nội dung lên lstSock
                lstSocks.Items.Clear(); // Xóa dữ liệu hiện có trong lstSock
                lstSocks.Items.AddRange(listSock); // Thêm nội dung từ tệp tin vào lstSock
            }
        }

        private void btnUserAgent_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Đọc nội dung tệp tin .txt
                listUserAgent = File.ReadAllLines(filePath);

                // Hiển thị nội dung lên lstUserAgent
                lstUserAgent.Items.Clear(); // Xóa dữ liệu hiện có trong lstUserAgent
                lstUserAgent.Items.AddRange(listUserAgent); // Thêm nội dung từ tệp tin vào lstUserAgent
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Đọc nội dung tệp tin .txt
                listProfile = File.ReadAllLines(filePath);

                // Hiển thị nội dung lên lstProfile
                lstProfile.Items.Clear(); // Xóa dữ liệu hiện có trong lstProfile
                lstProfile.Items.AddRange(listProfile); // Thêm nội dung từ tệp tin vào lstProfile
            }
        }

        private void PerformSeleniumLogin(string account)
        {
            //string chromeUserDataDir = @"C:\Users\TUANT\AppData\Local\Google\Chrome\User Data\Default";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-blink-features=AutomationControlled");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--disable-extensions");
            options.AddArgument("--disable-popup-blocking");
            options.AddArgument("--disable-notifications");
            //options.AddArgument($"--user-data-dir={chromeUserDataDir}");
            options.AddArgument("--no-first-run");
            options.AddArgument("--no-service-autorun");
            options.AddArgument("--password-store=basic");
            options.AddArgument("--lang=en-US");
            options.AddArgument("--disable-cpu");
            options.AddLocalStatePreference("browser", new { enabled_labs_experiments = new string[] { "http-auth-committed-interstitials@2" } });
            options.AddArgument("--disable-incognito");
            options.AddArgument("--disable-blink-features=AutomationControlled");
            options.AddArgument(@"--start-maximized");
            options.AddArgument("user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.9999.99 Safari/537.36");
            options.AddArgument("window-size=1200x600");
            options.AddArgument("--disable-web-security");
            options.AddArgument("--allow-running-insecure-content");

            using (var driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options))
            {
                string[] acc = account.Split('|');
                string email = acc[0];
                string pass = acc[1];

                driver.Navigate().GoToUrl("https://accounts.google.com/signin/v2/identifier?uilel=3&hl=en&passive=true&service=youtube&continue=https%3A%2F%2Fwww.youtube.com%2Fsignin%3Fhl%3Den%26next%3D%252F%26action_handle_signin%3Dtrue%26app%3Ddesktop&flowName=GlifWebSignIn&flowEntry=ServiceLogin");

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                IWebElement emailInput = wait.Until(d => d.FindElement(By.CssSelector("input[type='email']")));
                emailInput.SendKeys(email);

                IWebElement nextButton = wait.Until(d => d.FindElement(By.CssSelector("div#identifierNext")));
                nextButton.Click();

                // Add a delay, adjust the sleep time based on your needs
                Thread.Sleep(1000);

                IWebElement passwordInput = wait.Until(d => d.FindElement(By.CssSelector("input[name='password']")));
                passwordInput.SendKeys(pass);

                // Add another delay
                Thread.Sleep(1000);

                IWebElement loginButton = wait.Until(d => d.FindElement(By.Id("loginButton")));
                loginButton.Click();

                // Perform any additional actions after login if needed
            }
        }











    }
}
