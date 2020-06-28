using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NzbDrone.Core.ThingiProvider;
using NzbDrone.Core.Validation;

namespace NzbDrone.Core.Download.Clients.Cloud
{
    public class CloudTorrentSettingsValidator : AbstractValidator<CloudTorrentSettings>
    {
    }

    public class CloudTorrentSettings : IProviderConfig
    {
        private static readonly CloudTorrentSettingsValidator Validator = new CloudTorrentSettingsValidator();

        public NzbDroneValidationResult Validate()
        {
            return new NzbDroneValidationResult(Validator.Validate(this));
        }
    }
}
