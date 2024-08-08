using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Sound : MonoBehaviour
{
    private AudioSource theAudio;
    [SerializeField] private AudioClip[] clip;

    public LookAt_Player LookAt_Player;

    // Start is called before the first frame update
    void Start()
    {
        theAudio = GetComponent<AudioSource>();
        StartCoroutine("Play");
        LookAt_Player.StoplipAnim();
    }

    private void Update()
    {
        if (theAudio.isPlaying)
        {
            LookAt_Player.lipAnim();
        }
        else
        {
            LookAt_Player.StoplipAnim();
        }
    }

    IEnumerator Play()
    {
        theAudio.clip = clip[0];
        theAudio.Play();
        LookAt_Player.lipAnim();

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
