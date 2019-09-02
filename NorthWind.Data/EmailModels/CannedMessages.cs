using System;
using System.Collections.Generic;

namespace NorthWind.Data.EmailModels
{
    public partial class CannedMessages
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string MailSubject { get; set; }
        public string HtmlMessage { get; set; }
        public string TextMessage { get; set; }
    }
}
