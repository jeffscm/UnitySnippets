// 2018 - Author : Jefferson Scomacao - FactoryPattern

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactorySample : MonoBehaviour {


    Factory<IFactory> f = new Factory<IFactory>();

	// Use this for initialization
	void Start () {

        var temp = f.CreateNew<ActionFactory1>();

        temp.ExecuteAction();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
