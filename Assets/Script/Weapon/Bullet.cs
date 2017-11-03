using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Weapon
{
    public class Bullet : Weapon
    {
        public int speed = 10;
        public int lifeTime = 2;
        private void Start()
        {
            Destroy(gameObject, lifeTime);
        }
        private void Update()
        {
            transform.Translate(transform.forward*speed);
        }
    }
}
