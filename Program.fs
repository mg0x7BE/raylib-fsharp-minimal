#nowarn "3391"

open Raylib_cs
open System.Numerics

let draw (camera: Camera3D) (angle: float32) =
    Raylib.BeginDrawing()
    Raylib.ClearBackground(Color.Black)
    Raylib.BeginMode3D(camera)
    Rlgl.PushMatrix()
    Rlgl.Rotatef(angle, 1.0f, 1.0f, 0.0f)
    Raylib.DrawCubeWiresV(Vector3.Zero, Vector3.One * 1.3f, Color.Purple)
    Rlgl.PopMatrix()
    Raylib.EndMode3D()

    Raylib.DrawFPS(10,10);
    Raylib.EndDrawing()

let update (angle: float32) =
    let deltaTime = Raylib.GetFrameTime()
    (angle + 50.0f * deltaTime) % 360.0f

let rec gameLoop (camera: Camera3D) (angle: float32) =
    if not (Raylib.WindowShouldClose()) then
        let newAngle = update angle
        draw camera newAngle
        gameLoop camera newAngle

Raylib.InitWindow(800, 600, "Demo")
Raylib.SetTargetFPS(120)

let camera = Camera3D(
    Position = Vector3(0.0f, 0.0f, 2.0f),
    Target = Vector3.Zero,
    Up = Vector3.UnitY,
    FovY = 90.0f,
    Projection = CameraProjection.Perspective)

gameLoop camera 0.0f

Raylib.CloseWindow()