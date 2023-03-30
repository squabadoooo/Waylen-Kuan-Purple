using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//waylen is stupid
public class Exit : MonoBehaviour
{

    public GameObject gem;
    public GameObject background;
    public string teleportDestination;
    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {if (gem.activeInHierarchy == false)
        {
            //background.GetComponent<GameManager>().TeleportOpen(teleportDestination);
            background.GetComponent<GameManager>().TeleportOpen(nextScene: teleportDestination);
        }
    }
}
