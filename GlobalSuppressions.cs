// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Correctness", "UNT0013:Remove invalid SerializeField attribute", Justification = "<In sospeso>", Scope = "member", Target = "~F:CameraMovement.mouseSense")]
[assembly: SuppressMessage("Performance", "UNT0024:Give priority to scalar calculations over vector calculations", Justification = "<In sospeso>", Scope = "member", Target = "~M:CameraMovement.Update")]
[assembly: SuppressMessage("Performance", "UNT0024:Give priority to scalar calculations over vector calculations", Justification = "<In sospeso>", Scope = "member", Target = "~M:Movement.FixedUpdate")]
