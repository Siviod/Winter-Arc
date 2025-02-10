using UnityEngine;

public class Spin : MonoBehaviour
{
[SerializeField] float zSpin = 1;
[SerializeField] float xSpin = 1;
[SerializeField] float ySpin = 1;

    void Update()
    {
        transform.Rotate(zSpin, xSpin, ySpin);
    }
}
