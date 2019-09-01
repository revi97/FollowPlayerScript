using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform follow;
    public Vector3 offset;


    void Update()
    {

        transform.position = follow.position + offset;
    }
}
