using BB.ECS;
using System;
using UnityEngine;

namespace Moona.ECS
{
    [Serializable]
    public struct SourceComponent : IComponent
    {
        public AudioSource source;

        public SourceComponent(GameObjectEntity goe)
        {
            source = goe.gameObject.GetComponent<AudioSource>();

            if (source == null)
                source = goe.gameObject.AddComponent<AudioSource>();
        }
    }

    public class SourceDataComponent : ComponentDataWrapper<SourceComponent> { }

}