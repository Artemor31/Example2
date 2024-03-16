using System;
using UnityEngine;

namespace Defence_1.Scripts
{
    public class Border : MonoBehaviour
    {
        public event Action OnEnemyCollide;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<Enemy>() != null)
            {
                OnEnemyCollide?.Invoke();
            }

            Destroy(other.gameObject);
        }
    }
}
