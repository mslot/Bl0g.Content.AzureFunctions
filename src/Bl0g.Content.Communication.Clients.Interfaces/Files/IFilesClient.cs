using Bl0g.Content.Communication.Core.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bl0g.Content.Communication.Clients.Interfaces.Files
{
    public interface IFilesClient
    {
        Task<IEnumerable<FileContent>> GetContentsAync(FilesGetRequest request);
    }
}
