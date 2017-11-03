using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Behavior {
    public abstract class Movement : MonoBehaviour {
        protected abstract void OnSeekWalk(GameObject obj);
        protected abstract void OnSeekRun(GameObject obj);
        protected abstract void OnAttack(GameObject obj);
        protected abstract void OnWait();
        protected abstract void OnWander(float radius, float delayTime);
        protected abstract void OnDead();
        protected abstract void OnDamage();
    }
}
