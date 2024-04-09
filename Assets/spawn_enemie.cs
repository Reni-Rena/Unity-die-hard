using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnenemie : MonoBehaviour
{
    public GameObject mob;
    public GameObject SP1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(mob, SP1.transform.position, base.transform.rotation);
        }
    }
}
