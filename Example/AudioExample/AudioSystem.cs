using BB.ECS;

namespace Moona.ECS {

    public class AudioSystem : ECSController<UnityStandardSystemRoot, UnityEntityManager>
    {
        protected override void Initialize()
        {
            AddSystem<TickSystem>();
            AddSystem<InitEntitiesSystem>();
            AddSystem<VolumeAccumulateSystem>();
            AddSystem<UpdateSourceSystem>();
        }
    }
}
