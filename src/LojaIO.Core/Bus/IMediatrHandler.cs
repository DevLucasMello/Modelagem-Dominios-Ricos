using LojaIO.Core.Messages;
using System.Threading.Tasks;

namespace LojaIO.Core.Bus
{
    public interface IMediatrHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
    }
}
