using System;
using MortiseFrame.Swing;
using UnityEngine;

namespace Arashi {

    [CreateAssetMenu(fileName = "TM_GameConfig", menuName = "Arashi/GameConfig")]
    public class GameConfig : ScriptableObject {

        // Game
        [Header("Game Config")]
        public float gameResetEnterTime;

        // Role
        [Header("Role Config")]
        public int ownerRoleTypeID;

        // Map
        [Header("Map Config")]
        public int originalMapTypeID;
        public Material gridMat;
        public Color gridColor;
        public float gridThickness;

        [Header("Obstacle Config")]
        public Material obstacleMat;
        public Color obstacleColor;

        [Header("Path Config")]
        public Material pathMat;
        public Color pathColor;
        public float pathThickness;

        // Camera
        [Header("DeadZone Config")]
        public Vector2 cameraDeadZoneNormalizedSize;

        [Header("Shake Config")]
        public float cameraShakeFrequency_roleDamage;
        public float cameraShakeAmplitude_roleDamage;
        public float cameraShakeDuration_roleDamage;
        public EasingType cameraShakeEasingType_roleDamage;
        public EasingMode cameraShakeEasingMode_roleDamage;

    }

}