using UnityEngine;

namespace Defence_1.Scripts
{
    public class Bullet : MonoBehaviour
    {
        public float Speed;

        private void Update()
        {
            transform.Translate(Vector3.forward * (Time.deltaTime * Speed));
        }
    }
}
