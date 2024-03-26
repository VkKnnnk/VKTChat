using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public interface IBotService
    {
        Task<Message> RespondToMessageAsync(Bot bot, Message message);
    }
}
