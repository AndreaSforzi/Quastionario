using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mace : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(GetComponentInParent<Transform>().forward * 500);
        }
    }
}
