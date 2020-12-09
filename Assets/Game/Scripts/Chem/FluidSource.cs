using UnityEngine;
using System.Collections;

public class FluidSource : MonoBehaviour {

  public FluidSol solutiontoAdd;

  public FluidContain creator;

  // Use this for initialization
  void Start() {

  }

  // Update is called once per frame
  void Update() {

  }

  void OnTriggerEnter(Collider other) {
    FluidContain holder = other.GetComponent<FluidContain>();
    if(holder != null) {

      if(holder != creator) {
        other.GetComponent<FluidContain>().addToSolution(solutiontoAdd);
        Destroy(this.gameObject);
      }
    }

    else if (!other.GetComponent<Collider>().isTrigger)
    {
      Destroy(this.gameObject);
    }

  }

}
