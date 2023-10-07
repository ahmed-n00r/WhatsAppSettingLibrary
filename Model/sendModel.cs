using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppSettingLibrary.Model
{
    public class sendModel
    {
        public string phone { get; set; }
        public string language { get; set; }
        public string templateName { get; set; }
        public List<WhatsAppComponent>? components { get; set; }
    }
}
