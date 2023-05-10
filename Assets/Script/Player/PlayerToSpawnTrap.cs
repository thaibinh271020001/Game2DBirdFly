using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerToSpawnTrap : MonoBehaviour
{
    public int Point;   

    [SerializeField] GameObject Trap1;
    [SerializeField] GameObject Trap2;
    [SerializeField] GameObject Trap3;
    [SerializeField] GameObject Trap4;
    [SerializeField] GameObject Trap5;
    [SerializeField] GameObject Trap6;
    [SerializeField] GameObject Trap7;
    [SerializeField] GameObject Trap8;
    [SerializeField] GameObject Trap9;
    [SerializeField] GameObject Trap10;
    [SerializeField] GameObject Trap11;
    [SerializeField] GameObject Trap12;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "AllLine")
        {
            Point++;
            SpawnTrap();
            RandomTrap();
        }
    }

    void SpawnTrap()
    {
        switch (Point)
        {
            case 1:
                Trap3.SetActive(true);
                break;
            case 2:
                Trap11.SetActive(true);
                break;
            case 3:
                Trap7.SetActive(true);
                break;
            case 5:
                Trap6.SetActive(true);
                break;
            case 8:
                Trap10.SetActive(true);
                break;
            case 13:
                Trap4.SetActive(true);
                break;
            case 21:
                Trap5.SetActive(true);
                Trap12.SetActive(true);
                break;
            case 25:
                Trap5.SetActive(true);
                break;
        }
    }

    void RandomTrap()
    {
        if(Point % 2 != 0)
        {
            Trap1.transform.position = new Vector2(Random.Range(-3.3f, -1.8f), Trap1.transform.position.y);
            Trap2.transform.position = new Vector2(Random.Range(-1, 0.25f), Trap2.transform.position.y);
            Trap3.transform.position = new Vector2(Random.Range(1, 3.3f), Trap3.transform.position.y);
            Trap4.transform.position = new Vector2(Trap4.transform.position.x, Random.Range(1.7f, 5f));
            Trap5.transform.position = new Vector2(Trap5.transform.position.x, Random.Range(1f, -2.5f));
            Trap6.transform.position = new Vector2(Trap6.transform.position.x, Random.Range(-3.3f, -5.1f));
            Trap10.transform.position = new Vector2(Random.Range(1.24f, 3.45f), Trap10.transform.position.y);
            Trap11.transform.position = new Vector2(Random.Range(-1.63f, 0.5f), Trap11.transform.position.y);
            Trap12.transform.position = new Vector2(Random.Range(-3.25f, -2.34f), Trap12.transform.position.y);
        }
        if (Point % 2 == 0 && Point !=0)
        {
            Trap1.transform.position = new Vector2(Random.Range(-3.3f, -1.8f), Trap1.transform.position.y);
            Trap2.transform.position = new Vector2(Random.Range(-1, 0.25f), Trap2.transform.position.y);
            Trap3.transform.position = new Vector2(Random.Range(1, 3.3f), Trap3.transform.position.y);
            Trap7.transform.position = new Vector2(Trap7.transform.position.x, Random.Range(-5f, -2.74f));
            Trap8.transform.position = new Vector2(Trap8.transform.position.x, Random.Range(-2f, -1.08f));
            Trap9.transform.position = new Vector2(Trap9.transform.position.x, Random.Range(1.82f, 5.08f));
            Trap10.transform.position = new Vector2(Random.Range(1.24f, 3.45f), Trap10.transform.position.y);
            Trap11.transform.position = new Vector2(Random.Range(-1.63f, 0.5f), Trap11.transform.position.y);
            Trap12.transform.position = new Vector2(Random.Range(-3.25f, -2.34f), Trap12.transform.position.y);
        }
    }
}
