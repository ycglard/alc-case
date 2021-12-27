using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitController : MonoBehaviour
{
    [SerializeField]private string type;
    private Fruit _fruit;
    private void Start()
    {
        _fruit = new Fruit(type);
    }

    public Fruit getFruit()
    {
        return _fruit;
    }

}
