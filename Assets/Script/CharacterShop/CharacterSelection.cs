using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{
    public static int selection;
    public GameObject[] gameObjects;

    private void Start()
    {
        Load();
        PlayerPrefs.SetInt("SelectionCharacter", selection);
        selection = PlayerPrefs.GetInt("SelectionCharacter");
        Debug.Log("Selection: " + selection);
    }
    public void SelectionDefause()
    {
        selection = 0;
        Debug.Log("selection: " + selection);
        PlayerPrefs.SetInt("SelectionCharacter", 0);
    }
    public void Selection0()
    {
        if(gameObjects[0].activeInHierarchy == false)
        {
            selection = 1;
            Debug.Log("selection: " + selection);
            PlayerPrefs.SetInt("SelectionCharacter", 1);
        }
    }
    public void Selection1()
    {
        if (gameObjects[1].activeInHierarchy == false)
        {
            selection = 2;
            Debug.Log("selection: " + selection);
            PlayerPrefs.SetInt("SelectionCharacter", 2);
        }
    }
    public void Selection2()
    {
        if (gameObjects[2].activeInHierarchy == false)
        {
            selection = 3;
            Debug.Log("selection: " + selection);
            PlayerPrefs.SetInt("SelectionCharacter", 3);
        }
    }
    public void Selection3()
    {
        if (gameObjects[3].activeInHierarchy == false)
        {
            selection = 4;
            Debug.Log("selection: " + selection);
            PlayerPrefs.SetInt("SelectionCharacter", 4);
        }
    }
    public void Selection4()
    {
        if (gameObjects[4].activeInHierarchy == false)
        {
            selection = 5;
            Debug.Log("selection: " + selection);
            PlayerPrefs.SetInt("SelectionCharacter", 5);
        }
    }
    public void Selection5()
    {
        if (gameObjects[5].activeInHierarchy == false)
        {
            selection = 6;
            Debug.Log("selection: " + selection);
            PlayerPrefs.SetInt("SelectionCharacter", 6);
        }
    }
    public void Selection6()
    {
        if (gameObjects[6].activeInHierarchy == false)
        {
            selection = 7;
            Debug.Log("selection: " + selection);
            PlayerPrefs.SetInt("SelectionCharacter", 7);
        }
    }
    public void Selection7()
    {
        if (gameObjects[7].activeInHierarchy == false)
        {
            selection = 8;
            Debug.Log("selection: " + selection);
            PlayerPrefs.SetInt("SelectionCharacter", 8);
        }
    }
    public void Selection8()
    {
        if (gameObjects[8].activeInHierarchy == false)
        {
            selection = 9;
            Debug.Log("selection: " + selection);
            PlayerPrefs.SetInt("SelectionCharacter", 9);
        }
    }
    public void Selection9()
    {
        if (gameObjects[9].activeInHierarchy == false)
        {
            selection = 10;
            Debug.Log("selection: " + selection);
            PlayerPrefs.SetInt("SelectionCharacter", 10);
        }
    }
    public void Selection10()
    {
        if (gameObjects[10].activeInHierarchy == false)
        {
            selection = 11;
            Debug.Log("selection: " + selection);
            PlayerPrefs.SetInt("SelectionCharacter", 11);
        }
    }
    public void Selection11()
    {
        if (gameObjects[11].activeInHierarchy == false)
        {
            selection = 12;
            Debug.Log("selection: " + selection);
            PlayerPrefs.SetInt("SelectionCharacter", 12);
        }
    }
    public void Selection12()
    {
        if (gameObjects[12].activeInHierarchy == false)
        {
            selection = 13;
            Debug.Log("selection: " + selection);
            PlayerPrefs.SetInt("SelectionCharacter", 13);
        }
    }
    public void Selection13()
    {
        if (gameObjects[13].activeInHierarchy == false)
        {
            selection = 14;
            Debug.Log("selection: " + selection);
            PlayerPrefs.SetInt("SelectionCharacter", 14);
        }
    }
    public void Selection14()
    {
        if (gameObjects[14].activeInHierarchy == false)
        {
            selection = 15;
            Debug.Log("selection: " + selection);
            PlayerPrefs.SetInt("SelectionCharacter", 15);
        }
    }
    public void Load()
    {
        selection = PlayerPrefs.GetInt("SelectionCharacter");
    }
}
