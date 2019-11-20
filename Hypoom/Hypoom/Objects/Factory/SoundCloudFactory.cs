using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hypoom.Objects.Interfaces;
using Hypoom.Objects.StreamingServices;

namespace Hypoom.Objects.Factory
{
    public class SoundCloudFactory : StreamingServiceFactory
    {
        public override IStreamingService Create(string serachTerm) => new SoundCloudService(searchTerm:);
    }
}