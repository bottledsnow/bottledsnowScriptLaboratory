using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1 : MonoBehaviour,IHealth
{
    [SerializeField]
    private int _health;
    [SerializeField]
    private int _defense;
    public int Health
    {
        get { return _health; }
        set { _health = value; }
    }

    public int Defense
    {
        get { return _defense; }
        set { _defense = value; }
    }

    public void TakeDamage(int Damage)
    {
        int FinalDamage = Damage - _defense;
        _health -= FinalDamage; 
    }

    private void Update()
    {
        CheckDeath();
    }
    private void CheckDeath()
    {
        if(_health <=0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
