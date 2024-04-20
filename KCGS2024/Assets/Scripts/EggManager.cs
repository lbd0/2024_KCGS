using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggManager : MonoBehaviour
{
    public GameObject normal;
    public GameObject broken;

    // Start is called before the first frame update
    void Start()
    {
        normal.SetActive(true);
        broken.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "induction")
        {
            broken.SetActive(true);
            normal.SetActive(false);
        }
    }
}
