
namespace _07RawData
{
    class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
        }

        public int EngineSpeed { get; private set; }

        public int EnginePower { get; private set; }
    }
}
