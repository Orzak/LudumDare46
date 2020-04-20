using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healt : MonoBehaviour {

    public float maxHealt;
    public float healtt;
    public float damage;
    public float speedOfset;
    public float speed;
    UnityEngine.AI.NavMeshAgent agent;
    public Image healtBar;
    public Image healtBar2;

    // Use this for initialization
    void Start () {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        healtt = maxHealt;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        agent.speed = speed + speedOfset;
        if (healtt > 0){
            healtt = healtt - (damage*Time.deltaTime);
            speedOfset = 0;
        }
        else
        {

            healtt = -100;
            this.transform.position = this.GetComponent<followSkript>().target.transform.position;


        }
        healtBar.fillAmount = healtt / maxHealt;
        healtBar2.fillAmount = healtt / maxHealt;

    }
    
}
