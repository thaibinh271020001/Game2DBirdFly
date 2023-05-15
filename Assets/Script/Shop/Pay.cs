using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pay : MonoBehaviour
{
    int diamondPoint;
    int countToPay;
    int openKey0, openKey1, openKey2, openKey3, openKey4, openKey5, openKey6, openKey7, openKey8, openKey9, openKey10, openKey11, openKey12,
        openKey13, openKey14;

    public GameObject[] Use = new GameObject[16];
    public GameObject[] Locked = new GameObject[16];
    public GameObject notMoney;
    public GameObject PanelBuy;

    void Start()
    {
        diamondPoint = DiamondPoint.Diamond;
        Debug.Log(DiamondPoint.Diamond);
        PlayerPrefs.SetInt("Money", diamondPoint);
        OpenKey();
    }
    public void BuyBird100()
    {
        if(Locked[0].activeInHierarchy == true)
        {
            if (diamondPoint >= 100)
            {
                countToPay = 1;
                PanelBuy.SetActive(true);
                Debug.Log(diamondPoint);
            }else
            {
                notMoney.SetActive(true);
            }
        }
    }

    public void BuyBird120()
    {
        if (Locked[1].activeInHierarchy == true)
        {
            if (diamondPoint >= 120)
            {
                countToPay = 2;
                PanelBuy.SetActive(true);
                Debug.Log(diamondPoint);
            }
            else
            {
                notMoney.SetActive(true);
            }
        }
    }
    public void BuyBird140()
    {
        if (Locked[2].activeInHierarchy == true)
        {
            if (diamondPoint >= 140)
            {
                countToPay = 3;
                PanelBuy.SetActive(true);
                Debug.Log(diamondPoint);
            }
            else
            {
                notMoney.SetActive(true);
            }
        }
    }
    public void BuyBird160()
    {
        if (Locked[3].activeInHierarchy == true)
        {
            if (diamondPoint >= 160)
            {
                countToPay = 4;
                PanelBuy.SetActive(true);
                Debug.Log(diamondPoint);
            }
            else
            {
                notMoney.SetActive(true);
            }
        }
    }
    public void BuyBird180()
    {
        if (Locked[4].activeInHierarchy == true)
        {
            if (diamondPoint >= 180)
            {
                countToPay = 5;
                PanelBuy.SetActive(true);
                Debug.Log(diamondPoint);
            }
            else
            {
                notMoney.SetActive(true);
            }
        }
    }
    public void BuyBird200()
    {
        if (Locked[5].activeInHierarchy == true)
        {
            if (diamondPoint >= 200)
            {
                countToPay = 6;
                PanelBuy.SetActive(true);
                Debug.Log(diamondPoint);
            }
            else
            {
                notMoney.SetActive(true);
            }
        }
    }
    public void BuyBird220()
    {
        if (Locked[6].activeInHierarchy == true)
        {
            if (diamondPoint >= 220)
            {
                countToPay = 7;
                PanelBuy.SetActive(true);
                Debug.Log(diamondPoint);
            }
            else
            {
                notMoney.SetActive(true);
            }
        }
    }
    public void BuyBird230()
    {
        if (Locked[7].activeInHierarchy == true)
        {
            if (diamondPoint >= 230)
            {
                countToPay = 8;
                PanelBuy.SetActive(true);
                Debug.Log(diamondPoint);
            }
            else
            {
                notMoney.SetActive(true);
            }
        }
    }
    public void BuyBird240()
    {
        if (Locked[8].activeInHierarchy == true)
        {
            if (diamondPoint >= 240)
            {
                countToPay = 9;
                PanelBuy.SetActive(true);
                Debug.Log(diamondPoint);
            }
            else
            {
                notMoney.SetActive(true);
            }
        }
    }
    public void BuyBird250()
    {
        if (Locked[9].activeInHierarchy == true)
        {
            if (diamondPoint >= 250)
            {
                countToPay = 10;
                PanelBuy.SetActive(true);
                Debug.Log(diamondPoint);
            }
            else
            {
                notMoney.SetActive(true);
            }
        }
    }
    public void BuyBird260()
    {
        if (Locked[10].activeInHierarchy == true)
        {
            if (diamondPoint >= 260)
            {
                countToPay = 11;
                PanelBuy.SetActive(true);
                Debug.Log(diamondPoint);
            }
            else
            {
                notMoney.SetActive(true);
            }
        }
    }
    public void BuyBird270()
    {
        if (Locked[11].activeInHierarchy == true)
        {
            if (diamondPoint >= 270)
            {
                countToPay = 12;
                PanelBuy.SetActive(true);
                Debug.Log(diamondPoint);
            }
            else
            {
                notMoney.SetActive(true);
            }
        }
    }
    public void BuyBird280()
    {
        if (Locked[12].activeInHierarchy == true)
        {
            if (diamondPoint >= 280)
            {
                countToPay = 13;
                PanelBuy.SetActive(true);
                Debug.Log(diamondPoint);
            }
            else
            {
                notMoney.SetActive(true);
            }
        }
    }
    public void BuyBird290()
    {
        if (Locked[13].activeInHierarchy == true)
        {
            if (diamondPoint >= 290)
            {
                countToPay = 14;
                PanelBuy.SetActive(true);
                Debug.Log(diamondPoint);
            }
            else
            {
                notMoney.SetActive(true);
            }
        }
    }
    public void BuyBird300()
    {
        if (Locked[14].activeInHierarchy == true)
        {
            if (diamondPoint >= 300)
            {
                countToPay = 15;
                PanelBuy.SetActive(true);
                Debug.Log(diamondPoint);
            }
            else
            {
                notMoney.SetActive(true);
            }
        }
    }

    public void NotEnoughMoney()
    {
        notMoney.SetActive(false);
    }
    public void OKNotMoney()
    {
        notMoney.SetActive(false);
    }

    public void NoButtonPay()
    {
        PanelBuy.SetActive(false);
    }

    public void YesButtonPay()
    {
        PanelBuy.SetActive(false);
        switch (countToPay)
        {
            case 1:
                Use[0].SetActive(true);
                Locked[0].SetActive(false);
                diamondPoint -= 100;
                PlayerPrefs.SetInt("OpenKey1a", 1);
                PlayerPrefs.SetInt("Money", diamondPoint);
                Debug.Log(PlayerPrefs.GetInt("OpenKey1"));
                break;
            case 2:
                Use[1].SetActive(true);
                Locked[1].SetActive(false);
                diamondPoint -= 120;
                PlayerPrefs.SetInt("OpenKey2a", 1);
                PlayerPrefs.SetInt("Money", diamondPoint);
                break;
            case 3:
                Use[2].SetActive(true);
                Locked[2].SetActive(false);
                diamondPoint -= 140;
                PlayerPrefs.SetInt("OpenKey3a", 1);
                PlayerPrefs.SetInt("Money", diamondPoint);
                break;
            case 4:
                Use[3].SetActive(true);
                Locked[3].SetActive(false);
                diamondPoint -= 160;
                PlayerPrefs.SetInt("OpenKey4a", 1);
                PlayerPrefs.SetInt("Money", diamondPoint);
                break;
            case 5:
                Use[4].SetActive(true);
                Locked[4].SetActive(false);
                diamondPoint -= 180;
                PlayerPrefs.SetInt("OpenKey5a", 1);
                PlayerPrefs.SetInt("Money", diamondPoint);
                break;
            case 6:
                Use[5].SetActive(true);
                Locked[5].SetActive(false);
                diamondPoint -= 200;
                PlayerPrefs.SetInt("OpenKey6a", 1);
                PlayerPrefs.SetInt("Money", diamondPoint);
                break;
            case 7:
                Use[6].SetActive(true);
                Locked[6].SetActive(false);
                diamondPoint -= 220;
                PlayerPrefs.SetInt("OpenKey7a", 1);
                PlayerPrefs.SetInt("Money", diamondPoint);
                break;
            case 8:
                Use[7].SetActive(true);
                Locked[7].SetActive(false);
                diamondPoint -= 230;
                PlayerPrefs.SetInt("OpenKey8a", 1);
                PlayerPrefs.SetInt("Money", diamondPoint);
                break;
            case 9:
                Use[8].SetActive(true);
                Locked[8].SetActive(false);
                diamondPoint -= 240;
                PlayerPrefs.SetInt("OpenKey9a", 1);
                PlayerPrefs.SetInt("Money", diamondPoint);
                break;
            case 10:
                Use[9].SetActive(true);
                Locked[9].SetActive(false);
                diamondPoint -= 250;
                PlayerPrefs.SetInt("OpenKey10a", 1);
                PlayerPrefs.SetInt("Money", diamondPoint);
                break;
            case 11:
                Use[10].SetActive(true);
                Locked[10].SetActive(false);
                diamondPoint -= 260;
                PlayerPrefs.SetInt("OpenKey11a", 1);
                PlayerPrefs.SetInt("Money", diamondPoint);
                break;
            case 12:
                Use[11].SetActive(true);
                Locked[11].SetActive(false);
                diamondPoint -= 270;
                PlayerPrefs.SetInt("OpenKey12a", 1);
                PlayerPrefs.SetInt("Money", diamondPoint);
                break;
            case 13:
                Use[12].SetActive(true);
                Locked[12].SetActive(false);
                diamondPoint -= 280;
                PlayerPrefs.SetInt("OpenKey13a", 1);
                PlayerPrefs.SetInt("Money", diamondPoint);
                break;
            case 14:
                Use[13].SetActive(true);
                Locked[13].SetActive(false);
                diamondPoint -= 290;
                PlayerPrefs.SetInt("OpenKey14a", 1);
                PlayerPrefs.SetInt("Money", diamondPoint);
                break;
            case 15:
                Use[14].SetActive(true);
                Locked[14].SetActive(false);
                diamondPoint -= 300;
                PlayerPrefs.SetInt("OpenKey15a", 1);
                PlayerPrefs.SetInt("Money", diamondPoint);
                break;
        }
    }

    public void OpenKey()
    {
        openKey0 = PlayerPrefs.GetInt("OpenKey1a");
        if (openKey0 != 0)
        {
            Use[0].SetActive(true);
            Locked[0].SetActive(false);
        }

        openKey1 = PlayerPrefs.GetInt("OpenKey2a");
        if (openKey1 != 0)
        {
            Use[1].SetActive(true);
            Locked[1].SetActive(false);
        }

        openKey2 = PlayerPrefs.GetInt("OpenKey3a");
        if (openKey2 != 0)
        {
            Use[2].SetActive(true);
            Locked[2].SetActive(false);
        }

        openKey3 = PlayerPrefs.GetInt("OpenKey4a");
        if (openKey3 != 0)
        {
            Use[3].SetActive(true);
            Locked[3].SetActive(false);
        }

        openKey4 = PlayerPrefs.GetInt("OpenKey5a");
        if (openKey4 != 0)
        {
            Use[4].SetActive(true);
            Locked[4].SetActive(false);
        }

        openKey5 = PlayerPrefs.GetInt("OpenKey6a");
        if (openKey5 != 0)
        {
            Use[5].SetActive(true);
            Locked[5].SetActive(false);
        }

        openKey6 = PlayerPrefs.GetInt("OpenKey7a");
        if (openKey6 != 0)
        {
            Use[6].SetActive(true);
            Locked[6].SetActive(false);
        }

        openKey7 = PlayerPrefs.GetInt("OpenKey8a");
        if (openKey7 != 0)
        {
            Use[7].SetActive(true);
            Locked[7].SetActive(false);
        }

        openKey8 = PlayerPrefs.GetInt("OpenKey9a");
        if (openKey8 != 0)
        {
            Use[8].SetActive(true);
            Locked[8].SetActive(false);
        }

        openKey9 = PlayerPrefs.GetInt("OpenKey10a");
        if (openKey9 != 0)
        {
            Use[9].SetActive(true);
            Locked[9].SetActive(false);
        }

        openKey10 = PlayerPrefs.GetInt("OpenKey11a");
        if (openKey10 != 0)
        {
            Use[10].SetActive(true);
            Locked[10].SetActive(false);
        }

        openKey11 = PlayerPrefs.GetInt("OpenKey12a");
        if (openKey11 != 0)
        {
            Use[11].SetActive(true);
            Locked[11].SetActive(false);
        }

        openKey12 = PlayerPrefs.GetInt("OpenKey13a");
        if (openKey12 != 0)
        {
            Use[12].SetActive(true);
            Locked[12].SetActive(false);
        }

        openKey13 = PlayerPrefs.GetInt("OpenKey14a");
        if (openKey13 != 0)
        {
            Use[13].SetActive(true);
            Locked[13].SetActive(false);
        }

        openKey14 = PlayerPrefs.GetInt("OpenKey15a");
        if (openKey14 != 0)
        {
            Use[14].SetActive(true);
            Locked[14].SetActive(false);
        }
    }
}