using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationm : MonoBehaviour {

    public GameObject modelA;
    public GameObject modelB;
    
    public int duration;

    private int modelNumber;


    void Start()
    {
        modelNumber = 1;
        modelA.SetActive(true);
        modelB.SetActive(false);
    }

    void FixedUpdate()
    {
        modelNumber += 1;
        if (modelNumber == (duration)/2)
        {
            modelA.SetActive(false);
            modelB.SetActive(true);
            
        }
        else if (modelNumber == duration)
        {
            modelB.SetActive(false);
            modelA.SetActive(true);
            modelNumber = 0; 


        }
    }

   
    }