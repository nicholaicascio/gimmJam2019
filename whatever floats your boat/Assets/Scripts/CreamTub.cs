using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CreamTub : MonoBehaviour
{
    public GameObject creamBall;
    public Camera cam;
    public string MyType;
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

        var screenPos = Input.mousePosition;
        screenPos.z = 1;
        var worldPos = cam.ScreenToWorldPoint(screenPos);
        GameObject newInstance = Instantiate(creamBall, worldPos, Quaternion.identity);
        CreamBall ball = newInstance.GetComponent<CreamBall>();
        ball.Type = MyType;
    }

}
