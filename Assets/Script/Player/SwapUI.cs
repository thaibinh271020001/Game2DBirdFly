using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapUI : MonoBehaviour
{
    public GameObject MenuGame;
    public GameObject RestartGame;

    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "AllTrap")
        {
            RestartGame.SetActive(true);
            MenuGame.SetActive(false);
            Invoke("StopAnimation", 2f);
            Time.timeScale = 0f;
        }
    }

    public void StopAnimation()
    {
        anim.enabled = false;
        Debug.Log("remove animation");
    }

    public void Resart()
    {

        Banner.Instance.ShowAd();
    }
}
