﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{/// <summary>
/// created by andrew viney
/// test that the obsticels basic features work correctly
/// remeber to find remove for testing comments in relevent classes
/// </summary>
    public class editModeObsticles
    {
        // A Test behaves as an ordinary method
        [Test]
        public void obstaclesSpawn()
        {
            GameObject gameObject = MonoBehaviour.Instantiate(Resources.Load<GameObject>("ObstaclesPreFab"));
            Obstacles ob = gameObject.GetComponent<Obstacles>();
            int startHealth = ob.getHealth();
            Assert.AreEqual(startHealth, 10);
        }

        [Test]
        public void obstaclesReduce()
        {
            GameObject gameObject = MonoBehaviour.Instantiate(Resources.Load<GameObject>("ObstaclesPreFab"));
            Obstacles ob = gameObject.GetComponent<Obstacles>();
            int startHealth = ob.getHealth();
            ob.reduceHealth(1);
            Assert.AreEqual(ob.getHealth(), startHealth-1);
        }

        }
}
