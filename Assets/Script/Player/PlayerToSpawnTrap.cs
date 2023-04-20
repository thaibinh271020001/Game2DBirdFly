using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerToSpawnTrap : MonoBehaviour
{
    public float Point;
    [SerializeField] GameObject Trap3;
    [SerializeField] GameObject Trap4;
    [SerializeField] GameObject Trap5;
    [SerializeField] GameObject Trap6;
    [SerializeField] GameObject Trap7;
    [SerializeField] GameObject Trap10;
    [SerializeField] GameObject Trap11;
    [SerializeField] GameObject Trap12;
    [SerializeField] GameObject Trap13;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTrap();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "AllLine")
        {
            Point++;
        }
    }

    void SpawnTrap()
    {
        switch(Point){
            case 1:
                Debug.Log(Point);
                Trap3.SetActive(true);
                break;
            case 2:
                Debug.Log(Point);
                Trap11.SetActive(true);
                break;
            case 3:
                Debug.Log(Point);
                Trap7.SetActive(true);
                break;
            case 5:
                Debug.Log(Point);
                Trap6.SetActive(true);
                break;
            case 8:
                Debug.Log(Point);
                Trap10.SetActive(true);
                break;
            case 13:
                Debug.Log(Point);
                Trap4.SetActive(true);
                break;
            case 20:
                Debug.Log(Point);
                Trap5.SetActive(true);
                Trap12.SetActive(true);
                break;
            case 25:
                Debug.Log(Point);
                Trap5.SetActive(true);
                Trap13.SetActive(true);
                break;
        }
    }
}
