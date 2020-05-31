using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampMove : MonoBehaviour
{
    [SerializeField] private GameObject DarkLamp;
    [SerializeField] private Animator animator;
    [SerializeField] private int IPLight;
    // [SerializeField] private AnimationEvent animation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetInteger("Lampid", IPLight);
        animator.GetInteger(IPLight);
    }
    public void LampTrue()
    {
        DarkLamp.SetActive(true);
    }
    public void LampFalse()
    {
        DarkLamp.SetActive(false);
    }
}
