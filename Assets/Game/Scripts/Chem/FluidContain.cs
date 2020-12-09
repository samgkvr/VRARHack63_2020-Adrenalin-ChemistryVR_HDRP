using UnityEngine;
using System.Collections;

public class FluidContain : MonoBehaviour
{


    public float maxAmount=100;
    //public float currentAmount;

    public FluidSol fluidsolution;

    //When pouring out, this will be instantiated to do the pouring.
    public GameObject liquidSourcePrefab;

    //A visible water object for when there's stuff in this holder.
    public GameObject waterObject;

    public GameObject sourceSpawnObject;

    public Vector3 start = new Vector3(0.0f, 0.0f, 0.0f);
    public Vector3 end = new Vector3(0.0f, 1.0f, 0.0f);

    // Use this for initialization
    void Start()
    {
        fluidsolution = ScriptableObject.CreateInstance<FluidSol>();

        updateWaterImage();
         
        //public void addToSolution(FluidSol other)
    //{
      //  fluidsolution.addToSolution(other);

        //Debug.Log((solution.currentAmount / maxAmount));
        //waterObject.transform.localPosition = Vector3.Lerp(start, end, (solution.currentAmount / maxAmount));
        //updateWaterImage();

        //Update color.
        Renderer rend = waterObject.GetComponent<Renderer>();
        rend.material.shader = Shader.Find("FX/Water");
        rend.material.SetColor("_RefrColor", fluidsolution.getColor());
    //}
    
}

    // Update is called once per frame
    void Update()
    {
        //If tilted, then pour portion of liquid out based on percentage.

        float xAngle = transform.rotation.eulerAngles.x;
        float zAngle = transform.rotation.eulerAngles.z;

        //Normalize angles to 0-180 range. Neg doesn't matter
        if (xAngle > 180)
        {
            xAngle = Mathf.Abs(xAngle - 360);
        }

        //Normalize angles to 0-180 range. Neg doesn't matter
        if (zAngle > 180)
        {
            zAngle = Mathf.Abs(zAngle - 360);
        }

        float largestAngle = Mathf.Max(xAngle, zAngle);

        //What percent of the liquid can we hold?
        float holdPercent = Mathf.Clamp((90 - largestAngle) / 90, 0f, 1f);

        //If we spilled some liquid spawn particles and a hitbox to catch!
        if ((fluidsolution.getAmount() / maxAmount - holdPercent) > .01f)
        {
            float previousAmount = fluidsolution.getAmount();

            float newAmount = fluidsolution.getAmount();

            //Clamp the actual amount to be between 0 and the rotated amount
            newAmount = Mathf.Clamp(fluidsolution.getAmount(), 0f, holdPercent * maxAmount);

            float newProportion = newAmount / maxAmount;

            Debug.Log(newAmount);

            //The proportion lost.
            //float differenceProportion = (previousAmount -newAmount) / maxAmount;

            //Debug.Log(differenceProportion); 

            //If went to infinity, make zero.
            /*if (differenceProportion > 1f)
            {
                differenceProportion = 0;
            }*/

            //The actual amount lost.
            float differenceAmount = previousAmount - newAmount;

            Vector3 spawnPos = sourceSpawnObject.GetComponent<Collider>().bounds.min;//transform.position + new Vector3(0,3 ,0);

            // Debug.Log(spawnPos);

            //Vector3 spawnPos = transform.position + new Vector3(0,3 ,0);

            //This source adds the liquid to containers below. Note, can add more accurate positioning, i.e. corner of container. 

            GameObject source = (GameObject)Instantiate(liquidSourcePrefab, spawnPos, Quaternion.identity);

            //The source will add the same solution, but different proportions, in fact the exact amount that was lost.
            FluidSol newsolution = ScriptableObject.CreateInstance<FluidSol>();
            newsolution.init(fluidsolution);

            source.GetComponent<FluidSource>().solutiontoAdd = newsolution;
            source.GetComponent<FluidSource>().solutiontoAdd.multiplyByFactor(1 - newProportion);
            source.GetComponent<FluidSource>().creator = this;

            //Finally, for this container, decrease the amount of solution available.
            fluidsolution.multiplyByFactor(newProportion);
            Debug.Log(fluidsolution.getAmount());
            updateWaterImage();


            /*waterObject.transform.localPosition = Vector3.Lerp(start, end, (solution.currentAmount / maxAmount));
            
            if (solution.currentAmount == 0)
            {
                waterObject.SetActive(false);
            }

            else
            {
                waterObject.SetActive(true);

            }*/
            // Debug.Log(holdPercent);
        }

    }

    public void addToSolution(FluidSol other)
    {
        fluidsolution.addToSolution(other);

        //Debug.Log((solution.currentAmount / maxAmount));
        //waterObject.transform.localPosition = Vector3.Lerp(start, end, (solution.currentAmount / maxAmount));
        updateWaterImage();

        //Update color.
        Renderer rend = waterObject.GetComponent<Renderer>();
        rend.material.shader = Shader.Find("FX/Water");
        rend.material.SetColor("_RefrColor", fluidsolution.getColor());
    }

    public void changeLevel(float deltaLevel)
    {
        float differenceProportion = 1 / maxAmount;

        fluidsolution.multiplyByFactor(1 - differenceProportion);

        //solution.currentAmount += deltaLevel;

        //Debug.Log("rota" + (solution.currentAmount / maxAmount));
        //waterObject.transform.localPosition = Vector3.Lerp(start, end, (solution.currentAmount / maxAmount));
        updateWaterImage();
    }


    //changed

    private void updateWaterImage()
    {
        waterObject.transform.localPosition = Vector3.Lerp(start, end, (fluidsolution.getAmount() / maxAmount));

        if (maxAmount == 100)
        {
            waterObject.SetActive(true);
        }

        else
        {
            waterObject.SetActive(false);

        }
    }
}
