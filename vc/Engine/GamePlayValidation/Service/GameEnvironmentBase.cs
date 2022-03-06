using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vc.Engine.GamePlayValidation.Service
{
    internal class GameEnvironmentBase
    {
        public Guid GameId { get; init; } = Guid.NewGuid();
        public Guid CurrentPlayer { get; set; } = Guid.NewGuid();
        public Guid[] Players { get; set; } = Array.Empty<Guid>();
    }
}
