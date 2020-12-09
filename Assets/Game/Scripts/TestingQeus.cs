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
    [SerializeField] private GameObject CanvHorocho;
    [SerializeField] private GameObject CanvPloho;
    public int GameSchet = 0;
    public int YesScet = 0;
    public bool men = false;

    // Start is called before the first frame update
    void Start()
    {
        GameSchet = 0;
        CanvStart.SetActive(true);
        CanvVopros.SetActive(false);
        CanvPloho.SetActive(false);
        Canv1.SetActive(false);
        Canv2.SetActive(false);
        Canv3.SetActive(false);
        Canv4.SetActive(false);
        Canv5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Void2()
    {
         switch (GameSchet)
        {
             
            case 2:
                Canv1.SetActive(false);
                Canv2.SetActive(true);
                GameSchet = 3;
                YesScet = YesScet + 1;
                break;
            case 3:
                Canv2.SetActive(false);
                Canv3.SetActive(true);
                GameSchet = 4;
                YesScet = YesScet + 1;
                break;
            case 4:
                Canv3.SetActive(false);
                Canv4.SetActive(true);
                GameSchet = 5;
                
                break;
            case 5:
                Canv4.SetActive(false);
                Canv5.SetActive(true);
                YesScet = YesScet + 1;
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
        
        switch (GameSchet)
        {
            case 0:
                CanvStart.SetActive(false);
                CanvVopros.SetActive(true);
                Canv1.SetActive(true);
                GameSchet = 2;
                break;
            case 2:
                Canv1.SetActive(false);
                Canv2.SetActive(true);
                GameSchet = 3;
                break;
            case 3:
                Canv2.SetActive(false);
                Canv3.SetActive(true);
                GameSchet = 4;
                YesScet = YesScet + 1;

                break;
            case 4:
                Canv3.SetActive(false);
                Canv4.SetActive(true);
                GameSchet = 5;
                break;
            case 5:
                Canv4.SetActive(false);
                Canv5.SetActive(true);
                YesScet = YesScet + 1;
                break;
        }
    }
    
    
}
