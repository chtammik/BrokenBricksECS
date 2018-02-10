using BB.ECS;
using UnityEngine;

namespace Moona.ECS
{
    [DebugSystemGroup("Update")]
    class UpdateSourceSystem : ComponentSystem {

        [InjectDependency]
        private UnityEntityManager entityManager;
        
        [InjectTuple]
        private ComponentArray<SourceComponent> sources;
        public override void OnUpdate()
        {
            float sum = 0;
            for (int i = 0; i < sources.Length; i++)
            {
                if(sources[i].source == null)
                {
                    Debug.LogWarning("source not assigned! " + i);
                    continue;
                }

                sources[i].source.volume = Random.Range(0f, 1f);
                //entityManager.SetComponent(sources.GetEntity(i), new SourceComponent(sources[i].value + 1));
            }
        }
    }
}
