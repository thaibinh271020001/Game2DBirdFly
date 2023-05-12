using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapToMain : MonoBehaviour
{
    public void Swap()
    {
        SceneManager.LoadScene("SampleScene");

    }
}
