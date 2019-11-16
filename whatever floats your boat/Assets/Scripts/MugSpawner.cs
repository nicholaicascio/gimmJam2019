using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MugSpawner : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exit");
    }
}
