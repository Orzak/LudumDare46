using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class valueFolloving : MonoBehaviour {
    spelController value;
    public GameObject player;
    Text instruction;
    // Use this for initialization
    void Start () {
		value = player.GetComponent<spelController>();
        
        instruction = transform.GetChild(0).transform.GetChild(0).GetComponentInChildren<Text>();
       
        }
	
	// Update is called once per frame
	void Update () {
        instruction.text = "Round : "+value.runda+"/"+value.rundamax +"\n" + "Workers : " +value.slavvar + "\n" + "Saved : " + value.levde + "/" + value.frendAmount + "\n"+"Dead : " + value.döda + "/" + value.dödaMax + "\n";
        if (value.runda>value.rundamax)
        {
            transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(true);
        }
        else if(value.döda > value.dödaMax)
        {
            transform.GetChild(0).transform.GetChild(2).gameObject.SetActive(true);
        }

    }
}
