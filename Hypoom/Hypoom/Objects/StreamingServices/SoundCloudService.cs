using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hypoom.Objects.StreamingServices
{
    public class SoundCloudService : Interfaces.IStreamingService
    {
        public SoundCloudService(string searchTerm)
        {
            _searchTerm = searchTerm;
        }

        public Song GetSong()
        {
            throw new NotImplementedException();
        }
    }
}