using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReceiver : MonoBehaviour
{
    public delegate void ScrollWheelUpdate(float value);
    public static event ScrollWheelUpdate ScrollWheelUpdateEvent;

    public delegate void keyButtonUpdate(int value);
    public static event keyButtonUpdate keyButtonUpdateEvent;

    public delegate void mouseClickUpdate(int value);
    public static event mouseClickUpdate mouseClickUpdateEvent;
    
    
    /*
    private int _number;
    public int number
    {
        get
        {
            return _number;
        }
        private set
        {
            OnNumberChanged();
            _number = value;
        }
    }
      */  
    // Update is called once per frame
    void Update()
    {
        float mouseScrollWheel = Input.GetAxis("Mouse ScrollWheel");
        if (mouseScrollWheel != 0)
        {
            if (ScrollWheelUpdateEvent != null)
            {
                ScrollWheelUpdateEvent.Invoke(mouseScrollWheel);
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
            if (ScrollWheelUpdateEvent != null)
                keyButtonUpdateEvent.Invoke(0);
        if (Input.GetKeyDown(KeyCode.W))
            if (ScrollWheelUpdateEvent != null)
                keyButtonUpdateEvent.Invoke(1);
        if (Input.GetKeyDown(KeyCode.E))
            if (ScrollWheelUpdateEvent != null)
                keyButtonUpdateEvent.Invoke(2);
        if (Input.GetKeyDown(KeyCode.R))
            if (ScrollWheelUpdateEvent != null)
                keyButtonUpdateEvent.Invoke(3);

        if (Input.GetButtonDown("Lclick"))
            if (mouseClickUpdateEvent != null)
                mouseClickUpdateEvent.Invoke(0);
        if (Input.GetButtonDown("Rclick"))
            if (mouseClickUpdateEvent != null)
                mouseClickUpdateEvent.Invoke(2);

    }
}
