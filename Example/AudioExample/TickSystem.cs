using BB.ECS;

namespace Moona.ECS
{
    [DebugSystemGroup("Volume")]
    class TickSystem : ComponentSystem
    {
        public int Tick = -1;

        public override void OnUpdate()
        {
            Tick += 1;
        }
    }
}