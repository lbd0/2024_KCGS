using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clean : MonoBehaviour
{
    public GameManager gameManager;
    public Play_Sound Play_Sound;
    public LookAt_Player LookAt_Player;
    private int cnt = 0;

    // Start is called before the first frame update
    void Start()
    {
        cnt = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Sink")
        {
            if(cnt > 3)
            {
                gameManager.changeText("야채가 깨끗해졌습니다.\n이제 야채를 잘라보세요.");
                Play_Sound.PlaySound(2);
                Invoke("Edu1", 10f);

            } else
            {
                cnt++;
            }
        }
    }
    void Edu1()
    {
        Play_Sound.PlaySound(3);
        LookAt_Player.EduAnim();
        Invoke("Edu2", 9f);
    }
    void Edu2()
    {
        Play_Sound.PlaySound(4);
        Invoke("Edu3", 10f);
    }
    void Edu3()
    {
        Play_Sound.PlaySound(5);
        Invoke("Edu4", 9f);
    }
    void Edu4()
    {
        LookAt_Player.StopEduAnim();
        LookAt_Player.lipAnim();
        Play_Sound.PlaySound(6);
    }
}
