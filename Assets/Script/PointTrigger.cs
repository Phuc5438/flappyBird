using System;
using UnityEngine;

public class PointTrigger : MonoBehaviour
{
    private bool hasScored = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!hasScored && other.gameObject.CompareTag("Player"))
        {
            hasScored = true;
            GameManager.Instance.AddScore(1);
        }
    }
}
