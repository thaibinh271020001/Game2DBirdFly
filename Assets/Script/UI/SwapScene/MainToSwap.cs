using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainToSwap : MonoBehaviour
{
    public void SwapShop()
    {
        SceneManager.LoadScene("Shop Scene");
    }

    public void SwapSetting()
    {
        SceneManager.LoadScene("SettingScene");
    }
}
