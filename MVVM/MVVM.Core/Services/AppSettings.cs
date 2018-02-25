using Plugin.Settings.Abstractions;

namespace MVVM.Core.Services
{
    public class AppSettings : IAppSettings
    {

        public const int SuperNumberDefaultValue = 1;

        private readonly ISettings _settings;

        public AppSettings(ISettings settings)
        {
            _settings = settings;
        }
        
    }
}
