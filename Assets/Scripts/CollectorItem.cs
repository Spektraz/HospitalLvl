using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorItem : MonoBehaviour
{
    [SerializeField] private string ItemName;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Item name" + ItemName);
        Destroy(this.gameObject);
    }
}
