using GorillaShirts.Interfaces;
using System;

namespace GorillaShirts.Locations
{
    internal class Forest : IStandLocation
    {
        public GTZone Zone => GTZone.forest;
        public Tuple<UnityEngine.Vector3, UnityEngine.Vector3> Location => Tuple.Create<UnityEngine.Vector3, UnityEngine.Vector3>(new(-63.250f, 2.935f, -60f), new(0f, 184.340f, 0f));
    }
}
