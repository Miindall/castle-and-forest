using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _rockPrefab;
    [SerializeField] private Transform _firstSpawnPoint;
    [SerializeField] private Transform _secondSpawnPoint;
    [SerializeField] private float _spawnInterval = 1;
    [SerializeField] private float _rockLifeTime = 30;

    private float _spawnTrigger;

    void Update()
    {
        if (_spawnTrigger < Time.time)
        {
            Vector3 spawnPosition;
            if (_firstSpawnPoint == null & _secondSpawnPoint == null)
            {
                spawnPosition = transform.position;
            }
            else
            {
                spawnPosition = GetRandomPointBetween(_firstSpawnPoint.position, _secondSpawnPoint.position);
            }
            Destroy(
                Instantiate(
                    _rockPrefab,
                    spawnPosition,
                    _rockPrefab.transform.rotation),
                _rockLifeTime);
            _spawnTrigger = Time.time + _spawnInterval;
        }
    }

    private Vector3 GetRandomPointBetween(Vector3 firstPoint, Vector3 secondPoint)
    {
        return new Vector3(
            GetRandomBetween(firstPoint.x, secondPoint.x),
            GetRandomBetween(firstPoint.y, secondPoint.y),
            GetRandomBetween(firstPoint.z, secondPoint.z));
    }

    private float GetRandomBetween(float first, float second)
    {
        float rezult;
        if (first < second)
        {
            rezult = Random.Range(first, second);
        }
        else
        {
            rezult = Random.Range(second, first);
        }
        return rezult;
    }
}
