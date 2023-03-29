using System;
using Microsoft.Extensions.Configuration;

namespace gsdc
{
    public class AppConfiguration
    {
        public string Value1{ get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }

        private static AppConfiguration _theConfiguration;

        public static AppConfiguration GetConfiguration()
        {
            if (_theConfiguration != null) return _theConfiguration;

            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json").Build();

            var section = config.GetSection(nameof(AppConfiguration));
            _theConfiguration = section.Get<AppConfiguration>();

            return _theConfiguration;
        }
    }
}