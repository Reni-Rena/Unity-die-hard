using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnenemie : MonoBehaviour
{
    public GameObject mob;
    public GameObject particle;
    public GameObject[] spawns;

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
            yield return new WaitForSeconds(2);
            
            Instantiate(particle, Instantiate(mob, spawns[UnityEngine.Random.Range(0, spawns.Length - 1)].transform.position, base.transform.rotation).transform.position, base.transform.rotation);
        }
    }
}
