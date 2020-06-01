using MKVmergeBatcher.Properties;
using MKVmergeBatcher.src.obj;
using System.Windows.Forms;

namespace MKVmergeBatcher.src
{
    public partial class ModelCreatorPreviewForm : Form
    {
        public UserData userData = new UserData();
        public ModelCreatorManagement modelCreatorManagement;

        public ModelCreatorPreviewForm(UserData userData)
        {
            InitializeComponent();
            this.userData = userData;
            RestoreWindowData();
            SetDataSources();
            ModelCreatorManagement modelCreatorManagement = new ModelCreatorManagement(userData);
            modelCreatorManagement.GeneratePreview();
            this.userData = modelCreatorManagement.userData;

        }

        #region Data Source Methods
        private void SetDataSources()
        {
            this.modelCreatorBindingSource.DataSource = this.userData.modelCreator;
        }
        #endregion
        #region Generic Methods
        private void RestoreWindowData()
        {
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;

            // Set window location
            if (Settings.Default.WindowLocation != null)
            {
                this.Location = Settings.Default.WindowLocation;
            }
        }

        #endregion

        #region Buttons Methods
        private void okButton_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(addToModelTextBox.Text))
            {
                UserData.ModelManagement.Model model = new UserData.ModelManagement.Model();
                model.modelName = addToModelTextBox.Text;
                model.modelContent = previewTextBox.Text;
                userData.modelManagement.modelList.Add(model);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please insert a Model name to save or use the Cancel button", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        #endregion

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
