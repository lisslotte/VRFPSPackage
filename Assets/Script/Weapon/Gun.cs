using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Weapon {
    public class Gun : Weapon
    {
        [SerializeField]
        protected int maxBulletNumber = 0;

        [SerializeField]
        protected Transform firePoint;
        [SerializeField]
        protected Object bullet;
        [SerializeField]
        protected Object fireEff;
        [SerializeField]
        protected Object smokeEff;

        [SerializeField]
        protected AudioClip fireSound;
        [SerializeField]
        protected AudioClip reloadSound;
        [SerializeField]
        protected AudioClip noBulletSound;
        [SerializeField]
        protected AudioClip triggerSound;

        protected AudioSource aud;
        private void Awake()
        {
            aud = GetComponent<AudioSource>();
        }
        protected int bulletNumber = 0;
        protected void Start()
        {
            bulletNumber = maxBulletNumber;
        }
    }
}
