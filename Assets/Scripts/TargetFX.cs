using UnityEngine;

public class TargetFX : MonoBehaviour
{
    public GameObject burstPrefab;
    public Animator animator;
    public AudioClip fallClip;
    public float fallDelay = 2.5f;

    void Awake()
    {
        if (!animator) animator = GetComponentInChildren<Animator>();
    }

    void PlayFall()
    {
        if (fallClip) AudioSource.PlayClipAtPoint(fallClip, Camera.main.transform.position, Random.Range(0.6f, 0.9f));
        Debug.Log("Fall sound for " + name);
    }

    void OnKilled(bool stealth)
    {
        if (burstPrefab) Instantiate(burstPrefab, transform.position + Vector3.up, Quaternion.identity);
        animator.SetTrigger(stealth ? "DieStealth" : Random.value < 0.5f ? "DieForward" : "DieRight");
        Invoke(nameof(PlayFall), fallDelay);
    }
}