using UnityEngine;
using UnityEditor;
using NUnit.Framework;

public class NewEditorTest {

    [Test]
    public void EditorTest()
    {
        //Arrange
        var gameObject = new GameObject();

        //Act
        //Try to rename the GameObject
        var newGameObjectName = "My game object";
        gameObject.name = newGameObjectName;

        //Assert
        //The object has a new name
        Assert.AreEqual(newGameObjectName, gameObject.name);
    }

	[Test]
	public void IcicleTest()
	{
		var icicle = new GameObject();
		icicle.AddComponent<IcicleBehavior>();
		icicle.AddComponent<Rigidbody>();

		var iceComp = icicle.GetComponent<IcicleBehavior>();

		var speed = 10f;
		var down10 = iceComp.getVelocity(speed);
		var endVector = new Vector2(0, -speed) * 10;

		Assert.AreEqual(endVector, down10);
	}
}
