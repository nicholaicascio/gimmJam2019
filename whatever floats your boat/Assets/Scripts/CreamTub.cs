using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CreamTub : MonoBehaviour
{
    private float mZCoord;
    public GameObject creamBall;
    public Camera cam;
    GameObject newInstance;
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
        Debug.Log("Ice Cream");

        //ExecuteEvents.Execute(button.gameObject, pointer, ExecuteEvents.pointerEnterHandler);

        var screenPos = Input.mousePosition;
        screenPos.z = 1;
        var worldPos = cam.ScreenToWorldPoint(screenPos);
        newInstance = Instantiate(creamBall, worldPos, Quaternion.identity);
    }

    private Vector3 GetMouseAsWorldPoint()

    {

        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;

        // z coordinate of game object on screen
        mousePoint.z = mZCoord;

        // Convert it to world points
        return Camera.main.ScreenToWorldPoint(mousePoint);

    }
}
