using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppSettingLibrary.Model
{
    public class Template
    {
        public string name { get; set; }
        public Language language { get; set; }
        public List<WhatsAppComponent> components { get; set; }
    }
    
}
