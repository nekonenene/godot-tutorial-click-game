using Godot;
using System;
using System.Linq;

public partial class Main : Node2D
{
    private Label _label;
    private Boolean _isGameEnd = false;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        _label = GetNode<Label>("ClearLabel");
        _label.Visible = false;
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        if (_isGameEnd)
        {
            return;
        }

        // Tako という文字が含まれるノードの個数を取得
        int takoCount = GetChildren().Where(node => node.Name.ToString().Contains("Tako")).Count();
        if (takoCount == 0)
        {
            _label.Visible = true;
            _isGameEnd = true;
        }
    }
}
