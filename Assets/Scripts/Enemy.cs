using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private WayPoint _wayPoint;

    public void Init(WayPoint wayPoint) =>
        _wayPoint = wayPoint;

    private void Update() =>
        Move();

    private void Move() => 
        transform.position = Vector3.MoveTowards(transform.position, _wayPoint.transform.position, _speed * Time.deltaTime);             
}