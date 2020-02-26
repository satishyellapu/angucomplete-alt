using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace LeftOverFeast.iOS
{
    class Constants
    {
        // Azure app-specific connection string and hub path
        public const string ListenConnectionString = "Endpoint=sb://foodstorage.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey=szCXC6qVxbh56IAKpRe8n1PqKHUtEkEfxYPKjJtDiwI=";
        public const string NotificationHubName = "FoodStorageHub";
    }
}