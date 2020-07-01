﻿using UnityEngine;

public class MistReducer : MonoBehaviour
{
    private ParticleSystem mist;
    private bool _reducing;
    [SerializeField]private float mistReducingSpeed = 0.7f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            MistDown();
    }
    private void Start()
    {
        mist = this.GetComponent<ParticleSystem>();
    }

    public void MistDown()
    {
        var em = mist.emission;
        var main = mist.main;
        em.enabled = false;
        main.simulationSpeed = mistReducingSpeed;
    }
}
