using System.Collections;
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
        //Debug.Log(other.gameObject.ToString());
        if(other.gameObject.tag == "Mug")
        {
            if(SodaType == "Cola")
            {
                SodaInsideMug ColaToEnable = other.GetComponentInChildren<SodaInsideMug>(includeInactive: true);
                //Debug.Log(ColaToEnable.gameObject.ToString());
                ColaToEnable.Type = "Cola";
                //also set the material here to be the appropriate color
                ColaToEnable.gameObject.SetActive(true);
                FloatMug mug = other.gameObject.GetComponent<FloatMug>();
                mug.ingredients.Add(ColaToEnable.gameObject);
            }
        }
    }
}
