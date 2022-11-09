using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacoBellpoo : MonoBehaviour
{
    private ParticleSystem particleSmoke;

    public void Awake()
    {
        particleSmoke = gameObject.GetComponentInChildren<ParticleSystem>();
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(!particleSmoke.IsAlive())
        {
            Destroy(gameObject);
        }
    }
}
