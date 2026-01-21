using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    fload time = 0;
    fload timer = 1;
    public GameObject pipa;
    // Update is called once per frame
    void Update()
    {
        if (time <= 0)
        {
            Instantiate(pipa, transform.position, Quartenion.identity);
            time = timer;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }
}
