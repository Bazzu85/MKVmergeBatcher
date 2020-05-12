using MKVmergeBatcher.src.obj;
using System;
using System.Windows.Forms;

namespace MKVmergeBatcher
{
    public partial class Form1 : Form
    {
        #region Variables

        int audioCount = 1;

        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        #region Model Creator Tab Methods

        private void MCAddAudioButton_Click(object sender, EventArgs e)
        {
            Label audioLabel = new Label();
            this.tabModelCreator.Controls.Add(audioLabel);
            audioLabel.Text = "Audio" + audioCount;
            audioLabel.Name = "audioLabel" + audioCount;
            audioLabel.Top = audioCount * 25;
            audioLabel.Left = 100;
            Console.WriteLine("nome: " + audioLabel.Name);
            Button removeAudioButton = new Button();
            this.tabModelCreator.Controls.Add(removeAudioButton);
            removeAudioButton.Text = "Remove audio track";
            audioCount += 1;

            UserData ud = new UserData();
            Console.WriteLine(ud.modelCreator.Name);
            Console.WriteLine(ud.windows.WindowWidth);





        }
        #endregion
    }
}
