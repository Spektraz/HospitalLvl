using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class zombieLo : MonoBehaviour
{
    private HeroLogic heroLogic;
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject enemy;
    [SerializeField] private Mesh enemyMesh;
    [SerializeField] private GameObject Hero;
    [SerializeField] private Animator enemyAnim;
    [SerializeField] private BoxCollider enemyCol;
    [SerializeField] private float distansee;
    [SerializeField] private int damage = 5;
    private NavMeshAgent Mob;
    private float timer = 1.0f;
    private bool death = true;
    private bool Attack = false;
    void Start()
    {
        Mob = GetComponent<NavMeshAgent>();
        enemyCol = GetComponent<BoxCollider>();
        heroLogic = Hero.GetComponent<HeroLogic>();
    }
    void Update()
    {
        FindHero();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "VRPlayer")
        {
            Debug.Log("GGGG");
            enemyAnim.SetBool("attackH", true);
            Attack = true;
            heroLogic.HPL(damage, Attack);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(timer);
        enemyAnim.SetBool("death", true);
        death = false;
        enemyCol.size = new Vector3(0.4107208f, 0.1f, 0.4042969f);
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("hhhh");
        enemyAnim.SetBool("attackH", false);
        Attack = false;
    }
    void FindHero()
    {
        if (death == true)
        {
            float dis = Vector3.Distance(transform.position, Hero.transform.position);
            if (dis < distansee)
            {
                enemyAnim.SetFloat("speed", 1);
                Vector3 dirPlayer = transform.position - Hero.transform.position;
                Vector3 newPos = transform.position - dirPlayer;
                Mob.SetDestination(newPos);
            }
        }
        if (death == false)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            enemy.SetActive(false);
        }
    }
}
