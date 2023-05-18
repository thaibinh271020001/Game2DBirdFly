using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapInShop : MonoBehaviour
{
    public GameObject PanelCharacter, PanelDiamond;

    public Color colorA;
    public Color colorB;

    Image ImageButtonCharacter;
    Image ImageButtonDiamond;

    private void Start()
    {
        colorA.a = 1;
        ImageButtonCharacter = GameObject.Find("Button Character").GetComponent<Image>();
        ImageButtonDiamond = GameObject.Find("Button Purchase").GetComponent<Image>();
    }

    public void SwapToPanelDiamond()
    {
        PanelCharacter.SetActive(false);
        PanelDiamond.SetActive(true);
        ImageButtonCharacter.color = colorB;
        ImageButtonDiamond.color = colorA;
    }

    public void SwapToPanelCharacter()
    {
        PanelCharacter.SetActive(true);
        PanelDiamond.SetActive(false);
        ImageButtonDiamond.color = colorB;
        ImageButtonCharacter.color = colorA;
    }
}
