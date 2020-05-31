using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroLogic : MonoBehaviour
{
    [SerializeField] private int HP;
    [SerializeField] private GameObject Game;
    [SerializeField] private GameObject Finish;  
    [SerializeField] private GameObject Menu;
    private void Start()
    {    
    }
    void Update()
    {
        Death();
    }
    public void HPL(int HPe, bool attack)
    {
        if (attack == true)
        {
            Debug.Log("We feel damage");
            HP -= HPe;        
        }
    }
    void Death()
    {
        if (HP == 0)
        {
            Game.SetActive(false);
            Finish.SetActive(true);
            Menu.SetActive(false);
        }
    }
}
