using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnenemie : MonoBehaviour
{
    public GameObject mob;
    public GameObject particle;
    public GameObject[] spawns;
    public float delay = 2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            if(delay >= 0.5)
            {
                delay -= 0.1f;
            }
            
            
            Instantiate(particle, Instantiate(mob, spawns[UnityEngine.Random.Range(0, spawns.Length - 1)].transform.position, base.transform.rotation).transform.position, base.transform.rotation);
        }
    }
}
