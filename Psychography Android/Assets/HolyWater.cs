using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HolyWater : MonoBehaviour
{
    public bool water;


    [SerializeField] public Image img;
    // Start is called before the first frame update
    void Start()
    {      
        water = false;
        img.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonPress()
    {
        if (water == false)
        {
            water = true;
            img.enabled = true;
        }
        else
        {
            water = false;
            img.enabled = false;
        }

       
    }

}
