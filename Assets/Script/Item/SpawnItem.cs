using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public GameObject objectToBeSpawned;
    public Transform Parent;

    private GameObject SetAcitveSpawn;
    void Start()
    {
        SetAcitveSpawn = objectToBeSpawned;
    }

    void Update()
    {
        gameObject.GetComponent<CapsuleCollider2D>().enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.name == "Bird 1")
        {
            if (SetAcitveSpawn != null)
            {
                SetAcitveSpawn.SetActive(false);
            }

            Invoke("SpawnObject", 5f);

        }   
    }

    GameObject SpawnObject()
    {
        var result = Instantiate(objectToBeSpawned, new Vector2(Random.Range(-1.94f, -1.94f), Random.Range(-3.54f, 3.54f)), Quaternion.identity, Parent);
        result.tag = "Spawned";
        result.SetActive(true);
        return result;
    }
    void OnDisable()
    {
        gameObject.GetComponent<SpawnItem>().enabled = true;
    }
}
