using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MyLib_Unity.CommonClass
{
    class MyPhysics
    {


        public static void MouseRaycast(Action<RaycastHit> action, Action elseAction = null,
            float maxDistance = Mathf.Infinity, 
            int layerMask = Physics.DefaultRaycastLayers, 
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            if (Physics.Raycast(
                    Camera.main.ScreenPointToRay(Input.mousePosition), 
                    out RaycastHit hit, maxDistance, layerMask, queryTriggerInteraction))
            {
                action(hit);
            }
            else
            {
                elseAction?.Invoke();
            }
        }


    }
}
