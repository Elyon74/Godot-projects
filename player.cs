using Godot;
using System;
using System.Collections;
using System.Collections.Generic;
public class player : Sprite
{
    public int Life = 3;
    public int Rocket = 4;
    public int Speed = 250;
    public CollisionShape2D collisionShape2D;
    public Vector2 velocity;
    public Vector2 screensize;

    // Void start
    public override void _Ready()
    {
        screensize = GetViewportRect().Size;
        collisionShape2D = (CollisionShape2D)GetNode("CollisionShape2D");
    }

    //  Void update
    public override void _Process(float delta)
    {
        velocity = new Vector2();
        if (Input.IsActionPressed("ui_left"))
        {
            velocity.x -= 1;
        }
        if (Input.IsActionPressed("ui_right"))
        {
            velocity.x += 1;
        }
        if (Input.IsActionPressed("ui_up"))
        {
            velocity.y -= 1;
        }
        if (Input.IsActionPressed("ui_down"))
        {
            velocity.y += 1;
        }
        if (velocity.Length() > 0)
        {
            velocity = velocity.Normalized() * Speed;
        }

        Position += velocity * delta;
    }

}
