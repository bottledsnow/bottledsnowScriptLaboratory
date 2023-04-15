using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceGameManager : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(rayOrigin,out hitInfo))
            {
                IDamagable damagableObj = hitInfo.collider.GetComponent<IDamagable>();
                if(damagableObj != null)
                {
                    damagableObj.Damage(20);
                }
            }
        }
    }
}
