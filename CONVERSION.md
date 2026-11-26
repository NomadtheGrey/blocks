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
