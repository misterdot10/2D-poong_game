//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    public float speed = 10.0f;
    protected Rigidbody2D _rigidbody;
    private void Awake(){
      _rigidbody = GetComponent<Rigidbody2D>();
    }
}
