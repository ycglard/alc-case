using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int _speed;
    private string type;

    public Player(int speed, string type)
    {
        _speed = speed;
        this.type = type;
    }

    public int Speed
    {
        get => _speed;
        set => _speed = value;
    }

    public string Type
    {
        get => type;
        set => type = value;
    }
}
