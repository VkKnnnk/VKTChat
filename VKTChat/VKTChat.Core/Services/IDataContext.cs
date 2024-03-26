namespace VKTChat.Core.Services
{
    public interface IDataContext
    {
        void SetContext(object currentData);
        object? GetCurrentData();
    }
}
