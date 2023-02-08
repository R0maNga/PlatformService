using System.Collections.Generic;
using CommandsService.Models;

namespace CommandsService.SyncDataServices.Grpc
{
    public interface IIPlatformDataClient
    {
        IEnumerable<Platform> ReturnAllPlatforms();
    }
}