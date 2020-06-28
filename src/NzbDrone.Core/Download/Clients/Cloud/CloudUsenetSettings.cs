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
    public class CloudUsenetSettingsValidator : AbstractValidator<CloudUsenetSettings>
    {
    }

    public class CloudUsenetSettings : IProviderConfig
    {
        private static readonly CloudUsenetSettingsValidator Validator = new CloudUsenetSettingsValidator();

        public NzbDroneValidationResult Validate()
        {
            return new NzbDroneValidationResult(Validator.Validate(this));
        }
    }
}
