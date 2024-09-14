using Godot;
using System;

public partial class Explosion : Sprite2D
{
    private const int PATTERNS_COUNT = 37; // パターン数
    private const int PATTERNS_IN_SEC = 37 * 2; // 1秒間に表示するパターン数

    // 経過時間
    private float _elapsedTime = 0;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        _elapsedTime += (float)delta;
        Frame = (int)(_elapsedTime * PATTERNS_IN_SEC);

        if (Frame > PATTERNS_COUNT) {
            QueueFree();
        }
    }
}
