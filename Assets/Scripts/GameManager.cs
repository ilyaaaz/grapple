using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Player")]
    public GameObject player;
    public GameObject hookPrefab;
    public GameObject ropePrefab;
    [HideInInspector] public GameObject currentHook;

    [Header("Hook")]
    public bool hookOut;
    public bool isHooked;

    [Header("Animation")]
    public Animator tree;
    public Animator weird;
    

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        InitializeGame();
    }

    // Update is called once per frame
    void Update()
    {
        //check if currentHook exist
        if (!currentHook)
        {
            hookOut = false;
            isHooked = false;
        }
    }

    //set all the default variables
    void InitializeGame()
    {
        isHooked = false;
        hookOut = false;
    }

    public Vector3 getMousePos()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        return mousePos;
    }


}
