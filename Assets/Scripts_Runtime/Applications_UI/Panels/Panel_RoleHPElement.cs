using System;
using UnityEngine;
using UnityEngine.UI;
using TenonKit.Loom;

namespace Arashi.UI {

    public class Panel_RoleHPElement : MonoBehaviour {

        [SerializeField] Image hp;
        [SerializeField] Animator anim;

        public void Anim_PlayHurt() {
            anim.Play("Hurt");
        }

    }

}