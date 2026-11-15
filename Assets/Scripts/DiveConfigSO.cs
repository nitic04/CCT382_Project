using UnityEngine;

[CreateAssetMenu(menuName = "Milestone2/Dive Config", fileName = "DiveConfig")]
public class DiveConfigSO : ScriptableObject
{
    [Header("Targeting")]
    public LayerMask targetLayer;
    public float range = 25f;
    public float aimRadius = 1f;

    [Header("Dive")]
    public float diveSpeed = 28f;
    public float impactDistance = 1.2f;
    public float stealthOffset = 0.8f;

    [Header("Chain")]
    public float minHeight = 2f;
    public float gravity = -20f;
    public float chainWindow = 1.5f;
    public float cooldown = 3f;

    [Header("Feel")]
    public float shakeStrength = 1f;

    [Header("Audio Variation")]
    public Vector2 pitchRange = new Vector2(0.9f, 1.1f);
    public Vector2 volumeRange = new Vector2(0.8f, 1f);

    public float stabYaw = 0f;
}