using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppSettingLibrary.Model
{
    public class WhatsAppRequest
    {
        public string messaging_product { get; set; } = "whatsapp";
        public  string to { get; set;}
        public string type { get; set; } = "template";

        public Template template { get; set; }
    }

}
