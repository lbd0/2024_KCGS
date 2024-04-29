using Oculus.Interaction.Samples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text recipe;

    // Start is called before the first frame update
    void Start()
    {
        changeText("야채를 씻어보세요.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeText(string text) { recipe.text = text; }

}
