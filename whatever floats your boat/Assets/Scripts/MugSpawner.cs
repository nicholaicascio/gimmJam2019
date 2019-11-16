using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MugSpawner : MonoBehaviour
{
    public GameObject mug;
    public Transform spawnPos;
    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("exit");
        var newMug = Instantiate(mug);
        newMug.transform.position = spawnPos.position;
        //newMug.transform.localScale = Vector3.one;
    }
}
