using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followTowerSlow : MonoBehaviour

{

    public enum Mode
    {
        First,
        Closest,
        Lowest
    }


    public Mode mode;
    private float timer;
    public float cooldown = 5f;
    public float radie = 10f;
    public float Ofset = -1f;
    private healt target;

    UnityEngine.AI.NavMeshAgent agent;
    towerareaslow tower;


    // Use this for initialization
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        tower = GetComponentInParent<towerareaslow>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (mode)
        {
            case Mode.First:
                target = tower.GetTarget();
                break;
            case Mode.Closest:
                if (target)
                {
                    if (timer < 0)
                    {
                        target = tower.GetClosestTarget();
                        timer += cooldown;
                    }
                    timer -= Time.deltaTime;
                }
                else
                {
                    target = tower.GetClosestTarget();
                    if (target)
                    {
                        timer = cooldown;
                    }
                }
                break;
            case Mode.Lowest:
                if (target)
                {
                    if (timer < 0)
                    {
                        target = tower.GetLowestHealtTarget();
                        timer += cooldown;
                    }
                    timer -= Time.deltaTime;
                }
                else
                {
                    target = tower.GetLowestHealtTarget();
                    if (target)
                    {
                        timer = cooldown;
                    }
                }
                break;
        }

        if (target)
        {
            agent.isStopped = false;
            agent.SetDestination(target.transform.position);
            if (Vector3.SqrMagnitude(transform.position - target.transform.position) < radie * radie)
            {

                if (target.speedOfset > -0.5)
                {
                    target.speedOfset = Ofset;
                }
            }
            else if (Vector3.SqrMagnitude(transform.position - target.transform.position) > radie * radie && Vector3.SqrMagnitude(transform.position - target.transform.position) < (radie+2) * (radie+2))
            {
                target.speedOfset = 0; 
            }

        }
        else
        {
            agent.isStopped = true;
        }

    }
}
