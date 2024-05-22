// cross-platform 2D/3D graphics in C# with the capability to dynamically adjust the refresh rate at runtime

// 1. Unity3D

void Start()
{
    // Set the target frame rate to 60 FPS
    Application.targetFrameRate = 60;
}

void Update()
{
    // Dynamically adjust frame rate based on some condition
    if (someCondition)
    {
        Application.targetFrameRate = 30;
    }
    else
    {
        Application.targetFrameRate = 60;
    }
}
// ==============




// 2. MonoGame

public class Game1 : Game
{
    GraphicsDeviceManager graphics;

    public Game1()
    {
        graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";

        // Set to false to allow manual control of frame rate
        IsFixedTimeStep = false;

        // Set the desired refresh rate
        TargetElapsedTime = TimeSpan.FromMilliseconds(16.67); // For 60 FPS
    }

    protected override void Update(GameTime gameTime)
    {
        // Dynamically adjust refresh rate based on some condition
        if (someCondition)
        {
            TargetElapsedTime = TimeSpan.FromMilliseconds(33.33); // For 30 FPS
        }
        else
        {
            TargetElapsedTime = TimeSpan.FromMilliseconds(16.67); // For 60 FPS
        }

        base.Update(gameTime);
    }
}


// ==============




// 3. Stride (formerly Xenko)
public class Game1 : Game
{
    protected override void Update()
    {
        // Dynamically adjust the frame rate
        if (someCondition)
        {
            Game.Window.IsFixedTimeStep = true;
            Game.TargetElapsedTime = TimeSpan.FromMilliseconds(33.33); // For 30 FPS
        }
        else
        {
            Game.Window.IsFixedTimeStep = false;
            Game.TargetElapsedTime = TimeSpan.FromMilliseconds(16.67); // For 60 FPS
        }

        base.Update();
    }
}


// ==============




// 4. Godot Engine (C# Bindings)

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


// ==============


