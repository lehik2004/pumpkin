using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IMove
{
    public void Move(float _speed, Transform _side, GameObject gmb)
    { 
        gmb.transform.position = Vector2.MoveTowards(gmb.transform.position, _side.position, _speed * Time.deltaTime);
    }
    void Start()
    {
       
    }

    void Update()
    {
        
    }
}
