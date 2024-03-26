using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public interface IMessageService
    {
        List<Message> GetMessages();
        Task SendMessageAsync(Message newMessage);
        Task EditMessageAsync(int idMessage, Message newMessage);
        Task DeleteMessageAsync(int idMessage);
        Message? GetMessageById(int idMessage);
    }
}
