using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public GameObject particle;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
        
        Destroy(this.gameObject,10f);
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position += this.transform.forward * speed * Time.deltaTime;
            
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        print("collision : " + collision.gameObject.name);

        if(collision.gameObject.tag == "Wall")
        {
            Instantiate(particle, this.transform.position, base.transform.rotation);
            Destroy(this.gameObject);
            
        }

        if(collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<enemy>().TakeDamage(10);
            Instantiate(particle, this.transform.position, base.transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
