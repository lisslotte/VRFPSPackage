using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Actor
{
    public interface IDamageHandler
    {
        void OnDamage(Vector3 hitPoint,int atk);
    }
    public abstract class Actor : MonoBehaviour,IDamageHandler
    {
        public abstract void OnDamage(Vector3 hitPoint,int atk);
        protected GameObject player;
        private void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
    }
}
