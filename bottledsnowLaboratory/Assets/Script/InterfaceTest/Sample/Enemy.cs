using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour,IDamagable
{
    private int _health = 200;
    public int Health
    {
        get { return _health; }
        set { _health = value; } 
    }

    public void Damage(int damageAmount)
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
        _health -= damageAmount;
        if (_health < 0) _health = 0;
        Debug.Log("Enemy takes" + damageAmount + "damage! Remaining health is :" + _health);
    }
}
