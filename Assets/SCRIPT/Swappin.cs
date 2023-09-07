using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swappin : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;

    private void Start()
    {
        Debug.Log("Name " + gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("SLAB"))
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
    }

    private void Update()
    {

    }
}
