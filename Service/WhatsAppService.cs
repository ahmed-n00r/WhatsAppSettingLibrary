using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WhatsAppSettingLibrary.Model;
using WhatsAppSettingLibrary.Setting;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WhatsAppSettingLibrary.Service
{
    public class WhatsAppService : IWhatsAppService
    {
        private readonly WhatsAppSetting setting;

        public WhatsAppService(IOptions<WhatsAppSetting> setting)
        {
            this.setting = setting.Value;
        }

        public async Task<bool> seandMessage(sendModel message)
        {
            using HttpClient clien = new();
            clien.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", setting.ApiToken);

            WhatsAppRequest request = new()
            {
                to = message.phone,
                template = new()
                {
                    name = message.templateName,
                    language = new()
                    {
                        code = message.language
                    }
                }
            };

            HttpResponseMessage response = await clien.PostAsJsonAsync(new Uri(setting.ApiURL), request);

            return response.IsSuccessStatusCode;
        }
    }
}
