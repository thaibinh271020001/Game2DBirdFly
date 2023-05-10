using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainToSwap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwapShop()
    {
        SceneManager.LoadScene("Shop Scene");
    }

    public void SwapSetting()
    {
        SceneManager.LoadScene("SettingScene");
    }
}
