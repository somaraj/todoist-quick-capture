using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
using Todoist.QuickCapture.DTO;
using Todoist.QuickCapture.Helper;

namespace Todoist.QuickCapture
{
    public partial class FormSettings : Form
    {
        private string FilePath = Path.Combine(Application.StartupPath, "appsettings.json");
        public FormSettings()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbToken.Text))
            {
                var appSetting = new AppSettingDTO
                {
                    Token = tbToken.Text,
                    KeyModifier = (int)cbKeyModifier.SelectedItem,
                    ShortcutKey = (int)cbKeys.SelectedItem
                };

                if (File.Exists(FilePath))
                {
                    string json = JsonConvert.SerializeObject(appSetting);
                    File.WriteAllText(FilePath, json);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void FormSettings_Load(object sender, System.EventArgs e)
        {
            cbKeyModifier.DataSource = Enum.GetValues(typeof(KeyModifier));
            cbKeys.DataSource = Enum.GetValues(typeof(ShortcutKeys));

            if (File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);
                var appSetting = JsonConvert.DeserializeObject<AppSettingDTO>(json);
                tbToken.Text = appSetting.Token;
                cbKeyModifier.SelectedItem = (KeyModifier)Enum.Parse(typeof(KeyModifier), appSetting.KeyModifier.ToString());
                cbKeys.SelectedItem = (ShortcutKeys)Enum.Parse(typeof(ShortcutKeys), appSetting.ShortcutKey.ToString());
            }
        }
    }
}
