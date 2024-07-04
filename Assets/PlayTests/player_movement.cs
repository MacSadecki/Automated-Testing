using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NSubstitute;

public class player_movement
{
    [UnityTest]
    public IEnumerator with_positive_vertical_input_moves_forward()
    {
        // ARRANGE
        GameObject playerGameObject = new GameObject("Player");
        Player player = playerGameObject.AddComponent<Player>();
        player.PlayerInput = Substitute.For<IPlayerInput>();
        player.PlayerInput.Vertical.Returns(1f);

        var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.SetParent(playerGameObject.transform);
        cube.transform.localPosition = Vector3.zero;

        // ACT
        yield return new WaitForSeconds(0.5f);

        // ASSES        
        Assert.IsTrue(player.transform.position.z > 0f);
        Assert.AreEqual(0, player.transform.position.y);
        Assert.AreEqual(0, player.transform.position.x);
    }
}
