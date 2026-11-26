# blocks — ARCHIVE, as found

**Status: archived exactly as recovered. Not converted to a modern Unity.**

## Provenance

Recovered from Adam Bailey's Box account (`Unity Projects/blocks`) on
2026-11-26 and uploaded file-for-file. Every file's SHA was verified
against the downloaded copy after the push. One mechanical note: GitHub's
API refuses bulk uploads to a brand-new empty repository, so the first
commit here is `blocks.sln` alone, uploaded to initialize the repo; the
second commit is the complete project exactly as it sat in Box. This
README arrived in a later commit and is one of only two files here that
aren't original (the other is `.gitignore`).

## Dating

Unity 4.x era, by the project's own evidence: UnityScript (`.js`) files —
discontinued in 2018 — Visual Studio 2008-format solution files, and no
`ProjectVersion.txt`, which this era of Unity didn't write.

## What it appears to be

A building-blocks test: `MakeBlocks.cs`, a `Block` folder of pieces, one
scene (`testing.unity`), and Unity's Standard Assets. A small, honest
experiment in making and placing blocks.

170 files, ~27 MB.

## What was left behind

Regenerable bulk was not archived: `Library/`, `obj/`, and the ReSharper
cache folder. The `.csproj` and `.sln` files ARE committed, deliberately —
they're part of the as-found state.

## Conversion

Not attempted. Opening this in a modern Unity would auto-upgrade the
project format, but the UnityScript files would need rewriting in C#
by hand. That is a separate project, for another day.
