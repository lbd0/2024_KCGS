using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggManager : MonoBehaviour
{
    public GameObject normal;
    public GameObject broken;
    public GameObject upShell;
    public GameObject egg;

    private Vector3 upShell_pos;

    // Start is called before the first frame update
    void Start()
    {
        normal.SetActive(true);
        broken.SetActive(false);
        egg.SetActive(false);
        upShell_pos = upShell.transform.position;
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

            this.GetComponent<Collider>().enabled = false;

            if (upShell_pos != upShell.transform.position)
            {
                egg.SetActive(true);
            }
        }
    }
}
