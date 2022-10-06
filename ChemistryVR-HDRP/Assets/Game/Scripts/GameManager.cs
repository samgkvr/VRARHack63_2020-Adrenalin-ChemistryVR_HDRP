using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject xsad;
    [SerializeField] private ParticleSystem trailPartical;

    // Start is called before the first frame update
    void Start()
    {
        ParticleSystem.MainModule main = GetComponent<ParticleSystem>().main;
        main.startColor = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
