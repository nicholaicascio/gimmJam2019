using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CreamTub : MonoBehaviour
{
    public GameObject creamBall;
    //public Camera cam;
    public string MyType;
    public Transform spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //Debug.Log("Ice Cream");

        //ExecuteEvents.Execute(button.gameObject, pointer, ExecuteEvents.pointerEnterHandler);

        
        GameObject newInstance = Instantiate(creamBall, spawnPos.position, Quaternion.identity);
        newInstance.transform.Rotate(-90, 0, 0);
        //newInstance.transform.localScale
        //CreamBall ball = newInstance.GetComponent<CreamBall>();
        //ball.Type = MyType;
    }

}
