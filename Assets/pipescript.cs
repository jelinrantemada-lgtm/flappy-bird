using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipescript : MonoBehaviour
{
     fload nilaiRandom; //nilai desimal
    // Start is called before the first frame update
    void Start()
    {
        nilaiRandom = Random.Range(-0.8f,1.55f);
        transform.position = new Vector2(transform.position.x, nilaiRandom);
    }

    // Update is called once per frame
    void Update()
    {
      transform.position = Vector2.MoveTowards(transform.position, Vector2. left * 100, Time.deltaTime * 5;)  
    }
}
