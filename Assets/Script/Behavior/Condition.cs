using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Behavior {
    public class Condition : MonoBehaviour
    {

        protected virtual bool CanSeeObject(GameObject obj, float seeAngel,float seeDistance)
        {
            if (Vector3.Distance(transform.position, obj.transform.position) < seeDistance)
            {
                return true;
            }
            return false;
        }
        protected virtual bool CanAttackObject(GameObject obj,float attackDistance)
        {
            if (Vector3.Distance(transform.position, obj.transform.position) < attackDistance)
            {
                return true;
            }
            return false;
        }
    }
}
