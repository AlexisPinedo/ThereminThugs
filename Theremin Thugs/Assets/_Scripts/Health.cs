using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (health == 0)
            SceneManager.LoadScene(0);
    }

    public Collider2D Collider2D { get; set; }
    public object SeneManager { get; private set; }

    //called every frame
    void Update()
    {

    }
    
}
