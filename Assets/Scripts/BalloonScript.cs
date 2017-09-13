using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonScript : MonoBehaviour {

   

    float speed = 5;
    float difficultyPercent;
    // Use this for initialization
	void Start () {
        difficultyPercent = 60;
    }
	
	// Update is called once per frame
	void Update () {
        
        transform.Translate(Vector3.up * speed * Time.deltaTime * GetDiffucultyPercent());
        if(transform.position.y > 7.0f)
        {
            Destroy(gameObject);
        }
	}

    float GetDiffucultyPercent()
    {
        return Mathf.Clamp01(Time.timeSinceLevelLoad / difficultyPercent) * 3;
    }

   
}
