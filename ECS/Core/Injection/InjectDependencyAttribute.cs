﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BB.ECS {
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class InjectDependencyAttribute : Attribute{
    }
}
