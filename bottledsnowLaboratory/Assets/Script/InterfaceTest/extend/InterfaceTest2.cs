using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceTest2 : MonoBehaviour,IDamagable2
{
    private int _Damage = 10;
    [SerializeField]
    private GameObject character;
    public int Damage
    {
        get { return _Damage; }
        set { _Damage = value; }
    }

    private void Update()
    {
        InterfaceTest();
    }
    
    private void InterfaceTest()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Attake Character");
            IDamagable2 IDama2 = character.GetComponent<IDamagable2>();
            IDama2.Damage += 10;
            Debug.Log("Character Damage=" + IDama2.Damage);
        }
    }
}

public interface IDamagable2
{
    int Damage { get; set; }
}
