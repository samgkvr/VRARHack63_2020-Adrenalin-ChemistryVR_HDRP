using UnityEngine;

public class ChangeFire : MonoBehaviour
{
    [SerializeField] private ParticleSystem main; //управление частицами
    [SerializeField] private GameObject m_main; //управление обьектом
    private bool main_active;
    private bool main_cap;

    // Start is called before the first frame update
    void Start()
    {
        //main = GetComponent<ParticleSystem>();
        //main.startColor = Color.blue;
        m_main.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Li+")
        {
            main.startColor = new Color(0.9058824F, 0.3294118F, 0.5019608F, 1.0F);
        }
        if (other.tag == "Na+")
        {
            main.startColor = Color.yellow;
        }
        if (other.tag == "K+")
        {
            main.startColor = new Color(0.5019608F, 0F, 0.5019608F, 1.0F);
        }
        if (other.tag == "Rb+")
        {
            main.startColor = Color.red;
        }
        if (other.tag == "Cs+")
        {
            main.startColor = new Color(0F, 0.7490196F, 0F, 1.0F);
        }
        if (other.tag == "Cap")
        {
            if (main_active)
            {
                m_main.SetActive(false);
            }
            main_cap = true;
        }
        else
        {

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Cap")
        {
            if (main_active)
            {
                m_main.SetActive(true);
            }
            main_cap = false;
        }
    }

    public void active_stand()
    {
        if (main_active)
            main_active = false;
        else
            main_active = true;

        if (main_active && !main_cap)
            m_main.SetActive(true);
        else
            m_main.SetActive(false);
    }
}
