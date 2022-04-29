using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{

    NavMeshAgent agentPlayer;
    public Animator animator;
    private bool moving;

    private void Start()
    {
        agentPlayer = GetComponent<NavMeshAgent>();
        moving = false;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            moving = true;
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                agentPlayer.SetDestination(hit.point);
                agentPlayer.speed = 5f;

                if(moving == true)
                {
                    animator.SetBool("isMoving", true);
                }
            }
        }
    }
}
