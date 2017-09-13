using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickToDestroy : MonoBehaviour {

  
    
    private void OnMouseDown()
    {
        if (!TextScript.IsGameOver)
        {
            TextScript.count++;
        }
        AudioScript.IsPlay = true;
        Destroy(gameObject);
    }

    







}
