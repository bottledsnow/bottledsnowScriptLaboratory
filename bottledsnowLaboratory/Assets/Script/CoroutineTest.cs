using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(WaitToDoSomeThing());
    }
    private IEnumerator WaitToDoSomeThing()
    {
        yield return new WaitForSeconds(2);
        Debug.Log("2 Second Pass Away");
    }
}
