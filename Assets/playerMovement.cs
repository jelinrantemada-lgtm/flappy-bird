using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D Rb; //inilisasi
    public float jumpforce; //Jump loncat
    void Start()
    {
      Rb = GetComponent<Rigidbody2D>(); //perkenalan inilisasi  
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonDown(0)) // klik mouse kiri for pc / tap untuk hp
         {
              Rb.velocity = Vector2.up * jumpforce;
         }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "point")
        {
            score++;
        }
    }
}

