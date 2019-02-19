using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    
    [SerializeField]
    private Transform Spawnpoint;
    [SerializeField]
    private GameObject Prefab;
    
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
    }
}
