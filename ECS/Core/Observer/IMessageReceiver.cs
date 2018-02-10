using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BB.ECS {
    public interface IMessageReceiver {
        void Notify();
    }

    public interface IMessageReceiver<TMessage> {
        void Notify(TMessage message);
    }
}
