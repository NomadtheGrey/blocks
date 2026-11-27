# Conversion log

Status: **not started.**

The as-found Unity 4.x project lives in `old/` (also tagged `as-found` at
the commit that holds it in its original layout). The modern transcription
will be built at this repository root: a fresh current-Unity project whose
assets and scripts are transcribed from `old/` as needed.

Rules of the transcription:

- `old/` is never edited. It is the reference, not a workspace.
- Nothing is copied blindly: each asset or script that crosses over is
  noted here, with anything that was dropped or rewritten and why.
- Done means: opens with zero console errors, the main scene plays,
  and a build runs.

- 2026-11-27 (meta heal) - Generated .meta files with ORIGINAL Unity 4 GUIDs recovered from the Box Library `guidmapper` for 193/193 assets under the root copy's `Assets/` (0 without a recovered GUID; 0 orphan guidmapper entries with no asset in the archive). Importer blocks are minimal defaults (folders: folderAsset, scripts: MonoImporter, textures/models/audio: default importer settings), so import settings revert to defaults on first import - the GUIDs are the heal. No .cs files touched, nothing under `old/` touched. To use: pull, delete the local `Library/` folder, reopen in Unity, and count healed vs still-Missing references.
