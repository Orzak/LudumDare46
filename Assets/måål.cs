using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class måål : MonoBehaviour
{

    public GameObject player;
    spelController score;
    public LayerMask frendLager;

    void Start()
    {
        score = player.GetComponent<spelController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if ((1 << other.gameObject.layer & frendLager.value) != 0)
        {
            
           
                if (other.GetComponent<healt>().healtt > 0) {
                    score.levde += 1;
                    other.gameObject.SetActive(false);
                }
                else
                {
                    score.döda += 1;
                    other.gameObject.SetActive(false);
                }
            
            

        }

    }
}
