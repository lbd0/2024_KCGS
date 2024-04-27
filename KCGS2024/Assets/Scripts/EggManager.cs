using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggManager : MonoBehaviour
{
    public GameObject normal;
    public GameObject broken;
    public GameObject upShell;
    public GameObject downShell;
    public GameObject egg;

    private Vector3 shellPos;
    private Vector3 currentShellPos;

    // Start is called before the first frame update
    void Start()
    {
        normal.SetActive(true);
        broken.SetActive(false);
        egg.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        currentShellPos = upShell.transform.position - downShell.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "induction")
        {
            broken.SetActive(true);
            normal.SetActive(false);

            this.GetComponent<Collider>().enabled = false;
            
            shellPos = upShell.transform.position - downShell.transform.position;

            if (shellPos != currentShellPos)
            {
                egg.SetActive(true);
            }
        }
    }
}
