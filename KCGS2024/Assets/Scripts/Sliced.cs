using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliced : MonoBehaviour
{
    public GameObject sliced;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        sliced.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "SliceObjects")
        {
            sliced.SetActive(true);
            Destroy(other.gameObject);

            gameManager.changeText("야채 손질이 끝났습니다.\n이제 즉석밥을 데워보세요.");
        }
    }
}
