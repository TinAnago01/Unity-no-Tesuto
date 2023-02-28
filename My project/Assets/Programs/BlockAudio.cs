using UnityEngine;

public class BlockAudio : MonoBehaviour
{
    public AudioClip audioClip;

    private bool isPlaying = false;

    void Update()
    {
        if (transform.position.y < -10f && !isPlaying)
        {
            AudioSource.PlayClipAtPoint(audioClip, transform.position);
            isPlaying = true;
        }
    }
}