using System.Collections;
using NSubstitute;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class player
{
    [UnityTest]
    public IEnumerator has_rigidbody_component_attached()
    {
        // ARRANGE
        GameObject playerGameObject = new GameObject("Player");
        Player player = playerGameObject.AddComponent<Player>();
        player.PlayerInput = Substitute.For<IPlayerInput>();        

        // ACT
        yield return new WaitForSeconds(0.1f);

        // ASSES        
        Assert.NotNull(player.GetComponent<Rigidbody>());
    }
}
