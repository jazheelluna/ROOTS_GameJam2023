using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeethSpawnerScript : MonoBehaviour
{
    [SerializeField] private bool isTopTeeth;
    [SerializeField] private GameObject toothPrefab;
    [SerializeField] private int toothCount = 10;
    [SerializeField] private Vector3 offsetDirection = Vector3.right;

    private Quaternion rot = Quaternion.identity;

    private void Awake()
    {
        if (isTopTeeth)
        {
            rot = Quaternion.Euler(new Vector3(0, 0, 180));
        }

        for (int i = 0; i < toothCount; i++)
        {
            if (i == 0)
            {
                Instantiate(toothPrefab, transform.position, rot, this.transform);
            }
            else if (i > 0)
            {
                Instantiate(toothPrefab, transform.position + (offsetDirection * i), rot, this.transform);
            }
        }
    }

    private void OnDrawGizmos()
    {
        for (int i = 0; i < toothCount; i++)
        {
            if (i == 0)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawWireSphere(transform.position, 0.1f);
            }
            else if (i > 0)
            {
                Gizmos.color = Color.white;
                Gizmos.DrawWireSphere(transform.position + (offsetDirection * i), 0.05f);
            }
        }
    }
}
