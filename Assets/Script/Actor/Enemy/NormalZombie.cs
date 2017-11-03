using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
namespace Actor {
    public class NormalZombie : Zombie
    {
        NavMeshAgent nav;
        Animator ani;
        private float timer = 0;
        private void Awake()
        {
            ani = GetComponent<Animator>();
            nav = GetComponent<NavMeshAgent>();
        }
        private void Start()
        {
            InitZombie(100f, 5f, 1f, 1f, 2f);
        }
        private void Update()
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
                return;
            }
            if (!IsDead())
            {
                if (CanSeeObject(player, 180))
                {
                    if (CanAttackObject(player))
                    {
                        OnAttack(player);
                    }
                    else
                    {
                        int r = Random.Range(0, 3);
                        if (r == 0)
                        {
                            OnSeekRun(player);
                        }
                        else
                        {
                            OnSeekWalk(player);
                        }
                    }
                }
                else
                {
                    OnWait();
                }
            }
            else
            {
                OnDead();
            }
        }
        #region interface
        protected override void OnSeekWalk(GameObject obj)
        {

        }
        protected override void OnSeekRun(GameObject obj)
        {

        }
        protected override void OnAttack(GameObject obj)
        {

        }
        protected override void OnWait()
        {

        }
        protected override void OnWander(float radius, float delayTime)
        {

        }
        protected override void OnDead()
        {

        }
        #endregion
        public override void OnDamage(Vector3 hitPoint, int atk)
        {
        }
    }
}
