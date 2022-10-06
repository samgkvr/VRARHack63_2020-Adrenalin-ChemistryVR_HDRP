using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingQeus : MonoBehaviour
{
    private int yes;
    private int no;

    [SerializeField] private GameObject CanvStart;
    [SerializeField] private GameObject CanvVopros;
    [SerializeField] private GameObject Canv1;
    [SerializeField] private GameObject Canv2;
    [SerializeField] private GameObject Canv3;
    [SerializeField] private GameObject Canv4;
    [SerializeField] private GameObject Canv5;

    [SerializeField] private GameObject Canv11;
    [SerializeField] private GameObject Canv22;
    [SerializeField] private GameObject Canv33;
    [SerializeField] private GameObject Canv44;
    [SerializeField] private GameObject Canv55;
    public int GameSchet = 0;
    public int YesScet = 0;
    public bool men = false;

    private bool qwe_test;

    // Start is called before the first frame update
    void Start()
    {
        
        GameSchet = 0;
        CanvStart.SetActive(true);
        CanvVopros.SetActive(false);
        Canv1.SetActive(false);
        Canv2.SetActive(false);
        Canv3.SetActive(false);
        Canv4.SetActive(false);
        Canv5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameSchet == 6 && YesScet == 1)
        {
            Canv11.SetActive(true);
            GameSchet = 1;
            men = true;
            GameSchet = 0;
            YesScet = 0;
        }

        if (GameSchet == 6 && YesScet == 2)
        {
            Canv22.SetActive(true);
            men = true;
            GameSchet = 0;
            YesScet = 0;
        }

        if (GameSchet == 6 && YesScet == 3)
        {
            Canv33.SetActive(true);
            men = true;
            GameSchet = 0;
            YesScet = 0;
        }

        if (GameSchet == 6 && YesScet == 4)
        {
            Canv44.SetActive(true);
            men = true;
            GameSchet = 0;
            YesScet = 0;
        }

        if (GameSchet == 6 && YesScet == 5)
        {
            Canv55.SetActive(true);
            men = true;
            GameSchet = 0;
            YesScet = 0;
        }


    }

    public void Void2()
    {
        if (men == true)
        {
            men = false;
            CanvStart.SetActive(true);
            CanvVopros.SetActive(false);
            GameSchet = 0;
            Canv11.SetActive(false);
            Canv22.SetActive(false);
            Canv33.SetActive(false);
            Canv44.SetActive(false);
            Canv55.SetActive(false);
        }


        switch (GameSchet)
        {
         
            case 1:
                Canv1.SetActive(false);
                Canv2.SetActive(true);
                GameSchet = 2;
                YesScet = YesScet + 1;
                break;

            case 2:
                Canv2.SetActive(false);
                Canv3.SetActive(true);
                GameSchet = 3;
                YesScet = YesScet + 1;
                break;

            case 3:
                Canv3.SetActive(false);
                Canv4.SetActive(true);
                
                GameSchet = 4;

                break;
            case 4:
                Canv4.SetActive(false);
                Canv5.SetActive(true);
                YesScet = YesScet + 1;
                GameSchet = 5;
                break;
            case 5:
                Canv5.SetActive(false);
                GameSchet = 6;
                break;
        }

    }
    
    private void NextCanv(int num)
    {
        //Натрий загорается красным цветом? - Нет
        //Можно ли задувать спиртовку - Нет
        //Калий загорается фиолетовым? - Да
        //Можно ли пить ртуть - нет
        //Можно ли есть NaCl? - да

    }

    public void Void1()
    {
        if (men == true)
        {
            men = false;
            Canv1.SetActive(true);
            Canv11.SetActive(false);
            Canv22.SetActive(false);
            Canv33.SetActive(false);
            Canv44.SetActive(false);
            Canv55.SetActive(false);

        }
        switch (GameSchet)
        {
            case 0:
                CanvStart.SetActive(false);
                CanvVopros.SetActive(true);
                Canv1.SetActive(true);
                GameSchet = 1 ;
                break;

            case 1:
                Canv1.SetActive(false);
                Canv2.SetActive(true);
                GameSchet = 2;
                break;

            case 2:
                Canv2.SetActive(false);
                Canv3.SetActive(true);
                GameSchet = 3;
                break;

            case 3:
                Canv3.SetActive(false);
                Canv4.SetActive(true);
                YesScet = YesScet + 1;
                GameSchet = 4;
                
                break;
            case 4:
                Canv4.SetActive(false);
                Canv5.SetActive(true);
                
                GameSchet = 5;
                break;

            case 5:
                GameSchet = 6;
                YesScet = YesScet + 1;
                Canv5.SetActive(false);
                break;
        }

       
    }
    
    
}
