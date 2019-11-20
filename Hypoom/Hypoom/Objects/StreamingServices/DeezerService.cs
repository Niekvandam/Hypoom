using Hypoom.Objects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hypoom.Objects.StreamingServices
{
    public class DeezerService : IStreamingService
    {
        private readonly string _searchTerm; 

        public DeezerService(string searchTerm)
        {
            _searchTerm = searchTerm;
        }

        public void GetSong()
        {
            throw new NotImplementedException();
        }
    }
}