using BB.ECS;

namespace BB.ECSExample.GameObjectExample {
    public class Main : ECSController<UnityStandardSystemRoot, UnityEntityManager> {
        // Use this for initialization
        protected override void Initialize() {
            AddSystem<RotateObjectSystem>();
        }
    }
}
