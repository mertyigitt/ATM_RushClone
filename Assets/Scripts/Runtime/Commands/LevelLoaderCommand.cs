using Runtime.Interfaces;
using Runtime.Managers;
using Unity.VisualScripting;
using UnityEngine;

namespace Runtime.Commands
{
    public class LevelLoaderCommand : ICommand
    {
        private readonly LevelManager _levelManager;

        public LevelLoaderCommand(LevelManager levelManager)
        {
            _levelManager = levelManager;
        }

        public void Execute(byte parameter)
        {
            var resourceRequest = Resources.LoadAsync<GameObject>($"Prefabs/LevelPrefabs/level {parameter}");
            resourceRequest.completed += operation =>
            {
                var newLevel = Object.Instantiate(resourceRequest.asset.GameObject(),
                    Vector3.zero, Quaternion.identity);
                if (newLevel != null) newLevel.transform.SetParent(_levelManager.levelHolder.transform);
            };
        }

        public void Execute(int parameter)
        {
            
        }

        public void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}