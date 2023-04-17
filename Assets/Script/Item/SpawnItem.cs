using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public GameObject objectToBeSpawned;
    public int inputNumberOfSpawn;
    public Transform Parent;

    private GameObject RemoveSpawn;
    void Start()
    {
        RemoveSpawn = objectToBeSpawned;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(RemoveSpawn != null)
            {
                Destroy(RemoveSpawn);
            }
            
            Vector2 spawnDiamond = new Vector2(Random.Range(-4, 4), Random.Range(-6, 6));
            RemoveSpawn = Instantiate(objectToBeSpawned, spawnDiamond, Quaternion.identity, Parent);
            
        }
    }

    void OnDisable()
    {
        gameObject.GetComponent<SpawnItem>().enabled = true;
    }
}
