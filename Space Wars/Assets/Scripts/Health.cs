using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{


    public GameObject deathParticlesPrefab = null;
    private Transform theTransform = null;
    public bool shouldBeDestroyedOnDeath = true;
    public bool shouldShowGameOverOnDeath = false;
    public bool showHealthBar = false;
    public LinearIndicator linearIndicator = null;

    public float minValue, maxValue;
    public float currentValue;

    public float healthPoints
    {
        get
        {
            return _healthPoints; 
        }

        set
        {
            _healthPoints = value;

            if(_healthPoints <= 0)
            {
                SendMessage("Die", SendMessageOptions.DontRequireReceiver);
                
                if (deathParticlesPrefab != null)
                {
                    Instantiate(deathParticlesPrefab, theTransform.position, theTransform.rotation);
                    if (shouldBeDestroyedOnDeath)
                    {
                        Destroy (gameObject);
                    }
                }


                if (shouldShowGameOverOnDeath)
                {
                    GameController.GameOver();
                }
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        theTransform = GetComponent<Transform>();
        linearIndicator.SetupIndicator(minValue, maxValue);
    }
9
    void FixedUpdate()
    {
        if (showHealthBar)
        {
            currentValue = healthPoints;
            linearIndicator.SetValue(currentValue);

        }
    }
    [SerializeField]

    public float _healthPoints = 100.0f;



}
