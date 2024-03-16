using UnityEngine;

namespace PlatformWithSphere.Platform
{
    public class PlaneScript : MonoBehaviour
    {
        public GameObject _sphere;

        private void Update()
        {
            float hor = Input.GetAxis("Horizontal");
            float vert = Input.GetAxis("Vertical");

            gameObject.transform.Rotate(new Vector3(vert / 5, 0, hor / 5));

            if (_sphere.transform.position.y < -6)
            {
                _sphere.transform.position = Vector3.zero;
            }
        }
    }
}
