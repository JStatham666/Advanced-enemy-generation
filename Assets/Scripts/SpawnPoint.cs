using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    //[SerializeField] private Vector3 _direction;
    [SerializeField] private WayPoint _wayPoint;

    public void Create()
    {
        Enemy enemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
        enemy.Init(_wayPoint);
    }
}