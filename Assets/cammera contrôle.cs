using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cammeracontrôle : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        offset = this.transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.transform.position + offset;
    }
}
