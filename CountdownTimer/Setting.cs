using CountdownTimer.Tools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountdownTimer
{
    public class Setting
    {
        private const string FILE_PATH = "Setting.txt";

        public string Version { get { return "v1.0.2"; } }
        public AuthResizeFormTool.FormInfo FormTool { get; set; }
        public string Hour { get; set; }
        public string Minute { get; set; }
        public string Second { get; set; }
        public DateTime CheckedDailyTask { get; set; }

        public static Setting GetSetting()
        {
            if (File.Exists(FILE_PATH))
            {
                var settingJson = File.ReadAllText(FILE_PATH);

                try
                {
                    return JsonConvert.DeserializeObject<Setting>(settingJson);
                }
                catch { }
            }

            return new Setting();
        }

        internal void Save()
        {
            File.WriteAllText(FILE_PATH, JsonConvert.SerializeObject(this));
        }
    }
}
