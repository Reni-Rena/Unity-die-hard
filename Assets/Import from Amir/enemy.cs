using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.ParticleSystem;

public class enemy : MonoBehaviour
{
    public int AmountHealth;
    public float MaxHealth;
    public Canvas CanvasEnemy;
    
    NavMeshAgent Agent;
    public GameObject Player;
    public GameObject DeathParticle;
    void Start()
    {
        Agent = gameObject.GetComponent<NavMeshAgent>();
        CanvasEnemy.GetComponent<HealthEnemy>().ChangehealthBar(AmountHealth, MaxHealth);
        Player = GameObject.FindGameObjectWithTag("Player");
        
    }

    
    void Update()
    {
        Agent.SetDestination(Player.transform.position);
    }

    public void TakeDamage(int value)
    {
        AmountHealth -= value;
        CanvasEnemy.GetComponent<HealthEnemy>().ChangehealthBar(AmountHealth, MaxHealth);
        if (AmountHealth <= 0 )
        {
            Instantiate(DeathParticle, this.transform.position, base.transform.rotation);
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
         {
            if (collision.gameObject.tag == "Player")
            {
                 collision.gameObject.GetComponent<Health>().TakeDamage(10);
                 
                Instantiate(DeathParticle, this.transform.position, base.transform.rotation);
                Destroy(this.gameObject);
            }
        }
    }
