using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_Indicators : MonoBehaviour
{
    [SerializeField] private GameObject substance_1; //HCl
    [SerializeField] private GameObject substance_2; //NaOH
    [SerializeField] private GameObject substance_3; //NaCl

    [SerializeField] private bool active_substance_1; //HCl
    [SerializeField] private bool active_substance_2; //NaOH
    [SerializeField] private bool active_substance_3; //NaCls

    [SerializeField] private GameObject pipette_1; //метилоранж
    [SerializeField] private GameObject pipette_2; //лакмус
    [SerializeField] private GameObject pipette_3; //фенолфталеин
    
    public void indtEnter(int m_name_sc, Collider m_gmobj)
    {
        switch (m_name_sc)
        {
            case 1:
                Debug.Log("Enter: " + m_gmobj);
                if (m_gmobj.tag == "UserLaser")
                {

                }
                break;
            case 2:
                Debug.Log("Enter: " + m_gmobj);
                break;
            case 3:
                Debug.Log("Enter: " + m_gmobj);
                break;
            default:
                Debug.Log("None");
                break;
        }
    }
    public void indtExit(int m_name_sc, Collider m_gmobj)
    {
        Debug.Log("Exit: " + m_gmobj);
    }
}
