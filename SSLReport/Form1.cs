using SSLReport.Properties;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace SSLReport
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            AddUrlToList();
        }

        private async void AddUrlToList()
        {
            if (string.IsNullOrEmpty(txt_Url.Text)) return;

            if (!Uri.IsWellFormedUriString(txt_Url.Text, UriKind.RelativeOrAbsolute)) return;

            if (txt_Url.Text.Contains("http://"))
            {
                MessageBox.Show("This Domain obviusly not have SSL", "Warning", MessageBoxButtons.OKCancel); return;
            }

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
            if (item.Sn is null)
            {
                item.Sn = listUrl.Items.Count + 1;
            }
            ListViewItem itemUrl = new ListViewItem(item.Sn.ToString());



            itemUrl.SubItems.Add("...");

            itemUrl.SubItems.Add(item.Name);
            itemUrl.SubItems.Add(item.Url);



            itemUrl.SubItems.Add(item.IsPublic == true ? "true" : "false");

            var expire_date = item.ExpireDate == null ? "-" : item.ExpireDate.GetValueOrDefault().ToString("yyyy-MM-dd");
            itemUrl.SubItems.Add(expire_date);





            var expireInDaty = item.ExpireInDays == null ? "-" : item.ExpireInDays.ToString();
            itemUrl.SubItems.Add(expireInDaty);


            listUrl.Items.Add(itemUrl);

            return item;
        }

        private ListViewItem AddWithKey(ListViewItem itemRow, string key, string value)
        {
            itemRow.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Name =key,
                Text = value,
                Tag = itemRow
            });

            return itemRow;
        }

        private async Task ScanUrl(ItemDto itemUrl)
        {
            try
            {
                itemUrl.WorkingState = WorkingState.Running;
                UpdateRowInsideList(itemUrl);
                var expireDate = await GetExpireDateForUrl(itemUrl);

                itemUrl.WorkingState = WorkingState.Finish;
                UpdateRowInsideList(itemUrl, expireDate);
            }
            catch
            {
                itemUrl.WorkingState = WorkingState.Failed;
                UpdateRowInsideList(itemUrl);
            }
        }

        private void UpdateRowInsideList(ItemDto item, DateTime? ExpireDate = null)
        {
            int ExpireColumn = 5;
            int ExpireDayColumn = 6;
            int ProcceingColumn = 1;

            int IndexRow = item.Sn.GetValueOrDefault() - 1;

            listUrl.PerformSafely(() =>
            {
                if (item.WorkingState == WorkingState.Failed)
                {
                    listUrl.Items[IndexRow]
                        .SubItems[ExpireColumn].Text = "Failed!";

                    listUrl.Items[IndexRow].ForeColor = Color.Red;
                }
                else if(item.WorkingState == WorkingState.Finish)
                {


                    listUrl.Items[IndexRow]
                        .SubItems[ExpireColumn].Text = ExpireDate.GetValueOrDefault().ToString("yyyy-MM-dd");

                    listUrl.Items[IndexRow]
                        .SubItems[ExpireDayColumn].Text = 
                        (ExpireDate.GetValueOrDefault() - DateTime.Now).TotalDays.ToString("0.00");


                    listUrl.Items[IndexRow].ForeColor = Color.Green;

                }


                    listUrl.Items[IndexRow]
                            .SubItems[ProcceingColumn].Text = item.WorkingState.ToString();



            });




        }

        private void AddToLogs(string message, bool? isError = false, int? ItemSn = 0)
        {
            list_logs.PerformSafely(() =>
            {
                list_logs.Items.Add($"{DateTime.Now.ToString()} => {message}");
            });
        }
        private async Task<DateTime?> GetExpireDateForUrl(ItemDto item)
        {
            try
            {

                //await Task.Delay(5000);

                var Url = $"{item.Url}";
                AddToLogs($"Start Reading {item.Url}");
                using (TcpClient client = new TcpClient())
                {

                    AddToLogs($"Open connecting.. {item.Url}");
                    await client.ConnectAsync(Url, 443);

                    AddToLogs($"Successful Open Connect with: {item.Url}");

                    using (SslStream sslStream = new SslStream(client.GetStream(), false,
                        new RemoteCertificateValidationCallback((sender, certificate, chain, sslPolicyErrors) => true), null))
                    {

                        AddToLogs($"Trying reading SSL: {item.Url}");

                        sslStream.AuthenticateAsClient(Url);
                        X509Certificate2 certificate = new X509Certificate2(sslStream.RemoteCertificate);
                        AddToLogs($"Finish Reading {item.Name}");
                        return certificate.NotAfter;
                    }
                }
            }
            catch (Exception ex)
            {
                AddToLogs(ex.Message, true, item.Sn);
                throw;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(listUrl.Items.Count >= 1)
            {
                AddToLogs("Saving..");
                var ReadingAllItemInList = GetAllItemInList();
            }
        }


        

        private List<ItemDto> GetAllItemInList()
        {
            List<ItemDto> dtList = new List<ItemDto>();

            foreach (ListViewItem item in listUrl.Items)
            {
                dtList.Add(new ItemDto()
                {
                     Sn = int.Parse(item.Text),
                     Name = item.SubItems[1].Text
                });
            }

            return dtList;
        }
    }
}
