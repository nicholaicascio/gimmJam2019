using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkButton : MonoBehaviour
{
    public BoxCollider drinktable;
    public GameObject sodaStream;
    private bool sodaOn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.ToString());
    }

    private void OnMouseDown()
    {
        if(!sodaOn)
        {
            sodaStream.gameObject.SetActive(true);
            sodaOn = true;
        }
        else
        {
            sodaStream.gameObject.SetActive(false);
            sodaOn = false;
        }

        //Debug.Log("Soda");
    }
}
