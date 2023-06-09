using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] Transform target;
    Ray lastRay;
    bool move;
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            MoveToCursor();
            
        }
    }

    private void MoveToCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHit = Physics.Raycast(ray, out hit);
        if(hasHit)
        {
            GetComponent<UnityEngine.AI.NavMeshAgent>().destination =   hit.point;
        }
    }
}
