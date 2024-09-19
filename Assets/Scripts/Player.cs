using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Left Click shoot hook
        if (Input.GetMouseButtonDown(0))
        {
            ShootHook();
        }
    }

    void ShootHook()
    {
        GameManager.instance.currentHook = Instantiate(GameManager.instance.hookPrefab);

    }
}
