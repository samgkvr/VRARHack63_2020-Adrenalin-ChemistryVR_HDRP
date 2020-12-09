using UnityEngine;

public class ChangeFire : MonoBehaviour
{
    public ParticleSystem main; //управление частицами
    public GameObject m_main; //управление обьектом
    public bool main_active;
    public bool main_cap;

    // Start is called before the first frame update
    void Start()
    {
        //main = GetComponent<ParticleSystem>();
        //main.startColor = Color.blue;
        m_main.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Li+")
        {
            main.startColor = Color.black;
        }
        if (other.tag == "Na+")
        {
            main.startColor = Color.yellow;
        }
        if (other.tag == "K+")
        {
            main.startColor = Color.magenta;
        }
        if (other.tag == "Rb+")
        {
            main.startColor = Color.red;
        }
        if (other.tag == "Cs+")
        {
            main.startColor = Color.cyan;
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
