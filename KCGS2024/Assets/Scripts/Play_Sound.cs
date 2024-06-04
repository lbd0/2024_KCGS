using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Sound : MonoBehaviour
{
    private AudioSource theAudio;
    [SerializeField] private AudioClip[] clip;

    // Start is called before the first frame update
    void Start()
    {
        theAudio = GetComponent<AudioSource>();
        StartCoroutine("Play");
    }

    IEnumerator Play()
    {
        theAudio.clip = clip[0];
        theAudio.Play();

            yield return new WaitForSeconds(9.0f);
            if (!theAudio.isPlaying)
            {
                theAudio.clip = clip[1];
                theAudio.Play();
            }
    }
    public void PlaySound(int index)
    {
        theAudio.clip = clip[index];
        theAudio.Play();
    }
}
