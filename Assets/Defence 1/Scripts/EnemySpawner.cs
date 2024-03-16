using UnityEngine;

namespace Defence_1.Scripts
{
    public class EnemySpawner : MonoBehaviour
    {
        public Enemy Enemy;
        public float Delay;

        private float _timer;

        private void Start()
        {
            _timer = Delay;
        }

        private void Update()
        {
            _timer -= Time.deltaTime;

            if (_timer <= 0)
            {
                _timer = Delay;

                int x = Random.Range(-14, 14);
                int y = Random.Range(0, 2) == 0 ? 1 : 5;

                Vector3Int position = new Vector3Int(x, y, 30);
                Enemy clone = Instantiate(Enemy, position, Quaternion.identity);
            }
        }
    }
}
