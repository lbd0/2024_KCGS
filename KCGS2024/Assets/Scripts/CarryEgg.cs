using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarryEgg : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.GetChild(0).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "egg")
        {
            Destroy(other.gameObject);
            this.transform.GetChild(0).gameObject.SetActive(true);  
        }
    }
}
