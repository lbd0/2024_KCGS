using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Button Interaction

public class Interaction_btn : MonoBehaviour
{
    public GameObject power;        // Power Button
    public GameObject up;           // UP Button
    public GameObject down;         // Down Button
    public TextMeshProUGUI temp;    // temperature display

    private bool isOn = false;      // On/Off flag
    private int temperature = 1;    // initial temperature

    // Start is called before the first frame update
    void Start()
    {
        temp.text = "";         // Reset temperature display
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject == power)   // when you select the power button
        {
            if(!isOn)   // when it's off
            {
                isOn = true;   // on
                temp.text = temperature.ToString();  // temperature display

            } else     // when it's on
            {
                isOn = false;  // off
                temp.text = "H";   // Show hotness
            }
        } else if(other.gameObject == up)  // when you select the up button
        {
            if(isOn) // when it's on
            {
                if(temperature < 9)  // temperature below 9
                {
                    temperature += 1;       // up temperature
                } 
                temp.text = temperature.ToString();
            }
        } else if(other.gameObject == down)  // when you select the down button
        {
            if(isOn)        // when it's on
            {
                if (temperature > 1)    // temperature above 1
                {
                    temperature -= 1;   // down temperature
                }
                temp.text = temperature.ToString();
            }
        }
    }
}
