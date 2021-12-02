using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    Transform ObjToShake;


    void Update()
    {

        var randNrX = Random.Range((float)0.7, (float)-0.7);
        var randNrY = Random.Range((float)0.7, (float)-0.7);
        var randNrZ = Random.Range((float)0.7, (float)-0.7);
        ObjToShake.transform.position += Vector3(randNrX, randNrY, randNrZ);

    }

    private Vector3 Vector3(float randNrX, float randNrY, float randNrZ)
    {
        throw new System.NotImplementedException();
    }
}
