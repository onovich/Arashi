using System;
using System.Threading.Tasks;
using TenonKit.Prism;
using UnityEngine;

namespace Arashi {

    public class VFXParticelAppContext {

        // Core
        public VFXParticelCore vfxParticelCore;

        public VFXParticelAppContext(string label, Transform root) {
            vfxParticelCore = new VFXParticelCore(label, root);
        }

    }

}