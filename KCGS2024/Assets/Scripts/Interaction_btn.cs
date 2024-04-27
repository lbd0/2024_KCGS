using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Button Interaction

public class Interaction_btn : MonoBehaviour
{
    public GameManager gameManager;

    public GameObject power;        // Power Button
    public GameObject up;           // UP Button
    public GameObject down;         // Down Button
    public TextMeshProUGUI temp;    // temperature display

    private bool isOn = false;      // On/Off flag
    private int temperature = 0;    // initial temperature

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

                gameManager.changeText("하이라이터의 전원이 켜졌습니다.\n+버튼을 터치하여 불의 세기를 3으로 하세요.");

            } else     // when it's on
            {
                isOn = false;  // off
                temp.text = "H";   // Show hotness

                gameManager.changeText("하이라이터의 전원이 꺼졌습니다.\n아직 뜨거우니 조심하세요.");
            }
        } else if(other.gameObject == up)  // when you select the up button
        {
            if(isOn) // when it's on
            {
                if(temperature < 5)  // temperature below 5
                {
                    temperature += 1;       // up temperature
                } 
                temp.text = temperature.ToString();

                if(temperature == 3)
                {
                    gameManager.changeText("이제 후라이팬에 기름을 두르세요.");
                }
            }
        } else if(other.gameObject == down)  // when you select the down button
        {
            if(isOn)        // when it's on
            {
                if (temperature > 0)    // temperature above 0
                {
                    temperature -= 1;   // down temperature
                }
                temp.text = temperature.ToString();
            }
        }
    }
}
