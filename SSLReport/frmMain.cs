using SSLReport.Properties;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace SSLReport
{
    public partial class frmMain : Form
    {

        string jsonPath = Application.StartupPath + "\\db.json";
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            TryReadDbFile();
        }

        private void TryReadDbFile()
        {
            try
            {
                var dbContent = JsonSerializer.Deserialize<List<ItemDto>>(File.ReadAllText(jsonPath));
                if (dbContent?.Count >= 1)
                {
                    foreach (var item in dbContent)
                    {
                        AddUrlToList(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            AddUrlToList();
        }

        private async void AddUrlToList()
        {
            if (string.IsNullOrEmpty(txt_Url.Text)) return;

            if (!Regex.IsMatch(txt_Url.Text, @"^[a-zA-Z0-9-]+\.[a-zA-Z]{2,}$")) return;



            string Url = txt_Url.Text.Replace("https://", "");

            var Urlitem = AddUrlToList(new ItemDto()
            {
                Url = Url,
                Name = txt_Name.Text,
                IsPublic = checkBox_isPublic.Checked,
                ForceWay = check_forceWay.Checked

            });


            await ScanUrl(Urlitem);

        }

        private ItemDto AddUrlToList(ItemDto item)
        {
            item.Index = listUrl.Items.Count;
            ListViewItem itemUrl = new ListViewItem(item.Index.GetValueOrDefault().ToString());

            itemUrl.AddWithKey("colum_working", "...");

            //itemUrl.SubItems.Add("...");

            itemUrl.AddWithKey("colum_name", item.Name);
            itemUrl.AddWithKey("colum_url", item.Url);



            itemUrl.AddWithKey("colum_isPublic", item.IsPublic == true ? "true" : "false");

            var expire_date = item.ExpireDate == null ? "-" : item.ExpireDate.GetValueOrDefault().ToString("yyyy-MM-dd");
            itemUrl.AddWithKey("colum_expireDate", expire_date);





            var expireInDaty = item.ExpireInDays == null ? "-" : item.ExpireInDays.GetValueOrDefault().ToString("0.00");
            itemUrl.AddWithKey("colum_expireInDay", expireInDaty);


            itemUrl.Tag = item;
            listUrl.Items.Add(itemUrl);

            return item;
        }



        private async Task ScanUrl(ItemDto itemUrl)
        {
            try
            {
                itemUrl.WorkingState = WorkingState.Running;
                UpdateRowInsideList(itemUrl);
                var cert = await GetExpireDateForUrl(itemUrl);

                itemUrl.WorkingState = WorkingState.Finish;
                UpdateRowInsideList(itemUrl);
            }
            catch
            {
                itemUrl.WorkingState = WorkingState.Failed;
                UpdateRowInsideList(itemUrl);
            }
        }

        private void UpdateRowInsideList(ItemDto item)
        {

            int IndexRow = item.Index.GetValueOrDefault();

            listUrl.PerformSafely(() =>
            {
                if (item.WorkingState == WorkingState.Failed)
                {
                    listUrl.Items[IndexRow]
                        .SubItems["colum_expireDate"]!.Text = "Failed!";

                    listUrl.Items[IndexRow].ForeColor = Color.Red;
                }
                else if (item.WorkingState == WorkingState.Finish)
                {


                    listUrl.Items[IndexRow]
                        .SubItems["colum_expireDate"]!.Text = item.ExpireDate.GetValueOrDefault().ToString("yyyy-MM-dd");

                    listUrl.Items[IndexRow]
                        .SubItems["colum_expireInDay"]!.Text = item.ExpireInDays.GetValueOrDefault().ToString("0.00");


                    listUrl.Items[IndexRow].ForeColor = Color.Green;

                }


                listUrl.Items[IndexRow]
                        .SubItems["colum_working"]!.Text = item.WorkingState.ToString();


                listUrl.Items[IndexRow].Tag = item;



            });




        }

        private void AddToLogs(string message, bool? isError = false, int? ItemSn = 0)
        {
            list_logs.PerformSafely(() =>
            {
                list_logs.Items.Add($"{DateTime.Now.ToString()} => {message}");
            });
        }
        private async Task<ItemDto> GetExpireDateForUrl(ItemDto item)
        {
            try
            {

                //await Task.Delay(5000);

                var Url = $"{item.Url}";
                AddToLogs($"Start Reading {item.Url}");
                using (TcpClient client = new TcpClient())
                {

                    if(item.ForceWay) client.NoDelay = true;

                    AddToLogs($"Open connecting.. {item.Url}");
                    await client.ConnectAsync(Url, 443);

                    AddToLogs($"Successful Open Connect with: {item.Url}");

                    using (SslStream sslStream = new SslStream(client.GetStream(), false,
                        new RemoteCertificateValidationCallback((sender, certificate, chain, sslPolicyErrors) => true), null))
                    {

                        AddToLogs($"Trying reading SSL: {item.Url}");

                        if (item.ForceWay)
                        {
                            sslStream.AuthenticateAsClient(Url, null, 
                                System.Security.Authentication.SslProtocols.Tls12,
                                checkCertificateRevocation: false
                            );
                        }
                        else
                        {
                            sslStream.AuthenticateAsClient(Url);
                        }
                       

                        X509Certificate2 certificate = new X509Certificate2(sslStream.RemoteCertificate!);
                        AddToLogs($"Finish Reading {item.Name} Expire @ {certificate.NotAfter}");
                        item.ExpireDate = certificate.NotAfter;
                        item.AlternativeNames = GetSubjectAlternativeNames(certificate);
                        return item;
                    }
                }
            }
            catch (Exception ex)
            {
                AddToLogs(ex.Message, true, item.Index);
                throw;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            AddToLogs("Saving..");
            var ReadingAllItemInList = GetAllItemInList();
            File.WriteAllText(jsonPath,
                JsonSerializer.Serialize(ReadingAllItemInList));

        }




        private List<ItemDto> GetAllItemInList()
        {
            List<ItemDto> dtList = new List<ItemDto>();

            foreach (ListViewItem item in listUrl.Items)
            {

                dtList.Add((ItemDto)item.Tag!);
            }

            return dtList;
        }

        private ItemDto GetSelectRow(int Index)
        {
            var Row = listUrl.Items[Index];

            return new ItemDto()
            {
                Index = int.Parse(Row.Text),
                Name = Row.SubItems["colum_name"]!.Text,
                Url = Row.SubItems["colum_url"]!.Text,
                IsPublic = bool.Parse(Row.SubItems["colum_isPublic"]!.Text)

            };
        }

        private async void toolStrip_UpdateOnce_Click(object sender, EventArgs e)
        {
            if (listUrl.SelectedItems.Count >= 1)
            {
                int index = listUrl.SelectedItems[0].Index;
                await ScanUrl(GetSelectRow(index));
            }
        }

        private void toolStrip_RemoveAll_Click(object sender, EventArgs e)
        {
            listUrl.Items.Clear();
        }

        private async void toolStrip_UpdateAll_Click(object sender, EventArgs e)
        {
            if (listUrl.Items.Count == 0) return;

            foreach (ListViewItem item in listUrl.Items)
            {
                await ScanUrl((ItemDto)item.Tag!);
            }
        }

        private void toolStrip_RemoveOnce_Click(object sender, EventArgs e)
        {
            if (listUrl.SelectedItems.Count >= 1)
            {
                int index = listUrl.SelectedItems[0].Index;
                listUrl.Items[index].Remove();
            }
        }

        private void openInBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listUrl.SelectedItems.Count >= 1)
            {
                int index = listUrl.SelectedItems[0].Index;
                var url = listUrl.Items[index].SubItems["colum_url"]!.Text;

                url = url.Replace("https://", "");
                Openit("https://" + url);

            }
        }


        public static void Openit(string x)
        {
            System.Diagnostics.Process.Start("cmd", "/C start" + " " + x);
        }

        private void toolStrip_ViewOnce_Click(object sender, EventArgs e)
        {
            if (listUrl.SelectedItems.Count >= 1)
            {
                int index = listUrl.SelectedItems[0].Index;
                var alternative = (ItemDto)listUrl.Items[index]!.Tag;

                MessageBox.Show("Alternative Names: " + string.Join(Environment.NewLine,
                    alternative!.AlternativeNames!),
                    "Alternative Names",
                    MessageBoxButtons.OK);
            }
        }


        static List<string> GetSubjectAlternativeNames(X509Certificate2 certificate)
        {
            List<string> alternativeNames = new List<string>();

            foreach (var extension in certificate.Extensions)
            {
                if (extension is X509Extension && extension.Oid!.Value == "2.5.29.17") // OID for Subject Alternative Name
                {
                    AsnEncodedData asnData = new AsnEncodedData(extension.Oid, extension.RawData);
                    string[] entries = asnData.Format(true).Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string entry in entries)
                    {
                        if (entry.Trim().StartsWith("DNS Name="))
                        {
                            alternativeNames.Add(entry.Replace("DNS Name=", "").Trim());
                        }
                    }
                }
            }

            return alternativeNames;
        }

        private void txt_Url_Leave(object sender, EventArgs e)
        {
            txt_Name.Text = txt_Url.Text;
        }
    }
}
