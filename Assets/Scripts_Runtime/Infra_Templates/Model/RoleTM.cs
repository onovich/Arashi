using System;
using UnityEngine;

namespace Arashi {

    [CreateAssetMenu(fileName = "TM_Role", menuName = "Arashi/RoleTM")]
    public class RoleTM : ScriptableObject {

        [Header("Role Info")]
        public int typeID;
        public string typeName;
        public AllyStatus allyStatus;

        [Header("Role Attributes")]
        public float attackDistance;
        public int hpMax;
        public float speed;

        [Header("Role Render")]
        public RoleMod mod;
        public GameObject deadVFX;
        public float deadVFXDuration;
    }

}