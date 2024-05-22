public override void _Process(float delta)
{
    // Control the frame rate dynamically
    if (someCondition)
    {
        Engine.TargetFps = 30;
    }
    else
    {
        Engine.TargetFps = 60;
    }
}
