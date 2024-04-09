using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    public int AmountHealth;
    NavMeshAgent Agent;
    public GameObject Player;
    void Start()
    {
        Agent = gameObject.GetComponent<NavMeshAgent>();

        Player = GameObject.FindGameObjectWithTag("Player");
        
    }

    
    void Update()
    {
        Agent.SetDestination(Player.transform.position);
    }

    public void TakeDamage(int value)
    {
        AmountHealth -= value;
        if(AmountHealth <= 0 )
        {
            Destroy(this.gameObject);
        }
    }

}
