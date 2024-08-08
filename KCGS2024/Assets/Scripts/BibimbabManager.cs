using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BibimbabManager : MonoBehaviour
{

    private int index = 1;
    public GameManager GameManager;
    public Play_Sound Play_Sound;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
        index = 1;
        for(int i = 1; i<this.transform.childCount; i++)
        {
            this.transform.GetChild(i).gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (index == 1 && other.gameObject.name == "rice_open") 
        {
            this.transform.GetChild(index).gameObject.SetActive(true);
            Destroy(other.gameObject);
            index++;
        } else if (index == 2 && other.gameObject.name == "Sliced")
        {
            this.transform.GetChild(index).gameObject.SetActive(true);
            Destroy(other.gameObject);
            index++;
        }
        else if (index == 3 && other.gameObject.name == "gochujangBowl")
        {
            this.transform.GetChild(index).gameObject.SetActive(true);
            Destroy(other.gameObject);
            index++;
        }
        else if (index == 4 && other.gameObject.name == "Egg_3")
        {
            this.transform.GetChild(index).gameObject.SetActive(true);
            other.gameObject.SetActive(false);
            index++;
        }
        else if (index == 5 && other.gameObject.name == "sesameOil")
        {
            this.transform.GetChild(index).gameObject.SetActive(true);
            Destroy(other.gameObject);
            index++;

            GameManager.changeText("비빔밥 완성~");
            Play_Sound.PlaySound(16);
        }
        
    }
}
