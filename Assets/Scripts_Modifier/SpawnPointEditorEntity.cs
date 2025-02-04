#if UNITY_EDITOR
using UnityEngine;

namespace Arashi.Modifier {

    public class SpawnPointEditorEntity : MonoBehaviour {

        public void Rename() {
            this.gameObject.name = $"SpawnPoint";
        }

        public Vector2 GetPos() {
            return transform.position;
        }

        public Vector2Int GetSizeInt() {
            var size = transform.localScale;
            var sizeInt = size.RoundToVector2Int();
            return sizeInt;
        }

    }

}
#endif