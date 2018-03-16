using System.Collections;
using System.Collections.Generic;
using System;

public class Ammo {

    int qtd = 10;

    public void Reload ()
    {
        qtd = 10;
    }

    public bool Use ()
    {
        if (qtd > 0)
        {
            qtd--;
            return true;
        }
        return false;
    }
}
