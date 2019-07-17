using System;
namespace DiggersAndFliers
{
    public class Ant : IDigable
    {
        public int MaximumDepth { get; } = 100;
        public void Dig()
        {
            System.Console.WriteLine("Im an ant and im diggin' so good.");
        }
    }
}