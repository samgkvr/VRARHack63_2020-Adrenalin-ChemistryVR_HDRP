using UnityEngine;

public class substance : MonoBehaviour
{
    [SerializeField] private sc_Indicators m_sc_Indicators;
    [SerializeField] private int name_sc;

    private void Start()
    {
        if (name_sc == 0 || m_sc_Indicators == null)
        {
            Debug.Log("Не настроен substance");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        m_sc_Indicators.indtEnter(name_sc, other);
    }
    private void OnTriggerExit(Collider other)
    {
        m_sc_Indicators.indtExit(name_sc, other);
    }
}
