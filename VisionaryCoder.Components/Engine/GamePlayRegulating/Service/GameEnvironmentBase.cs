namespace vc.Components.Engine.GamePlayRegulating.Service
{
    internal class GameEnvironmentBase
    {
        public Guid GameId { get; init; } = Guid.NewGuid();
        public Guid CurrentPlayer { get; set; } = Guid.NewGuid();
        public Guid[] Players { get; set; } = Array.Empty<Guid>();
    }
}
