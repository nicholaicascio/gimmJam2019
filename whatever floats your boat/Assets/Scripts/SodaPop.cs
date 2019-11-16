using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SodaPop : MonoBehaviour
{
    public string SodaType = "null";
    public Material[] mats;
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
        //Debug.Log(other.gameObject.ToString());
        if(other.gameObject.tag == "Mug")
        {
            if(SodaType == "ROOT BEER")
            {
                SodaInsideMug ColaToEnable = other.GetComponentInChildren<SodaInsideMug>(includeInactive: true);
                //Debug.Log(ColaToEnable.gameObject.ToString());
                ColaToEnable.Type = SodaType;
                MeshRenderer mesh = ColaToEnable.GetComponent<MeshRenderer>();
                mesh.material = mats[0];
                //also set the material here to be the appropriate color
                ColaToEnable.gameObject.SetActive(true);
                FloatMug mug = other.gameObject.GetComponent<FloatMug>();
                mug.liquid = SodaType;
            }
            if (SodaType == "PEPTO")
            {
                SodaInsideMug ColaToEnable = other.GetComponentInChildren<SodaInsideMug>(includeInactive: true);
                //Debug.Log(ColaToEnable.gameObject.ToString());
                ColaToEnable.Type = SodaType;
                MeshRenderer mesh = ColaToEnable.GetComponent<MeshRenderer>();
                mesh.material = mats[1];
                //also set the material here to be the appropriate color
                ColaToEnable.gameObject.SetActive(true);
                FloatMug mug = other.gameObject.GetComponent<FloatMug>();
                mug.liquid = SodaType;
            }
            if (SodaType == "PEE PEE")
            {
                SodaInsideMug ColaToEnable = other.GetComponentInChildren<SodaInsideMug>(includeInactive: true);
                //Debug.Log(ColaToEnable.gameObject.ToString());
                ColaToEnable.Type = SodaType;
                MeshRenderer mesh = ColaToEnable.GetComponent<MeshRenderer>();
                mesh.material = mats[2];
                //also set the material here to be the appropriate color
                ColaToEnable.gameObject.SetActive(true);
                FloatMug mug = other.gameObject.GetComponent<FloatMug>();
                mug.liquid = SodaType;
            }
        }
    }
}
