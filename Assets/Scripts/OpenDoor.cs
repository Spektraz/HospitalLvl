using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    //[SerializeField] private Vector3 dPos;
    [SerializeField] private Animator animator;
    [SerializeField] private int IPDoor;
    private bool _open;
    private void Update()
    {
        if (Input.GetKey(KeyCode.F)) {
            animator.SetInteger("Side", IPDoor);
            animator.GetInteger(IPDoor);
            StartCoroutine(enumerator());
        }
    }
    IEnumerator enumerator()
    {
        yield return new WaitForSeconds(2.2f);
        animator.enabled = false;
    }
}
