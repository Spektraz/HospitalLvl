using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(PlayerCharacter))]
[RequireComponent(typeof(InventoryManager))]
public class Managers : MonoBehaviour
{
    public static PlayerCharacter Player { get; private set; }
    public static InventoryManager Inventiry { get; private set; }
    private List<IGameManager1> _startSequire;
    void Awake()
    {
        Player = GetComponent<PlayerCharacter>();
        Inventiry = GetComponent<InventoryManager>();
        _startSequire = new List<IGameManager1>();
        _startSequire.Add(Player);
        _startSequire.Add(Inventiry);
        StartCoroutine(StartupManagers());
    }
    private IEnumerator StartupManagers()
    {
        foreach (IGameManager1 manager in _startSequire)
        {
            manager.Startup();
        }
        yield return null;
        int numModules = _startSequire.Count;
        int numReady = 0;
        while (numReady < numModules)
        {
            int lastReady = numReady;
            numReady = 0;
            foreach (IGameManager1 manager in _startSequire)
            {
                if (manager.status == ManagerStatus.Started)
                {
                    numReady++;
                }
            }
            if (numReady > lastReady)
                Debug.Log("Progress: " + numReady + "/" + numModules);
            yield return null;
        }
        Debug.Log("All managers started up");
    }
}