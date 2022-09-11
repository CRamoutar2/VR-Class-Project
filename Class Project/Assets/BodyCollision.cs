using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyCollision : MonoBehaviour
{

    public Transform head;
    public Transform feet;
    //public Transform Ignore;


    // Start is called before the first frame update
    void Start()
    {
        //Physics.IgnoreCollision(Ignore.GetComponent<Collider>(), GetComponent<Collider>());
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(head.position.x, feet.position.y, head.position.z);
    }
}
