using UnityEngine;

namespace Arashi {

    public struct RoleInputComponent {

        public Vector2 moveAxis;
        public void Reset() {
            moveAxis = Vector2.zero;
        }

    }

}