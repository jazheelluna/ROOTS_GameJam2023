using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlaneManager : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tooth"))
        {
            gameManager.score += other.GetComponent<ToothManager>().toothValue;
            Destroy(other.gameObject);
        }
    }
}
