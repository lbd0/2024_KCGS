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
    public IEnumerator CleanSound()
    {
        theAudio.clip = clip[2];
        theAudio.Play();
        
            yield return new WaitForSeconds(8.0f);
            if (!theAudio.isPlaying)
            {
                theAudio.clip = clip[3];
                theAudio.Play();
            }

            yield return new WaitForSeconds(5.0f);
            if (!theAudio.isPlaying)
            {
                theAudio.clip = clip[4];
                theAudio.Play();
            }

            yield return new WaitForSeconds(5.0f);
            if (!theAudio.isPlaying)
            {
                theAudio.clip = clip[5];
                theAudio.Play();
            }

            yield return new WaitForSeconds(7.0f);
            if (!theAudio.isPlaying)
            {
                theAudio.clip = clip[6];
                theAudio.Play();
            }
        
    }
    /*
    IEnumerator CleanSound()
    {
        theAudio.clip = clip[2];
        theAudio.Play();
        while (true)
        {
            yield return new WaitForSeconds(8.0f);
            if (!theAudio.isPlaying)
            {
                theAudio.clip = clip[3];
                theAudio.Play();
            }

            yield return new WaitForSeconds(5.0f);
            if (!theAudio.isPlaying)
            {
                theAudio.clip = clip[4];
                theAudio.Play();
            }

            yield return new WaitForSeconds(5.0f);
            if (!theAudio.isPlaying)
            {
                theAudio.clip = clip[5];
                theAudio.Play();
            }

            yield return new WaitForSeconds(7.0f);
            if (!theAudio.isPlaying)
            {
                theAudio.clip = clip[6];
                theAudio.Play();
            }
        }
    }

    void CuttingSound()
    {
        theAudio.clip = clip[7];
        theAudio.Play();
    }

    IEnumerator MicrowaveSound()
    {
        theAudio.clip = clip[8];
        theAudio.Play();
        while (true)
        {
            yield return new WaitForSeconds(5.0f);
            if (!theAudio.isPlaying)
            {
                theAudio.clip = clip[9];
                theAudio.Play();
            }
        }
    }

    void EggSound1()
    {
        theAudio.clip = clip[10];
        theAudio.Play();
    }
    void EggSound2()
    {
        theAudio.clip = clip[11];
        theAudio.Play();
    }
    void EggSound3()
    {
        theAudio.clip = clip[12];
        theAudio.Play();
    }

    IEnumerator Play4()
    {
        theAudio.clip = clip[13];
        theAudio.Play();
        while (true)
        {
            yield return new WaitForSeconds(6.0f);
            if (!theAudio.isPlaying)
            {
                theAudio.clip = clip[14];
                theAudio.Play();
            }
        }
    }
    void MakingSound()
    {
        theAudio.clip = clip[15];
        theAudio.Play();
    }
    void EndSound()
    {
        theAudio.clip = clip[16];
        theAudio.Play();
    }*/
}
