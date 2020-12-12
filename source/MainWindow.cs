using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Media_Converter
{
    public partial class MainWindow : Form
    {
        private static List<string> extensions = new List<string>();
        private static string input = "";
        private static string output = "";
        private static string argument = "";
        private static Button button = new Button();

        public MainWindow()
        {
            InitializeComponent();         
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            extensions.Add("mp4");
            extensions.Add("mov");
            extensions.Add("ebm");
            extensions.Add("avi");
            extensions.Add("flv");
            extensions.Add("wmv");
            extensions.Add("mkv");        
        }

        private void Input_Button_Click(object sender, EventArgs e)
        {
            Input_Dialog.ShowDialog();

            string extension = "";

            try
            {
                extension = Input_Dialog.FileName.Substring(Input_Dialog.FileName.Length - 3);
            }
            catch
            {
                ;
            }

            if (extensions.Any(extension.Contains))
            {
                Input_Box.Text = Input_Dialog.FileName;
            }
            else
            {
                MessageBox.Show("Please choose valid video file!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Output_Button_Click(object sender, EventArgs e)
        {
            Output_Dialog.ShowDialog();
            Output_Box.Text = Output_Dialog.SelectedPath;
        }

        private void Convert_Button_Click(object sender, EventArgs e)
        {
            if (Input_Box.Text == "" || Output_Box.Text == "")
            {
                MessageBox.Show("Please choose input file and output folder!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Convert_Button.Enabled = false;
                Convert_Button.Text = "Converting...";

                input = Input_Box.Text;
                output = Output_Box.Text;

                switch (Format_Choice.Text)
                {
                    case "mp4":
                        argument = $@"-i {input} -c:v h264 {output}\converted-file.mp4";
                        break;

                    case "mkv":
                        argument = $@"-i {input} -c:v h264 {output}\converted-file.mkv";
                        break;

                    case "avi":
                        argument = $@"-i {input} -c:v h264 {output}\converted-file.avi";
                        break;

                    case "webm":
                        argument = $@"-i {input} {output}\converted-file.webm";
                        break;

                    case "wmv":
                        argument = $@"-i {input} -c:v msmpeg4v3 {output}\converted-file.wmv";
                        break;

                    case "mov":
                        argument = $@"-i {input} -c:v h264 {output}\converted-file.mov";
                        break;

                    case "flv":
                        argument = $@"-i {input} -c:v h264 {output}\converted-file.flv";
                        break;

                    default:
                        argument = "";
                        break;
                }

                Tools.Convert(argument);
                Convert_Button.Text = "Convert";
                Convert_Button.Enabled = true;
                if (File.Exists(Output_Box.Text + @"\converted-file." + Format_Choice.Text))
                {
                    MessageBox.Show("Conversion finished!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Info_Button_Click(object sender, EventArgs e)
        {
            InfoWindow Info_Form = new InfoWindow();
            Info_Form.ShowDialog();
        }
    }
}
