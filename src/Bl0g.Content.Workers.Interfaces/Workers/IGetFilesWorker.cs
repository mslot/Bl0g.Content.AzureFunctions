using Bl0g.Content.Communication.Core.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bl0g.Content.Workers.Interfaces.Workers
{
    //TODO: Figure out a better name than "GetFiles"
    public interface IGetFilesWorker<TArgument>
    {
        Task<IEnumerable<FileContent>> GetFilesAsync(TArgument argument);
    }
}
