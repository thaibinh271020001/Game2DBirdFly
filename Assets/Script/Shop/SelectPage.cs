using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPage : MonoBehaviour
{
    private int Page = 1;

    [SerializeField]private GameObject ButtonBird1;
    [SerializeField]private GameObject ButtonBird2;
    [SerializeField]private GameObject ButtonBird3;
    [SerializeField]private GameObject ButtonBird4;
    [SerializeField]private GameObject ButtonBird5;
    [SerializeField]private GameObject ButtonBird6;
    [SerializeField]private GameObject ButtonBird7;
    [SerializeField]private GameObject ButtonBird8;
    [SerializeField]private GameObject ButtonBird9;
    [SerializeField]private GameObject ButtonBird10;
    [SerializeField]private GameObject ButtonBird11;
    [SerializeField]private GameObject ButtonBird12;
    [SerializeField]private GameObject ButtonBird13;
    [SerializeField]private GameObject ButtonBird14;
    [SerializeField]private GameObject ButtonBird15;
    [SerializeField]private GameObject ButtonBird16;

    [SerializeField] private GameObject DisLeftBtn;
    [SerializeField] private GameObject DisRightBtn;
    [SerializeField] private GameObject LeftButton;
    [SerializeField] private GameObject RightButton;
    public void NextPage()
    {
        if (Page < 4)
        {
            Page++;
        }

        switch (Page)
        {
            case 2:
                ButtonBird1.SetActive(false);
                ButtonBird2.SetActive(false);
                ButtonBird3.SetActive(false);
                ButtonBird4.SetActive(false);
                ButtonBird5.SetActive(true);
                ButtonBird6.SetActive(true);
                ButtonBird7.SetActive(true);
                ButtonBird8.SetActive(true);
                DisLeftBtn.SetActive(false);
                LeftButton.SetActive(true);
                break;
            case 3:
                ButtonBird5.SetActive(false);
                ButtonBird6.SetActive(false);
                ButtonBird7.SetActive(false);
                ButtonBird8.SetActive(false);
                ButtonBird9.SetActive(true);
                ButtonBird10.SetActive(true);
                ButtonBird11.SetActive(true);
                ButtonBird12.SetActive(true);
                break;
            case 4:
                ButtonBird9.SetActive(false);
                ButtonBird10.SetActive(false);
                ButtonBird11.SetActive(false);
                ButtonBird12.SetActive(false);
                ButtonBird13.SetActive(true);
                ButtonBird14.SetActive(true);
                ButtonBird15.SetActive(true);
                ButtonBird16.SetActive(true);
                DisRightBtn.SetActive(true);
                RightButton.SetActive(false);
                break;
        }

        Debug.Log(Page);
    }

    public void PreviousPage()
    {
        if (Page > 1)
        {
            Page--;
        }

        switch (Page)
        {
            case 1:
                ButtonBird1.SetActive(true);
                ButtonBird2.SetActive(true);
                ButtonBird3.SetActive(true);
                ButtonBird4.SetActive(true);
                ButtonBird5.SetActive(false);
                ButtonBird6.SetActive(false);
                ButtonBird7.SetActive(false);
                ButtonBird8.SetActive(false);
                DisLeftBtn.SetActive(true);
                LeftButton.SetActive(false);
                break;
            case 2:
                ButtonBird5.SetActive(true);
                ButtonBird6.SetActive(true);
                ButtonBird7.SetActive(true);
                ButtonBird8.SetActive(true);
                ButtonBird9.SetActive(false);
                ButtonBird10.SetActive(false);
                ButtonBird11.SetActive(false);
                ButtonBird12.SetActive(false);
                break;
            case 3:
                ButtonBird9.SetActive(true);
                ButtonBird10.SetActive(true);
                ButtonBird11.SetActive(true);
                ButtonBird12.SetActive(true);
                ButtonBird13.SetActive(false);
                ButtonBird14.SetActive(false);
                ButtonBird15.SetActive(false);
                ButtonBird16.SetActive(false);
                DisRightBtn.SetActive(false);
                RightButton.SetActive(true);
                break;
        }
        Debug.Log(Page);

    }

    public void SelectedPage()
    {
        NextPage();
        PreviousPage();
        
    }
    void Start()
    {

    }

    void Update()
    {
       
    }
}
