using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool Startmove = true;
    public bool pattern1 = false;
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void Phase1()
    {
        Startmove = false;
        pattern1 = true; 
    }
}
