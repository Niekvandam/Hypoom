using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hypoom.Objects.StreamingServices
{
    public class YouTubeService : Interfaces.IStreamingService
    {
        private readonly string _searchTerm;

        public YouTubeService(string searchTerm)
        {
            _searchTerm = searchTerm;
        }

        public Song GetSong()
        {
            throw new NotImplementedException();
        }
    }
}