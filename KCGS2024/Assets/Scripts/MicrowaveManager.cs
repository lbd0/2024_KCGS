using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicrowaveManager : MonoBehaviour
{
    public GameObject open_rice;
    public GameObject inMW;

    // Start is called before the first frame update
    void Start()
    {
        inMW.SetActive(false);
        open_rice.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Rice")
        {
            Destroy(other.gameObject);
            inMW.SetActive(true);

            yield return new WaitForSeconds(3f);

            inMW.SetActive(false);
            open_rice.SetActive(true);
        }
    }
}
