using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionFactory1 : IFactory {

    public void ExecuteAction()
    {
        Debug.Log("Execute Action");
    }
}
