using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_Indicators : MonoBehaviour
{
    /*
    HCl:
    1
    2
    3

    NaOH:
    4
    5
    6

    NaCl:
    7
    8
    9

    pipette_1
    pipette_2
    pipette_3
    */

    public void indtEnter(int m_name_sc, Collider m_gmobj, GameObject color_obj, GameObject color_obj_2)
    {
        switch (m_name_sc)
        {
            case 1:
                if (m_gmobj.tag == "pipette_1")
                {
                    color_obj.SetActive(false);
                    color_obj_2.SetActive(true);
                }
                break;
            case 2:
                if (m_gmobj.tag == "pipette_2")
                {
                    color_obj.SetActive(false);
                    color_obj_2.SetActive(true);
                }
                break;
            case 3:
                if (m_gmobj.tag == "pipette_3")
                {
                    color_obj.SetActive(false);
                    color_obj_2.SetActive(true);
                }
                break;
            case 4:
                if (m_gmobj.tag == "pipette_1")
                {
                    color_obj.SetActive(false);
                    color_obj_2.SetActive(true);
                }
                break;
            case 5:
                if (m_gmobj.tag == "pipette_2")
                {
                    color_obj.SetActive(false);
                    color_obj_2.SetActive(true);
                }
                break;
            case 6:
                if (m_gmobj.tag == "pipette_3")
                {
                    color_obj.SetActive(false);
                    color_obj_2.SetActive(true);
                }
                break;
            case 7:
                if (m_gmobj.tag == "pipette_1")
                {
                    color_obj.SetActive(false);
                    color_obj_2.SetActive(true);
                }
                break;
            case 8:
                if (m_gmobj.tag == "pipette_2")
                {
                    color_obj.SetActive(false);
                    color_obj_2.SetActive(true);
                }
                break;
            case 9:
                if (m_gmobj.tag == "pipette_3")
                {
                    color_obj.SetActive(false);
                    color_obj_2.SetActive(true);
                }
                break;
            default:
                Debug.Log("None");
                break;
        }
    }
    public void indtExit(int m_name_sc, Collider m_gmobj, GameObject color_obj, GameObject color_obj_2)
    {
        //Debug.Log("Exit: " + m_gmobj);
    }
}
