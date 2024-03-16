using UnityEngine;

namespace Defence_1.Scripts
{
    public class PlatformMover : MonoBehaviour
    {
        public float Speed;
        public float JumpPower;
        public Rigidbody Rigidbody;
        
        private void Update()
        {
            float hor = Input.GetAxis("Horizontal");
            float ver = Input.GetAxis("Vertical");

            transform.Translate(new Vector3(hor, 0, ver) * (Time.deltaTime * Speed));

            if (Input.GetKeyUp(KeyCode.Space))
            {
                Rigidbody.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
            }
        }
    }
}
