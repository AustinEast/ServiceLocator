using Services;
using Services.ExampleServices;
using UnityEngine;

public class Test : MonoBehaviour
{

    void Start()
    { 
        Debug.Log(ServiceLocator.IsRegistered<EnemyManager>());
        Debug.Log(ServiceLocator.IsRegistered<DifficultyManager>());
    }


}
