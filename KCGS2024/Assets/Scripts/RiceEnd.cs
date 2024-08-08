using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiceEnd : MonoBehaviour
{
    public GameManager gameManager;
    public Play_Sound Play_Sound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "rice_open")
        {
            gameManager.changeText("이제 계란후라이를 해보세요.\n전기레인지의 전원 버튼을 터치하세요.");
            Play_Sound.PlaySound(10);
        }
    }
}
