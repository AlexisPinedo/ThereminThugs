using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutScript : MonoBehaviour
{
    SpriteRenderer rend;

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();    
    }

    IEnumerator FadeOut()
    {
        for(float f = 1f; f >= -0.05; f -= 0.05f)
        {
            Color colour = rend.material.color;
            colour.a = f;
            yield return new WaitForSeconds(0.05f);
        }
    }

    public void startFading()
    {
        StartCoroutine("FadeOut");
    }
}
