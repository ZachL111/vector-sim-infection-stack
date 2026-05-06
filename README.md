# vector-sim-infection-stack

`vector-sim-infection-stack` is a compact C# repository for simulations, centered on this goal: Create a C# reference implementation for infection workflows, centered on resource planning, capacity fixtures, and allocation and spill reports.

## Why This Exists

The point is to make a small domain rule concrete enough that a reader can change it and immediately see what broke.

## Vector Sim Infection Stack Review Notes

For a quick review, compare `decision risk` with `state drift` before reading the middle cases.

## Capabilities

- `fixtures/domain_review.csv` adds cases for input pressure and state drift.
- `metadata/domain-review.json` records the same cases in structured form.
- `config/review-profile.json` captures the read order and the two review questions.
- `examples/vector-sim-infection-walkthrough.md` walks through the case spread.
- The C# code includes a review path for `decision risk` and `state drift`.
- `docs/field-notes.md` explains the strongest and weakest cases.

## Implementation Shape

The fixture data drives the tests. The code stays thin, while `metadata/domain-review.json` and `config/review-profile.json` explain what each case is meant to protect.

The C# code keeps the review rule close to the tests.

## Local Usage

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

## Verification

The check exercises the source code and the review fixture. `recovery` is the high score at 224; `stress` is the low score at 121.

## Roadmap

The repository is intentionally scoped to local checks. I would expand it by adding adversarial fixtures before adding features.
