using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Todoist.QuickCapture.DTO;
using Todoist.QuickCapture.Helper;

namespace Todoist.QuickCapture
{
    public partial class FormQuickCapture : Form
    {
        #region Imports

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        #endregion

        #region Fields

        private readonly TodoistAPIManager todoistAPIManager;
        public static bool Close = false;
        private static AppSettingDTO AppSettings;
        private const int ShortcutId = 0;

        #endregion

        #region Ctor

        public FormQuickCapture()
        {
            InitializeComponent();

            RegisterStartUp();
            CustomizeUI();
            AppSettings = FetchAppSettings();
            RegisterHotKey();

            todoistAPIManager = new TodoistAPIManager();
        }

        #endregion

        #region Overrides

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                Show();
                WindowState = FormWindowState.Normal;
                lbMessage.Text = null;
                tbDue.Text = null;
                for (int i = 0; i < cbLabel.Items.Count; i++)
                {
                    cbLabel.SetItemChecked(i, false);
                }
                tbTask.Focus();
            }
        }

        #endregion

        #region Events

        private void FormQuickCapture_Load(object sender, EventArgs e)
        {
            BindComboBox();
            ToggleErrorPanel();
            todoistAPIManager.GetAllTasks();
        }

        private void FormQuickCapture_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
        }

        private void FormQuickCapture_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Close)
            {
                UnregisterHotKey(Handle, ShortcutId);
                e.Cancel = false;
            }
            else
            {
                WindowState = FormWindowState.Minimized;
                e.Cancel = true;
            }
        }

        private void FormQuickCapture_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                CreateTask();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void tsMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var tag = Convert.ToInt32(e.ClickedItem.Tag);
            switch (tag)
            {
                case 1:
                    CreateTask();
                    break;
                case 2:
                    WindowState = FormWindowState.Minimized;
                    break;
                case 3:
                    var frmSettings = new FormSettings();
                    var dialogResult = frmSettings.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        AppSettings = FetchAppSettings();
                        ToggleErrorPanel();
                        UnregisterHotKey(Handle, ShortcutId);
                        RegisterHotKey();
                    }
                    break;
                case 4:
                    var frmAbout = new FormAbout();
                    frmAbout.ShowDialog();
                    break;
                case 5:
                    Close = true;
                    Close();
                    break;
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        #endregion

        #region Helpers

        private AppSettingDTO FetchAppSettings()
        {
            var filePath = Path.Combine(Application.StartupPath, "appsettings.json");
            var appSetting = new AppSettingDTO
            {
                Token = "",
                KeyModifier = (int)KeyModifier.WinKey,
                ShortcutKey = (int)ShortcutKeys.Divide
            };

            if (!File.Exists(filePath))
            {
                string json = JsonConvert.SerializeObject(appSetting);
                File.WriteAllText(filePath, json);
            }
            else
            {
                var json = File.ReadAllText(filePath);
                appSetting = JsonConvert.DeserializeObject<AppSettingDTO>(json);
            }

            return appSetting;
        }

        private void CreateTask()
        {
            if (!string.IsNullOrEmpty(tbTask.Text))
            {
                var labels = new List<long>();
                foreach (LabelDTO item in cbLabel.CheckedItems)
                {
                    labels.Add(item.Id);
                }

                var dto = new NewTaskDTO
                {
                    Content = tbTask.Text,
                    Project = Convert.ToInt64(cbProject.SelectedValue),
                    Priority = Convert.ToInt32(cbPriority.SelectedValue),
                    Labels = labels.ToArray(),
                    DueString = tbDue.Text.Trim()
                };
                var newTask = todoistAPIManager.CreateTask(dto);
                if (newTask.Id > 0)
                {
                    tbTask.Text = null;
                    for (int i = 0; i < cbLabel.Items.Count; i++)
                    {
                        cbLabel.SetItemChecked(i, false);
                    }
                    lbMessage.Text = "Task created successfully!";
                }
                else
                {
                    lbMessage.Text = "Task creation failed!";
                }
            }
            else
            {
                MessageBox.Show("Enter task details", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTask.Focus();
            }
        }

        private void BindComboBox()
        {
            var projects = todoistAPIManager.GetAllProjects();
            cbProject.DataSource = projects;
            cbProject.ValueMember = "Id";
            cbProject.DisplayMember = "Name";

            var labels = todoistAPIManager.GetAllLabels();
            cbLabel.DataSource = labels;
            cbLabel.ValueMember = "Id";
            cbLabel.DisplayMember = "Name";

            var priorities = todoistAPIManager.GetAllPriorities();
            cbPriority.DataSource = priorities;
            cbPriority.ValueMember = "Id";
            cbPriority.DisplayMember = "Name";
        }

        private void RegisterHotKey()
        {
            RegisterHotKey(Handle, ShortcutId, AppSettings.KeyModifier, AppSettings.ShortcutKey.GetHashCode());
        }

        private void CustomizeUI()
        {
            Text = "Todist Quick Capture";
            notifyIcon.Text = "Todist Quick Capture";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            lbDate.Text = $"Date: {DateTime.Today.ToString("dd-MM-yyyy")}";
        }

        private void RegisterStartUp()
        {
            var keyName = "TodoistQuickCapture";
            var exePath = Path.Combine(Application.StartupPath, "Todoist.QuickCapture.exe");

            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (registryKey.GetValue(keyName) == null)
                registryKey.SetValue(keyName, exePath);
        }

        private void ToggleErrorPanel()
        {
            if (string.IsNullOrEmpty(AppSettings.Token))
            {
                lblError.Text = "No valid token found!";
                pnlError.Dock = DockStyle.Fill;
                pnlError.Visible = true;
                tsbSave.Visible = false;
                lblError.Visible = true;
            }
            else
            {
                pnlError.Dock = DockStyle.None;
                pnlError.Visible = false;
                tsbSave.Visible = true;
            }
        }

        #endregion
    }
}
