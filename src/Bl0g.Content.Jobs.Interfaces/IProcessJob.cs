using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bl0g.Content.Jobs.Interfaces
{
    public interface IProcessJob<TProcessArgument1>
    {
        Task StartAsync(TProcessArgument1 argument);
    }
}
