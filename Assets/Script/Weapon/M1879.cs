using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Actor;
namespace Weapon
{
    public interface IM1879CtrlHandler
    {
        bool OnShooting();
        void OnReload();
        void OnPressTrigger(float power);
    }
    public class M1879 : Gun, IM1879CtrlHandler
    {
        RevolverController rlc;
        [SerializeField]
        private GameObject gunTrigger;
        [SerializeField]
        private GameObject gunHammer;
        protected new void Start()
        {
            base.Start();
            rlc = GetComponent<RevolverController>();
        }
        #region interface
        public bool OnShooting()
        {
            OnPressTrigger(0);
            if (bulletNumber>0)
            {
                bulletNumber--;
                RayAttack();
                Instantiate(bullet, firePoint.position, Quaternion.identity);
                Instantiate(fireEff, firePoint.position, Quaternion.identity);
                Instantiate(smokeEff, firePoint.position, Quaternion.identity);
                PlayAudio(fireSound);
                return true;
            }
            else
            {
                PlayAudio(noBulletSound);
                return false;
            }
        }
        public void OnReload()
        {
            bulletNumber = maxBulletNumber;
            PlayAudio(reloadSound);
        }
        public void OnPressTrigger(float power)
        {
            gunTrigger.transform.localEulerAngles = new Vector3(power * 15f, 0, 0);
            gunHammer.transform.localEulerAngles = new Vector3(power * -30f, 0, 0);
            PlayAudio(triggerSound);
        }
        #endregion
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                OnShooting();
            }
            if (Input.GetMouseButtonDown(1))
            {
                OnReload();
            }
            
        }
        private bool RayAttack()
        {
            RaycastHit hitInfo ;
            if (Physics.Raycast(firePoint.position,firePoint.forward,out hitInfo))
            {
                IDamageHandler adh = hitInfo.collider.GetComponent<IDamageHandler>();
                if (adh!=null)
                {
                    adh.OnDamage(hitInfo.point, atk);
                    return true;
                }
            }
            return false;
        }
        private void PlayAudio(AudioClip audioClip)
        {
            aud.Stop();
            aud.clip = audioClip;
            aud.Play();
        }
        
    }
}
