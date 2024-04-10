using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class UImanager : MonoBehaviour
{


    public Image HPbar;
    public TextMeshProUGUI hpText;

    [Range(0f,100f)]
    public float hp;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ChangehealthBar(float value, float maxValue)
    {
        HPbar.fillAmount = value/maxValue;
        HPbar.color = new Color(Mathf.Clamp((1 - value / maxValue), 0, 1), Mathf.Clamp((value / maxValue), 0, 1), 0, 1f);
        hpText.text = "Health :"+value.ToString();
    }

}
