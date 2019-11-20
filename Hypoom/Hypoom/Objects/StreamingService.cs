using Hypoom.Objects.Factory;
using Hypoom.Objects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hypoom.Objects
{
    public class StreamingService
    {
        private readonly Dictionary<Services, StreamingServiceFactory> _factories;

        public StreamingService()
        {
            _factories = new Dictionary<Services, StreamingServiceFactory>
            {
                { Services.Deezer, new DeezerFactory() },
                { Services.SoundCloud, new SoundCloudFactory() },
                { Services.Spotify, new SpotifyFactory() },
                { Services.YouTube, new YouTubeFactory() }
            };
        }

        public IStreamingService ExecuteCreation(Services service) => _factories[service].Create();
    }
}