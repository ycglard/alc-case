using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit
{
    private string type;

    public Fruit(string type)
    {
        this.type = type;
    }

    public string Type
    {
        get => type;
        set => type = value;
    }
}
