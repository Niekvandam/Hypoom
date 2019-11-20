using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Hypoom.Objects.StreamingServices

{
    public class SpotifyService : Interfaces.IStreamingService
    {
        private string apiKey;

        private readonly string _searchTerm;
        public SpotifyService(string searchTerm)
        {
            _searchTerm = searchTerm;
        }

        public Song GetSong()
        {
            Debug.WriteLine("executing the spotify api");
        }
    }
}