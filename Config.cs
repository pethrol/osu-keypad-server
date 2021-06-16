using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace osu_keypad_server {
    public class ConfigData {
        public String ip;
        public Keys a;
        public Keys b;
        public ConfigData() { }
        public ConfigData(String ip, Keys a, Keys b) {
            this.ip = ip;
            this.a = a;
            this.b = b;
        }
    }
    public class Config {
        private static String path = "osu!keypad-server.config";

        private static Config _instance;
        public Config() { }
        public static Config GetInstance() {
            if (_instance == null) {
                _instance = new Config();
            }
            return _instance;
        }

        public ConfigData LoadConfig() {
            var xs = new XmlSerializer(typeof(ConfigData));
            try {
                using (var sr = new StreamReader(path)) {
                    var data = (ConfigData)xs.Deserialize(sr);
                    return data;
                    //MainForm.updateInfoInWindow(data.ip, data.a, data.b);


                }
            }
            catch(Exception) {
                MessageBox.Show("Cannot open config file. Generating one.");
            }
            return new ConfigData("192.168.0.101", Keys.Z, Keys.X);
            
           
        }

        public void SaveConfig(String ip, Keys a, Keys b) {
            ConfigData configData = new ConfigData(ip, a, b);

            var xs = new XmlSerializer(typeof(ConfigData));

            using (var sw = new StreamWriter(path)) {
                xs.Serialize(sw, configData);
            }
        }




    }
}
