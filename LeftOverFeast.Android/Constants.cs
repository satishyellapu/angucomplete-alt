using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace LeftOverFeast.Droid
{
    public static class Constants
    {
        public const string ListenConnectionString = "Endpoint=sb://foodstorage.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey=szCXC6qVxbh56IAKpRe8n1PqKHUtEkEfxYPKjJtDiwI=";
        public const string NotificationHubName = "FoodStorageHub";
    }
}