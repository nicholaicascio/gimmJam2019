using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreamBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position.Set(this.transform.position.x, this.transform.position.y, -9.2f);
    }

    private void OnMouseDown()
    {
        if (!this.GetComponent<Rigidbody>())
        {
            this.gameObject.AddComponent<Rigidbody>();
            Rigidbody rig = this.GetComponent<Rigidbody>();
            rig.drag = 5;
            rig.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        }
        
    }
}
