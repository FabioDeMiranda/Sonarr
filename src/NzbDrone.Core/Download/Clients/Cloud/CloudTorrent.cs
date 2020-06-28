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
using NzbDrone.Core.MediaFiles.TorrentInfo;
using NzbDrone.Core.Parser.Model;
using NzbDrone.Core.RemotePathMappings;

namespace NzbDrone.Core.Download.Clients.Cloud
{
    public class CloudTorrent : TorrentClientBase<CloudTorrentSettings>
    {
        public override string Name => "Cloud Torrent";

        public CloudTorrent(
            ITorrentFileInfoReader torrentFileInfoReader, 
            IHttpClient httpClient, 
            IConfigService configService, 
            IDiskProvider diskProvider, 
            IRemotePathMappingService remotePathMappingService, 
            Logger logger) 
            : base(torrentFileInfoReader, httpClient, configService, diskProvider, remotePathMappingService, logger)
        {
        }

        public override IEnumerable<DownloadClientItem> GetItems()
        {
            return new List<DownloadClientItem>();
        }

        public override void RemoveItem(string downloadId, bool deleteData)
        {
        }

        public override DownloadClientInfo GetStatus()
        {
            return new DownloadClientInfo();
        }

        protected override void Test(List<ValidationFailure> failures)
        {
        }

        protected override string AddFromMagnetLink(RemoteEpisode remoteEpisode, string hash, string magnetLink)
        {
            return null;
        }

        protected override string AddFromTorrentFile(RemoteEpisode remoteEpisode, string hash, string filename, byte[] fileContent)
        {
            return null;
        }
    }
}
