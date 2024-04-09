using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class déplacement : MonoBehaviour
{
    public float speed;
    public GameObject game;
    private float rotate;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed += speed;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed /= 2;
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += this.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position -= this.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rotate -= 2;
            Vector3 newRotation = new Vector3(0, rotate, 0);
            this.transform.eulerAngles = newRotation;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rotate += 2;
            Vector3 newRotation = new Vector3(0, rotate, 0);
            this.transform.eulerAngles = newRotation;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(game, this.transform.position, base.transform.rotation);
        }

    }
}
