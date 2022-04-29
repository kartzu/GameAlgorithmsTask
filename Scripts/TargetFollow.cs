using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TargetFollow : MonoBehaviour
{

    NavMeshAgent agent;
    public Animator animator;
    private bool moving;

    [SerializeField]
    Transform target;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        moving = false;
    }

    void Update()
    {
        agent.SetDestination(target.position);
        moving = true;
        if (moving == true)
        {
            animator.SetBool("isMoving", true);
        }

    }
}