using UnityEngine;

namespace GorillaShirts.Models.Locations
{
    internal class ForestLocation : IStandLocation
    {
        public GTZone[] Zones => [GTZone.forest, GTZone.cityWithSkyJungle];
        public Vector3 Position => new(-63.250f, 2.935f, -60f);
        public Vector3 EulerAngles => Vector3.up * 184.340f;
    }
}
