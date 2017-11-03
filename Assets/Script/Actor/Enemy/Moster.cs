using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Actor
{
    public abstract class Moster : Actor
    {
        [SerializeField]
        private float hp = 0;
        [SerializeField]
        private float seeDistance = 0;
        [SerializeField]
        private float seeAngel = 0;
        [SerializeField]
        private float attackDistance = 0;
        [SerializeField]
        private float walkSpeed = 0;
        [SerializeField]
        private float runSpeed = 0;
        
        #region movement
        protected abstract void OnSeekWalk(GameObject obj);
        protected abstract void OnSeekRun(GameObject obj);
        protected abstract void OnAttack(GameObject obj);
        protected abstract void OnWait();
        protected abstract void OnWander(float radius, float delayTime);
        protected abstract void OnDead();
        #endregion
        #region condition
        protected virtual bool CanSeeObject(GameObject obj, float seeAngel)
        {
            if (Vector3.Distance(transform.position, obj.transform.position) < seeDistance)
            {
                return true;
            }
            return false;
        }
        protected virtual bool CanAttackObject(GameObject obj)
        {
            if (Vector3.Distance(transform.position, obj.transform.position) < attackDistance)
            {
                return true;
            }
            return false;
        }
        protected virtual bool IsDead()
        {
            if (hp < 0)
            {
                return true;
            }
            return false;
        }
        #endregion
        #region interface
        public override void OnDamage(Vector3 hitPoint, int atk)
        {

        }
        #endregion

    }
}
