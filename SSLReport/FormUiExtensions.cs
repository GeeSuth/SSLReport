using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSLReport
{
    internal static class FormUiExtensions
    {
        public static void PerformSafely(this Control target, Action action) 
        { 
            if(target.InvokeRequired)
            {
                target.Invoke(action);
            }
            else
            {
                action();
            }
        }


        public static ListViewItem AddWithKey(this ListViewItem itemRow, string key, string value)
        {
            itemRow.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Name = key,
                Text = value,
                Tag = itemRow
            });

            return itemRow;
        }
    }
}
