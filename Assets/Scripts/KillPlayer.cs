using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    private bool isHit;

    private GameObject spawnLocation;

    void Start()
    {
        spawnLocation = GameObject.Find("SpawnLocation");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            col.transform.position = spawnLocation.transform.position;
        }
        
    }

}
