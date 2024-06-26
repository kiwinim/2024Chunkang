using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawn : MonoBehaviour
{
    public Transform BossSpawnPoint;

    void Start()
    {
        BossStart();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.U))
        {
            BossStart();
        }
    }
    void BossStart()
    {
        var BosstGo = ObjectPoolManager.instance.GetGo("Boss");
        BosstGo.transform.position = this.BossSpawnPoint.position;
    }
}
