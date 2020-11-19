using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody mrigid;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        mrigid = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        this.mrigid.AddForce(new Vector3(0, 0.1f, 0.1f));
    }

}
