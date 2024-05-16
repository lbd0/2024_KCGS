using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clean : MonoBehaviour
{
    public GameManager gameManager;
    public Play_Sound Play_Sound;
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

            } else
            {
                cnt++;
            }
        }
    }
}
