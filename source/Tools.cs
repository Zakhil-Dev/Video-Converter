using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Media_Converter
{
    class Tools
    {
        public static void Convert(string argument)
        {
            try
            { 
                Process proc = new Process();
                proc.StartInfo.FileName = @"C:\ffmpeg\ffmpeg.exe";
                proc.StartInfo.Arguments = $"{argument}";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardOutput = true;
                var proces_result = proc.Start();
                proc.WaitForExit();

            }
            catch
            {
                string message = "Required libraries were not found.\nDo you want to download them now?\nDownload size ~300 MB";
                DialogResult result = MessageBox.Show(message, "Libraries not found!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Directory.CreateDirectory(@"C:\ffmpeg");
                    WebClient wc = new WebClient();
                    wc.DownloadFile("https://www.dropbox.com/s/mp5m7mb96fmxki9/ffmpeg.exe?dl=1", @"C:\ffmpeg\ffmpeg.exe");
                    wc.DownloadFile("https://www.dropbox.com/s/4koxw7kjfuidjj9/ffplay.exe?dl=1", @"C:\ffmpeg\ffplay.exe");
                    wc.DownloadFile("https://www.dropbox.com/s/1gzn1sfm23tin9x/ffprobe.exe?dl=1", @"C:\ffmpeg\ffprobe.exe");

                    MessageBox.Show("Downloaded files are located in 'C:/ffmpeg/'", "Download completed!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Process proc = new Process();
                    proc.StartInfo.FileName = @"C:\ffmpeg\ffmpeg.exe";
                    proc.StartInfo.Arguments = $"{argument}";
                    proc.StartInfo.UseShellExecute = false;
                    proc.StartInfo.CreateNoWindow = true;
                    proc.StartInfo.RedirectStandardInput = true;
                    proc.StartInfo.RedirectStandardOutput = true;
                    var proces_result = proc.Start();
                    proc.WaitForExit();
                }
                else
                {
                    ;
                }
            }           
        }
    }
}
