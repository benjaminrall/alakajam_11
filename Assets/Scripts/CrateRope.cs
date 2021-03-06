﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateRope : InteractableObject
{

    public Rigidbody crate;

    public override void ActivateToggle()
    {
        if (!active) active = true;
        else
        {
            gameObject.SetActive(false);
            crate.constraints = RigidbodyConstraints.None;
            crate.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionZ;
        }
    }
}
