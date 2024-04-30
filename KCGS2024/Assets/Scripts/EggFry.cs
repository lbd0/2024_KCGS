using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggFry : MonoBehaviour
{
    public GameManager gameManager;

    public GameObject oil;
    public GameObject fry;

   

    // Start is called before the first frame update
    void Start()
    {
        oil.SetActive(false); 
        fry.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Sunflower_Oil_A")
        {
            oil.SetActive(true);

            gameManager.changeText("이제 계란을 후라이팬에 넣어보세요.");
        }

        else if(other.gameObject.name == "Egg")
        {
            fry.SetActive(true);
            Destroy(other.gameObject);
            StartCoroutine(EndFry());
            
        }
    }

    IEnumerator EndFry()
    {
        yield return new WaitForSeconds(3);

        gameManager.changeText("계란이 다 익었습니다.\n전기레인지의 전원 버튼을 터치하여 전원을 끄세요.");

        
    }

}
