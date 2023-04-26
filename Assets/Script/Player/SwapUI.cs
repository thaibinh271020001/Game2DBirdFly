using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapUI : MonoBehaviour
{
    [SerializeField] private GameObject MenuGame;
    [SerializeField] private GameObject RestartGame;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "AllTrap")
        {
            RestartGame.SetActive(true);
            MenuGame.SetActive(false);
            Time.timeScale = 0f;
        }
    }

    public void Resart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }
}
