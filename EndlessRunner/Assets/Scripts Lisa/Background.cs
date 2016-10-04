using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {

    [SerializeField]
    private float _speed; //The speed with wich it scrolls
    private Vector3 _newPos = new Vector3(50, 0, 0); //The position where it spawns

    void Update()
    {
        //Makes stuff scroll to the left
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
    }

    void OnBecameInvisible()
    {
        //Makes it spawn again when it isn't visible anymore
        transform.position += _newPos;
    }
}
