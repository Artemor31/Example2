using UnityEngine;

namespace Defence_1.Scripts
{
    public class Enemy : MonoBehaviour
    {
        public float Speed;

        private void Update()
        {
            transform.Translate(Vector3.back * (Time.deltaTime * Speed));
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<Bullet>() != null)
            {
                Destroy(other.gameObject);
                Destroy(gameObject);
            }
        }
    }
}
