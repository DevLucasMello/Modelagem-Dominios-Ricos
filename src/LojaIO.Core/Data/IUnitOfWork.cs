using System.Threading.Tasks;

namespace LojaIO.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
