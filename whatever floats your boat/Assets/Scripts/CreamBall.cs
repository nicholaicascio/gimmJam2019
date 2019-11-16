using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreamBall : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject baby;
    public string Type;
    // Start is called before the first frame update
    void Start()
    {
        
        //this.transform.position.Set(this.transform.position.x, this.transform.position.y, -9.2f);
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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Mug")
        {
            FloatMug mug = collision.gameObject.GetComponent<FloatMug>();
            spawnPos = mug.spawnPos;
            var newBaby = Instantiate(baby, spawnPos);
            //newBaby.transform.localScale = Vector3.one;
            mug.ingredients.Add(Type);
            Destroy(this.gameObject);
        }
    }
}
