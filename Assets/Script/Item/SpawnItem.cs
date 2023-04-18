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
        gameObject.GetComponent<CapsuleCollider2D>().enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.name == "Bird 1")
        {
            if (RemoveSpawn != null)
            {
                Destroy(RemoveSpawn);
            }

            Invoke("SpawnObject", 5f);
            Vector2 spawnPosition = new Vector2(Random.Range(-4, 4), Random.Range(-6, 6));
            StartCoroutine(WaitForSixSeconds());
            RemoveSpawn = SpawnObject();
        }
    }

    IEnumerator WaitForSixSeconds()
    {
        yield return new WaitForSeconds(6f);
    }

    GameObject SpawnObject()
    {
        return Instantiate(objectToBeSpawned, new Vector2(Random.Range(-4, 4), Random.Range(-6, 6)), Quaternion.identity, Parent);
    }
    void OnDisable()
    {
        gameObject.GetComponent<SpawnItem>().enabled = true;
    }

   
}
