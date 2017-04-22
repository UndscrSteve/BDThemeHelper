using System;
using System.IO;
using System.Windows.Forms;
using System.Net;

namespace DiscordThemeHelper
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            helperLink.Links.Add(0, 23, "https://github.com/UndscrSteve/BDThemeHelper");
        }

        private void helperButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter a valid link. Example is https://i.imgur.com/jPxzN8n.png . Needs to be an direct imgur image link and needs to start with https://");
        }

        private void helperButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter your Windows Username. This is needed so the program can access your Documents folder, so the theme can be downloaded into there. Example would be: C:/Users/YOURNAME");
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            string pathUsrName = pathBox.Text;
            string imageUrl = linkBox.Text;
            string colorCode = clrCodeBox.Text;
            string themeName = nameBox.Text;
            string path = "C:/Users/" + pathUsrName + "/Documents/BDThemeHelper/";
            string filePath = "C:/Users/" + pathUsrName + "/Documents/BDThemeHelper/my_theme.theme.css";

            if (linkBox.Text != "" && pathBox.Text != "")
            {              
                    try
                    {
                        if (Directory.Exists(path))
                        {
                            return;
                        }
                        else
                        {
                            Directory.CreateDirectory(path);
                        }

                        using (WebClient webClient = new WebClient())
                        {
                            webClient.DownloadFile("https://puu.sh/vrQO0/6c96d0d247.css", @"C:/Users/" + pathUsrName + "/Documents/BDThemeHelper/my_theme.theme.css");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Process failed. Please clean up first (use the 'clean up' button) before you try to create another theme.");
                    }

                    if(clrCodeBox.Text != "")
                    {
                        string clrReplacer = File.ReadAllText(filePath);
                        clrReplacer = clrReplacer.Replace("#EB5A00", colorCode);
                        File.WriteAllText(filePath, clrReplacer);
                    }
                    else
                    {
                    }

                    if(nameBox.Text != "")
                    {
                        string nameReplacer = File.ReadAllText(filePath);
                        nameReplacer = nameReplacer.Replace("Sample_Theme", themeName);
                        File.WriteAllText(filePath, nameReplacer);
                    }
                    else
                    {
                    }

                    string replacer = File.ReadAllText(filePath);
                    replacer = replacer.Replace("LINKHERE", imageUrl);
                    File.WriteAllText(filePath, replacer);
                    
                    MessageBox.Show("Done! You can find your theme in C:/Users/YOURNAME/Documents/BDThemeHelper. Thanks for using this tool!");
            }
            else
            {
                MessageBox.Show("Please enter something into the fields!");
            }
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            string pathUsrName = pathBox.Text;
            string imageUrl = linkBox.Text;
            string filePath = "C:/Users/" + pathUsrName + "/Documents/BDThemeHelper/my_theme.theme.css";
            string path = "C:/Users/" + pathUsrName + "/Documents/BDThemeHelper/";

            if (Directory.Exists(path))
            {
                File.Delete(filePath);
                Directory.Delete(path);
                MessageBox.Show("Cleaned up! You can create a new theme now!");
            }
            else
            {
                MessageBox.Show("Nothing to clean up! Please create a theme first!");
            }
        }

        private void helperButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you want your theme to fit color-wise with the background, use a Hexadecimal color code. You can find those on sites like colorpicker.com . Please enter them WITH the #, else it won't work! If you dont need a special color, leave this field empty!");
        }

        private void helperLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            helperLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/UndscrSteve/BDThemeHelper");
        }
    }
}
