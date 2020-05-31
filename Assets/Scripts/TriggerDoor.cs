using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    [SerializeField] private Vector3 dPos;
    [SerializeField] private GameObject Floor;
    private GameObject Floor10;
    // Use this for initialization

    private bool _open;

    //  public void Operate(){
    //    if (_open) {
    //      Vector3 pos = transform.position - dPos;
    //      transform.position = pos;
    //      Destroy(Instantiate (Floor10, transform.position, Quaternion.identity));
    //
    //
    //    } else {
    //      Vector3 pos = transform.position + dPos;
    //      transform.position = pos;
    //
    //    }
    //    _open = !_open;

    //  }
    public void Activate()
    {
        if (!_open)
        {
            Vector3 pos = transform.position + dPos;
            transform.position = pos;
            _open = true;
        }
    }
}