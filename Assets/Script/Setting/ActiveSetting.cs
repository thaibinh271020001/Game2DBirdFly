using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveSetting : MonoBehaviour
{
    public GameObject ActiveStting;

    public void appear()
    {
        ActiveStting.SetActive(true);
    }
    public void Disable()
    {
        ActiveStting.SetActive(false);
    }
}
