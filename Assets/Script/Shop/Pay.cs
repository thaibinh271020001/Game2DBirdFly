using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pay : MonoBehaviour
{
    int diamondPoint;

    public GameObject[] Use = new GameObject[16];
    public GameObject[] Locked = new GameObject[16];
    public GameObject notMoney;

    void Start()
    {
        diamondPoint = DiamondPoint.Diamond;
        Debug.Log(DiamondPoint.Diamond);
    }
    public void BuyBird100()
    {
        if(Locked[0].activeInHierarchy == true)
        {
            if (diamondPoint >= 100)
            {
                diamondPoint -= 100;
                Use[0].SetActive(true);
                Locked[0].SetActive(false);
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
                diamondPoint -= 120;
                Use[1].SetActive(true);
                Locked[1].SetActive(false);
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
                diamondPoint -= 140;
                Use[2].SetActive(true);
                Locked[2].SetActive(false);
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
                diamondPoint -= 160;
                Use[3].SetActive(true);
                Locked[3].SetActive(false);
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
                diamondPoint -= 180;
                Use[4].SetActive(true);
                Locked[4].SetActive(false);
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
                diamondPoint -= 200;
                Use[5].SetActive(true);
                Locked[5].SetActive(false);
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
                diamondPoint -= 220;
                Use[6].SetActive(true);
                Locked[6].SetActive(false);
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
                diamondPoint -= 230;
                Use[7].SetActive(true);
                Locked[7].SetActive(false);
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
                diamondPoint -= 240;
                Use[8].SetActive(true);
                Locked[8].SetActive(false);
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
                diamondPoint -= 250;
                Use[9].SetActive(true);
                Locked[9].SetActive(false);
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
                diamondPoint -= 260;
                Use[10].SetActive(true);
                Locked[10].SetActive(false);
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
                diamondPoint -= 270;
                Use[11].SetActive(true);
                Locked[11].SetActive(false);
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
                diamondPoint -= 280;
                Use[12].SetActive(true);
                Locked[12].SetActive(false);
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
                diamondPoint -= 290;
                Use[13].SetActive(true);
                Locked[13].SetActive(false);
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
                diamondPoint -= 300;
                Use[14].SetActive(true);
                Locked[14].SetActive(false);
                Debug.Log(diamondPoint);
            }
            else
            {
                notMoney.SetActive(true);
            }
        }
    }

    public void OKNotMoney()
    {
        notMoney.SetActive(false);
    }


}