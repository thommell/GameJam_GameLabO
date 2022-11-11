using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private int spawnRate;
    [SerializeField] private GameObject enemy;
    private GameObject player;

    private Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        offset = new Vector2(0, 6);
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            // Spawn directly on the player
            var enemyOBJ =  Instantiate(enemy,(Vector2) player.transform.position + offset,Quaternion.identity,transform);
            yield return new WaitForSeconds(spawnRate);
            Destroy(enemyOBJ);
        }
    }
}
