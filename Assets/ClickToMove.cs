using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToMove : MonoBehaviour
{
    private Animator animator;
    private UnityEngine.AI.NavMeshAgent  meshAgent;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        meshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

        }
    }
}
