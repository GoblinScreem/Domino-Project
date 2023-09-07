using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTargetFalse : MonoBehaviour
{
    public List<string> tags;
    public GameObject target;

    private void OnTriggerEnter(Collider other)
    {
        if (tags.Contains(other.gameObject.tag))
        {
            target.SetActive(false);
        }
    }
}
