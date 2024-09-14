using Godot;
using System;

public partial class Tako : Sprite2D
{
    // ②定数の定義.
    // 移動速度.
    private const float MOVE_SPEED = 200f;

    // ③クラス変数の定義
    // 画面サイズ.
    private Rect2 _screen;

    // 移動量.
    private Vector2 _velocity;

    // ④開始処理.
    public override void _Ready()
    {
        // 画面サイズを取得.
        _screen = GetViewportRect();

        // 移動速度をランダムで決定.
        _velocity.X = (float)GD.RandRange(-1d, 1d);
        _velocity.Y = (float)GD.RandRange(-1d, 1d);

        GD.Print("_velocity: " + _velocity);
    }

    // ⑤更新.
    public override void _Process(double delta)
    {
        // 移動処理.
        Position += _velocity * MOVE_SPEED * (float)delta;

        // 画面端での跳ね返り判定.
        if (Position.X < 0)
        {
            Position = new Vector2(0, Position.Y);
            _velocity.X *= -1; // 移動量(X)を反転
        }
        if (Position.Y < 0)
        {
            Position = new Vector2(Position.X, 0);
            _velocity.Y *= -1; // 移動量(Y)を反転
        }
        if (Position.X > _screen.Size.X)
        {
            Position = new Vector2(_screen.Size.X, Position.Y);
            _velocity.X *= -1; // 移動量(X)を反転
        }
        if (Position.Y > _screen.Size.Y)
        {
            Position = new Vector2(Position.X, _screen.Size.Y);
            _velocity.Y *= -1; // 移動量(Y)を反転
        }
    }
}
