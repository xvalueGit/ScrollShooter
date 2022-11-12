using System;
using System.Collections.Generic;
using Enemy;
using UnityEngine;

namespace Systems.Level
{
    [Serializable]
    public class LevelStage
    {
        [SerializeField] private int duration;
        public int Duration => duration;
        
        [SerializeField, Range(0, 10)] private float spawnRate;
        public float SpawnRate => spawnRate;
        
        [SerializeField] private List<EnemyLevelSettings> enemies;
        public List<EnemyLevelSettings> Enemies => enemies;
    }
}