using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPackage : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        var Package = other.GetComponent<PackageBehaviour>();
        if (Package != null)
        {
            ScoreManager.instance.AddPoint();
            Destroy(other.gameObject);
        }
    }
}
