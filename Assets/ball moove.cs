using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmoov : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += this.transform.forward * speed * Time.deltaTime;
    }

    private void OnCollisionEnter (Collision collision)
    {
        print("collision "+ collision.gameObject.name);
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
    }
}
