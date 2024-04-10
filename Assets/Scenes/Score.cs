using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score instance;
    public float scoreAmount;
    
    void Start()
    {
        if (instance != null)
            Destroy(this);
        instance = this;
        GameObject.DontDestroyOnLoad(this.gameObject);
        Score.instance.scoreAmount++;
    }
}
