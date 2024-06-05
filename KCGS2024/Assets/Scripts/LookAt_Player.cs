using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt_Player : MonoBehaviour
{
    public Animator animator;
    public Transform Player;
    public GameObject knife;
    private Vector3 targetposition;

    private AudioSource theAudio;
    [SerializeField] private AudioClip[] clip;

    private void Start()
    {
        theAudio = GetComponent<AudioSource>();
    }
    void Update()
    {
        targetposition = new Vector3(Player.position.x, transform.position.y, Player.position.z);
        transform.LookAt(targetposition);
    }
    public void PlaySound(int index)
    {
        theAudio.clip = clip[index];
        theAudio.Play();
    }

    public void EduAnim()
    {
        animator.SetBool("Edu",true);
        knife.SetActive(true);
    }

    public void StopEduAnim()
    {
        animator.SetBool("Edu", false);
        knife.SetActive(false);
    }

    public void lipAnim()
    {
        animator.SetBool("lip", true);
    }

    public void StoplipAnim()
    {
        animator.SetBool("lip", false);
    }
}
