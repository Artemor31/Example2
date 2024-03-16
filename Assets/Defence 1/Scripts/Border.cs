using System;
using UnityEngine;

namespace Defence_1.Scripts
{
    public class Border : MonoBehaviour
    {
        public event Action OnEnemyCollide;

        private void OnTriggerEnter(Collider other)
        {
            Destroy(other.gameObject);

            if (other.gameObject.GetComponent<Enemy>() == null) return;

            OnEnemyCollide?.Invoke();
        }
    }
}
