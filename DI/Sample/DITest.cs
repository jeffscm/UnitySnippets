// 2018 - Author : Jefferson Scomacao - DI Pattern

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DITest : AppElement<Ammo> {


    public override void Start()
    {
        base.Start();

        GetDI().Reload();
    }

	void Update () {
		
        if (GetDI().Use())
        {
            Debug.Log("Fire weapon");
        }
        else
        {
            Debug.Log("Empty Ammo, reload");
            GetDI().Reload();
        }
	}
}
