// 2018 - Author : Jefferson Scomacao - DI Pattern

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppElement<T> : MonoBehaviour where T : class, new (){

    public virtual void Initialize()
    {
        DI.Instance.GetInstance<T>(false);
    }

	public virtual void Start () {
        Initialize();
	}
		
    public virtual T GetDI ()
    {
        return DI.Instance.GetInstance<T>(false);
    }


}
