using Exiled.API.Interfaces;

namespace SCP8585
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; }
        public int Scp8585Health { get; set; } = 300;
        public string Scp8585Code { get; set; } = "SCP-8585";
        public float Scp8585SpeedMultiplier { get; set; } = 1.2f;
    }
}