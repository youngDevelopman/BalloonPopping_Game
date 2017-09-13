using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour   {

    //public static TextScript textController = new TextScript();
    public Text countText;
    public static int count = 0;
    public static bool IsGameOver = false;

    void Update()
    {
        countText.text = "Score: " + count.ToString();
    }
    
}
