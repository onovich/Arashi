using System;
using UnityEngine;
using UnityEngine.UI;
using TenonKit.Loom;
using MortiseFrame.Swing;

namespace Arashi.UI {

    public class Panel_Login : MonoBehaviour, IPanel {

        [SerializeField] Button startGameBtn;
        [SerializeField] Button exitGameBtn;

        public Action OnClickStartGameHandle;
        public Action OnClickExitGameHandle;

        public void Ctor() {
            startGameBtn.onClick.AddListener(() => {
                OnClickStartGameHandle?.Invoke();
            });

            exitGameBtn.onClick.AddListener(() => {
                OnClickExitGameHandle?.Invoke();
            });
        }

        void OnDestroy() {
            startGameBtn.onClick.RemoveAllListeners();
            exitGameBtn.onClick.RemoveAllListeners();
            OnClickStartGameHandle = null;
            OnClickExitGameHandle = null;
        }

    }

}