using System;
using Bl0g.Content.Communication.Core.Shared;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Bl0g.Content.AzureFunctions
{
    public class Functions
    {
        private readonly IHostingEnvironment _env;
        private readonly IOptions<HostingOptions> _options;

        public Functions(IHostingEnvironment env, IOptions<HostingOptions> options)
        {
            _env = env;
            _options = options;
        }

        [FunctionName("CommitTrigger")]
        public void CommitTrigger(
            [QueueTrigger("commit-queue")] FilesGetRequest filesGetRequest,
            ILogger log)
        {

        }
    }
}
