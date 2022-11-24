using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{

    public Vector3 Po;
    public GameObject Player;
    public float poy;
    public int poe = 1 << 8;
    public bool hit;
    void Update()
    {
        hit = Physics.Raycast();
        if(RaycastHit = Physics.Raycast(Po, Player.transform.rotation.eulerAngles, poy, poe))
        {

        }
    }
}
