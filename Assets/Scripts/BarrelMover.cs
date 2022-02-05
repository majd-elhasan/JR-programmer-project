using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelMover : MonoBehaviour
{
    [SerializeField]float rotate;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotate = Input.GetAxis("SecondHor");
        transform.Rotate(rotate * Time.deltaTime * 15, 0, 0);
    }
}
