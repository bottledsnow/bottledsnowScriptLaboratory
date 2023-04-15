using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour,IDamagable
{
    private int _health = 100;
    public int Health
    {
        get { return _health; }
        set { _health = value; }
    }

    public void Damage(int DamageAmount)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
        _health -= DamageAmount;
        if (_health < 0) _health = 0;
        Debug.Log("Player take " + DamageAmount + "Damage! Remaining health is" + _health);
    }
}
