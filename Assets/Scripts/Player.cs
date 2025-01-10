using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft = 5;
    private int _numSeedsPlanted = 0;

    private void Start ()
    {
        
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.W)) //moves up when pressed W
        {
            transform.Translate(Vector3.up * _speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S)) //moves down when pressed S
        {
            transform.Translate(Vector3.down * _speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A)) //moves left when pressed A
        {
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D)) //moves right when pressed D
        {
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
        }
        
        if(Input.GetKey(KeyCode.Space) && _numSeedsLeft > 0) //if space is pressed and there are still seeds left
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        Instantiate(_plantPrefab);
        _numSeedsLeft--;
        _numSeedsPlanted++;
    }
}
