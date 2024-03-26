using Newtonsoft.Json;
using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public class AppdataService : IAppdataService
    {
        #region Constants
        private const string FileName = "data.json";
        private const string FileDirectory = "appdata";
        #endregion
        #region Properties
        private readonly object _lockObject = new object();
        private List<User> _data = new List<User>();
        #endregion
        #region Methods
        private async Task LoadDataAsync()
        {
            try
            {
                var filePath = Path.Combine(FileDirectory, FileName);
                if (!File.Exists(filePath))
                {
                    _data = new List<User>();
                    return;
                }

                using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (var sr = new StreamReader(fs))
                using (var jsonReader = new JsonTextReader(sr))
                {
                    var serializer = new JsonSerializer();
                    List<User>? data = serializer.Deserialize<List<User>>(jsonReader);
                    lock (_lockObject)
                    {
                        _data = data ?? new List<User>();
                    }
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок чтения файла JSON
                lock (_lockObject)
                {
                    _data = new List<User>();
                }
            }
        }
        public async Task<List<User>> GetDataAsync()
        {
            await LoadDataAsync();
            lock (_lockObject)
            {
                return new List<User>(_data);
            }
        }
        public async Task SaveDataAsync()
        {
            lock (_lockObject)
            {
                var json = JsonConvert.SerializeObject(_data);
                File.WriteAllText(Path.Combine(FileDirectory, FileName), json);
            }
        }
        #endregion
    }
}
