using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;
using NLog;
using NzbDrone.Common.Disk;
using NzbDrone.Common.Http;
using NzbDrone.Core.Configuration;
using NzbDrone.Core.Parser.Model;
using NzbDrone.Core.RemotePathMappings;

namespace NzbDrone.Core.Download.Clients.Cloud
{
    public class CloudUsenet : UsenetClientBase<CloudUsenetSettings>
    {
        public override string Name => "Cloud Usenet";

        public CloudUsenet(
            IHttpClient httpClient, 
            IConfigService configService, 
            IDiskProvider diskProvider, 
            IRemotePathMappingService remotePathMappingService, 
            IValidateNzbs nzbValidationService, 
            Logger logger) 
            : base(httpClient, configService, diskProvider, remotePathMappingService, nzbValidationService, logger)
        {
        }

        public override IEnumerable<DownloadClientItem> GetItems()
        {
            throw new NotImplementedException();
        }

        public override void RemoveItem(string downloadId, bool deleteData)
        {
            throw new NotImplementedException();
        }

        public override DownloadClientInfo GetStatus()
        {
            throw new NotImplementedException();
        }

        protected override void Test(List<ValidationFailure> failures)
        {
            throw new NotImplementedException();
        }

        protected override string AddFromNzbFile(RemoteEpisode remoteEpisode, string filename, byte[] fileContent)
        {
            throw new NotImplementedException();
        }
    }
}
