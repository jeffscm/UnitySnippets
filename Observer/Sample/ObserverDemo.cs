// 2018 - Author : Jefferson Scomacao - Observer Pattern

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverDemo : MonoBehaviour {

    Observer<float> test;

	// Use this for initialization
	void Start () 
    {
        
        test = new Observer<float>(0, true).OnChange(
            (f) =>
            {

                Debug.Log("Value Changed: " + f);

            }
        );

        test.Value = 1f;
	}
	
	// Update is called once per frame
	void Update () 
    {
		if (test.Value < 10f)
        {
            test.Value += 0.75f;
        }
	}
}
