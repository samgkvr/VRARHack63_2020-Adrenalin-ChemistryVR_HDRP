using UnityEngine;
using System.Collections;

public class NitrogenSource : FluidSource {

	// Use this for initialization
	void Start () {
        Liquid nitrogen = ScriptableObject.CreateInstance<Liquid>(); //5, Color.white, LiquidType.Water);
        nitrogen.init(1, Color.red, LiquidType.Nitrogen);

        FluidSol solutions = ScriptableObject.CreateInstance<FluidSol>();
        solutions.addToSolution(nitrogen);


        solutiontoAdd = solutions;
    }

    // Update is called once per frame
    void Update () {
	
	}
}
