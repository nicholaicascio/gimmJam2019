﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SodaPop : MonoBehaviour
{
    public string SodaType = "null";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.ToString());
    }
}
