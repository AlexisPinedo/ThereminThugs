using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 3;

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D player)
    {
        //Losing a life
        if (player.gameObject.tag == "Enemy")
        {
            health--;
            Debug.Log("Health is now: " + health);
        }
    }

    public Collider2D Collider2D { get; set; }

    //called every frame
    void Update()
    {

    }
    
}
