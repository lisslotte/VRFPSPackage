using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Actor
{
    public abstract class Zombie : Actor
    {
        private float hp = 100f;
        private float seeDistance = 5f;
        private float attackDistance = 1f;
        private float walkSpeed = 1f;
        private float runSpeed = 2f;

        protected GameObject player;

        protected void InitZombie(float hp, float seeDistance, float attackDistance, float walkSpeed, float runSpeed)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            this.hp = hp;
            this.seeDistance = seeDistance;
            this.attackDistance = attackDistance;
            this.walkSpeed = walkSpeed;
            this.runSpeed = runSpeed;
        }
        #region movement
        protected abstract void OnSeekWalk(GameObject obj);
        protected abstract void OnSeekRun(GameObject obj);
        protected abstract void OnAttack(GameObject obj);
        protected abstract void OnWait();
        protected abstract void OnWander(float radius,float delayTime);
        protected abstract void OnDead();
        #endregion
        #region condition
        protected virtual bool CanSeeObject(GameObject obj,float seeAngel)
        {
            if (Vector3.Distance(transform.position,obj.transform.position)<seeDistance)
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
            if (hp<0)
            {
                return true;
            }
            return false;
        }
        #endregion
       
    }
}
