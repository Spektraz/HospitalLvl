using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviceTrigger : MonoBehaviour
{
    [SerializeField] private GameObject[] targets;
    public bool requireKey;

    void OnTriggerEnter(Collider other)
    {
        if (requireKey && Managers.Inventiry.equippedItem != "Key")
        {
            return;
        }
        foreach (GameObject target in targets)
            target.SendMessage("Activate");
    }
}