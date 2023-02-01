using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeethSpawnerScript : MonoBehaviour
{
    [SerializeField] private GameObject toothPrefab;
    [SerializeField] private int toothCount = 10;
    [SerializeField] private Vector3 offsetDirection = Vector3.right;

    private void Awake()
    {
        for (int i = 0; i < toothCount; i++)
        {
            if (i == 0)
            {
                Instantiate(toothPrefab, this.transform);
            }
            else if (i > 0)
            {
                Instantiate(toothPrefab, transform.position + (offsetDirection * i), Quaternion.identity, this.transform);
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
