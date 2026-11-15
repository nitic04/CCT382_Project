using UnityEngine;

public class DiveAudio : MonoBehaviour
{
    public DiveConfigSO config;
    public DiveEventsSO events;

    public AudioClip diveClip;
    public AudioClip knifeClip;

    AudioSource source;

    void Awake()
    {
        source = gameObject.AddComponent<AudioSource>();
        source.spatialBlend = 0f;
    }

    void OnEnable()
    {
        events.DiveStarted += OnDive;
        events.TargetKilled += OnKill;
    }

    void OnDisable()
    {
        events.DiveStarted -= OnDive;
        events.TargetKilled -= OnKill;
    }

    void OnDive(Vector3 pos) => Play(diveClip, 1f);

    void OnKill(Vector3 pos, int combo) => Play(knifeClip, 1f + (combo - 1) * 0.1f);

    void Play(AudioClip clip, float pitchBoost)
    {
        if (clip == null) return;
        source.pitch = Random.Range(config.pitchRange.x, config.pitchRange.y) * pitchBoost;
        source.PlayOneShot(clip, Random.Range(config.volumeRange.x, config.volumeRange.y));
    }
}