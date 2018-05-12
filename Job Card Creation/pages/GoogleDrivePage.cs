using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Job_Card_Creation.pages;
using Google.Apis.Drive.v3;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;


namespace Job_Card_Creation.pages
{
    public partial class GoogleDrivePage : UserControl
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/drive-dotnet-quickstart.json
        static string[] Scopes = { DriveService.Scope.Drive };
        static string ApplicationName = "POHS_Aakash_Client";
        string FolderID = "";
        string FolderName = "";
        string UpFileFullName = "";
        string UpFileName = "";

        public GoogleDrivePage()
        {
            InitializeComponent();
        }

        private void GoogleDrivePage_Load(object sender, EventArgs e)
        {
            try
            {
                google_folder();
                pictureBox1.BackColor = Color.LightYellow;
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: -" + err.Message);
            }

        }
        public void google_folder()
        {
            try
            {
                UserCredential credential;

                using (var stream =
                    new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
                {
                    string credPath = System.Environment.GetFolderPath(
                        System.Environment.SpecialFolder.Personal);
                    credPath = Path.Combine(credPath, ".credentials/drive-dotnet-quickstart.json");

                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                    Console.WriteLine("Credential file saved to: " + credPath);
                    ConsoleLabel.Text ="Credential file saved to: " + credPath+"\n";
                }

                // Create Drive API service.
                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                // Define parameters of request.
                FilesResource.ListRequest listRequest = service.Files.List();
                listRequest.PageSize = 50;
                listRequest.Fields = "nextPageToken, files(id, name)";

                string pageToken = null;
                
                do
                {
                    var request = service.Files.List();
                    request.Q = "mimeType = 'application/vnd.google-apps.folder' and name = 'POHSv2.0'";
                    request.Spaces = "drive";
                    request.Fields = "nextPageToken, files(id, name)";
                    request.PageToken = pageToken;
                    var result = request.Execute();                    
                    foreach (var file in result.Files)
                    {
                        ConsoleLabel.Text = ConsoleLabel.Text + "getting files here: Name-" + file.Name + "\n ID:-"+file.Id+"\n";
                        FolderID = file.Id;
                        FolderName = file.Name;
                    }
                    ConsoleLabel.Text = ConsoleLabel.Text + "\n\nThe file ID for our folder named "+FolderName+" is:----" + FolderID;

                   pageToken = result.NextPageToken;
                } while (pageToken != null);

                
            }

            catch (Exception err)
            {
                MessageBox.Show("Error: -" + err.Message);
            }
        }      

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Pdf Files | *.pdf";
            openFileDialog1.InitialDirectory= @"G:\RPNP Databases\VISUAL STUDIO\Repositories\POHSv2.0\Job Card Creation\saved_reports";
            openFileDialog1.ShowDialog();
            FileLabel.Text = openFileDialog1.FileName;
            UpFileFullName = openFileDialog1.FileName;
            UpFileName = openFileDialog1.SafeFileName;            
            UploadLabel.Text = "Upload the file '"+UpFileName+"' from the path above to the Google Drive Folder '" + FolderName + "'.";



        }

        private void UploadButton_Click(object sender, EventArgs e)
        {

            try
            {

                UserCredential credential;

                using (var stream =
                    new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
                {
                    string credPath = System.Environment.GetFolderPath(
                        System.Environment.SpecialFolder.Personal);
                    credPath = Path.Combine(credPath, ".credentials/drive-dotnet-quickstart.json");

                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                    Console.WriteLine("Credential file saved to: " + credPath);
                    ConsoleLabel.Text = "Credential file saved to: " + credPath + "\n";
                }

                // Create Drive API service.
                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });


                var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = UpFileName,
                    Parents = new List<string>
    {
        FolderID
    }
                };
                FilesResource.CreateMediaUpload request;
                using (var stream = new System.IO.FileStream(UpFileFullName,
                    System.IO.FileMode.Open))
                {
                    request = service.Files.Create(
                        fileMetadata, stream, "application/pdf");
                    request.Fields = "id";
                    request.Upload();
                }
                var file = request.ResponseBody;
                Console.WriteLine("File ID: " + file.Id);
                UploadLabel.Text = "Uploaded Successfully";
            }
             catch (Exception err)
            {
                MessageBox.Show("Error: -" + err.Message);
            }
        }

        private void CurrentUserLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LogInOutButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (LogInOutButton.Text=="Log Out")
                {
                    string[] filePaths = Directory.GetFiles(@"C:\Users\PHOENIX II\Documents\.credentials\drive-dotnet-quickstart.json");
                    foreach (string filePath in filePaths)
                        System.IO.File.Delete(filePath);
                    LogInOutLabel1.Text = "You have been logged out successfully.";
                    LogInOutButton.Text = "Log In";
                }
                else if(LogInOutButton.Text == "Log In")
                {
                    UserCredential credential;

                    using (var stream =
                        new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
                    {
                        string credPath = System.Environment.GetFolderPath(
                            System.Environment.SpecialFolder.Personal);
                        credPath = Path.Combine(credPath, ".credentials/drive-dotnet-quickstart.json");

                        credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                            GoogleClientSecrets.Load(stream).Secrets,
                            Scopes,
                            "user",
                            CancellationToken.None,
                            new FileDataStore(credPath, true)).Result;
                        Console.WriteLine("Credential file saved to: " + credPath);
                        ConsoleLabel.Text = "Credential file saved to: " + credPath + "\n";
                    }

                    // Create Drive API service.
                    var service = new DriveService(new BaseClientService.Initializer()
                    {
                        HttpClientInitializer = credential,
                        ApplicationName = ApplicationName,
                    });

                    LogInOutButton.Text = "Log Out";
                    LogInOutLabel1.Text= "This will log you out without asking for further confirmation.";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: -" + err.Message);
            }
        }
    }
}
