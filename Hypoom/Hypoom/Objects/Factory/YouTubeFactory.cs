using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hypoom.Objects.Interfaces;
using Hypoom.Objects.StreamingServices;

namespace Hypoom.Objects.Factory
{
    public class YouTubeFactory : StreamingServiceFactory
    {
        public override IStreamingService Create(string searchTerm) => new YouTubeService(searchTerm);
    }
}