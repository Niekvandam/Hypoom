using Hypoom.Objects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hypoom.Objects.Factory
{
    public abstract class StreamingServiceFactory
    {
        public abstract IStreamingService Create(string searchTerm);
    }
}