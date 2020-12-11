using UnityEngine;

public class substance : MonoBehaviour
{
    [SerializeField] private sc_Indicators m_sc_Indicators;
    [SerializeField] private int name_sc;

    [SerializeField] private GameObject change_color;
    [SerializeField] private GameObject change_color_2;

    private void Start()
    {
        if (name_sc == 0 || m_sc_Indicators == null)
        {
            Debug.Log("Не настроен substance");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        m_sc_Indicators.indtEnter(name_sc, other, change_color, change_color_2);
    }
    private void OnTriggerExit(Collider other)
    {
        m_sc_Indicators.indtExit(name_sc, other, change_color, change_color_2);
    }
}
