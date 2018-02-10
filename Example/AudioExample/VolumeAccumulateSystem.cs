using BB.ECS;

namespace Moona.ECS
{
    [DebugSystemGroup("Volume")]
    class VolumeAccumulateSystem : ComponentSystem
    {

        [InjectTuple]
        ComponentArray<SourceComponent> sources;
        public override void OnUpdate()
        {
            float sum = 0;

            for (int i = 0; i < sources.Length; i++)
            {
                sum += sources[i].source.volume;
            }
        }
    }
}
