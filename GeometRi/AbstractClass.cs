﻿using System;
using static System.Math;
using System.Collections.Generic;

namespace GeometRi
{

#if NET20
    [Serializable]
#endif
    abstract public class FiniteObject
    {
        abstract internal int _PointLocation(Point3d p);
    }
    abstract public class PlanarFiniteObject : FiniteObject
    {
        abstract internal Plane3d Plane { get; }
    }
}
