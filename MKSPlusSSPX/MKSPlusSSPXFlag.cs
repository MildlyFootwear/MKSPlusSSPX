using System.Collections.Generic;
using UnityEngine;

namespace MKSPlusSSPX
{
    public class MKSPlusSSPXFlagStripper : PartModule
    {

        private List<MeshRenderer> rendererlist = new List<MeshRenderer>();

        public void Start()
        {
            foreach (Transform t in part.FindModelTransforms("flagTransform"))
            {
                rendererlist.Add(t.GetComponent<MeshRenderer>());
            }
            if (rendererlist != null && rendererlist.Count > 0)
            {
                foreach (MeshRenderer r in rendererlist)
                {
                    r.enabled = false;
                }
            }
        }
    }
}