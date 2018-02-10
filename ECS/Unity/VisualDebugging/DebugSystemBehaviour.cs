using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BB.ECS.VisualDebugging {
    public class DebugSystemBehaviour : MonoBehaviour {
        public DebugSystems system { get { return _system; } }
        private DebugSystems _system;

        internal void Init(DebugSystems debugSystem) {
            _system = debugSystem;
        }
    }
}
