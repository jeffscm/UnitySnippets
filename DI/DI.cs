// 2018 - Author : Jefferson Scomacao - DI Pattern

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class DI
{

    static DI _instance;
    public static DI Instance
    {
        get
        {
            if (_instance == null)
            {

                _instance = new DI();

            }
            return _instance;
        }
    }

    List<object> list = new List<object>();

    public T1 GetInstance<T1>(bool createNew = true)
    {

        if (!createNew)
        {
            var temp = list.FirstOrDefault(t => t.GetType() == typeof(T1));

            if (temp != null)
            {
                return (T1)temp;
            }
        }
       
        var tempNew = Activator.CreateInstance<T1>();

        list.Add(tempNew);

        return tempNew;
    }



}
