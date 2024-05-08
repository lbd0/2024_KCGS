using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt_Player : MonoBehaviour
{
    public Transform Player;
    private Vector3 targetposition;

    void Update()
    {
        targetposition = new Vector3(Player.position.x, transform.position.y, Player.position.z);
        transform.LookAt(targetposition);
    }
}
