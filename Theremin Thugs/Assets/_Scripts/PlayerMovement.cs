using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalMove = 3f;
    
    

    // Update is called once per frame
    void Update()
    {
        // Move the object forward along its x axis 1 unit/second.
        transform.Translate(Vector3.right * Time.deltaTime);

        // Move the object forward in world space 1 unit/second.
        transform.Translate(Vector3.right * Time.deltaTime, Space.World);
        
        InputReceiver instance = new InputReceiver();

        int theumber = instance.number;
        instance.number = 3;
    }
}
