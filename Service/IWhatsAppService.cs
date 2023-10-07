using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsAppSettingLibrary.Model;

namespace WhatsAppSettingLibrary.Service
{
    public interface IWhatsAppService
    {
        Task<bool> seandMessage(sendModel message);
    }
}
