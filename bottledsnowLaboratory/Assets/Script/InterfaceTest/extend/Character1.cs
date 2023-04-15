using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character1 : MonoBehaviour,IDamagable2
{
    [SerializeField]
    private int _Damage = 10;
    public int Damage
    {
        get { return _Damage; }
        set { _Damage = value; }
    }
}
